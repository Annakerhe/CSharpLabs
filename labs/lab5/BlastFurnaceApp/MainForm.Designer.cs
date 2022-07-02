namespace BlastFurnaceApp
{
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
            this.components = new System.ComponentModel.Container();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.погрузчикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.большойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.среднийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шустрыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рабочегоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 50;
            this.timerRefresh.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(12, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(310, 438);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            this.textBox1.DoubleClick += new System.EventHandler(this.textBox1_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1258, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.показатьToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.погрузчикToolStripMenuItem,
            this.рабочегоToolStripMenuItem,
            this.печьToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // погрузчикToolStripMenuItem
            // 
            this.погрузчикToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.большойToolStripMenuItem,
            this.среднийToolStripMenuItem,
            this.шустрыйToolStripMenuItem});
            this.погрузчикToolStripMenuItem.Name = "погрузчикToolStripMenuItem";
            this.погрузчикToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.погрузчикToolStripMenuItem.Text = "Погрузчик";
            // 
            // большойToolStripMenuItem
            // 
            this.большойToolStripMenuItem.Name = "большойToolStripMenuItem";
            this.большойToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.большойToolStripMenuItem.Text = "Большой";
            this.большойToolStripMenuItem.Click += new System.EventHandler(this.большойToolStripMenuItem_Click);
            // 
            // среднийToolStripMenuItem
            // 
            this.среднийToolStripMenuItem.Name = "среднийToolStripMenuItem";
            this.среднийToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.среднийToolStripMenuItem.Text = "Средний";
            this.среднийToolStripMenuItem.Click += new System.EventHandler(this.среднийToolStripMenuItem_Click);
            // 
            // шустрыйToolStripMenuItem
            // 
            this.шустрыйToolStripMenuItem.Name = "шустрыйToolStripMenuItem";
            this.шустрыйToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.шустрыйToolStripMenuItem.Text = "Шустрый";
            this.шустрыйToolStripMenuItem.Click += new System.EventHandler(this.шустрыйToolStripMenuItem_Click);
            // 
            // рабочегоToolStripMenuItem
            // 
            this.рабочегоToolStripMenuItem.Name = "рабочегоToolStripMenuItem";
            this.рабочегоToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.рабочегоToolStripMenuItem.Text = "Рабочего";
            this.рабочегоToolStripMenuItem.Click += new System.EventHandler(this.рабочегоToolStripMenuItem_Click);
            // 
            // печьToolStripMenuItem
            // 
            this.печьToolStripMenuItem.Name = "печьToolStripMenuItem";
            this.печьToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.печьToolStripMenuItem.Text = "Печь";
            this.печьToolStripMenuItem.Click += new System.EventHandler(this.печьToolStripMenuItem_Click);
            // 
            // показатьToolStripMenuItem
            // 
            this.показатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.журналToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.показатьToolStripMenuItem.Name = "показатьToolStripMenuItem";
            this.показатьToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.показатьToolStripMenuItem.Text = "Информация";
            // 
            // журналToolStripMenuItem
            // 
            this.журналToolStripMenuItem.Name = "журналToolStripMenuItem";
            this.журналToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.журналToolStripMenuItem.Text = "Журнал";
            this.журналToolStripMenuItem.Click += new System.EventHandler(this.журналToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1147, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Работаю";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1147, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Перегрелась";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Visible = false;
            // 
            // timerLoad
            // 
            this.timerLoad.Enabled = true;
            this.timerLoad.Interval = 2000;
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Доменая печь";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerRefresh;
        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem рабочегоToolStripMenuItem;
        private ToolStripMenuItem погрузчикToolStripMenuItem;
        private ToolStripMenuItem печьToolStripMenuItem;
        private ToolStripMenuItem показатьToolStripMenuItem;
        private ToolStripMenuItem журналToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem большойToolStripMenuItem;
        private ToolStripMenuItem среднийToolStripMenuItem;
        private ToolStripMenuItem шустрыйToolStripMenuItem;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timerLoad;
    }
}