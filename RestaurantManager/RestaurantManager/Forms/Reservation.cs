using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager.Forms
{
    public partial class Reservation : Form
    {
        FormulaireReservation form;
        public Reservation()
        {
            InitializeComponent();
            form = new FormulaireReservation(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void Display()
        {
            DbReservation.DisplayAndSearchReservation("SELECT * FROM reservation", dataGridViewReservation);
        }

        private void btnAjouterReservation_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveReservationInfo();
            form.ShowDialog();
        }

        private void Reservation_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void textSearchReservation_TextChanged(object sender, EventArgs e)
        {
            DbReservation.DisplayAndSearchReservation("SELECT * FROM reservation WHERE clientReserve LIKE '%"+ txtSearchReservation.Text + "%'", dataGridViewReservation);
        }

        private void dataGridViewReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                return;
            }
            if(e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Voulez-vous supprimer cette réservation ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes);
                {
                    DbReservation.DeleteReservation(dataGridViewReservation.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void dataGridViewReservation_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //EDIT
                form.Clear();
                form.id = dataGridViewReservation.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.nbrPersonnes = dataGridViewReservation.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.numeroTable = dataGridViewReservation.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.date = dataGridViewReservation.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.nomClient = dataGridViewReservation.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.UpdateInfoReservation();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                //DELETE
                if (MessageBox.Show("Voulez-vous supprimer cette réservation ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbReservation.DeleteReservation(dataGridViewReservation.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
