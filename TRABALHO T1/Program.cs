using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace TRABALHO_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Veterinarios = new ArrayList();
            ArrayList Animais = new ArrayList();
            ArrayList Agendamentos = new ArrayList();

            Agendamento g;
            Veterinario v;
            Animal a;
            int op=1;
            int verificador =0;

            do{
            op = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Escolha a opcao desejada:\n 1-Cadastrar Veterinario \n 2-Cadastrar Animal \n 3-Registrar Consulta \n 4-Alterar um veterinario\n 5-Alterar um animal \n 6-Remover um veterinario\n 7-Remover Animal \n 8-Remover Consulta \n 9-Listar todos os animais, veterinarios e consultas \n 10-Sair"));

           
                
                
                if (op == 1)
            {
                v = new Veterinario();
                do
                {
                    v.cpf = Convert.ToInt64(Microsoft.VisualBasic.Interaction.InputBox("Digite o CPF do veterinário"));
                    verificador = 0;
                    foreach (Veterinario x in Veterinarios)
                    {
                        if (v.cpf == x.cpf)
                        {
                            MessageBox.Show("CPF já cadastrado, digite um CPF diferente!");
                            verificador = 1;
                            break;
                        }
                    }
                }
                while (verificador == 1);
                v.nome = (Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do veterinário"));
                    do{
                v.registro = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Digite o registro do veterinário"));
                        verificador = 0;
                    foreach (Veterinario x in Veterinarios)
                    {
                        if (v.registro == x.registro)
                        {
                            MessageBox.Show("Registro já cadastrado, digite um Registro diferente!");
                            verificador = 1;
                            break;
                        }
                    }
                }
                while (verificador == 1);
                v.data = Convert.ToDateTime(Microsoft.VisualBasic.Interaction.InputBox("Digite a data de nascimento do veterinário (dd/mm/aaaa)"));
                Veterinarios.Add(v);
            }

           
               
                if (op == 2)
            {
                a = new Animal();
                    do{
                a.codigo = Convert.ToInt64(Microsoft.VisualBasic.Interaction.InputBox("Digite o Código do animal"));
                    verificador = 0;
                    foreach (Animal x in Animais)
                    {
                        if (a.codigo == x.codigo)
                        {
                            MessageBox.Show("Codigo já cadastrado, digite um Codigo diferente!");
                            verificador = 1;
                            break;
                        }
                    }
                }
                while (verificador == 1);
                a.nome = (Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do animal"));
                a.raca = (Microsoft.VisualBasic.Interaction.InputBox("Digite a raça do animal"));
                a.data = Convert.ToDateTime(Microsoft.VisualBasic.Interaction.InputBox("Digite a data de nascimento do animal (dd/mm/aaaa)"));
                Animais.Add(a);

            
            }

            
               
                if (op==3)
            {
                g = new Agendamento();
                    do{
                g.codigo = Convert.ToInt64(Microsoft.VisualBasic.Interaction.InputBox("Digite o Código do agendamento"));
                    verificador =0;
               foreach (Agendamento x in Agendamentos)
                    {
                        if (g.codigo == x.codigo)
                        {
                            MessageBox.Show("Codigo já cadastrado, digite um CPF diferente!");
                            verificador = 1;
                            break;
                        }
                    }
                }
                while (verificador == 1);
                    
                do
                {
                g.veterinario = Convert.ToInt64(Microsoft.VisualBasic.Interaction.InputBox("Digite o registro do veterinario responsável"));
                verificador = 0;
                    foreach (Veterinario x in Veterinarios)
                    {
                        if (g.veterinario == x.registro) verificador = 1;

                    }
                    if (verificador != 1) MessageBox.Show("Veterinario nao encontrado, digite novamente");
                }
                while (verificador != 1);
                do
                {
                
                g.animal = Convert.ToInt64(Microsoft.VisualBasic.Interaction.InputBox("Digite o codigo do animal a ser atendido"));
                verificador = 0;
                    foreach (Animal x in Animais)
                    {
                        if (g.animal == x.codigo) verificador = 1;

                    }
                    if (verificador != 1) MessageBox.Show("Animal nao encontrado, digite novamente");
                }
                while (verificador != 1);

                do
                {
                    g.data = Convert.ToDateTime(Microsoft.VisualBasic.Interaction.InputBox("Digite a data e horario do agendamento (dd/mm/aaaa hh:mm)"));
                    verificador = 0;
                    foreach (Agendamento x in Agendamentos)
                    {
                        if (g.data == x.data)
                        {
                            MessageBox.Show("Já existe um agendamento nesta data e horário, por favor digite uma outra data!");
                            verificador = 1;
                            break;


                        }



                    }
                }
                while (verificador == 1);


                Agendamentos.Add(g);

                    
            }


         if (op==4)
         {
             Int64 referencia;
             verificador=0;

             referencia = Convert.ToInt64(Microsoft.VisualBasic.Interaction.InputBox("Digite o Registro do veterinário que deseja alterar"));

             foreach (Veterinario x in Veterinarios)
             {
                 if (referencia == x.registro)
                 {
                     x.nome = (Microsoft.VisualBasic.Interaction.InputBox("Digite o novo nome do veterinário"));
                     x.cpf = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Digite o novo CPF do veterinário"));
                     x.data = Convert.ToDateTime(Microsoft.VisualBasic.Interaction.InputBox("Digite a nova data de nascimento do veterinário (dd/mm/aaaa)"));
                     verificador=1;
                     break;



       }

             }
             if (verificador == 1) MessageBox.Show("Veterinario Alterado com Sucesso");
             else MessageBox.Show("Veterinario não encontrado");




         }

         if (op==5)
                {
                    Int64 referencia;
                    verificador = 0;

                    referencia = Convert.ToInt64(Microsoft.VisualBasic.Interaction.InputBox("Digite o codigo do animal que deseja alterar"));

                    foreach (Animal x in Animais)
                    {
                        if (referencia == x.codigo)
                        {
                            x.nome = (Microsoft.VisualBasic.Interaction.InputBox("Digite o novo nome do Animal"));
                            x.raca = (Microsoft.VisualBasic.Interaction.InputBox("Digite a nova raça do animal"));
                            x.data = Convert.ToDateTime(Microsoft.VisualBasic.Interaction.InputBox("Digite a nova data de nascimento do animal (dd/mm/aaaa)"));
                            verificador = 1;
                            break;



                        }

                    }
                    if (verificador == 1) MessageBox.Show("Animal Alterado com Sucesso");
                    else MessageBox.Show("Animal não encontrado");



                }

        if (op==6)
                {
                    Int64 referencia;
                    verificador = 0;
                    int agendado=0;
                    

                   referencia = Convert.ToInt64(Microsoft.VisualBasic.Interaction.InputBox("Digite o Registro do veterinário que deseja remover"));
            foreach (Agendamento x in Agendamentos)
            {
                if (referencia==x.veterinario)
                {
                    MessageBox.Show("O veterinário não pode ser removido, pois esta em cadastrado em uma consulta, remova a consulta e tente novamente!!");
                    agendado = 1;
                    break;

                }


            }





            if (agendado==0)
            {
                   foreach (Veterinario x in Veterinarios)
                   {
                       if (referencia == x.registro)
                       {
                           Veterinarios.Remove(x);

                           verificador = 1;
                           break;



                       }

                   }
                   if (verificador == 1) MessageBox.Show("Veterinario removido com Sucesso");
                   else MessageBox.Show("Veterinario não encontrado");
                }




                }

                if (op==7)
                {
                    Int64 referencia;
                    verificador = 0;
                    int agendado = 0;

                    referencia = Convert.ToInt64(Microsoft.VisualBasic.Interaction.InputBox("Digite o Codigo do animal que deseja remover"));
                    foreach (Agendamento x in Agendamentos)
                    {
                        if (referencia == x.animal)
                        {
                            MessageBox.Show("O Animal não pode ser removido, pois esta em cadastrado em uma consulta, remova a consulta e tente novamente!!");
                            agendado = 1;
                            break;

                        }


                    }
                    if (agendado==0)
                    { 

                    foreach (Animal x in Animais)
                    {
                        if (referencia == x.codigo)
                        {
                            Animais.Remove(x);

                            verificador = 1;
                            break;



                        }

                    }
                    if (verificador == 1) MessageBox.Show("Animal removido com Sucesso");
                    else MessageBox.Show("Animal não encontrado");
                    }





                }

                if (op==8)
                {
                    Int64 referencia;
                    verificador = 0;
                    referencia = Convert.ToInt64(Microsoft.VisualBasic.Interaction.InputBox("Digite o Codigo da consulta que deseja remover"));
                    foreach (Agendamento x in Agendamentos)
                    {
                        if (referencia == x.codigo)
                        {
                            Agendamentos.Remove(x);

                            verificador = 1;
                            break;



                        }



                    }
                    if (verificador == 1) MessageBox.Show("Consulta removido com Sucesso");
                    else MessageBox.Show("Consulta não encontrado");
                    





                }

                if (op==9)
                {
                    Console.Write("-------------------Veterinários-------------------\n");
                    foreach (Veterinario x in Veterinarios)
                    {
                        x.imprimir();
                    }

                    Console.Write("\n\n-------------------Animais-------------------\n");
                    foreach (Animal x in Animais)
                    {
                        x.imprimir();
                    }

                    Console.Write("\n\n-------------------Consultas-------------------\n");
                    foreach (Agendamento x in Agendamentos)
                    {
                        x.imprimir();
                    }
                    
                    Console.ReadKey();
                    Console.Clear();





                }




}
            while (op<10);














































        }
        
    }
}
