using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace U2_3_4_PruebaExamen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int vecesAceptar;
        private int vecesCancelar;
        private Frase frase;
 
        public MainWindow()
        {
            InitializeComponent();
            frase= new Frase();
            this.DataContext = frase;
        }

        private void aceptarButton_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            int veces;
            
            if (b.Tag.Equals("Aceptar"))  // También se puede comparar la propiedad "Content".
            {       
                vecesAceptar++;
                veces = vecesAceptar;
            }
            else
            {
                vecesCancelar++;
                veces = vecesCancelar;
            }
            
            String message = "El botón se ha pulsado " + (veces == 1 ? "una vez" : $"{veces} veces");
            MessageBox.Show(message);
        }

        private void añadirButton_Click(object sender, RoutedEventArgs e)
        {
            // Definir un nuevo TextBlock para recoger lo escrito en el TextBox al pulsar el botón "Añadir".
            TextBlock t = new TextBlock();

            // Las siguientes propiedades también se puden definir
            // en "Window.Resources" como un "Style" y luego asignar.
            t.Background = Brushes.IndianRed;
            t.Margin = new Thickness(5);
            t.Padding = new Thickness(5);
            t.Foreground = Brushes.White;
            t.Height = 35;
            t.FontSize = 18;

            // Nombre de la propiedad de la clase "Frase" a la que se enlaza.
            // Modo "OneTime" para que coja el valor en el momento de crear el binding, y no se actualice en el futuro.
            Binding binding = new Binding("TextoAlmacenado")    
            {
                Source = frase,
                Mode = BindingMode.OneTime,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };

            // Aplicar el binding al TextBlock.
            t.SetBinding(TextBlock.TextProperty, binding);
            
            contenedorWrapPanel.Children.Add(t);
        }
    }
}