using System;
using System.Transactions;

public class Quiz
{


    public static void Main(string[] args)
    {
        Console.Write("Are you a male or a female?: ");
        string gender = Console.ReadLine();



        if (gender.ToLower() == "male")
        {
            if (CarryingInfant())
            {
                Console.WriteLine("Sorry sir, you cannot ride the front seat due to the presence of an infant");
            }
            else
            {
                if (Height())
                {
                    Console.WriteLine("Sorry sir, you do not fulfill the height requirements to ride the front seat");
                }
                else
                {
                    Console.WriteLine("Welcome aboard");
                }
            }

        }
        else if (gender.ToLower() == "female")
        {
            if (pregnant())
            {
                Console.WriteLine("Sorry, Ma'am. As an expectant mother you cannot ride in the front seat");
            }
            else
            {
                if (CarryingInfant())
                {
                    Console.WriteLine("Sorry ma'am, you cannot ride the front seat due to the presence of an infant");
                }
                else
                {
                    if (Height())
                    {
                        Console.WriteLine("Sorry ma'am, you do not fulfill the height requirements to ride the front seat");
                    }
                    else
                    {
                        Console.WriteLine("Welcome aboard");
                    }
                }
            }
        }//main method end



        static bool pregnant()
        {
            Console.Write("Are you pregnant?: ");
            string pregnantconfirm = Console.ReadLine();


            bool result = (pregnantconfirm.ToLower() == "yes") ? true : false;
            return result;

        }

        static bool CarryingInfant()
        {
            Console.Write("Are you carrying an infant?: ");
            string response = Console.ReadLine();


            bool result = (response.ToLower() == "yes") ? true : false;
            return result;
        }

        static bool Height()
        {
            Console.WriteLine("Enter your height");
            Console.Write("Feet: ");
            int feet = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inches: ");
            int inches = Convert.ToInt32(Console.ReadLine());

           bool result = ((feet <= 4)&& (inches <= 11)) ? true : false;
            return result;
        }

    }
}



