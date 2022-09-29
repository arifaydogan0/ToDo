using System.Diagnostics;
using System.Media;

namespace ToDo;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    //Form events
    private void Form1_Load(object sender, EventArgs e)
    {
        this.Location = AppSettings.Location;
        this.Size = AppSettings.Size;
        this.richTextBox1.Text = AppSettings.Content;
        this.panel2.Size = dtp1.Size;
        this.notifyIcon.Text = "ToDo App";
    }
    private void Form1_Closing(object sender, FormClosingEventArgs e)
    {
        e.Cancel = true;
        this.Visible = false;
    }
    private void Form1_ChangedSize(object sender, EventArgs e)
    {
        this.richTextBox1.Size = new Size(this.Size.Width - 20, this.Size.Height - 20);
    }


    //richTextBox1 events
    private void richTextBox1_DoubleClick(object sender, EventArgs e)
    {
        richTextBox1.Focus();
    }
    private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyData == Keys.Enter)
        {
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(111);
                richTextBox1.AppendText("- ");
            });
        }
    }


    //btn1 events
    private void btn1_Click(object sender, EventArgs e)
    {
        if (dtp1.Value.Hour <= 0 && dtp1.Value.Minute <= 0 && dtp1.Value.Second <= 0)
            return;
        if (!timer1.Enabled)
        {
            timer1.Enabled = true;
            btn1.Text = "Durdur";
            btn1.BackColor = Color.GreenYellow;
        }
        else
        {
            timer1.Enabled = false;
            btn1.Text = "Başlat";
            btn1.BackColor = this.BackColor;
        }
    }


    //timer1 events
    private void timer1_Ticks(object sender, EventArgs e)
    {
        if (dtp1.Value.Hour <= 0 && dtp1.Value.Minute <= 0 && dtp1.Value.Second <= 0)
        {
            SoundPlayer simpleSound = new SoundPlayer(Application.StartupPath + @"\timerSound.wav");
            simpleSound.Play();
            timer1.Enabled = false;
            btn1.Text = "Başlat";
            btn1.BackColor = this.BackColor;
            return;
        }
        dtp1.Value = dtp1.Value.AddSeconds(-1);
    }


    //notify events
    private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        this.Visible = true;
    }


    //menustrip events
    private void item_Click(object sender, EventArgs e)
    {
        AppSettings.Location = this.Location;
        AppSettings.Size = this.Size;
        AppSettings.Content = this.richTextBox1.Text;
        foreach (var p in Process.GetProcesses().Where(x => x.ProcessName == "ToDo").ToList())
            p.Kill();
    }
}
