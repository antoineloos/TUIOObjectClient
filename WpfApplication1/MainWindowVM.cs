using ObjetTangibleTest;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApplication1
{
    public class MainWindowVM : BindableBase
    {
     

        public MainWindow MainW { get; set; }

        public Canvas MainCanvas { get; set; }

        private ObservableCollection<TObject> lstTObject;
        public ObservableCollection<TObject> LstTObject
        {
            get { return lstTObject; }
            set { SetProperty(ref lstTObject, value); }
        }
       

        public MainWindowVM(MainWindow mainW)
        {
            MainW = mainW;
            var MainCanvas = MainW.MainCanvas;
            LstTObject = new ObservableCollection<TObject>();
            
            Thread t = new Thread(() =>
            {
                Random rd = new Random();

                    while (true)
                {
                    var lst = CltSingleton.Instance.clt.getTuioObjects();
                    
                    Debug.WriteLine(lst.Count.ToString());
                    if (lst.Count == 0)
                    {

                        System.Windows.Application.Current.Dispatcher.InvokeAsync(new Action(() =>
                        {
                            if (MainCanvas.Children.Count > 0)
                            {
                                MainCanvas.Children.RemoveAt(0);
                                LstTObject.RemoveAt(0);
                            }
                        }));

                    }
                    if ( lst.Count > 0)
                    {
                        foreach(TUIO.TuioObject obj in lst)
                        {
                            if (LstTObject.Where(o => o.VM.Id == obj.SymbolID).Count()>0)
                            {
                                var tmp = LstTObject.Where(o => o.VM.Id == obj.SymbolID).First();
                                
                                System.Windows.Application.Current.Dispatcher.InvokeAsync(new Action(() =>
                                {
                                    tmp.VM.Id = obj.SymbolID;
                                    Canvas.SetLeft(tmp, obj.Position.X * 1920 - 100);
                                    Canvas.SetTop(tmp, obj.Position.Y * 1080 - 100);
                                    tmp.transf.Angle = obj.AngleDegrees;
                                }), System.Windows.Threading.DispatcherPriority.Render).Wait();

                            }
                            else
                            {

                                System.Windows.Application.Current.Dispatcher.InvokeAsync(new Action(() =>
                                {
                                    var tmp = new TObject(obj.SymbolID);
                                    Canvas.SetLeft(tmp, obj.Position.X * 1920 - 100);
                                    Canvas.SetTop(tmp, obj.Position.Y * 1080 - 100);
                                    tmp.transf.Angle = obj.AngleDegrees;
                                    LstTObject.Add(tmp);
                                    MainCanvas.Children.Add(tmp);
                                    
                                }), System.Windows.Threading.DispatcherPriority.Render).Wait();

                            }

                        }

                        

                        foreach (TObject elem in LstTObject)
                        {
                            if ( !lst.Any(o => o.SymbolID == elem.VM.Id))
                            {
                                System.Windows.Application.Current.Dispatcher.InvokeAsync(new Action(() =>
                                {
                                    MainCanvas.Children.Remove(elem);
                                    LstTObject.Remove(elem);
                                }));
                            }

                        }





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
