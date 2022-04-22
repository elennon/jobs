using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for UpdateJob.xaml
    /// </summary>
    public partial class UpdateJob : Window
    {
        List<Customer> customerList = new List<Customer>();
        //Customer customer;
        int custId;
        public UpdateJob()
        {
            InitializeComponent();
            getAllCustomers();
        }

        private async void getAllCustomers()
        {
            using (var context = new flourEntities2())
            {
                var jobs = await context.Customers.AsNoTracking().Where(x => x.Finished == false).ToListAsync();
                foreach (Customer job in jobs)
                {
                    jobsDone.Items.Add( job.Name + "-" + job.Address );
                }
            }
        }

        private async void jobsDone_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            using (var context = new flourEntities2())
            {
                var gfgfgf = jobsDone.SelectedItem.ToString().Split('-');
                var custName = jobsDone.SelectedItem.ToString().Split('-')[0];
                var custAddress = jobsDone.SelectedItem.ToString().Split('-')[1];//.Split(' ')[1];
                customerList = await context.Customers.AsNoTracking().Where(x => x.Name == custName && x.Address == custAddress).ToListAsync();
                customerName.Text = customerList.First().Name;
                custId = customerList.First().CustomerId;
            }
        }

        private async void updateJob_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new flourEntities2())
            {
                var customer = await context.Customers.AsNoTracking().Where(x => x.CustomerId == custId).FirstOrDefaultAsync();
                if (agreedRd.IsChecked == true)
                {
                    customer.Agreed = true;
                    DateTime? agreedDate = dateAgreed.SelectedDate;
                    customer.AgreedDate = agreedDate;
                }
                else { 

                    customer.timeTaken = float.Parse(timeSpent.Text);
                    if ((bool)paidByCash.IsChecked) { customer.payedByCash = true; }
                    if ((bool)paidByTransfer.IsChecked) { customer.payedByTransfer = true; }
                    customer.finishDate = DateTime.Parse(finishDate.Text);
                    customer.Finished = true;
                }
                context.Customers.Attach(customer);
                context.Entry(customer).State = EntityState.Modified;
                context.SaveChanges();
                MessageBox.Show("done and done");
            }
        }
    }
}
