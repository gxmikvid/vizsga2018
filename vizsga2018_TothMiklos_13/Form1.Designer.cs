namespace vizsga2018_TothMiklos_13
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
            this.btnContainer = new System.Windows.Forms.Panel();
            this.titleKep = new System.Windows.Forms.PictureBox();
            this.left = new System.Windows.Forms.PictureBox();
            this.right = new System.Windows.Forms.PictureBox();
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.titleKep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContainer
            // 
            this.btnContainer.Location = new System.Drawing.Point(223, 1);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.Size = new System.Drawing.Size(576, 338);
            this.btnContainer.TabIndex = 0;
            // 
            // titleKep
            // 
            this.titleKep.Location = new System.Drawing.Point(56, 33);
            this.titleKep.Name = "titleKep";
            this.titleKep.Size = new System.Drawing.Size(100, 142);
            this.titleKep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.titleKep.TabIndex = 1;
            this.titleKep.TabStop = false;
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(306, 387);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(67, 36);
            this.left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.left.TabIndex = 2;
            this.left.TabStop = false;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(444, 387);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(67, 36);
            this.right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.right.TabIndex = 3;
            this.right.TabStop = false;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(68, 316);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Mentés";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.titleKep);
            this.Controls.Add(this.btnContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.titleKep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btnContainer;
        private System.Windows.Forms.PictureBox titleKep;
        private System.Windows.Forms.PictureBox left;
        private System.Windows.Forms.PictureBox right;
        private System.Windows.Forms.Button saveBtn;
    }
}

