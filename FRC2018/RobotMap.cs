using System;
using CTRE;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRC2018
{
    public class RobotMap
    {
        #region Singleton code
        /*
         *  This code ensures that only one instance of the autonomous class is instantiated globally.
         *  If the environment is multithreaded, once a thread accesses the Auto instance,
         *  that thread will lock the object to prevent other threads from accessing it.
         *  More information can be found here: https://msdn.microsoft.com/en-us/library/ff650316.aspx
         */
        private static volatile RobotMap instance;
        private static object syncRoot = new Object();

        private RobotMap() => Init();

        public static RobotMap Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new RobotMap();
                    }
                }

                return instance;
            }
        }
        #endregion

        #region Enums
        private enum TalonIDs
        {
            LeftDrive = 1,
            LeftSlave = 2,
            RightDrive = 3,
            RightSlave = 4
        }
        #endregion

        #region Components
        public CANTalon LeftDrive  { get; private set; }
        public CANTalon LeftSlave  { get; private set; }
        public CANTalon RightDrive { get; private set; }
        public CANTalon RightSlave { get; private set; }
        #endregion

        private void Init()
        {
            LeftDrive = new CANTalon((int)TalonIDs.LeftDrive);
            LeftSlave = new CANTalon((int)TalonIDs.LeftSlave)
            {
                MotorControlMode = WPILib.Interfaces.ControlMode.Follower
            };
            LeftSlave.Set(LeftDrive.DeviceId);

            RightDrive = new CANTalon((int)TalonIDs.RightDrive);
            RightSlave = new CANTalon((int)TalonIDs.RightSlave)
            {
                MotorControlMode = WPILib.Interfaces.ControlMode.Follower
            };
            RightSlave.Set(RightDrive.DeviceId);
        }
    }
}