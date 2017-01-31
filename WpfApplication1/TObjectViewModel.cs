using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class TObjectViewModel : BindableBase
    {


        private Capsule capsule;
        public Capsule Capsule
        {
            get { return capsule; }
            set { SetProperty(ref capsule, value); }
        }

        private Boolean isMenuAchatVisible;
        public Boolean IsMenuAchatVisible
        {
            get { return isMenuAchatVisible; }
            set { SetProperty(ref isMenuAchatVisible, value); }
        }

        public DelegateCommand AddCommand => new DelegateCommand(Add);
        public DelegateCommand PlusCommand => new DelegateCommand(Plus);

        private void Plus()
        {
            NbProduit++;
        }

        private int nbProduit;
        public int NbProduit
        {
            get { return nbProduit; }
            set { SetProperty(ref nbProduit, value); }
        }

        public DelegateCommand MoinCommand => new DelegateCommand(Moin);

        private void Moin()
        {
            if (NbProduit > 0) NbProduit--;
        }

        private void Add()
        {
            IsMenuAchatVisible = true;
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { SetProperty(ref id, value); }
        }


        public TObjectViewModel(int id)
        {
            Id = id;
            Capsule = new Capsule();
        }

        public void Update(int id)
        {
            Id = id;

        }
    }
}
