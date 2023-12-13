using Client.Shared.Models;
using ClientsAPI.Business.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientsAPI.Infrastructure.Data
{
    public class ClientsRepository : IClients
    {
        public Task<List<Clients>> GetClientsAsync()
        {
            using StreamReader reader = new("clientsData.json");
            var json = reader.ReadToEnd();
            List<Clients> clients = JsonConvert.DeserializeObject<List<Clients>>(json);
            return Task.FromResult(clients);
        }
    }
}