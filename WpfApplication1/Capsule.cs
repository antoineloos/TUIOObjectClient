using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApplication1
{
    public class Capsule : BindableBase
    {
        private int idObj;
        public int IdObj
        {
            get { return idObj; }
            set { SetProperty(ref idObj, value); }
        }

        private SolidColorBrush couleur;
        public SolidColorBrush Couleur
        {
            get { return couleur; }
            set { SetProperty(ref couleur, value); }
        }

        private string nom;
        public string Nom
        {
            get { return nom; }
            set { SetProperty(ref nom, value); }
        }

        private string prix;
        public string Prix
        {
            get { return prix; }
            set { SetProperty(ref prix, value); }
        }

        private string type;
        public string Type
        {
            get { return type; }
            set { SetProperty(ref type, value); }
        }

        private string contenance;
        public string Contenance
        {
            get { return contenance; }
            set { SetProperty(ref contenance, value); }
        }

        private string intensite;
        public string Intensite
        {
            get { return intensite; }
            set { SetProperty(ref intensite, value); }
        }


        public Capsule()
        {
            Couleur = new SolidColorBrush(Colors.White);
        }
    }
}
