//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DenemeSürümü1_04_10_24
{
    using System;
    using System.Collections.Generic;
    
    public partial class Urunler
    {
        public int UrunID { get; set; }
        public string UrunAD { get; set; }
        public Nullable<int> Fiyat { get; set; }
        public string Marka { get; set; }
        public Nullable<int> Stok { get; set; }
        public Nullable<int> KategoriID { get; set; }
    
        public virtual Kategoriler Kategoriler { get; set; }
    }
}
