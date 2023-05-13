using CommunityToolkit.Mvvm.Input;
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

namespace Email.UserControls.View
{
    /// <summary>
    /// Interaction logic for SearchBarControl.xaml
    /// </summary>
    public partial class SearchBarControl : UserControl
    {


        public SearchBarControl()
        {
            InitializeComponent();
        }

        public string SearchText
        {
            get { return (string)GetValue(SearchTextProperty); }
            set { SetValue(SearchTextProperty, value); }
        }

        public static readonly DependencyProperty SearchTextProperty =
            DependencyProperty.Register("SearchText", typeof(string), typeof(SearchBarControl), new PropertyMetadata(""));

        public RelayCommand SearchCommand
        {
            get { return (RelayCommand)GetValue(SearchCommandProperty); }
            set { SetValue(SearchCommandProperty, value); }
        }

        public static readonly DependencyProperty SearchCommandProperty =
            DependencyProperty.Register("SearchCommand", typeof(RelayCommand), typeof(SearchBarControl), new PropertyMetadata(null));
    }
}
