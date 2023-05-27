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
    public partial class FormulaireReservation : Form
    {
        private readonly Reservation _parent;
        public string id, nbrPersonnes, numeroTable, date, nomClient;
        public FormulaireReservation(Reservation parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfoReservation()
        {
            lblTextFormReservation.Text = "Mettre à jour réservation";
            btnSaveReservation.Text = "Mettre à jour";
            txtPersonnes.Text = nbrPersonnes;
            txtTable.Text = numeroTable;
            txtDate.Text = date;
            txtClient.Text = nomClient;
        }

        private void btnSaveReservation_Click_1(object sender, EventArgs e)
        {
            if (txtPersonnes.Text.Trim().Length == 0)
            {
                MessageBox.Show("Nombre de personnes est vide.", "Champ manquant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTable.Text.Trim().Length == 0)
            {
                MessageBox.Show("Numero de table est vide.", "Champ manquant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDate.Text.Trim().Length == 0)
            {
                MessageBox.Show("La date est vide.", "Champ manquant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtClient.Text.Trim().Length == 0)
            {
                MessageBox.Show("Nom du client est vide.", "Champ manquant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (btnSaveReservation.Text == "Ajouter")
            {
                ReservationClass reservation = new ReservationClass(txtPersonnes.Text.Trim(), txtTable.Text.Trim(), txtDate.Text.Trim(), txtClient.Text.Trim());
                DbReservation.AddReservation(reservation);
                Clear();
            }
            if (btnSaveReservation.Text == "Mettre à jour")
            {
                ReservationClass reservation = new ReservationClass(txtPersonnes.Text.Trim(), txtTable.Text.Trim(), txtDate.Text.Trim(), txtClient.Text.Trim());
                DbReservation.UpdateReservation(reservation, id);
            }
            _parent.Display();
        }

        public void  SaveReservationInfo()
        {
            lblTextFormReservation.Text = "Ajouter une réservation";
            btnSaveReservation.Text = "Ajouter";
        }

        public void Clear()
        {
            txtPersonnes.Text = txtTable.Text = txtDate.Text = txtClient.Text = string.Empty;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveReservation_Click(object sender, EventArgs e)
        {
          
        }
    }
}
    