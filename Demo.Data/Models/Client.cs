using Demo.Data.Models.Types;
using System;

namespace Demo.Data.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public bool EstClientRegulier { get; set; }

        public DateOnly DateCreation { get; set; }

        public TypeGateau GateauPreferee { get; set; }

    }
}
