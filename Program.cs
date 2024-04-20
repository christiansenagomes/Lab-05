using System;
namespace Lab_05;

class Program
{
    static void Main(string[] args)
    {
        // Declaração de variáveis
        double notaProva1A, notaProva1B, notaProva2A, notaProva2B, notaAtividades;
        int frequencia;
        double notaModulo1, notaModulo2, notaTotal;
        // Interação com o usuário
        Console.WriteLine("Insira a quantidade de pontos obtidos na prova 1A (0 - 20): ");
        notaProva1A = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Insira a quantidade de pontos obtidos na prova 1B (0 - 20): ");
        notaProva1B = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Insira a quantidade de pontos obtidos na prova 2A (0 - 20): ");
        notaProva2A = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Insira a quantidade de pontos obtidos na prova 2B (0 - 20): ");
        notaProva2B = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Insira a quantidade de pontos obtidos nas atividades (0 - 20): (Resenhas/Laboratórios/ADA)");
        notaAtividades = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Insira a porcentagem de frequência no semestre: ");
        frequencia = int.Parse(Console.ReadLine()!);
        Console.WriteLine();
        // Processamento
        notaModulo1 = notaProva1A + notaProva1B;
        notaModulo2 = notaProva2A + notaProva2B;
        notaTotal = notaModulo1 + notaModulo2 + notaAtividades;
        Console.WriteLine($"Pontos obtidos no primeiro módulo: {notaModulo1}");
        Console.WriteLine($"Pontos obtidos no segundo módulo: {notaModulo2}");
        Console.WriteLine($"Pontos obtidos nas atividades: {notaAtividades}");
        if(frequencia < 75) {
            Console.WriteLine($"O aluno possui uma frequência menor que 75% no semestre ({frequencia}%), portanto está reprovado.");
        } else {
            if(notaTotal >= 60) {
                Console.WriteLine($"O aluno obteve uma nota total de {notaTotal} pontos, portanto está aprovado.");
            }
            else {
                Console.WriteLine($"O aluno obteve uma nota total de: {notaTotal} pontos. Faltam {60 - notaTotal} pontos para atingir a nota mínina de aprovação (60 pontos).");
                // Verificando se é possível atingir a média com a reavaliação, e imprimindo na tela
                if((notaModulo1 + notaAtividades) < 20 && (notaModulo2 + notaAtividades) < 20)
                    Console.WriteLine($"O aluno não pode realizar a reavaliação, portanto está reprovado.");
                else
                    Console.WriteLine($"O aluno pode realizar a reavaliação.");
            }
        }

    }
}
