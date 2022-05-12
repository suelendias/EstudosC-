using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;



namespace atividade
{
    public class Program1
    {
        // Declaração e atribuição da String de Conexão, passando as informações para a conexão com o banco de dados.
        static string stringConexao = "server=us-cdbr-east-04.cleardb.com; user id=ba1fd8cfc08a6d;pwd=a7a538b0;database=heroku_51b1705dfeb7055;";
        
        #region CRUD Candidatos
        // Método para cadastrar candidato
        // comando SQL para executar o comando "INSERT".
        public static void CadastrarCandidato(Candidato1 candidato1)
        {
            if (candidato1 != null)
            {
                ExecutarNonQuery("INSERT INTO candidato1 (nome_candidato, email, telefone, cidade, estado) values (@nome_candidato, @email, @telefone, @cidade, @estado)", new MySqlParameter("@nome_candidato", candidato1.NomeCandidato), new MySqlParameter("@email", candidato1.Email), new MySqlParameter("@telefone", candidato1.Telefone), new MySqlParameter("@cidade", candidato1.Cidade), new MySqlParameter("@estado", candidato1.Uf));
            }
        }
        
        // Método para deletar candidato
        // comando SQL para executar o comando "DELETE".
        public static void DeletarCandidato(string nome)
        {
            ExecutarNonQuery("DELETE FROM candidato1 WHERE nome_candidato LIKE @nome_candidato", new MySqlParameter("@nome_candidato", nome));
        }

        // Método para atualizar candidato
        // comando SQL para executar o comando "UPDATE".
        public static void AtualizarCandidato(Candidato1 candidato1)
        {
            if (candidato1 != null)
            {
                ExecutarNonQuery("UPDATE candidato1 SET nome_candidato = @nome_candidato, email = @email, telefone = @telefone, cidade = @cidade, estado = @estado WHERE candidato_id = @candidato_id", new MySqlParameter("@candidato_id", candidato1.CandidatoId), new MySqlParameter("@nome_candidato", candidato1.NomeCandidato), new MySqlParameter("@email", candidato1.Email), new MySqlParameter("@telefone", candidato1.Telefone), new MySqlParameter("@cidade", candidato1.Cidade), new MySqlParameter("@estado", candidato1.Uf));
            }
        }        

        // Método para Consultar Candidato
        public static List<Candidato1> ConsultarCandidato(string nome)
        {
            // Criando a lista de candidatos que será retornada na chamada deste método
            List<Candidato1> candidatoRetornado = new List<Candidato1>();
            // Instanciando o objeto de conexão, onde deve ser passada a string de conexão.
            MySqlConnection conexao = new MySqlConnection(stringConexao);
            try
            {
                // Abrindo a conexão com o banco de dados
                conexao.Open();
                // Criando comando SQL para consulta de Candidato
                string sql = $"SELECT * FROM candidato1 WHERE nome_candidato LIKE @nome_candidato";
                // Instanciando o objeto de comando com o banco de dados, passando o SQL que será executado e a conexão
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                // Passando o parâmetro @Nome e o seu respectivo valor
                comando.Parameters.AddWithValue("@nome_candidato", $"%{nome}%");
                // Executando o comando criado anteriormente.
                MySqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Console.Write(dr["nome_candidato"]);
                    Console.Write(" | ");
                    Console.Write(dr["email"]);
                    Console.Write(" | ");
                    Console.Write(dr["telefone"]);
                    Console.Write(" | ");
                    Console.Write(dr["cidade"]);
                    Console.Write(" | ");
                    Console.Write(dr["estado"]);
                    Console.Write(" | ");
                    Console.WriteLine("__________________________________");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Ocorreu um erro com o banco de dados ... Erro: {ex.Message} ... Tente novamente mais tarde.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro! Erro: {ex.Message} ... Tente novamente mais tarde.");
            }
            finally
            {
                // Fechando a conexão.
                conexao.Close();
            }
            // Retonando candidato
            return candidatoRetornado;
        }

        #endregion

        #region CRUD Vagas
        // Método para cadastrar vagas, chamando o outro método ExecuteNonQuery
        // comando SQL para executar o comando "INSERT".
        public static void CadastrarVaga(Vagas vaga1)
        {
            if (vaga1 != null)
            {
                ExecutarNonQuery("INSERT INTO vagas1 (nome_da_vaga, status_vaga, descricao) values (@nome_da_vaga, @status_vaga, @descricao)", new MySqlParameter("@nome_da_vaga", vaga1.Nome_da_vaga), new MySqlParameter("@status_vaga", vaga1.Status_vaga), new MySqlParameter("@descricao", vaga1.Descricao_vaga));
            }
        }

        // Método para deletar vaga
        // comando SQL para executar o comando "DELETE".
        public static void DeletarVaga(string nome)
        {
            ExecutarNonQuery("DELETE FROM vagas1 WHERE nome_da_vaga LIKE @nome_da_vaga", new MySqlParameter("@nome_da_vaga", nome));
        }

