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
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı kayıt edildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı sistemde kayıtlı";
        public static string AccessTokenCreated = "Kullanıcı yetkilendirme gerçekleştirildi";
    }
}
