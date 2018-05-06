using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Models;


namespace ClassLibrary.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private Context _context = null;
        public ClientRepository(Context context)
        {
            _context = context;
        }

        public IEnumerable<Client> GetClients()
        {
            return _context.Clients.ToList();
        }

        public Client GetClientById(int id)
        {
            var query = from c in _context.Clients where c.Id == id select c;
            return query.Single();
        }

        public void InsertClient(Client client, int UserId)
        {
            _context.Users.Find(UserId).Clients.Add(client);
        }

        public void UpdateClient(Client client) { }

        public void DeleteClient(int ClientId)
        {
            Client client = _context.Clients.Where(c => c.Id == ClientId).SingleOrDefault();
            _context.Clients.Remove(client);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
