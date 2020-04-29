using System;

namespace OperatorsAppl 
{

   class Program 
   {
   
      static void Main(string[] args) 
	  {
         /* ejemplo de sizeof */
         Console.WriteLine("The size of int is {0}", sizeof(int));
         Console.WriteLine("The size of short is {0}", sizeof(short));
         Console.WriteLine("The size of double is {0}", sizeof(double));
         
         /* ejemplo de operador ternario */
         int a, b;
         bool at =true;
         a = 17;
         b = (a == 1) ? 20 : 30;
         Console.WriteLine("Value of b is {0}", a);

         b = (a == 10) ? 20 : 30;
         Console.WriteLine("Value of b is {0}", b);
         Console.ReadLine();
      }
   }
}
