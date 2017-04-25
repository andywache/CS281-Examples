using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Lecture03
{
    public class Scene
    {
        #region 建構式

        public Scene(int id)
        {
            this.Id = id;
            //this.
        }

        #endregion 建構式

        #region 欄位的定義

        public int Id;
        public Button YesButton;
        public Button NoButton;

        #endregion 欄位的定義

        #region Scene的公用方法

        public Image GetImage()     //這種 "()" 傳值得 method 需要注意??  <紅底線>  //收到什麼指令 變更什麼圖片  <決定目前場景>
        {
            if (this.Id == 1)       // <(this.Id == 1) -> 如果由Scene new 出來的物件 id = 1>
            { return global::Lecture03.Properties.Resources._1; }      //回傳 場景照片 "_1"
            else if (this.Id == 2) { return global::Lecture03.Properties.Resources._2; }
            else if (this.Id == 3) { return global::Lecture03.Properties.Resources._3; }
            else if (this.Id == 4) { return global::Lecture03.Properties.Resources._4; }
            else if (this.Id == 5) { return global::Lecture03.Properties.Resources._5; }
            else if (this.Id == 6) { return global::Lecture03.Properties.Resources._6; }
            else if (this.Id == 7) { return global::Lecture03.Properties.Resources._7; }
            else if (this.Id == 8) { return global::Lecture03.Properties.Resources._8; }
            else if (this.Id == 9) { return global::Lecture03.Properties.Resources._9; }
            else { return global::Lecture03.Properties.Resources._10; }
        }

        #endregion Scene的公用方法

        public void ChangeTo(int id)
        {
            this.Id = id;
        }
    }
}