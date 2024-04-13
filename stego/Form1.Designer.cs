namespace stego
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxOpenFile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCapacity = new System.Windows.Forms.TextBox();
            this.textBoxPSNR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMSE = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(167, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxOpenFile
            // 
            this.textBoxOpenFile.Location = new System.Drawing.Point(268, 250);
            this.textBoxOpenFile.Name = "textBoxOpenFile";
            this.textBoxOpenFile.Size = new System.Drawing.Size(194, 20);
            this.textBoxOpenFile.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(268, 297);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(194, 20);
            this.textBoxMessage.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(167, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mesaj:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "Encode Lineer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(145, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 45);
            this.button3.TabIndex = 8;
            this.button3.Text = "Decode Lineer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(191, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Capacity:";
            // 
            // textBoxCapacity
            // 
            this.textBoxCapacity.Location = new System.Drawing.Point(263, 451);
            this.textBoxCapacity.Name = "textBoxCapacity";
            this.textBoxCapacity.Size = new System.Drawing.Size(80, 20);
            this.textBoxCapacity.TabIndex = 17;
            // 
            // textBoxPSNR
            // 
            this.textBoxPSNR.Location = new System.Drawing.Point(84, 509);
            this.textBoxPSNR.Name = "textBoxPSNR";
            this.textBoxPSNR.Size = new System.Drawing.Size(79, 20);
            this.textBoxPSNR.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "PSNR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "MSE:";
            // 
            // textBoxMSE
            // 
            this.textBoxMSE.Location = new System.Drawing.Point(84, 450);
            this.textBoxMSE.Name = "textBoxMSE";
            this.textBoxMSE.Size = new System.Drawing.Size(79, 20);
            this.textBoxMSE.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(496, 347);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 45);
            this.button4.TabIndex = 19;
            this.button4.Text = "Decode Random";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(374, 347);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 45);
            this.button5.TabIndex = 20;
            this.button5.Text = "Encode Random";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 579);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCapacity);
            this.Controls.Add(this.textBoxPSNR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMSE);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOpenFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxOpenFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCapacity;
        private System.Windows.Forms.TextBox textBoxPSNR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMSE;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

