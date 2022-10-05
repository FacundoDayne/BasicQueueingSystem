namespace BasicQueueingSystem
{
    public partial class QueueingForm : Form
    {
        CashierWindowQueueForm frm; private CashierClass cashier;
        public QueueingForm()
        {
            InitializeComponent();
            frm = new CashierWindowQueueForm();
            frm.Show();
            cashier = new CashierClass();
        }

        private void Click(object s, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
    }
}