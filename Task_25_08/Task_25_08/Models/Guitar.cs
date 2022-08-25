using System;
using System.Collections.Generic;
using System.Text;
using Task_25_08.Models.Base;

namespace Task_25_08.Models
{
    public class Guitar : Instrumental
    {
        public string GuitarString { get; set; }
        public string Type { get; set; }
        public override string Sound()
        {
            return "Guitar sound";
        }
    }
}
