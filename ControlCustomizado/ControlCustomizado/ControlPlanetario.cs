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
using Windows.UI.Xaml.Media.Animation;
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

        public int TiempoGiroAnimacion
        {
            get { return (int)GetValue(TiempoGiroAnimacionProperty); }
            set { SetValue(TiempoGiroAnimacionProperty, value); }
        }
        // Using a DependencyProperty as the backing store for TiempoGiroAnimacion.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TiempoGiroAnimacionProperty =
            DependencyProperty.Register("TiempoGiroAnimacion", typeof(int), typeof(ControlPlanetario), new PropertyMetadata(15, null));

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            Canvas CanvasDibujo = (Canvas)GetTemplateChild("CanvasPlanetario");
            Ellipse Sol = (Ellipse)GetTemplateChild("Sol");
            double Multiplicador = CalcularMultiplicador();
            CanvasDibujo.Children.Clear();

            foreach (Planeta item in ItemsSource)
            {
                Ellipse planeta = new Ellipse();

                planeta.Height = item.Diametro * Multiplicador;
                planeta.Width = item.Diametro * Multiplicador;

                planeta.Fill = new SolidColorBrush(Colors.Red);
                CanvasDibujo.Children.Add(planeta);

                Canvas.SetLeft(planeta, (this.Width / 2) - (item.DistanciaSol * Multiplicador));
                Canvas.SetTop(planeta, (this.Height / 2) - (item.Diametro * Multiplicador / 2));

            }
            AnimacionPlanetas(CanvasDibujo, Sol);
        }

        private double CalcularMultiplicador()
        {
            double MayorDistancia = 0;
            foreach (Planeta item in ItemsSource)
            {
                if (MayorDistancia < item.DistanciaSol)
                {
                    MayorDistancia = item.DistanciaSol;
                }
            }

            return (this.Width / 2) / MayorDistancia;
        }

        private void AnimacionPlanetas(Canvas CanvasPlanetas, Ellipse Sol)
        {
            Storyboard storyboard = new Storyboard();
            storyboard.RepeatBehavior = RepeatBehavior.Forever;

            for (int i = 0; i < CanvasPlanetas.Children.Count; i++)
            {
                DoubleAnimation rotateAnimation = new DoubleAnimation()
                {
                    From = 0,
                    To = 360,
                    Duration = new Duration(TimeSpan.FromSeconds(TiempoGiroAnimacion * (((this.Width / 2) - (Canvas.GetLeft(CanvasPlanetas.Children[i])))) / (this.Width / 2))),
                    RepeatBehavior = RepeatBehavior.Forever
                };


                RotateTransform Rotar = new RotateTransform();
                Rotar.CenterX = (this.Width / 2) - (Canvas.GetLeft(CanvasPlanetas.Children[i]));
                CanvasPlanetas.Children[i].RenderTransform = Rotar;

                Storyboard.SetTarget(rotateAnimation, CanvasPlanetas.Children[i]);
                Storyboard.SetTargetProperty(rotateAnimation, "(UIElement.RenderTransform).(RotateTransform.Angle)");

                storyboard.Children.Add(rotateAnimation);

            }
            storyboard.Begin();
        }
    }
}
