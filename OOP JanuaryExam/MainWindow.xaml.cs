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
        List<Robot> robots = new List<Robot>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //create robots and initialise global List
            createRobots();

            //display all robots in Listbox (i)
            lbxRobotList.ItemsSource = null;
            lbxRobotList.ItemsSource = robots;
        }

        public void createRobots()
        {
            //3 HouseHold, 3 Delivery (g)
            HouseholdRobot h1 = new HouseholdRobot()
            {
                RobotName = "HouseBot",
                RobotType = RobotType.HouseholdRobot
            };
            HouseholdRobot h2 = new HouseholdRobot()
            {
                RobotName = "GardenMate",
                RobotType = RobotType.HouseholdRobot
            };
            HouseholdRobot h3 = new HouseholdRobot()
            {
                RobotName = "Housemate 3000",
                RobotType = RobotType.HouseholdRobot
            };

            DeliveryRobot d1 = new DeliveryRobot()
            {
                RobotName = "DeliverBot",
                RobotType = RobotType.DeliveryRobot
            };
            DeliveryRobot d2 = new DeliveryRobot()
            {
                RobotName = "Flybot",
                RobotType = RobotType.DeliveryRobot
            };
            DeliveryRobot d3 = new DeliveryRobot()
            {
                RobotName = "Driver",
                RobotType = RobotType.DeliveryRobot
            };

            //adding skills (h)
            h2.DownloadSkill(HouseHoldSkill.Gardening);
            h3.DownloadSkill(HouseHoldSkill.Cooking);
            h3.DownloadSkill(HouseHoldSkill.Laundry);

            //add to global List collection
            robots.Add(h1);
            robots.Add(h2);
            robots.Add(h3);
            robots.Add(d1);
            robots.Add(d2);
            robots.Add(d3);
        }

        private void lbxRobotList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //get selected robot
            if (lbxRobotList.SelectedItem != null)
            {
                Robot r = lbxRobotList.SelectedItem as Robot;
                //display description in textbox (i)
                tbxRobotDetails.Text = r.DescribeRobot();
            }
        }

        private void btnCharge_Click(object sender, RoutedEventArgs e)
        {
            //charge robot to full capacity (j)
            //get selected robot
            if (lbxRobotList.SelectedItem != null)
            {
                Robot r = lbxRobotList.SelectedItem as Robot;

                if(r.CurrentPowerKWH == r.PowerCapactyKWH)
                {
                    MessageBox.Show("Robot already fully charged.");
                }
                else
                {
                    //set charge to full capacity
                    r.CurrentPowerKWH = r.PowerCapactyKWH;
                    MessageBox.Show("Robot fully charged. Time taken: 3 hours, 25 minutes");
                }
            }
        }

        private void radBtnAllRobots_Checked(object sender, RoutedEventArgs e)
        {
            //set source to global List (k)
            lbxRobotList.ItemsSource = null;
            lbxRobotList.ItemsSource = robots;
        }

        private void radBtnHousehold_Checked(object sender, RoutedEventArgs e)
        {
            //create filtered List from global List (k)
            List<Robot> filteredList = new List<Robot>();

            for (int i = 0; i < robots.Count; i++)
            {
                if(robots[i].RobotType == RobotType.HouseholdRobot)
                {
                    filteredList.Add(robots[i]);
                }
            }

            //then set as source
            lbxRobotList.ItemsSource = null;
            lbxRobotList.ItemsSource = filteredList;
        }

        private void radBtnDelivery_Checked(object sender, RoutedEventArgs e)
        {
            //create filtered List from global List (k)
            List<Robot> filteredList = new List<Robot>();

            for (int i = 0; i < robots.Count; i++)
            {
                if (robots[i].RobotType == RobotType.DeliveryRobot)
                {
                    filteredList.Add(robots[i]);
                }
            }

            //then set as source
            lbxRobotList.ItemsSource = null;
            lbxRobotList.ItemsSource = filteredList;
        }
    }
}