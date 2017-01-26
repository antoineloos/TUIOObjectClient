using ObjetTangibleTest;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApplication1
{
    public class MainWindowVM : BindableBase
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { SetProperty(ref id, value); }
        }

        private float angle;
        public float Angle
        {
            get { return angle; }
            set { SetProperty(ref angle, value); }
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

        public MainWindow MainW { get; set; }

        public MainWindowVM(MainWindow mainW)
        {
            MainW = mainW;
            var MainGrid = MainW.mainGr;
            Thread t = new Thread(() =>
            {
                while (true)
                {
                    var lst = CltSingleton.Instance.clt.getTuioObjects();

                    if (lst != null && lst.Count > 0)
                    {
                        var tmp = lst.FirstOrDefault();
                        Id = tmp.SymbolID;
                        System.Windows.Application.Current.Dispatcher.InvokeAsync(new Action(() =>
                        {
                            // = tmp.SymbolID;
                            Canvas.SetLeft(MainGrid, tmp.Position.X * 1920 - 100);
                            Canvas.SetTop(MainGrid, tmp.Position.Y * 1080 - 100);
                            MainW.transf.Angle = tmp.AngleDegrees;
                        }), System.Windows.Threading.DispatcherPriority.Render).Wait();

                        //foreach (TUIO.TuioObject elem in lst)
                        //{

                        //}



                    }


                }
            });
            t.Start();

            //Task.Factory.StartNew(new Action(() =>
            //{

            //    while (true)
            //    {
            //        var lst = CltSingleton.Instance.clt.getTuioObjects();

            //        if (lst != null && lst.Count > 0)
            //        {

            //            var tmp = lst.FirstOrDefault();
            //            //foreach (TUIO.TuioObject elem in lst)
            //            //{
            //                Id = tmp.SymbolID;
            //                PosX = tmp.Position.X * 1920-100;
            //                PosY = tmp.Position.Y * 1080-100;
            //            Angle = tmp.AngleDegrees;
            //            //}
                            
                        

            //        }


            //    }
            //}));
        }
    }
}
