using Demo.Configuration;
using Demo.Model;

namespace Demo.Repository
{
    internal class InvoiceRepository : Repository
    {
        public void AddInvoice(Invoice invoice)
        {
            Context.Invoices.Add(invoice);
            Context.SaveChanges();
        }

        public List<Invoice> GetAllInvoices() => Context.Invoices.ToList();

        public List<Invoice> GetInvoicesBySearch(string search)
        {
            using (var context = new TechnoServiceDatabaseContext())
            {
                return context.Invoices.Where(it => it.Device == search).ToList();
            }
        }
    }
}
