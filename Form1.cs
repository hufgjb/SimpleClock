using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClock
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();

            timerClock.Start();       // 啟動時鐘
        }

        // 時鐘timer1_Tick事件：每一秒執行一次
        private void timerClock_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString("HH:mm:ss");    // 顯示時間
            txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");  // 顯示日期
            txtWeekDay.Text = DateTime.Now.ToString("dddd");     // 顯示星期幾
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timerAlert_Tick(object sender, EventArgs e)
        {

        }
    }
}
