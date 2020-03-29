namespace UI
{
    partial class AngebotControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Box1 = new System.Windows.Forms.TextBox();
            this.Box2 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(19, 11);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(196, 135);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // Box1
            // 
            this.Box1.Location = new System.Drawing.Point(19, 153);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(100, 20);
            this.Box1.TabIndex = 1;
            // 
            // Box2
            // 
            this.Box2.Location = new System.Drawing.Point(157, 153);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(58, 20);
            this.Box2.TabIndex = 2;
            // 
            // AngebotControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.PictureBox);
            this.Name = "AngebotControl";
            this.Size = new System.Drawing.Size(243, 188);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TextBox Box1;
        private System.Windows.Forms.MaskedTextBox Box2;
    }
}
