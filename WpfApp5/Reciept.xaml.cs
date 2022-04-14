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
    /// Interaction logic for Reciept.xaml
    /// </summary>
    public partial class Reciept : Window
    {
        public Reciept()
        {
            InitializeComponent();
        }

        private void addReceipt_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new flourEntities2())
            {
                var rec = new receipt();
                rec.id = new Random().Next();
                rec.supplier = supplier.SelectedItem.ToString();
                DateTime ? ff = dateBought.SelectedDate;
                if (ff == null)
                {
                    MessageBox.Show("No date");
                }
                else
                {
                    rec.dateBought = ff;
                }
                rec.spent = Convert.ToDouble(spent.Text);
                
                context.receipts.Add(rec);
                context.SaveChanges();
                MessageBox.Show("done and done");
            }
        }
    }
}
