using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Carta
    {
        //atributos de la clase 
        int palo;
        int numero;
        String[] palos = { "Oro","Copas","Espadas","Bastos" };

        public Carta(int palo, int numero)//constructor de la clase, es el que inicializa al objeto, recibe por parametro el palo y el nuemero
        {
            //numeros son del 1 al 12
            //palos 0 al 3
            if (numero <1 || numero > 12)//verifico en el constructor que los datos sean correctos, si son correctos asigno
            {
                Console.WriteLine("Numero incorrecto");
                Console.ReadKey();
                Environment.Exit(1);
            }
            else
            {
                this.numero = numero; //el this.numero se refiere al atributo numero de la clase, el numero solo se refiere al numero que le paso por parametro
            }
            if (palo>4 || palo <0)
            {
                Console.WriteLine("palo incorrecto"); Console.ReadKey();
                Environment.Exit(2);
            }
            else {
                this.palo = palo;
            }
        }

        public void escribeCarta() //metodo de la clase carta que llamo para escribir el numero y el palo de la carta
        {
            Console.WriteLine(numero.ToString() + " de " + palos[palo]);
        }

        public int getNumero() //metodo de la clase carta que llamo para obtener el numero de la carta sin que pueda acceder al atributo en si.
        {
            return this.numero;
        }

    }
}
