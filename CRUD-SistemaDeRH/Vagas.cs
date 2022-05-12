using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    public class Vagas
    {        
        public string Id_vaga { get; set; }
        public string Nome_da_vaga { get; set; } 
        public string Status_vaga { get; set; }
        public string Descricao_vaga { get; set; }

        public Vagas()
        {

        }
        public Vagas(string id_vaga, string nome_da_vaga, string status_vaga, string descricao_vaga)
        {
            Id_vaga = id_vaga;
            Nome_da_vaga = nome_da_vaga;
            Status_vaga = status_vaga;
            Descricao_vaga = descricao_vaga;
        }
    }
}
