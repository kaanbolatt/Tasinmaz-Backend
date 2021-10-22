using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string UserAdded = "Kullanıcı Eklendi!";
        public static string UserNameInvalid = "Kullanıcı adı kullanılamaz!";
        public static string UserListed = "Üyeler listelendi.";
        public static string UserMailAlreadyExist = "Bu mail adresi daha önce kullanıldı. Lütfen başka mail adresi girin.";
        public static string UserCountError = "10'dan fazla üyelik oluşturamazsın.";
        public static string UserDeleted = "Üye başarılı bir şekilde silindi.";
        public static string UserAlreadyExists = "Böyle bir kullanıcı bulunuyor.";
        public static string ProductDeleted = "Kullanıcı silindi.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string PasswordLengthError = "Parolanız 8 karakterden fazla olmalıdır.";
        public static string PasswordRules = "Şifrenizde en az bir büyük, bir küçük harf, bir rakam ve bir özel karakter olmalıdır.";
        public static string ProvinceLimitExceded = "Makimum 15 adet şehir olabilir. Bü yüzden şehir eklenmedi.";
        public static string AuthorizationDenied = "Yetersiz yetki.";
        public static string UserRegistered = "Kullanıcı kaydedildi.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Hatalı Şifre!";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string AccessTokenCreated = "Başarıyla giriş yapıldı.";
        public static string TasinmazAdded = "Taşınmaz Eklendi.";
        public static string TasinmazUpdated = "Taşınmaz Güncellendi.";
        public static string TasinmazListed = "Taşınmazlar Listelendi.";
        public static string TasinmazDeleted = "Taşınmaz silindi.";
        internal static string logListed;
    }
}
