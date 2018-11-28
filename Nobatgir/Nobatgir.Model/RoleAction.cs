using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Nobatgir.Model
{
    public class RoleAction
    {
        public int ID { get; set; }

        public Act Action { get; set; }

        public int ActionID { get; set; }

        public Role Role { get; set; }

        public int RoleID { get; set; }

        public bool HasView { get; set; }

        public bool HasAdd { get; set; }

        public bool HasEdit { get; set; }

        public bool HasDelete { get; set; }
    }
}
