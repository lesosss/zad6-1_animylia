using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad6_animyli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        bool timerStartr = false;
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            tmr.Enabled = true;
            tmr.Interval = 30;

            if (!timerStartr)
            {
                tmr.Enabled = true;
                timerStartr = true;
                btnStart.Text = "Стоп";
            }
 
            else if(pct.Left + pct.Width > this.Width)
            {//если картинка на краю формы то пр нажатии она возвращается в начальное положение
                pct.Left = 0;
                tmr.Enabled = false;
                timerStartr = false;
                btnStart.Text = "Старт"; 
                
                
             }
            
            else
                {
                    tmr.Enabled = false;
                    timerStartr = false;
                    btnStart.Text = "Старт";
                }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            pct.Left = pct.Left + 20;
        }
    }
}
