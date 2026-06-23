string mensagemDeBoasVindas = "Bem vindo ao FR Music";
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();


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
    Console.WriteLine("Digite 5 para mostrar a nota das bandas");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("Digite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoNumericaEscolhida = int.Parse(opcaoEscolhida);

    switch (opcaoNumericaEscolhida)
    {
        case 1: RegistroDaBanda();
            break;
        case 2: VerBandasRegistradas();
            break;
        case 3: RemoverBanda();
            break;
        case 4: DarNotaParaBanda();
            break;
        case 5: ExibirAsBandasESuasNotas();
            break;
        case -1: Console.WriteLine($"Até mais tchau tchau :)");
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
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"Banda {nomeDaBanda} registrada com sucesso!");
    Thread.Sleep(200);
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
        Console.WriteLine("\nNenhuma banda registrada");
    }
    else
    {
        foreach (var band in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {band}");
        }
    }
    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu de opções");
    Console.ReadKey();
    Console.Clear();
    ExibirMensagemDeBoasVindas();
    ExibirOpcoesMenu();

}

void RemoverBanda()
{
    Console.Clear();
    Console.WriteLine("*****************");
    Console.WriteLine("Remover uma banda");
    Console.WriteLine("*****************");

    foreach (var band in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {band}");
    }
    Console.Write("\nDigite o nome da banda que deseja remover: ");
    string nomeDaBandaParaRemover = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBandaParaRemover))
    {
        bandasRegistradas.Remove(nomeDaBandaParaRemover);
        Console.WriteLine($"\nA banda {nomeDaBandaParaRemover} foi removida com sucesso!");
    } 
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBandaParaRemover} não foi no encontrada no sistema");
    }

    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu de opções");
    Console.ReadKey();
    Console.Clear();
    ExibirMensagemDeBoasVindas();
    ExibirOpcoesMenu();
}

void DarNotaParaBanda()
{
    Console.Clear();
    Console.WriteLine("*******************");
    Console.WriteLine("Dar nota para banda");
    Console.WriteLine("*******************");

    foreach (var band in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {band}");
    }

    Console.Write("\nDigite o nome da banda que deseja dar uma nota: ");
    string nomeDaBandaParaDarNota = Console.ReadLine()!;

    
    if (bandasRegistradas.ContainsKey(nomeDaBandaParaDarNota))
    {
        
        Console.Write($"Digite a nota para dar a banda {nomeDaBandaParaDarNota}: ");
        string notaDaBanda = Console.ReadLine()!;
        int notaNumerica = int.Parse(notaDaBanda);

        bandasRegistradas[nomeDaBandaParaDarNota].Add(notaNumerica);
        Console.WriteLine($"A nota {notaNumerica} foi adicinada a banda {nomeDaBandaParaDarNota}");
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBandaParaDarNota} não foi encontrada no sistema");
    }

    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu de opções");
    Console.ReadKey();
    Console.Clear();
    ExibirMensagemDeBoasVindas();
    ExibirOpcoesMenu();
}

void ExibirAsBandasESuasNotas()
{
    Console.Clear();
    Console.WriteLine("*************************");
    Console.WriteLine("Notas e médias das bandas");
    Console.WriteLine("*************************");
    
    if (bandasRegistradas.Count == 0)
    {
        Console.WriteLine("Nenhuma banda registrada no sistema");
    } else
    {
        foreach (var banda_e_Notas in bandasRegistradas)
        {
            string nomeDaBanda = banda_e_Notas.Key;
            List<int> notas = banda_e_Notas.Value;

            string notasTexto = notas.Count > 0 ? string.Join(' ', notas) : "Sem notas";

            Console.WriteLine($"Bandas: {nomeDaBanda} - Nota: {notasTexto}");

        }
    }

    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu de opções");
    Console.ReadKey();
    Console.Clear();
    ExibirMensagemDeBoasVindas();
    ExibirOpcoesMenu();
}

ExibirMensagemDeBoasVindas();
ExibirOpcoesMenu();
