using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Forms
{
    public struct RevennueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
    internal class DasboardStat : DbConnectionDashboard
    {
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public long NumCustomers { get; private set; }
        public long NumProducts { get; private set; }

        public long NumSuppliers { get; private set; }

        public List<KeyValuePair<string, int>> TopProductList { get; private set; }
        public List<KeyValuePair<string, int>> UnderStockList { get; private set; }
        public List<RevennueByDate> GrossRevennueList { get; private set; }
        public long NumOrders { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfit { get; set; }

        //constructor
        public DasboardStat()
        {

        }

        //private methods
        private void GetNumberItems()
        {
            using(var connection=GetConnection())
            {
                connection.Open();
                using(var command=new MySqlCommand())
                {
                    command.Connection = connection;
                    //Get total number of Customers
                    command.CommandText = "SELECT count(id)  FROM clients";
                    NumCustomers = (long)command.ExecuteScalar();

                    //Get total number of Supplier
                    command.CommandText = "SELECT count(id)  FROM fournisseurs";
                    NumSuppliers = (long)command.ExecuteScalar();

                    //Get total number of product
                    command.CommandText = "SELECT count(idPlat)  FROM plats";
                    NumProducts = (long)command.ExecuteScalar();

                    //Get total number of order
                    command.CommandText = @"SELECT count(numeroCommande)  FROM commandestables WHERE dateCommande between @fromDate and @toDate";
                    command.Parameters.Add("@fromDate", MySqlDbType.DateTime).Value=startDate;
                    command.Parameters.Add("@toDate", MySqlDbType.DateTime).Value = endDate;
                    NumOrders = (long)command.ExecuteScalar();
                }
            }
        }
        private void GetOrderAnalisys()
        {
            GrossRevennueList = new List<RevennueByDate>();
            TotalProfit = 0;
            TotalRevenue = 0;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT dateCommande, sum(prixPlat) FROM commandestables cmd
                                            INNER JOIN contenircommandes ccmd
                                            ON cmd.numeroCommande = ccmd.commande
                                            INNER JOIN plats p
                                            ON p.nomPlat = ccmd.platCommande
                                            WHERE dateCommande BETWEEN @fromDate and @toDate
                                            GROUP BY dateCommande";
                    command.Parameters.Add("@fromDate", MySqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", MySqlDbType.DateTime).Value = endDate;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        resultTable.Add(
                            new KeyValuePair<DateTime, decimal>((DateTime)reader[0], Convert.ToDecimal(reader[1]))
                            );
                        TotalRevenue += reader.GetDecimal(1);
                    }
                    TotalProfit = TotalRevenue * 0.2m;//20% de profit
                    reader.Close();

                    //Group by Days 
                    if (numberDays <30 )
                    {
                        foreach(var item in resultTable)
                        {
                            GrossRevennueList.Add(new RevennueByDate()
                            {
                                Date = item.Key.ToString("dd MM"),
                                TotalAmount=item.Value
                            });
                        }
                    }

                    //Group by Weeks
                    else if (numberDays <92 )
                    {
                        GrossRevennueList = (from orderList in resultTable
                                             group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                            orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into order
                                             select new RevennueByDate
                                             {
                                                 Date = "Week" + order.Key.ToString(),
                                                 TotalAmount = order.Sum(amount => amount.Value)
                                             }).ToList();
                    }

                    //Group by Months
                    else if (numberDays < (365*2))
                    {
                        bool isYear = numberDays < 365 ? true : false;
                        GrossRevennueList = (from orderList in resultTable
                                             group orderList by orderList.Key.ToString("MMM yyyy")
                                           into order
                                             select new RevennueByDate
                                             {
                                                 Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")):order.Key,
                                                 TotalAmount = order.Sum(amount => amount.Value)
                                             }).ToList();
                    }

                    //Group by years 
                    else
                    {
                        GrossRevennueList = (from orderList in resultTable
                                             group orderList by orderList.Key.ToString("yyyy")
                                           into order
                                             select new RevennueByDate
                                             {
                                                 Date = order.Key,
                                                 TotalAmount = order.Sum(amount => amount.Value)
                                             }).ToList();
                    }
                }
            }
        }
        private void GetProductAnalisys()
        {
            TopProductList = new List<KeyValuePair<string, int>>();
            UnderStockList = new List<KeyValuePair<string, int>>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    MySqlDataReader reader;
                    command.Connection = connection;
                    //Get top 5 Products
                    command.CommandText = @"SELECT p.nomPlat, dateCommande , sum(quantitePlat) as q FROM commandestables cmd INNER JOIN contenircommandes ccmd ON cmd.numeroCommande = ccmd.commande INNER JOIN plats p ON p.nomPlat = ccmd.platCommande WHERE dateCommande between @fromDate AND @toDate GROUP BY p.nomPlat ORDER BY q DESC LIMIT 5";
                    command.Parameters.Add("@fromDate", MySqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", MySqlDbType.DateTime).Value = endDate;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TopProductList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)(decimal)reader[2]));
                    }
                    reader.Close();

                    //Get underStock product 
                    command.CommandText = @"SELECT nomIngredient, stock FROM ingredients WHERE stock <= 10";
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        UnderStockList.Add(new KeyValuePair<string, int>(reader[0].ToString(), reader.GetInt32(1)));
                    }
                    reader.Close();
                }
            }
        }

        //public methods
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, endDate.Hour,endDate.Minute,59); 
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                GetNumberItems();
                GetOrderAnalisys();
                GetProductAnalisys();
                Console.WriteLine("Data refreshed with succes: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed , same query: {0} - {1}", startDate.ToString(),endDate.ToString());
                return false;
            }

        }
    }
}

