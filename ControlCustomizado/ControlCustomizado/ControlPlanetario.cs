using ControlCustomizado.Datos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace ControlCustomizado
{
    public sealed class ControlPlanetario : Control
    {
        public ControlPlanetario()
        {
            this.DefaultStyleKey = typeof(ControlPlanetario);
        }

        public ObservableCollection<Planeta> ItemsSource
        {
            get { return (ObservableCollection<Planeta>)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ItemsSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource", typeof(ObservableCollection<Planeta>), typeof(ControlPlanetario), new PropertyMetadata(null));



        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            Canvas CanvasDibujo = (Canvas)GetTemplateChild("CanvasPlanetario");
            CanvasDibujo.Children.Clear();

            Ellipse planeta = new Ellipse();

            planeta.Height = 20;
            planeta.Width = 20;
            planeta.Fill = new SolidColorBrush(Colors.Red);

            CanvasDibujo.Children.Add(planeta);
            Canvas.SetLeft(planeta, 250);
            Canvas.SetTop(planeta, 250);
        }
    }
}
