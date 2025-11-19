using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ToDoList
{
    public class Crud
    {
        List<Tarefa> tarefa = new List<Tarefa>();

        public void Cadastrar()
        {
            int proximoId = 1;

            tarefa.Add(new Tarefa(DateTime.Now, true)
            {
                Id = proximoId++,
                Descricao = "Estudos",
                Titulo = "Estudar todos os dias da semana!",


            });

            tarefa.Add(new Tarefa(DateTime.Now, true)
            {
                Id = proximoId++,
                Descricao = "Trabalhar",
                Titulo = "Trabalhar de segunda a sexta!",

            });
            Console.WriteLine("Cadastra");
        }

        public void Listar()
        {
            foreach (var minhaTarefa in tarefa)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine(minhaTarefa.Id);
                Console.WriteLine(minhaTarefa.Titulo);
                Console.WriteLine(minhaTarefa.Descricao);
                Console.WriteLine(minhaTarefa.Data);
                minhaTarefa.StatusTarefa();

            }
            return;
        }

    }
}
