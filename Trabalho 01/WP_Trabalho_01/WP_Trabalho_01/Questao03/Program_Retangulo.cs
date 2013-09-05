using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WP_Trabalho_01.Questao03
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            TextReader reader = System.Console.In;
            TextWriter writer = System.Console.Out;

            float base_local = 0.0f, altura_local = 0.0f, base_azulejo = 0.0f, altura_azulejo = 0.0f;
            string linha="";
            
            writer.WriteLine("Informe a medida da largura (base) do local? ");
            linha = reader.ReadLine();
            try
            {
                base_local = float.Parse(linha);
            }
            catch (Exception e)
            {
                e.ToString();
                writer.WriteLine("Valor da largura do local inválido");
                reader.ReadLine();
                Environment.Exit(1);
            }

            writer.WriteLine("Informe a medida da comprimento (altura) do local? ");
            linha = reader.ReadLine();
            try
            {
                altura_local = float.Parse(linha);
            }
            catch (Exception e)
            {
                e.ToString();
                writer.WriteLine("Valor do comprimento do local inválido");
                reader.ReadLine();
                Environment.Exit(1);
            }

            writer.WriteLine("Informe a medida da base do azulejo? ");
            linha = reader.ReadLine();
            try
            {
                base_azulejo = float.Parse(linha);
            }
            catch (Exception e)
            {
                e.ToString();
                writer.WriteLine("Valor da base do azulejo inválido");
                reader.ReadLine();
                Environment.Exit(1);
            }


            writer.WriteLine("Informe a medida da altura do azulejo? ");
            linha = reader.ReadLine();
            try
            {
                altura_azulejo = float.Parse(linha);
            }
            catch (Exception e)
            {
                e.ToString();
                writer.WriteLine("Valor da altura do azulejo inválido");
                reader.ReadLine();
                Environment.Exit(1);
            }

            Retangulo dim_local = new Retangulo(base_local, altura_local);
            Retangulo dim_azulejo = new Retangulo(base_azulejo, altura_azulejo);

            double azulejos_cobertura_area = 
                Math.Ceiling(System.Convert.ToDouble(dim_local.calculaArea() / dim_azulejo.calculaArea()));
            double azulejos_cobertura_perimetro = 
                Math.Ceiling(System.Convert.ToDouble(dim_local.calculaPerimetro() / dim_azulejo.retornaBase()));

            writer.WriteLine("Azulejos para cobrir a área do local: {0}", azulejos_cobertura_area);
            writer.WriteLine("Azulejos para construir o rodapé: {0}", azulejos_cobertura_perimetro);

            reader.ReadLine();
        }
    }
}
