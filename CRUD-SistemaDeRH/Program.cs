using System.Configuration;
using MySql.Data.MySqlClient;
using System;

namespace atividade
{
    public class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Opções: ");
                Console.WriteLine("1 - Cadastrar Candidato");
                Console.WriteLine("2 - Remover Candidato");
                Console.WriteLine("3 - Consultar Candidato");
                Console.WriteLine("4 - Atualizar Candidato");
                Console.WriteLine("5 - Cadastrar Vaga");
                Console.WriteLine("6 - Remover Vaga");
                Console.WriteLine("7 - Consultar Vaga");
                Console.WriteLine("8 - Atualizar Vaga");
                Console.WriteLine("a - Cadastrar Entrevista");
                Console.WriteLine("b - Remover Entrevista");
                Console.WriteLine("c - Consultar Entrevista");
                Console.WriteLine("d - Atualizar Entrevista");
                
                switch (Console.ReadKey().KeyChar)
                {
                    case '1': Console.Clear(); 
                        Program1.CadastrarCandidato(CadastrarInformacoesDoCandidato()); 
                        break;
                    case '2':
                        Console.Clear();
                        Console.Write("Qual é o nome do candidato que você deseja deletar? \n");
                        Program1.DeletarCandidato(Console.ReadLine());
                        break;
                    case '3':
                        Console.Clear();
                        Console.Write("Insira o nome do candidato que deseja consultar:\n");
                        foreach (Candidato1 candidatoRetornado in Program1.ConsultarCandidato(Console.ReadLine()))
                        {
                            Console.WriteLine(candidatoRetornado.ToString());
                            Console.WriteLine("_______________________");
                        }
                        break;
                    case '4':
                        Console.Clear();
                        Console.Write("Insira os novos dados do candidato\n");
                        Program1.AtualizarCandidato(AtualizarInformacoesDoCandidato());
                        break;

                    case '5':
                        Console.Clear();
                        Program1.CadastrarVaga(CadastrarInformacoesVaga());
                        break;
                    case '6':
                        Console.Clear();
                        Console.Write("Qual é o nome da vaga que você deseja deletar? \n");
                        Program1.DeletarVaga(Console.ReadLine());
                        break;
                    case '7':
                        Console.Clear();
                        Console.Write("Insira o nome da vaga que deseja consultar:\n");
                        Program1.ConsultarVaga(Console.ReadLine());
                        
                        break;
                    case '8':
                        Console.Clear();
                        Console.Write("Insira os novos dados da vaga\n");
                        Program1.AtualizarVaga(AtualizarInformacoesDaVaga());
                        break;

                    case 'a':
                        Console.Clear();
                        Program1.CadastrarEntrevista(CadastrarInformacoesEntrevista());
                        break;
                    case 'b':
                        Console.Clear();
                        Console.Write("Qual é o ID da entrevista que você deseja deletar? \n");
                        Program1.DeletarEntrevista(Console.ReadLine());
                        break;
                    case 'c':
                        Console.Clear();
                        Console.Write("Insira o ID da entrevista que deseja consultar:\n");
                        Program1.ConsultarEntrevista(Console.ReadLine());

                        break;
                    case 'd':
                        Console.Clear();
                        Console.Write("Insira os novos dados da entrevista\n");
                        Program1.AtualizarEntrevista(AtualizarInformacoesDaEntrevista());
                        break;


                    default: Console.Clear(); Console.WriteLine("Opção inválida!"); break;
                }

            } while (Console.ReadKey().Key == ConsoleKey.Enter);
        }

        public static Candidato1 CadastrarInformacoesDoCandidato()
        {
            Candidato1 candidato1 = new Candidato1();
            Console.Write("Nome: ");
            candidato1.NomeCandidato = Console.ReadLine();
            Console.Write("Email: ");
            candidato1.Email = Console.ReadLine();
            Console.Write("Telefone: ");
            candidato1.Telefone = Console.ReadLine();
            Console.Write("Cidade: ");
            candidato1.Cidade = Console.ReadLine();
            Console.Write("UF - Estado: ");
            candidato1.Uf = Console.ReadLine();
            return candidato1;
        }

        public static Candidato1 AtualizarInformacoesDoCandidato()
        {
            Candidato1 candidato1 = new Candidato1();
            Console.Write("ID: ");
            candidato1.CandidatoId = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            candidato1.NomeCandidato = Console.ReadLine();
            Console.Write("Email: ");
            candidato1.Email = Console.ReadLine();
            Console.Write("Telefone: ");
            candidato1.Telefone = Console.ReadLine();
            Console.Write("Cidade: ");
            candidato1.Cidade = Console.ReadLine();
            Console.Write("UF - Estado: ");
            candidato1.Uf = Console.ReadLine();
            return candidato1;
        }

        public static Vagas CadastrarInformacoesVaga()
        {
            Vagas vaga1 = new Vagas();
            Console.Write("Nome da vaga: ");
            vaga1.Nome_da_vaga = Console.ReadLine();
            Console.Write("Status da vaga: ");
            vaga1.Status_vaga = Console.ReadLine();
            Console.Write("Descrição da vaga: ");
            vaga1.Descricao_vaga = Console.ReadLine();
            return vaga1;
        }

        public static Vagas AtualizarInformacoesDaVaga()
        {
            Vagas vaga1 = new Vagas();
            Console.Write("ID: ");
            vaga1.Id_vaga = Console.ReadLine();
            Console.Write("Nome da vaga: ");
            vaga1.Nome_da_vaga = Console.ReadLine();
            Console.Write("Status da vaga: ");
            vaga1.Status_vaga = Console.ReadLine();
            Console.Write("Descrição da vaga: ");
            vaga1.Descricao_vaga = Console.ReadLine();
            return vaga1;
        }

        public static Entrevistas CadastrarInformacoesEntrevista()
        {
            Entrevistas entrevista = new Entrevistas();
            Console.Write("ID do Candidato: ");
            entrevista.CandidatoId = int.Parse(Console.ReadLine());
            Console.Write("Data da Entrevista: ");
            entrevista.DataEntrevista = Console.ReadLine();
            Console.Write("Nome do Entrevistador: ");
            entrevista.NomeEntrevistador = Console.ReadLine();                     
            Console.Write("ID da Vaga: ");
            entrevista.Id_vaga = Console.ReadLine();
            return entrevista;
        }

        public static Entrevistas AtualizarInformacoesDaEntrevista()
        {
            Entrevistas entrevista = new Entrevistas();
            Console.Write("ID da Entrevista: ");
            entrevista.Entrevista_id = int.Parse(Console.ReadLine());
            Console.Write("ID do Candidato: ");
            entrevista.CandidatoId = int.Parse(Console.ReadLine());
            Console.Write("Data da Entrevista: ");
            entrevista.DataEntrevista = Console.ReadLine();
            Console.Write("Nome do Entrevistador: ");
            entrevista.NomeEntrevistador = Console.ReadLine();
            Console.Write("ID da Vaga: ");
            entrevista.Id_vaga = Console.ReadLine();
            return entrevista;
        }
    }
}