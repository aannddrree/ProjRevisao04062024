using ProjRevisao04062024.Models;
using Services;

namespace Controllers
{
    public class TerraController
    {

        private TerraService _terraService;

        public TerraController() { 
            _terraService = new TerraService();
        }

        public bool Insert(Terra terra)
        {
            return _terraService.Insert(terra);
        }


    }
}
