// See https://aka.L;/new-console-template for more information
// comentario
Console.WriteLine("Hello, World!");//saida de dados, impressao em tela.

int numeroInteiro = 10;//Declaracao de variavel inteira ,recebendo valor 10
long numeroMaior = 1099999L;//Declaracao de variavel long, recebendo 1099999L
float numeroQuebrado = 6.8f;// Declaracao de variavel do tipo float
double numeroQuebradoMaior = 101.99999999D;//// Declaracao de variavel do tipo double
char letra = 'z';//Declaracao de variavel do tipo char(1 caracter)
string texto = "A turma estreito é a melhor.";// Declaracao tipo strig, recebendo uma frase
bool variavelBooleana = true;//// Declaracao tipo Bolleana. recebendo valor verdadeiro
DateTime data = DateTime.Now; //Declaracao de variavel tipo Datetme ( data ate o segundos) armazenando os segundo atuais
DateTime outraData = new DateTime(2023, 01, 31);//Instanciando da classe Date time ,passando parametro como mes e dia
texto.ToUpper(); //convertendo o texto p letra maiusculas
Console.WriteLine(" Frase com letra maiuscula:" + texto.ToUpper());

//Declaraçao de variavel
string nomeCompleto;
Console.Write("Digite o seu nome: ");// instruçao ao usuario, impressao em tela
nomeCompleto = Console.ReadLine();//Aguardadndo o usuario digitar no terminal
Console.WriteLine("O seu nome é:" + nomeCompleto);//  saida de dados,concatenando texto com valor da variavel



