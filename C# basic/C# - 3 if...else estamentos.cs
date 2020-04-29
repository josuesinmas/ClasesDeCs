using System;

namespace DecisionMaking 
{

   class Program 
   {
   
      static void Main(string[] args) 
	  {
         /* local variable definicion */
         int a = 100;
         
         /* comprueba la codicion booleana */
         if (a < 20) 
		 {
            /*si la condicion es verdadera imprime lo siguiente */
            Console.WriteLine("a es mayor que 20");
         } 
		 else 
		 {
            /* si la condicion es verdaderta imprime lo siguiente */
            Console.WriteLine("a no es mayor que 20");
         }
         Console.WriteLine("valor de a es : {0}", a);
         Console.ReadLine();
      }
   }
} 