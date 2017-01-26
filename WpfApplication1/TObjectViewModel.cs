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

        private float posX;
        public float PosX
        {
            get { return posX; }
            set { SetProperty(ref posX, value); }
        }



        private float posY;
        public float PosY
        {
            get { return posY; }
            set { SetProperty(ref posY, value); }
        }
        public TObjectViewModel(int id, float x, float y)
        {
            Id = id;
            PosX = x;
            PosY = y;
        }

        public void Update(int id, float x, float y)
        {
            Id = id;
            PosX = x;
            PosY = y;
        }
    }
}