        // Método para atualizar vagas
        // comando SQL para executar o comando "UPDATE".
        public static void AtualizarVaga(Vagas vaga1)
        {
            if (vaga1 != null)
            {
                ExecutarNonQuery("UPDATE vagas1 SET nome_da_vaga = @nome_da_vaga, status_vaga = @status_vaga, descricao = @descricao WHERE id_vaga = @id_vaga", new MySqlParameter("@id_vaga", vaga1.Id_vaga), new MySqlParameter("@nome_da_vaga", vaga1.Nome_da_vaga), new MySqlParameter("@status_vaga", vaga1.Status_vaga), new MySqlParameter("@descricao", vaga1.Descricao_vaga));
            }
        }

        // Método para Consultar vagas
        public static void ConsultarVaga(string nome_vaga)
        {
            MySqlConnection conexao = new MySqlConnection(stringConexao);
            conexao.Open();
            string sql = $"SELECT * FROM vagas1 WHERE nome_da_vaga LIKE @nome_da_vaga";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nome_da_vaga", $"%{nome_vaga}%");
            MySqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                Console.Write(dr["id_vaga"]);
                Console.Write(" | ");
                Console.Write(dr["nome_da_vaga"]);
                Console.Write(" | ");
                Console.Write(dr["status_vaga"]);
                Console.Write(" | ");
                Console.Write(dr["descricao"]);
                Console.Write(" | ");
                Console.WriteLine("__________________________________");
            }
            conexao.Close();
        }
        #endregion

        #region CRUD Entrevistas
        // Método para cadastrar entrevistas, chamando o outro método ExecuteNonQuery
        // comando SQL para executar o comando "INSERT".
        public static void CadastrarEntrevista(Entrevistas entrevista)
        {
            if (entrevista != null)
            {
                ExecutarNonQuery("INSERT INTO entrevistas1 (candidato_id, data_entrevista, nome_entrevistador, id_vaga) values (@candidato_id, @data_entrevista, @nome_entrevistador, @id_vaga)", new MySqlParameter("@candidato_id", entrevista.CandidatoId), new MySqlParameter("@data_entrevista", entrevista.DataEntrevista), new MySqlParameter("@nome_entrevistador", entrevista.NomeEntrevistador), new MySqlParameter("@id_vaga", entrevista.Id_vaga));
            }
        }

        // Método para deletar entrevista
        // comando SQL para executar o comando "DELETE".
        public static void DeletarEntrevista(string id)
        {
            ExecutarNonQuery("DELETE FROM entrevistas1 WHERE entrevista_id LIKE @entrevista_id", new MySqlParameter("@entrevista_id", id));
        }

        // Método para atualizar entrevista
        // comando SQL para executar o comando "UPDATE".
        public static void AtualizarEntrevista(Entrevistas entrevista)
        {
            if (entrevista != null)
            {
                ExecutarNonQuery("UPDATE entrevistas1 SET candidato_id = @candidato_id, data_entrevista = @data_entrevista, nome_entrevistador = @nome_entrevistador, id_vaga = @id_vaga WHERE entrevista_id = @entrevista_id", new MySqlParameter("@entrevista_id", entrevista.Entrevista_id), new MySqlParameter("@candidato_id", entrevista.CandidatoId), new MySqlParameter("@data_entrevista", entrevista.DataEntrevista), new MySqlParameter("@nome_entrevistador", entrevista.NomeEntrevistador), new MySqlParameter("@id_vaga", entrevista.Id_vaga));
            }
        }

        // Método para Consultar Entrevista
        public static void ConsultarEntrevista(string id_entrevista)
        {
            MySqlConnection conexao = new MySqlConnection(stringConexao);
            conexao.Open();
            string sql = $"SELECT * FROM entrevistas1 WHERE entrevista_id LIKE @entrevista_id";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@entrevista_id", $"%{id_entrevista}%");
            MySqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                Console.Write(dr["entrevista_id"]);
                Console.Write(" | ");
                Console.Write(dr["candidato_id"]);
                Console.Write(" | ");
                Console.Write(dr["data_entrevista"]);
                Console.Write(" | ");
                Console.Write(dr["nome_entrevistador"]);
                Console.Write(" | ");
                Console.Write(dr["id_vaga"]);
                Console.Write(" | ");
                Console.WriteLine("__________________________________");
            }
            conexao.Close();
        }
        #endregion

        private static void ExecutarNonQuery(string sql, params MySqlParameter[] parameters)
        {
            // Instanciando o objeto de conexão, onde deve ser passada a string de conexão.
            MySqlConnection conexao = new MySqlConnection(stringConexao);
            try
            {
                // Abrindo a conexão com o banco de dados
                conexao.Open();
                // Instanciando o objeto de comando com o banco de dados, passando o SQL que será executado e a conexão na qual o comando será realizado.
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                // Adicionar parâmetros aos comandos
                foreach (MySqlParameter param in parameters)
                    comando.Parameters.Add(param);
                // Executando o comando criado anteriormente.
                comando.ExecuteNonQuery();
                // Mensagem informando que o comando foi executado
                Console.WriteLine("Comando executado!");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Erro com o banco de dados: {ex.Message} ... Tente novamente mais tarde.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message} ... Tente novamente mais tarde.");
            }
            finally
            {
                // Fechando a conexão.
                conexao.Close();
            }
        }
    }
}
