using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjRevisao04062024.Services
{
    internal class RevisaoFuncoesBasicas
    {
        private RevisaoFuncoesBasicas()
        {
            TesteFuncoesBasicas();
        }


        public static RevisaoFuncoesBasicas GetInstance()
        {
            return new RevisaoFuncoesBasicas();
        }

        private void TesteFuncoesBasicas()
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Id: " + i);
            }

            List<string> collection = new List<string>();
            collection.Add("teste1");
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            string switch_on = "op1";
            switch (switch_on)
            {
                case "op1":
                    Console.WriteLine("OP1");
                    break;
                default:
                    Console.WriteLine("Top Default");
                    break;
            }

            int j = 0;
            while (j < 10)
            {
                Console.WriteLine("Dados: " + j);
                j++;
            }

            do
            {
                Console.WriteLine("Dados: " + j);
                j++;
            } while (j < 10);
        }
    }
}
