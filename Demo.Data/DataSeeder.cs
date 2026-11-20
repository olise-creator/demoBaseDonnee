using Demo.Data.Models;
using Demo.Data.Models.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Data
{
    public class DataSeeder
    {
        private readonly DemoDbContext _context;
        public DataSeeder(DemoDbContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            // Ne seed que si BD vide
            if (_context.Clients.Any())
                return;

            List<Client> clients = new List<Client>
            {
                new Client("Jean", "Dupont", estClientRegulier: true, gateauPreferee: TypeGateau.Tarte),
                new Client("Marie", "Martin", estClientRegulier: false, gateauPreferee: TypeGateau.Entremet),
                new Client("Pierre", "Bernard", estClientRegulier: true, gateauPreferee: TypeGateau.Etages),
                new Client("Sophie", "Petit", estClientRegulier: false, gateauPreferee: TypeGateau.Tarte),
                new Client("Luc", "Moreau", estClientRegulier: true, gateauPreferee: TypeGateau.Design)
            };
            _context.Clients.AddRange(clients);
            await _context.SaveChangesAsync();
        }
    }
}
