namespace ToDoList;
public static class Program
{
    public static void Main()
    {

        int opcao;

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
        }
        while (opcao != 6);


    }
}