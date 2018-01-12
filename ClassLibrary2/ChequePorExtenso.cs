using System;

namespace Classes
{
    public class ChequePorExtenso
    {

        public string lerPorExtenso(double valor)
        {

            string extensoFinal = "";
            string valorExtenso = valor.ToString("000000000000.00");

            if (valor <= 1000000000000 && valor > 0)
            {
                       
                for (int i = 0; i <= 12; i += 3)
                {
                    extensoFinal += escrevendo(Convert.ToDouble(valorExtenso.Substring(i, 3)));

                    if (extensoFinal != "")
                    {
                        int valorDoPedaço = -1;
                        String txtDoE = "";
                        if (i < 9) {
                            valorDoPedaço = Convert.ToInt32(valorExtenso.Substring(i, 3));
                            if (Convert.ToDouble(valorExtenso.Substring(i + 3, 10 - i)) > 0) {
                                txtDoE = " e ";
                            }
                        }
                        
                        switch (i)
                        {                            

                            case 0:
                                if (valorDoPedaço == 1)
                                    extensoFinal += " Bilhão" + txtDoE;
                                else if (valorDoPedaço > 1)
                                    extensoFinal += " Bilhões" + txtDoE;
                            break;

                            case 3:
                                if (valorDoPedaço == 1)
                                    extensoFinal += " Milhão" + txtDoE;
                                else if (valorDoPedaço > 1)
                                    extensoFinal += " Milhões" + txtDoE;
                            break;

                            case 6:
                                if (valorDoPedaço > 0)
                                    extensoFinal += " Mil" + txtDoE;
                            break;

                            default:
                            break;
                        }                       
                    }                    

                    if (i == 9)
                    {                                           
                        if (Convert.ToInt64(valorExtenso.Substring(0, 12)) == 1)
                            extensoFinal += " Real";
                        else if (Convert.ToInt64(valorExtenso.Substring(0, 12)) > 1)
                            extensoFinal += " Reais";

                        if (Convert.ToInt32(valorExtenso.Substring(13, 2)) > 0 && extensoFinal != string.Empty)
                            extensoFinal += " e ";
                    }

                    if (i == 12) {

                        int valorDoPedaço = Convert.ToInt32(valorExtenso.Substring(13, 2));
                        if (valorDoPedaço == 1) { 
                            extensoFinal += " Centavo";
                        }
                        else if (Convert.ToInt32(valorExtenso.Substring(13, 2)) > 1) { 
                            extensoFinal += " Centavos";
                        }
                    }
                }
                return extensoFinal;
            }
            else
            {
                return "Valor inválido!";
            }

        }

        static string escrevendo(double valor)
        {
            if (valor <= 0)
                return "";
            else
            {
                string montagem = "";

                if (valor > 0 & valor < 1)
                {
                    valor *= 100;
                }

                string strValor = valor.ToString("000");
                int primeiroNumero = Convert.ToInt32(strValor.Substring(0, 1));
                int segundoNumero = Convert.ToInt32(strValor.Substring(1, 1));
                int terceiroNumero = Convert.ToInt32(strValor.Substring(2, 1));

                string[] centenas = { "Cento", "Duzentos", "Trezentos", "Quatrocentos", "Quinhentos", "Seiscentos", "Setecentos", "Oitocentos", "Novecentos" };
                if (primeiroNumero == 1) montagem += (segundoNumero + terceiroNumero == 0) ? "Cem" : "Cento";
                else if (primeiroNumero > 0) montagem += centenas[primeiroNumero-1];               

                string[] dezenas = { "Dez", "Vinte", "Trinta", "Quarenta", "Cinquenta", "Sessenta", "Setenta", "Oitenta", "Noventa" };
                if (segundoNumero == 1)
                {
                    string[] apartirDeDez = { "Dez", "Onze", "Doze", "Treze", "Quatorze", "Dezesseis", "Dezessete", "Dezoito", "Dezenove" };
                    montagem += ((primeiroNumero > 0) ? " e " : string.Empty) + apartirDeDez[terceiroNumero];                   
                }
                else if (segundoNumero > 0) montagem += ((primeiroNumero > 0) ? " e " : string.Empty) + dezenas[segundoNumero -1];             

                if (strValor.Substring(1, 1) != "1" & terceiroNumero != 0 & montagem != string.Empty) montagem += " e ";

                string[] unidades = {"Um", "Dois", "Três", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove" };
                if (terceiroNumero > 0) {
                    montagem += unidades[terceiroNumero - 1]; 
                }                   

                return montagem;
            }
        }
    }
}