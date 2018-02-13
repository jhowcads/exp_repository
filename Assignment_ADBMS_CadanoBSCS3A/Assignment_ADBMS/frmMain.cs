using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClassCollection;
namespace Assignment_ADBMS
{
    public partial class frmMain : Form
    {
        MySQLDBUtilities dbutil = new MySQLDBUtilities();

        public frmMain()
        {
            InitializeComponent();
            dbutil.OpenConnection();
            SelectQuery("SELECT * FROM tbl_Contestants ORDER BY ContestantNo ASC;");
        }

        private void frmMain_Load(object sender, EventArgs e) { }

        private int contestantNo = 1;

        private bool col1 = true;
        private bool isNextLine = true;
        private int panelY = 0;
        private int nwPanelY = 25; 
        private int x = 0;
        private int y = 0;

        private void setLocation()
        {
            
            if (col1 == true) { x = 25; col1 = false; }
            else { x = 261; col1 = true; }

            if (isNextLine == true) { panelY = nwPanelY;  y = panelY; isNextLine = false; }
            else { y = panelY; isNextLine = true; nwPanelY = panelY + 334; }
        }

        private void SelectQuery(string query)
        {
            DataTable dt = dbutil.SelectTable(query);
            foreach (DataRow r in dt.Rows)
            {
                setLocation();
                String ContNo = r["ContestantNo"].ToString();
                String ContName = r["FName"].ToString() + " " + r["LName"].ToString();
                String PicPath = r["PicturePath"].ToString();

                GenerateContestants(ContNo, ContName, PicPath, x, y);
            }
        }
        public void Click_Me(object sender,EventArgs e)
        {
            frm_Criteria fc = new frm_Criteria();
            fc.ShowDialog();
        }
        private void GenerateContestants(String ContNo, String ContName, String ContPic, int pnlX, int pnlY)
        {
            PictureBox _PicBox = new PictureBox();
            _PicBox.Name = "pbxProfile" + ContNo;
            _PicBox.Size = new Size(160, 160);
            _PicBox.Location = new Point(26, 25);
            _PicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            _PicBox.BorderStyle = BorderStyle.FixedSingle;
            _PicBox.TabStop = false;
            _PicBox.ImageLocation = @".../Images//" + ContPic;

            Label _LabelContestantNo = new Label();
            _LabelContestantNo.Size = new Size(160, 26);
            _LabelContestantNo.Location = new Point(26, 196);
            _LabelContestantNo.Name = "lblContestantNo" + ContNo;
            _LabelContestantNo.ForeColor = Color.DarkRed;
            _LabelContestantNo.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            _LabelContestantNo.Text = "Contestant No. " + ContNo;
            _LabelContestantNo.TextAlign = ContentAlignment.MiddleCenter;

            Label _LabelContName = new Label();
            _LabelContName.Size = new Size(160, 26);
            _LabelContName.Location = new Point(26, 222);
            _LabelContName.Name = "lblContName" + contestantNo;
            _LabelContName.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            _LabelContName.Text = ContName;
            _LabelContName.TextAlign = ContentAlignment.MiddleCenter;

            Button _ButtonScore = new Button();
            _ButtonScore.Size = new Size(160, 33);
            _ButtonScore.Location = new Point(26, 253);
            _ButtonScore.FlatAppearance.BorderSize = 0;
            _ButtonScore.Name = "btnScore" + contestantNo;
            _ButtonScore.Text = "SCORE";
            _ButtonScore.UseVisualStyleBackColor = true;
            _ButtonScore.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            _ButtonScore.TabIndex = contestantNo;
            _ButtonScore.Click += new System.EventHandler(Click_Me);


            Panel _Panel = new Panel();
            _Panel.Name = "pnlContestant" + contestantNo;
            _Panel.Size = new Size(215, 313);
            _Panel.BorderStyle = BorderStyle.FixedSingle;
            _Panel.Location = new Point(x, y);
            _Panel.TabIndex = 0;
            _Panel.Controls.Add(_PicBox);
            _Panel.Controls.Add(_LabelContestantNo);
            _Panel.Controls.Add(_LabelContName);
            _Panel.Controls.Add(_ButtonScore);

            this.Controls.Add(_Panel);
        }
    }
}
