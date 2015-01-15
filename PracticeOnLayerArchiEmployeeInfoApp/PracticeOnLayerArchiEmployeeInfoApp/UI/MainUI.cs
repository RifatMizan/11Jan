using System.Windows.Forms;

namespace PracticeOnLayerArchiEmployeeInfoApp.UI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void addDesignationButton_Click(object sender, System.EventArgs e)
        {
            DesignationUI aDesignationUi=new DesignationUI();
            aDesignationUi.Show();
        }
    }
}
