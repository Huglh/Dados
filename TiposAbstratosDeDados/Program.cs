using System;

namespace TiposAbstratosDeDados
{
    class Program  //Pratica3
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();
            int opcao = 0;

            while (opcao != 4)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1) Inserir");
                Console.WriteLine("2) Pesquisar");
                Console.WriteLine("3) Imprimir Lista");
                Console.WriteLine("4) Sair");
                Console.Write("Digite a opção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite um número: ");
                        int chave = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite um nome: ");
                        string nome = Console.ReadLine();
                        if (l.Pesquisar(chave) != null)
                        {
                            Console.WriteLine("Erro: chave duplicada!");
                        }
                        else
                        {
                            l.Inserir(new NoLista(chave, nome));
                        }
                        break;
                    case 2:
                        Console.Write("Digite um número a ser pesquisado: ");
                        chave = Convert.ToInt32(Console.ReadLine());
                        NoLista n = l.Pesquisar(chave);
                        if (n == null)
                            Console.WriteLine("Valor não encontrado!");
                        else
                        {
                            Console.WriteLine("Achou: " + n.chave + ", " + n.nome);
                            Console.Write("Deseja remover o nó encontrado? (S/N): ");
                            string opcaoRemover = Console.ReadLine();
                            if (opcaoRemover.ToUpper() == "S")
                            {
                                l.Remover(chave);
                                Console.WriteLine("Nó removido.");
                            }
                        }
                        break;
                    case 3:
                        l.Imprimir();
                        break;
                    case 4:
                        Console.WriteLine("Encerrando o programa.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }

            Console.ReadKey();
        }
    }

}

