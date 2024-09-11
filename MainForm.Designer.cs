namespace Todolist;

partial class MainForm
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
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        panel1 = new Panel();
        label1 = new Label();
        pictureBox1 = new PictureBox();
        panel2 = new Panel();
        guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
        panelContainer = new Panel();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(80, 80, 90);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(pictureBox1);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(1122, 100);
        panel1.TabIndex = 0;
        panel1.Paint += panel1_Paint;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("JetBrains Mono", 13.1999989F, FontStyle.Bold, GraphicsUnit.Point);
        label1.ForeColor = SystemColors.ButtonHighlight;
        label1.Location = new Point(190, 35);
        label1.Name = "label1";
        label1.Size = new Size(559, 29);
        label1.TabIndex = 1;
        label1.Text = "TodoList - “The shortest answer is doing.”";

        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.icon;
        pictureBox1.Location = new Point(26, 12);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(93, 80);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        pictureBox1.Click += pictureBox1_Click;
        // 
        // panel2
        // 
        panel2.BackColor = SystemColors.ControlLight;
        panel2.Controls.Add(guna2Button3);
        panel2.Controls.Add(guna2Button2);
        panel2.Controls.Add(guna2Button1);
        panel2.Dock = DockStyle.Top;
        panel2.Location = new Point(0, 100);
        panel2.Name = "panel2";
        panel2.Size = new Size(1122, 67);
        panel2.TabIndex = 1;
        panel2.Paint += panel2_Paint;
        // 
        // guna2Button3
        // 
        guna2Button3.BackColor = Color.Gainsboro;
        guna2Button3.CheckedState.BorderColor = Color.FromArgb(192, 0, 0);
        guna2Button3.CheckedState.CustomBorderColor = Color.FromArgb(192, 0, 0);
        guna2Button3.CustomizableEdges = customizableEdges1;
        guna2Button3.DisabledState.BorderColor = Color.DarkGray;
        guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button3.FillColor = Color.LightGray;
        guna2Button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        guna2Button3.ForeColor = Color.Black;
        guna2Button3.Location = new Point(257, 0);
        guna2Button3.Name = "guna2Button3";
        guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges2;
        guna2Button3.Size = new Size(135, 65);
        guna2Button3.TabIndex = 4;
        guna2Button3.Tag = "";
        guna2Button3.Text = "Account";
        guna2Button3.Click += guna2Button3_Click;
        // 
        // guna2Button2
        // 
        guna2Button2.BackColor = Color.Gainsboro;
        guna2Button2.CheckedState.BorderColor = Color.FromArgb(192, 0, 0);
        guna2Button2.CheckedState.CustomBorderColor = Color.FromArgb(192, 0, 0);
        guna2Button2.CustomizableEdges = customizableEdges3;
        guna2Button2.DisabledState.BorderColor = Color.DarkGray;
        guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button2.FillColor = Color.LightGray;
        guna2Button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        guna2Button2.ForeColor = Color.Black;
        guna2Button2.Location = new Point(128, 0);
        guna2Button2.Name = "guna2Button2";
        guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
        guna2Button2.Size = new Size(135, 65);
        guna2Button2.TabIndex = 3;
        guna2Button2.Tag = "";
        guna2Button2.Text = "Today Activities";
        guna2Button2.Click += guna2Button2_Click;
        // 
        // guna2Button1
        // 
        guna2Button1.BackColor = Color.Transparent;
        guna2Button1.CustomBorderColor = SystemColors.ActiveBorder;
        guna2Button1.CustomizableEdges = customizableEdges5;
        guna2Button1.DisabledState.BorderColor = Color.DarkGray;
        guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button1.FillColor = Color.LightGray;
        guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        guna2Button1.ForeColor = Color.Black;
        guna2Button1.Location = new Point(0, 0);
        guna2Button1.Name = "guna2Button1";
        guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
        guna2Button1.Size = new Size(135, 65);
        guna2Button1.TabIndex = 2;
        guna2Button1.Tag = "Home";
        guna2Button1.Text = "Home";
        guna2Button1.Click += guna2Button1_Click;
        // 
        // panelContainer
        // 
        panelContainer.Dock = DockStyle.Fill;
        panelContainer.Location = new Point(0, 167);
        panelContainer.Name = "panelContainer";
        panelContainer.Size = new Size(1122, 435);
        panelContainer.TabIndex = 2;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1122, 602);
        Controls.Add(panelContainer);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Name = "MainForm";
        Text = "Form1";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        panel2.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Label label1;
    private PictureBox pictureBox1;
    private Panel panel2;
    private Guna.UI2.WinForms.Guna2Button guna2Button2;
    private Guna.UI2.WinForms.Guna2Button guna2Button1;
    private Guna.UI2.WinForms.Guna2Button guna2Button3;
    private Panel panelContainer;
}