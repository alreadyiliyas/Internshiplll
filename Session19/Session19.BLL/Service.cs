using AutoMapper;
using Session19.BLL.Model;
using Session19.DAL;
using Session19.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session19.BLL
{
	public abstract class Service<T>
	{
		protected ReturnResult<T> result = null;
		protected Repository<T> repo = null;
		protected readonly IMapper _iMapper;
		public Service(string path)
		{
			repo = new Repository<T>(path);
			_iMapper = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<Account, AccountDTO>().ReverseMap();
				cfg.CreateMap<ApiResponse, ApiResponseDTO>().ReverseMap();
				cfg.CreateMap<Currency, CurrencyDTO>().ReverseMap();
			}).CreateMapper();
		}
	}
}
