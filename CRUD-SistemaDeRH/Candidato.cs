using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    public class Candidato1
    {

        public int CandidatoId { get; set; }
        public string NomeCandidato { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }

        public Candidato1() 
        {

        }
        public Candidato1(string nomeCandidato, string email, string telefone, string cidade, string uf)
        {            
            NomeCandidato = nomeCandidato;
            Email = email;
            Telefone = telefone;
            Cidade = cidade;
            Uf = uf;
        }

        public Candidato1(int candidatoId, string nomeCandidato, string email, string telefone, string cidade, string uf) : this(nomeCandidato, email, telefone, cidade, uf)
        {
            CandidatoId = candidatoId;
        }
    }   
}
