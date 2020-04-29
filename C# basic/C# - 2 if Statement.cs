using System;

namespace DecisionMaking 
{

   class Program 
   {
   
      static void Main(string[] args) 
	  {
         /* Variable local */
         
         bool a = false;
         
        /* comprueba la condicion */
         if (a && b || c) 
		 {
            /* si la condicion es verdadera imprime por la pantalla lo siguiente */
            Console.WriteLine("a es verdaredo");
         }
         Console.WriteLine("el valor de a es : {0}", a);
         Console.ReadLine();
      }
   }
}