using Client.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientsAPI.Business.Repository
{
    public interface IClients
    {
        Task<List<Clients>> GetClientsAsync();    
    }
}
