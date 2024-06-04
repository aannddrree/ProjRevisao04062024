using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjRevisao04062024.Models.Implementacao
{
    public abstract class Planeta : IPlaneta
    {

        #region Propriedades

        public int Id { get; set; }
        public string Nome { get; set; }
        public int VelocidadeRotacao { get; set; }
        public int VelocidadeTranslacao { get; set; }

        #endregion

        #region Métodos

        public override string ToString()
        {
            return $"Id: {Id}\n Nome: {Nome}\n Velocidade Translação: {VelocidadeTranslacao}\n Velocidade Rotação: {VelocidadeRotacao}\n";
        }

        public void rotacao(int velocidade)
        {
            VelocidadeRotacao += velocidade;
        }

        public void translacao(int velocidade)
        {
            VelocidadeTranslacao += velocidade;
        }
        #endregion
    }
}
