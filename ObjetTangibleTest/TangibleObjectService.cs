using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetTangibleTest
{
    public class TangibleObjectService : INotifyPropertyChanged
    {



        #region INotifyPropertyChanged impl
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }


        private ObservableCollection<TUIO.TuioObject> tangibleObjectLst;

        public ObservableCollection<TUIO.TuioObject> TangibleObjectLst
        {
            get { return new ObservableCollection<TUIO.TuioObject>( CltSingleton.Instance.clt.getTuioObjects()); }
            private set
            {
                tangibleObjectLst = value;
                NotifyPropertyChanged(nameof(TangibleObjectLst));
            }
        }

        private ObservableCollection<TUIO.TuioCursor> tangibleCursorLst;

        public ObservableCollection<TUIO.TuioCursor> TangibleCursorLst
        {
            get { return new ObservableCollection<TUIO.TuioCursor>(CltSingleton.Instance.clt.getTuioCursors()); }
            private set
            {
                tangibleCursorLst = value;
                NotifyPropertyChanged(nameof(TangibleCursorLst));
            }
        }
        #endregion

        public TangibleObjectService()
        {
            
        }
    }
}
