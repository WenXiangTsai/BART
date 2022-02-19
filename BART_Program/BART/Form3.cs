using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BART
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            label1.Text =
                "        這個作業每回合將呈現一顆氣球。您可以點選中間標示“充氣”按鈕\r\n\r\n" +
                "來增加氣球的大小。每次充氣會在氣球中增加一分，不過您不會知道目前\r\n\r\n" +
                "氣球已經累積幾分。作業中您也可以點選左邊標示“回合結算”按鈕，收\r\n\r\n" +
                "集該氣球所累積的分數，此時分數將計入“作業總分”，接著跳到下顆氣\r\n\r\n" +
                "球繼續作業。\r\n\r\n\r\n\r\n" +
                "        您可以自由決定替氣球充氣多少次，但小心在某些時機點氣球可能會\r\n\r\n" +
                "爆炸，從第一次充氣到把氣球充滿整個螢幕都有可能是爆炸點。如果在您\r\n\r\n" +
                "點選“回合結算”之前氣球爆炸，則會跳到下顆氣球並且失去所累積分數\r\n\r\n" +
                "。不過氣球爆炸不會影響您的作業總分測驗結束之後，作業總分將是您的\r\n\r\n" +
                "測驗表現。\r\n\r\n\r\n\r\n" +
                "            以上如有任何疑問請舉手詢問主試者，若沒有請開始練習。";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
