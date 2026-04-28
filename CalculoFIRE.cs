using System;

namespace ProjetoFIRE
{
    class CalculoFIRE
    {
        public static (decimal meta, decimal Patrimonio, int meses) NumeroFire()
        {
            var dados = ColetorDeDados.Executar();
            var patrimonio = dados.Patrimonio;
            decimal TSR = 0;
            switch (dados.EstiloFIRE)
            {
                case 1:
                    TSR = 0.04m;
                    break;
                case 2:
                    TSR = 0.035m;
                    break;
                case 3:
                    Console.WriteLine("[Opção Barista em breve]");
                    TSR = 0.04m;
                    break;
            }
            decimal meta = (dados.SalarioDesejado * 12) / TSR;
            var meses = 0;

            var retornoMensal = (decimal)Math.Pow((double)(1 + dados.RetornoAnual), 1.0 / 12) - 1;

            while (patrimonio < meta && meses < 1200)
            {
                patrimonio = patrimonio * (1 + retornoMensal) + dados.AporteMensal;
                meses++;
            }
            if (meses >= 1200)
            {
                Console.WriteLine("Não foi possivel alcançar o FIRE em 100 Anos aumente os aportes");
            }
            
            return (meta, patrimonio, meses);
        }
    }
}