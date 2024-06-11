﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using ProjRevisao04062024.Models.Implementacao;

namespace ProjRevisao04062024.Models
{
    public class Terra : Planeta
    {
        public int QtdPopulacao { get; set; }
        public Predio Predio { get; set; }
    }
}
