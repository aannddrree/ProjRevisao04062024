using ProjRevisao04062024.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TerraService
    {
        private TerraRepository _terraRepository;

        public TerraService()
        {
            _terraRepository = new TerraRepository();
        }

        public bool Insert(Terra terra)
        {
            return _terraRepository.Insert(terra);
        }

    }
}
