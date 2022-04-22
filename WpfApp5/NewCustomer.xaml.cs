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
            if (price.Text != "")
            {
                customer.Price = Int32.Parse(price.Text);
            }
            else
            {
                MessageBox.Show("price please");
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
             customer.JobType = jobtype.Text.ToString();
            
             if ((bool)agreedRd.IsChecked) { customer.Agreed = true; } else { customer.Agreed = false; }
            
            using (var context = new flourEntities2())
            {
                context.Customers.Add(customer);
                context.SaveChanges(); // commits the changes to the database
            }

            MessageBox.Show("done");
        }

    }
}
