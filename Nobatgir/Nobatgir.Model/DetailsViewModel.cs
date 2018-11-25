using System;
using System.Collections.Generic;
using System.Text;

namespace Nobatgir.Model
{
    
    public class DetailsViewModel<T> where T : BaseClass
    {
        public T Row{ get; set; } 

        public ActionTypes ActionType { get; set; }
    }
    
}
