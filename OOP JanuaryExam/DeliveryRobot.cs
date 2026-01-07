using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_JanuaryExam
{
    internal class DeliveryRobot:Robot
    {
        public DeliveryMode ModeOfDelivery { get; set; }
        public double MaxLoadKG { get; set; }

        public override string DescribeRobot()
        {
            string output = $"I am a delivery robot.\nI specialise in Delivery by {ModeOfDelivery}.\nThe Maximum Load I can carry is {MaxLoadKG}kg.\n\n{this.ToString()}";
            return output;
        }
    }
}
