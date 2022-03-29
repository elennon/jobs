using System;
using System.Collections.Generic;
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
    /// Interaction logic for NewCustomer.xaml
    /// </summary>
    public partial class NewCustomer : Window
    {
        public NewCustomer()
        {
            InitializeComponent();
        }


        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer();
            //customer.KeyId = new Random().Next();
            customer.Name = customerName.Text.ToString();
            customer.Number = customerNumber.Text.ToString();
            customer.Email = customerEmail.Text.ToString();
            customer.Address = customerAddress.Text.ToString();
            customer.AcrossTheFloor = Int32.Parse(widthAcrossTheFloor.Text);
            customer.HeightFromTheFloor = Int32.Parse(heightfromTheFloor.Text);
            if (angle.Text != "") { customer.Angle = Int32.Parse(angle.Text); }
            if (time.Text != "")
            {
                customer.Time = Convert.ToDouble(time.Text);
            }
            if (angle.Text != "")
            {
                customer.Price = Int32.Parse(price.Text);
            }

            DateTime? quoteDate = dateOfQuote.SelectedDate;
            if (quoteDate == null)
            {
                MessageBox.Show("No date");
            }
            else
            {
                customer.QuoteDate = quoteDate;
            }

            DateTime? agreedDate = dateAgreed.SelectedDate;
            customer.AgreedDate = agreedDate;

            customer.JobType = jobtype.Text.ToString();
            if (eighteenmmMdf.Text != "")
            {
                customer.EighteenMDF = Int32.Parse(eighteenmmMdf.Text);
            }
            if (twelvemmMdf.Text != "")
            {
                customer.TwelveMDF = Int32.Parse(twelvemmMdf.Text);
            }
            if (ninemmMdf.Text != "")
            {
                customer.NineMDF = Int32.Parse(ninemmMdf.Text);
            }
            if (runners.Text != "")
            {
                customer.Runners = Int32.Parse(runners.Text);
            }
            if (pushToOpen.Text != "")
            {
                customer.PushToOpen = Int32.Parse(pushToOpen.Text);
            }
            customer.ThreeBy = Int32.Parse(threeBy.Text);

            if (paint.Text != "")
            {
                customer.Paint = Int32.Parse(paint.Text);
            }
            if ((bool)agreedRd.IsChecked) { customer.Agreed = true; } else { customer.Agreed = false; }
            if ((bool)finishedRd.IsChecked) { customer.Finished = true; } else { customer.Finished = false; }

            using (var context = new flourEntities2())
            {
                context.Customers.Add(customer);
                context.SaveChanges(); // commits the changes to the database
            }

            MessageBox.Show("done");
        }

    }
}
