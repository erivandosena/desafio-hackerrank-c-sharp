using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            int maxDigit = 6;

            List<int> num = obtemCalculo(maxDigit);
            num.ForEach(f => { Console.WriteLine(f); });
            Console.Read();
        }

        /*
        Função que devolve todos os possíveis números de 4 dígitos, sendo cada um
        menor ou igual a <maxDigit> onde a soma dos dígitos dos mesmos seja 21.
        */
        private static List<int> obtemCalculo(int maxDigit)
        {
            List<int> lista = new List<int>(1);
            
            for (int novoNumero = 1000; novoNumero <= 7770; novoNumero++)
            {
                string numeroGeradoString = novoNumero.ToString();
                List<int> digitosDoNumeroGerado = new List<int>(4);

                for (int y = 0; y < novoNumero.ToString().Length; y++)
                    digitosDoNumeroGerado.Add(Convert.ToInt32(numeroGeradoString.Substring(y, 1)));

                if (digitosDoNumeroGerado.Max() > maxDigit)
                    continue;

                int soma = 0;
                for (int n = 0; n < novoNumero.ToString().Length; n++)
                    soma += Convert.ToInt32(numeroGeradoString.Substring(n, 1));

                if (soma == 21)
                    lista.Add(novoNumero);
            }

            return lista.Any() ? lista : null;
        }
    }
}