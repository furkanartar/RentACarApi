using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Eklendi";
        public static string Updated = "Güncellendi.";
        public static string Deleted = "Silindi";
        public static string NameInvalid = "Geçersiz isim";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string Listed = "Listelendi";
        public static string RentInvalid = "Araba zaten kiralandı";
        public static string NotUploaded = "Yüklenemedi.";
        public static string Uploaded = "Yüklendi";
        public static string CarOfImageLimitExceeded = "Resim limiti aşıldı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string UserRegistered = "Kayıt işlemi başarılı";
        public static string PasswordError = "Şifre yanlış";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists  = "Kullanıcı zaten mevcut";
        public static string TheCarIsAlreadyRented = "Araba zaten kiralanmış";

        public static string FindeksAdded = "Findeks puanınız eklendi.";
        public static string FindeksUpdated = "Findeks puanınız güncellendi.";
        public static string FindeksDeleted = "Findeks puanınız silindi.";
        public static string FindeksNotEnoughForCar = "Findeks puanınız bu araç için yeterli değil..";
        public static string FindeksNotFound = "Findeks puanı eklemelisiniz.";
        public static string AuthorizationDenied = "AuthorizationDenied";
    }
}