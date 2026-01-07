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
    }
}