namespace SampleFIP
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
            this.LISA_Label = new System.Windows.Forms.Label();
            this.Label_401k = new System.Windows.Forms.Label();
            this.IPA_label = new System.Windows.Forms.Label();
            this.PercLISA_TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CrtPtflio_Btn = new System.Windows.Forms.Button();
            this.Perc401k_TB = new System.Windows.Forms.TextBox();
            this.PercIP_TB = new System.Windows.Forms.TextBox();
            this.Salary_TB = new System.Windows.Forms.TextBox();
            this.AvailBal_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LISA_Label
            // 
            this.LISA_Label.AutoSize = true;
            this.LISA_Label.Location = new System.Drawing.Point(27, 244);
            this.LISA_Label.Name = "LISA_Label";
            this.LISA_Label.Size = new System.Drawing.Size(84, 13);
            this.LISA_Label.TabIndex = 29;
            this.LISA_Label.Text = "L.I.S.A. Amount:";
            // 
            // Label_401k
            // 
            this.Label_401k.AutoSize = true;
            this.Label_401k.Location = new System.Drawing.Point(38, 220);
            this.Label_401k.Name = "Label_401k";
            this.Label_401k.Size = new System.Drawing.Size(73, 13);
            this.Label_401k.TabIndex = 28;
            this.Label_401k.Text = "401k Amount:";
            // 
            // IPA_label
            // 
            this.IPA_label.AutoSize = true;
            this.IPA_label.Location = new System.Drawing.Point(52, 197);
            this.IPA_label.Name = "IPA_label";
            this.IPA_label.Size = new System.Drawing.Size(59, 13);
            this.IPA_label.TabIndex = 27;
            this.IPA_label.Text = "IP Amount:";
            // 
            // PercLISA_TB
            // 
            this.PercLISA_TB.Location = new System.Drawing.Point(139, 114);
            this.PercLISA_TB.Name = "PercLISA_TB";
            this.PercLISA_TB.Size = new System.Drawing.Size(100, 20);
            this.PercLISA_TB.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Percent to L.I.S.A.";
            // 
            // CrtPtflio_Btn
            // 
            this.CrtPtflio_Btn.Location = new System.Drawing.Point(141, 292);
            this.CrtPtflio_Btn.Name = "CrtPtflio_Btn";
            this.CrtPtflio_Btn.Size = new System.Drawing.Size(131, 23);
            this.CrtPtflio_Btn.TabIndex = 24;
            this.CrtPtflio_Btn.Text = "Create Portfolio";
            this.CrtPtflio_Btn.UseVisualStyleBackColor = true;
            this.CrtPtflio_Btn.Click += new System.EventHandler(this.CrtPtflio_Btn_Click);
            // 
            // Perc401k_TB
            // 
            this.Perc401k_TB.Location = new System.Drawing.Point(139, 88);
            this.Perc401k_TB.Name = "Perc401k_TB";
            this.Perc401k_TB.Size = new System.Drawing.Size(100, 20);
            this.Perc401k_TB.TabIndex = 23;
            // 
            // PercIP_TB
            // 
            this.PercIP_TB.Location = new System.Drawing.Point(139, 62);
            this.PercIP_TB.Name = "PercIP_TB";
            this.PercIP_TB.Size = new System.Drawing.Size(100, 20);
            this.PercIP_TB.TabIndex = 22;
            // 
            // Salary_TB
            // 
            this.Salary_TB.Location = new System.Drawing.Point(139, 36);
            this.Salary_TB.Name = "Salary_TB";
            this.Salary_TB.Size = new System.Drawing.Size(100, 20);
            this.Salary_TB.TabIndex = 21;
            // 
            // AvailBal_TB
            // 
            this.AvailBal_TB.Location = new System.Drawing.Point(139, 10);
            this.AvailBal_TB.Name = "AvailBal_TB";
            this.AvailBal_TB.Size = new System.Drawing.Size(100, 20);
            this.AvailBal_TB.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Percent to 401K";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Percent to IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Salary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Available balance";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Percent to Amount";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 327);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LISA_Label);
            this.Controls.Add(this.Label_401k);
            this.Controls.Add(this.IPA_label);
            this.Controls.Add(this.PercLISA_TB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CrtPtflio_Btn);
            this.Controls.Add(this.Perc401k_TB);
            this.Controls.Add(this.PercIP_TB);
            this.Controls.Add(this.Salary_TB);
            this.Controls.Add(this.AvailBal_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LISA_Label;
        private System.Windows.Forms.Label Label_401k;
        private System.Windows.Forms.Label IPA_label;
        private System.Windows.Forms.TextBox PercLISA_TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CrtPtflio_Btn;
        private System.Windows.Forms.TextBox Perc401k_TB;
        private System.Windows.Forms.TextBox PercIP_TB;
        private System.Windows.Forms.TextBox Salary_TB;
        private System.Windows.Forms.TextBox AvailBal_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

