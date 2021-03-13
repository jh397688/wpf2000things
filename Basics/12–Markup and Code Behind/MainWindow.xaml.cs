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

namespace _12_Markup_and_Code_Behind
{
    /// <summary>
    /// 
    /// Source : https://wpf.2000things.com/2010/07/24/12-markup-and-code-behind/
    /// 
    /// WPF는 XAML(Markup) 와 CodeBehind 로 나누어져 있습니다.
    /// 마크업은 어플리케이션의 레이아웃과 컨트롤 등을 정의합니다.
    /// CodeBehind는 마크업에서 정의한 부분의 동작을 정의합니다.
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button CodeBehind Event!");
        }
    }
}
