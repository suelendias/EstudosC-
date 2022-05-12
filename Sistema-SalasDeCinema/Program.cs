using System;

namespace simulado
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilhete ingresso = new Bilhete();
            ingresso.CodigoBilhete = 25896;
            ingresso.Valor = 22.99;
            ingresso.Data = "14/10/2021";   
            //ingresso.MeioBilhete = false;
            //ingresso.capacidadeTotal = 100;
            //ingresso.pagaMeia(true);    
            //ingresso.faixaEtaria(16);  
            //ingresso.capacidadeDisponivel(80);   
            //ingresso.valorPago(22.99);
            //ingresso.ExibirInfos();

            Imax imax = new Imax();
            imax.TipoSala = "IMAX";
            imax.Tela = "22m x 16,1m";
            imax.Resolucao = "4K";
            imax.Capacidade = "100 Pessoas";
            imax.ingresso = ingresso;        
            imax.ExibirDados();
            imax.ObterDados();
            


            Bilhete ingresso2 = new Bilhete();
            ingresso2.CodigoBilhete = 21416;
            ingresso2.Valor = 8.99;
            ingresso2.Data = "15/10/2021"; 

            Tradicional convencional = new Tradicional();
            convencional.TipoSala = "Tradicional";
            convencional.Tela = "12m x 5,1m";
            convencional.Resolucao = "HD";
            convencional.Capacidade = "60 Pessoas";
            convencional.ingresso2 = ingresso2; 
            convencional.ExibirDados();
            convencional.ObterDados();



            Bilhete ingresso3 = new Bilhete();
            ingresso3.CodigoBilhete = 1216;
            ingresso3.Valor = 15.99;
            ingresso3.Data = "16/10/2021"; 

            Tradi3D sala3d = new Tradi3D();
            sala3d.TipoSala = "Tradicional 3D";
            sala3d.Tela = "12m x 5,1m";
            sala3d.Resolucao = "HD";
            sala3d.Capacidade = "80 Pessoas";
            sala3d.ingresso3 = ingresso3; 
            sala3d.ExibirDados();
            sala3d.ObterDados();

        }
    }
}
