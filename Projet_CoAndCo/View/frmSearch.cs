using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_CoAndCo
{
    public partial class frmSearch : frmMenu
    {
        const int PANELTRI_HEIGHT_MIN = 90;
        const int PANELTRI_HEIGHT_MAX = 350;

        public frmSearch()
        {
            InitializeComponent();
            afficheAlpha();
            afficheYear();
            panelTri.Height = PANELTRI_HEIGHT_MIN;
        }


        private void afficheAlpha()
        {
            List<Button> btns = new List<Button>();
            string buttonsLabel = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int posX = 0; int posY = 0; // start location
            int x = posX; int y = posY;
            for (int i = 0; i < buttonsLabel.Length; i++)
            {
                Button btn = new Button();
                btn.Text = System.Convert.ToString(buttonsLabel[i]); // print char on button
                btn.Height = btn.Width = 24;  // button size
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = Color.Turquoise;
                btn.BackColor = Color.DarkGray;
                if (i == 10)
                {
                    x = posX; y = y + 25;
                }
                btn.Location = new Point(x, y);
                x = x + 25;
                btns.Add(btn);
            }
            pnlAlpha.Controls.AddRange(btns.ToArray());

        }

        private void afficheYear()
        {
            List<Button> btns = new List<Button>();
            List<String> annees = new List<String>();
            for (int i = 1920; i < DateTime.Now.Year; i += 10)
            {
                annees.Add(Convert.ToString(i) + "'s");
            }
            int posX = 0; int posY = 0; // start location
            int x = posX; int y = posY;
            for (int i = 0; i < annees.Count; i++)
            {
                Button btn = new Button();

                btn.Text = System.Convert.ToString(annees[i]);
                btn.Width = 50;
                btn.Height = 25;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = Color.Turquoise;
                btn.BackColor = Color.DarkGray;
                if (x > 500 && y == 0)
                {
                    x = posX; y = y + 25;
                }
                btn.Location = new Point(x, y);
                x = x + 50;
                btns.Add(btn);
            }
            pnlYear.Controls.AddRange(btns.ToArray());
        }


        private void radAlpha_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("ok");
            pnlAlpha.Visible = radAlpha.Checked;
        }

        private void radYears_CheckedChanged(object sender, EventArgs e)
        {
            pnlYear.Visible = radYears.Checked;
        }

        private void ckbMovie_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            Form x = new Form(); x.Show();
        }

        private void ckbMovie_CheckedChanged_1(object sender, EventArgs e)
        {
            ShowFormMovie();
        }

        private void ShowFormMovie()
        {
            Form FrmMovie = new frmMovie();
            FrmMovie.ShowDialog(this);
        }
        private void ShowFormBook()
        {
            Form FrmBook = new frmBook();
            FrmBook.ShowDialog(this);
        }

        private void ckbBook_CheckedChanged(object sender, EventArgs e)
        {
            ShowFormBook();
        }

        private void frmSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Panel Tri Accordion
        // -------------------
        private void btnMaxTri_Click(object sender, EventArgs e)
        {
            panelTri.Height = PANELTRI_HEIGHT_MAX;
            btnMaxTri.Visible = false;
        }

        private void btnMinTri_Click(object sender, EventArgs e)
        {
            panelTri.Height = PANELTRI_HEIGHT_MIN;
            btnMaxTri.Visible = true;

        }

        private void btnSearchTri_Click(object sender, EventArgs e)
        {
            panelTri.Height = PANELTRI_HEIGHT_MIN;
            btnMaxTri.Visible = true;
        }

        private void btnMaxTri_MouseHover(object sender, EventArgs e)
        {
            btnMaxTri.BackgroundImage = imageList_Icon_64.Images[0];
        }

        private void btnMaxTri_MouseLeave(object sender, EventArgs e)
        {
            btnMaxTri.BackgroundImage = imageList_Icon_64.Images[1];
        }

        private void btnMinTri_MouseHover(object sender, EventArgs e)
        {
            btnMinTri.BackgroundImage = imageList_Icon_64.Images[2];
        }

        private void btnMinTri_MouseLeave(object sender, EventArgs e)
        {
            btnMinTri.BackgroundImage = imageList_Icon_64.Images[3];
        }

        private void trackBar_Min_Scroll(object sender, EventArgs e)
        {
            trackBar_Control(false);
        }

        private void trackBar_Max_Scroll(object sender, EventArgs e)
        {
            trackBar_Control(true);
        }

        private void trackBar_Control(Boolean Up)
        {
            int maxValue = trackBar_Max.Value;
            int minValue = trackBar_Min.Value;
            if (maxValue < minValue)
            {
                if (Up)
                {
                    trackBar_Min.Value = trackBar_Max.Value;
                }
                else
                {
                    trackBar_Max.Value = trackBar_Min.Value;
                }
            }
            txtMin.Text = trackBar_Min.Value.ToString();
            txtMax.Text = trackBar_Max.Value.ToString();
        }

        private void txtMin_Validating(object sender, CancelEventArgs e)
        {
            int minValue = Convert.ToInt32(txtMin.Text);
            if (minValue<trackBar_Min.Minimum || minValue > trackBar_Max.Maximum)
            {
                e.Cancel = true;
                txtMin.Text = trackBar_Min.Value.ToString();
            }
            else
            {
                trackBar_Min.Value = minValue;
            }
            trackBar_Control(false);
        }

        private void txtMax_Validating(object sender, CancelEventArgs e)
        {
            int maxValue = Convert.ToInt32(txtMax.Text);
            if (maxValue < trackBar_Max.Minimum || maxValue > trackBar_Max.Maximum)
            {
                e.Cancel = true;
                txtMax.Text = trackBar_Max.Value.ToString();
            }
            else
            {
                trackBar_Max.Value = maxValue;
            }
            trackBar_Control(true);
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {         
            this.nationalityTableAdapter.Fill(this.dataSet1.Nationality);
            this.genreTableAdapter.Fill(this.dataSet1.Genre);
            this.type_MediaTableAdapter.Fill(this.dataSet1.Type_Media);

            getItemGenre();
            getItemNationality();
            getBtnType_Media();
            int yearMax = (int)this.mediaTableAdapter.maxYear();
            trackBar_Max.Value = yearMax;
            trackBar_Max.Maximum = yearMax;
            trackBar_Min.Maximum = yearMax;
            txtMax.Text = yearMax.ToString();
            int yearMin = (int)this.mediaTableAdapter.minYear();
            trackBar_Min.Value = yearMin;
            trackBar_Min.Minimum = yearMin;
            trackBar_Max.Minimum = yearMin;
            txtMin.Text = yearMin.ToString();
        }

        private void getItemGenre()
        {
            for (int i = 0; i < dataSet1.Genre.Rows.Count; i++)
            {
                chkLstBoxGenre.Items.Add(dataSet1.Genre.Rows[i][1].ToString());
            }
        }

        private void getItemNationality()
        {
            for (int i = 0; i < dataSet1.Nationality.Rows.Count; i++)
            {
                chkLstBoxNationality.Items.Add(dataSet1.Nationality.Rows[i][1].ToString());
            }
        }

        private void getBtnType_Media()
        {
            for (int i = 0; i < dataSet1.Type_Media.Rows.Count; i++)
            {
                CheckBox chkBoxMedia = new CheckBox();
                this.panelMedia.Controls.Add(chkBoxMedia);
                chkBoxMedia.Appearance = Appearance.Button;
                chkBoxMedia.Text = dataSet1.Type_Media.Rows[i][1].ToString();
                chkBoxMedia.BackColor = Color.DarkGray;
                chkBoxMedia.FlatAppearance.BorderSize = 0;
                chkBoxMedia.FlatAppearance.CheckedBackColor = Color.Turquoise;
                chkBoxMedia.FlatAppearance.MouseOverBackColor = Color.Turquoise;
                chkBoxMedia.FlatStyle = FlatStyle.Flat;
                chkBoxMedia.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                chkBoxMedia.Location = new System.Drawing.Point(10 + 110 * i, 19);
                chkBoxMedia.Text = dataSet1.Type_Media.Rows[i][1].ToString();
                string chkName = "chkBox" + chkBoxMedia.Text;
                chkBoxMedia.Size = new Size(90, 23);
                chkBoxMedia.TabIndex = i + 1;
                chkBoxMedia.UseVisualStyleBackColor = false;
                chkBoxMedia.Name = chkName;
            }
            
        }
    }
}
