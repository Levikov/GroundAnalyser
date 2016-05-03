using CCWin;

namespace GroundAnalyser
{
    public partial class Form_Report : Skin_DevExpress
    {
        public Form_Report()
        {
            InitializeComponent();
        }

        private void Form_Report_Load(object sender, System.EventArgs e)
        {
            dgv_RepErrDetail.DataSource = GlobalVariable.dataErrDetail;
            dgv_RepErrDetail.Columns[0].Width = 60;
            dgv_RepErrDetail.Columns[1].Width = 80;
            dgv_RepErrDetail.Columns[2].Width = 100;
            dgv_RepErrSum.DataSource = GlobalVariable.dataErrSum;
            dgv_RepErrSum.Columns[0].Width = 60;
            dgv_RepErrSum.Columns[1].Width = 80;
            dgv_RepErrSum.Columns[2].Width = 100;
        }
    }
}
