using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace ToDoList
{
    public class Crud
    {
        List<Tarefa> tarefa = new List<Tarefa>();

        public void Cadastrar(string titulo, string descricao)
        {

            int proximoId = 1;

            tarefa.Add(new Tarefa(DateTime.Now, false)
            {

                Id = proximoId++,
                Descricao = descricao,
                Titulo = titulo,
            });
        }

        public String Listar()
        {

                          
            foreach (var minhaTarefa in tarefa)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine(minhaTarefa.Id);
                Console.WriteLine(minhaTarefa.Titulo);
                Console.WriteLine(minhaTarefa.Descricao);
                Console.WriteLine(minhaTarefa.Data);

                if (minhaTarefa.Status == true)
                {
                    Console.WriteLine("Tarefa concluida");
                }
                else
                {
                    Console.WriteLine("Tarefa em andamento");

                }

            }
            return "Colocar aqui a sequencia de opções";

        }
        
        
        public bool MarcarConcluida(int id)
        {
            
            var t = tarefa.FirstOrDefault(x => x.Id == id);

            if (t == null)
            {
                Console.WriteLine("Tafera: " + id + " não encontrada!");
            }

            return true;
            
        }
        
    }
}
