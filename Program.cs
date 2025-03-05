namespace PesquisaBináriaComNomes
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes =  {"Alice", "Bob", "Charlie", "David", "Eve", "Frank", "Grace", "Henry", "Ivy", "Jack",
    "Kelly", "Liam", "Mia", "Noah", "Olivia", "Peter", "Quinn", "Ryan", "Sophia", "Thomas",
    "Uma", "Victor", "Willow", "Xavier", "Yara", "Zachary", "Abigail", "Benjamin", "Chloe", "Daniel",
    "Emily", "Finn", "Gabriella", "Hunter", "Isabella", "Jacob", "Katherine", "Lucas", "Madison", "Nathan",
    "Owen", "Penelope", "Quentin", "Riley", "Samuel", "Taylor", "Ulysses", "Violet", "William", "Xena",
    "Yasmine", "Zane", "Aria", "Blake", "Caleb", "Dylan", "Eleanor", "Felix", "Giselle", "Hudson",
    "Iris", "Jasper", "Kylie", "Leo", "Maya", "Nolan", "Ophelia", "Parker", "Quilla", "Rowan",
    "Scarlett", "Tristan", "Ursula", "Valentina", "Wyatt", "Ximena", "Yvette", "Zander", "Aurora", "Brody",
    "Clara", "Declan", "Eliana", "Flynn", "Genevieve", "Holden", "India", "Julian" };

            //OBs.:  É OBRIGATÓRIO A LISTA ESTAR ORDENADA
            Array.Sort(nomes);
            
            string alvo = "Eliana";
            int posicao = BuscaBinária(alvo,nomes);
            if (posicao < 0)
            {
                Console.WriteLine(" O nome '' {0} '' não está na lista", alvo);
            }
            else {
                Console.WriteLine(" a posicao do {0} na lista é {1}", alvo, posicao);
            }
        }

         static int BuscaBinária(string alvo, string[] lista)
        {
            int baixo, alto, meio, tentativas = 0, posicao = 0;
            bool NumFound = false;
            baixo = 0;
            alto = lista.Length - 1;
            while ( (baixo <= alto) && NumFound == false )
            {
                meio = (baixo + alto) / 2;

                //analisa se o chuter vem alafabeticamente antes ou depois do nosso alvo

                //se o chute vier depois do nosso alvo ( chute alto )
                if ((string.Compare(lista[meio], alvo ) > 0 ))
                {
                    // a variavel " alto " será redefinida
                    alto = meio - 1;
                }

                //se o chute vier antes do nosso alvo ( chute baixo )
                else if ((string.Compare(lista[meio], alvo) < 0))
                {
                    //varivael " baixo " ´será redefinida
                    baixo = meio + 1;
                }

                //o chute foi certo
                else
                {
                    NumFound = true;
                    posicao = meio;
                }
                tentativas += 1;

            }

            if ( NumFound == false )
            {
                return -1;
            }

            else
            {
                return posicao;
            }
        }
    }
}
