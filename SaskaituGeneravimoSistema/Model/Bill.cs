using SaskaituGeneravimoSistema.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaskaituGeneravimoSistema.Model
{
    internal class Bill
    {        
        public int Id { get; set; }
        public List<int> Item { get; set; }
        public decimal TotalPrice { get; set; }

        public Bill(int id, List<int> item)
        {
            Id = id;
            Item = item;
        }

    }
}
