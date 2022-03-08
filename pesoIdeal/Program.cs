using System;

namespace pesoIdeal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float calculoPeso, altura;
            char sexo;
            Console.WriteLine("Informe o sexo da pessoa:\n M- Masculino\n F - Feminino");
            sexo = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Informe a altura da pessoa: ");
            altura = float.Parse(Console.ReadLine());

            if ((sexo == 'm') || (sexo == 'M')) {
                calculoPeso = (float)((72.7 * altura) - 58);
                Console.WriteLine("Como você é homem seu peso ideal é {0}", calculoPeso);
            } else
            {
                calculoPeso = (float)((62.1 * altura) - 44.7);
                Console.WriteLine("Como você é mulher seu peso ideal é {0}", calculoPeso);
            }
        }
    }
}
