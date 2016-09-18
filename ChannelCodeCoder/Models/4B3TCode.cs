using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ChannelCodesCoder.Models
{
    public class _4B3TCode : ChanelCode
    {
        public _4B3TCode(string input)
        {
            InputInfo = input;
        }

        private Grid Interpret(Dictionary<string,string> dict)
        {
            Grid grid = new Grid();
            grid.Height = 80;
            grid.Width = 0;
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            int colCounter = 0;
            for (int i=0;i<InputInfo.Length;i++)
            {
                if ((i+1)%4==0)
                {
                    string paint = dict[InputInfo.Substring(i-3, 4)];
                    foreach (var part in paint.ToCharArray())
                    {
                        if (part == '-')
                        {
                            grid.ColumnDefinitions.Add(new ColumnDefinition());
                            Border border = new Border() { BorderThickness = new System.Windows.Thickness(2, 0, 2, 2), BorderBrush = Brushes.Red, Margin = new System.Windows.Thickness(-1) };
                            Grid.SetColumn(border, colCounter);
                            Grid.SetRow(border, 1);
                            grid.Children.Add(border);
                            grid.Width += 40;
                        }
                        else if (part == '+')
                        {
                            grid.ColumnDefinitions.Add(new ColumnDefinition());
                            Border border = new Border() { BorderThickness = new System.Windows.Thickness(2, 2, 2, 0), BorderBrush = Brushes.Red, Margin = new System.Windows.Thickness(-1) };
                            Grid.SetColumn(border, colCounter);
                            Grid.SetRow(border, 0);
                            grid.Children.Add(border);
                            grid.Width += 40;
                        }
                        else if (part == '0')
                        {
                            grid.ColumnDefinitions.Add(new ColumnDefinition());
                            Line line = new Line() { StrokeThickness = 2.0, Margin = new System.Windows.Thickness(-1), Stroke = Brushes.Red, VerticalAlignment = VerticalAlignment.Top, Stretch = Stretch.Fill, X1 = 1 };
                            Grid.SetColumn(line, colCounter);
                            Grid.SetRow(line, 1);
                            grid.Children.Add(line);
                            grid.Width += 40;
                        }
                        colCounter++;
                    }
                }                   
            }
            return grid;
        }

        public Grid DoR1()
        {
            return Interpret(R1);
        }

        public Grid DoR2()
        {
            return Interpret(R2);
        }
        public Grid DoR3()
        {
            return Interpret(R3);
        }


        private Dictionary<string, string> R1 = new Dictionary<string, string>()
        {
            {"0010","+++"},
            {"0001","++0"},
            {"0000","+0+"},
            {"0100","0++"},
            {"1000","+-+"},
            {"0011","0-+"},
            {"0101","-0+"},
            {"1001","00+"},
            {"1010","0+0"},
            {"1100","+00"},
            {"0110","-+0"},
            {"1110","+-0"},
            {"1101","+0-"},
            {"1011","0+-"},
            {"0111","-++"},
            {"1111","++-"}
        };

        private Dictionary<string, string> R2 = new Dictionary<string, string>()
        {
            {"0010","-+-"},
            {"0001","00-"},
            {"0000","0-0"},
            {"0100","-00"},
            {"1000","+-+"},
            {"0011","0-+"},
            {"0101","-0+"},
            {"1001","00+"},
            {"1010","0+0"},
            {"1100","+00"},
            {"0110","++0"},
            {"1110","+-0"},
            {"1101","+0-"},
            {"1011","0+-"},
            {"0111","-++"},
            {"1111","+--"}
        };

        private Dictionary<string, string> R3 = new Dictionary<string, string>()
        {
            {"0010","-+-"},
            {"0001","00-"},
            {"0000","0-0"},
            {"0100","-00"},
            {"1000","---"},
            {"0011","0-+"},
            {"0101","-0+"},
            {"1001","--+"},
            {"1010","-0-"},
            {"1100","0--"},
            {"0110","-+0"},
            {"1110","+-0"},
            {"1101","+0-"},
            {"1011","0+-"},
            {"0111","--+"},
            {"1111","+--"}
        };
    }
}
