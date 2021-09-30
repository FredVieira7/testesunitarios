using System;

namespace ClasseDeExemplo
{
    public class ClasseExemplo
    {

        public int somarInteiros(params int[] valores)
        {
            int soma = 0;

            for(int i = 0; i < valores.Length; i++)
            {
                soma += valores[i];
            }

            return soma;
        }

        public string concatenarStrings(string palavra1, string palavra2)
        {
            return palavra1 + " " + palavra2;
        }

        public bool ligado(int num)
        {
            bool ligado = false;
            if(num == 1)
            {
                ligado = true;
            }
            else
            {
                ligado = false;
            }

            return ligado;
        }
    }
}
