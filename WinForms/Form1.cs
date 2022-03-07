using Model;

namespace WinForms
{
    public partial class Form1 : Form
    {
        Employees database = null;

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
            timer.Interval = 1000;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            tsslCurrentTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Ñîçäàéòå áàçó äàííûõ");
                return;
            }
            frmAddEmployee frmAddEmployee = new frmAddEmployee();
            frmAddEmployee.ShowDialog();
            if (frmAddEmployee.DialogResult == DialogResult.OK)
            {
                database.Add(frmAddEmployee.Employee);
                UpdateInfo();
            }
        }

        public void UpdateInfo()
        {
            Employee employee = database?.CurrentEmployee;
            if (employee == null)
            {
                tbName.Text = "";
                tbDescribe.Text = "";
                tbPosition.Text = "";
                tslIndex.Text = "-1";
                return;
            }
            tbName.Text = employee.Name;
            tbPosition.Text = employee.Position;
            tbDescribe.Text = employee.Describe;
            dtpBirthDay.Value = employee.BirthDay;
            tslIndex.Text = database.CurrentIndex.ToString();
        }

        private void ñîçäàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            database = new Employees();
        }

        private void tsbPrev_Click(object sender, EventArgs e)
        {
            database.Prev();
            UpdateInfo();
        }

        private void tsbNext_Click(object sender, EventArgs e)
        {
            database.Next();
            UpdateInfo();
        }

        private void tsbRemove_Click(object sender, EventArgs e)
        {
            database.Remove();
            UpdateInfo();
        }

        private void ñîõğàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ñîõğàíèòüêàêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "XML ôàéë |*.XML|Âñå ôàéëû|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                database.Save(dialog.FileName);
            }
        }

        private void îòêğûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "XML ôàéë |*.XML|Âñå ôàéëû|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                database = new Employees();
                database.Load(dialog.FileName);
                UpdateInfo();
            }
        }

        private void îÏğîãğàììåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutApp aboutApp = new AboutApp();
            aboutApp.ShowDialog();
           
        }
    }
}