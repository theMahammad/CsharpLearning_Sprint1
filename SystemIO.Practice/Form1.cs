using System.IO;

namespace SystemIO.Practice
{
    public partial class Form1 : Form
    {
        
        List<Staff> staffList;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(DataOperations.saveLocation))
            {
                Directory.Delete(DataOperations.saveLocation, true);
            }
            
            Directory.CreateDirectory(DataOperations.saveLocation);
        }

        private void btnCallStaff_Click(object sender, EventArgs e)
        {
            staffList = DataOperations.CallStaffs(15);
            lstStaff.DataSource = staffList;
        }
            
        private void lstStaff_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void lstStaff_DoubleClick(object sender, EventArgs e)
        {
            Staff selectedStaff = lstStaff.SelectedItem as Staff;
            MessageBox.Show($"{selectedStaff.Name}\n" +
                $"{selectedStaff.Surname}\n" +
                $"{selectedStaff.Country}\n" +
                $"{selectedStaff.Email}");
        }

        private void btnSaveStaff_Click(object sender, EventArgs e)
        {
            
            DataOperations.SaveStaff(staffList);
        }
        
        
    }
}