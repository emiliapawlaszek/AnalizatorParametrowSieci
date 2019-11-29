namespace Modbus
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
            this.label4 = new System.Windows.Forms.Label();
            this.polaczonoLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.adresIP = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.napiecieBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.natezenieBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tresbledu = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stan połączenia:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // polaczonoLabel
            // 
            this.polaczonoLabel.AutoSize = true;
            this.polaczonoLabel.ForeColor = System.Drawing.Color.Red;
            this.polaczonoLabel.Location = new System.Drawing.Point(107, 14);
            this.polaczonoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.polaczonoLabel.Name = "polaczonoLabel";
            this.polaczonoLabel.Size = new System.Drawing.Size(93, 13);
            this.polaczonoLabel.TabIndex = 10;
            this.polaczonoLabel.Text = "NIEPOŁĄCZONO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Połącz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Adres IP";
            // 
            // adresIP
            // 
            this.adresIP.Location = new System.Drawing.Point(90, 40);
            this.adresIP.Margin = new System.Windows.Forms.Padding(2);
            this.adresIP.Name = "adresIP";
            this.adresIP.Size = new System.Drawing.Size(93, 20);
            this.adresIP.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.napiecieBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.natezenieBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(8, 90);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 101);
            this.panel2.TabIndex = 14;
            this.panel2.Visible = false;
            // 
            // napiecieBox
            // 
            this.napiecieBox.Enabled = false;
            this.napiecieBox.Location = new System.Drawing.Point(82, 3);
            this.napiecieBox.Name = "napiecieBox";
            this.napiecieBox.Size = new System.Drawing.Size(93, 20);
            this.napiecieBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Napięcie [V]";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // natezenieBox
            // 
            this.natezenieBox.BackColor = System.Drawing.SystemColors.Window;
            this.natezenieBox.Enabled = false;
            this.natezenieBox.Location = new System.Drawing.Point(82, 38);
            this.natezenieBox.Name = "natezenieBox";
            this.natezenieBox.Size = new System.Drawing.Size(93, 20);
            this.natezenieBox.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Natężenie [A]";
            this.label8.Click += new System.EventHandler(this.label2_Click);
            // 
            // tresbledu
            // 
            this.tresbledu.AutoSize = true;
            this.tresbledu.Location = new System.Drawing.Point(9, 147);
            this.tresbledu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tresbledu.Name = "tresbledu";
            this.tresbledu.Size = new System.Drawing.Size(35, 13);
            this.tresbledu.TabIndex = 15;
            this.tresbledu.Text = "label1";
            this.tresbledu.Visible = false;
            this.tresbledu.Click += new System.EventHandler(this.tresbledu_Click);
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(90, 66);
            this.portBox.Margin = new System.Windows.Forms.Padding(2);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(93, 20);
            this.portBox.TabIndex = 17;
            this.portBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Port";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 215);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tresbledu);
            this.Controls.Add(this.adresIP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.polaczonoLabel);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Monitoring sieci";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label polaczonoLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adresIP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox napiecieBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox natezenieBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label tresbledu;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.Label label1;
    }
}

