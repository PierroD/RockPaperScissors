
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
            this.pbox_Rock = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pbox_Paper = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pbox_Scissors = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn_play = new Guna.UI2.WinForms.Guna2Button();
            this.drag_form = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.lbl_connectionStatus = new System.Windows.Forms.Label();
            this.pnl_Matchmaking = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_lookingForPlayer = new System.Windows.Forms.Label();
            this.pbar_loading = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.timer_macthmaking = new System.Windows.Forms.Timer(this.components);
            this.pnl_gameChoices = new Guna.UI2.WinForms.Guna2Panel();
            this.pbox_answer = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbl_you = new System.Windows.Forms.Label();
            this.lbl_ennemy = new System.Windows.Forms.Label();
            this.lbl_vs = new System.Windows.Forms.Label();
            this.lbl_youScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_results = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Scissors)).BeginInit();
            this.pnl_Matchmaking.SuspendLayout();
            this.pnl_gameChoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_answer)).BeginInit();
            this.pnl_results.SuspendLayout();
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
            // pbox_Rock
            // 
            this.pbox_Rock.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Rock.Image = global::RockPaperScissors.Properties.Resources.rock;
            this.pbox_Rock.Location = new System.Drawing.Point(9, 15);
            this.pbox_Rock.Name = "pbox_Rock";
            this.pbox_Rock.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbox_Rock.ShadowDecoration.Parent = this.pbox_Rock;
            this.pbox_Rock.Size = new System.Drawing.Size(70, 70);
            this.pbox_Rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_Rock.TabIndex = 2;
            this.pbox_Rock.TabStop = false;
            this.pbox_Rock.Click += new System.EventHandler(this.Choice_Click);
            // 
            // pbox_Paper
            // 
            this.pbox_Paper.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Paper.Image = global::RockPaperScissors.Properties.Resources.paper;
            this.pbox_Paper.Location = new System.Drawing.Point(115, 15);
            this.pbox_Paper.Name = "pbox_Paper";
            this.pbox_Paper.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbox_Paper.ShadowDecoration.Parent = this.pbox_Paper;
            this.pbox_Paper.Size = new System.Drawing.Size(70, 70);
            this.pbox_Paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_Paper.TabIndex = 3;
            this.pbox_Paper.TabStop = false;
            this.pbox_Paper.Click += new System.EventHandler(this.Choice_Click);
            // 
            // pbox_Scissors
            // 
            this.pbox_Scissors.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Scissors.Image = global::RockPaperScissors.Properties.Resources.scissors;
            this.pbox_Scissors.Location = new System.Drawing.Point(221, 15);
            this.pbox_Scissors.Name = "pbox_Scissors";
            this.pbox_Scissors.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbox_Scissors.ShadowDecoration.Parent = this.pbox_Scissors;
            this.pbox_Scissors.Size = new System.Drawing.Size(70, 70);
            this.pbox_Scissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_Scissors.TabIndex = 4;
            this.pbox_Scissors.TabStop = false;
            this.pbox_Scissors.Click += new System.EventHandler(this.Choice_Click);
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
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
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
            this.lbl_connectionStatus.Location = new System.Drawing.Point(56, 14);
            this.lbl_connectionStatus.Name = "lbl_connectionStatus";
            this.lbl_connectionStatus.Size = new System.Drawing.Size(63, 13);
            this.lbl_connectionStatus.TabIndex = 8;
            this.lbl_connectionStatus.Text = "Connected";
            // 
            // pnl_Matchmaking
            // 
            this.pnl_Matchmaking.Controls.Add(this.lbl_lookingForPlayer);
            this.pnl_Matchmaking.Controls.Add(this.pbar_loading);
            this.pnl_Matchmaking.Location = new System.Drawing.Point(21, 44);
            this.pnl_Matchmaking.Name = "pnl_Matchmaking";
            this.pnl_Matchmaking.ShadowDecoration.Parent = this.pnl_Matchmaking;
            this.pnl_Matchmaking.Size = new System.Drawing.Size(264, 100);
            this.pnl_Matchmaking.TabIndex = 9;
            this.pnl_Matchmaking.Visible = false;
            this.pnl_Matchmaking.VisibleChanged += new System.EventHandler(this.pnl_Matchmaking_VisibleChanged);
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
            // pbar_loading
            // 
            this.pbar_loading.Animated = true;
            this.pbar_loading.AnimationSpeed = 1F;
            this.pbar_loading.FillColor = System.Drawing.Color.White;
            this.pbar_loading.FillThickness = 4;
            this.pbar_loading.Location = new System.Drawing.Point(117, 56);
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
            // timer_macthmaking
            // 
            this.timer_macthmaking.Interval = 50;
            this.timer_macthmaking.Tick += new System.EventHandler(this.timer_macthmaking_Tick);
            // 
            // pnl_gameChoices
            // 
            this.pnl_gameChoices.Controls.Add(this.pbox_answer);
            this.pnl_gameChoices.Controls.Add(this.pbox_Paper);
            this.pnl_gameChoices.Controls.Add(this.pbox_Rock);
            this.pnl_gameChoices.Controls.Add(this.pbox_Scissors);
            this.pnl_gameChoices.Controls.Add(this.btn_play);
            this.pnl_gameChoices.Location = new System.Drawing.Point(12, 173);
            this.pnl_gameChoices.Name = "pnl_gameChoices";
            this.pnl_gameChoices.ShadowDecoration.Parent = this.pnl_gameChoices;
            this.pnl_gameChoices.Size = new System.Drawing.Size(298, 216);
            this.pnl_gameChoices.TabIndex = 10;
            this.pnl_gameChoices.Visible = false;
            // 
            // pbox_answer
            // 
            this.pbox_answer.BackColor = System.Drawing.Color.Transparent;
            this.pbox_answer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pbox_answer.Location = new System.Drawing.Point(33, 91);
            this.pbox_answer.Name = "pbox_answer";
            this.pbox_answer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbox_answer.ShadowDecoration.Parent = this.pbox_answer;
            this.pbox_answer.Size = new System.Drawing.Size(20, 20);
            this.pbox_answer.TabIndex = 6;
            this.pbox_answer.TabStop = false;
            // 
            // lbl_you
            // 
            this.lbl_you.AutoSize = true;
            this.lbl_you.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_you.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lbl_you.Location = new System.Drawing.Point(64, 17);
            this.lbl_you.Name = "lbl_you";
            this.lbl_you.Size = new System.Drawing.Size(31, 17);
            this.lbl_you.TabIndex = 11;
            this.lbl_you.Text = "You";
            this.lbl_you.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ennemy
            // 
            this.lbl_ennemy.AutoSize = true;
            this.lbl_ennemy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ennemy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lbl_ennemy.Location = new System.Drawing.Point(124, 17);
            this.lbl_ennemy.Name = "lbl_ennemy";
            this.lbl_ennemy.Size = new System.Drawing.Size(0, 17);
            this.lbl_ennemy.TabIndex = 12;
            this.lbl_ennemy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_vs
            // 
            this.lbl_vs.AutoSize = true;
            this.lbl_vs.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_vs.Location = new System.Drawing.Point(98, 17);
            this.lbl_vs.Name = "lbl_vs";
            this.lbl_vs.Size = new System.Drawing.Size(23, 17);
            this.lbl_vs.TabIndex = 13;
            this.lbl_vs.Text = "VS";
            this.lbl_vs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_youScore
            // 
            this.lbl_youScore.AutoSize = true;
            this.lbl_youScore.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_youScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lbl_youScore.Location = new System.Drawing.Point(71, 44);
            this.lbl_youScore.Name = "lbl_youScore";
            this.lbl_youScore.Size = new System.Drawing.Size(15, 17);
            this.lbl_youScore.TabIndex = 14;
            this.lbl_youScore.Text = "0";
            this.lbl_youScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(130, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_results
            // 
            this.pnl_results.Controls.Add(this.lbl_ennemy);
            this.pnl_results.Controls.Add(this.lbl_you);
            this.pnl_results.Controls.Add(this.label1);
            this.pnl_results.Controls.Add(this.lbl_vs);
            this.pnl_results.Controls.Add(this.lbl_youScore);
            this.pnl_results.Location = new System.Drawing.Point(44, 44);
            this.pnl_results.Name = "pnl_results";
            this.pnl_results.ShadowDecoration.Parent = this.pnl_results;
            this.pnl_results.Size = new System.Drawing.Size(231, 96);
            this.pnl_results.TabIndex = 16;
            this.pnl_results.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(322, 401);
            this.Controls.Add(this.pnl_results);
            this.Controls.Add(this.pnl_Matchmaking);
            this.Controls.Add(this.lbl_connectionStatus);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pnl_gameChoices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPS - by PierroD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Scissors)).EndInit();
            this.pnl_Matchmaking.ResumeLayout(false);
            this.pnl_Matchmaking.PerformLayout();
            this.pnl_gameChoices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_answer)).EndInit();
            this.pnl_results.ResumeLayout(false);
            this.pnl_results.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private Guna.UI2.WinForms.Guna2ControlBox btn_close;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbox_Rock;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbox_Paper;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbox_Scissors;
        private Guna.UI2.WinForms.Guna2Button btn_play;
        private Guna.UI2.WinForms.Guna2DragControl drag_form;
        private System.Windows.Forms.Label lbl_connectionStatus;
        private Guna.UI2.WinForms.Guna2Panel pnl_Matchmaking;
        private System.Windows.Forms.Timer timer_macthmaking;
        private System.Windows.Forms.Label lbl_lookingForPlayer;
        private Guna.UI2.WinForms.Guna2CircleProgressBar pbar_loading;
        private Guna.UI2.WinForms.Guna2Panel pnl_gameChoices;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbox_answer;
        private System.Windows.Forms.Label lbl_ennemy;
        private System.Windows.Forms.Label lbl_you;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_youScore;
        private System.Windows.Forms.Label lbl_vs;
        private Guna.UI2.WinForms.Guna2Panel pnl_results;
    }
}

