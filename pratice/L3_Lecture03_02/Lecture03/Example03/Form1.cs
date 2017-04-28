using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example03
{
    public partial class Form1 : Form
    {
        private Scene scenecurrent;

        public Form1()
        {
            InitializeComponent();
            scenecurrent = new Scene(1, scenePictureBox, yesButton, noButton);
        }

        private void MakeDecision(int decision)
        {
            switch (scenecurrent.Id)
            {
                case 1:
                    scenecurrent.ChangeTo(2);
                    break;

                case 2:
                    if (decision == 1) { scenecurrent.ChangeTo(8); }
                    else { scenecurrent.ChangeTo(3); }
                    break;

                case 3:
                    if (decision == 1) { scenecurrent.ChangeTo(4); }
                    else { scenecurrent.ChangeTo(5); }
                    break;

                case 4:
                    scenecurrent.ChangeTo(1);
                    break;

                case 5:
                    if (decision == 1) { scenecurrent.ChangeTo(6); }
                    else { scenecurrent.ChangeTo(7); }
                    break;

                case 6:
                    scenecurrent.ChangeTo(1);
                    break;

                case 7:
                    scenecurrent.ChangeTo(1);
                    break;

                case 8:
                    if (decision == 1) { scenecurrent.ChangeTo(9); }
                    else { scenecurrent.ChangeTo(10); }
                    break;

                case 9:
                    scenecurrent.ChangeTo(3);
                    break;

                case 10:
                    scenecurrent.ChangeTo(1);
                    break;
            }

            //if (scenecurrent.Id == 1) scenecurrent.ChangeTo(2);
            //else if (scenecurrent.Id == 2)
            //{
            //    if (decision == 1) { scenecurrent.ChangeTo(8); }
            //    else { scenecurrent.ChangeTo(3); }
            //}
            //else if (scenecurrent.Id == 3)
            //{
            //    if (decision == 1) { scenecurrent.ChangeTo(4); }
            //    else { scenecurrent.ChangeTo(5); }
            //}
            //else if (scenecurrent.Id == 4) scenecurrent.ChangeTo(1);
            //else if (scenecurrent.Id == 5)
            //{
            //    if (decision == 1) { scenecurrent.ChangeTo(6); }
            //    else { scenecurrent.ChangeTo(7); }
            //}
            //else if (scenecurrent.Id == 6) scenecurrent.ChangeTo(1);
            //else if (scenecurrent.Id == 7) scenecurrent.ChangeTo(1);
            //else if (scenecurrent.Id == 8)
            //{
            //    if (decision == 1) { scenecurrent.ChangeTo(9); }
            //    else { scenecurrent.ChangeTo(10); }
            //}
            //else if (scenecurrent.Id == 9) scenecurrent.ChangeTo(3);
            //else { scenecurrent.ChangeTo(1); }
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            MakeDecision(1);
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            MakeDecision(2);
        }
    }
}