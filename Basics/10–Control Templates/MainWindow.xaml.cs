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

namespace _10_Control_Templates
{
    /// <summary>
    /// 
    /// Source : https://wpf.2000things.com/2010/07/22/10-templates/
    /// 
    /// WPF의 템플릿은 스타일과 비슷하지만  다릅니다. 
    /// 템플릿을 사용하면 동작을 변경하지 않고도 UI 컨트롤 모양의 모든 설정 바꿀 수 있습니다.
    ///
    /// WPF의 모든 컨트롤에는 모양이 완전히 지정된 기본 템플릿이 있으며 사용합니다.
    /// 컨트롤의 모양을 변경하기 위해 기본 템플릿을 사용자가 작성한 템플릿으로 바꿀 수 있습니다.
    /// 
    /// 템플릿을 스타일과 비슷하게 리소스 형태로 저장하고 여러 컨트롤이 재사용 가능합니다.
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
