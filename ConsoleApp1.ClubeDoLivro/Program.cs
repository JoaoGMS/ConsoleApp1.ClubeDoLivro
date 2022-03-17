using System;



namespace ConsoleApp1.ClubeDoLivro
{
    internal partial class Program
    {
        /*Gustavo tem uma coleção grande de revistas em quadrinhos. Por isso, resolveu
        emprestar para os amigos. Assim foi criado o Clube da Leitura.
        Mas para não perder nenhuma revista, seu pai contratou os alunos da Academia do
        Programador 2022 para fazer uma aplicação que cadastra as revistas e controla o
        empréstimo.
        Para cada Revista, deverá ser cadastrado:
        • o tipo de coleção
        • o número da edição
        • o ano da revista
        • a caixa onde está guardada

        Cada caixa tem uma cor, uma etiqueta e um número.
        Para cada Empréstimo cadastram-se:
        • o amigo que pegou a revista
        • qual foi a revista emprestada
        • a data do empréstimo
        • a data de devolução

        Cada criança só pode pegar uma revista por empréstimo.
        O cadastro do Amigo consiste de:
        • nome
        • nome do responsável
        • telefone
        • endereço

        Mensalmente Gustavo verifica os empréstimos realizados no mês e diariamente os
        empréstimos que estão em aberto.

        =========================================================================================================================================================
          
          #region e #endregion:
         
          recurso este que visa diminuir visualmente o código e deixá-lo agrupado por tipo de execução, por exemplo:
          Eventos, Funções e Métodos, Construtores, Enumeradores, Variáveis, etc.
        */

        static Amigo[] amigos = new Amigo[1000];
        static Livro[] livros = new Livro[1000];
        static Emprestimo[] emprestimos = new Emprestimo[1000];
        static Caixa[] caixas = new Caixa[1000];


