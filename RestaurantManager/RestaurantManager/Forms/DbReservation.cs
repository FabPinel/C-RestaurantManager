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
    internal class DbReservation : DbRestaurationManager
    {
        public static void AddReservation(ReservationClass res)
        {
            string sql = "INSERT INTO `reservation` (`nbPersonnes`, `tableReserve`, `dateReserve`, `clientReserve`) VALUES (@ReservationPersonnes, @ReservationTable, @ReservationDate, @ReservationClient)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ReservationPersonnes", MySqlDbType.VarChar).Value = res.nbrPersonnes;
            cmd.Parameters.Add("@ReservationTable", MySqlDbType.VarChar).Value = res.numeroTable;
            cmd.Parameters.Add("@ReservationDate", MySqlDbType.VarChar).Value = res.date;
            cmd.Parameters.Add("@ReservationClient", MySqlDbType.VarChar).Value = res.nomClient;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Réservation ajoutée avec succes.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Réservation non ajoutée. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateReservation(ReservationClass res, string id)
        {
            string sql = "UPDATE `reservation` SET nbPersonnes = @ReservationPersonnes , tableReserve = @ReservationTable, dateReserve = @ReservationDate, clientReserve = @ReservationClient WHERE idReservation = @ReservationID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ReservationID", MySqlDbType.VarChar).Value =id;
            cmd.Parameters.Add("@ReservationPersonnes", MySqlDbType.VarChar).Value = res.nbrPersonnes;
            cmd.Parameters.Add("@ReservationTable", MySqlDbType.VarChar).Value = res.numeroTable;
            cmd.Parameters.Add("@ReservationDate", MySqlDbType.VarChar).Value = res.date;
            cmd.Parameters.Add("@ReservationClient", MySqlDbType.VarChar).Value = res.nomClient;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Réservation mise à jour avec succes.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Réservation non mise à jour. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DeleteReservation(string id)
        {
            string sql = "DELETE FROM `reservation`  WHERE idReservation = @ReservationID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ReservationID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Réservation suprimée avec succes.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Réservation non suprimée. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DisplayAndSearchReservation(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }
    }
}
