using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_JanuaryExam
{
    internal class HouseholdRobot: Robot
    {
        private List<HouseHoldSkill> Skills;

        public override string DescribeRobot()
        {
            string output = $"I am a household robot.\nI can help with chores around the house.\n\nHousehold Robot Skills:\n{this.Skills.ToString()}\n\n{this.ToString()}";
            return output;
        }
    }
}
