using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MosqueFinder.Forms.Features.MosquesAroundMe
{
    public partial class MosquesList : ContentPage
    {
        private MosquesListViewModel _mosquesListViewModel;

        public MosquesList()
        {
            _mosquesListViewModel = new MosquesListViewModel();
            InitializeComponent();
            BindingContext = _mosquesListViewModel;
        }

        protected override void OnAppearing()
        {
            _mosquesListViewModel.Load();
        }
    }
}