        static void Main(string[] args)
        {
            static void lerLivro(ref Livro livro)
            {
                Console.WriteLine("Digite o nome do Livro: ");
                livro.nomeLivro = Console.ReadLine();
                Console.WriteLine("Digite o tipo de coleção: ");
                livro.tipoColecao = Console.ReadLine();
                Console.WriteLine("Digite o numero da edição do livro: ");
                livro.nEdicao = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Diga o ano da Livro: ");
                livro.ano = Console.ReadLine();
                Console.WriteLine("Digite o número da caixa que esta o livro: ");
                livro.nCaixaGuardada = Convert.ToInt32(Console.ReadLine());


            }
            static void lerCaixa(ref Caixa caixa)
            {
                Console.WriteLine("Digite a cor da caixa: ");
                caixa.cor = Console.ReadLine();
                Console.WriteLine("Digite o número da caixa: ");
                caixa.numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a etiqueta da caixa: ");
                caixa.etiqueta = Console.ReadLine();

            }
            static void cadastrarAmigos(ref Amigo amigo)
            {
                Console.WriteLine("Digite o nome do amigo: ");
                amigo.nomeAmigo = Console.ReadLine();
                Console.WriteLine("Digite o nome do responsavel do amigo: ");
                amigo.nomeResponsavel = Console.ReadLine();
                Console.WriteLine("Digite o telefone do amigo: ");
                amigo.telefone = Console.ReadLine();
                Console.WriteLine("Digite o endereço do amigo: ");
                amigo.endereco = Console.ReadLine();
            }
            static void lerEmprestimo(ref Emprestimo emprestimo)
            {
                Console.WriteLine("Digite o nome do amigo que esta emprestando o livro: ");
                emprestimo.nomeAmigo = Console.ReadLine();
                Console.WriteLine("Digite o nome da revista desejada: ");
                emprestimo.nomeAmigo = Console.ReadLine();
                Console.WriteLine("Digite a data de emprestimo: ");
                emprestimo.dataEmprestimo = Console.ReadLine();
                Console.WriteLine("Digite a data de devolução: ");
                emprestimo.dataDevolucao = Console.ReadLine();

            }
            int resposta;
            bool chamarMenu;
            char continuar;
            string excluirOuEditar;
            int excluir, editar;
            do 
            { 
                #region menu
                do
            {
                 Console.WriteLine("Clube do Livro");
                 Console.WriteLine();
                 Console.WriteLine("Digite [1] para adicionar um livro");
                 Console.WriteLine("Digite [2] para adicionar caixa");
                 Console.WriteLine("Digite [3] para cadastrar amigo");
                 Console.WriteLine("Digite [4] para fazer um emprestimo");
                 Console.WriteLine("Digite [5] para exibir os livros");
                 Console.WriteLine("Digite [6] para exibir as caixas");
                 Console.WriteLine("Digite [7] para exibir os amigos");
                 Console.WriteLine("Digite [8] para exibir os emprestimos");
                 Console.WriteLine("Digite [9] para editar ou excluir uma revista");
                 Console.WriteLine("Digite [10] para editar ou excluir uma caixa");
                 Console.WriteLine("Digite [11] para editar ou excluir um amigo");
                 Console.WriteLine("Digite [12] para editar ou excluir um emprestimo");

                 Console.Write("Resposta: ");
                 resposta = Convert.ToInt32(Console.ReadLine());
                }while(resposta != 1 && resposta != 2 && resposta != 3 && resposta != 4 && resposta != 5 && resposta != 6 && resposta != 7 && resposta != 8 && resposta != 9 && resposta != 10 && resposta != 11 && resposta != 12);
            
            

             #endregion
             Livro livro = new Livro();
             Caixa caixa = new Caixa();
                Amigo amigo = new Amigo();
             Emprestimo emprestimo = new Emprestimo();

               switch (resposta)
               {
                case 1:
                    #region Revista
                    lerLivro(ref livro);
                    livro.AdicionarLivroAoVetor(livros, livro);
                    Console.WriteLine();
                    #endregion
                    break;

                case 2:
                    #region Caixa
                    lerCaixa(ref caixa);
                    caixa.guardarCaixaemVetor(caixas, caixa);
                    Console.WriteLine();

                    #endregion

                    break;

                case 3:
                    #region Cadastro do Amigo

                    cadastrarAmigos(ref amigo);

                    amigo.vetorDeAmigos(amigos, amigo);
                    Console.WriteLine();

                    #endregion

                    break;

                case 4:
                    #region Emprestimo
                    lerEmprestimo(ref emprestimo);

                    emprestimo.VetorDeEmprestimos(emprestimos, emprestimo);
                    Console.WriteLine();

                    #endregion
                    break;

                case 5:
                    livro.exibir(livros, livro);
                    break;

                case 6:
                    caixa.exibirCaixa(caixas, caixa);
                    break;

                case 7:
                    amigo.exibirAmigos(amigos, amigo);
                    break;

                case 8:
                    emprestimo.exibirEmprestimos(emprestimos, emprestimo);
                    break;

                case 9:
                    do
                    {
                        Console.Write("Digite E para editar ou EX para excluir: ");
                        excluirOuEditar = Console.ReadLine();
                        Console.WriteLine();
                    } while (excluirOuEditar != "E" && excluirOuEditar != "EX");
                    #region Excluir ou editar Revista
                    if (excluirOuEditar == "E")
                    {
                        Console.Write("Digite a posição da revista que deseja editar: ");
                        editar = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();

                        lerLivro(ref livro);

                        livro.editarLivro(livros, livro, editar);
                        Console.WriteLine();
                    }
                    else
                    {
                        if (excluirOuEditar == "EX")
                        {
                            Console.Write("Digite a posição da revista que deseja excluir: ");
                            excluir = Convert.ToInt32(Console.ReadLine());

                            livro.excluirLivro(livros, livro, excluir);
                            Console.WriteLine();
                        }
                    }
                    #endregion
                    break;

                case 10:
                    do
                    {
                        Console.Write("Digite E para editar ou EX para excluir: ");
                        excluirOuEditar = Console.ReadLine();
                        Console.WriteLine();
                    } while (excluirOuEditar != "E" && excluirOuEditar != "EX");

                    #region Excluir ou editar Caixa
                    if (excluirOuEditar == "E")
                    {
                        Console.Write("Digite a posição da caixa que deseja editar: ");
                        editar = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();

                        lerCaixa(ref caixa);

                        caixa.editarCaixa(caixas, caixa, editar);

                        Console.WriteLine();
                    }
                    else
                    {
                        if (excluirOuEditar == "EX")
                        {
                            Console.Write("Digite a posição da caixa que deseja excluir: ");
                            excluir = Convert.ToInt32(Console.ReadLine());

                            caixa.excluirCaixa(caixas, caixa, excluir);
                            Console.WriteLine();
                        }
                    }
                    #endregion
                    break;

                case 11:
                    do
                    {
                        Console.Write("Digite E para editar ou EX para excluir: ");
                        excluirOuEditar = Console.ReadLine();
                        Console.WriteLine();
                    } while (excluirOuEditar != "E" && excluirOuEditar != "EX");

                    #region Excluir ou editar Amigo
                    if (excluirOuEditar == "E")
                    {
                        Console.Write("Digite a posição do cadastro do amigo que deseja editar: ");
                        editar = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();

                        cadastrarAmigos(ref amigo);

                        amigo.editarCadastro(amigos, amigo, editar);
                        Console.WriteLine();
                    }
                    else
                    {
                        if (excluirOuEditar == "EX")
                        {
                            Console.Write("Digite a posição do cadastro do amigo que deseja excluir: ");
                            excluir = Convert.ToInt32(Console.ReadLine());

                            amigo.excluirCadastro(amigos, amigo, excluir);
                            Console.WriteLine();
                        }
                    }
                    #endregion
                    break;

                case 12:
                    do
                    {
                        Console.Write("Digite E para editar ou EX para excluir: ");
                        excluirOuEditar = Console.ReadLine();
                        Console.WriteLine();
                    } while (excluirOuEditar != "E" && excluirOuEditar != "EX");

                    #region Excluir ou editar Emprestimo
                    if (excluirOuEditar == "E")
                    {
                        Console.Write("Digite a posição do emprestimo que deseja editar: ");
                        editar = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();

                        lerEmprestimo(ref emprestimo);
                        Console.WriteLine();

                        emprestimo.editarEmprestimo(emprestimos, emprestimo, editar);
                        Console.WriteLine();

                    }
                    else
                    {
                        if (excluirOuEditar == "EX")
                        {
                            Console.Write("Digite a posição do emprestimo que deseja excluir: ");
                            excluir = Convert.ToInt32(Console.ReadLine());

                            emprestimo.excluirEmprestimo(emprestimos, emprestimo, excluir);
                            Console.WriteLine();
                        }
                    }

                    #endregion
                    break;

               }
                    do
                    {
                        Console.Write("Deseja ir para o menu novamente? Digite S para sim e N para não: ");
                        continuar = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine();
                    } while (continuar != 'S' && continuar != 'N');

                    chamarMenu = continuar == 'S';

            } while (chamarMenu == true);
        }


    }
        public class Amigo 
        {
            public string nomeAmigo;
            public string nomeResponsavel;
            public string telefone;
            public string endereco;

