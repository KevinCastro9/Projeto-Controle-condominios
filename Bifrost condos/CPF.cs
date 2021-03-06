﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bifrost_condos
{
    class CPF
    {
        public static bool IsCpf(string cpf)
        {

            //Crianção de vetores

            int[] mult1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mult2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            //Criação de string
            string tempCpf;
            string digito;

            //Criação de variaveis

            int soma;
            int resto;

            if (cpf.Length != 11)
            {
                cpf = cpf.Trim();
                cpf = cpf.Replace(".", "").Replace("-", "");
            }
            tempCpf = cpf.Substring(0, 9);

            soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * mult1[i];

            }

            resto = soma % 11;
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }
            digito = resto.ToString();
            tempCpf = tempCpf + digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * mult2[i];

            }

            resto = soma % 11;
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);

        }
    }
}
