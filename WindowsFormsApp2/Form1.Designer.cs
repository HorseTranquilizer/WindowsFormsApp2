namespace WindowsFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.James = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BadJames = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.James)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadJames)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "good";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // James
            // 
            this.James.Image = ((System.Drawing.Image)(resources.GetObject("James.Image")));
            this.James.Location = new System.Drawing.Point(407, 12);
            this.James.Name = "James";
            this.James.Size = new System.Drawing.Size(412, 440);
            this.James.TabIndex = 1;
            this.James.TabStop = false;
            this.James.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Bad";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BadJames
            // 
            this.BadJames.Image = ((System.Drawing.Image)(resources.GetObject("BadJames.Image")));
            this.BadJames.Location = new System.Drawing.Point(-7, 12);
            this.BadJames.Name = "BadJames";
            this.BadJames.Size = new System.Drawing.Size(408, 454);
            this.BadJames.TabIndex = 3;
            this.BadJames.TabStop = false;
            this.BadJames.Visible = false;
            this.BadJames.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BadJames);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.James);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.James)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadJames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox James;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox BadJames;
    }
}

