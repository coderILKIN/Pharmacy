using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class Pharmacy
    {
        public string Name;
        public int Id;
        public static int id = 0;

        public Drug[] drugs = new Drug[0];

        public void pharmacyidInfo()
        {
            id++;
            Id = id;
        }

        public void pharmacywriteinfo()
        {
            Console.WriteLine($"ID: {Id}");
        }

        public void SaleDrug(string name, int count, double money)
        {
            foreach (var item in drugs)
            {
                if (item.Name == name && item.Count > count && item.Price < money)
                {
                    money -= count * item.Price;
                    item.Count -= count;
                    Console.WriteLine(item);
                    Console.WriteLine($"Qalan Pul: {money}");
                }
                else
                {
                    Console.WriteLine($"mehsul yoxdur");
                }

            }
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }


        public void AddDrug(Drug drug)
        {
            Array.Resize(ref drugs, drugs.Length + 1);
            drugs[drugs.Length - 1] = drug;
        }

        public void DrugList()
        {
            foreach (var item in drugs)
            {
                Console.WriteLine(item);
            }
        }

       
    }

}
