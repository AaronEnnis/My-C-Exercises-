namespace menu
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblConversion = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblType2 = new System.Windows.Forms.Label();
            this.lblType1 = new System.Windows.Forms.Label();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnIncheToFeet = new System.Windows.Forms.Button();
            this.btnPoundToEuro = new System.Windows.Forms.Button();
            this.btnCtoF = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incheToFeetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poundToEuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(193, 166);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Visible = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(193, 96);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Visible = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblConversion
            // 
            this.lblConversion.AutoSize = true;
            this.lblConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversion.Location = new System.Drawing.Point(42, 9);
            this.lblConversion.Name = "lblConversion";
            this.lblConversion.Size = new System.Drawing.Size(246, 16);
            this.lblConversion.TabIndex = 2;
            this.lblConversion.Text = "Pick the conversion you want to do";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(399, 99);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Visible = false;
            // 
            // lblType2
            // 
            this.lblType2.AutoSize = true;
            this.lblType2.Location = new System.Drawing.Point(399, 60);
            this.lblType2.Name = "lblType2";
            this.lblType2.Size = new System.Drawing.Size(0, 13);
            this.lblType2.TabIndex = 4;
            this.lblType2.Visible = false;
            // 
            // lblType1
            // 
            this.lblType1.AutoSize = true;
            this.lblType1.Location = new System.Drawing.Point(16, 60);
            this.lblType1.Name = "lblType1";
            this.lblType1.Size = new System.Drawing.Size(0, 13);
            this.lblType1.TabIndex = 5;
            this.lblType1.Visible = false;
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(19, 99);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(132, 20);
            this.txtUserInput.TabIndex = 6;
            this.txtUserInput.Text = "0.0";
            this.txtUserInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserInput.Visible = false;
            this.txtUserInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserInput_KeyPress);
            // 
            // btnIncheToFeet
            // 
            this.btnIncheToFeet.Location = new System.Drawing.Point(45, 55);
            this.btnIncheToFeet.Name = "btnIncheToFeet";
            this.btnIncheToFeet.Size = new System.Drawing.Size(106, 23);
            this.btnIncheToFeet.TabIndex = 7;
            this.btnIncheToFeet.Text = "Inches to Feet";
            this.btnIncheToFeet.UseVisualStyleBackColor = true;
            this.btnIncheToFeet.Click += new System.EventHandler(this.btnIncheToFeet_Click);
            // 
            // btnPoundToEuro
            // 
            this.btnPoundToEuro.Location = new System.Drawing.Point(207, 55);
            this.btnPoundToEuro.Name = "btnPoundToEuro";
            this.btnPoundToEuro.Size = new System.Drawing.Size(106, 23);
            this.btnPoundToEuro.TabIndex = 9;
            this.btnPoundToEuro.Text = "Pound to Euro";
            this.btnPoundToEuro.UseVisualStyleBackColor = true;
            this.btnPoundToEuro.Click += new System.EventHandler(this.btnPoundToEuro_Click);
            // 
            // btnCtoF
            // 
            this.btnCtoF.Location = new System.Drawing.Point(374, 55);
            this.btnCtoF.Name = "btnCtoF";
            this.btnCtoF.Size = new System.Drawing.Size(121, 23);
            this.btnCtoF.TabIndex = 10;
            this.btnCtoF.Text = "Calcius to Fahrenheit";
            this.btnCtoF.UseVisualStyleBackColor = true;
            this.btnCtoF.Click += new System.EventHandler(this.btnCtoF_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(530, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incheToFeetToolStripMenuItem,
            this.poundToEuroToolStripMenuItem,
            this.cToFToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // incheToFeetToolStripMenuItem
            // 
            this.incheToFeetToolStripMenuItem.Name = "incheToFeetToolStripMenuItem";
            this.incheToFeetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.incheToFeetToolStripMenuItem.Text = "inche to feet";
            this.incheToFeetToolStripMenuItem.Click += new System.EventHandler(this.incheToFeetToolStripMenuItem_Click);
            // 
            // poundToEuroToolStripMenuItem
            // 
            this.poundToEuroToolStripMenuItem.Name = "poundToEuroToolStripMenuItem";
            this.poundToEuroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.poundToEuroToolStripMenuItem.Text = "pound to euro";
            // 
            // cToFToolStripMenuItem
            // 
            this.cToFToolStripMenuItem.Name = "cToFToolStripMenuItem";
            this.cToFToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cToFToolStripMenuItem.Text = "c to f";
            this.cToFToolStripMenuItem.Click += new System.EventHandler(this.cToFToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 213);
            this.Controls.Add(this.btnCtoF);
            this.Controls.Add(this.btnPoundToEuro);
            this.Controls.Add(this.btnIncheToFeet);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.lblType1);
            this.Controls.Add(this.lblType2);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblConversion);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblConversion;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblType2;
        private System.Windows.Forms.Label lblType1;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnIncheToFeet;
        private System.Windows.Forms.Button btnPoundToEuro;
        private System.Windows.Forms.Button btnCtoF;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incheToFeetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poundToEuroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToFToolStripMenuItem;
    }
}

