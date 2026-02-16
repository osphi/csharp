string mensagemDeBoasVindas = "\nSeja Bem-Vinda(o) ao projeto";
Console.WriteLine(mensagemDeBoasVindas);

string curso = "Csharp primeiro contato";
string nome = "Sophia";
string sobrenome = "Tiberio";

Console.WriteLine(curso);
Console.WriteLine(nome + sobrenome);

// funções

void ExibirMensagemDeBoasVindas ()
{
    Console.WriteLine(@"

░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░░█████╗░██████╗░██╗░░░░░███████╗
██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗██╔══██╗██╔══██╗██║░░░░░██╔════╝
╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║███████║██████╦╝██║░░░░░█████╗░░
░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║██╔══██║██╔══██╗██║░░░░░██╔══╝░░
██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝██║░░██║██████╦╝███████╗███████╗
╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░╚══════╝╚══════╝");

    Console.WriteLine(mensagemDeBoasVindas);
};

void ExibirOpcoesMenu()
{
    Console.WriteLine("\nDigite 1 para registrar um artista");
    Console.WriteLine("Digite 2 para exibir todos os artistas");
    Console.WriteLine("Digite 3 para avaliar um artista");
    Console.WriteLine("Digite 4 para exibir a média de avaliação do artista");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua escolha: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int numeroOpcaoEscolhida = int.Parse(opcaoEscolhida);

// switch case 

    switch (numeroOpcaoEscolhida)
    {
        case 1: Console.WriteLine("Sua escolha foi: " + numeroOpcaoEscolhida);
            break;
        case 2: Console.WriteLine("Sua escolha foi: " + numeroOpcaoEscolhida);
            break;
        case 3: Console.WriteLine("Sua escolha foi: " + numeroOpcaoEscolhida);
            break;
        case 4: Console.WriteLine("Sua escolha foi: " + numeroOpcaoEscolhida);
            break;
        case -1: Console.WriteLine("Tchau tchau, vejo você em breve! :)");
            break;
        default: Console.WriteLine("Opção Inválida");
            break;
    }
};

ExibirMensagemDeBoasVindas();
ExibirOpcoesMenu();