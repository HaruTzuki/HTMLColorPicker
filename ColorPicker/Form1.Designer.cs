namespace ColorPicker
{
    partial class Form1
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
            this.lblColorCode = new System.Windows.Forms.Label();
            this.btnColorOpen = new System.Windows.Forms.Button();
            this.cd = new System.Windows.Forms.ColorDialog();
            this.lblHTMLCode = new System.Windows.Forms.Label();
            this.txtHTMLCode = new System.Windows.Forms.TextBox();
            this.txtRGBCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblColorCode
            // 
            this.lblColorCode.Location = new System.Drawing.Point(206, 100);
            this.lblColorCode.Name = "lblColorCode";
            this.lblColorCode.Size = new System.Drawing.Size(124, 102);
            this.lblColorCode.TabIndex = 0;
            // 
            // btnColorOpen
            // 
            this.btnColorOpen.Location = new System.Drawing.Point(206, 38);
            this.btnColorOpen.Name = "btnColorOpen";
            this.btnColorOpen.Size = new System.Drawing.Size(124, 59);
            this.btnColorOpen.TabIndex = 1;
            this.btnColorOpen.Text = "ColorOpen";
            this.btnColorOpen.UseVisualStyleBackColor = true;
            this.btnColorOpen.Click += new System.EventHandler(this.btnColorOpen_Click);
            // 
            // lblHTMLCode
            // 
            this.lblHTMLCode.AutoSize = true;
            this.lblHTMLCode.Location = new System.Drawing.Point(12, 47);
            this.lblHTMLCode.Name = "lblHTMLCode";
            this.lblHTMLCode.Size = new System.Drawing.Size(98, 20);
            this.lblHTMLCode.TabIndex = 2;
            this.lblHTMLCode.Text = "HTML Code:";
            // 
            // txtHTMLCode
            // 
            this.txtHTMLCode.Location = new System.Drawing.Point(16, 69);
            this.txtHTMLCode.Name = "txtHTMLCode";
            this.txtHTMLCode.Size = new System.Drawing.Size(184, 26);
            this.txtHTMLCode.TabIndex = 3;
            // 
            // txtRGBCode
            // 
            this.txtRGBCode.Location = new System.Drawing.Point(16, 154);
            this.txtRGBCode.Name = "txtRGBCode";
            this.txtRGBCode.Size = new System.Drawing.Size(184, 26);
            this.txtRGBCode.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "RGB Code:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 237);
            this.Controls.Add(this.txtRGBCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHTMLCode);
            this.Controls.Add(this.lblHTMLCode);
            this.Controls.Add(this.btnColorOpen);
            this.Controls.Add(this.lblColorCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorPicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColorCode;
        private System.Windows.Forms.Button btnColorOpen;
        private System.Windows.Forms.ColorDialog cd;
        private System.Windows.Forms.Label lblHTMLCode;
        private System.Windows.Forms.TextBox txtHTMLCode;
        private System.Windows.Forms.TextBox txtRGBCode;
        private System.Windows.Forms.Label label1;
    }
}

