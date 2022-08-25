using System;
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
                    BrandName="Yamaha",
                    Price=345.70m,
                    Model="f310",
                    Type="Acoustic",
                    GuitarString="Dadarrio"
                },
                 new Violin
                {
                    BrandName="Gibson",
                    Price=642.90m,
                    Model="f310",
                    ViolinStrings="Violenitor"
                }
            };
            for (int i = 0; i < instrumentals.Length; i++)
            {
                var properties = instrumentals[i].GetType().GetProperties();
                Console.WriteLine($"Instrumental : {instrumentals[i].GetType().Name}");
                for (int j = properties.Length-1; j >=0; j--)
                {
                    Console.WriteLine($"{properties[j].Name} : {properties[j].GetValue(instrumentals[i])}");
                }
                Console.WriteLine($"Sound : { instrumentals[i].Sound()}");
               
            }
            //foreach (var item in instrumentals)
            //{
            //    foreach (var property in item.GetType().GetProperties())
            //    {
            //        string val = property.GetValue(item).ToString();
                    
                   
            //    }
               
            //}
        }
    }
}
