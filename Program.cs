string mensagemDeBoasVindas = "\nSeja Bem-Vinda(o) ao SOUNDABLE";
Console.WriteLine(mensagemDeBoasVindas);

List<string> listaArtistas = new List<string>();

// funções

void ExibirLogo ()
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
    ExibirLogo();

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
        case 1: RegistrarArtista();
            break;
        case 2: MostrarArtistasRegistrados();
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

void RegistrarArtista()
{
    Console.Clear();
    ExibirTitulos("Registro de artistas");

    Console.Write("\nDigite o nome do artista: ");
    string nomeArtista = Console.ReadLine()!;
    listaArtistas.Add(nomeArtista);
    Console.WriteLine($"{nomeArtista} foi registrado com sucesso!");

    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

// for e foreach

void MostrarArtistasRegistrados()
{
    Console.Clear();
    ExibirTitulos("Exibindo artistas registrados.");

//    for (int i = 0; i < listaArtistas.Count; i++)
//    {
//        Console.WriteLine($"{listaArtistas[i]}");
//    }

    foreach (string artista in listaArtistas)
    {
        Console.WriteLine($"{artista}");
    }

    Console.WriteLine("\nSelecione qualquer tecla para voltar ao menu inicial.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void ExibirTitulos(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

ExibirOpcoesMenu();