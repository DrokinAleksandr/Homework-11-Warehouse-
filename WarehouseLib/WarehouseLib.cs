using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseLib
{
    public static class productCollection
    {
        private static List<prodData> _collProd = new List<prodData>();
        public static void Add(prodData DataAboutProduct)
        {
            _collProd.Add(DataAboutProduct);
        }

        public static prodData[] GetProdData()
        {
            return _collProd.ToArray();
        }
    }
    public class prodData
    {
        public prodData(string newID, string nameProd, double priceProd, int baseProd,string expirationProd)
        {
            this.ProdID = newID;
            this.ProdName = nameProd;
            this.ProdPrice = priceProd;
            this.ProdBase = baseProd;
            this.ProdExpri = expirationProd;
        }

        public string ProdID { get; set; }
        public string ProdName { get; set; }
        public double ProdPrice { get; set; }
        public int ProdBase { get; set; }
        public string ProdExpri { get; set; }
    }
    public class shelfLife
    {
          public static string shelfLifeCalc(int baseProd)
        {
            //DateTime shelfLifeProd;
            string shelfLifeProd = DateTime.Today.AddDays(baseProd).ToString("dd.MM.yyyy");
            return shelfLifeProd;
        }

    }
}
