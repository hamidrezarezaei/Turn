using System;
using System.Collections.Generic;
using System.Text;
using Nobatgir.Model;

namespace Nobatgir.ViewModel
{
    
    public class StepsViewModel
    {
        public List<string> StepNames { get; set; } = new List<string>();

        public int CurrentStep { get; set; }
    }
    
}
