using Demo.Model;
using Demo.Repository;
using System.Configuration;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demo
{
    public partial class MainWindow : Window
    {
        private readonly InvoiceRepository invoiceRepository = new();
        private readonly UserRepository userRepository = new();

        public MainWindow()
        {
            InitializeComponent();
            var invoice = new Invoice(DateOnly.Parse("12.12.2004"), "Computer");
            invoiceRepository.AddInvoice(invoice);
            List<Invoice> invoices = invoiceRepository.GetAllInvoices();

            InvoiceListView.ItemsSource = invoices;

            List<User> users = userRepository.GetAllUsers();
            TestTextBlock.Text = users[0].Role.Name;
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            InvoiceListView.ItemsSource = invoiceRepository.GetAllInvoices().Where(it => it.Id.ToString() == SearchTextBox.Text).ToList();

        }
    }
}