namespace kambio
{
    partial class RoomsMenu
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
            this.listBoxRooms = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEnterRoom = new System.Windows.Forms.Button();
            this.buttonCreateNewRoom = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxRooms
            // 
            this.listBoxRooms.FormattingEnabled = true;
            this.listBoxRooms.ItemHeight = 20;
            this.listBoxRooms.Location = new System.Drawing.Point(70, 178);
            this.listBoxRooms.Name = "listBoxRooms";
            this.listBoxRooms.Size = new System.Drawing.Size(256, 284);
            this.listBoxRooms.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(151, 31);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(149, 29);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "[User Name]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecet Room";
            // 
            // buttonEnterRoom
            // 
            this.buttonEnterRoom.Location = new System.Drawing.Point(70, 468);
            this.buttonEnterRoom.Name = "buttonEnterRoom";
            this.buttonEnterRoom.Size = new System.Drawing.Size(256, 65);
            this.buttonEnterRoom.TabIndex = 4;
            this.buttonEnterRoom.Text = "ENTER";
            this.buttonEnterRoom.UseVisualStyleBackColor = true;
            // 
            // buttonCreateNewRoom
            // 
            this.buttonCreateNewRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateNewRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonCreateNewRoom.Location = new System.Drawing.Point(268, 126);
            this.buttonCreateNewRoom.Name = "buttonCreateNewRoom";
            this.buttonCreateNewRoom.Size = new System.Drawing.Size(58, 49);
            this.buttonCreateNewRoom.TabIndex = 5;
            this.buttonCreateNewRoom.Text = "+";
            this.buttonCreateNewRoom.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(456, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 304);
            this.listBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(522, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Active users";
            // 
            // RoomsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 556);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonCreateNewRoom);
            this.Controls.Add(this.buttonEnterRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxRooms);
            this.Name = "RoomsMenu";
            this.Text = "RoomsMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEnterRoom;
        private System.Windows.Forms.Button buttonCreateNewRoom;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
    }
}