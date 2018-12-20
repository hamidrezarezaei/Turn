using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Nobatgir.Services
{
    public partial class Repository
    {
        public enum Sessions
        {
            TurnID
        }

        public Guid? SessionTurnID
        {
            get
            {
                var s = httpContextAccessor.HttpContext.Session.GetString(nameof(Sessions.TurnID));

                return string.IsNullOrEmpty(s) ? (Guid?) null : Guid.Parse(s);
            }
            set => httpContextAccessor.HttpContext.Session.SetString(nameof(Sessions.TurnID), value == null ? "" : value.ToString());
        }
    }
}
