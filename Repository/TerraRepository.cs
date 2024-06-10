using Microsoft.Data.SqlClient;
using ProjRevisao04062024.Models;

namespace Repository
{
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


    }
}
