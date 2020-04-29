using System;
namespace Aritmetica
{
   
   class Program 
   { 
      
      static void Main(string[] args) 
	  { 
        /*declaramos las variables a utilizar
        
        */
         int a = 21;
         int b = 10;
         int c;

         c = a + b;
         Console.WriteLine("Linea 1 - el valor de c es ", c);
         
         c = a - b;
         Console.WriteLine("Linea 2 - el valor de c es ", c);
         
         c = a * b;
         Console.WriteLine("Linea 3 - el valor de c es ", c);
         
         c = a / b;
         Console.WriteLine("Linea 4 - el valor de c es ", c);
         
         c = a % b;
         Console.WriteLine("Linea 5 - el valor de c es ", c);
         
         c = a++;
         Console.WriteLine("Linea 6 - el valor de c es ", c);
         
         c = a--;
         Console.WriteLine("Linea 7 - el valor de c es ", c);
         //console.Readline(); lee la entrada de usuario
         Console.ReadLine();
      }
   }
}