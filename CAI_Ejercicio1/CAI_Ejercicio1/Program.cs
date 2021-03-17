using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Ejercicio1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string palabra = "";
            int contador;
            const int numregistro = 212;
            const int cinco = 5;
            const int tres = 3;
            do
            {
                for (contador = 0; contador < numregistro; contador++)
                {
                    if (contador % tres == 0  && contador % cinco == 0 ) 
                    {
                        Console.WriteLine(contador + " - FooBar");
                    }
                    else if (contador % cinco == 0)
                    {
                        Console.WriteLine(contador + " - Bar");
                    }
                    else if (contador % tres == 0) 
                    {
                        Console.WriteLine(contador + " - Foo");
                    }
                    Console.WriteLine(contador);
                }
            } while (contador < numregistro);
            
            Console.WriteLine("toca para terminar");
            Console.ReadKey();
        }
    }
}
 