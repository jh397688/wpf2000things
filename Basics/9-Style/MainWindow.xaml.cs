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

namespace _9_Style
{
    /// <summary>
    /// 
    /// Source : https://wpf.2000things.com/2010/07/21/9-styles/
    /// 
    /// WPF 에서 컨트롤 스타일은 컨트롤의 유사한 속성을 다른 컨트롤이 재사용 가능하도록 설정이 가능합니다.
    /// 컨트롤의 스타을을 리소스로 저장한 다음 컨트롤의 Style 속성에 리소스를 설정합니다.
    /// 이 방식으로 하나의 리소스를 이용하여 여러 컨트롤이 재사용 가능합니다.
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
