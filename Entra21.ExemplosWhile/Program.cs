using Entra21.ExemplosWhile;

Console.Write(@"------Arquivos-------
1 - Exercício 01");
Console.WriteLine("Digite a opção desejada: ");
var exercicioUsuario = Convert.ToInt32(Console.ReadLine());

if(exercicioUsuario == 1)
{
    var exercico01 = new Exercicio01();
    exercico01.Executar();
}