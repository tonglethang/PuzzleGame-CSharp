using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TongLeThang_19CT2_PuzzleGame
{
    public partial class frmBXH : Form
    {

        int[] arr = new int[0];
        public frmBXH()
        {
            InitializeComponent();
        }
        private void frmBXH_Load(object sender, EventArgs e)
        {
            String content = File.ReadAllText("xephang.txt");
            string[] lines = content.Split(
                     new string[] { "\r\n", "\r", "\n" },
                     StringSplitOptions.None
                     );

            for(int i = 0; i < lines.Length; i++)
            {
                string[] arrTmp = lines[i].Split(',');
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.GetUpperBound(0)] = int.Parse(arrTmp[1]);
            }
            Array.Sort(arr);
            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }
            for (int i = 0; i < lines.Length; i++)
            {
                string[] arrTmp = lines[i].Split(',');
                if (arrTmp[1].Equals(arr[0].ToString()))
                {
                    lbl1.Text = arrTmp[0] + "(" + arrTmp[1] + "s)";
                }
                if (arrTmp[1].Equals(arr[1].ToString()))
                {
                    lbl2.Text = arrTmp[0] + "(" + arrTmp[1] + "s)";
                }
                if (arrTmp[1].Equals(arr[2].ToString()))
                {
                    lbl3.Text = arrTmp[0] + "(" + arrTmp[1] + "s)";
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
