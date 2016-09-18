using System.Windows.Controls;
using System.Windows.Media;

namespace ChannelCodesCoder.Models
{
    public class ImpulseCode : ChanelCode
    {

        public ImpulseCode(string input)
        {
            InputInfo = input;
        }

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
                    Border border = new Border() { BorderThickness = new System.Windows.Thickness(2, 0, 2, 2), BorderBrush = Brushes.Red , Margin= new System.Windows.Thickness(-1)};
                    Grid.SetColumn(border, i);
                    Grid.SetRow(border, 1);
                    grid.Children.Add(border);
                    grid.Width += 40;
                }
                else if (InputInfo[i] == '1')
                {
                    grid.ColumnDefinitions.Add(new ColumnDefinition());
                    Border border = new Border() { BorderThickness = new System.Windows.Thickness(2, 2, 2, 0), BorderBrush = Brushes.Red , Margin= new System.Windows.Thickness(-1)};
                    Grid.SetColumn(border, i);
                    Grid.SetRow(border, 0);
                    grid.Children.Add(border);
                    grid.Width += 40;
                }
                    
            }
            return grid;
        }

    }
}
