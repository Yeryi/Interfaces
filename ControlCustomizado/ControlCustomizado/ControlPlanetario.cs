using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
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
