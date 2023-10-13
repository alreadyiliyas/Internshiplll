using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Politeh.BLL.Model;
using Politeh.DAL;
using Politeh.DAL.Model;

namespace Politeh.BLL
{
    public class ServiceClient
    {
        private Repository<Client> repo = null;
        private ReturnResult<Client> result = null;
        private readonly IMapper _iMapper;
        public ServiceClient(string path)
        {
            result = new Repository<Client>(path);
            _iMapper = SettingAutoMapper.Init()
                .CreateMapper();
        }

        public (bool isError, string message) RegisterClient(ClientDTO client)
        {
            result = repo.Create(_iMapper.Map<ClientDTO>);

            return (result.IsError, 
                result.Exception!=null 
                 ? result.Exception.Message
                 : "");
        }

        public Client AuthorizationClient(ClientDTO client)
        {
            result = repo.GetAll();

            result.Data = result.ListData.FirstOrDefault(f => f.Email == client.Email
                && f.Password == client.Password);
            result = repo.GetClient(client.Email, client.Password);

            return _iMapper.Map<ClientDTO>(result.Data);
        }
    }
}
