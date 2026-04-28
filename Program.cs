using System;

namespace ProjetoFIRE
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultado = CalculoFIRE.NumeroFire();

            int anos = resultado.meses / 12;
            int mesesRestantes = resultado.meses % 12;

            Console.WriteLine("\n===== RESULTADO FIRE =====");
            Console.WriteLine($"Meta: {resultado.meta:C}");
            Console.WriteLine($"Patrimônio final: {resultado.Patrimonio:C}");
            Console.WriteLine($"Tempo: {anos} anos e {mesesRestantes} meses");
        }
    }
}