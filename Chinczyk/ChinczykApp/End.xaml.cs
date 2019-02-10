using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ChinczykApp
{
    /// <summary>
    /// Logika interakcji dla klasy End.xaml
    /// </summary>
    public partial class End : Window
    {
        private game Game;
        public End(game _game)
        {
            InitializeComponent();
            this.Game = _game;
            WinerName.Content = this.Game.gameModel.Winer.Name;
        }
    }
}
