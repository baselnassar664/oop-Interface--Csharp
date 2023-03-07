using DemoNet6.inhertaince;
using DemoNet6.Interface;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace DemoNet6
{
 

    internal class Program
    {
        public static void print(ISeries series)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(series.Current);
                series.GetNext();
            }

        }

        //public static void print(SeriesByThree seriesByThree)
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine(seriesByThree.Current);
        //        seriesByThree.GetNext();
        //    }

        //}

        static void Main(string[] args)

        {
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //print(seriesByTwo);

            //Console.WriteLine("--------------");

            //SeriesByThree seriesByThree = new SeriesByThree();
            //print(seriesByThree);

            ISeries series1 = new SeriesByTwo();
            print(series1);

            Console.WriteLine("--------------");

            ISeries series2 = new SeriesByThree();
            print(series2);

             Console.WriteLine("--------------");

            Employeee employee1 = new Employeee(1, "basel", 5001);
 
            Console.WriteLine(employee1);

            Employeee employee2 = new Employeee(2, "amjad", 5001);

            Console.WriteLine(employee2);

            employee1 = employee2; //copy data from employee2 to  employee1
            Console.WriteLine(employee1);/*
                                          * 2
                                          * "amjad"
                                          * 5001
                                          * */
            Console.WriteLine("--------------------------");
            employee1 = new Employeee(employee2); //copy data from employee2 to  employee1 by (copy constrouctor)
            Console.WriteLine(employee1);/*
                                          * 2
                                          * "amjad"
                                          * 5001
                                          * */
            Console.WriteLine("--------------------------");
            employee1 =(Employeee)employee2.Clone();//copy data from employee2 to  employee1 by ( clone methode)
            Console.WriteLine(employee1);

            Employeee[] employees =
            {
               new Employeee(1,"basel",5000),
               new Employeee(2,"basel",6000),
               new Employeee(3,"basel",4000),
               new Employeee(4,"basel",3000),
               
            };

            Console.WriteLine("--------------------------");
            Array.Sort(employees);
            foreach(Employeee employee in employees)
            {
                Console.WriteLine(employee); 
                                                // sort
                                                 /*
                                               *   4::basel :: 3000
                                                   3::basel :: 4000
                                                   1::basel :: 5000
                                                   2::basel :: 6000
                                              */
            }

            Console.WriteLine("--------------------------");


            //not need to use interface IComparable
            foreach (Employeee employee in employees.OrderBy(x=>x.Salary))
            {
                Console.WriteLine(employee);
                // sort
                /*
              *   4::basel :: 3000
                  3::basel :: 4000
                  1::basel :: 5000
                  2::basel :: 6000
             */
            }

        }
    }
}
