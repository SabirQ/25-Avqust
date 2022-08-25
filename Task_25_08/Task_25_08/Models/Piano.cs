using System;
using System.Collections.Generic;
using System.Text;
using Task_25_08.Models.Base;

namespace Task_25_08.Models
{
    public class Piano : Instrumental
    {
        public string Surface { get; set; }
        public byte PedalsCount { get; set; }
        public short WeightKg { get; set; }
        public bool HasWheels { get; set; }
        

        public override string Sound()
        {
            return "Piano sound";
        }
    }
}
