using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace FootballersMVVM.View{

    public partial class TextBoxWithErrorProvider : UserControl {

        public static Brush BrushForAll { get; set; } = Brushes.Red;

        public Brush TextBoxBorderBrush {
            get {
                return border.BorderBrush;
            }
            set {
                border.BorderBrush = value;
            }
        }

        public string ToolTipText { get; set; } = "Uzupełnij dane";

        public TextBoxWithErrorProvider() {
            InitializeComponent();
            // Ustawienie koloru obramowania
            border.BorderBrush = BrushForAll;
        }

        public void SetError(string errorText) {
            textBlockToolTip.Text = errorText;


            if(textBox.Text == "") {
                // Brak danych
                border.BorderThickness = new Thickness(1);
                toolTip.Visibility = Visibility.Visible;
                this.IsNotEmpty = false;
            }
            else {
                // Zgłoszenie błędu
                border.BorderThickness = new Thickness(0);
                toolTip.Visibility = Visibility.Hidden;
                this.IsNotEmpty = true;
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e) {
            SetError(ToolTipText);
        }

        private void textBox_GotFocus(object sender, RoutedEventArgs e) {
            SetError(ToolTipText);
        }


        public static readonly DependencyProperty TextProperty =
       DependencyProperty.Register(
          "Text",
          typeof(string),
          typeof(TextBoxWithErrorProvider),
          new FrameworkPropertyMetadata(null));

        public string Text {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }


        public static readonly DependencyProperty IsNotEmptyProperty =
       DependencyProperty.Register(
          "IsNotEmpty",
          typeof(bool),
          typeof(TextBoxWithErrorProvider),
          new FrameworkPropertyMetadata(null));

        public bool IsNotEmpty {
            get { return (bool)GetValue(IsNotEmptyProperty); }
            set { SetValue(IsNotEmptyProperty, value); }
        }


    }
}
