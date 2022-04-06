using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            Drug drug1 = new Drug();
            drug1.Name = "";
            drug1.Count = 3;
            drug1.Price = 21;
            drug1.drugidInfo();
            drug1.drugidInfo();
            drug1.drugidInfo();

            Console.WriteLine(drug1.ToString());

            Pharmacy pharmacy = new Pharmacy();

            Console.WriteLine("Enter money: ");
            double money = double.Parse(Console.ReadLine());
            Console.WriteLine("Specify name of drug: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter count drug which you retrieve: ");
            int count = int.Parse(Console.ReadLine());

            pharmacy.AddDrug(drug1);
            pharmacy.AddDrug(drug1);
            pharmacy.SaleDrug(name, count, money);




        }
    }
}
