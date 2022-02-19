using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;


namespace BART
{
    public partial class Form1 : Form
    {
        int pumpscount = 0;
        int totalearned = 0;
        int BlueBurst;
        int BreakPoint;
        int Lifecount;
        decimal BARTscore;
        decimal averagelife;
        decimal averagepump;
        int burstnumber = 0;
        int totalpump;
        
        int trials = 1;

        int MaxLife;  //氣球最大生命
        int EndType;  //結束類型：0 = standard；1 = collection
        int round;    //測驗回合
        int practice;  //是否練習：0 = yes；1 = no
        int sound;
        double Delay;

        int datacolumn = 0;
        int pumpcontrol = 0;      //1 = 鎖定；0 = 解鎖
        int collectcontrol = 1;   //1 = 鎖定；0 = 解鎖
        int collectcount = 1;

        float BalloonX ;
        float BalloonY ;
        float BalloonHeight ;
        float BalloonWidth ;

        List<int> list_trial = new List<int>();
        List<int> list_pumps = new List<int>();
        List<int> list_type = new List<int>();
        List<int> list_earned = new List<int>();
        List<int> list_last = new List<int>();
        List<int> list_life = new List<int>();
        List<int> list_burst = new List<int>();
        List<string> list_time = new List<string>();

        Form4 f4 = new Form4();
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();

        public string ID;
        public string Sex;
        public string BirthYear;
        public string Education;
        public string Starttime;
        public DateTime Begintime;
        public DateTime Endtime;

        public Form1()
        {
            InitializeComponent();

            f4.ShowDialog();
            f2.ShowDialog();
            //f3.ShowDialog();

            GetParticipant();
            GetParameter();

            label_Burst.Visible = false;
            label_Wait.Visible = false; 

            BalloonX = this.Width / 2 - 25;
            BalloonY = Pump.Location.Y - 70;
            BalloonHeight = 50;
            BalloonWidth = 50;

            Pump.Enabled = false;
            Pump.Enabled = true;
            Starttime = DateTime.Now.ToString("yyyyMMddHHmmss");
            Begintime = DateTime.Now;
            pumpcontrol = 0;
            collectcontrol = 0;

            BalloonType();

            
        }

        private void GetParameter()
        {
            MaxLife = Int32.Parse(f4.MaxLifeSetting.Text);
            EndType = Int32.Parse(f4.EndTypeSetting.Text);
            round = Int32.Parse(f4.TrialsSetting.Text);
            practice = Int32.Parse(f4.PracticeSetting.Text);
            sound = Int32.Parse(f4.VoiceSetting.Text);
            Delay = Double.Parse(f4.DelaySetting.Text);
        }

        private void GetParticipant()
        {
            this.ID = f2.textBoxSubnum.Text;
            this.Sex = f2.comboBox2.Text;
            this.BirthYear = f2.numericUpDown1.Value.ToString();
            this.Education = f2.comboBox1.Text;

            //MessageBox.Show(ID + Sex + Year + Education);
        }

        private void BalloonType() //氣球類型
        {
            Random BlueBreakPoint = new Random();
            BlueBurst = BlueBreakPoint.Next(1, MaxLife);
            BreakPoint = BlueBurst;

            if (trials < round + 1 && EndType == 0)
            {
                Lifecount = Lifecount + BreakPoint;
            }

            if (collectcount < round + 1 && EndType == 1)
            {
                Lifecount = Lifecount + BreakPoint;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e) //圖型
        {
            //球形
            Graphics g = this.CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Green);
            g.FillEllipse(sb, BalloonX, BalloonY, BalloonWidth, BalloonHeight);

            //矩形
            Pen pen2 = new Pen(Color.White, 20);             //Pen pen2 = new Pen(Color.White, 寬);
            e.Graphics.DrawLine(pen2, this.Width/2, Pump.Location.Y-20, this.Width/2, Pump.Location.Y);
            //e.Graphics.DrawLine(pen2, 矩形上邊中心x坐標, 矩形上邊中心y坐標, 矩形下邊中心x坐標, 矩形下邊中心y坐標);

        }

