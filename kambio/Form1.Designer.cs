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
            this.buttonTakeFresh = new System.Windows.Forms.Button();
            this.listBoxStand = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonDoAction = new System.Windows.Forms.Button();
            this.labelWatch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxFrsehCards
            // 
            this.listBoxFrsehCards.FormattingEnabled = true;
            this.listBoxFrsehCards.ItemHeight = 20;
            this.listBoxFrsehCards.Location = new System.Drawing.Point(18, 18);
            this.listBoxFrsehCards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxFrsehCards.Name = "listBoxFrsehCards";
            this.listBoxFrsehCards.Size = new System.Drawing.Size(133, 1084);
            this.listBoxFrsehCards.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 1102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Set game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBoxPlayer1
            // 
            this.listBoxPlayer1.FormattingEnabled = true;
            this.listBoxPlayer1.ItemHeight = 20;
            this.listBoxPlayer1.Location = new System.Drawing.Point(417, 770);
            this.listBoxPlayer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxPlayer1.Name = "listBoxPlayer1";
            this.listBoxPlayer1.Size = new System.Drawing.Size(178, 144);
            this.listBoxPlayer1.TabIndex = 8;
            // 
            // listBoxPlayer2
            // 
            this.listBoxPlayer2.FormattingEnabled = true;
            this.listBoxPlayer2.ItemHeight = 20;
            this.listBoxPlayer2.Location = new System.Drawing.Point(430, 37);
            this.listBoxPlayer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxPlayer2.Name = "listBoxPlayer2";
            this.listBoxPlayer2.Size = new System.Drawing.Size(178, 144);
            this.listBoxPlayer2.TabIndex = 9;
            // 
            // listBoxDropped
            // 
            this.listBoxDropped.FormattingEnabled = true;
            this.listBoxDropped.ItemHeight = 20;
            this.listBoxDropped.Location = new System.Drawing.Point(858, 35);
            this.listBoxDropped.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxDropped.Name = "listBoxDropped";
            this.listBoxDropped.Size = new System.Drawing.Size(178, 1044);
            this.listBoxDropped.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(633, 429);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 111);
            this.button2.TabIndex = 11;
            this.button2.Text = "Take card from dropped >>>\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonTakeFresh
            // 
            this.buttonTakeFresh.Location = new System.Drawing.Point(198, 429);
            this.buttonTakeFresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTakeFresh.Name = "buttonTakeFresh";
            this.buttonTakeFresh.Size = new System.Drawing.Size(201, 111);
            this.buttonTakeFresh.TabIndex = 12;
            this.buttonTakeFresh.Text = "Take card From Fresh <<<<<<<<<";
            this.buttonTakeFresh.UseVisualStyleBackColor = true;
            this.buttonTakeFresh.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBoxStand
            // 
            this.listBoxStand.FormattingEnabled = true;
            this.listBoxStand.ItemHeight = 20;
            this.listBoxStand.Location = new System.Drawing.Point(417, 449);
            this.listBoxStand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxStand.Name = "listBoxStand";
            this.listBoxStand.Size = new System.Drawing.Size(178, 44);
            this.listBoxStand.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 425);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Stand card";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(417, 506);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 35);
            this.button4.TabIndex = 15;
            this.button4.Text = "drop";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(417, 551);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 35);
            this.button5.TabIndex = 16;
            this.button5.Text = "swap";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonDoAction
            // 
            this.buttonDoAction.Location = new System.Drawing.Point(417, 595);
            this.buttonDoAction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDoAction.Name = "buttonDoAction";
            this.buttonDoAction.Size = new System.Drawing.Size(112, 35);
            this.buttonDoAction.TabIndex = 17;
            this.buttonDoAction.Text = "do action";
            this.buttonDoAction.UseVisualStyleBackColor = true;
            this.buttonDoAction.Click += new System.EventHandler(this.buttonDoAction_Click);
            // 
            // labelWatch
            // 
            this.labelWatch.AutoSize = true;
            this.labelWatch.Location = new System.Drawing.Point(447, 277);
            this.labelWatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWatch.Name = "labelWatch";
            this.labelWatch.Size = new System.Drawing.Size(51, 20);
            this.labelWatch.TabIndex = 19;
            this.labelWatch.Text = "watch";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 1050);
            this.Controls.Add(this.labelWatch);
            this.Controls.Add(this.buttonDoAction);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxStand);
            this.Controls.Add(this.buttonTakeFresh);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBoxDropped);
            this.Controls.Add(this.listBoxPlayer2);
            this.Controls.Add(this.listBoxPlayer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxFrsehCards);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button buttonTakeFresh;
        private System.Windows.Forms.ListBox listBoxStand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonDoAction;
        private System.Windows.Forms.Label labelWatch;
    }
}

