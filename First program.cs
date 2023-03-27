using System;



Console.WriteLine("what method of opperation are you using\nenter 5 for remainder\nenter 4 for addition\nenter 3 for subtraction\nenter 2 for divison\nenter 1 for multiplication");

int select = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Select first number");
double num_1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Select second number");
double num_2 = Convert.ToDouble(Console.ReadLine());

switch (select)
{
    case 1:
        double mult = num_1 * num_2;
        Console.WriteLine(mult);
        break;


    case 2:
        double div = num_1 / num_2;
        Console.WriteLine(div);
        break;

    case 3:
        double sub = num_1 - num_2;
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
        Console.WriteLine(select + " is not an option choose a diffrent method");
        break;





}
Console.WriteLine(" Here is your answer have a nice day");
