using System;
using System.Collections.Generic;
using System.Text;

namespace Nobatgir.Util
{
    public class ReturnUrl
    {
        public ReturnUrl(string Area, string Controller, string Action)
        {
            this.ReturnArea = Area;
            this.ReturnController = Controller;
            this.ReturnAction = Action;
        }

        public ReturnUrl(string Controller, string Action)
        {
            this.ReturnArea = "Admin";
            this.ReturnController = Controller;
            this.ReturnAction = Action;
        }

        public ReturnUrl()
        {
            this.ReturnArea = "Admin";
        }

        public string ReturnArea { get; set; }

        public string ReturnController { get; set; }

        public string ReturnAction { get; set; }

        public string Url
        {
            get
            {
                string s = $"/{this.ReturnArea}/{this.ReturnController}/{this.ReturnAction}";
                return s;
            }
        }
    }
}
