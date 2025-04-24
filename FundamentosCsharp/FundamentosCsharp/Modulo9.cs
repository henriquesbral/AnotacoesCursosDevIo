using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversores
{
    public class Conversor
    {
        public void ConvertAndParse()
        {
            //int numero = int.Parse("1");//primeira forma de conversão
            int numero = Convert.ToInt32("1"); //segunda forma de conversão
            Console.WriteLine(numero);
        }

        public void AulaTryParse()
        {
            var num = "123456";
            
            if(int.TryParse(num, out int numeroConvertido))
            {
                Console.WriteLine($"O numero {numeroConvertido} foi convertido com sucesso !");
            }
        }

        /*
        private static void Conversores2()
        {
            var tryParse = new Conversores.Conversor();
            tryParse.AulaTryParse();
        }
        private static void Conversores()
        {
            var convert = new Conversores.Conversor();
            convert.ConvertAndParse();
        }
        */
    }
}
