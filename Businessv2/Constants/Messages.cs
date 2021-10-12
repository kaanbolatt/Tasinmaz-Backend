﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string UserAdded = "Kullanıcı Eklendi!";
        public static string UserNameInvalid = "Kullanıcı adı kullanılamaz!";
        public static string UserListed = "Üyeler listelendi.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string UserDeleted = "Üye başarılı bir şekilde silindi.";
        public static string PasswordLengthError = "Parolanız 8 karakterden fazla olmalıdır.";
        public static string UserCountError = "10'dan fazla üyelik oluşturamazsın.";
        public static string UserMailAlreadyExist = "Bu mail adresi daha önce kullanıldı. Lütfen başka mail adresi girin.";
    }
}
