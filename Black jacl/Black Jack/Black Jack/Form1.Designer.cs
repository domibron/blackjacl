
namespace Black_Jack
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtScore = new System.Windows.Forms.Label();
            this.gamrtimer = new System.Windows.Forms.Timer(this.components);
            this.txtHouse = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.Label();
            this.hitbutton = new System.Windows.Forms.Button();
            this.dealer = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.standbutton = new System.Windows.Forms.Button();
            this.txtCash = new System.Windows.Forms.Label();
            this.txtCard = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.numud = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.endscreen = new System.Windows.Forms.PictureBox();
            this.infinitycheckbox = new System.Windows.Forms.CheckBox();
            this.cheat2 = new System.Windows.Forms.CheckBox();
            this.Win = new System.Windows.Forms.PictureBox();
            this.broke = new System.Windows.Forms.PictureBox();
            this.txtBet = new System.Windows.Forms.Label();
            this.betButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dealer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endscreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Win)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.broke)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.Black;
            this.txtScore.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtScore.Location = new System.Drawing.Point(257, 345);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(237, 107);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Total: 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gamrtimer
            // 
            this.gamrtimer.Enabled = true;
            this.gamrtimer.Interval = 20;
            this.gamrtimer.Tick += new System.EventHandler(this.gametime);
            // 
            // txtHouse
            // 
            this.txtHouse.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHouse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtHouse.Location = new System.Drawing.Point(257, 117);
            this.txtHouse.Name = "txtHouse";
            this.txtHouse.Size = new System.Drawing.Size(237, 77);
            this.txtHouse.TabIndex = 1;
            this.txtHouse.Text = "House: 0";
            this.txtHouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.Black;
            this.txtStatus.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtStatus.Location = new System.Drawing.Point(571, -3);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(186, 46);
            this.txtStatus.TabIndex = 2;
            this.txtStatus.Text = "Status: --";
            this.txtStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hitbutton
            // 
            this.hitbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hitbutton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hitbutton.Location = new System.Drawing.Point(442, 442);
            this.hitbutton.Name = "hitbutton";
            this.hitbutton.Size = new System.Drawing.Size(83, 82);
            this.hitbutton.TabIndex = 3;
            this.hitbutton.Text = "HIT";
            this.hitbutton.UseVisualStyleBackColor = true;
            this.hitbutton.Click += new System.EventHandler(this.hitbutton_Click);
            // 
            // dealer
            // 
            this.dealer.Image = global::Black_Jack.Properties.Resources.download;
            this.dealer.Location = new System.Drawing.Point(248, 12);
            this.dealer.Name = "dealer";
            this.dealer.Size = new System.Drawing.Size(246, 125);
            this.dealer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealer.TabIndex = 4;
            this.dealer.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Black_Jack.Properties.Resources.download__1_;
            this.pictureBox1.Location = new System.Drawing.Point(274, 268);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // standbutton
            // 
            this.standbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.standbutton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.standbutton.Location = new System.Drawing.Point(214, 442);
            this.standbutton.Name = "standbutton";
            this.standbutton.Size = new System.Drawing.Size(83, 79);
            this.standbutton.TabIndex = 6;
            this.standbutton.Text = "STAND";
            this.standbutton.UseVisualStyleBackColor = true;
            this.standbutton.Click += new System.EventHandler(this.standclick);
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCash.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCash.Location = new System.Drawing.Point(548, 472);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(183, 32);
            this.txtCash.TabIndex = 7;
            this.txtCash.Text = "Cash: 100";
            this.txtCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCard
            // 
            this.txtCard.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCard.Location = new System.Drawing.Point(259, 531);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(220, 23);
            this.txtCard.TabIndex = 8;
            this.txtCard.Text = "Recent Card: 10";
            this.txtCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RestartButton
            // 
            this.RestartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestartButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RestartButton.Location = new System.Drawing.Point(317, 449);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(102, 65);
            this.RestartButton.TabIndex = 9;
            this.RestartButton.Text = "Next Game";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Visible = false;
            this.RestartButton.Click += new System.EventHandler(this.restartClick);
            // 
            // numud
            // 
            this.numud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numud.Location = new System.Drawing.Point(594, 451);
            this.numud.Name = "numud";
            this.numud.Size = new System.Drawing.Size(78, 23);
            this.numud.TabIndex = 10;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Black;
            this.progressBar1.Location = new System.Drawing.Point(548, 502);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(184, 22);
            this.progressBar1.TabIndex = 11;
            // 
            // endscreen
            // 
            this.endscreen.Image = ((System.Drawing.Image)(resources.GetObject("endscreen.Image")));
            this.endscreen.Location = new System.Drawing.Point(274, 268);
            this.endscreen.Name = "endscreen";
            this.endscreen.Size = new System.Drawing.Size(205, 111);
            this.endscreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.endscreen.TabIndex = 12;
            this.endscreen.TabStop = false;
            this.endscreen.Visible = false;
            // 
            // infinitycheckbox
            // 
            this.infinitycheckbox.AutoSize = true;
            this.infinitycheckbox.BackColor = System.Drawing.Color.Black;
            this.infinitycheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infinitycheckbox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.infinitycheckbox.Location = new System.Drawing.Point(617, 34);
            this.infinitycheckbox.Name = "infinitycheckbox";
            this.infinitycheckbox.Size = new System.Drawing.Size(90, 19);
            this.infinitycheckbox.TabIndex = 13;
            this.infinitycheckbox.Text = "infinity cash";
            this.infinitycheckbox.UseVisualStyleBackColor = false;
            // 
            // cheat2
            // 
            this.cheat2.AutoSize = true;
            this.cheat2.BackColor = System.Drawing.Color.Black;
            this.cheat2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cheat2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cheat2.Location = new System.Drawing.Point(617, 59);
            this.cheat2.Name = "cheat2";
            this.cheat2.Size = new System.Drawing.Size(125, 19);
            this.cheat2.TabIndex = 14;
            this.cheat2.Text = " House always lose";
            this.cheat2.UseVisualStyleBackColor = false;
            // 
            // Win
            // 
            this.Win.Image = global::Black_Jack.Properties.Resources.download_3_;
            this.Win.Location = new System.Drawing.Point(274, 268);
            this.Win.Name = "Win";
            this.Win.Size = new System.Drawing.Size(205, 111);
            this.Win.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Win.TabIndex = 15;
            this.Win.TabStop = false;
            this.Win.Visible = false;
            // 
            // broke
            // 
            this.broke.Image = global::Black_Jack.Properties.Resources.download_4_;
            this.broke.Location = new System.Drawing.Point(274, 268);
            this.broke.Name = "broke";
            this.broke.Size = new System.Drawing.Size(205, 111);
            this.broke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.broke.TabIndex = 16;
            this.broke.TabStop = false;
            this.broke.Visible = false;
            // 
            // txtBet
            // 
            this.txtBet.BackColor = System.Drawing.Color.Black;
            this.txtBet.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBet.Location = new System.Drawing.Point(548, 527);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(177, 23);
            this.txtBet.TabIndex = 17;
            this.txtBet.Text = "Bet: 0";
            this.txtBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // betButton
            // 
            this.betButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.betButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.betButton.Location = new System.Drawing.Point(678, 442);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(66, 32);
            this.betButton.TabIndex = 18;
            this.betButton.Text = "BET";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.Bet);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(758, 563);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.broke);
            this.Controls.Add(this.Win);
            this.Controls.Add(this.cheat2);
            this.Controls.Add(this.infinitycheckbox);
            this.Controls.Add(this.endscreen);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.numud);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.txtCard);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.standbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dealer);
            this.Controls.Add(this.hitbutton);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtHouse);
            this.Controls.Add(this.txtScore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(774, 602);
            this.MinimumSize = new System.Drawing.Size(774, 602);
            this.Name = "Form1";
            this.Text = "Black Jack v1.1.2A";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.dealer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endscreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Win)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.broke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gamrtimer;
        private System.Windows.Forms.Label txtHouse;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.Button hitbutton;
        private System.Windows.Forms.PictureBox dealer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button standbutton;
        private System.Windows.Forms.Label txtCash;
        private System.Windows.Forms.Label txtCard;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.NumericUpDown numud;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox endscreen;
        private System.Windows.Forms.CheckBox infinitycheckbox;
        private System.Windows.Forms.CheckBox cheat2;
        private System.Windows.Forms.PictureBox Win;
        private System.Windows.Forms.PictureBox broke;
        private System.Windows.Forms.Label txtBet;
        private System.Windows.Forms.Button betButton;
    }
}

