using System;

namespace ProjetoFIRE
{
    class ColetorDeDados
    {
        public static DadosFIRE Executar()
        {
            var dados = new DadosFIRE();

            Console.WriteLine("Idade atual: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int idade) && idade > 0 && idade <= 100)
                {
                    dados.Idade = idade;
                    break;
                }
                else
                    Console.WriteLine("Idade Invalida Digite um numero Inteiro de 1 a 100: ");
            }
            Console.WriteLine("Patrimonio: ");
            while (true)
            {
                if (decimal.TryParse(Console.ReadLine(), out decimal partrimonio) && partrimonio >= 0)
                {
                    dados.Patrimonio = partrimonio;
                    break;
                }
                else
                {
                    Console.WriteLine("Digite um numero Positivo: ");
                }
            }
            Console.WriteLine("Aportes Mensais: ");
            while (true)
            {
                if (decimal.TryParse(Console.ReadLine(), out decimal aporte) && aporte >= 0)
                {
                    dados.AporteMensal = aporte;
                    break;
                }
                else
                {
                    Console.WriteLine("Digite um numero Positivo: ");
                }
            }
            Console.WriteLine("Retorno Anual EX 4 para 4%: ");
            while (true)
            {
                if (decimal.TryParse(Console.ReadLine(), out decimal retornoAnual) && retornoAnual > 0)
                {
                    dados.RetornoAnual = retornoAnual/100m;
                    break;
                }
                else
                {
                    Console.WriteLine("Digite um numero Positivo diferente de 0: ");
                }
            }
            Console.WriteLine("Salario desejado: ");
            while (true)
            {
                if (decimal.TryParse(Console.ReadLine(), out decimal salario) && salario > 0)
                {
                    dados.SalarioDesejado = salario;
                    break;
                }
                else
                {
                    Console.WriteLine("Digite um numero Positivo diferente de 0: ");
                }
            }

            Console.WriteLine("=== Estilo FIRE ===\n");
            Console.WriteLine("[1] FIRE Tradicional  → 4,0% | Regra clássica — Trinity Study (1998)");
            Console.WriteLine("[2] FIRE Conservador  → 3,5% | Margem extra para horizontes longos");
            Console.WriteLine("[3] Barista FIRE      → 4,0% | Trabalho parcial + meta menor\n");
            Console.Write("Escolha seu estilo (1-3): ");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int estiloFIRE) && estiloFIRE > 0 && estiloFIRE <= 3)
                {
                    dados.EstiloFIRE = estiloFIRE;
                    break;
                }
                else
                    Console.WriteLine("Digite uma opçao valida\n[1] Padrão americano 4%\n[2] FIRE Equilibrado 3,5%)\n[3] FIRE Conservador\n[4] Barista FIRE (FIRE pacial para quem continuar trabalhando)");
            }
            return dados;
        }
    }
}