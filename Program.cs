// Sistema CRUD(Create - Read - Update - Delete) em mémoria
using System;


namespace SI_Cadastro
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        
        static void Main(string[] args)
        {
            string Opcao = OpcaoUser();

            while (Opcao.ToUpper() != "X")
            {
                switch (Opcao)
                {
                    case "1":
                        ListarSeries();
                        break;

                    case "2":
                        InserirSeries();
                        break;

                    case "3":
                        AtualizarSeries();
                        break;

                    case "4":
                        ExcluirSeries();
                        break;

                    case "5":
                        VisualizarSeries();
                        break;

                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                    
                }

                Opcao = OpcaoUser();
            }

            Console.WriteLine("Obrigado ao ultilizar nossos serviços");
            Console.ReadLine();
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");

            var lista = repositorio.List();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada. ");
                return;
            }

            foreach (var serie in lista)
            {   
                var excluido = serie.retornaExlcuido();
                Console.WriteLine("#ID {0}: {1}  {2}",serie.retornaId(),serie.retornaTitulo(),(excluido ? "Excluido":""));
            }
        }

        private static void InserirSeries()
        {
            Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} + {1}",i,Enum.GetName(typeof(Genero),i));
            }

            Console.WriteLine("Digite o gênero entre as opções acima");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o titulo da série");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de inicio da série");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da série");
            string entradaDescricao = Console.ReadLine();

            Serie novaserie = new Serie(id: repositorio.Proximoid(),
            Genero: (Genero)entradaGenero, Titulo: entradaTitulo, Ano: entradaAno, Descricao: entradaDescricao);

            repositorio.insere(novaserie);
        }

        private static void AtualizarSeries()
        {
            Console.WriteLine("Digite o Id da série: ");
            int IndiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} + {1}",i,Enum.GetName(typeof(Genero),i));
            }

            Console.WriteLine("Digite o gênero entre as opções acima");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o titulo da série");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de inicio da série");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da série");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: IndiceSerie,
            Genero: (Genero)entradaGenero, Titulo: entradaTitulo, Ano: entradaAno, Descricao: entradaDescricao);

            repositorio.atualiza(IndiceSerie,atualizaSerie);
        }

        private static void ExcluirSeries()
        {
            Console.WriteLine("Digite o ID da série: ");
            int IndiceSerie = int.Parse(Console.ReadLine());

            repositorio.exclui(IndiceSerie);
        }

        
        private static void VisualizarSeries()
        {
            Console.WriteLine("Digite o ID da série: ");
            int IndiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(IndiceSerie);

            Console.WriteLine(serie);
        }

        private static string OpcaoUser()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries ao seu dispor!!");
            Console.WriteLine("Informe uma opção desejada:");

            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir");
            Console.WriteLine("5- Visualizar série");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string OpcaoUser = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return OpcaoUser;
        }
    }
}