            public void vetorDeAmigos(Amigo[] amigos, Amigo amigo)
            {
                for (int i = 0; i < amigos.Length; i++)
                {
                    if (amigos[1] == null)
                    {
                        amigos[1] = amigo;
                        break;
                    }
                }
            }
            public void editarCadastro(Amigo[] amigos, Amigo amigo, int editar)
            {
                for(int i = 0; i < amigos.Length; i++)
                {
                    if(i == editar)
                    {
                        amigos[i] = amigo;
                        break;
                    }
                }
            }
            public void excluirCadastro(Amigo[] amigos, Amigo amigo, int excluir)
            {
                for (int i = 0; i < amigos.Length; i++)
                {
                    if(i == excluir)
                    {
                        amigos[i] = null;
                        break;
                    }
                }
            }
            public void exibirAmigos(Amigo[] amigos, Amigo amigo)
            {
                for (int l = 0; 1 < amigos.Length;)
                {
                    if (amigos[1] != null)
                    {
                        Console.WriteLine("Amigo " + amigos[1].nomeAmigo + ", nome do responsável: " + amigos[1].nomeResponsavel + ".");
                        Console.WriteLine("Endereço: " + amigos[1].endereco + ", telefones" + amigos[1].telefone + ".");
                    }
                }
            }
        }
        public class Livro

        {
            public string tipoColecao;
            public int nEdicao;
            public string ano;
            public int nCaixaGuardada;
            public string nomeLivro;


            public void AdicionarLivroAoVetor(Livro[] livros, Livro livro)
            {
                for (int i = 0; i < livros.Length; i++)
                {
                    if (livros[i] == null)
                    {
                        livros[i] = livro;
                        break;

                    }
                }
            }

