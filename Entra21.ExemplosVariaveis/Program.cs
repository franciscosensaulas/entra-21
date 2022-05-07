namespace Entra21.ExemploVariaveis
{
    public class Exemplo01
    {
        public static void Main(params string[] args)
        {
            //Console.WriteLine("Olá mundo");

            //// Nome do arquivo -> Nome da classe = Exemplo01.cs

            //Console.WriteLine("Soma: 2 + 2"); // Saída: "Soma: 2 + 2"
            //Console.WriteLine("Soma: " + 2 + 2); // Saída: "Soma: 22"

            //// string é um tipo para armazenar textos
            //// string + string = concatenação

            //Console.WriteLine("Olá Mundo");
            //Console.WriteLine("Soma: " + (2 + 2));
            //Console.WriteLine("Subtração: " + (2 - 2));
            //Console.WriteLine("Multiplicação: " + (2 * 2));
            //Console.WriteLine("Divisão: " + (2 / 2));
            //Console.WriteLine("Resto da divisão: " + (2 % 2));

            //// string => para armazenar textos: "Olá mundo"
            //// double => para armazenar números reais: 21.0 , -21.1
            //// int => para armazenar números inteiros: 21, -21

            //// Variável: é o local onde é possível armazenar algo

            //int nota1 = 9;
            //int nota2 = 8;
            //int nota3 = 9;
            //// Forma de calcular a média direto com a soma
            //// double media = (nota1 + nota2 + nota3) / 3;

            //int soma = nota1 + nota2 + nota3;
            //double media = soma / 3;

            //string nome = "Pedro";
            //string sobrenome = "Souza";
            //string nomeCompleto = nome + " " + sobrenome;
            //Console.WriteLine("Nome completo: " + nomeCompleto);

            //Console.Clear();

            //// Como solicitar informações para o usuário
            //Console.WriteLine("Nome: ");
            //string nomeProfessor = Console.ReadLine();

            //Console.Write("Sobrenome: ");
            //string sobrenomeProfessor = Console.ReadLine();

            //string nomeProfessorCompleto = nomeProfessor + " " + sobrenomeProfessor;

            //Console.WriteLine("Nome completo: " + nomeProfessorCompleto);

            //// Tudo o que o usuário digita é string
            //// Ou seja, não é possível armazenar em um inteiro
            //// é necessário fazer uma conversão

            //// Conversão de string para inteiro
            //int numero1 = Convert.ToInt32("10");
            //int numero2 = Convert.ToInt32("8001");
            //int somaNumeros = numero1 + numero2;

            //Console.WriteLine("Soma dos números: " + somaNumeros);

            /********************** Conversão de valores ****************/

            //// Conversão de string para double
            //double valor = Convert.ToDouble("2.30");

            // Conversão de string para bool
            bool vivo = Convert.ToBoolean("true");

            // Solicitar os dados
            Console.Write("Número da sorte: ");
            int numeroDaSorte = Convert.ToInt32(Console.ReadLine());

            Console.Write("Valor: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            // Limpar a tela
            Console.Clear();

            Console.WriteLine("Número da sorte: " + numeroDaSorte);
            Console.WriteLine("Valor: R$ " + valor);

            /********************** Exemplo 01 ****************/
            // Solicitar a quantidade de horas trabalhadas e o valor hora
            // Apresentar ao final o salário bruto

            // INPUT: Entra (solicitar informações)
            Console.WriteLine("Digite a quantidade: ");
            int quantidadeHorasTrabalhadas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor hora");
            double valorHora = Convert.ToDouble(Console.ReadLine());

            // Processamento
            double salarioBruto = quantidadeHorasTrabalhadas * valorHora;

            // Output: Saída (apresentar para o usuário)
            Console.Clear(); 
            Console.WriteLine("Salário Bruto: R$ " + salarioBruto);

            /********************** Exemplo 02 - Concatenação ****************/
            // tipoVariavel + nomeVariavel = valor
            string nomePersonagem = "Alberto";
            Console.WriteLine("Nome personagem: " + nomePersonagem);// Output: NomePersonagem: Alberto

            nomePersonagem = "Paolo";
            Console.WriteLine("Nome personagem: " + nomePersonagem);// Output: NomePersonagem: Paolo

            // Concatenação  da variável nome com texto "da Silva"
            nomePersonagem = nomePersonagem + " da Silva";
            Console.WriteLine("Nome personagem: " + nomePersonagem);// Output: NomePersonagem: Paolo da Silva

            /********************** Exemplos Regra de 3 ****************/
            // QuantidadeTotal      PercentualTotal
            // QuantidadeParcial    PercentualParcial

            // Descobrir o percentual de algo
            // 3120                 100
            // 300                  percentualParial
            int quantidadeTotalArquivos = 3120;
            int quanitdadeParcialArquivos = 300;

            // percentualParcial => (300 * 100) / 3120
            double percentualParcial = (quantidadeTotalArquivos * 100) / quantidadeTotalArquivos;
            Console.WriteLine("Percentual parcial: " + percentualParcial);
        }
    }
}