using AutoMapper;
using Session19.DAL;
using Session19.DAL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Session19.BLL.Model
{
	public class ServiceAccount : Service<Account>
	{
		public ServiceAccount(string path) : base(path)
		{
		}

		public (bool isError, string message) RegisterAccount(AccountDTO account)
		{
			var accountModel = _iMapper.Map<AccountDTO, Account>(account);

			var existingAccount = repo.GetAll().ListData.FirstOrDefault(a => a.Login == account.Login);
			if (existingAccount != null)
			{
				return (true, "Аккаунт с таким именем уже существует");
			}

			result = repo.Create(accountModel);

			if (result.IsError)
			{
				return (true, "Ошибка при создании аккаунта");
			}

			return (false, "Аккаунт успешно зарегистрирован");
		}

		public Account AuthorizationClient(AccountDTO account)
		{
			// Маппинг DTO на модель
			var accountModel = _iMapper.Map<AccountDTO, Account>(account);

			// Поиск аккаунта по имени и паролю
			var existingAccount = repo.GetAll().ListData.FirstOrDefault(
				a => a.Login == accountModel.Login && a.Password == accountModel.Password);

			if (existingAccount != null)
			{
				Console.WriteLine("Успешно. Привет! {0}", existingAccount.Login);
			}
			else
			{
				Console.WriteLine("Неправильный логин или пароль!");
			}
			return existingAccount;
		}
		
	}

}
