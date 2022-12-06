using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TongLeThang_19CT2_PuzzleGame
{
    public partial class frmThang : Form
    {
        int inNullSliceIndex, inmoves = 0;
        List<Bitmap> lstOriginalPictureList = new List<Bitmap>();
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
        int count = 300;
        string[] arr = new string[0];
        public frmThang()
        {
            InitializeComponent();
            gbOriginal.BackgroundImage = Properties.Resources.nganha;
            lstOriginalPictureList.AddRange(new Bitmap[] { Properties.Resources._1_1, Properties.Resources._1_2, Properties.Resources._1_3, Properties.Resources._1_4, Properties.Resources._1_5, Properties.Resources._1_6, Properties.Resources._1_7, Properties.Resources._1_8, Properties.Resources._1_9, Properties.Resources._null });

            lblMovesMade.Text += inmoves;
            lblTime.Text = count.ToString();
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
                List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 });
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
            if (lblTime.Text != "300")
            {
                YesOrNo = MessageBox.Show("Bạn có muốn chơi lại ?", "Game xếp hình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (YesOrNo == DialogResult.Yes || lblTime.Text == count.ToString())
            {
                Shuffle();
                count = 300;
                timer1.Stop();
                timer.Reset();
                lblTime.Text = count.ToString();
                txtName.ReadOnly = false;
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
            if(txtName.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên của bạn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                arr = new string[0];
                String content = File.ReadAllText("xephang.txt");
                string[] lines = content.Split(
                         new string[] { "\r\n", "\r", "\n" },
                         StringSplitOptions.None
                         );

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] arrTmp = lines[i].Split(',');
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.GetUpperBound(0)] = arrTmp[0];
                }
                Boolean key = true;
                foreach (string line in arr)
                {
                    if (txtName.Text.ToString().Equals(line))
                    {
                        timer1.Enabled = false;
                        timer1.Stop();
                        MessageBox.Show("Tên người chơi đã tồn tại ! " + "\n Vui lòng nhập tên khác !", "Thông báo");
                        key = false;
                        Shuffle();
                        break;
                    }
                }

                if (key == true)
                {
                    timer1.Start();
                    btnPause.Enabled = true;
                    txtName.Enabled = true;

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
                                timer1.Stop();
                                (gbPuzzleBox.Controls[8] as PictureBox).Image = lstOriginalPictureList[8];
                                String filename = "xephang.txt";

                                int time_ht = 300 - int.Parse(lblTime.Text.ToString());
                                File.AppendAllText(filename, "\n" + txtName.Text + "," + time_ht);
                                MessageBox.Show("Chúc mừng " + txtName.Text + "...\nĐã xếp hình thành công !\nThời gian hoàn thành: " + time_ht + "s" + "\nSố lần xếp: " + inmoves, "Game xếp hình"); ;
                                inmoves = 0;
                                txtName.ReadOnly = false;
                                lblMovesMade.Text = "Số lần xếp : 0";
                                lblTime.Text = "300";
                                Shuffle();
                            }

                        }
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

        private void btnBXH_Click(object sender, EventArgs e)
        {
            var bxh = new frmBXH();
            bxh.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
      
            count--;
            lblTime.Text = count.ToString();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            if (count <= 0)
            {
                timer1.Stop();
                lblMovesMade.Text = "Số lần xếp : 0";
                lblTime.Text = "300";
                inmoves = 0;
                btnPause.Enabled = false;
                MessageBox.Show("Hết thời gian\nBạn có muốn thử lại", "Game xếp hình");
                count = 300;
                Shuffle();
            }
            /*    timer1.Tick += new EventHandler(SwitchPictureBox);*/
        }



        private void PauseOrResume(object sender, EventArgs e)
        {
            if (btnPause.Text == "Pause")
            {
                timer1.Stop();
                gbPuzzleBox.Visible = false;
                btnPause.Text = "Resume";
            }
            else
            {
                timer1.Start();
                gbPuzzleBox.Visible = true;
                btnPause.Text = "Pause";
            }
        }
    }
}
