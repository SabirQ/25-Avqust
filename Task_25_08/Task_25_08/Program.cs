using System;
using System.Linq;
using System.Reflection;
using Task_25_08.Models;
using Task_25_08.Models.Base;

namespace Task_25_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Instrumental[] instrumentals = 
            {
                 new Guitar 
                 {
                    Brand="Yamaha",
                    Price=345.70m,
                    Model="f310",
                    Country="Japan",
                    Type="Acoustic",
                    GuitarString="Dadarrio",
                    Wood="Akasa",
                    StringCount=6
                 },
                 new Violin
                 {
                    Brand="Gibson",
                    Price=642.90m,
                    Model="FVN-02",
                    Country="USA",
                    ViolinString="Violenitor",
                    ViolinBow="Arco",
                    Quality="High",
                    Tailpiece="Ebony"

                 },
                 new Drum
                 {
                     Brand="Tama",
                     Price=1800m,
                     Model="K48P-CHM",
                     Country="Tailand",
                     DrumStick="Classic",
                     DrumsCount=7,
                     ShellMaterial="Mersawa",
                     Cymbal="Crash",
                     IsElectronic=false,                     
                 },
                 new Piano
                 { 
                     Brand="Schimmel",
                     Price=2440m,
                     Model="FRIDOLIN F 121",
                     Country="Germany",
                     Surface="High-gloss",
                     PedalsCount=3,
                     WeightKg=234,
                     HasWheels=true
                 }
            };
            PrintAllInstruments(instrumentals);
            
        }
        public static void PrintAllInstruments(Instrumental[] instrumentals)
        {
            for (int i = 0; i < instrumentals.Length; i++)
            {
                var properties = instrumentals[i].GetType().GetProperties();
                var methods = instrumentals[i].GetType().GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).Where(x => !x.IsSpecialName).ToArray();
                Console.WriteLine($"{i+1}) Instrumental : {instrumentals[i].GetType().Name}");
                Console.WriteLine($"--------------------------------\nCharacteristics :");
                for (int j = properties.Length - 1; j >= 0; j--)
                {
                    Console.WriteLine($"      {properties[j].Name} : {properties[j].GetValue(instrumentals[i])}");
                }
                Console.WriteLine("Methods :");
                for (int j = 0; j < methods.Length; j++)
                {
                    Console.WriteLine($"      {methods[j].Name} : {methods[j].Invoke(instrumentals[i], null)}");
                }
                Console.WriteLine($"\n");
                
            }
        }
    }
}
