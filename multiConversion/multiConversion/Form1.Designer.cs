namespace multiConversion
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
            this.rdbInchToFeet = new System.Windows.Forms.RadioButton();
            this.rdbPoundToEuro = new System.Windows.Forms.RadioButton();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.lblConversion = new System.Windows.Forms.Label();
            this.lblType2 = new System.Windows.Forms.Label();
            this.lblType1 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.rdbCtoF = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rdbInchToFeet
            // 
            this.rdbInchToFeet.AutoSize = true;
            this.rdbInchToFeet.Location = new System.Drawing.Point(64, 12);
            this.rdbInchToFeet.Name = "rdbInchToFeet";
            this.rdbInchToFeet.Size = new System.Drawing.Size(31, 17);
            this.rdbInchToFeet.TabIndex = 0;
            this.rdbInchToFeet.Text = "1";
            this.rdbInchToFeet.UseVisualStyleBackColor = true;
            this.rdbInchToFeet.CheckedChanged += new System.EventHandler(this.rdbInchToFeet_CheckedChanged);
            // 
            // rdbPoundToEuro
            // 
            this.rdbPoundToEuro.AutoSize = true;
            this.rdbPoundToEuro.Location = new System.Drawing.Point(220, 12);
            this.rdbPoundToEuro.Name = "rdbPoundToEuro";
            this.rdbPoundToEuro.Size = new System.Drawing.Size(31, 17);
            this.rdbPoundToEuro.TabIndex = 1;
            this.rdbPoundToEuro.Text = "2";
            this.rdbPoundToEuro.UseVisualStyleBackColor = true;
            this.rdbPoundToEuro.CheckedChanged += new System.EventHandler(this.rdbPoundToEuro_CheckedChanged);
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(12, 125);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(125, 20);
            this.txtUserInput.TabIndex = 3;
            this.txtUserInput.Text = "0.0";
            this.txtUserInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserInput.TextChanged += new System.EventHandler(this.txtUserInput_TextChanged);
            this.txtUserInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserInput_KeyPress);
            // 
            // lblConversion
            // 
            this.lblConversion.AutoSize = true;
            this.lblConversion.Location = new System.Drawing.Point(190, 47);
            this.lblConversion.Name = "lblConversion";
            this.lblConversion.Size = new System.Drawing.Size(92, 13);
            this.lblConversion.TabIndex = 4;
            this.lblConversion.Text = "Pick a conversion";
            this.lblConversion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblType2
            // 
            this.lblType2.AutoSize = true;
            this.lblType2.Location = new System.Drawing.Point(374, 92);
            this.lblType2.Name = "lblType2";
            this.lblType2.Size = new System.Drawing.Size(0, 13);
            this.lblType2.TabIndex = 5;
            // 
            // lblType1
            // 
            this.lblType1.AutoSize = true;
            this.lblType1.Location = new System.Drawing.Point(12, 92);
            this.lblType1.Name = "lblType1";
            this.lblType1.Size = new System.Drawing.Size(0, 13);
            this.lblType1.TabIndex = 6;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(374, 128);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer.TabIndex = 7;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(207, 122);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // rdbCtoF
            // 
            this.rdbCtoF.AutoSize = true;
            this.rdbCtoF.Location = new System.Drawing.Point(377, 12);
            this.rdbCtoF.Name = "rdbCtoF";
            this.rdbCtoF.Size = new System.Drawing.Size(31, 17);
            this.rdbCtoF.TabIndex = 9;
            this.rdbCtoF.TabStop = true;
            this.rdbCtoF.Text = "3";
            this.rdbCtoF.UseVisualStyleBackColor = true;
            this.rdbCtoF.CheckedChanged += new System.EventHandler(this.rdbCtoF_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 195);
            this.Controls.Add(this.rdbCtoF);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblType1);
            this.Controls.Add(this.lblType2);
            this.Controls.Add(this.lblConversion);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.rdbPoundToEuro);
            this.Controls.Add(this.rdbInchToFeet);
            this.Name = "Form1";
            this.Text = "Multi Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbInchToFeet;
        private System.Windows.Forms.RadioButton rdbPoundToEuro;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Label lblConversion;
        private System.Windows.Forms.Label lblType2;
        private System.Windows.Forms.Label lblType1;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RadioButton rdbCtoF;
    }
}

