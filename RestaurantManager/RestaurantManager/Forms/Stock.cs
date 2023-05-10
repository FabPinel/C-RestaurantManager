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
    public partial class Stock : Form
    {
        FormulaireStock form;
        public Stock()
        {
            InitializeComponent();
            form = new FormulaireStock(this);
        }

        public void Display()
        {
            DbStock.DisplayAndSearchStock("SELECT id, nomIngredient, stock, categorieIngredient FROM ingredients", dataGridViewStock);
        }

        private void btnAjouterStock_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveStockInfo();
            form.ShowDialog();
        }

        private void Stock_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void textSearchStock_TextChanged(object sender, EventArgs e)
        {
            DbStock.DisplayAndSearchStock("SELECT id, nomIngredient, stock, categorieIngredient FROM ingredients WHERE nomIngredient LIKE '%" + txtSearchStock.Text + "%'", dataGridViewStock);
        }

        private void dataGridViewStock_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //EDIT
                form.Clear();
                form.id = dataGridViewStock.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.ingredient = dataGridViewStock.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.stock = dataGridViewStock.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.categorie = dataGridViewStock.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.UpdateInfoStock();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Voulez-vous supprimer cet élément ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbStock.DeleteStock(dataGridViewStock.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
