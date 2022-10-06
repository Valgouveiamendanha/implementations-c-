using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationInjectionLife.Services
{
    public class SecondaryService
    {
        private readonly PrimaryService _primaryService;

        public SecondaryService(PrimaryService primaryService)  
        =>  _primaryService = primaryService;
        

        public Guid Id { get; set; } = new Guid();
        public Guid PrimaryServiceId => _primaryService.Id;
    }
}
