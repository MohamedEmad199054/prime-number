using System;
using System.Security.Cryptography.X509Certificates;
namespace std

    //AN VAIRABLE IN MAIN YOU MUST FO GIVE IT A INITIAL VALUE 
{
   

    class Programme
    {
        static void Main(string[] args)
        {
            bool x = true;
            Console.WriteLine("enter number to check if  prime or not: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 2)
            {
                x = false;
            }
            else if (num == 1 || num % 2 == 0)// number is one or even cant be prome number
            {
                x = false;
            }
            else
            {
                for (int i = 2; i < num; i++)//for odd numbers 
                {
                    if (num % i == 0 )
                    {
                        x = false;
                        break;//means close the loop when find a number can be devided by any number 
                        // breake means dont wait for the last state 
                    }
                }

            }
            if (num == 2)//exception that 2 is prime number..
            {
                x = true;
            }

            if (x)
            {
                Console.WriteLine("THIS IS PRIME NUMBER ");
            }
            else
            {                                                                                                                                                                                                                                                                                                                                                               
                Console.WriteLine("THIS IS NOT PRIME NUMBER ");


            }





        }




    }
}

