
// HELLO WORLD:

using System.Diagnostics;

namespace HelloWorld
{
    class Program
    {

        enum Cor{ Azul = 30, Verde, Amarelo, Vermelho} 
        enum Opcao{ Criar = 1 , Deletar, Editar, Listar, Atualizar }


        //ESTRUTURA DE CÓDIGO EM C#:
        static void Main(string[] args)
        {

            // CONSOLE:

            Console.WriteLine("Hello Word");  //escrever:   quebra linha naturalmente
            Console.Write("two\n");  // \n quebra linha
            Console.Write("one");
            Console.ReadLine();    //ler:  espera o enter para parar |  espera que o usuário insira um valor no prompt 



            // VARÍAVEIS:

            var v = "Minha variavel";  //não pode ser atribuido outro tipo de valor
            Console.WriteLine(v);

            int dez = 10;
            Console.WriteLine(dez);

            float f = -15.6f;
            Console.WriteLine(f);

            bool bolean = true;
            Console.WriteLine(bolean);
            bolean = false;

            string stg = "Minha String";
            Console.WriteLine(stg);

            char ch = 'b';
            Console.WriteLine(ch);

            dynamic din = 55;
            din = "Dinâmica";
            Console.WriteLine(din); //pode ser atribuido outro tipo de valor

            const int myConst = 41;   //constante em C# (necessário definir que é constante e seu tipo)
            Console.WriteLine(myConst);



            //CAPTURANDO ENTRADA DO USÚARIO:

            string nome = "";  //declara variável vazia
            Console.WriteLine("Escreva seu nome:"); //exibe a mensagem, instruindo usúario a inserir o nome
            nome = Console.ReadLine(); //lê e armazena o valor inserido pelo usúario
            Console.WriteLine("Seu nome é:"); //exibe uma mensagem sugerindo o nome
            Console.WriteLine(nome); //exibe o nome
            Console.ReadLine(); //não permite que o programa encerre sem o usúario clicar no enter



            //OPERADORES ARITIMÉTICOS:

            int soma = 5 + 75;
            Console.WriteLine(soma);

            int mult = 5 * 75;
            Console.WriteLine(mult);

            int div = 75 / 5; //Atenção: no caso de o resultado for decimal(float), ira arredonda, Ex: 5 / 2 = 2
            Console.WriteLine(div);

            float divFloat = 5f / 2; //forma de rsolver, variavel tem que ser float e um dos números da soma também. Nocaso de 6 / 2 seria: 3.0f
            Console.WriteLine(divFloat);

            int prioridade = 2 + 2 * 10; //o resultado seria 22, seguindo a regra de prioridade da matématica (* + - +). Lembrado que parentêse mudam a ordem de prioridade, ou seja (2 + 2) * 10 seria 40
            Console.WriteLine(prioridade);



            //CONDICIONAIS:

            int a = 10;
            int b = 50;

            if(a < 2){
                Console.WriteLine("10 é maior que 2");
            }else if(b == 50){
                Console.WriteLine("teste if else"); 
            }else{
                Console.WriteLine("E menor");
            }

            //se o if for falso, ele ira verificar o if else, e no caso dos 2 serem falso executara o else (lembrando que o valro de comparação pode ser uma variável)



            //OPERADORES LÓGICOS:   

            /*
            && = e
            || = ou
            > = maior que 
            < = menor que
            >= = maior ou igual que
            <= = menor ou igual que
            = = igual
            != = diferente
            */

            Console.WriteLine("Digite sua idade:");
            int idade = int.Parse(Console.ReadLine());  //O Console.ReadLine sempre retorna string, por isso o uso do int Parse, para converter o valor para inteiro 

            if(idade >= 0 && idade <=11){
                Console.WriteLine("Criança");
            }else if(idade >= 12 && idade <= 18){
                Console.WriteLine("Adolescente");
            }else if(idade >= 19 && idade <= 60){
                Console.WriteLine("Adulto");
            }else{
                Console.WriteLine("Idoso");
            }

            Console.ReadLine();



            //FUNÇÕES:

            static void minhaFuncao(){
                Console.WriteLine("Minha 1° função");
            }

            minhaFuncao();

            //Funções no geral não podem ficar dentro do Main, nesse caso está só no exemplo. Porém a sua chaamda pode

            static void GerarPreco(int preco, string nome){  //parâmetros
                Console.WriteLine(preco + nome); //concatenação em C#

                int precoABS = Math.Abs(preco); //não deixa o valor ser negativo
            }

            GerarPreco(5, " Vitor");

            static string funcaoQueRetornaString(string minhaString){
                return minhaString;

                //o que vier abaixo do retorno não será executado!

                //ao definir algum tipo de retorno, como nesse caso string, e obrigatório retornar algum valor
                //Void: Define que a função não retorna um valor específico
            }

            Console.WriteLine(funcaoQueRetornaString("Teste"));



            //ARRAY:    

            string[] produtos = new string[5]{  //tem que obter o tipo definido e a quantidade 
                "produto1",
                "produto2",
                "produto3",
                "produto4",
                "produto5",
            };

            produtos[0] = "produto0";
            Console.WriteLine(produtos[0]);

            int[] valores = {10, 20, 30, 40}; //forma mais simples e sem definir quantidade



            //SWITCH:

            string cor = "Azul";

            switch (cor)  
            {
                case "Vermelho":  
                Console.WriteLine("Cor vermelha!");
                break;

                case "Amarelo":
                Console.WriteLine("Cor amrelo!");
                break;

                case "Roxo":
                Console.WriteLine("Cor roxa!");
                break;

                case "Laranja":
                Console.WriteLine("Cor laranja!");
                break;

                default:
                Console.WriteLine("Nenhuma cor!");
                break;
            }

            //no switch só pode ser igualdade, ideal para quando se tem muitos valores



           //ENUM:



            // enum Cor{ Azul = 30, Verde, Amarelo, Vermelho}
            Cor minhaCor = Cor.Azul;
            Console.WriteLine(minhaCor);
            Console.WriteLine((int)minhaCor); //30
            Console.WriteLine((Cor)31);  //Verde

            //meu enum e Opcoes esta em Program
            //todos tem um valor numerico (não precisa estar entre " "), alterando o valor como fiz com azul, os outros númros eguirão a asequencia
            //Limita que uma variavel com tipo cor trabalhe apenas com os valores informados no parâmetro

            //Enum com Switch

            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;

            Console.WriteLine(opcaoSelecionada);
            Console.ReadLine();

            switch(opcaoSelecionada){
                case Opcao.Atualizar:
                Console.WriteLine("Ação para atualizar");
                break;

                case Opcao.Criar:
                Console.WriteLine("Ação para criar");
                break;

                case Opcao.Deletar:
                Console.WriteLine("Ação para deletar");
                break;

                case Opcao.Editar:
                Console.WriteLine("Ação para editar");
                break;
                
                case Opcao.Listar:
                Console.WriteLine("Ação para listar");
                break;

                default:
                Console.WriteLine("Opção inválida");
                break;
            }



            //WHILE:

            int contador = 0;
            while (contador < 0) //enquanto for true ira executar
            {
                Console.WriteLine("Rodando o while:" + contador);
                contador += 1;
                // contador++;
            }

            Console.WriteLine("Fim!");
            Console.ReadLine();



            //DO WHILE:

            do
            {
                Console.WriteLine("Sera executado pelo menos uma vez");
                //mesmo que o parametro seja falso, o código será executado pelo menos uma vez
            } while (100 < 10);



            //FOREACH:

            string[] nomes = {"Vitor", "Gabriel", "Linas"};

            foreach (string palavra in nomes)   //para cada palavra no array nomes, repita o bloco de código
            {
                //usada para percorrer array
                Console.WriteLine(palavra);
            }



            //FOR:

            for (int i = 0; i < nomes.Length; i++)
            {
                // Console.WriteLine(i);
                Console.WriteLine(nomes[i]);

                /*
                Vitor
                Gabriel
                Linas
                */
            }


            for (int i = nomes.Length - 1; i > 0;  i--)  //ordem decrescente
            {
                Console.WriteLine(nomes[i]);

                /*
                Linas
                Gabriel
                */
            }
            }



            //ESCOPO:

            // * Uma variável dentro de uma função só pode ser acessada pela mesma, como por exemplo dentro do Main

            //ESCOPO LOCAL: declaração dentro de uma função que so pode ser acessada na mesma

            //ESCOPO GLOBAL: declarado em Program, pode ser acessado por todas as funções



         
        
        }    
    }

//ACRESCENTADO PARA TESTE DE COMMIT GIT




