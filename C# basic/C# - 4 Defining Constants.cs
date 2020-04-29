using System;

namespace DeclaringConstants 
{

    class Program 
	{
    
        static void Main(string[] args) 
		{
            const double pi = 3.14159;   
            
            // constante declaracion
            double r;

            Console.WriteLine("Dame el radio: ");

            r = Convert.ToDouble(Console.ReadLine());

            double areaCircle = pi * r * r;

            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
            
            Console.ReadLine();
        }
    }
}