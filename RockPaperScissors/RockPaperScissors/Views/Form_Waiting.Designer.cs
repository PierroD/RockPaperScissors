
namespace RockPaperScissors.Views
{
    partial class Form_Waiting
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
            this.lbl_youLose = new System.Windows.Forms.Label();
            this.pbox_lose = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_lose)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_youLose
            // 
            this.lbl_youLose.AutoSize = true;
            this.lbl_youLose.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_youLose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(101)))), ((int)(((byte)(162)))));
            this.lbl_youLose.Location = new System.Drawing.Point(99, 4);
            this.lbl_youLose.Name = "lbl_youLose";
            this.lbl_youLose.Size = new System.Drawing.Size(119, 32);
            this.lbl_youLose.TabIndex = 4;
            this.lbl_youLose.Text = "WAIT . . . ";
            // 
            // pbox_lose
            // 
            this.pbox_lose.BackColor = System.Drawing.Color.White;
            this.pbox_lose.Image = global::RockPaperScissors.Properties.Resources.animation_500_klxzz8np;
            this.pbox_lose.Location = new System.Drawing.Point(-1, 30);
            this.pbox_lose.Name = "pbox_lose";
            this.pbox_lose.ShadowDecoration.Parent = this.pbox_lose;
            this.pbox_lose.Size = new System.Drawing.Size(323, 166);
            this.pbox_lose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_lose.TabIndex = 3;
            this.pbox_lose.TabStop = false;
            // 
            // Form_Waiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 200);
            this.Controls.Add(this.lbl_youLose);
            this.Controls.Add(this.pbox_lose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Waiting";
            this.Text = "Form_Waiting";
            ((System.ComponentModel.ISupportInitialize)(this.pbox_lose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_youLose;
        private Guna.UI2.WinForms.Guna2PictureBox pbox_lose;
    }
}