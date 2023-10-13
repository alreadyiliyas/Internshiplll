using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Politeh.DAL;
using Politeh.DAL.Model;

namespace Politeh.BLL
{
    public class ServiceAccount
    {
        private Repository<Account> repo = null;
        private ReturnResult<Account> result = null;
        private readonly IMapper _iMapper;
        public ServiceAccount(string path)
        {
            result = new Repository<Account>(path);
        }

        public void GetAllAccountCLient(int ClientId)
        {
            result = repo.GetAll();

            result.ListData = result.ListData.Where(w => w.ClientId == ClientId).ToList();

            return result.ListData;
        }
    }
}
