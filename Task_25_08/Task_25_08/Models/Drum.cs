using System;
using System.Collections.Generic;
using System.Text;
using Task_25_08.Models.Base;

namespace Task_25_08.Models
{
    public class Drum : Instrumental
    {
        public string DrumStick { get; set; }
        public string Cymbal { get; set; }
        public byte DrumsCount { get; set; }
        public bool IsElectronic { get; set; }
        public string ShellMaterial { get; set; }


        public override string Sound()
        {
            return "Drum sound";
        }
        public string SetUpDrums()
        {
            return "Drums are set up";
        }
    }
}
