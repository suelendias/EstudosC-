using System;
public class Tradicional : Bilhete
{
    private String tipoSala;
    private String tela;
    private String resolucao;
    private String capacidade;

    public Bilhete ingresso2;
    public string TipoSala { get => tipoSala; set => tipoSala = value; }
    public string Tela { get => tela; set => tela = value; }
    public string Resolucao { get => resolucao; set => resolucao = value; }
    public string Capacidade { get => capacidade; set => capacidade = value; }

            public Tradicional ()
            {

            }

            public Tradicional (string TipoSala, string Tela, string Resolucao, string Capacidade)
            {
                this.TipoSala = TipoSala;
                this.Tela = Tela;
                this.Resolucao = Resolucao;
                this.Capacidade = Capacidade;
            }  


            public void ExibirDados()
            {
                ExibirDados(ConsoleColor.Red);
            }
            public void ExibirDados(ConsoleColor cor)
            {
                Console.WriteLine(ObterDados());                              
            }

            public string ObterDados()
            {
                return $"----------BILHETE---------- \n Código de Bilhete: {ingresso2.CodigoBilhete}\n Valor de Bilhete: {ingresso2.Valor}\n Data: {ingresso2.Data}\n Tipo de Sala: {TipoSala}\n Tela: {Tela}\n Resolução: {Resolucao}\n Capacidade Total: {Capacidade}\n";
            }


            // COLETAR DADOS
            public void ColetarDados()
            {
                Console.Write("Tipo de Sala: ");   
                TipoSala = Console.ReadLine();     
                Console.Write("Tela: ");   
                Tela = Console.ReadLine();    
                Console.Write("Resolução: ");   
                Resolucao = Console.ReadLine();     
                Console.Write("Capacidade: ");   
                Capacidade = Console.ReadLine();  
                Console.Write("Código do Bilhete: ");
                CodigoBilhete = int.Parse(Console.ReadLine());
                Console.Write("Valor de Bilhete: ");
                Valor = double.Parse(Console.ReadLine());
                Console.Write("Data: ");
                Data = Console.ReadLine();   
            }
            
}