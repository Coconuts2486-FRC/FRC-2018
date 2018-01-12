using FRC2018.OpModes;
using WPILib;
using WPILib.SmartDashboard;

namespace FRC2018
{
    public class FRC2018 : IterativeRobot
    {
        public override void AutonomousInit() => Auto.Instance.Init();
        public override void AutonomousPeriodic() => Auto.Instance.Loop();

        public override void TeleopInit() => TeleOp.Instance.Init();
        public override void TeleopPeriodic() => TeleOp.Instance.Loop();

        public override void TestInit() => Test.Instance.Init();
        public override void TestPeriodic() => Test.Instance.Loop();

        public override void DisabledInit() => Disabled.Instance.Init();
        public override void DisabledPeriodic() => Disabled.Instance.Loop();
    }
}
