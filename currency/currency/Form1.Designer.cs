namespace currency
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
            this.btnConvert1 = new System.Windows.Forms.Button();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnConvert2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.ckbEuro1 = new System.Windows.Forms.CheckBox();
            this.ckbSterling1 = new System.Windows.Forms.CheckBox();
            this.ckbDollars1 = new System.Windows.Forms.CheckBox();
            this.ckbEuro2 = new System.Windows.Forms.CheckBox();
            this.ckbSterling2 = new System.Windows.Forms.CheckBox();
            this.ckbDollars2 = new System.Windows.Forms.CheckBox();
            this.ckbEuro3 = new System.Windows.Forms.CheckBox();
            this.ckbSterling3 = new System.Windows.Forms.CheckBox();
            this.ckbDollars3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnConvert1
            // 
            this.btnConvert1.Location = new System.Drawing.Point(376, 94);
            this.btnConvert1.Name = "btnConvert1";
            this.btnConvert1.Size = new System.Drawing.Size(122, 23);
            this.btnConvert1.TabIndex = 6;
            this.btnConvert1.Text = "Convert";
            this.btnConvert1.UseVisualStyleBackColor = true;
            this.btnConvert1.Click += new System.EventHandler(this.btnConvert1_Click);
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(197, 96);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(143, 20);
            this.txtUserInput.TabIndex = 7;
            this.txtUserInput.Text = "0.0";
            this.txtUserInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserInput_KeyPress);
            // 
            // btnConvert2
            // 
            this.btnConvert2.Location = new System.Drawing.Point(376, 217);
            this.btnConvert2.Name = "btnConvert2";
            this.btnConvert2.Size = new System.Drawing.Size(122, 23);
            this.btnConvert2.TabIndex = 9;
            this.btnConvert2.Text = "Convert";
            this.btnConvert2.UseVisualStyleBackColor = true;
            this.btnConvert2.Click += new System.EventHandler(this.btnConvert2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(376, 339);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 23);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer1.Location = new System.Drawing.Point(48, 217);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(0, 16);
            this.lblAnswer1.TabIndex = 15;
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer2.Location = new System.Drawing.Point(48, 346);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(0, 16);
            this.lblAnswer2.TabIndex = 16;
            // 
            // ckbEuro1
            // 
            this.ckbEuro1.AutoSize = true;
            this.ckbEuro1.Location = new System.Drawing.Point(51, 35);
            this.ckbEuro1.Name = "ckbEuro1";
            this.ckbEuro1.Size = new System.Drawing.Size(48, 17);
            this.ckbEuro1.TabIndex = 17;
            this.ckbEuro1.Text = "Euro";
            this.ckbEuro1.UseVisualStyleBackColor = true;
            this.ckbEuro1.CheckedChanged += new System.EventHandler(this.ckbEuro1_CheckedChanged);
            // 
            // ckbSterling1
            // 
            this.ckbSterling1.AutoSize = true;
            this.ckbSterling1.Location = new System.Drawing.Point(222, 35);
            this.ckbSterling1.Name = "ckbSterling1";
            this.ckbSterling1.Size = new System.Drawing.Size(61, 17);
            this.ckbSterling1.TabIndex = 18;
            this.ckbSterling1.Text = "Sterling";
            this.ckbSterling1.UseVisualStyleBackColor = true;
            this.ckbSterling1.CheckedChanged += new System.EventHandler(this.ckbSterling1_CheckedChanged);
            // 
            // ckbDollars1
            // 
            this.ckbDollars1.AutoSize = true;
            this.ckbDollars1.Location = new System.Drawing.Point(398, 35);
            this.ckbDollars1.Name = "ckbDollars1";
            this.ckbDollars1.Size = new System.Drawing.Size(58, 17);
            this.ckbDollars1.TabIndex = 19;
            this.ckbDollars1.Text = "Dollars";
            this.ckbDollars1.UseVisualStyleBackColor = true;
            this.ckbDollars1.CheckedChanged += new System.EventHandler(this.ckbDollars1_CheckedChanged);
            // 
            // ckbEuro2
            // 
            this.ckbEuro2.AutoSize = true;
            this.ckbEuro2.Location = new System.Drawing.Point(51, 157);
            this.ckbEuro2.Name = "ckbEuro2";
            this.ckbEuro2.Size = new System.Drawing.Size(48, 17);
            this.ckbEuro2.TabIndex = 20;
            this.ckbEuro2.Text = "Euro";
            this.ckbEuro2.UseVisualStyleBackColor = true;
            this.ckbEuro2.CheckedChanged += new System.EventHandler(this.ckbEuro2_CheckedChanged);
            // 
            // ckbSterling2
            // 
            this.ckbSterling2.AutoSize = true;
            this.ckbSterling2.Location = new System.Drawing.Point(217, 157);
            this.ckbSterling2.Name = "ckbSterling2";
            this.ckbSterling2.Size = new System.Drawing.Size(61, 17);
            this.ckbSterling2.TabIndex = 21;
            this.ckbSterling2.Text = "Sterling";
            this.ckbSterling2.UseVisualStyleBackColor = true;
            this.ckbSterling2.CheckedChanged += new System.EventHandler(this.ckbSterling2_CheckedChanged);
            // 
            // ckbDollars2
            // 
            this.ckbDollars2.AutoSize = true;
            this.ckbDollars2.Location = new System.Drawing.Point(398, 157);
            this.ckbDollars2.Name = "ckbDollars2";
            this.ckbDollars2.Size = new System.Drawing.Size(58, 17);
            this.ckbDollars2.TabIndex = 22;
            this.ckbDollars2.Text = "Dollars";
            this.ckbDollars2.UseVisualStyleBackColor = true;
            this.ckbDollars2.CheckedChanged += new System.EventHandler(this.ckbDollars2_CheckedChanged);
            // 
            // ckbEuro3
            // 
            this.ckbEuro3.AutoSize = true;
            this.ckbEuro3.Location = new System.Drawing.Point(51, 283);
            this.ckbEuro3.Name = "ckbEuro3";
            this.ckbEuro3.Size = new System.Drawing.Size(48, 17);
            this.ckbEuro3.TabIndex = 23;
            this.ckbEuro3.Text = "Euro";
            this.ckbEuro3.UseVisualStyleBackColor = true;
            this.ckbEuro3.CheckedChanged += new System.EventHandler(this.ckbEuro3_CheckedChanged);
            // 
            // ckbSterling3
            // 
            this.ckbSterling3.AutoSize = true;
            this.ckbSterling3.Location = new System.Drawing.Point(222, 283);
            this.ckbSterling3.Name = "ckbSterling3";
            this.ckbSterling3.Size = new System.Drawing.Size(61, 17);
            this.ckbSterling3.TabIndex = 24;
            this.ckbSterling3.Text = "Sterling";
            this.ckbSterling3.UseVisualStyleBackColor = true;
            this.ckbSterling3.CheckedChanged += new System.EventHandler(this.ckbSterling3_CheckedChanged);
            // 
            // ckbDollars3
            // 
            this.ckbDollars3.AutoSize = true;
            this.ckbDollars3.Location = new System.Drawing.Point(398, 283);
            this.ckbDollars3.Name = "ckbDollars3";
            this.ckbDollars3.Size = new System.Drawing.Size(58, 17);
            this.ckbDollars3.TabIndex = 25;
            this.ckbDollars3.Text = "Dollars";
            this.ckbDollars3.UseVisualStyleBackColor = true;
            this.ckbDollars3.CheckedChanged += new System.EventHandler(this.ckbDollars3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 405);
            this.Controls.Add(this.ckbDollars3);
            this.Controls.Add(this.ckbSterling3);
            this.Controls.Add(this.ckbEuro3);
            this.Controls.Add(this.ckbDollars2);
            this.Controls.Add(this.ckbSterling2);
            this.Controls.Add(this.ckbEuro2);
            this.Controls.Add(this.ckbDollars1);
            this.Controls.Add(this.ckbSterling1);
            this.Controls.Add(this.ckbEuro1);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConvert2);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.btnConvert1);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConvert1;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnConvert2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.CheckBox ckbEuro1;
        private System.Windows.Forms.CheckBox ckbSterling1;
        private System.Windows.Forms.CheckBox ckbDollars1;
        private System.Windows.Forms.CheckBox ckbEuro2;
        private System.Windows.Forms.CheckBox ckbSterling2;
        private System.Windows.Forms.CheckBox ckbDollars2;
        private System.Windows.Forms.CheckBox ckbEuro3;
        private System.Windows.Forms.CheckBox ckbSterling3;
        private System.Windows.Forms.CheckBox ckbDollars3;
    }
}

