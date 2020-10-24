using FarmPlanner.Interfaces;
using FarmPlanner.ViewModels;
using FarmPlanner.Views;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPlanner
{
    class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            NavCommand = new MyICommand<string>(OnNav);
        }

        private PlantListViewModel plantListViewModel = new PlantListViewModel();

        private PlantCategoryViewModel plantCategoriesViewModel = new PlantCategoryViewModel();

        private BindableBase _CurrentViewModel;

        public BindableBase CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set { SetProperty(ref _CurrentViewModel, value); }
        }

        public MyICommand<string> NavCommand { get; private set; }

        private void OnNav(string destination)
        {
            switch (destination)
            {
                case "plant categories":
                    CurrentViewModel = plantCategoriesViewModel;
                    break;
                case "plants":
                default:
                    CurrentViewModel = plantListViewModel;
                    break;
            }
        }
    }
}
