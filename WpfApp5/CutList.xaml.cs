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
                (bool)hasTallUnit.IsChecked);
            unit.getCuttingList(unit);
        }
    }
}
