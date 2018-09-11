namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn = new System.Windows.Forms.Button();
            this.UpperLim = new System.Windows.Forms.TextBox();
            this.BotLim = new System.Windows.Forms.TextBox();
            this.Integral = new System.Windows.Forms.RichTextBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            resources.ApplyResources(this.btn, "btn");
            this.btn.BackColor = System.Drawing.Color.White;
            this.btn.Name = "btn";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // UpperLim
            // 
            resources.ApplyResources(this.UpperLim, "UpperLim");
            this.UpperLim.Name = "UpperLim";
            this.UpperLim.TextChanged += new System.EventHandler(this.UpperLim_TextChanged);
            // 
            // BotLim
            // 
            resources.ApplyResources(this.BotLim, "BotLim");
            this.BotLim.Name = "BotLim";
            this.BotLim.TextChanged += new System.EventHandler(this.BotLim_TextChanged);
            // 
            // Integral
            // 
            resources.ApplyResources(this.Integral, "Integral");
            this.Integral.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Integral.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Integral.Name = "Integral";
            this.Integral.Tag = "exp";
            this.Integral.TextChanged += new System.EventHandler(this.Integral_TextChanged);
            // 
            // BtnClose
            // 
            resources.ApplyResources(this.BtnClose, "BtnClose");
            this.BtnClose.BackColor = System.Drawing.Color.White;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Clear
            // 
            resources.ApplyResources(this.Clear, "Clear");
            this.Clear.BackColor = System.Drawing.Color.White;
            this.Clear.Name = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.BtnClose;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.Integral);
            this.Controls.Add(this.BotLim);
            this.Controls.Add(this.UpperLim);
            this.Controls.Add(this.btn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox UpperLim;
        private System.Windows.Forms.TextBox BotLim;
        private System.Windows.Forms.RichTextBox Integral;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

