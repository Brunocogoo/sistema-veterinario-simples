using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABALHO_T1
{
    class Animal
    {
        public Int64 codigo;
        public string nome;
        public string raca;
        public DateTime data;


        public void imprimir ()
        {
            Console.Write("\n\ncodigo: "+codigo);
            Console.Write("\nnome: "+nome);
            Console.Write("\nraça: "+raca);
            Console.Write("\ndata de nascimento: "+data);

        }




    }
}

