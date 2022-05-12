using System;
using System.Collections.Generic;
using System.Text;


namespace Bootcamp_8
{
    public sealed class ListaPais
    {
        private List<Pais> paises;

        private static ListaPais instancia;
        private ListaPais()
        {
            paises = new List<Pais>();            
        }
        
        public static ListaPais GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new ListaPais();
            }
            return instancia;
        }

        public void AddPais()
        {
            Console.Write("·Agregar pais·\nNombre: ");
            Pais p = new Pais();
            p.Paiss = Console.ReadLine();
            Console.Write("·Agregar provincias· Ingrese 0 para terminar de agregar");
            string s;
            do
            {
                Console.Write("\nNombre: ");
                s = Console.ReadLine();
                if (s != "0")
                {
                    p.provincias.Add(s);

                }

            } while (s != "0");

            instancia.paises.Add(p);
        }

        public void MostrarLista()
        {
            foreach(Pais i in paises)
            {
                Console.WriteLine("Pais: "+i.Paiss+"\nProvincias: ");
                foreach(string s in i.provincias)
                {
                    Console.WriteLine("   -"+s);
                }
            }
        }
    }
}
