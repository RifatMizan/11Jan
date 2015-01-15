using System;
using System.Windows.Forms;
using PracticeOnLayerArchiEmployeeInfoApp.BLL;
using PracticeOnLayerArchiEmployeeInfoApp.DAL.DAO;

namespace PracticeOnLayerArchiEmployeeInfoApp.UI
{
    public partial class DesignationUI : Form
    {
        public DesignationUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveDesignationButton_Click(object sender, EventArgs e)
        {
            Designation aDesignation=new Designation();
            aDesignation.Code = codeTextBox.Text;
            aDesignation.Title = titleTextBox.Text;
            DesignationManager aDesignationManager=new DesignationManager();
            aDesignationManager.Save(aDesignation);
            MessageBox.Show("Updated");
        }
    }
}
