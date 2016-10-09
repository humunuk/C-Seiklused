using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NB! Järgmine nimeruum on selle jaoks, et leida observable collection
using System.Collections.ObjectModel;
using InimesteKuvamine.Models;

namespace InimesteKuvamine.ViewModels
{
    public class MainWindowVM
    {
        //ObservableCollection - muudab automaatselt vaates asju. (List jms nõuavad käsitsi värskendust)
        private ObservableCollection<Inimene> _inimesed;

        public ObservableCollection<Inimene> Inimesed
        {
            get { return _inimesed; }
        }

        //Et vältida mingeid nullReferenceExeptioneid, tuleb constructoris see asi juba ära initsialiseerida
        public MainWindowVM()
        {
            _inimesed = new ObservableCollection<Inimene>();
        }

        public void LoadData()
        {
            _inimesed.Add(new Inimene("Peeter", "Pakiraam", 175));
            _inimesed.Add(new Inimene("Ants", "Pakiraam", 165));
        }

        public void LisaInimene(Inimene inimene)
        {
            _inimesed.Add(inimene);
        }
    }
}
