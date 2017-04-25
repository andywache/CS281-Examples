using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MainWindow
{
    public class Scene
    {
        public Scene(int id, PictureBox PictureBox, Button yesButton, Button noButton)
        {
            this.Id = id;
            this.ScenePictureBox = PictureBox;
            this.YesButton = yesButton;
            this.NoButton = noButton;
        }

        public int Id;
        public PictureBox ScenePictureBox;
        public Button YesButton;
        public Button NoButton;

        public Image ChangeScene(int Id)
        {
            if (Id == 1) { return global::MainWindow.Properties.Resources._1; }
            else if (Id == 2) { return global::MainWindow.Properties.Resources._2; }
            else if (Id == 3) { return global::MainWindow.Properties.Resources._3; }
            else if (Id == 4) { return global::MainWindow.Properties.Resources._4; }
            else if (Id == 5) { return global::MainWindow.Properties.Resources._5; }
            else if (Id == 6) { return global::MainWindow.Properties.Resources._6; }
            else if (Id == 7) { return global::MainWindow.Properties.Resources._7; }
            else if (Id == 8) { return global::MainWindow.Properties.Resources._8; }
            else if (Id == 9) { return global::MainWindow.Properties.Resources._9; }
            else { return global::MainWindow.Properties.Resources._10; }
        }

        public void ChangeTo(int id)
        {
            this.Id = id;       //轉換Id
            this.ScenePictureBox.Image = this.ChangeScene(id);
            ButtonText();
        }

        private void ButtonText()
        {
            if (this.Id == 1)
            {
                YesButton.Text = "按下乾啦來了解";
                NoButton.Hide();
            }
            else if (this.Id == 4 || this.Id == 6 || this.Id == 7 || this.Id == 10)
            {
                YesButton.Text = "重新開始";
                NoButton.Hide();
            }
            else if (this.Id == 9)
            {
                YesButton.Text = "(1)";
                NoButton.Hide();
            }
            else
            {
                YesButton.Text = "(1)";
                NoButton.Text = "(2)";
                YesButton.Show();
                NoButton.Show();
            }
        }
    }
}