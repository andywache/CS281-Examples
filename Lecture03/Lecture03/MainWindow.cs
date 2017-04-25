using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture03
{
    public partial class MainWindow : Form
    {
        //定義一個變數 儲存現在的場景
        private Scene currentScene;

        public MainWindow()
        {
            InitializeComponent();
            this.currentScene = new Scene(1);
            this.Render();      //進入MainWindow Form 並讀取場景讀場景(預設圖片1)
            this.currentScene.YesButton = this.yesButton;
            this.currentScene.NoButton = this.noButton;
            this.currentScene.YesButton.Text = "乾啦";
        }

        private void MakeDecision(int decision)
        {
            if (currentScene.Id == 1)       //目前場景位置 在 1
            {
                if (decision == 1)
                { currentScene.ChangeTo(2); }//切換到場景2 <將2傳入 "ChangeTo" 改變場景Id =2 傳入"Render" 替換圖片by "currentScene.GetImage() 回傳圖片給 this.scenePictureBox.Image"
            }
            else if (currentScene.Id == 2)
            {
                if (decision == 1)
                {
                    currentScene.ChangeTo(8);
                }
                else currentScene.ChangeTo(3);
            }
            else if (currentScene.Id == 3)
            {
                if (decision == 1)
                {
                    currentScene.ChangeTo(4);
                }
                if (decision == 2)
                {
                    currentScene.ChangeTo(5);
                }
            }
            else if (currentScene.Id == 4)
            {
                return;
            }
            else if (currentScene.Id == 5)
            {
                if (decision == 1)
                {
                    currentScene.ChangeTo(6);
                }
                if (decision == 2)
                {
                    currentScene.ChangeTo(7);
                }
            }
            else if (currentScene.Id == 6)
            {
                return;
            }
            else if (currentScene.Id == 7)
            {
                return;
            }
            else if (currentScene.Id == 8)
            {
                if (decision == 1)
                {
                    currentScene.ChangeTo(9);
                }
                if (decision == 2)
                {
                    currentScene.ChangeTo(10);
                }
            }
            else if (currentScene.Id == 9)
            {
                currentScene.ChangeTo(3);
            }
            else if (currentScene.Id == 10)
            {
                return;
            }
            this.Render();      //更新畫面?
        }

        private void Render()   //改變場景用 (繪製畫面??)
        {
            this.scenePictureBox.Image = currentScene.GetImage();//scenePictureBox = winform 圖片Name , Image = scenePictureBox的屬性(圖片指定)
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            this.MakeDecision(1);
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.MakeDecision(2);
        }
    }
}