            public void editarLivro(Livro[] livros, Livro livro, int editar)
            {
                for (int i = 0; i < livros.Length; i++)
                {
                    if (i == editar)
                    {
                        livros[i] = livro;
                        break;
                    }
                }
            }
            public void excluirLivro(Livro[] livros, Livro livro, int excluir)
            {
                for (int i = 0; 1 < livros.Length; i++)
                {
                    if (i == excluir)
                    {
                        livros[i] = null;
                        break;
                    }
                }
            }
            public void exibir(Livro[] livros, Livro livro)
            {
                for (int i = 0; i < livros.Length; i++)
                {
                    Console.WriteLine("Livro " + livros[i].nomeLivro);
                    Console.WriteLine("Tipo de coleção " + livros[i].tipoColecao + " número da edição" + livros[i].nEdicao);
                    Console.WriteLine("Ano de revista : " + livros[i].ano + ", caixa em que está guardado: " + livros[i].nCaixaGuardada );
                    continue;
                }
            }
        }
        public class Emprestimo
        {

            public string dataEmprestimo;
            public string nomeAmigo;
            public int idAmigo;
            public int nRevistaEmprestada;
            public string dataDevolucao;
            public int contador = 0;

            private string[] posicoesNaoNulas = new string[1000];

            public void VetorDeEmprestimos(Emprestimo[] emprestimos, Emprestimo emprestimo)
            {
                for(int j = 0; j < emprestimos.Length; j++)
                {
                    if(emprestimos[j] == null)
                    {
                        emprestimos[j] = emprestimo;
                        break;
                    }
                }
            }
            public void editarEmprestimo(Emprestimo[] emprestimos, Emprestimo emprestimo, int editar)
            {
                for (int j = 0; j < emprestimos.Length; j++)
                {
                    if(j== editar)
                    {
                        emprestimos[j] = emprestimo;
                        break ;
                    }
                }
            }
            public void excluirEmprestimo(Emprestimo[] emprestimos, Emprestimo emprestimo, int excluir)
            {
                for (int j = 0; j < emprestimos.Length; j++)
                {
                    emprestimos[j] = null;
                    break;

                }
            }
            public void exibirEmprestimos(Emprestimo[] emprestimos, Emprestimo emprestimo)
            {
                for( int j = 0; j < emprestimos.Length; j++)
                {
                    if(emprestimos[j] == null)
                    {
                        Console.WriteLine("Amigo que emprestou: " + emprestimos[j].nomeAmigo + ", revista emprestada: " + emprestimos[j].nRevistaEmprestada);
                        Console.WriteLine("Data do emprestimo: " + emprestimos[j].dataEmprestimo + ", data de devolução: " + emprestimos[j].dataDevolucao);
                        Console.WriteLine();
                    }
                }
            }
        }
        public partial class Caixa
        {
            public string cor;
            public string etiqueta;
            public int numero;
            


            public void guardarCaixaemVetor(Caixa[] caixas, Caixa caixa)
            {
                for (int k = 0; k < caixas.Length; k++)
                {
                    if (caixas[k] == null)
                    {
                        caixas[k] = caixa;
                        break;
                    }
                }
            }
            public void editarCaixa(Caixa[] caixas, Caixa caixa, int editar)
            {
                for (int k = 0; k < caixas.Length; k++)
                {
                    if (k == editar)
                    {
                        caixas[k] = caixa;
                        break;
                    }
                }
            }
            public void excluirCaixa(Caixa[] caixas, Caixa caixa,  int excluir)
            {
                for (int k = 0; k < caixas.Length; k++)
                {
                    if (k == excluir)
                    {
                        caixas[k] = null;
                        break;
                    }
                }
            }
            public void exibirCaixa(Caixa[] caixas, Caixa caixa)
            {
                for (int k = 0; k < caixas.Length; k++)
                {
                    if (caixas[k] != null)
                    {
                        System.Console.WriteLine("Cor da caixa: " + caixas[k].cor + ", etiqueta da caixa: " + caixas[k].etiqueta + ", numero da caixa: " + caixas[k].numero + ".");
                        System.Console.WriteLine();
                    }
                }
            }

        }
}

