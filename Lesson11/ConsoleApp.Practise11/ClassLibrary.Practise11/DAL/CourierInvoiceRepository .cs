using ClassLibrary.Practise11.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Practise11.DAL
{
    public class CourierInvoiceRepository
    {
        private string connectionString;

        public CourierInvoiceRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        private List<CourierInvoice> ReadInvoices(NpgsqlDataReader reader)
        {
            List<CourierInvoice> invoices = new List<CourierInvoice>();

            while (reader.Read())
            {
                CourierInvoice invoice = new CourierInvoice
                {
                    InvoiceId = Convert.ToInt32(reader["InvoiceId"]),
                    SenderName = reader["SenderName"].ToString(),
                    ReceiverName = reader["ReceiverName"].ToString(),
                    Amount = Convert.ToDecimal(reader["Amount"]),
                    // Добавьте другие свойства, если есть
                };

                invoices.Add(invoice);
            }

            return invoices;
        }
        public List<CourierInvoice> GetAllInvoices()
        {
            using(NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM your_table"; // Замените "your_table" на реальное имя вашей таблицы

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        return ReadInvoices(reader);
                    }
                }
            }
        }

        public CourierInvoice GetInvoiceById(int invoiceId)
        {
            // Реализуйте код для получения накладной по ID из базы данных
        }

        public void AddInvoice(CourierInvoice invoice)
        {
            // Реализуйте код для добавления новой накладной в базу данных
        }

        public void UpdateInvoice(CourierInvoice invoice)
        {
            // Реализуйте код для обновления накладной в базе данных
        }

        public void DeleteInvoice(int invoiceId)
        {
            // Реализуйте код для удаления накладной из базы данных
        }
    }
}
