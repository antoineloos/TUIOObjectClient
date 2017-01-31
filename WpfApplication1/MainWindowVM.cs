using Newtonsoft.Json;
using ObjetTangibleTest;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
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

        private ObservableCollection<Capsule> lstCapsule;
        public ObservableCollection<Capsule> LstCapsule
        {
            get { return lstCapsule; }
            set { SetProperty(ref lstCapsule, value); }
        }


        private int nbTotal;
        public int NbTotal
        {
            get { return nbTotal; }
            set { SetProperty(ref nbTotal, value); }
        }

        public MainWindowVM(MainWindow mainW)
        {
            MainW = mainW;
            var MainCanvas = MainW.MainCanvas;
            LstTObject = new ObservableCollection<TObject>();
            LstCapsule = new ObservableCollection<Capsule>();

            //LstCapsule.Add(new Capsule() { Contenance = "110ml", Couleur = (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffCE0058")), Intensite = "8/10", Nom = "Lungo Forte", Prix = "0,29€", Type = "Lungo" , IdObj = 1} );
            //LstCapsule.Add(new Capsule() { Contenance = "110ml", Couleur = (SolidColorBrush)(new BrushConverter().ConvertFrom("#ff0085CA")), Intensite = "4/10", Nom = "Lungo", Prix = "0,29€", Type = "Lungo" , IdObj = 2});
            //LstCapsule.Add(new Capsule() { Contenance = "110ml", Couleur = (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffFFCE04")), Intensite = "5/10", Nom = "Expresso", Prix = "0,29€", Type = "Expresso", IdObj = 3 });

            //WriteFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)), "Capsules.json", LstCapsule);

            LstCapsule = new ObservableCollection<Capsule>(ImportFile(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Capsules.json")));

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
                    if (lst.Count > 0)
                    {
                        foreach (TUIO.TuioObject obj in lst)
                        {
                            if (LstTObject.Where(o => o.VM.Id == obj.SymbolID).Count() > 0)
                            {
                                var tmp = LstTObject.Where(o => o.VM.Id == obj.SymbolID).First();

                                System.Windows.Application.Current.Dispatcher.InvokeAsync(new Action(() =>
                                {
                                    tmp.VM.Id = obj.SymbolID;
                                    Canvas.SetLeft(tmp, obj.Position.X * 1920 - 125);
                                    Canvas.SetTop(tmp, obj.Position.Y * 1080 - 125);
                                    tmp.transf.Angle = obj.AngleDegrees;
                                }), System.Windows.Threading.DispatcherPriority.Render).Wait();

                            }
                            else
                            {

                                System.Windows.Application.Current.Dispatcher.InvokeAsync(new Action(() =>
                                {
                                    var tmp = new TObject(obj.SymbolID);
                                    Canvas.SetLeft(tmp, obj.Position.X * 1920 - 125);
                                    Canvas.SetTop(tmp, obj.Position.Y * 1080 - 125);
                                    tmp.transf.Angle = obj.AngleDegrees;
                                    if (LstCapsule.Any(c => c.IdObj == tmp.VM.Id)) tmp.VM.Capsule = LstCapsule.First(c => c.IdObj == tmp.VM.Id);
                                    LstTObject.Add(tmp);
                                    MainCanvas.Children.Add(tmp);

                                }), System.Windows.Threading.DispatcherPriority.Render).Wait();

                            }

                        }



                        foreach (TObject elem in LstTObject)
                        {
                            if (!lst.Any(o => o.SymbolID == elem.VM.Id))
                            {
                                System.Windows.Application.Current.Dispatcher.InvokeAsync(new Action(() =>
                                {
                                    MainCanvas.Children.Remove(elem);
                                    LstTObject.Remove(elem);
                                }));
                            }

                        }





                    }

                    NbTotal = 0;
                    foreach (TObject elem in LstTObject)
                    {
                        NbTotal += elem.VM.NbProduit;

                    }
                }

            });
            t.Start();


        }



        private void WriteFile(string root, string file, dynamic lines)
        {
            var path = System.IO.Path.Combine(root, $"{file}.json");
            var info = new FileInfo(path);
            if (!info.Directory.Exists)
            {
                info.Directory.Create();
            }

            File.WriteAllText(path, JsonConvert.SerializeObject(lines, Formatting.Indented));
        }

        private List<Capsule> ImportFile(string path)
        {
            if (File.Exists(path))
            {


                var content = File.ReadAllText(path);

                if (path.Contains("Capsules.json"))
                {

                    var res = JsonConvert.DeserializeObject<List<Capsule>>(content);
                    return res;

                }
            }
            return null;
        }
    }
}
