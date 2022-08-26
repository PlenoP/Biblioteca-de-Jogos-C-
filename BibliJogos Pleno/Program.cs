using BibliJogos.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliJogos
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            List<Jogo> ListadeJogos = new List<Jogo>();
            Console.ForegroundColor = ConsoleColor.Magenta;

            while (true)
            {
                Console.WriteLine("======BIBLIOTECA DE JOGOS======");

                Console.WriteLine("1 - Adicionar Jogo");
                Console.WriteLine("2 - Listar Jogo");
                Console.WriteLine("3 - Editar Jogo");
                Console.WriteLine("4 - Remover Jogo");
                Console.Write("Opcao: ");

                bool resultado;
                String opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        resultado = AdicionarJogo(ListadeJogos);

                        if (resultado == true)
                        {
                        Console.WriteLine("Cadastrado com Sucesso!");
                        Console.WriteLine("");
                        Console.WriteLine("Pressione qualquer tecla para continuar!");
                        Console.ReadLine();
                        Console.Clear();
                        }
                        else
                        {
                        Console.WriteLine("Erro no Cadastro");
                        Console.WriteLine("Pressione qualquer tecla para continuar!");
                        Console.ReadLine();
                        Console.Clear();
                        }
                        break;

                     case "2":
                        {
                            resultado = ListarJogos(ListadeJogos);
                        }
                        break;

                     case "3":
                        {
                            resultado = EditarJogo(ListadeJogos);
                        }
                        break;

                     case "4":
                        {
                            resultado = DeletarJogos(ListadeJogos);
                        }
                        break;
                }
            }
        }
        public static bool AdicionarJogo(List<Jogo> ListadeJogos)
        {
            Console.Clear();
            Console.Write("Título: ");
            String titulo = Console.ReadLine();
            Console.Write("Gênero: ");
            String genero = Console.ReadLine();
            Console.Write("Data de Lançamento: ");
            int data = Convert.ToInt32(Console.ReadLine());
            Console.Write("Número Máximo de Jogadores: ");

            int qtjogadores = Convert.ToInt32(Console.ReadLine());

            if (titulo == "") return false;
            if (genero == "") return false;
            if (data < 1950) return false;
            if (qtjogadores < 1) return false;

            Jogo novojogo = new Jogo(titulo, data, genero, qtjogadores);

            ListadeJogos.Add(novojogo);
            Console.Beep();

            return true;
        }

        public static bool ListarJogos(List<Jogo> ListadeJogos)
        {
            Console.Clear();
            Console.WriteLine("JOGOS ADICIONADOS: ");
            Console.WriteLine("");

            foreach (Jogo jogo in ListadeJogos)
            {
                Console.Write("Jogo: ");
                Console.WriteLine(jogo.getTitulo());
                Console.Write("Gênero: ");
                Console.WriteLine(jogo.getGenero());
                Console.Write("Ano de lançamento: ");
                Console.WriteLine(jogo.getData());
                Console.Write("Número máximo de jogadores: ");
                Console.WriteLine(jogo.getqtjogadores());
                Console.WriteLine("================================================================================================");
                Console.WriteLine("");
            }

            Console.WriteLine("Pressione qualquer tecla para retornar");
            Console.ReadLine();
            Console.Clear();

            return true;
        }
        public static bool DeletarJogos(List<Jogo> ListadeJogos)
        {
            Console.Clear();
            Console.Write("Digite o nome do que será deletado: ");
            String jogoDeletar = Console.ReadLine();
            foreach (Jogo jogo in ListadeJogos)
            {
                if (jogo.getTitulo() == jogoDeletar)
                {
                    ListadeJogos.Remove(jogo);
                    Console.Clear();
                    break;
                }
            }
            return true;
        }
        public static bool EditarJogo(List<Jogo> ListadeJogos)
        {
            Console.Clear();
            Console.Write("Digite o nome do jogo que será editado: ");
            String jogoEditar = Console.ReadLine();

            foreach (Jogo jogo in ListadeJogos)
            {
                if (jogo.getTitulo() == jogoEditar)
                {
                    Console.WriteLine("");

                    Console.Write("Escolha o novo nome do jogo: ");                   
                    String jogoEditado = Console.ReadLine();
                    jogo.setTitulo(jogoEditado);
                    Console.Write("Escolha o novo gênero do jogo: ");                    
                    String generoEditado = Console.ReadLine();
                    jogo.setGenero(generoEditado);
                    Console.Write("Escolha a nova data de lançamento do jogo: ");
                    int dataEditada = Convert.ToInt32(Console.ReadLine());
                    jogo.setData(dataEditada);
                    Console.Write("Escolha quantos jogadores poderá ter do jogo: ");
                    int jogadoresEditado = Convert.ToInt32(Console.ReadLine());
                    jogo.setData(jogadoresEditado);
                    Console.Clear();                                  
                }
            }
            return true;
        }
    }
}