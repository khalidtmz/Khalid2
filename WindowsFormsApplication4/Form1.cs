using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        int totalTeams = 16;
        int totalMatch;
        int teamNumber = 1;
        int matchNumber;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnTeam1_Click(object sender, EventArgs e)
        {
            btnTeam2.Enabled = false;
            btnSubmit.Enabled = true;
        }

        private void btnTeam2_Click(object sender, EventArgs e)
        {
            btnTeam1.Enabled = false;
            btnSubmit.Enabled = true;
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            String name = textBox0.Text.ToString();
            if (name.Length > 0)
            {
                switch (teamNumber)
                {
                    case 1: textBox1.Text = name; break;
                    case 2: textBox2.Text = name; break;
                    case 3: textBox3.Text = name; break;
                    case 4: textBox4.Text = name; break;
                    case 5: textBox5.Text = name; break;
                    case 6: textBox6.Text = name; break;
                    case 7: textBox7.Text = name; break;
                    case 8: textBox8.Text = name; break;
                    case 9: textBox9.Text = name; break;
                    case 10: textBox10.Text = name; break;
                    case 11: textBox11.Text = name; break;
                    case 12: textBox12.Text = name; break;
                    case 13: textBox13.Text = name; break;
                    case 14: textBox14.Text = name; break;
                    case 15: textBox15.Text = name; break;
                    case 16: textBox16.Text = name; break;
                }
                textBox0.Text = "";
                if (++teamNumber > totalTeams)
                {
                    textBox0.Enabled = false;
                    btnAddTeam.Enabled = false;
                    btnTeam1.Enabled = true;
                    btnTeam2.Enabled = true;
                    btnTeam1.Text = textBox1.Text;
                    btnTeam2.Text = textBox2.Text;
                    totalMatch = totalTeams - 1;
                    matchNumber = 1;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
            String name="";
            if (btnTeam1.Enabled)
                name = btnTeam1.Text.ToString();
            else if (btnTeam2.Enabled)
                name = btnTeam2.Text.ToString();
            switch (matchNumber)
            {
                case 1:
                    textBox1_2.Text = name;
                    btnTeam1.Text = textBox3.Text;
                    btnTeam2.Text = textBox4.Text;
                    break;
                case 2:
                    textBox3_4.Text = name;
                    btnTeam1.Text = textBox5.Text;
                    btnTeam2.Text = textBox6.Text;
                    break;
                case 3:
                    textBox5_6.Text = name;
                    btnTeam1.Text = textBox7.Text;
                    btnTeam2.Text = textBox8.Text;
                    break;
                case 4:
                    textBox7_8.Text = name;
                    btnTeam1.Text = textBox9.Text;
                    btnTeam2.Text = textBox10.Text;
                    break;
                case 5:
                    textBox9_10.Text = name;
                    btnTeam1.Text = textBox11.Text;
                    btnTeam2.Text = textBox12.Text;
                    break;
                case 6:
                    textBox11_12.Text = name;
                    btnTeam1.Text = textBox13.Text;
                    btnTeam2.Text = textBox14.Text;
                    break;
                case 7:
                    textBox13_14.Text = name;
                    btnTeam1.Text = textBox15.Text;
                    btnTeam2.Text = textBox16.Text;
                    break;
                case 8:
                    textBox15_16.Text = name;
                    btnTeam1.Text = textBox1_2.Text;
                    btnTeam2.Text = textBox3_4.Text;
                    break;
                case 9:
                    textBox1_4.Text = name;
                    btnTeam1.Text = textBox5_6.Text;
                    btnTeam2.Text = textBox7_8.Text;
                    break;
                case 10:
                    textBox5_8.Text = name;
                    btnTeam1.Text = textBox9_10.Text;
                    btnTeam2.Text = textBox11_12.Text;
                    break;
                case 11:
                    textBox9_12.Text = name;
                    btnTeam1.Text = textBox13_14.Text;
                    btnTeam2.Text = textBox15_16.Text;
                    break;
                case 12:
                    textBox13_16.Text = name;
                    btnTeam1.Text = textBox1_4.Text;
                    btnTeam2.Text = textBox5_8.Text;
                    break;
                case 13:
                    textBox1_8.Text = name;
                    btnTeam1.Text = textBox9_12.Text;
                    btnTeam2.Text = textBox13_16.Text;
                    break;
                case 14:
                    textBox9_16.Text = name;
                    btnTeam1.Text = textBox1_8.Text;
                    btnTeam2.Text = textBox9_16.Text;
                    break;
                case 15:
                    textBox1_16.Text = name;
                    btnTeam1.Text = "";
                    btnTeam2.Text = "";
                    break;
            }
            if (++matchNumber > totalMatch)
            {
                textBoxWinnerTeamName.Text = textBox1_16.Text;
            }
            else
            {
                btnTeam1.Enabled = true;
                btnTeam2.Enabled = true;
            }
        }
    }
}
