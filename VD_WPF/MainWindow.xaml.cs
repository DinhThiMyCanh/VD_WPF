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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VD_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnDangKy.Click += new RoutedEventHandler(DangKy);
            btnHuyBo.Click += new RoutedEventHandler(HuyBo);
        }

        private void HuyBo(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DangKy(object sender, RoutedEventArgs e)
        {
            string ht = txtHoTen.Text;
            string ns = dtpNgaySinh.Text;
            string gt = rdNam.IsChecked ==true ? "Nam" : "Nữ";

            string nn = "";
            if (chkTiengAnh.IsChecked == true)
                nn = nn + chkTiengAnh.Content;
            if (chkTiengTrung.IsChecked == true)
                nn = nn + "," + chkTiengTrung.Content;
            if (chkTiengNhat.IsChecked == true)
                nn = nn + "," + chkTiengNhat.Content;

            string qq = cboQuequan.Text;

            string dsmh = "";

            foreach (ListBoxItem mh in lstDSMH.SelectedItems)
                dsmh = dsmh + mh.Content +"\n";

            MessageBox.Show(@"Họ và tên:" +ht+"\n"+ "Ngày sinh:"+ ns +"\n" + "Quê quán:" +qq +
                "\nGiới tính:" +gt +"\n" +"Ngoại ngữ:" +nn +"\n"+"Danh sách môn học" +dsmh);
        }
    }
}
