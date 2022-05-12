using System;

public class Bilhete 
{
    private int codigoBilhete;
    private double valor;
    private string data;
    bool meioBilhete;

    private int capacidadeTotal;
    private int disponivel;


    public int CodigoBilhete { get => codigoBilhete; set => codigoBilhete = value; }
    public double Valor { get => valor; set => valor = value; }
    public string Data { get => data; set => data = value; }
    public bool MeioBilhete { get => meioBilhete; set => meioBilhete = value; }
    public int Disponivel { get => disponivel; set => disponivel = value; }
    public int CapacidadeTotal { get => capacidadeTotal; set => capacidadeTotal = value; }

            public Bilhete ()
            {
               
            } 

            public Bilhete (int CodigoBilhete, double Valor, string Data, bool meioBilhete)
            {
                this.CodigoBilhete = CodigoBilhete;
                this.Valor = Valor;
                this.Data = Data;
            }     

            // CONSTRUTOR PARA MOSTRAR APENAS SE VALOR DE INGRESSO É MEIA OU NÃO
            public Bilhete (double Valor, bool meioBilhete)
            {
                this.Valor = Valor;
                this.meioBilhete = true;
            }     

            public void ExibirInfos()
            {
                ExibirInfos(ConsoleColor.Gray);
            }
            public void ExibirInfos(ConsoleColor cor)
            {
                Console.WriteLine(ObterInfos());                              
            }  
            public string ObterInfos()
            {
                return $"----------BILHETE---------- \n Valor de Bilhete: {Valor}\n Meia entrada: {MeioBilhete}\n";
            }
            

            // MÉTODO PARA VERIFICAR SE TEM DIREITO AO BILHETE DE MEIA ENTRADA
            public void pagaMeia(bool MeioBilhete)
            {
                if (meioBilhete == true)
                {
                    Console.WriteLine($"Direito a meia entrada? sim.\n");
                }
                else
                {
                    Console.WriteLine($"\n\nDireito a meia entrada: não.\n");
                }
            }

            // MÉTODO PARA VERIFICAR FAIXA ETÁRIA DE TELESPECTADOR
            public void faixaEtaria(int idade)
            {
                if (idade <= 17)
                {
                    Console.WriteLine($"Maior de idade? não.\n");
                }
                else
                {
                    Console.WriteLine($"Maior de idade? sim.\n");
                }
            }


            // MÉTODO PARA VERIFICAR A QUANTIDADE DE POLTRONAS DISPONIVEIS NA SALA
            public void CapacidadeDisponivel (int quantOcupada)
            {
                Disponivel = CapacidadeTotal - quantOcupada;
                Console.WriteLine($"\nQuantidade de poltronas disponíveis: {disponivel}.\n");
            }


            // MÉTODO PARA CALCULAR VALOR DE MEIA ENTRADA
            public void valorPago (double valorMeia)
            {
                valorMeia = Valor / 2;
                Console.WriteLine($"\nValor do ingresso a ser pago: {valorMeia}.\n");
            }
}