        private void Pump_Click(object sender, EventArgs e)  //充氣後
        {
            pumpscount++;
            datacolumn++;
            totalpump++;

            if (sound == 0)
            {
                SoundPlayer PumpSound = new SoundPlayer();     //充氣聲音開關
                PumpSound.Stream = Resource1.Balloon_Pump;
                PumpSound.Play();
            }

            Button_disabled();

            if (BreakPoint == pumpscount)
            {
                list_trial.Add(trials);
                list_pumps.Add(pumpscount);
                list_earned.Add(totalearned);
                list_burst.Add(1);
                list_last.Add(0);
                list_type.Add(MaxLife);
                list_life.Add(BreakPoint);
                list_time.Add(DateTime.Now.ToString("HH:mm:ss"));

                trials++;

                label_Burst.Visible = true;
                collectcontrol = 1;
                burstnumber++;
                LastEarned.Text = "前次得分 : 0 分";

                if (sound == 0)
                {
                    SoundPlayer BurstSound = new SoundPlayer();    //爆炸聲音開關
                    BurstSound.Stream = Resource1.Balloon_Burst;
                    BurstSound.Play();
                }

                if (trials == 3 + 1 && practice == 0)
                {
                    trials = 1;
                    collectcount = 1;
                    practice = 1;

                    Lifecount = 0;
                    pumpscount = 0;
                    totalearned = 0;
                    burstnumber = 0;
                    totalpump = 0;

                    LastEarned.Text = "前次得分 : " + "0" + " 分";
                    TotalEarned.Text = "作業總分 : " + "0" + " 分";

                    MessageBox.Show("練習結束!! 以下開始正式測驗!!");
                }

                BalloonType();
                BalloonRefresh();

                if (trials == round + 1 && EndType == 0)  //trials 次數
                {
                    Endtime = DateTime.Now;
                    Export();

                    //MessageBox.Show("恭喜你完成了本次測驗!!");
                    
                    Close();
                    
                }
                pumpscount = 0;
            }
            else
            {
                label_Wait.Visible = true;

                list_trial.Add(trials);
                list_pumps.Add(pumpscount);
                list_earned.Add(totalearned);
                list_burst.Add(0);
                list_last.Add(0);
                list_type.Add(MaxLife);
                list_life.Add(BreakPoint);
                list_time.Add(DateTime.Now.ToString("HH:mm:ss"));

                BalloonWidth += ((float)Pump.Location.X / MaxLife);
                BalloonHeight += ((float)Pump.Location.X / MaxLife);
                BalloonX -= ((float)Pump.Location.X / MaxLife/2);
                BalloonY -= ((float)Pump.Location.X / MaxLife);

                label2.Text = Convert.ToString(BalloonX);

                Collect.Enabled = true;
            }
            Refresh();
        }

        private void Collect_Click(object sender, EventArgs e)
        {
            list_last.Add(pumpscount);
            totalearned += pumpscount;

            LastEarned.Text = "前次得分 : " + pumpscount + " 分";
            TotalEarned.Text = "作業總分 : " + totalearned + " 分";

            
            label_Wait.Visible = true;

            datacolumn++;
            collectcount++;

            list_trial.Add(trials);
            list_pumps.Add(pumpscount);
            list_earned.Add(totalearned);
            list_burst.Add(0);
            list_type.Add(MaxLife);
            list_life.Add(BreakPoint);
            list_time.Add(DateTime.Now.ToString("HH:mm:ss"));

            trials++;

            if (sound == 0)
            {
                SoundPlayer CollectSound = new SoundPlayer();   //收錢聲音開關
                CollectSound.Stream = Resource1.Coin;
                CollectSound.Play();
            }

            Button_disabled();
            collectcontrol = 1;
            
            if (trials == 3 + 1 && practice == 0)
            {
                trials = 1;
                collectcount = 1;
                practice = 1;

                Lifecount = 0;
                pumpscount = 0;
                totalearned = 0;
                burstnumber = 0;
                totalpump = 0;

                LastEarned.Text = "前次得分 : " + "0" + " 分";
                TotalEarned.Text = "作業總分 : " + "0" + " 分";

                MessageBox.Show("練習結束!! 以下開始正式測驗!!");
            }

            if (trials == round + 1 && EndType == 0)  //trials 次數
            {
                Endtime = DateTime.Now;
                Export();
                Close(); 
            }

            if (collectcount == round + 1 && EndType == 1)
            {
                Endtime = DateTime.Now;
                Export();
                Close();
            }

            BalloonRefresh();
            BalloonType();

            pumpscount = 0;

        }

