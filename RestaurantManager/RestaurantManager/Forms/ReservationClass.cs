using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Forms
{
    internal class ReservationClass
    {
        public string nbrPersonnes { get; set; }
        public string numeroTable { get; set; }
        public string date { get; set; }
        public string nomClient { get; set; }

        public ReservationClass(string nbrPersonnes, string numeroTable, string date, string nomClient)
        {
            this.nbrPersonnes = nbrPersonnes;
            this.numeroTable = numeroTable;
            this.date = date;
            this.nomClient = nomClient;
        }
    }
}
