Random rand = new Random();
int ranNum;
int escolha;
string[] escolhaSis = {"Pedra", "Papel", "Tesoura"};

do
{
    ranNum = rand.Next(0, 2);


    Console.Write("1.Pedra\n2.Papel\n3.Tesoura\n0.Sair\nEscolha: ");
    while(!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha > 3){Console.Write("Número inválido! Tente novamente: ");}
    string ppt = escolha == 1 ? "Pedra" : escolha == 2 ? "Papel" : "Tesoura";


    Console.Write($"\nVocê escolheu: {ppt}\nSistema escolheu: {escolhaSis[ranNum]}\nResultado: ");
    if(ranNum == escolha - 1)
    {
        Console.Write("Empate!\n\n");
    }
    else if(ranNum == 0 && escolha == 3 || ranNum == 1 && escolha == 1 || ranNum == 2 && escolha == 2)
    {
        Console.Write("Sistema venceu!\n\n");
    }
    else
    {
        Console.Write("Você venceu!\n\n");
    }
}
while(escolha != 0);
