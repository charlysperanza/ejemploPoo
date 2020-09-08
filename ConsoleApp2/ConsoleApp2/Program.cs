using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            int numero, palo;

            Console.WriteLine("Ingrese el numero de la carta");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el palo de la carta, 0 para oro, 1 para copa, 2 para espada y 3 para basto");
            palo = int.Parse(Console.ReadLine());

            Carta naipe = new Carta(palo, numero); //declaro el objeto naipe del tipo Carta, para inicializarlo y que no tenga basura
                                                   //para inicializar pongo la palabra clave new y despues llamo al constructor
                                                   //con los parametros que precisa

            naipe.escribeCarta(); //llamo al metodo escribeCarta del objeto naipe (que es de la clase Carta)

            Console.ReadKey();
        }
    }
}
