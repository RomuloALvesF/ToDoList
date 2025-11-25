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

            string? entrada = Console.ReadLine();             

            if (!int.TryParse(entrada, out opcao))
            {
                Console.WriteLine("Entrada inválida, Digite um número.");
                continue;
            }

            switch (opcao) 
            {
                case 1:
                    var titulo = Console.ReadLine();
                    var descricao = Console.ReadLine();

                    if (String.IsNullOrEmpty(titulo) || String.IsNullOrEmpty(descricao))
                    {
                        Console.WriteLine("Titulo ou descrição vazios, preenchimanto obrigatorio, reinicie o processo e tente novamente!");
                        return;
                    }                       
                    crud.Cadastrar(titulo, descricao);
                    break;
                case 2:
                    Console.WriteLine(crud.Listar());
                    break;
                case 3:
                    Console.WriteLine();
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