namespace Bee_Hive_Simulator
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btStartSimulation = new System.Windows.Forms.ToolStripButton();
            this.btReset = new System.Windows.Forms.ToolStripButton();
            this.btOpen = new System.Windows.Forms.ToolStripButton();
            this.btSave = new System.Windows.Forms.ToolStripButton();
            this.btPrint = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Bees = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Flowers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HoneyInHive = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NectarInFlowers = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FramesRun = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FrameRate = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btStartSimulation,
            this.btReset,
            this.btOpen,
            this.btSave,
            this.btPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btStartSimulation
            // 
            this.btStartSimulation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btStartSimulation.Image = ((System.Drawing.Image)(resources.GetObject("btStartSimulation.Image")));
            this.btStartSimulation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btStartSimulation.Name = "btStartSimulation";
            this.btStartSimulation.Size = new System.Drawing.Size(95, 22);
            this.btStartSimulation.Text = "Start Simulation";
            this.btStartSimulation.Click += new System.EventHandler(this.btStartSimulation_Click);
            // 
            // btReset
            // 
            this.btReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btReset.Image = ((System.Drawing.Image)(resources.GetObject("btReset.Image")));
            this.btReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(39, 22);
            this.btReset.Text = "Reset";
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btOpen
            // 
            this.btOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btOpen.Image = ((System.Drawing.Image)(resources.GetObject("btOpen.Image")));
            this.btOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(23, 22);
            this.btOpen.Text = "&Открыть";
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btSave
            // 
            this.btSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(23, 22);
            this.btSave.Text = "&Сохранить";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btPrint
            // 
            this.btPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btPrint.Image = ((System.Drawing.Image)(resources.GetObject("btPrint.Image")));
            this.btPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(23, 22);
            this.btPrint.Text = "&Печать";
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 285);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(105, 17);
            this.toolStripStatusLabel1.Text = "Simulation paused";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Bees, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Flowers, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.HoneyInHive, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.NectarInFlowers, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.FramesRun, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.FrameRate, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(259, 122);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Bees
            // 
            this.Bees.AutoSize = true;
            this.Bees.Location = new System.Drawing.Point(132, 0);
            this.Bees.Name = "Bees";
            this.Bees.Size = new System.Drawing.Size(31, 13);
            this.Bees.TabIndex = 0;
            this.Bees.Text = "Bees";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "#Bees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "#Flowers";
            // 
            // Flowers
            // 
            this.Flowers.AutoSize = true;
            this.Flowers.Location = new System.Drawing.Point(132, 22);
            this.Flowers.Name = "Flowers";
            this.Flowers.Size = new System.Drawing.Size(43, 13);
            this.Flowers.TabIndex = 3;
            this.Flowers.Text = "Flowers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total honey in the hive";
            // 
            // HoneyInHive
            // 
            this.HoneyInHive.AutoSize = true;
            this.HoneyInHive.Location = new System.Drawing.Point(132, 42);
            this.HoneyInHive.Name = "HoneyInHive";
            this.HoneyInHive.Size = new System.Drawing.Size(69, 13);
            this.HoneyInHive.TabIndex = 5;
            this.HoneyInHive.Text = "HoneyInHive";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total nectar in the filed";
            // 
            // NectarInFlowers
            // 
            this.NectarInFlowers.AutoSize = true;
            this.NectarInFlowers.Location = new System.Drawing.Point(132, 62);
            this.NectarInFlowers.Name = "NectarInFlowers";
            this.NectarInFlowers.Size = new System.Drawing.Size(84, 13);
            this.NectarInFlowers.TabIndex = 7;
            this.NectarInFlowers.Text = "NectarInFlowers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Frames run";
            // 
            // FramesRun
            // 
            this.FramesRun.AutoSize = true;
            this.FramesRun.Location = new System.Drawing.Point(132, 82);
            this.FramesRun.Name = "FramesRun";
            this.FramesRun.Size = new System.Drawing.Size(61, 13);
            this.FramesRun.TabIndex = 9;
            this.FramesRun.Text = "FramesRun";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Frame rate";
            // 
            // FrameRate
            // 
            this.FrameRate.AutoSize = true;
            this.FrameRate.Location = new System.Drawing.Point(132, 102);
            this.FrameRate.Name = "FrameRate";
            this.FrameRate.Size = new System.Drawing.Size(59, 13);
            this.FrameRate.TabIndex = 11;
            this.FrameRate.Text = "FrameRate";
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(13, 168);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(258, 108);
            this.lb1.TabIndex = 3;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 150;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 307);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Beehive Simulator";
            this.Move += new System.EventHandler(this.Form1_Move);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btStartSimulation;
        private System.Windows.Forms.ToolStripButton btReset;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Bees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Flowers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label HoneyInHive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NectarInFlowers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label FramesRun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label FrameRate;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ToolStripButton btOpen;
        private System.Windows.Forms.ToolStripButton btSave;
        private System.Windows.Forms.ToolStripButton btPrint;
        private System.Windows.Forms.Timer timer2;
    }
}

