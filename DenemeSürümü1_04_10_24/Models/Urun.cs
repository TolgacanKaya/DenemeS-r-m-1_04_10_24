using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DenemeSürümü1_04_10_24.Models
{
    public class Urun
    {
        public int UrunID { get; set; }
        public string UrunAD { get; set; }
        public Nullable<int> Fiyat { get; set; }
        public string Marka { get; set; }
        public Nullable<int> Stok { get; set; }
        public Nullable<int> KategoriID { get; set; }

        public string KategoriAd { get; set; }


    }
}