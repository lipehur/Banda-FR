string mensagemDeBoasVindas = "Bem vindo ao FR Music";


void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
███████╗██████╗░  ███╗░░░███╗██╗░░░██╗░██████╗██╗░█████╗░
██╔════╝██╔══██╗  ████╗░████║██║░░░██║██╔════╝██║██╔══██╗
█████╗░░██████╔╝  ██╔████╔██║██║░░░██║╚█████╗░██║██║░░╚═╝
██╔══╝░░██╔══██╗  ██║╚██╔╝██║██║░░░██║░╚═══██╗██║██║░░██╗
██║░░░░░██║░░██║  ██║░╚═╝░██║╚██████╔╝██████╔╝██║╚█████╔╝
╚═╝░░░░░╚═╝░░╚═╝  ╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░");

    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para avaliar uma banda");
    Console.WriteLine("Digite 3 para remover uma banda");
    Console.WriteLine("Digite 4 para classificar as bandas");
    Console.WriteLine("Digite -1 para sair");

    Console.WriteLine("Digite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoNumericaEscolhida = int.Parse(opcaoEscolhida);

    switch (opcaoNumericaEscolhida)
    {
        case 1:
            Console.WriteLine($"Você digitou  {opcaoNumericaEscolhida}");
            break;
        case 2:
            Console.WriteLine($"Você digitou  {opcaoNumericaEscolhida}");
            break;
        case 3:
            Console.WriteLine($"Você digitou {opcaoNumericaEscolhida}");
            break;
        case 4:
            Console.WriteLine($"Você digitou {opcaoNumericaEscolhida}");
            break;
        case -1:
            Console.WriteLine($"Você digitou {opcaoNumericaEscolhida}");
            break;
        default:
            Console.WriteLine("Você digitou uma opção invalida");
            break;
    }


}



ExibirMensagemDeBoasVindas();
ExibirOpcoesMenu();
