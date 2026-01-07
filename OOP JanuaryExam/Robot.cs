using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_JanuaryExam
{
    public enum RobotType
    {
        HouseholdRobot,
        DeliveryRobot
    }
    public abstract class Robot
    {
        //properties
        public string RobotName { get; set; }
        public RobotType RobotType { get; set; }
        public double PowerCapactyKWH { get; set; }
        public double CurrentPowerKWH { get; set; }

        //methods
        public double getBatteryPercentage()
        {
            return (CurrentPowerKWH / PowerCapactyKWH) * 100;
        }

        public string DisplayBatteryInformation()
        {
            return $"Battery Information:\nCpacity: {PowerCapactyKWH}\nCurrent Power: {CurrentPowerKWH}\nBattery Level: {getBatteryPercentage()}%";
        }

        public abstract string DescribeRobot();
        public override string ToString()
        {
            return $"{RobotName} - [{RobotType}]";
        }
    }
}
