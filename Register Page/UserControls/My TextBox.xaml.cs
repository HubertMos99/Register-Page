using System.Windows;
using System.Windows.Controls;

namespace Register_Page.UserControls
{
   
    public partial class My_TextBox : UserControl
    {
        public My_TextBox()
        {
            InitializeComponent();
        }


        public string Hint
        {
            get { return (string)GetValue(HintProperty); }
            set { SetValue(HintProperty, value); }
        }

        public static readonly DependencyProperty HintProperty = DependencyProperty.Register
            ("Hint", typeof(string), typeof(My_TextBox));
    }
}
