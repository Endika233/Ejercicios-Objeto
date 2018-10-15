using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Objeto
{
    class Numero
    {
        private int num;
        public Numero()
        {
            num = 0;
        }
        public Numero(int num)
        {
            this.num = num;
        }
        public void Suma(int numSum)
        {
            this.num = this.num + numSum;
        }
        public void Resta(int numRest)
        {
            this.num = this.num - numRest;
        }
        public int GetValor()
        {
            return this.num;
        }
        public int GetDouble()
        {
            return this.num * 2;
        }
        public int GetTriple()
        {
            return this.num * 3;
        }
        public void SetNumero(int num)
        {
            this.num = num;
        }
    }
}
//Realiza una clase número que almacene un número entero y tenga las siguientes características:
//      Constructor por defecto que inicializa a 0 el número interno.
//      Constructor que inicializa el número interno.
//      Método aniade que permite sumarle un número al valor interno.
//      Método resta que resta un número al valor interno.
//      Método getValor. Devuelve el valor interno.
//      Método getDoble. Devuelve el doble del valor interno.
//      Método getTriple. Devuelve el triple del valor interno.
//      Método setNumero. Inicializa de nuevo el valor interno.


