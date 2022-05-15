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
            List<int> listagem = new List<int>(1);
            
            for (int novoNumero = 1000; novoNumero <= 7770; novoNumero++)
            {
                string numeroObtido = novoNumero.ToString();
                List<int> digitosNumeroObtido = new List<int>(4);

                for (int y = 0; y < novoNumero.ToString().Length; y++)
                    digitosNumeroObtido.Add(Convert.ToInt32(numeroObtido.Substring(y, 1)));

                if (digitosNumeroObtido.Max() > maxDigit)
                    continue;

                int soma = 0;
                for (int n = 0; n < novoNumero.ToString().Length; n++)
                    soma += Convert.ToInt32(numeroObtido.Substring(n, 1));

                if (soma == 21)
                    listagem.Add(novoNumero);
            }

            return listagem.Any() ? listagem : null;
        }
    }
}
