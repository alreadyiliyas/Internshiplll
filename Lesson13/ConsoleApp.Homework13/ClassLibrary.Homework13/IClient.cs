using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Homework13
{
	public interface IClient
	{
		int Id { get; set; }
		string Name { get; set; }
		bool StateQueue { get; set; }
		DateTime DateOfBirthday { get; set; }
		void ShowAllClient();
		void AddQueue(Queue<IClient> clients);
		void CreditService();
		void OpenDeposit();
		void ConsultationService();
	}
}
