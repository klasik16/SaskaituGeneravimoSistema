using SaskaituGeneravimoSistema.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaskaituGeneravimoSistema.Repository
{
    internal class BillRepository
    {
        public List<Bill> Bills { get; private set; }
        public BillRepository()
        {
            if (Bills == null) {
                Bills = new List<Bill>();

                for (int i = 1; i <= 10; i++)
                {
                    Bills.Add(new Bill(i, GenerateBillItems()));
                }
            }
        }
        private List<int> GenerateBillItems()
        {
            List<int> listRange = new List<int>();
            Random rd = new Random();
            for (int i = 0; i < rd.Next(1, 10); i++)
            {
                listRange.Add(rd.Next(1,10));
            }

            return listRange;
        }

        public List<Bill> Retrieve()
        {
            return Bills;
        }

        //public List<Bill> Retrieve(int id)
        //{
        //    // int security = employees.Where(l => l.ID == employeeID).
        //    Bill bill = Bills.Where(l => l.Id == id);
        //    return bill; //security;
        //}
    }
}
