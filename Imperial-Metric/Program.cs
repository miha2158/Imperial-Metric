using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imperial_Metric
{
    class Program
    {
        static void Main(string[] args)
        {

            int input1, input2;

            do
            {
                Console.WriteLine("1. Litre");
                Console.WriteLine("2. Butt");
                Console.WriteLine("3. fl.oz");
                Console.WriteLine("4. US Barrel");
                Console.WriteLine("5. UK Barrel");
                Console.WriteLine("6. US Gallon");
                Console.WriteLine("7. UK Gallon");
                Console.WriteLine("8. US Pint");
                Console.WriteLine("9. UK Pint");
                Console.WriteLine("10. US Oil Barrel");
                Console.WriteLine("11. UK Oil Barrel");
                Console.WriteLine("0. Exit");


                Console.WriteLine();
                Console.WriteLine("Convert From?");
                while (!int.TryParse(Console.ReadLine(), out input1) && input1 >= 11 && input1 <= 0)
                {
                    Console.WriteLine("Number from 0 to 11");
                }
                if (input1 == 0) break;


                Console.WriteLine();
                Console.WriteLine("Convert to?");
                while (!int.TryParse(Console.ReadLine(), out input2) && input2 >= 11 && input2 <= 0)
                {
                    Console.WriteLine("Number from 0 to 11");
                }
                if (input2 == 0) break;

                double Num;
                Console.WriteLine();
                Console.WriteLine("Number?");
                while (!double.TryParse(Console.ReadLine(), out Num))
                {
                    Console.WriteLine("Write a Number");
                }

                switch (input1)
                {
                    case 2:
                        Num = Num * 490.97;
                        break;

                    case 3:
                        Num = Num * (28.4 / 1000);
                        break;

                    case 4:
                        Num = Num * 119.2;
                        break;

                    case 5:
                        Num = Num * 163.65;
                        break;

                    case 6:
                        Num = Num * 3.784;
                        break;

                    case 7:
                        Num = Num * 4.546;
                        break;

                    case 8:
                        Num = Num * 0.473;
                        break;

                    case 9:
                        Num = Num * 0.57;
                        break;

                    case 10:
                        Num = Num * 158.97;
                        break;

                    case 11:
                        Num = Num * 158.988;
                        break;
                }



                switch (input2)
                {
                    case 2:
                        Num = Num / 490.97;
                        break;

                    case 3:
                        Num = Num / (28.4 / 1000);
                        break;

                    case 4:
                        Num = Num / 119.2;
                        break;

                    case 5:
                        Num = Num / 163.65;
                        break;

                    case 6:
                        Num = Num / 3.784;
                        break;

                    case 7:
                        Num = Num / 4.546;
                        break;

                    case 8:
                        Num = Num / 0.473;
                        break;

                    case 9:
                        Num = Num / 0.57;
                        break;

                    case 10:
                        Num = Num / 158.97;
                        break;

                    case 11:
                        Num = Num / 158.988;
                        break;
                }



                Console.WriteLine("result : {0}", Num);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

            }
            while (input1 != 0 || input2 != 0);            
        }
    }
}
