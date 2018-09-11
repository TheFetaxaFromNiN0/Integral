namespace WindowsFormsApplication2
{
    partial class Ans
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.AnsBox = new System.Windows.Forms.RichTextBox();
            this.AnsClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ответ :";
            // 
            // AnsBox
            // 
            this.AnsBox.Location = new System.Drawing.Point(112, 63);
            this.AnsBox.Name = "AnsBox";
            this.AnsBox.ReadOnly = true;
            this.AnsBox.Size = new System.Drawing.Size(155, 46);
            this.AnsBox.TabIndex = 1;
            this.AnsBox.Text = "";
            this.AnsBox.TextChanged += new System.EventHandler(this.AnsBox_TextChanged);
            // 
            // AnsClose
            // 
            this.AnsClose.Location = new System.Drawing.Point(287, 149);
            this.AnsClose.Name = "AnsClose";
            this.AnsClose.Size = new System.Drawing.Size(78, 27);
            this.AnsClose.TabIndex = 2;
            this.AnsClose.Text = "Закрыть";
            this.AnsClose.UseVisualStyleBackColor = true;
            this.AnsClose.Click += new System.EventHandler(this.AnsClose_Click);
            // 
            // Ans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(377, 188);
            this.Controls.Add(this.AnsClose);
            this.Controls.Add(this.AnsBox);
            this.Controls.Add(this.label1);
            this.Name = "Ans";
            this.Text = "Ans";
            this.Load += new System.EventHandler(this.Ans_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox AnsBox;
        private System.Windows.Forms.Button AnsClose;
    }
}