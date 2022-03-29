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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Reciept reciept = new Reciept();
        NewCustomer newCustomer = new NewCustomer();
        UpdateJob UpdateJob = new UpdateJob();
        public MainWindow()
        {
            InitializeComponent();
            getUpComingJobs();         
        }

        private async void getUpComingJobs()
        {
            using (var context = new flourEntities2())
            {
                var jobs = await context.Customers.AsNoTracking().Where(x => x.Agreed == true && x.Finished == false).OrderBy(y => y.AgreedDate).ToListAsync();
                double days = 0;
                foreach (Customer job in jobs)
                {
                    jobsComingUp.Items.Add( job.Name + " ... " + job.Address + "  ..... " + getDaysSinceAgreed(job.AgreedDate));
                    days += job.Time;
                }
                jobsComingUp.Items.Add("");
                var weeknumber = Math.Round(days / 7);
                days += weeknumber * 2;
                var availDate = DateTime.Now.AddDays(days);
                jobsComingUp.Items.Add("Next available date ..... " + availDate.ToShortDateString() + " ( " + (weeknumber + 1) + " weeks )");
            }
        }

        private string getDaysSinceAgreed(DateTime? agreedDate)
        {

            DateTime endDate = DateTime.Today;
            int days = (endDate - agreedDate).Value.Days;
            return days.ToString() + " days since agreed";
        }

        private void newCustomerClick(object sender, RoutedEventArgs e)
        {
            newCustomer.Show();
        }

        private void updateCustomerClick(object sender, RoutedEventArgs e)
        {
            UpdateJob.Show();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Receipt_Click(object sender, RoutedEventArgs e)
        {
            reciept.Show();
        }
    }
}
