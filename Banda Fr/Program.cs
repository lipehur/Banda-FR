string mensagemDeBoasVindas = "Bem vindo ao FR Music";
List<string> bandasRegistradas = new List<string>();


void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
███████╗██████╗░  ███╗░░░███╗██╗░░░██╗░██████╗██╗░█████╗░
██╔════╝██╔══██╗  ████╗░████║██║░░░██║██╔════╝██║██╔══██╗
█████╗░░██████╔╝  ██╔████╔██║██║░░░██║╚█████╗░██║██║░░╚═╝
██╔══╝░░██╔══██╗  ██║╚██╔╝██║██║░░░██║░╚═══██╗██║██║░░██╗
██║░░░░░██║░░██║  ██║░╚═╝░██║╚██████╔╝██████╔╝██║╚█████╔╝
╚═╝░░░░░╚═╝░░╚═╝  ╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░");

    Console.WriteLine("\n" + mensagemDeBoasVindas);
}

void ExibirOpcoesMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para ver as bandas registradas");
    Console.WriteLine("Digite 3 para remover uma banda");
    Console.WriteLine("Digite 4 dar uma nota para uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.WriteLine("Digite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoNumericaEscolhida = int.Parse(opcaoEscolhida);

    switch (opcaoNumericaEscolhida)
    {
        case 1: RegistroDaBanda();
            break;
        case 2: VerBandasRegistradas();
            break;
        case 3: Console.WriteLine($"Você digitou {opcaoNumericaEscolhida}");
            break;
        case 4: Console.WriteLine($"Você digitou {opcaoNumericaEscolhida}");
            break;
        case -1: Console.WriteLine($"Você digitou {opcaoNumericaEscolhida}");
            break;
        default: Console.WriteLine("Você digitou uma opção invalida");
            break;
    }


}

void RegistroDaBanda()
{
    Console.Clear();
    Console.Write("Digite a banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda);
    Console.WriteLine($"Banda {nomeDaBanda} registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMensagemDeBoasVindas();
    ExibirOpcoesMenu();
}

void VerBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("******************");
    Console.WriteLine("Bandas Registradas");
    Console.WriteLine("******************");

    if (bandasRegistradas.Count == 0)
    {

        Console.WriteLine(band);

        Console.WriteLine("Nenhuma banda registrada");
    }
    else
    {

        foreach (var band in bandasRegistradas)
        {
            Console.Write($"Banda: {band}");
        }

    }
}



ExibirMensagemDeBoasVindas();
ExibirOpcoesMenu();
