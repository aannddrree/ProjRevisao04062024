using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjRevisao04062024.Models
{
    public interface IPlaneta
    {
        void rotacao(int velocidade);
        void translacao(int velocidade);
    }
}
