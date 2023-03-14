using EX_OO_02;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa("Ari","(00)0000-0000","Rua do Ari");
        Professor professor = new Professor("Prof. Pardal", "190","Rua Copacabana, 1000", 1234.56);
        Professor professor2 = new Professor(pessoa, 2345.67);

        Console.WriteLine(pessoa.ToString());
        Console.WriteLine(professor2.ToString());

        Estudante estudante = new Estudante("João", "(00)000-000","Avenida do João", 1234);

        Console.WriteLine("A média aritmética do aluno de matricula " + estudante.Matricula + " é " + estudante.CalcularMedia(6.00, 7.00));

        Console.WriteLine("Digite a primeira nota");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o peso da primeira nota:");
        int peso1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota");
        double nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o peso da primeira nota:");
        int peso2 = int.Parse(Console.ReadLine());

        Console.WriteLine("A média ponderada do aluno de matricula " + estudante.Matricula + " é " + estudante.CalcularMedia(nota1, peso1, nota2, peso2).ToString("F2"));





    }
}