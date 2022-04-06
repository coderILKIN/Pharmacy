using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class TypeDrug
    {
        public int Id;
        public static int id=0;

        public string TypeName { get; set; }

        public void typeidInfo()
        {
            id++;
            Id = id;
        }

        public void typedruginfo()
        {
            Console.WriteLine($"ID: {Id}");
        }

        

        public virtual string Tostring()
        {
            return TypeName;
        }

    }
}
