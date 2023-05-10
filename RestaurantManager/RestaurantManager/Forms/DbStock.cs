using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager.Forms
{
    internal class DbStock :DbRestaurationManager
    {
        public static void AddStock(StockClass ingred)
        {
            string sql = "INSERT INTO `ingredients` (`nomIngredient`, `stock`, `categorieIngredient`) VALUES (@NomIngredient,@StockIngredient, @CategorieIngredient)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@NomIngredient", MySqlDbType.VarChar).Value = ingred.nomIngredient;
            cmd.Parameters.Add("@StockIngredient", MySqlDbType.VarChar).Value = ingred.stock;
            cmd.Parameters.Add("@CategorieIngredient", MySqlDbType.VarChar).Value = ingred.categorieIngredient;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ingrédient ajouté avec succes.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ingrédient non ajouté. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateStock(StockClass ingred, string id)
        {
            string sql = "UPDATE `ingredients` SET nomIngredient = @NomIngredient , stock = @StockIngredient, categorieIngredient = @CategorieIngredient WHERE id = @IngredientID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IngredientID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@NomIngredient", MySqlDbType.VarChar).Value = ingred.nomIngredient;
            cmd.Parameters.Add("@StockIngredient", MySqlDbType.VarChar).Value = ingred.stock;
            cmd.Parameters.Add("@CategorieIngredient", MySqlDbType.VarChar).Value = ingred.categorieIngredient;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Elément mis à jour avec succes.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Elément non mis à jour. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DeleteStock(string id)
        {
            string sql = "DELETE FROM `ingredients`  WHERE id = @IngredientID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IngredientID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Elément suprimé avec succes.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Elément non suprimé. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DisplayAndSearchStock(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tblStock = new DataTable();
            adp.Fill(tblStock);
            dgv.DataSource = tblStock;
            con.Close();
        }
    }
}
