using System.Windows.Controls;
using System.Windows.Media;

namespace ChannelCodesCoder.Models
{
    public class ManchesterCode : ChanelCode
    {
        public ManchesterCode(string input)
        {
            InputInfo = input;
        }
        private bool ImpulseIsUp { get; set; }

        public Grid Interpret()
        {
            Grid grid = new Grid();
            grid.Height = 80;
            grid.Width = 0;
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            for (int i=0;i<InputInfo.Length;i++)
            {
                if (InputInfo[i] == '0')
                {
                    grid.ColumnDefinitions.Add(new ColumnDefinition());
                    Border border1 = new Border() { BorderThickness = new System.Windows.Thickness(2, 0, 2, 2), BorderBrush = Brushes.Red , Margin= new System.Windows.Thickness(-1)};
                    Grid.SetColumn(border1, i*2);
                    Grid.SetRow(border1, 1);
                    grid.Children.Add(border1);
                    grid.Width += 40;

                    grid.ColumnDefinitions.Add(new ColumnDefinition());
                    Border border2 = new Border() { BorderThickness = new System.Windows.Thickness(2, 2, 2, 0), BorderBrush = Brushes.Red, Margin = new System.Windows.Thickness(-1) };
                    Grid.SetColumn(border2, i*2+1);
                    Grid.SetRow(border2, 0);
                    grid.Children.Add(border2);
                    grid.Width += 40;
                }
                else if (InputInfo[i] == '1')
                {
                    grid.ColumnDefinitions.Add(new ColumnDefinition());
                    Border border1 = new Border() { BorderThickness = new System.Windows.Thickness(2, 2, 2, 0), BorderBrush = Brushes.Red , Margin= new System.Windows.Thickness(-1)};
                    Grid.SetColumn(border1, i*2);
                    Grid.SetRow(border1, 0);
                    grid.Children.Add(border1);
                    grid.Width += 40;

                    grid.ColumnDefinitions.Add(new ColumnDefinition());
                    Border border2 = new Border() { BorderThickness = new System.Windows.Thickness(2, 0, 2, 2), BorderBrush = Brushes.Red, Margin = new System.Windows.Thickness(-1) };
                    Grid.SetColumn(border2, i*2+1);
                    Grid.SetRow(border2, 1);
                    grid.Children.Add(border2);
                    grid.Width += 40;
                }
                    
            }
            return grid;
        }
    }
}
