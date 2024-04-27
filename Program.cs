Console.WriteLine("Quantos itens irá ter na lista?");
int quantidadeItens = int.Parse(Console.ReadLine());

// Cria um vetor para armazenar a quantidade de itens
string[] itens = new string[quantidadeItens];

// Solicita e armazena os itens
for (int i = 0; i < quantidadeItens; i++)
{
    Console.Write($"Item {i + 1}: ");
    string item = Console.ReadLine();

    // Pesquisar se já existe algum item com mesmo nome
    bool repeticao = false;

    for (int j = 0; j < quantidadeItens; j++)
    {
        if (itens[j] != null)
        {
            if (item.ToUpper() == itens[j].ToUpper())
            {
                repeticao = true;
            }
        }
    }

    if (!repeticao)
        itens[i] = item;
    else
    {
        Console.WriteLine("Não é possivel adicionar o mesmo item!");
        i--;
    }
}

// Limpa a tela
Console.Clear();

// Exibe os itens
Console.WriteLine("Sua lista de itens:");
for (int i = 0; i < quantidadeItens; i++)
{
    Console.WriteLine($"{i + 1}. {itens[i]}");
}