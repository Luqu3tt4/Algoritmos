using System.ComponentModel;

namespace OrdenacaoPorSelecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criamos um array ( não dinâmico ) e preenchemos com valores aleatórios 
            Random Rnum = new Random();
            int[] ListaNums = new int[100];
            Console.WriteLine("Array antes de ser ordenado: ");
            for (int i = 0; i < ListaNums.Length; i++)
            {
                ListaNums[i] = Rnum.Next(1001);
                Console.WriteLine(" {0} ", ListaNums[i]);
            }


            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Array depois de ser ordenado: ");

            // criamos um outro arraty ( só que dinâmico ), passamos o array anterior nele e enviamos ele na função
            List<int> ListaDaFuncao = new List<int>(ListaNums);
            OrdenacaoPorSelecao(ref ListaDaFuncao);
            
            //exibimos o array
            foreach(int i in ListaDaFuncao)
            {
                Console.WriteLine(" {0} ", i);
            }
        }

        static void OrdenacaoPorSelecao(ref List<int> Lista)
        {
            //será a lista onde armazenaremos a lista ordenada
            List<int> ListaOrdenada = new List<int>();

            
            //enquanto a lista não estiver vazia
            while (Lista.Count() > 0)
            {
                // o maior número e sua posição
                int maior, PosMaior = 0;

                //definição inicial do maior número
                maior = Lista[0];

                //percorre o array em busca do maior número
                for (int n = 0; n < Lista.Count(); n++)
                {
                    if (Lista[n] > maior)
                    {
                        maior = Lista[n];
                        PosMaior = n;
                    }

                }
                // adicionamos o maior elemento no final da lista ( ordem decrescente )
                // reovems o maior elemento da lista original a cada passada, pois se não, apenas ele seria adicionado
                ListaOrdenada.Add(maior);
                Lista.RemoveAt(PosMaior);


            }

            //aqui substituimos a lista original pela ordenada
            Lista = ListaOrdenada;
        }
    }
}
