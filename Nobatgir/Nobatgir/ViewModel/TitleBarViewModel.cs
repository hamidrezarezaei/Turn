using System;
using System.Collections.Generic;
using System.Text;
using Nobatgir.Model;

namespace Nobatgir.ViewModel
{
    
    public class TitleBarViewModel
    {
        public ActionTypes ActionType { get; set; }

        public string Title { get; set; }

        public string AddNewTitle { get; set; }

        public string AddNewController { get; set; }

        public int ParentID { get; set; }
    }
    
}
