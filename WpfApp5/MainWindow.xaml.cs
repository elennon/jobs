using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
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
        CutList cutList = new CutList();
        public MainWindow()
        {
            InitializeComponent();
            getUpComingJobs();
            var startDate = DateTime.ParseExact("01/01/2022", "MM/dd/yyyy", new CultureInfo("en-IE"));
            var endDate = DateTime.Now;
            var monthsTill = MonthsBetween(startDate, endDate);
            cmbMonths.ItemsSource = monthsTill;
            cmbMonths.SelectedIndex = Convert.ToInt32(monthsTill.LongCount()) - 1;
            getFinishedJobsByMonth(monthsTill.Last().Monthh);
        }

        public static IEnumerable<Months> MonthsBetween(
        DateTime startDate,
        DateTime endDate)
        {
            DateTime iterator;
            DateTime limit;
            

            if (endDate > startDate)
            {
                iterator = new DateTime(startDate.Year, startDate.Month, 1);
                limit = endDate;
            }
            else
            {
                iterator = new DateTime(endDate.Year, endDate.Month, 1);
                limit = startDate;
            }

            var dateTimeFormat = CultureInfo.CurrentCulture.DateTimeFormat;
            while (iterator <= limit)
            {
                Months mm = new Months();
                mm.Monthh = iterator.Month; // 
                mm.Yearr = iterator.Year;
                mm.MonthName = dateTimeFormat.GetMonthName(iterator.Month);
                yield return (
                    mm                    
                );
                iterator = iterator.AddMonths(1);
            }
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

        private async void getFinishedJobsByMonth(int month)
        {
            using (var context = new flourEntities2())
            {
                var jobs = await context.Customers.AsNoTracking().Where(x => x.Finished == true && x.finishDate.Value.Month == month).OrderBy(y => y.AgreedDate).ToListAsync();
                foreach (Customer job in jobs)
                {
                    jobsDoneByMonth.Items.Add(job.Name + " ... " + job.Address + "  ..... " + getDaysSinceAgreed(job.finishDate));
                }
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

        private void Receipt_Click(object sender, RoutedEventArgs e)
        {
            reciept.Show();
        }

        private void cutList_Click(object sender, RoutedEventArgs e)
        {
            cutList.Show();
        }

        private async void cmbMonths_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Months m = new Months();
            m = (Months)cmbMonths.SelectedItem;
            using (var context = new flourEntities2())
            {
                double? tot = 0;
                var invoices = await context.receipts.AsNoTracking().Where(x => x.dateBought.Value.Month == m.Monthh).ToListAsync();
                foreach (receipt rec in invoices)
                {
                    tot += rec.spent;
                }
                spent.Text = tot.ToString();
                double? made = 0;
                var jobsDone = await context.Customers.AsNoTracking().Where(x => x.Finished == true && x.finishDate.Value.Month == m.Monthh).ToListAsync();
                foreach (Customer job in jobsDone)
                {
                    made += job.Price;
                }
                doshMade.Text = made.ToString();
            }
            jobsDoneByMonth.Items.Clear();
            getFinishedJobsByMonth(m.Monthh);
        }

        
    }

    public class Months
    {
        private int nameValue;
        public int Monthh
        {
            get
            {
                return nameValue;
            }
            set
            {
                nameValue = value;
            }
        }

        private string monthNmaeameValue;
        public string MonthName
        {
            get
            {
                return monthNmaeameValue;
            }
            set
            {
                monthNmaeameValue = value;
            }
        }
        private int yearValue;
        private object selectedItem;

        public Months(object selectedItem)
        {
            this.selectedItem = selectedItem;
        }

        public Months()
        {
        }

        public int Yearr
        {
            get
            {
                return yearValue;
            }
            set
            {
                if (value != yearValue)
                {
                    yearValue = value;
                }
            }
        }
    }
    }
