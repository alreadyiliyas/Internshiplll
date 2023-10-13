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
    public class SettingAutoMapper
    {
        public static MapperConfiguration Init()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Client, ClientDTO>().ReverseMap();
                cfg.CreateMap<Address, AddressDTO>().ReverseMap();
                cfg.CreateMap<Account, AccountDTO>().ReverseMap();
            });
        }
    }
}
