using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Runner.Views;
using Runner.Models;

namespace Runner.ViewModels
{
    class MainMenuViewModel : MainWindow
    {
        public DelegateCommandModel StartGame { get; set; }
        


        public MainMenuViewModel()
        {
            this.StartGame = new DelegateCommandModel(
                (o) => { mainFrame.NavigationService.Navigate(new GameViewModel()); }
                );
        }

    }
}
