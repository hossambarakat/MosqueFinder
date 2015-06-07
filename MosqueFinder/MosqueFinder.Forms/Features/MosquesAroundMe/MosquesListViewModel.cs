using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosqueFinder.Forms.Features.MosquesAroundMe
{
    public class MosquesListViewModel
    {
        public ObservableCollection<MosqueViewModel> Mosques { get; private set; }

        public MosquesListViewModel()
        {
            Mosques = new ObservableCollection<MosqueViewModel>();
        }

        public void Load()
        {
           Mosques.Clear();
           Mosques.Add(new MosqueViewModel(){Name = "Parramatta Mosque"});
           Mosques.Add(new MosqueViewModel() { Name = "Aupurn Mosque" });
        }
    }
}
