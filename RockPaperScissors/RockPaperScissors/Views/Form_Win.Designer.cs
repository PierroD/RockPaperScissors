
namespace RockPaperScissors.Views
{
    partial class Form_Win
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
            this.pbox_win = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbl_youLose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_win)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_win
            // 
            this.pbox_win.Image = global::RockPaperScissors.Properties.Resources.animation_500_klxv0vid;
            this.pbox_win.Location = new System.Drawing.Point(-1, 32);
            this.pbox_win.Name = "pbox_win";
            this.pbox_win.ShadowDecoration.Parent = this.pbox_win;
            this.pbox_win.Size = new System.Drawing.Size(323, 166);
            this.pbox_win.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_win.TabIndex = 0;
            this.pbox_win.TabStop = false;
            // 
            // lbl_youLose
            // 
            this.lbl_youLose.AutoSize = true;
            this.lbl_youLose.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_youLose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lbl_youLose.Location = new System.Drawing.Point(96, 9);
            this.lbl_youLose.Name = "lbl_youLose";
            this.lbl_youLose.Size = new System.Drawing.Size(118, 32);
            this.lbl_youLose.TabIndex = 3;
            this.lbl_youLose.Text = "YOU WIN";
            // 
            // Form_Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 200);
            this.Controls.Add(this.lbl_youLose);
            this.Controls.Add(this.pbox_win);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Win";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Win";
            this.Shown += new System.EventHandler(this.Form_Win_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_win)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pbox_win;
        private System.Windows.Forms.Label lbl_youLose;
    }
}