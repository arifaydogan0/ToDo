namespace ToDo;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(450, 450);
        this.ShowInTaskbar = false;
        this.Icon = new Icon(Application.StartupPath + @"\icon.ico");
        this.ShowIcon = true;
        this.SuspendLayout();

        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.SizableToolWindow;

        this.Load += new(this.Form1_Load);
        this.FormClosing += new(this.Form1_Closing);
        this.SizeChanged += new(Form1_ChangedSize);
        this.Controls.Add(panel1);
        this.Controls.Add(panel2);

        this.richTextBox1.DoubleClick += new(this.richTextBox1_DoubleClick);
        this.richTextBox1.KeyDown += new(this.richTextBox1_KeyDown);
        this.panel1.Controls.Add(richTextBox1);

        this.panel2.Controls.Add(dtp1);

        this.btn1.Click += new(this.btn1_Click);
        this.dtp1.Controls.Add(btn1);

        this.timer1.Tick += new(this.timer1_Ticks);

        this.notifyIcon.ContextMenuStrip = menuStrip;
        this.notifyIcon.MouseDoubleClick += new(notifyIcon_MouseDoubleClick);
        this.menuStrip.Items.Add(item);
        this.item.Click += new(item_Click); 

        this.Name = "Form1";
        this.Text = "ToDo";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Panel panel1 = new()
    {
        Name = "panel1",
        BackColor = Color.Yellow,
        Dock = DockStyle.Fill,
    };
    private System.Windows.Forms.Panel panel2 = new()
    {
        Name = "panel2",
        BackColor = Color.Yellow,
        Dock = DockStyle.Bottom,
    };
    private System.Windows.Forms.DateTimePicker dtp1 = new()
    {
        Name = "dtp1",
        Enabled = true,
        Format = DateTimePickerFormat.Time,
        Dock = DockStyle.Fill,
        Font = new Font(FontFamily.GenericMonospace, 13f, FontStyle.Bold),
    };
    private System.Windows.Forms.Button btn1 = new()
    {
        Name = "btn1",
        Dock = DockStyle.Right,
        Text = "Başlat",
        UseCompatibleTextRendering = true,
        UseMnemonic = true,
        AutoSize = true,
    };
    private System.Windows.Forms.RichTextBox richTextBox1 = new()
    {
        Name = "richTextBox1",
        BackColor = Color.Yellow,
        Text = "Test",
        BorderStyle = BorderStyle.None,
        ReadOnly = false,
        Font = new Font(FontFamily.Families[7], 14f, FontStyle.Bold),
        UseWaitCursor = false,
        AllowDrop = false,
        HideSelection = true,
        ImeMode = ImeMode.NoControl,
        CausesValidation = true,
        Dock = DockStyle.None,
        Multiline = true,
        WordWrap = true,
        Location = new Point(10, 10),
        TabStop = false,
    };
    private System.Windows.Forms.Timer timer1 = new()
    {
        Enabled = false,
        Interval = 1000,
    };
    private System.Windows.Forms.NotifyIcon notifyIcon = new()
    {
        Icon = new Icon(Application.StartupPath + @"\icon.ico"),
        Visible = true,
        BalloonTipTitle = "ToDo App",
        BalloonTipText = "ToDo App",
    };
    private System.Windows.Forms.ContextMenuStrip menuStrip = new()
    {

    };
    private System.Windows.Forms.ToolStripMenuItem item = new()
    {
        Name = "Çıkış",
        Text = "Çıkış",
    };
}
