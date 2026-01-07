using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP_JanuaryExam
{
    //public repo can be found at https://github.com/KStaunton-ATU/OOP-JanuaryExam
    //Collaborator is keith.mcmanus@atu.ie
    public enum HouseHoldSkill
    {
        Cooking,
        Cleaning,
        Laundry,
        Gardening,
        ChildCare
    }

    public enum DeliveryMode
    {
        Walking,
        Driving,
        Flying
    }


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void createRobots()
        {
            //3 HouseHold, 3 Delivery (g)
            HouseholdRobot h1 = new HouseholdRobot()
            {
                RobotName = "HouseBot"
            };
            HouseholdRobot h2 = new HouseholdRobot()
            {
                RobotName = "GardenMate"
            };
            HouseholdRobot h3 = new HouseholdRobot()
            {
                RobotName = "Housemate 3000"
            };

            DeliveryRobot d1 = new DeliveryRobot()
            {
                RobotName = "DeliverBot"
            };
            DeliveryRobot d2 = new DeliveryRobot()
            {
                RobotName = "Flybot"
            };
            DeliveryRobot d3 = new DeliveryRobot()
            {
                RobotName = "Driver"
            };

            //adding skills (h)
            h2.DownloadSkill(HouseHoldSkill.Gardening);
            h3.DownloadSkill(HouseHoldSkill.Cooking);
            h3.DownloadSkill(HouseHoldSkill.Laundry);

        }
    }
}