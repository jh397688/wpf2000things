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

namespace _2_Rendering_Tiers
{
    /// <summary>
    /// 
    /// Source : https://wpf.2000things.com/2010/07/14/2-rendering-tiers/
    /// 
    /// WPF 응용 프로그앰은 런타임에 그래픽카드 기능을 자동으로 검사하고
    /// 그래픽 카드에서 수행할 수 있는 기능을 나타내는 렌더링 계층 값을 할당합니다.
    ///
    /// 티어 0 - 하드웨어 가속 미사용, 모든 렌더링을 SW(CPU)에서 수행

    /// Tier 1 – 일부에서 하드웨어 가속 사용 DirectX version >= 9.0.  하드웨어 가속 항목 :
    ///     원형 그라데이션 스타일
    ///     3D 레이트레이싱
    ///     텍스트 렌더링
    ///     3D 안티 에일리어싱
    /// Tier 2- 대부분의 기능을 하드웨어 가속 사용DirectX version >= 9.0
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            // 티어를 확인하는 로직
            
            int renTier = (RenderCapability.Tier >> 16);
            MessageBox.Show(string.Format("Tier = {0}", renTier));
        }
    }
}
