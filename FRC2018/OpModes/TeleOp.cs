using FRC2018.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRC2018.OpModes
{
    public class TeleOp : IOpMode
    {
        #region Singleton code
        /*
         *  This code ensures that only one instance of the teleop class is instantiated globally.
         *  If the environment is multithreaded, once a thread accesses the TeleOp instance,
         *  that thread will lock the object to prevent other threads from accessing it.
         *  More information can be found here: https://msdn.microsoft.com/en-us/library/ff650316.aspx
         */
        private static volatile TeleOp instance;
        private static object syncRoot = new Object();

        private TeleOp() { }

        public static TeleOp Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new TeleOp();
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
