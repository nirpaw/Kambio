namespace kambio
{
    partial class Settings
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxp1 = new System.Windows.Forms.TextBox();
            this.textBoxp2 = new System.Windows.Forms.TextBox();
            this.textBoxp4 = new System.Windows.Forms.TextBox();
            this.textBoxp3 = new System.Windows.Forms.TextBox();
            this.button_play = new System.Windows.Forms.Button();
            this.checkBoxp3 = new System.Windows.Forms.CheckBox();
            this.checkBoxp4 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player one";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player tree";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Player two";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Player four";
            // 
            // textBoxp1
            // 
            this.textBoxp1.Location = new System.Drawing.Point(108, 10);
            this.textBoxp1.Name = "textBoxp1";
            this.textBoxp1.Size = new System.Drawing.Size(100, 20);
            this.textBoxp1.TabIndex = 4;
            // 
            // textBoxp2
            // 
            this.textBoxp2.Location = new System.Drawing.Point(107, 49);
            this.textBoxp2.Name = "textBoxp2";
            this.textBoxp2.Size = new System.Drawing.Size(100, 20);
            this.textBoxp2.TabIndex = 5;
            // 
            // textBoxp4
            // 
            this.textBoxp4.Enabled = false;
            this.textBoxp4.Location = new System.Drawing.Point(108, 127);
            this.textBoxp4.Name = "textBoxp4";
            this.textBoxp4.Size = new System.Drawing.Size(100, 20);
            this.textBoxp4.TabIndex = 7;
            // 
            // textBoxp3
            // 
            this.textBoxp3.Enabled = false;
            this.textBoxp3.Location = new System.Drawing.Point(108, 89);
            this.textBoxp3.Name = "textBoxp3";
            this.textBoxp3.Size = new System.Drawing.Size(100, 20);
            this.textBoxp3.TabIndex = 6;
            this.textBoxp3.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(299, 156);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(75, 23);
            this.button_play.TabIndex = 8;
            this.button_play.Text = "Play";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // checkBoxp3
            // 
            this.checkBoxp3.AutoSize = true;
            this.checkBoxp3.Location = new System.Drawing.Point(215, 92);
            this.checkBoxp3.Name = "checkBoxp3";
            this.checkBoxp3.Size = new System.Drawing.Size(15, 14);
            this.checkBoxp3.TabIndex = 9;
            this.checkBoxp3.UseVisualStyleBackColor = true;
            this.checkBoxp3.CheckedChanged += new System.EventHandler(this.checkBoxp3_CheckedChanged);
            // 
            // checkBoxp4
            // 
            this.checkBoxp4.AutoSize = true;
            this.checkBoxp4.Location = new System.Drawing.Point(215, 130);
            this.checkBoxp4.Name = "checkBoxp4";
            this.checkBoxp4.Size = new System.Drawing.Size(15, 14);
            this.checkBoxp4.TabIndex = 10;
            this.checkBoxp4.UseVisualStyleBackColor = true;
            this.checkBoxp4.CheckedChanged += new System.EventHandler(this.checkBoxp4_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 195);
            this.Controls.Add(this.checkBoxp4);
            this.Controls.Add(this.checkBoxp3);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.textBoxp4);
            this.Controls.Add(this.textBoxp3);
            this.Controls.Add(this.textBoxp2);
            this.Controls.Add(this.textBoxp1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxp1;
        private System.Windows.Forms.TextBox textBoxp2;
        private System.Windows.Forms.TextBox textBoxp4;
        private System.Windows.Forms.TextBox textBoxp3;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.CheckBox checkBoxp3;
        private System.Windows.Forms.CheckBox checkBoxp4;
    }
}