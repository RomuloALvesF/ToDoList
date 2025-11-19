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

            switch (opcao) //lemnrar de usar o 1 - cadastrar antes de testar o 2 - listar. 
            {
                case 1:
                    crud.Cadastrar();
                    break;
                case 2:
                    Console.WriteLine(crud.Listar());
                    break;
                default:
                    Console.WriteLine("Invalida");
                    break;
            }

        }
        while (opcao != 6);
    }
}