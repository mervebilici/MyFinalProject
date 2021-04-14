using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages 
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        internal static string ProductsListed = "Ürünler listelendi";
        internal static string MaintenanceTime="Sistem bakımda";

        public static string ProductCountOfCategoryError = "Aynı üründen en  fazla on tane ekleyebilirsiniz";

        public static string ProductNameAlreadyExists = "Geçersiz ürün ismi";

        public static string CategoryLimitExceded = "Kategori limiti aşıldı";
    }
}
