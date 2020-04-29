using System;

namespace DecisionMaking 
{

   class Program 
   {
   
      static void Main(string[] args) 
	  {
         int a = 100;
         int b = 200;
         
         switch (a) 
		 {
            case 100: 
            Console.WriteLine("Esta parte del codigo sera egecutado ");
            
            switch (b)
			{
               case 200:
               Console.WriteLine("esta parte del codigo sera ejecutado");
               break;
            }
            break;
         }
         Console.WriteLine("El valor de a es exatamente : {0}", a);
         Console.WriteLine("El valor de b es exatamente : {0}", b);
         Console.ReadLine();
      }
   }
} 