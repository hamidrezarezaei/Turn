using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nobatgir.Model;

namespace Nobatgir.ViewModel
{
    public class TurnFieldsViewModel
    {

        public Model.Turn Turn { get; set; }

        public List<ExpertField> ExpertFields { get; set; }
    }
}
