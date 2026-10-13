
Menu();


static void Menu() {
    Console.Clear();
    Console.WriteLine("O que você quer fazer?");
    Console.WriteLine("1 - Abrir arquivo");
    Console.WriteLine("2 - Criar arquivo");
    Console.WriteLine("3 - Sair");
    short option = short.Parse(Console.ReadLine());

    switch(option)
    {
        case 1: Abrir(); break;
        case 2: Editar(); break;
        case 3: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
}


static void Abrir()
{

}

static void Editar()
{
}
