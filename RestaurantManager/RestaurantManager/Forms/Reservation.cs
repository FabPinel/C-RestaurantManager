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
        public Reservation()
        {
            InitializeComponent();
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
            FormulaireReservation form = new FormulaireReservation(this);
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
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Voulez-vous supprimer cette réservation ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes) ;
                {
                    DbReservation.DeleteReservation(dataGridViewReservation.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
