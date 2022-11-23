using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TongLeThang_19CT2_PuzzleGame
{
    public partial class Form1 : Form
    {
        int inNullSliceIndex, inmoves = 0;
        List<Bitmap> lstOriginalPictureList = new List<Bitmap>();
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
        private void comboImg_SelectedIndexChanged(object sender, EventArgs e)
        {
            object tmp = comboImg.Text.ToString();
            if (tmp.Equals("Dải ngân hà"))
            {
                gbOriginal.BackgroundImage = Properties.Resources.nganha;
                lstOriginalPictureList.AddRange(new Bitmap[] { Properties.Resources._1_1, Properties.Resources._1_2, Properties.Resources._1_3, Properties.Resources._1_4, Properties.Resources._1_5, Properties.Resources._1_6, Properties.Resources._1_7, Properties.Resources._1_8, Properties.Resources._1_9, Properties.Resources._null });
                Shuffle();
            }
            else if (tmp.Equals("Bãi biển"))
            {
                gbOriginal.BackgroundImage = Properties.Resources.baibien;
                lstOriginalPictureList.AddRange(new Bitmap[] { Properties.Resources._2_1, Properties.Resources._2_2, Properties.Resources._2_3, Properties.Resources._2_4, Properties.Resources._2_5, Properties.Resources._2_6, Properties.Resources._2_7, Properties.Resources._2_8, Properties.Resources._2_9, Properties.Resources._null });
                Shuffle();
            }
            else if (tmp.Equals("Ghềnh đá dĩa"))
            {
                gbOriginal.BackgroundImage = Properties.Resources.dadia;
            }
        }
        public Form1()
        {
            InitializeComponent();
            gbOriginal.BackgroundImage = Properties.Resources.nganha;
            lstOriginalPictureList.AddRange(new Bitmap[] { Properties.Resources._1_1, Properties.Resources._1_2, Properties.Resources._1_3, Properties.Resources._1_4, Properties.Resources._1_5, Properties.Resources._1_6, Properties.Resources._1_7, Properties.Resources._1_8, Properties.Resources._1_9, Properties.Resources._null });

            lblMovesMade.Text += inmoves;
            lblTimeElapsed.Text = "00:00:00";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Shuffle();
        }

        void Shuffle()
        {
            do
            {
                int j;
                List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 });//8 is not present - since it is the last slice.
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    ((PictureBox)gbPuzzleBox.Controls[i]).Image = lstOriginalPictureList[j];
                    if (j == 9) inNullSliceIndex = i;
                }
            } while (CheckWin());
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNo = new DialogResult();
            if (lblTimeElapsed.Text != "00:00:00")
            {
                YesOrNo = MessageBox.Show("Bạn có muốn chơi lại ?", "Game xếp hình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (YesOrNo == DialogResult.Yes || lblTimeElapsed.Text == "00:00:00")
            {
                Shuffle();
                timer.Reset();
                lblTimeElapsed.Text = "00:00:00";
                inmoves = 0;
                lblMovesMade.Text = "Số lần xếp: 0";
            }
        }

        private void AskPermissionBeforeQuite(object sender, FormClosingEventArgs e)
        {
            DialogResult YesOrNO = MessageBox.Show("Bạn có muốn thoát ?", "Game xếp hình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sender as Button != btnQuit && YesOrNO == DialogResult.No) e.Cancel = true;
            if (sender as Button == btnQuit && YesOrNO == DialogResult.Yes) Environment.Exit(0);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            AskPermissionBeforeQuite(sender, e as FormClosingEventArgs);
        }

        private void SwitchPictureBox(object sender, EventArgs e)
        {
            if (lblTimeElapsed.Text == "00:00:00")
                timer.Start();
            int inPictureBoxIndex = gbPuzzleBox.Controls.IndexOf(sender as Control);
            if (inNullSliceIndex != inPictureBoxIndex)
            {
                List<int> arr = new List<int>(new int[] { ((inPictureBoxIndex % 3 == 0) ? -1 : inPictureBoxIndex - 1), inPictureBoxIndex - 3, (inPictureBoxIndex % 3 == 2) ? -1 : inPictureBoxIndex + 1, inPictureBoxIndex + 3 });
                if (arr.Contains(inNullSliceIndex))
                {
                    ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Image = ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image;
                    ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image = lstOriginalPictureList[9];
                    inNullSliceIndex = inPictureBoxIndex;
                    lblMovesMade.Text = "Số lần xếp : " + (++inmoves);
                    if (CheckWin())
                    {
                        timer.Stop();
                        (gbPuzzleBox.Controls[8] as PictureBox).Image = lstOriginalPictureList[8];
                        MessageBox.Show("Chúc mừng bạn...\nĐã xếp hình thành công !\nThời gian hoàn thành: " + timer.Elapsed.ToString().Remove(8) + "\nSố lần xếp: " + inmoves, "Game xếp hình");
                        inmoves = 0;
                        lblMovesMade.Text = "Số lần xếp : 0";
                        lblTimeElapsed.Text = "00:00:00";
                        timer.Reset();
                        Shuffle();
                    }
                }
            }
        }

        bool CheckWin()
        {
            int i;
            for (i = 0; i < 8; i++)
            {
                if ((gbPuzzleBox.Controls[i] as PictureBox).Image != lstOriginalPictureList[i]) break;
            }
            if (i == 8) return true;
            else return false;
        }

        private void UpdateTimeElapsed(object sender, EventArgs e)
        {
            if (timer.Elapsed.ToString() != "00:00:00")
                lblTimeElapsed.Text = timer.Elapsed.ToString().Remove(8);
            if (timer.Elapsed.ToString() == "00:00:00")
                btnPause.Enabled = false;
            else
                btnPause.Enabled = true;
            if (timer.Elapsed.Minutes.ToString() == "5")
            {
                timer.Reset();
                lblMovesMade.Text = "Số lần xếp : 0";
                lblTimeElapsed.Text = "00:00:00";
                inmoves = 0;
                btnPause.Enabled = false;
                MessageBox.Show("Hết thời gian\nBạn có muốn thử lại", "Game xếp hình");
                Shuffle();
            }
        }

  

        private void PauseOrResume(object sender, EventArgs e)
        {
            if (btnPause.Text == "Pause")
            {
                timer.Stop();
                gbPuzzleBox.Visible = false;
                btnPause.Text = "Resume";
            }
            else
            {
                timer.Start();
                gbPuzzleBox.Visible = true;
                btnPause.Text = "Pause";
            }
        }
    }
}
