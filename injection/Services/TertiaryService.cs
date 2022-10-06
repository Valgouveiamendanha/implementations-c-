using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationInjectionLife.Services
{
    public class TertiaryService
    {
        private readonly PrimaryService _primaryService;
        private readonly SecondaryService _secondaryService;
        private readonly SecondaryService _secondaryNewInstance;

        public TertiaryService(
            PrimaryService primaryService, 
            SecondaryService secondaryService, 
            SecondaryService secondaryNewInstance)
        {

            _primaryService = primaryService;
            _secondaryService = secondaryService;
            _secondaryNewInstance = secondaryNewInstance;
        }

        public Guid Id = new Guid();
        public Guid PrimaryServiceId => _primaryService.Id;
        public Guid SecondaryServiceId => _secondaryService.Id;
        public Guid SecondaryServiceNewInstanceId => _secondaryNewInstance.Id;
    }
}
