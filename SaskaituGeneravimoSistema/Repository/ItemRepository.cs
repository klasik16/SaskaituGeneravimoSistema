using SaskaituGeneravimoSistema.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaskaituGeneravimoSistema.Repository
{
    internal class ItemRepository
    {
        public List<Item> Items { get; private set; }
        public ItemRepository()
        {
            Items = new List<Item>();
            Items.Add(new Item(1, "13. Soup “Jum” with shrimps and coconut milk", (decimal)8.20));
            Items.Add(new Item(2, "14. “Pho” soup with beef", (decimal)11.20));
            Items.Add(new Item(3, "21. Salad “four seasons”", (decimal)5.50));
            Items.Add(new Item(4, "23.Summer rolls (3 pcs.)", (decimal)9.00));
            Items.Add(new Item(5, "313G Chicken Curry (spicy)", (decimal)12.60));
            Items.Add(new Item(6, "4.2 Crispy chicken “Guo-bao”", (decimal)12.00));
            Items.Add(new Item(7, "311. Crispy duck", (decimal)16.30));
            Items.Add(new Item(8, "6.7 Beef with black peppers", (decimal)14.50));
            Items.Add(new Item(9, "318. Crispy fish", (decimal)12.60));
            Items.Add(new Item(10, "319. Shrimps with butter and garlic sauce", (decimal)16.40));
        }
    }
}
