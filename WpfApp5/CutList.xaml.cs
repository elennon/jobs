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
    /// Interaction logic for CutList.xaml
    /// </summary>
    public partial class CutList : Window
    {
        public CutList()
        {
            InitializeComponent();
        }

        private void cuttingList_Click(object sender, RoutedEventArgs e)
        {

            Drawers unit = new Drawers(Int32.Parse(width.Text),
                Int32.Parse(fullHeight.Text),
                Int32.Parse(kicker.Text),
                Int32.Parse(lowSideHeight.Text),
                Int32.Parse(flatTopWidth.Text),
                Double.Parse(angle.Text),
                Int32.Parse(drawerNumber.Text),
                Int32.Parse(depth.Text),
                Int32.Parse(cabinetWidth.Text),
                (bool)hasTallUnit.IsChecked,
                unitTypeCmb.Text);
            unit.getCuttingList(unit);
            getPrice(unit);
        }

        private void getPrice(Drawers understairDrawerUnit)
        {
            double price = 0;
            var noShts = (understairDrawerUnit.eighteenMdfArea + (understairDrawerUnit.eighteenMdfArea / 100 * 10)) / 2880000;
            int i = (int)Math.Ceiling(noShts);
            price += i * 60;
            var notvlvShts = (understairDrawerUnit.twelveMdfArea + (understairDrawerUnit.twelveMdfArea / 100 * 10)) / 2880000;
            int itwlv = (int)Math.Ceiling(notvlvShts);
            price += itwlv * 50;
            var drss = 0;
            if (understairDrawerUnit.drawerNumber == 3)
            {
                price += 45;
                drss = 3;
            }
            else price += 90; drss = 3;
            price += 70; // for 3 by 1.5
            price += 40; // paint
            price += 30; // push to open
            price += 15; // deisel
            price += 8;  // fixings
            //price += understairDrawerUnit.
            costList.Items.Add(" number of 18mm mdf ... " + i.ToString());
            costList.Items.Add(" number of 12mm mdf ... " + itwlv.ToString());
            costList.Items.Add(" number drawer runners ... " + drss.ToString());
            costList.Items.Add(" full materials cost ... €" + price.ToString());
            //MessageBox.Show("materials -- " + price.ToString());
        }

    }
}
