using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Runner.Views;
using Runner.Models;
using System.Windows;

namespace Runner.ViewModels
{
    class MainMenuViewModel 
    {
        public DelegateCommandModel StartGame { get; set; }
        public DelegateCommandModel EndGame { get; set; }
        


        public MainMenuViewModel()
        {
            
            this.StartGame = new DelegateCommandModel(
                (o) => { MainWindow.frame.NavigationService.Navigate(new GameViewModel()); }
                );

            this.EndGame = new DelegateCommandModel(
                (o) => { Application.Current.Shutdown(); });
            


        }

    }
}
