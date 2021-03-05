using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string CarListed = "Arabalar listelendi";
        public static string RentalAdded = "Araç kiralık verildi";
        public static string RentalListed = "Kiralik araçlar listelendi";
        public static string BrandListed = "Markalar listelendi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CarCountofBrandError = "Bir markada en fazla 10 araç olabilir.";
        public static string CarNameAlreadyExist = "Araba ismi sistemde mavcut";
        public static string BrandLimitExceed = "Marka limiti aşıldığı için araba eklenemiyor.";
        public static string CarImagesAdded = "Araç resmi eklendi";
    }
}
