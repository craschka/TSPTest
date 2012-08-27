namespace TSPTest
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tankstellenName = new System.Windows.Forms.Label();
            this.tankstelleDdorf = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Test";
            this.notifyIcon1.BalloonTipTitle = "Neuer Preis";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aktualisieren";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3400000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tankstellenName
            // 
            this.tankstellenName.AutoSize = true;
            this.tankstellenName.Location = new System.Drawing.Point(12, 24);
            this.tankstellenName.Name = "tankstellenName";
            this.tankstellenName.Size = new System.Drawing.Size(35, 13);
            this.tankstellenName.TabIndex = 1;
            this.tankstellenName.Text = "label1";
            // 
            // tankstelleDdorf
            // 
            this.tankstelleDdorf.AutoSize = true;
            this.tankstelleDdorf.Location = new System.Drawing.Point(12, 56);
            this.tankstelleDdorf.Name = "tankstelleDdorf";
            this.tankstelleDdorf.Size = new System.Drawing.Size(35, 13);
            this.tankstelleDdorf.TabIndex = 2;
            this.tankstelleDdorf.Text = "label1";
            // 
            // timer2
            // 
            this.timer2.Interval = 3100000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 113);
            this.Controls.Add(this.tankstelleDdorf);
            this.Controls.Add(this.tankstellenName);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button1;
		  private System.Windows.Forms.Timer timer1;
          private System.Windows.Forms.Label tankstellenName;
          private System.Windows.Forms.Label tankstelleDdorf;
          private System.Windows.Forms.Timer timer2;

    }
}

