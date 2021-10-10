namespace NPF.BusinessLogic
{
    /// <summary>
    /// divisibility rules
    /// </summary>
    public static class Divisibility
    {
        /// <summary>
        /// divisibility rule, by 11
        /// </summary>
        /// <param name="number">long number to check</param>
        /// <returns>boolean</returns>
        public static bool By11(long number)
        {
            string aux = number.ToString();
            long diferenca;

            do
            {
                int tamanho = aux.Length;

                string ultimo_algarismo = aux.Substring(tamanho - 1);
                string demais_algarismos = aux.Substring(0, tamanho - 1);

                diferenca = long.Parse(demais_algarismos) - long.Parse(ultimo_algarismo);

                aux = diferenca.ToString();
            }
            while (aux.Length > 2);

            return Multiplicity.By11(diferenca);
        }

        /// <summary>
        /// divisibility rule, by 11
        /// </summary>
        /// <param name="number">string of a number to check</param>
        /// <returns>boolean</returns>
        public static bool By11(string number)
        {
            long sum_pares = 0;
            long sum_impares = 0;

            try
            {
                for (int i = 0; i < number.Length; i++)
                {
                    char value = number[i];
                    if (i % 2 != 0)
                        sum_pares += int.Parse(value.ToString());
                    else
                        sum_impares += int.Parse(value.ToString());
                }

                var resto = sum_impares % sum_pares;

                return Multiplicity.By11(resto);
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}
