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

        //constructor
        public HouseholdRobot()
        {
            //updating constructor (h)
            Skills = new List<HouseHoldSkill>();
            DownloadSkill(HouseHoldSkill.Cleaning);
        }

        //methods
        public override string DescribeRobot()
        {
            //prepare skills string
            string skillsString = "";
            for(int i = 0; i < Skills.Count; i++)
            {
                skillsString += $"- {Skills[i]}\n";
            }
            string output = $"I am a household robot.\nI can help with chores around the house.\n\nHousehold Robot Skills:\n{skillsString}\n\n{this.ToString()}";
            return output;
        }

        public void DownloadSkill(HouseHoldSkill skill)
        {
            Skills.Add(skill);
        }
    }
}
