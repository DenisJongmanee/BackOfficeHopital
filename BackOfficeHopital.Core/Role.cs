using System;

namespace BackOfficeHopital.Core
{
    class Role
    {
        public int IdRole { get; }
        public string NomRole { get; }

        public Role(int idRole, string nomRole)
        {
            this.IdRole = idRole;
            this.NomRole = nomRole;
        }
    }

}
