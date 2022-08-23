using System;
using System.Threading.Channels;

namespace Dba
{
    public class Dba
    {
        public static void Main(string[] args)
        {
            double amount = 7000;
            double minimum = 5000;
            while (true)
            {
                Console.WriteLine("1.check ammount");
                Console.WriteLine("2.diposite");
                Console.WriteLine("3.withdraw");
                Console.WriteLine("4.exit");

                Console.WriteLine("Enter the choice : ");
                int ch =Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                    {
                        Console.WriteLine("*************************************");
                        Console.WriteLine("Total Amount : "+amount);
                        Console.WriteLine("Available amount : "+(amount-minimum));
                        Console.WriteLine("*************************************");
                    }
                        break;
                    case 2:
                    {
                        Console.WriteLine("*************************************");
                        Console.Write("Enter the diposite Amount : ");
                        double da = Convert.ToDouble(Console.ReadLine());
                        if (da > 0)
                        {
                            Console.WriteLine("disposite Succsesfull....!");
                            amount = amount + da;
                            Console.WriteLine("Total balnce is : " + amount);
                            Console.WriteLine("Available balence is : " + (amount-minimum));
                            Console.WriteLine("*************************************");
                        }
                        else
                        {
                            Console.WriteLine("pleace check & Enter valied amount....!");
                        }
                    }
                        break;
                    case 3:
                    {
                        Console.WriteLine("***********************************");
                        Console.WriteLine("Enter the withdral amount : ");
                        double wd = Convert.ToDouble(Console.ReadLine());
                        if ((amount-minimum)>=wd)
                        {
                            amount = amount - wd;
                            Console.WriteLine("withdral successful...!");
                            Console.WriteLine("Total Amount : "+amount);
                            Console.WriteLine("Available amount : "+(amount-minimum));
                        }
                        else
                        {
                            Console.WriteLine("insuficent balence...!");
                            Console.WriteLine("Total Amount : "+amount);
                            Console.WriteLine("Available amount : "+(amount-minimum));
                        }
                        Console.WriteLine("***********************************");
                    }
                        break;
                    case 4:
                    {
                        Console.WriteLine("***********************************");
                        Console.WriteLine("Thankyou for using bank application .......!");
                        System.Environment.Exit(0);
                        Console.WriteLine("***********************************");
                    }
                        break;
                    default:Console.WriteLine("Pleace Enter the valied option : ");
                        break;
                }
                
            }
        }
    }
}