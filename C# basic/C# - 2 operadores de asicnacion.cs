using System;

namespace operadores 
{

   class Program 
   {
   
      static void Main(string[] args) 
	  {
         int a = 21;
         int c;
         c = a;
         Console.WriteLine("Linea 1 - =  Valor de c = {0}", c);
         
         c += a;
         Console.WriteLine("Linea 2 - += Valor de c = {0}", c);
         
         c -= a;
         Console.WriteLine("Linea 3 - -=  Valor de c = {0}", c);
         
         c *= a;
         Console.WriteLine("Linea 4 - *=  Valor de c = {0}", c);
         
         c /= a;
         Console.WriteLine("Linea 5 - /=  Valor de c = {0}", c);
         
         c = 200;
         c %= a;
         Console.WriteLine("Linea 6 - %=  Valor de c = {0}", c);
         
         c <<= 2;
         Console.WriteLine("Linea 7 - <<=  Valor de c = {0}", c);
         
         c >>= 2;
         Console.WriteLine("Linea 8 - >>=  Valor de c = {0}", c);
         
         c &= 2;
         Console.WriteLine("Linea 9 - &=  Valor de c = {0}", c);
         
         c ^= 2;
         Console.WriteLine("Line 10 - ^=  Valor de c = {0}", c);
         
         c |= 2;
         Console.WriteLine("Line 11 - |=  Valor de c = {0}", c);
         Console.ReadLine();
      }
   }
}