using System;
using System.Collections.Generic;
using System.Text;
using Task_25_08.Models.Base;

namespace Task_25_08.Models
{
    class Violin : Instrumental
    {
        public string Tailpiece { get; set; }
        public string ViolinString { get; set; }
        public string ViolinBow { get; set; }
        public string Quality { get; set; }
        public override string Sound()
        {
            return "Violin sound";
        }
        public string VibrateStrings()
        {
            return "violin strings are vibrated";
        }

    }
}
