using System;

public static class Program 
{         
    public static void Main()
    {
        Console.WriteLine("Hello");
     	Console.WriteLine("Would you like to use the application?");
        string MyChoice = Console.ReadLine();
		string MyChoicef = MyChoice.ToUpper();
		if(Mychoicef=="YES")
		{
            Console.WriteLine("Ok the application is starting....");
        }
		else
		{
            Console.WriteLine("You may have given a invalid input please refer to use only yes or no in the response");
        }
    }
	//There would be some error but I am in hurry that's why I fix error later
	
	
