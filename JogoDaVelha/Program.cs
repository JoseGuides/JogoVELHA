// See https://aka.ms/new-console-template for more information
bool b = false;

/* A gente precisa achar uma forma de não encerrar o programa quando o jogo acabar
 toda vez que eu tentei um laço while eu entrava em um loop infinito
 */
Console.WriteLine("|=======================================================|");
//pensei nas barras para deixar o jogo com algo um pouco mais visual que não seja 
// apenas letras e numeros, deixar ele um pouco mais ""bonito""
Console.WriteLine("|||||||||||||||||||---MENU PRINCIPAL---||||||||||||||||||");
Console.WriteLine("|=======================================================|");

while (!b) { 

Console.WriteLine("Sempre que quiser sair do jogo aperte 'S'");
Console.WriteLine("Escolha o modo de jogo: ");
Console.WriteLine("1 - Jogador vs Jogador");
Console.WriteLine("2 - Jogador vs Computador");
Console.WriteLine("3 - Sair do jogo");
Console.Write("Selecione: ");

string modoDeJogo = Console.ReadLine();
int modoDeJogoConvert = Convert.ToInt32(modoDeJogo);
/*se digita alguma letra ele esta dando erro e fechando automaticamente, achar  algum jeito
 de aparecer alguma mensagem se o usuario digitar alguma letra e nao apenas fechar*/

Console.Clear();
/*Método que eu encontrei para limpar a tela do console, ele consegue limpar para deixar mais 
 organizado e também da a sensação de "trocar de tela" para o jogo
 */

switch (modoDeJogoConvert)
{
    case 1:
        InicieJogadorVSJogador();
        /* acredito que se separarmos os modos por funções (Como no Javascript), irá ficar mais
         organizado de montar os códigos
        */
        break;
    case 2:
        InicieJogadorVSPc();
        break;
    case 3:
        Console.WriteLine("Jogo encerrado!");
        break;
    default:
        Console.WriteLine("Tecla inválida :(");
        break;
}

static void InicieJogadorVSJogador()
{
    Console.WriteLine("|====================================|");
    Console.WriteLine("|Modo selecionado: Jogador vs Jogador|");
    Console.WriteLine("|====================================|");
}

static void InicieJogadorVSPc()
{
    Console.WriteLine("|=======================================|");
    Console.WriteLine("|Modo selecionado: Jogador vs computador|");
    Console.WriteLine("|=======================================|");
    Console.WriteLine("Selecione a dificuldade do jogo: ");
    Console.WriteLine("D - Dificil");
    Console.WriteLine("F - Facil");
    string dificuldade = Console.ReadLine();
    Console.Clear();
    switch (dificuldade)
    {
        case "F":
            InicieModoFacil();
            break;
        case "D":
            InicieModoDificil();
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;
    }
    
}
static void InicieModoFacil()
{
    Console.WriteLine("==Modo Fácil===");
}

static void InicieModoDificil()
{
    Console.WriteLine("==Modo Dificil==");
}


    if (modoDeJogoConvert == 3)
    {
        b = true;
    }
}


// Teste pra ve se o bagua me aceita la





