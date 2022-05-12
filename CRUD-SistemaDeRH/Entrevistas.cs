using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    public class Entrevistas : Candidato1
    {


        public int Entrevista_id { get; set; }
        public string NomeEntrevistador { get; set; }
        public string DataEntrevista { get; set; }
        public Candidato1 candidato1 { get; set; }
        public string Id_vaga { get; set; }

        public Entrevistas() 
        {

        }

        public Entrevistas(int entrevista_id, string nomeEntrevistador, string dataEntrevista, Candidato1 candidato1, string id_vaga)
        {
            Entrevista_id = entrevista_id;
            NomeEntrevistador = nomeEntrevistador;
            DataEntrevista = dataEntrevista;
            this.candidato1 = candidato1;
            Id_vaga = id_vaga;
        }
    }


}
