using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Control de usuario está documentada en https://go.microsoft.com/fwlink/?LinkId=234236

namespace ComponentePersonal
{
    public sealed partial class AnilloVelocidad : UserControl
    {
        //public int valor = -90;
        public AnilloVelocidad()
        {
            this.InitializeComponent();
            valor = -90;
        }
        /// <summary>
        /// Este método se encarga de aumentar el ángulo de 1 en 1 cuando el botón se pulse una vez o se mantenga pulsado.
        /// </summary>
        /// <param name="sender">Contiene la instancia del control que lanza el evento, en este caso button.</param>
        /// <param name="e">Este parametro cambia dependiendo la firma del hander del evento</param>
        public void AumentarVelocidad(object sender, RoutedEventArgs e)
        {
            if (valor < 90)
            {
                Velocidad.Text = (valor + 91).ToString();
                valor++;
            }
            
        }
        /// <summary>
        /// Cuando el botón deja de estar pulsado, la velocidad (ángulo) disminuirá.
        /// </summary>
        /// <param name="sender">Contiene la instancia del control que lanza el evento, en este caso button.</param>
        /// <param name="e">Este parametro cambia dependiendo la firma del hander del evento</param>
        public async void RepeatButton_LostFocus(object sender, RoutedEventArgs e)
        {
            while (valor > -90)
            {
                Velocidad.Text = (valor + 89).ToString();
                await Task.Delay(50);
                valor--;
            }
        }

        /// <summary>
        /// La variable valor es el ángulo que va a ir tomando el velocímetro. 
        /// Necesitamos hacer un DependencyProperty para que la variable se vaya actualizando cuando se cambie su valor.
        /// </summary>
        public int valor
        {
            get { return (int)GetValue(valorProperty); }
            set { SetValue(valorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for valor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty valorProperty =
            DependencyProperty.Register("valor", typeof(int), typeof(AnilloVelocidad), new PropertyMetadata(0));


    }
}
