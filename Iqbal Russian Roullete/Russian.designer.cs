namespace iqbal_russian
{
    partial class Russian
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
            this.labelrussian = new System.Windows.Forms.Label();
            this.loderimage = new System.Windows.Forms.PictureBox();
            this.btnload = new System.Windows.Forms.Button();
            this.btnst = new System.Windows.Forms.Button();
            this.btnspin = new System.Windows.Forms.Button();
            this.btnshoot = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loderimage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelrussian
            // 
            this.labelrussian.AutoSize = true;
            this.labelrussian.Font = new System.Drawing.Font("Museo Sans For Dell", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrussian.ForeColor = System.Drawing.Color.Maroon;
            this.labelrussian.Location = new System.Drawing.Point(236, 24);
            this.labelrussian.Name = "labelrussian";
            this.labelrussian.Size = new System.Drawing.Size(281, 40);
            this.labelrussian.TabIndex = 0;
            this.labelrussian.Text = "Russian Roullete";
            // 
            // loderimage
            // 
            this.loderimage.Location = new System.Drawing.Point(44, 207);
            this.loderimage.Name = "loderimage";
            this.loderimage.Size = new System.Drawing.Size(693, 293);
            this.loderimage.TabIndex = 1;
            this.loderimage.TabStop = false;
            this.loderimage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnload
            // 
            this.btnload.BackColor = System.Drawing.Color.DarkOrange;
            this.btnload.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnload.Location = new System.Drawing.Point(44, 110);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(119, 55);
            this.btnload.TabIndex = 2;
            this.btnload.Text = "LOAD";
            this.btnload.UseVisualStyleBackColor = false;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btnst
            // 
            this.btnst.BackColor = System.Drawing.Color.DarkOrange;
            this.btnst.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnst.Location = new System.Drawing.Point(481, 110);
            this.btnst.Name = "btnst";
            this.btnst.Size = new System.Drawing.Size(256, 55);
            this.btnst.TabIndex = 3;
            this.btnst.Text = "SHOOT AWAY";
            this.btnst.UseVisualStyleBackColor = false;
            this.btnst.Click += new System.EventHandler(this.btnst_Click);
            // 
            // btnspin
            // 
            this.btnspin.BackColor = System.Drawing.Color.DarkOrange;
            this.btnspin.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnspin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnspin.Location = new System.Drawing.Point(187, 110);
            this.btnspin.Name = "btnspin";
            this.btnspin.Size = new System.Drawing.Size(117, 55);
            this.btnspin.TabIndex = 4;
            this.btnspin.Text = "SPIN";
            this.btnspin.UseVisualStyleBackColor = false;
            this.btnspin.Click += new System.EventHandler(this.btnspin_Click);
            // 
            // btnshoot
            // 
            this.btnshoot.BackColor = System.Drawing.Color.DarkOrange;
            this.btnshoot.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshoot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnshoot.Location = new System.Drawing.Point(333, 110);
            this.btnshoot.Name = "btnshoot";
            this.btnshoot.Size = new System.Drawing.Size(133, 55);
            this.btnshoot.TabIndex = 5;
            this.btnshoot.Text = "SHOOT";
            this.btnshoot.UseVisualStyleBackColor = false;
            this.btnshoot.Click += new System.EventHandler(this.btnshoot_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(568, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Play Again";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Russian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnshoot);
            this.Controls.Add(this.btnspin);
            this.Controls.Add(this.btnst);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.loderimage);
            this.Controls.Add(this.labelrussian);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Russian";
            this.Text = "Russian";
            ((System.ComponentModel.ISupportInitialize)(this.loderimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelrussian;
        private System.Windows.Forms.PictureBox loderimage;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnst;
        private System.Windows.Forms.Button btnspin;
        private System.Windows.Forms.Button btnshoot;
        private System.Windows.Forms.Button button1;
    }
}