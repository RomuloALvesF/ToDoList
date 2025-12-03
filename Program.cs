namespace ToDoList;

public static class Program
{
    public static void Main()
    {

        int opcao;
        Crud crud = new Crud();

        do
        {

            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Listar tarefas");
            Console.WriteLine("3 - Marcar como concluída");
            Console.WriteLine("4 - Editar tarefa");
            Console.WriteLine("5 - Excluir tarefa");
            Console.WriteLine("6 - Sair");

            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("-----------------");

            string? entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out opcao))
            {
                Console.WriteLine("Entrada inválida, Digite um número.");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("CADASTRO DE TAREFAS");
                    Console.WriteLine("                   ");

                    Console.WriteLine("Digite o titulo da tarefa:");
                    var titulo = Console.ReadLine();

                    Console.WriteLine("Digite a descrição da tarefa:");
                    var descricao = Console.ReadLine();

                    if (String.IsNullOrEmpty(titulo) || String.IsNullOrEmpty(descricao))
                    {
                        Console.WriteLine("Titulo ou descrição vazios, preenchimanto obrigatorio, reinicie o processo e tente novamente!");
                        return;
                    }
                    crud.Cadastrar(titulo, descricao);
                    Console.WriteLine("Tarefa cadastrada com sucesso");
                    Console.WriteLine("-----------------------------");
                    break;
                case 2:
                    Console.WriteLine("LISTAGEM DE TAREFA");
                    Console.WriteLine(crud.Listar());
                    break;
                case 3:
                    Console.WriteLine("Digite o ID da tarefa que quer conlcuir: ");
                    var concluir = Console.ReadLine();

                    if (!int.TryParse(concluir, out int opcaoConcluir))
                    {
                        Console.WriteLine("Digite um valor valido! Recomece a operação.");
                        return;
                    }

                    if (crud.MarcarConcluida(opcaoConcluir) == false)
                    {
                        Console.WriteLine("Tarefa concluida com sucesso");
                        Console.WriteLine("----------------------------");
                    }


                    break;
                case 4:
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Finalizando...");
                    break;
            }

        }
        while (opcao != 6);

    }
}