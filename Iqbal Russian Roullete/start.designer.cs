namespace iqbal_russian
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
            this.label1 = new System.Windows.Forms.Label();
            this.play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Russian Roullete";
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.DarkBlue;
            this.play.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.Color.Snow;
            this.play.Location = new System.Drawing.Point(407, 51);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(347, 180);
            this.play.TabIndex = 1;
            this.play.Text = "Go";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 301);
            this.Controls.Add(this.play);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button play;
    }
}

