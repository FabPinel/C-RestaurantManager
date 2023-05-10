using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Forms
{
    internal class StockClass
    {
        public string nomIngredient { get; set; }

        public string stock { get; set; }

        public string categorieIngredient { get; set; }

        public StockClass(string ingredient, string stock, string categorie)
        {
            this.nomIngredient = ingredient;
            this.stock = stock;
            this.categorieIngredient = categorie;

        }
    }
}
