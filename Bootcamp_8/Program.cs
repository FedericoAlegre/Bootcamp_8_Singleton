using System;
using System.Data.SqlClient;

namespace Bootcamp_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("·Bootcamp 8·");
            ListaPais l= ListaPais.GetInstancia();
            l.AddPais();
            ListaPais l2 = ListaPais.GetInstancia();
            if (l == l2)
            {
                Console.WriteLine("funciona");
                l.MostrarLista();
                Console.ReadKey();
            }  
            
        }
    }
}
