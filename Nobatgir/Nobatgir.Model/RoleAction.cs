using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Nobatgir.Model
{
    public class RoleAction
    {
        public int ID { get; set; }

        public Act Act { get; set; }

        public int ActID { get; set; }

        public int RoleID { get; set; }

        public bool HasView { get; set; }

        public bool HasAdd { get; set; }

        public bool HasEdit { get; set; }

        public bool HasDelete { get; set; }

        // نباید این وجود داشته باشد به دلیل ساخت جدول اضافی
        //public Role Role { get; set; }
    }
}
