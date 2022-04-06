using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class Drug
    {
        public string Name;
        public int Id;
        public static int countr =0;
        
        public TypeDrug Type { get; set; }

        public int Count { get; set; }
        public double Price { get; set; }
        

        public void drugidInfo()
        {
            Id= ++countr;
            
        }

        public void drugwriteinfo()
        {
            Console.WriteLine($"ID: {Id}");
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name:{Name}, Price: {Price}, Count: {Count}";
        }
    }
}
