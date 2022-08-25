using System;
using System.Collections.Generic;
using System.Text;

namespace Task_25_08.Models.Base
{
    public abstract class Instrumental
    {
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public string Model { get; set; }
        public string Country { get; set; }

        public abstract string Sound();
    }
}
