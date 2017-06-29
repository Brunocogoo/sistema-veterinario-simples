using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABALHO_T1
{
    class Agendamento
    {
        public Int64 codigo;
        public DateTime data;
        public Int64 veterinario;
        public Int64 animal;


        public void imprimir()
        {
            Console.Write("\n\ncodigo: " + codigo);
            Console.Write("\nVeterinario responsável: " + veterinario);
            Console.Write("\nanimal a ser atendido: " + animal);
            Console.Write("\ndata e horario da consulta: " + data);
        }
    }

   
}
