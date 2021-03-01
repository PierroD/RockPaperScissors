
namespace RockPaperScissors
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
            this.components = new System.ComponentModel.Container();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pic_Rock = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pic_Paper = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pic_Scissors = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn_play = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_youChoose = new System.Windows.Forms.Label();
            this.lbl_choice = new System.Windows.Forms.Label();
            this.drag_form = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.lbl_connectionStatus = new System.Windows.Forms.Label();
            this.pnl_Matchmaking = new Guna.UI2.WinForms.Guna2Panel();
            this.timer_macthmaking = new System.Windows.Forms.Timer(this.components);
            this.pbar_loading = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lbl_lookingForPlayer = new System.Windows.Forms.Label();
            this.pnl_gameChoices = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Scissors)).BeginInit();
            this.pnl_Matchmaking.SuspendLayout();
            this.pnl_gameChoices.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(38, 21);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "RPS";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.FillColor = System.Drawing.Color.Transparent;
            this.btn_close.HoverState.Parent = this.btn_close;
            this.btn_close.IconColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(275, 1);
            this.btn_close.Name = "btn_close";
            this.btn_close.PressedColor = System.Drawing.Color.Red;
            this.btn_close.PressedDepth = 100;
            this.btn_close.ShadowDecoration.Parent = this.btn_close;
            this.btn_close.Size = new System.Drawing.Size(45, 29);
            this.btn_close.TabIndex = 1;
            // 
            // pic_Rock
            // 
            this.pic_Rock.BackColor = System.Drawing.Color.Transparent;
            this.pic_Rock.Image = global::RockPaperScissors.Properties.Resources.rock;
            this.pic_Rock.Location = new System.Drawing.Point(9, 15);
            this.pic_Rock.Name = "pic_Rock";
            this.pic_Rock.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pic_Rock.ShadowDecoration.Parent = this.pic_Rock;
            this.pic_Rock.Size = new System.Drawing.Size(70, 70);
            this.pic_Rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Rock.TabIndex = 2;
            this.pic_Rock.TabStop = false;
            this.pic_Rock.Click += new System.EventHandler(this.Choice_Click);
            // 
            // pic_Paper
            // 
            this.pic_Paper.BackColor = System.Drawing.Color.Transparent;
            this.pic_Paper.Image = global::RockPaperScissors.Properties.Resources.paper;
            this.pic_Paper.Location = new System.Drawing.Point(115, 15);
            this.pic_Paper.Name = "pic_Paper";
            this.pic_Paper.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pic_Paper.ShadowDecoration.Parent = this.pic_Paper;
            this.pic_Paper.Size = new System.Drawing.Size(70, 70);
            this.pic_Paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Paper.TabIndex = 3;
            this.pic_Paper.TabStop = false;
            this.pic_Paper.Click += new System.EventHandler(this.Choice_Click);
            // 
            // pic_Scissors
            // 
            this.pic_Scissors.BackColor = System.Drawing.Color.Transparent;
            this.pic_Scissors.Image = global::RockPaperScissors.Properties.Resources.scissors;
            this.pic_Scissors.Location = new System.Drawing.Point(221, 15);
            this.pic_Scissors.Name = "pic_Scissors";
            this.pic_Scissors.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pic_Scissors.ShadowDecoration.Parent = this.pic_Scissors;
            this.pic_Scissors.Size = new System.Drawing.Size(70, 70);
            this.pic_Scissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Scissors.TabIndex = 4;
            this.pic_Scissors.TabStop = false;
            this.pic_Scissors.Click += new System.EventHandler(this.Choice_Click);
            // 
            // btn_play
            // 
            this.btn_play.BorderRadius = 5;
            this.btn_play.CheckedState.Parent = this.btn_play;
            this.btn_play.CustomImages.Parent = this.btn_play;
            this.btn_play.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_play.ForeColor = System.Drawing.Color.White;
            this.btn_play.HoverState.Parent = this.btn_play;
            this.btn_play.Location = new System.Drawing.Point(63, 126);
            this.btn_play.Name = "btn_play";
            this.btn_play.ShadowDecoration.Parent = this.btn_play;
            this.btn_play.Size = new System.Drawing.Size(180, 45);
            this.btn_play.TabIndex = 5;
            this.btn_play.Text = "PLAY";
            // 
            // lbl_youChoose
            // 
            this.lbl_youChoose.AutoSize = true;
            this.lbl_youChoose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_youChoose.Location = new System.Drawing.Point(114, 74);
            this.lbl_youChoose.Name = "lbl_youChoose";
            this.lbl_youChoose.Size = new System.Drawing.Size(96, 21);
            this.lbl_youChoose.TabIndex = 6;
            this.lbl_youChoose.Text = "You choose :";
            this.lbl_youChoose.Visible = false;
            // 
            // lbl_choice
            // 
            this.lbl_choice.AutoSize = true;
            this.lbl_choice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choice.Location = new System.Drawing.Point(138, 106);
            this.lbl_choice.Name = "lbl_choice";
            this.lbl_choice.Size = new System.Drawing.Size(0, 17);
            this.lbl_choice.TabIndex = 7;
            // 
            // drag_form
            // 
            this.drag_form.ContainerControl = this;
            this.drag_form.TargetControl = this;
            // 
            // lbl_connectionStatus
            // 
            this.lbl_connectionStatus.AutoSize = true;
            this.lbl_connectionStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_connectionStatus.Location = new System.Drawing.Point(14, 39);
            this.lbl_connectionStatus.Name = "lbl_connectionStatus";
            this.lbl_connectionStatus.Size = new System.Drawing.Size(63, 13);
            this.lbl_connectionStatus.TabIndex = 8;
            this.lbl_connectionStatus.Text = "Connected";
            // 
            // pnl_Matchmaking
            // 
            this.pnl_Matchmaking.Controls.Add(this.lbl_lookingForPlayer);
            this.pnl_Matchmaking.Controls.Add(this.pbar_loading);
            this.pnl_Matchmaking.Location = new System.Drawing.Point(36, 65);
            this.pnl_Matchmaking.Name = "pnl_Matchmaking";
            this.pnl_Matchmaking.ShadowDecoration.Parent = this.pnl_Matchmaking;
            this.pnl_Matchmaking.Size = new System.Drawing.Size(264, 100);
            this.pnl_Matchmaking.TabIndex = 9;
            this.pnl_Matchmaking.Visible = false;
            this.pnl_Matchmaking.VisibleChanged += new System.EventHandler(this.pnl_Matchmaking_VisibleChanged);
            // 
            // timer_macthmaking
            // 
            this.timer_macthmaking.Interval = 50;
            this.timer_macthmaking.Tick += new System.EventHandler(this.timer_macthmaking_Tick);
            // 
            // pbar_loading
            // 
            this.pbar_loading.Animated = true;
            this.pbar_loading.AnimationSpeed = 1F;
            this.pbar_loading.FillColor = System.Drawing.Color.White;
            this.pbar_loading.FillThickness = 4;
            this.pbar_loading.Location = new System.Drawing.Point(120, 56);
            this.pbar_loading.Name = "pbar_loading";
            this.pbar_loading.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pbar_loading.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pbar_loading.ProgressThickness = 3;
            this.pbar_loading.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbar_loading.ShadowDecoration.Parent = this.pbar_loading;
            this.pbar_loading.Size = new System.Drawing.Size(30, 30);
            this.pbar_loading.TabIndex = 0;
            this.pbar_loading.Value = 1;
            // 
            // lbl_lookingForPlayer
            // 
            this.lbl_lookingForPlayer.AutoSize = true;
            this.lbl_lookingForPlayer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lookingForPlayer.Location = new System.Drawing.Point(79, 28);
            this.lbl_lookingForPlayer.Name = "lbl_lookingForPlayer";
            this.lbl_lookingForPlayer.Size = new System.Drawing.Size(106, 13);
            this.lbl_lookingForPlayer.TabIndex = 10;
            this.lbl_lookingForPlayer.Text = "Looking for players";
            // 
            // pnl_gameChoices
            // 
            this.pnl_gameChoices.Controls.Add(this.pic_Paper);
            this.pnl_gameChoices.Controls.Add(this.pic_Rock);
            this.pnl_gameChoices.Controls.Add(this.pic_Scissors);
            this.pnl_gameChoices.Controls.Add(this.btn_play);
            this.pnl_gameChoices.Location = new System.Drawing.Point(12, 173);
            this.pnl_gameChoices.Name = "pnl_gameChoices";
            this.pnl_gameChoices.ShadowDecoration.Parent = this.pnl_gameChoices;
            this.pnl_gameChoices.Size = new System.Drawing.Size(298, 216);
            this.pnl_gameChoices.TabIndex = 10;
            this.pnl_gameChoices.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(322, 401);
            this.Controls.Add(this.pnl_Matchmaking);
            this.Controls.Add(this.lbl_connectionStatus);
            this.Controls.Add(this.lbl_choice);
            this.Controls.Add(this.lbl_youChoose);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pnl_gameChoices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPS - by PierroD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Scissors)).EndInit();
            this.pnl_Matchmaking.ResumeLayout(false);
            this.pnl_Matchmaking.PerformLayout();
            this.pnl_gameChoices.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private Guna.UI2.WinForms.Guna2ControlBox btn_close;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pic_Rock;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pic_Paper;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pic_Scissors;
        private Guna.UI2.WinForms.Guna2Button btn_play;
        private System.Windows.Forms.Label lbl_youChoose;
        private System.Windows.Forms.Label lbl_choice;
        private Guna.UI2.WinForms.Guna2DragControl drag_form;
        private System.Windows.Forms.Label lbl_connectionStatus;
        private Guna.UI2.WinForms.Guna2Panel pnl_Matchmaking;
        private System.Windows.Forms.Timer timer_macthmaking;
        private System.Windows.Forms.Label lbl_lookingForPlayer;
        private Guna.UI2.WinForms.Guna2CircleProgressBar pbar_loading;
        private Guna.UI2.WinForms.Guna2Panel pnl_gameChoices;
    }
}

