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
    public partial class FormulaireStock : Form
    {
        private readonly Stock _parent;
        public string id, ingredient, stock, categorie;

        public FormulaireStock(Stock parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfoStock()
        {
            lblTextFormStock.Text = "Mettre à jour élément";
            btnSaveStock.Text = "Mettre à jour";
            txtIdStock.Text = id;
            txtIngredient.Text = ingredient;
            txtStock.Text = stock;
            txtCategorie.Text = categorie;
        }

        public void SaveStockInfo()
        {
            lblTextFormStock.Text = "Ajouter un stock";
            btnSaveStock.Text = "Ajouter";
        }

        public void Clear()
        {
            txtIngredient.Text = txtStock.Text = txtCategorie.Text = string.Empty;
        }

        private void btnSaveStock_Click(object sender, EventArgs e)
        {
            if (txtIngredient.Text.Trim().Length == 0)
            {
                MessageBox.Show("Le nom de l'ingrédient est vide.", "Champ manquant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtStock.Text.Trim().Length == 0)
            {
                MessageBox.Show("La quantité est vide.", "Champ manquant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (btnSaveStock.Text == "Ajouter")
            {
                StockClass ingredient = new StockClass(txtIngredient.Text.Trim(), txtStock.Text.Trim(), txtCategorie.Text.Trim());
                DbStock.AddStock(ingredient);
                Clear();
            }
            if (btnSaveStock.Text == "Mettre à jour")
            {
                StockClass ingredient = new StockClass(txtIngredient.Text.Trim(), txtStock.Text.Trim(), txtCategorie.Text.Trim());
                DbStock.UpdateStock(ingredient, id);
            }
            _parent.Display();
        }

    }
}
