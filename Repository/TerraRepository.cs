using Microsoft.Data.SqlClient;
using Models;
using ProjRevisao04062024.Models;


namespace Repository
{

    //ADO.NET -> Inserindo e Consultados informações no banco de dados. 
    public class TerraRepository
    {
        private readonly string _strConn = "Server=DESKTOP-6NSSVDC;Database=PlanetaDB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=Yes";
        private SqlConnection conn;

        
        //Método responsável pela abertura de conexao, este (contrutor da classe) será executado quando a classe TerraRepository foi instanciada. 
        public TerraRepository()
        {
            conn = new SqlConnection(_strConn);
            conn.Open();
        }

        //Inclusao de informações no banco de dados
        public bool Insert(Terra terra)
        {
            bool result = false;

            try
            {
                //rotina para inserir as informações
                string INSERT = "INSERT INTO TB_TERRA (Nome, VelocidadeRotacao, VelocidadeTranslacao, QtdPopulacao) VALUES  (@Nome, @VelocidadeRotacao, @VelocidadeTranslacao, @QtdPopulacao)";
                SqlCommand cmd = new SqlCommand(INSERT, conn);
                //Alimentar minha query insert 
                cmd.Parameters.Add(new SqlParameter("@Nome", terra.Nome));
                cmd.Parameters.Add(new SqlParameter("@VelocidadeRotacao", terra.VelocidadeRotacao));
                cmd.Parameters.Add(new SqlParameter("@VelocidadeTranslacao", terra.VelocidadeTranslacao));
                cmd.Parameters.Add(new SqlParameter("@QtdPopulacao", terra.QtdPopulacao));

                //executar a query no banco de dados
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }

        //Consulta no banco de dados para que sejam retornadas algumas linhas referentes ao planeta Terra
        public List<Terra> GetAll()
        {
            //quero inserir todas as informações referente ao planeta terra nesta lista
            List<Terra> list = new List<Terra>();

            //string sql = "SELECT Id, Nome, VelocidadeRotacao, VelocidadeTranslacao, QtdPopulacao FROM TB_TERRA";

            string sql = " SELECT T.Id, " +
                                " Nome, " +
                                " VelocidadeRotacao, " +
                                " VelocidadeTranslacao, " +
                                " QtdPopulacao, " +
                                " IdPredio, " +
                                " P.Descricao " +
                           " FROM TB_TERRA T INNER JOIN TB_PREDIO P " +
                             " ON T.IdPredio = P.Id ";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                //É executado uma query no banco de dados e retornado o resultado na variável reader ("tabela")
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Terra terra = new Terra();
                    terra.Id = reader.GetInt32(0);
                    terra.Nome = reader.GetString(1);
                    terra.VelocidadeRotacao = reader.GetInt32(2);
                    terra.VelocidadeTranslacao = reader.GetInt32(3);
                    terra.QtdPopulacao = reader.GetInt32(4);
                    terra.Predio = 
                        new Predio { Id = reader.GetInt32(5), 
                                     Descricao = reader.GetString(6) };

                    list.Add(terra);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return list;
        }


    }
}
