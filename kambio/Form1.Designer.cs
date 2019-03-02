namespace kambio
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
            this.listBoxFrsehCards = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxPlayer1 = new System.Windows.Forms.ListBox();
            this.listBoxPlayer2 = new System.Windows.Forms.ListBox();
            this.listBoxDropped = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBoxStand = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxFrsehCards
            // 
            this.listBoxFrsehCards.FormattingEnabled = true;
            this.listBoxFrsehCards.Location = new System.Drawing.Point(12, 12);
            this.listBoxFrsehCards.Name = "listBoxFrsehCards";
            this.listBoxFrsehCards.Size = new System.Drawing.Size(90, 706);
            this.listBoxFrsehCards.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 716);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Set game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBoxPlayer1
            // 
            this.listBoxPlayer1.FormattingEnabled = true;
            this.listBoxPlayer1.Location = new System.Drawing.Point(278, 598);
            this.listBoxPlayer1.Name = "listBoxPlayer1";
            this.listBoxPlayer1.Size = new System.Drawing.Size(120, 95);
            this.listBoxPlayer1.TabIndex = 8;
            // 
            // listBoxPlayer2
            // 
            this.listBoxPlayer2.FormattingEnabled = true;
            this.listBoxPlayer2.Location = new System.Drawing.Point(287, 24);
            this.listBoxPlayer2.Name = "listBoxPlayer2";
            this.listBoxPlayer2.Size = new System.Drawing.Size(120, 95);
            this.listBoxPlayer2.TabIndex = 9;
            // 
            // listBoxDropped
            // 
            this.listBoxDropped.FormattingEnabled = true;
            this.listBoxDropped.Location = new System.Drawing.Point(572, 23);
            this.listBoxDropped.Name = "listBoxDropped";
            this.listBoxDropped.Size = new System.Drawing.Size(120, 680);
            this.listBoxDropped.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(422, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 72);
            this.button2.TabIndex = 11;
            this.button2.Text = "Take card from dropped >>>\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(132, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 72);
            this.button3.TabIndex = 12;
            this.button3.Text = "Take card From Fresh <<<<<<<<<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBoxStand
            // 
            this.listBoxStand.FormattingEnabled = true;
            this.listBoxStand.Location = new System.Drawing.Point(278, 292);
            this.listBoxStand.Name = "listBoxStand";
            this.listBoxStand.Size = new System.Drawing.Size(120, 30);
            this.listBoxStand.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Stand card";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(278, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "drop";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(278, 358);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "swap";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(278, 387);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "do action";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 765);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxStand);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBoxDropped);
            this.Controls.Add(this.listBoxPlayer2);
            this.Controls.Add(this.listBoxPlayer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxFrsehCards);
            this.Name = "Form1";
            this.Text = "Kamboo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxFrsehCards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxPlayer1;
        private System.Windows.Forms.ListBox listBoxPlayer2;
        private System.Windows.Forms.ListBox listBoxDropped;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBoxStand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

