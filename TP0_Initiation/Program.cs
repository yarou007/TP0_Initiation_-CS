using System;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TP0_Initiation
{
    public static class Program { 
    static void Main(string[] args)
    {
            // Exercice 1 : 1

            //Console.WriteLine("Entrer une valeur: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("Valeur absolue = "+Math.Abs(num));
            // Exercice 1 : 2 
            // Console.WriteLine("Entrer une anneé: ");
            //int an = int.Parse(Console.ReadLine());
            //if (an % 4 == 0)
            // {
            //     Console.WriteLine("C’est une année bissextile");
            // }
            // else
            // {
            //     Console.WriteLine("Non année bissextile");
            // }


            //Exerice 2 : 
            //Console.WriteLine("Donner votre revenu: ");
            //double rev = double.Parse(Console.ReadLine());
            //double imp = 0;

            //if (rev <= 1000)
            //{
            //    imp = 0.10 * 1000;
            //    Console.WriteLine("L'impot pour `" + rev + "` = " + imp);
            //}
            //else if (rev >= 1001 && rev <= 5000)
            //{
            //    imp = (0.10 * 1000) + 0.3 * (rev - 1000);
            //    Console.WriteLine("L'impot pour `" + rev + "` = " + imp);

            //}
            //else
            //{
            //    imp = (0.10 * 1000) + 0.3 * (rev - 1000) + 0.5 * (rev - 3000);
            //    Console.WriteLine("L'impot pour `" + rev + "` = " + imp);
            //}

            // Exerice 3 

            //Console.WriteLine("Saisi entier 1 ");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Saisi entier 2 ");
            //int n2 = int.Parse(Console.ReadLine());
            ////      -5 = 5       > 1 
            ////         50 >    51 
            //if (Math.Abs(n1-50) > Math.Abs(n2-50) ) 
            //{
            //    Console.WriteLine(n2);
            //}
            //else Console.WriteLine(n1);

            /// Exerice 4 
            /// 
            // Mine for 3 digits only 
            //Console.WriteLine("Donner un nombre");
            //int num = int.Parse(Console.ReadLine()); // 153
            //int a = num / 100; // 1 
            //int b = (num % 100) / 10; // 5
            //int c = ( (num%100) % 10) % 10; //3 


            //if ( (a*a*a)+(b*b*b)+(c*c*c) == num)
            //{
            //    Console.WriteLine("Armstrong");
            //}
            //else Console.WriteLine("Not armstrong");

            // after research 3 or more digits -- yikes hedhi temshi zeda ken ala 3 digits if you want 4 digits or more you need to multiple 4 times for 4 digits 
            // 5 times for 5 digits to get armstrong number lol 
            //Console.WriteLine("Donner un nombre");
            //int num = int.Parse(Console.ReadLine()); // 1634
            //int numFake = num; // = 1634
            //int res = 0;

            //while (numFake != 0)  
            //{
            //   // Console.WriteLine(numFake + " " + num);
            //    int lastDigit = numFake % 10; // 4
            //    res += (lastDigit * lastDigit * lastDigit);
            //    numFake /= 10;
            //    Console.WriteLine(res+" " + lastDigit);

            //}
            //Console.WriteLine(res);
            //if (res == num)
            //{
            //    Console.WriteLine("Armstrong");
            //}
            //else Console.WriteLine("Not armstrong");

            Console.WriteLine("Donner entier a ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Donner entier b ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Calcul + , - ,* , /: ");
            char op = char.Parse(Console.ReadLine());
            double sum = 0;
    
            switch (op)
            {
                case '+':  sum = (a + b) ;Console.WriteLine(a + "+" + b+"= " + sum);break;
                case '-':  sum = (a - b); Console.WriteLine(a + "-" + b + "= " + sum); break;

                case '*':  sum = (a * b); Console.WriteLine(a + "*" + b + "= " + sum); break;

                case '/':
                    try
                    {
                        if (b == 0) { throw new DivideByZeroException(); }
                        else { sum = a / b; Console.WriteLine(a + "/" + b + "= " + sum); }

                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default: Console.WriteLine("Wrong caractere");break;
                                
            }
            }


        }
    }
