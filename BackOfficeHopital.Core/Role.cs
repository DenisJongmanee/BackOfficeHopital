using System;

namespace BackOfficeHopital.Core
{
    public class Role
    {
        public int IdRole { get; }
        public string NomRole { get; }

        
        public Role(int idRole, string nomRole)
        {
            this.IdRole = idRole;
            this.NomRole = nomRole;
        }

        public override string ToString()
        {
            return $"{NomRole}";
        }
    }

}
