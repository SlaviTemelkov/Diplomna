
namespace Stani_Bogat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.announce = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.questionbox = new System.Windows.Forms.PictureBox();
            this.answerAbox = new System.Windows.Forms.PictureBox();
            this.answerBbox = new System.Windows.Forms.PictureBox();
            this.answerDbox = new System.Windows.Forms.PictureBox();
            this.answerCbox = new System.Windows.Forms.PictureBox();
            this.answerA = new System.Windows.Forms.Label();
            this.question = new System.Windows.Forms.Label();
            this.fiftyfifty = new System.Windows.Forms.PictureBox();
            this.askthaudience = new System.Windows.Forms.PictureBox();
            this.phoneafriend = new System.Windows.Forms.PictureBox();
            this.announceA = new System.Windows.Forms.Label();
            this.announceC = new System.Windows.Forms.Label();
            this.answerC = new System.Windows.Forms.Label();
            this.announceB = new System.Windows.Forms.Label();
            this.answerB = new System.Windows.Forms.Label();
            this.announceD = new System.Windows.Forms.Label();
            this.answerD = new System.Windows.Forms.Label();
            this.walkingaway = new System.Windows.Forms.PictureBox();
            this.leveltree = new System.Windows.Forms.Label();
            this.moneytree = new System.Windows.Forms.Label();
            this.lifeline = new System.Windows.Forms.PictureBox();
            this.lifelinetext = new System.Windows.Forms.Label();
            this.startgame = new System.Windows.Forms.PictureBox();
            this.answerreveal = new System.Windows.Forms.PictureBox();
            this.tothequestion = new System.Windows.Forms.PictureBox();
            this.continuegame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerAbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerBbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerDbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerCbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiftyfifty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.askthaudience)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneafriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.walkingaway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startgame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerreveal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tothequestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.continuegame)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.announce.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.announce.ForeColor = System.Drawing.Color.White;
            this.announce.Location = new System.Drawing.Point(1, 388);
            this.announce.Name = "label4";
            this.announce.Size = new System.Drawing.Size(984, 36);
            this.announce.TabIndex = 10;
            this.announce.Text = "Добре дошли!";
            this.announce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo.BackgroundImage = global::Stani_Bogat.Properties.Resources.logo_2023;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(1, 2);
            this.logo.Name = "pictureBox1";
            this.logo.Size = new System.Drawing.Size(984, 390);
            this.logo.TabIndex = 13;
            this.logo.TabStop = false;
            // 
            // questionbox
            // 
            this.questionbox.BackColor = System.Drawing.Color.Transparent;
            this.questionbox.Image = global::Stani_Bogat.Properties.Resources.question;
            this.questionbox.Location = new System.Drawing.Point(1, 438);
            this.questionbox.Name = "questionbox";
            this.questionbox.Size = new System.Drawing.Size(984, 84);
            this.questionbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.questionbox.TabIndex = 15;
            this.questionbox.TabStop = false;
            // 
            // answerAbox
            // 
            this.answerAbox.BackColor = System.Drawing.Color.Transparent;
            this.answerAbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.answerAbox.Enabled = false;
            this.answerAbox.Image = global::Stani_Bogat.Properties.Resources.left;
            this.answerAbox.Location = new System.Drawing.Point(1, 520);
            this.answerAbox.Name = "answerAbox";
            this.answerAbox.Size = new System.Drawing.Size(492, 50);
            this.answerAbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.answerAbox.TabIndex = 16;
            this.answerAbox.TabStop = false;
            this.answerAbox.Click += new System.EventHandler(this.AnswerA);
            // 
            // answerBbox
            // 
            this.answerBbox.BackColor = System.Drawing.Color.Transparent;
            this.answerBbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.answerBbox.Enabled = false;
            this.answerBbox.Image = global::Stani_Bogat.Properties.Resources.right;
            this.answerBbox.Location = new System.Drawing.Point(493, 520);
            this.answerBbox.Name = "answerBbox";
            this.answerBbox.Size = new System.Drawing.Size(492, 50);
            this.answerBbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.answerBbox.TabIndex = 25;
            this.answerBbox.TabStop = false;
            this.answerBbox.Click += new System.EventHandler(this.AnswerB);
            // 
            // answerDbox
            // 
            this.answerDbox.BackColor = System.Drawing.Color.Transparent;
            this.answerDbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.answerDbox.Enabled = false;
            this.answerDbox.Image = global::Stani_Bogat.Properties.Resources.right;
            this.answerDbox.Location = new System.Drawing.Point(493, 567);
            this.answerDbox.Name = "answerDbox";
            this.answerDbox.Size = new System.Drawing.Size(492, 50);
            this.answerDbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.answerDbox.TabIndex = 27;
            this.answerDbox.TabStop = false;
            this.answerDbox.Click += new System.EventHandler(this.AnswerD);
            // 
            // answerCbox
            // 
            this.answerCbox.BackColor = System.Drawing.Color.Transparent;
            this.answerCbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.answerCbox.Enabled = false;
            this.answerCbox.Image = global::Stani_Bogat.Properties.Resources.left;
            this.answerCbox.Location = new System.Drawing.Point(1, 567);
            this.answerCbox.Name = "answerCbox";
            this.answerCbox.Size = new System.Drawing.Size(492, 50);
            this.answerCbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.answerCbox.TabIndex = 26;
            this.answerCbox.TabStop = false;
            this.answerCbox.Click += new System.EventHandler(this.AnswerC);
            // 
            // answerA
            // 
            this.answerA.AutoSize = true;
            this.answerA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(48)))), ((int)(((byte)(121)))));
            this.answerA.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerA.ForeColor = System.Drawing.Color.White;
            this.answerA.Location = new System.Drawing.Point(119, 533);
            this.answerA.Name = "answerA";
            this.answerA.Size = new System.Drawing.Size(0, 23);
            this.answerA.TabIndex = 33;
            // 
            // question
            // 
            this.question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(48)))), ((int)(((byte)(121)))));
            this.question.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.question.ForeColor = System.Drawing.Color.White;
            this.question.Location = new System.Drawing.Point(94, 452);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(798, 53);
            this.question.TabIndex = 37;
            this.question.Text = "Кой иска да стане богат?";
            this.question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fiftyfifty
            // 
            this.fiftyfifty.BackgroundImage = global::Stani_Bogat.Properties.Resources._5050;
            this.fiftyfifty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fiftyfifty.Enabled = false;
            this.fiftyfifty.Location = new System.Drawing.Point(12, 14);
            this.fiftyfifty.Name = "fiftyfifty";
            this.fiftyfifty.Size = new System.Drawing.Size(84, 68);
            this.fiftyfifty.TabIndex = 38;
            this.fiftyfifty.TabStop = false;
            this.fiftyfifty.Click += new System.EventHandler(this.FiftyFifty);
            // 
            // askthaudience
            // 
            this.askthaudience.BackgroundImage = global::Stani_Bogat.Properties.Resources.friend;
            this.askthaudience.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.askthaudience.Enabled = false;
            this.askthaudience.Location = new System.Drawing.Point(104, 14);
            this.askthaudience.Name = "askthaudience";
            this.askthaudience.Size = new System.Drawing.Size(84, 68);
            this.askthaudience.TabIndex = 39;
            this.askthaudience.TabStop = false;
            this.askthaudience.Click += new System.EventHandler(this.PhoneAFriend);
            // 
            // phoneafriend
            // 
            this.phoneafriend.BackgroundImage = global::Stani_Bogat.Properties.Resources.audience;
            this.phoneafriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.phoneafriend.Enabled = false;
            this.phoneafriend.Location = new System.Drawing.Point(196, 14);
            this.phoneafriend.Name = "phoneafriend";
            this.phoneafriend.Size = new System.Drawing.Size(84, 68);
            this.phoneafriend.TabIndex = 40;
            this.phoneafriend.TabStop = false;
            this.phoneafriend.Click += new System.EventHandler(this.AskTheAudience);
            // 
            // label6
            // 
            this.announceA.AutoSize = true;
            this.announceA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(48)))), ((int)(((byte)(121)))));
            this.announceA.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.announceA.ForeColor = System.Drawing.Color.Gold;
            this.announceA.Location = new System.Drawing.Point(92, 533);
            this.announceA.Name = "label6";
            this.announceA.Size = new System.Drawing.Size(28, 23);
            this.announceA.TabIndex = 41;
            this.announceA.Text = "А:";
            this.announceA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.announceC.AutoSize = true;
            this.announceC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(48)))), ((int)(((byte)(121)))));
            this.announceC.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.announceC.ForeColor = System.Drawing.Color.Gold;
            this.announceC.Location = new System.Drawing.Point(92, 580);
            this.announceC.Name = "label7";
            this.announceC.Size = new System.Drawing.Size(28, 23);
            this.announceC.TabIndex = 45;
            this.announceC.Text = "C:";
            this.announceC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerC
            // 
            this.answerC.AutoSize = true;
            this.answerC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(48)))), ((int)(((byte)(121)))));
            this.answerC.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerC.ForeColor = System.Drawing.Color.White;
            this.answerC.Location = new System.Drawing.Point(119, 580);
            this.answerC.Name = "answerC";
            this.answerC.Size = new System.Drawing.Size(0, 23);
            this.answerC.TabIndex = 44;
            // 
            // label8
            // 
            this.announceB.AutoSize = true;
            this.announceB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(48)))), ((int)(((byte)(121)))));
            this.announceB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.announceB.ForeColor = System.Drawing.Color.Gold;
            this.announceB.Location = new System.Drawing.Point(523, 533);
            this.announceB.Name = "label8";
            this.announceB.Size = new System.Drawing.Size(28, 23);
            this.announceB.TabIndex = 47;
            this.announceB.Text = "B:";
            this.announceB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerB
            // 
            this.answerB.AutoSize = true;
            this.answerB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(48)))), ((int)(((byte)(121)))));
            this.answerB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerB.ForeColor = System.Drawing.Color.White;
            this.answerB.Location = new System.Drawing.Point(550, 533);
            this.answerB.Name = "answerB";
            this.answerB.Size = new System.Drawing.Size(0, 23);
            this.answerB.TabIndex = 46;
            // 
            // label11
            // 
            this.announceD.AutoSize = true;
            this.announceD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(48)))), ((int)(((byte)(121)))));
            this.announceD.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.announceD.ForeColor = System.Drawing.Color.Gold;
            this.announceD.Location = new System.Drawing.Point(523, 580);
            this.announceD.Name = "label11";
            this.announceD.Size = new System.Drawing.Size(30, 23);
            this.announceD.TabIndex = 49;
            this.announceD.Text = "D:";
            this.announceD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerD
            // 
            this.answerD.AutoSize = true;
            this.answerD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(48)))), ((int)(((byte)(121)))));
            this.answerD.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerD.ForeColor = System.Drawing.Color.White;
            this.answerD.Location = new System.Drawing.Point(550, 580);
            this.answerD.Name = "answerD";
            this.answerD.Size = new System.Drawing.Size(0, 23);
            this.answerD.TabIndex = 48;
            // 
            // walkingaway
            // 
            this.walkingaway.BackgroundImage = global::Stani_Bogat.Properties.Resources.otkaz;
            this.walkingaway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.walkingaway.Enabled = false;
            this.walkingaway.Location = new System.Drawing.Point(12, 83);
            this.walkingaway.Name = "walkingaway";
            this.walkingaway.Size = new System.Drawing.Size(268, 41);
            this.walkingaway.TabIndex = 50;
            this.walkingaway.TabStop = false;
            this.walkingaway.Click += new System.EventHandler(this.WalkingAway);
            // 
            // label2
            // 
            this.leveltree.AutoSize = true;
            this.leveltree.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leveltree.ForeColor = System.Drawing.Color.White;
            this.leveltree.Location = new System.Drawing.Point(745, 24);
            this.leveltree.Name = "label2";
            this.leveltree.Size = new System.Drawing.Size(0, 21);
            this.leveltree.TabIndex = 52;
            // 
            // label5
            // 
            this.moneytree.AutoSize = true;
            this.moneytree.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moneytree.ForeColor = System.Drawing.Color.White;
            this.moneytree.Location = new System.Drawing.Point(801, 24);
            this.moneytree.Name = "label5";
            this.moneytree.Size = new System.Drawing.Size(0, 21);
            this.moneytree.TabIndex = 53;
            // 
            // pictureBox7
            // 
            this.lifeline.BackColor = System.Drawing.Color.Transparent;
            this.lifeline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lifeline.Location = new System.Drawing.Point(24, 129);
            this.lifeline.Name = "pictureBox7";
            this.lifeline.Size = new System.Drawing.Size(241, 248);
            this.lifeline.TabIndex = 55;
            this.lifeline.TabStop = false;
            // 
            // label3
            // 
            this.lifelinetext.BackColor = System.Drawing.Color.Transparent;
            this.lifelinetext.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lifelinetext.ForeColor = System.Drawing.Color.White;
            this.lifelinetext.Location = new System.Drawing.Point(82, 147);
            this.lifelinetext.Name = "label3";
            this.lifelinetext.Size = new System.Drawing.Size(126, 41);
            this.lifelinetext.TabIndex = 56;
            this.lifelinetext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.startgame.BackgroundImage = global::Stani_Bogat.Properties.Resources._new;
            this.startgame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.startgame.Location = new System.Drawing.Point(12, 122);
            this.startgame.Name = "button5";
            this.startgame.Size = new System.Drawing.Size(268, 41);
            this.startgame.TabIndex = 57;
            this.startgame.TabStop = false;
            this.startgame.Click += new System.EventHandler(this.StartTheGame);
            // 
            // answerreveal
            // 
            this.answerreveal.BackgroundImage = global::Stani_Bogat.Properties.Resources.razkrii;
            this.answerreveal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.answerreveal.Enabled = false;
            this.answerreveal.Location = new System.Drawing.Point(12, 122);
            this.answerreveal.Name = "answerreveal";
            this.answerreveal.Size = new System.Drawing.Size(268, 41);
            this.answerreveal.TabIndex = 61;
            this.answerreveal.TabStop = false;
            this.answerreveal.Visible = false;
            this.answerreveal.Click += new System.EventHandler(this.AnswerReveal);
            // 
            // tothequestion
            // 
            this.tothequestion.BackgroundImage = global::Stani_Bogat.Properties.Resources.kumvuprosa;
            this.tothequestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tothequestion.Enabled = false;
            this.tothequestion.Location = new System.Drawing.Point(12, 122);
            this.tothequestion.Name = "tothequestion";
            this.tothequestion.Size = new System.Drawing.Size(268, 41);
            this.tothequestion.TabIndex = 62;
            this.tothequestion.TabStop = false;
            this.tothequestion.Visible = false;
            this.tothequestion.Click += new System.EventHandler(this.ToTheQuestion);
            // 
            // continuegame
            // 
            this.continuegame.BackgroundImage = global::Stani_Bogat.Properties.Resources.napred;
            this.continuegame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.continuegame.Enabled = false;
            this.continuegame.Location = new System.Drawing.Point(12, 122);
            this.continuegame.Name = "continuegame";
            this.continuegame.Size = new System.Drawing.Size(268, 41);
            this.continuegame.TabIndex = 63;
            this.continuegame.TabStop = false;
            this.continuegame.Visible = false;
            this.continuegame.Click += new System.EventHandler(this.ContinueTheGame);
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(986, 629);
            this.Controls.Add(this.continuegame);
            this.Controls.Add(this.tothequestion);
            this.Controls.Add(this.answerreveal);
            this.Controls.Add(this.startgame);
            this.Controls.Add(this.lifelinetext);
            this.Controls.Add(this.lifeline);
            this.Controls.Add(this.moneytree);
            this.Controls.Add(this.leveltree);
            this.Controls.Add(this.walkingaway);
            this.Controls.Add(this.announceD);
            this.Controls.Add(this.answerD);
            this.Controls.Add(this.announceB);
            this.Controls.Add(this.answerB);
            this.Controls.Add(this.announceC);
            this.Controls.Add(this.answerC);
            this.Controls.Add(this.announceA);
            this.Controls.Add(this.phoneafriend);
            this.Controls.Add(this.askthaudience);
            this.Controls.Add(this.fiftyfifty);
            this.Controls.Add(this.question);
            this.Controls.Add(this.answerA);
            this.Controls.Add(this.answerDbox);
            this.Controls.Add(this.answerCbox);
            this.Controls.Add(this.answerBbox);
            this.Controls.Add(this.answerAbox);
            this.Controls.Add(this.questionbox);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.announce);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Стани богат";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerAbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerBbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerDbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerCbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiftyfifty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.askthaudience)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneafriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.walkingaway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startgame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerreveal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tothequestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.continuegame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label announce;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox questionbox;
        private System.Windows.Forms.PictureBox answerAbox;
        private System.Windows.Forms.PictureBox answerBbox;
        private System.Windows.Forms.PictureBox answerDbox;
        private System.Windows.Forms.PictureBox answerCbox;
        private System.Windows.Forms.Label answerA;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.PictureBox fiftyfifty;
        private System.Windows.Forms.PictureBox askthaudience;
        private System.Windows.Forms.PictureBox phoneafriend;
        private System.Windows.Forms.Label announceA;
        private System.Windows.Forms.Label announceC;
        private System.Windows.Forms.Label answerC;
        private System.Windows.Forms.Label announceB;
        private System.Windows.Forms.Label answerB;
        private System.Windows.Forms.Label announceD;
        private System.Windows.Forms.Label answerD;
        private System.Windows.Forms.PictureBox walkingaway;
        private System.Windows.Forms.Label leveltree;
        private System.Windows.Forms.Label moneytree;
        private System.Windows.Forms.PictureBox lifeline;
        private System.Windows.Forms.Label lifelinetext;
        private System.Windows.Forms.PictureBox startgame;
        private System.Windows.Forms.PictureBox answerreveal;
        private System.Windows.Forms.PictureBox tothequestion;
        private System.Windows.Forms.PictureBox continuegame;
    }
}

