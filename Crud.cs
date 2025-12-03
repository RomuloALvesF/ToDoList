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

            tarefa.Add(new Tarefa(DateTime.Now, true)
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
                Console.WriteLine("                    ");
                Console.WriteLine("ID:" + minhaTarefa.Id);
                Console.WriteLine("TITULO:" + minhaTarefa.Titulo);
                Console.WriteLine("DESCRIÇÃO:" + minhaTarefa.Descricao);
                Console.WriteLine("DATA:" + minhaTarefa.Data);
            
                
                if (minhaTarefa.Status == true)
                {
                     Console.WriteLine("STATUS: Tarefa em andamento"); //tenho que atualizar esse Listar
                }
                else
                {
                    Console.WriteLine("STATUS: Tarefa concluida");
                }    
            }
            return "-----------------------";
        }
            
        public bool MarcarConcluida(int id)
        {
            
            var t = tarefa.FirstOrDefault(x => x.Id == id);

            if (t == null)
            {
                Console.WriteLine("Tafera: " + id + " não encontrada!");              
            }

            return t.Status = false;
            
        }
        
    }
}
