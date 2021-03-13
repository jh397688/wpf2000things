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

namespace _11_Commands
{
    /// <summary>
    /// 
    /// Source : https://wpf.2000things.com/2010/07/23/11-commands/
    /// 
    /// WPF는 Command 기능을 지원합니다.
    /// Command는 WPF GUI 구성과 독립적으로 특정 작업을 수행하는 개체입니다.
    /// 
    /// Command의 주요 목적은 여러 컨트롤에서 공통된 코드를
    /// 개별 컨트롤의 이벤트 처리기에서 메인 처리 위치로 이동합니다.
    /// 이를 통해 여러 컨트롤이 동일한 Command 를 재사용 가능합니다.
    /// Command 를 사용할 컨트롤은 메인 처리 위치에 바인딩 걸어 사용합니다.
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CommandBinding binding = new CommandBinding(ApplicationCommands.New);
            binding.Executed += new ExecutedRoutedEventHandler(CommandNew_Executed);
            this.CommandBindings.Add(binding);
        }

        private void CommandNew_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Button Command Event!");
        }
    }
}
