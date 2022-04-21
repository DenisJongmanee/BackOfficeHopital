using System;

namespace BackOfficeHopital.Core
{
    class Service
    {
        public int IdService { get; }
        public string NomService { get; }

        public Service(int idService, string nomService)
        {
            this.IdService = idService;
            this.NomService = nomService;
        }
    }
}
