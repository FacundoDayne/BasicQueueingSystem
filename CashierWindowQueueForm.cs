using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueueingSystem
{
    public partial class CashierWindowQueueForm : Form
    {
        System.Windows.Forms.Timer timer; CustomerView cv;
        public CashierWindowQueueForm()
        {
            InitializeComponent(); cv = new CustomerView(); cv.Show();
            timer = new System.Windows.Forms.Timer(); timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_tick); timer.Start(); 
        }

        int x = 0;
        private void timer_tick(object s, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
            x++; label1.Text = x.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            } 
        }
        private void btnNext_Click(object sender, EventArgs e)
        {    
            if (CashierClass.CashierQueue.Count > 0)
            {
                cv.label1.Text = CashierClass.CashierQueue.Peek();
                CashierClass.CashierQueue.Dequeue();                
            }
        }
    }
}
