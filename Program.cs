using System;


namespace FirstProgram
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what method of opperation are you using");
            Console.WriteLine("enter 1 for multiplication");
            Console.WriteLine("enter 2 for divison");
            Console.WriteLine("enter 3 for subtraction");
            Console.WriteLine("enter 4 for addition");
            Console.WriteLine("enter 5 for remainder");

            int select = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select first number");
            int num_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Select second number");
            int num_2 = Convert.ToDouble(Console.ReadLine());

            double total = 0;
            switch (select)
            {
                case 1:
                    int mult = num_1 * num_2;
                    Console.WriteLine(mult);
                    break;
                    

                case 2:
                   double div  = num_1 / num_2;
                    Console.WriteLine(div);
                    break;

                case 3:
                  double  sub = num_1 - num_2;
                    Console.WriteLine(sub);
                    break;


                case 4:
                   double add = num_1 + num_2;
                    Console.WriteLine(add);
                    break;
                case 5:
                    double rem = num_1 % num_2;
                    Console.WriteLine(rem);
                    break;

                default:
                    Console.WriteLine(select + " is not an opption choose a diffrent method");
                    break;

                    



            }
            Console.WriteLine(" Here is your answer have a nice day");
        }
    }
}
