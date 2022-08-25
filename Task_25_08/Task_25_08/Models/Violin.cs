using System;
using System.Collections.Generic;
using System.Text;
using Task_25_08.Models.Base;

namespace Task_25_08.Models
{
    class Violin : Instrumental
    {
        public string ViolinStrings { get; set; }
        public override string Sound()
        {
           
            return "Violin sound";
        }
    }
}
