using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindow
{
    public partial class Form1 : Form
    {
        private Scene sceneNumber;              // Scene sceneNumber = new Scene(1, this.scenePictureBox);

        public Form1()                                               //建構式
        {                                                            //建構式
            InitializeComponent();                                   //建構式
            this.sceneNumber = new Scene(1, this.scenePictureBox, this.yesButton, this.noButton);    //建構式   //new 位置 問題??
        }

        private void makeDecision(int decision)
        {
            if (sceneNumber.Id == 1) { sceneNumber.ChangeTo(2); }
            else if (sceneNumber.Id == 2)
                if (decision == 1) { sceneNumber.ChangeTo(8); }
                else { sceneNumber.ChangeTo(3); }
            else if (sceneNumber.Id == 3)
                if (decision == 1) { sceneNumber.ChangeTo(4); }
                else { sceneNumber.ChangeTo(5); }
            else if (sceneNumber.Id == 4) { sceneNumber.ChangeTo(1); }
            else if (sceneNumber.Id == 5) { sceneNumber.ChangeTo(1); }
            else if (sceneNumber.Id == 6) { sceneNumber.ChangeTo(1); }
            else if (sceneNumber.Id == 7) { sceneNumber.ChangeTo(1); }
            else if (sceneNumber.Id == 8)
                if (decision == 1) { sceneNumber.ChangeTo(9); }
                else { sceneNumber.ChangeTo(10); }
            else if (sceneNumber.Id == 9) { sceneNumber.ChangeTo(3); }
            else { sceneNumber.ChangeTo(1); }
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            makeDecision(1);
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            makeDecision(2);
        }
    }
}