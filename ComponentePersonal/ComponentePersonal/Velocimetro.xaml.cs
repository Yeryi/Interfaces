using Microsoft.Toolkit.Uwp.UI.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
    public sealed partial class Velocimetro : UserControl
    {
        public Velocimetro()
        {
            this.InitializeComponent();
        }

        /*public static readonly DependencyProperty ValueProperty =
           DependencyProperty.Register(nameof(Value), typeof(double), typeof(RadialGauge), new PropertyMetadata(null));

        public double Value
        {
            get { return (double)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }*/

        private void AumentarVelocidad(object sender, RoutedEventArgs e)
        {
            if (RadialGaugeControl.IsInteractive == true && RadialGaugeControl.Value < RadialGaugeControl.Maximum)
            {
                RadialGaugeControl.Value = RadialGaugeControl.Value+1;
            }
        }
    }
}
