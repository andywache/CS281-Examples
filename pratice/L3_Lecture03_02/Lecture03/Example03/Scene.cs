using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Example03
{
    public class Scene
    {
        public Scene(int id, PictureBox scenePictureBox, Button yesButton, Button noButton)
        {
            this.Id = id;
            this.ScenePictureBox = scenePictureBox;
            YesButton = yesButton;
            NoButton = noButton;
            yesButton.Text = "乾啦";
            NoButton.Hide();
        }

        public int Id;
        public Button YesButton;
        public Button NoButton;
        public PictureBox ScenePictureBox;

        public Image ChangeScene(int Id)
        {
            if (Id == 1) { return global::Example03.Properties.Resources._1; }
            else if (Id == 2) { return global::Example03.Properties.Resources._2; }
            else if (Id == 3) { return global::Example03.Properties.Resources._3; }
            else if (Id == 4) { return global::Example03.Properties.Resources._4; }
            else if (Id == 5) { return global::Example03.Properties.Resources._5; }
            else if (Id == 6) { return global::Example03.Properties.Resources._6; }
            else if (Id == 7) { return global::Example03.Properties.Resources._7; }
            else if (Id == 8) { return global::Example03.Properties.Resources._8; }
            else if (Id == 9) { return global::Example03.Properties.Resources._9; }
            else { return global::Example03.Properties.Resources._10; }
        }

        public void ChangeTo(int id)
        {
            this.Id = id;
            ScenePictureBox.Image = this.ChangeScene(Id);
            if (id == 1)
            {
                YesButton.Text = "乾啦";
                NoButton.Hide();
            }
            else if (id == 2 || id == 3 || id == 5 || id == 8)
            {
                YesButton.Text = "1";
                NoButton.Text = "2";
                YesButton.Show();
                NoButton.Show();
            }
            else if (id == 9) { YesButton.Text = "1"; NoButton.Hide(); }
            else { YesButton.Text = "重新開始"; NoButton.Hide(); }
        }
    }
}