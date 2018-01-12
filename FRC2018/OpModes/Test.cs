using FRC2018.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRC2018.OpModes
{
    public class Test : IOpMode
    {
        #region Singleton code
        /*
         *  This code ensures that only one instance of the autonomous class is instantiated globally.
         *  If the environment is multithreaded, once a thread accesses the Auto instance,
         *  that thread will lock the object to prevent other threads from accessing it.
         *  More information can be found here: https://msdn.microsoft.com/en-us/library/ff650316.aspx
         */
        private static volatile Test instance;
        private static object syncRoot = new Object();

        private Test() { }

        public static Test Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Test();
                    }
                }

                return instance;
            }
        }
        #endregion

        public void Init()
        {
            throw new NotImplementedException();
        }

        public void Loop()
        {
            throw new NotImplementedException();
        }
    }
}