        async void Button_disabled() //點擊任意按鈕後失效時間
        {
            Pump.Enabled = false;            
            Collect.Enabled = false;
            pumpcontrol = 1;
            collectcontrol = 1;

            await Task.Delay(TimeSpan.FromSeconds(Delay));

            pumpcontrol = 0;
            collectcontrol = 0;

            label_Wait.Visible = false;
            label_Burst.Visible = false;

            Pump.Enabled = true;
        }

        protected override bool ProcessDialogKey(Keys keyData) //按鍵控制
        {
            if (pumpcontrol == 0 && keyData == Keys.D2)
            {
                    Pump_Click(null, null);
            }

            if (keyData == Keys.D1 && collectcontrol == 0 && pumpscount > 0)
            {
                     Collect_Click(null, null);                           
            }
            return base.ProcessDialogKey(keyData);
        }

        private void BalloonRefresh() //捨棄舊氣球，重製氣球
        {
            BalloonX = this.Width / 2 - 25;
            BalloonY = Pump.Location.Y - 70;
            BalloonHeight = 50;
            BalloonWidth = 50;

            this.Invalidate();
            this.Update();
        }

        private void Export()
        {
            string filename = "BART_" + ID + "_" + Starttime;
            StreamWriter sw = new StreamWriter(@"C:\BART_Data\" + filename + ".txt"); 

            sw.WriteLine(ID + "\t" + Sex + "\t" + BirthYear + "\t" + Education);
            sw.WriteLine("MaxLife\t" + "EndType\t" + "Practice\t" + "Sound\t" + "Delay Time");
            sw.WriteLine(MaxLife +"\t"+ EndType +"\t"+ practice +"\t"+ sound + "\t"+ Delay);
            sw.WriteLine();
            sw.WriteLine("trial\t" + "life\t" + "pumps\t" + "collect\t" + "score\t" + "burst\t" + "time\t");

            int[] a = list_trial.ToArray();
            //int[] b = list_type.ToArray();
            int[] c = list_life.ToArray(); 
            int[] d = list_pumps.ToArray();
            int[] e = list_last.ToArray();
            int[] f = list_earned.ToArray();
            int[] g = list_burst.ToArray();
            string[] h = list_time.ToArray();

            for (int i = 0; i < datacolumn; i++)  
            {
                sw.WriteLine(a[i] + "\t" + c[i] + "\t" + d[i] + "\t" + e[i] + "\t" + f[i] + "\t" + g[i] +"\t" +h[i]);
            }
            sw.WriteLine();

            trials = trials - 1;
            collectcount = collectcount - 1;
            averagelife = Math.Round((decimal)Lifecount / trials, 2);
            averagepump = Math.Round((decimal)totalpump / trials,2);
            BARTscore = Math.Round((decimal)totalearned / collectcount,2);

            TimeSpan ts = Endtime - Begintime;
  
            sw.WriteLine(trials + "\t" + averagelife + "\t" + averagepump + "\t" + BARTscore + "\t" + totalearned +"\t" + burstnumber + "\t" + ts);

            sw.Close();
        }
    }
}
