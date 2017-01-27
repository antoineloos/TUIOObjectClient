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
        private int id;
        public int Id
        {
            get { return id; }
            set { SetProperty(ref id, value); }
        }

     
        public TObjectViewModel(int id)
        {
            Id = id;
          
        }

        public void Update(int id)
        {
            Id = id;
           
        }
    }
}
