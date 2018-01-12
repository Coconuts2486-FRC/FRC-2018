using System;
using FRC2018.Interface;

namespace FRC2018.OpModes
{
    public class Auto : IOpMode
    {
        #region Singleton code
        /*
         *  This code ensures that only one instance of the autonomous class is instantiated globally.
         *  If the environment is multithreaded, once a thread accesses the Auto instance,
         *  that thread will lock the object to prevent other threads from accessing it.
         *  More information can be found here: https://msdn.microsoft.com/en-us/library/ff650316.aspx
         */
        private static volatile Auto instance;
        private static object syncRoot = new Object();

        private Auto() { }

        public static Auto Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Auto();
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