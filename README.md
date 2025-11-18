# ToDoList

Dando inicio aos estudos de .NET.

Esse projeto tem como objetivo ser o primeiro de diversos até alcançar o nível avançado nas tecnologias citadas, estou pedindo a IA para me dar os projetos em diferentes niveis, e agindo como se fossem demandas que chegam ao desenvolvedor com alguns apontamentos de como ela deve ser e suas etapas.

#Regra pessoal: Duvidas que surgirem não podem ser usados recursos de IA apenas a documentação e pesquisas independentes de IA.

Esse projeto terá:

# Plano geral (visão rápida)

1. Criar projeto Console App em C#
2. Implementar classe `Tarefa`
3. Criar repositório/lista de tarefas e ID incremental
4. Implementar menu em loop e comandos do CRUD (Add, List, Complete, Edit, Delete)
5. Testes manuais e tratamento de erros
6. (Opcional) Persistência em arquivo `.json`

## Passo 1 — Preparar o ambiente

## Passo 2 — Criar a classe `Tarefa`

* Crie um arquivo `Tarefa.cs`.
* Propriedades obrigatórias:

  * `int Id { get; set; }`
  * `string Titulo { get; set; }`
  * `string Descricao { get; set; }`
  * `bool Concluida { get; set; }`
  * `DateTime DataCriacao { get; set; }`

## Passo 3 — Criar armazenamento em memória e ID incremental e uso de LIST<>

## Passo 4 — Implementar o menu principal (loop)

  * Mostrar opções:

    ```
    1 - Adicionar tarefa
    2 - Listar tarefas
    3 - Marcar como concluída
    4 - Editar tarefa
    5 - Excluir tarefa
    6 - Sair
    ```

## Passo 5 — Implementar “Adicionar tarefa”

* Método `AdicionarTarefa()`:

  * Pergunta título: `Console.Write("Título: "); var titulo = Console.ReadLine();`
  * Pergunta descrição.
  * Valide: título não pode ser vazio (se vazio, peça novamente).
  * Crie `Tarefa` com `Id = proximoId`.
  * Adicione em `tarefas`.

## Passo 6 — Implementar “Listar tarefas”

* Método `ListarTarefas()`:

  * Se `tarefas.Count == 0` mostre “Nenhuma tarefa”.
  * Para cada tarefa imprima algo legível, por exemplo:

    ```
    ID: 1 - Comprar pão
    Descrição: Ir à padaria
    Status: Pendente
    Criada em: 14/11/2025 10:30
    ---------------------------
    ```
  * Mostrar também se está concluída (`Concluída` / `Pendente`).

## Passo 7 — Implementar “Marcar como concluída”

* Método `MarcarConcluida()`:

  * Pergunte `ID:` e leia número (use `int.TryParse`).
  * Procure tarefa: `var t = tarefas.FirstOrDefault(x => x.Id == id);`
  * Se não encontrar, avise.
  * Se encontrar, defina `t.Concluida = true`.

## Passo 8 — Implementar “Editar tarefa”

* Método `EditarTarefa()`:

  * Pergunte `ID:` e busque a tarefa.
  * Se não existir, avise.
  * Pergunte novo título (use o atual como sugestão) — se o usuário deixar em branco, mantenha o anterior.
  * Pergunte nova descrição (mesma regra).
  * Não altere `DataCriacao` nem `Id`.

## Passo 9 — Implementar “Excluir tarefa”

* Método `ExcluirTarefa()`:

  * Pergunte `ID:`.
  * Busque tarefa.
  * Se não existir, avise.
  * Pergunte confirmação `Tem certeza? (S/N)`.
  * Se confirmado, `tarefas.Remove(t)`.

**Erros comuns:** tentar remover enquanto itera a lista.

## Passo 10 — Tratamento de erros e UX simples

* Use `int.TryParse` sempre que ler números. Não quebre o programa com exceções.
* Trate `null` ao buscar tarefas.
* Mensagens curtas e informativas (ex.: “ID não encontrado”, “Tarefa atualizada com sucesso”).
* Após cada ação, espere um `Console.ReadKey()` para o usuário ver a mensagem e então volte ao menu.




