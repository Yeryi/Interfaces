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
            Canvas.SetTop(CanvasDibujo, 500);
            Canvas.SetLeft(CanvasDibujo, 500);

            CanvasDibujo.Height = 500;
            CanvasDibujo.Children.Clear();

            Ellipse planeta1 = new Ellipse();
            Ellipse planeta2 = new Ellipse();
            Ellipse planeta3 = new Ellipse();

            planeta1.Height = 20;
            planeta1.Width = 20;
            planeta2.Height = 20;
            planeta2.Width = 20;
            planeta3.Height = 20;
            planeta3.Width = 20;

            planeta1.Fill = new SolidColorBrush(Colors.Red);
            planeta2.Fill = new SolidColorBrush(Colors.Red);
            planeta3.Fill = new SolidColorBrush(Colors.Red);

            CanvasDibujo.Children.Add(planeta1);
            CanvasDibujo.Children.Add(planeta2);
            CanvasDibujo.Children.Add(planeta3);

            //Canvas.SetLeft(planeta, 250);
            Canvas.SetTop(planeta1, Canvas.GetTop(CanvasDibujo) / 2);
            Canvas.SetTop(planeta2, Canvas.GetTop(CanvasDibujo) / 2);
            Canvas.SetLeft(planeta2, 75);
            Canvas.SetTop(planeta3, Canvas.GetTop(CanvasDibujo) / 2);
            Canvas.SetLeft(planeta3, 150);
        }
    }
}
