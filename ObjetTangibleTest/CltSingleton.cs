using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetTangibleTest
{
    public class CltSingleton
    {
        public TUIO.TuioClient clt;

        private static CltSingleton instance;

        private CltSingleton()
        {
            clt = new TUIO.TuioClient(3337);
            clt.connect();
        }

        public static CltSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CltSingleton();
                }
                return instance;
            }
        }
    }
}
