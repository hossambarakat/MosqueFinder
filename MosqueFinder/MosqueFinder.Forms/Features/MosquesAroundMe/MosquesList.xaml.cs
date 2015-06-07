using MosqueFinder.Forms.Core.DI;
using MosqueFinder.Forms.Services;
using MosqueFinder.Forms.Services.Abstarcts;
using Xamarin.Forms;

namespace MosqueFinder.Forms.Features.MosquesAroundMe
{
    public partial class MosquesList : ContentPage
    {
        private MosquesListViewModel _mosquesListViewModel;

        public MosquesList()
        {
            _mosquesListViewModel = IoCHelper.Resolve<MosquesListViewModel>();
            InitializeComponent();
            BindingContext = _mosquesListViewModel;
            mosquesListView.ItemSelected += (sender, args) =>
            {
                if(sender==null)return;

                mosquesListView.SelectedItem = null;
            };
        }

        protected override void OnAppearing()
        {
            _mosquesListViewModel.Load();
        }
    }
}
