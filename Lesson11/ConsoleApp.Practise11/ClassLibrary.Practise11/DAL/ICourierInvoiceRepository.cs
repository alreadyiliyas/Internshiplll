using ClassLibrary.Practise11.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Practise11.DAL
{
    public interface ICourierInvoiceRepository
    {
        List<CourierInvoice> GetAllInvoices();
        CourierInvoice GetInvoiceById(int invoiceId);
        void AddInvoice(CourierInvoice invoice);
        void UpdateInvoice(CourierInvoice invoice);
        void DeleteInvoice(int invoiceId);
    }
}
