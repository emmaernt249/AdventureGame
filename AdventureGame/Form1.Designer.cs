namespace AdventureGame
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
            this.RedLabel = new System.Windows.Forms.Label();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.YellowLabel = new System.Windows.Forms.Label();
            this.sceneImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sceneImage)).BeginInit();
            this.SuspendLayout();
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RedLabel.Location = new System.Drawing.Point(26, 368);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(10, 13);
            this.RedLabel.TabIndex = 2;
            this.RedLabel.Text = ".";
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BlueLabel.Location = new System.Drawing.Point(139, 368);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(10, 13);
            this.BlueLabel.TabIndex = 3;
            this.BlueLabel.Text = ".";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.outputLabel.Location = new System.Drawing.Point(51, 13);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(10, 13);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = ".";
            // 
            // YellowLabel
            // 
            this.YellowLabel.AutoSize = true;
            this.YellowLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.YellowLabel.Location = new System.Drawing.Point(249, 368);
            this.YellowLabel.Name = "YellowLabel";
            this.YellowLabel.Size = new System.Drawing.Size(10, 13);
            this.YellowLabel.TabIndex = 7;
            this.YellowLabel.Text = ".";
            // 
            // sceneImage
            // 
            this.sceneImage.InitialImage = global::AdventureGame.Properties.Resources.jungle;
            this.sceneImage.Location = new System.Drawing.Point(83, 53);
            this.sceneImage.Name = "sceneImage";
            this.sceneImage.Size = new System.Drawing.Size(626, 300);
            this.sceneImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sceneImage.TabIndex = 4;
            this.sceneImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.YellowLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.sceneImage);
            this.Controls.Add(this.BlueLabel);
            this.Controls.Add(this.RedLabel);
            this.Name = "Form1";
            this.Text = "Lost in a Jungle";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.sceneImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.PictureBox sceneImage;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label YellowLabel;
    }
}

