using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi.";
        public static string CarCantAdded = "Ekleme geçersiz.";
        public static string CarsListed = "Araçlar listelendi.";
        public static string CarDeleted = "Araç sistemden silindi.";
        public static string CarUpdated = "Araç güncellendi.";

        public static string BrandAdded = "Marka eklendi.";
        public static string BrandDeleted = "Marka silindi.";
        public static string BrandUpdated = "Marka güncellendi.";

        public static string RentAdded = "Kiralama eklendi.";
        public static string RentDeleted = "Kiralama silindi.";
        public static string RentUpdated = "Kiralama güncellendi.";
        public static string RentListed = "Güncel kiralanmış araç listesi.";
        public static string RentGetting = "Sistemdeki son durumu gösteriliyor.";
        public static string ReturnDateNone = "Dönüş tarihi bulunamadı.";

        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string CustomersListed = "Müşteriler listelendi.";

        public static string UserAdded = "Kullanıcı sisteme eklendi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UsersListed = "Kullanıcılar listelendi.";
        public static string UserAlreadyExists = "Böyle bir kullanıcı zaten var.";
        public static string UserNotFound = "Kullanıcı bulunamıyor.";
        public static string UserRegistered = "Kullanıcı kayıt oldu.";

        public static string ColorUpdated = "Renk güncellendi.";
        public static string ColorDeleted = "Renk silindi.";
        public static string ColorAdded = "Renk eklendi.";

        public static string ImageAdded = "Resim ekleme başarılı.";
        public static string ImagesUpdated = "Resim güncellemesi başarılı.";
        public static string ImageDeleted = "Resim başarıyla silindi.";
        public static string ImageExist = "Bu resim daha önce eklenmiş.";
        public static string CarImagesCountExceded = "Daha fazla resim eklenemez.";

        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string PasswordError = "Şifre hatalı!";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string NotListed = "Listelenmedi.";
        public static string Listed = "Listelendi.";

        public static string CarCountOfCategoryError = "Kategori limiti doldu.";
        public static string CarNameAllreadyExists = "Bu isimde bir araç bulunuyor.";
        public static string CustomerLimitExiceded = "Müşteri limidi aşıldı.";
        public static string EmailControl = "Email kontrol ediliyor.";
        public static string PaymentSuccessful = "Ödeme başarılı.";
        public static string PaymentFailed = "Ödeme işlemi başarısız.";
        public static string RentalUndeliveredCar = "Bu araç kiralanamaz.";
        public static string RentalNotAvailable = "Bu araç şuanda kiralanmış durumda.";
    }
}
