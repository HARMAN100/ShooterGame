namespace ShooterGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeApplication = new System.Windows.Forms.Button();
            this.Reload = new System.Windows.Forms.Button();
            this.SpinChambers = new System.Windows.Forms.Button();
            this.ShootAway = new System.Windows.Forms.Button();
            this.Shoot = new System.Windows.Forms.Button();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.PlayerState = new System.Windows.Forms.PictureBox();
            this.victoryIndicator = new System.Windows.Forms.Label();
            this.errorText = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerState)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closeApplication);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // closeApplication
            // 
            this.closeApplication.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.closeApplication, "closeApplication");
            this.closeApplication.FlatAppearance.BorderSize = 0;
            this.closeApplication.Name = "closeApplication";
            this.closeApplication.UseVisualStyleBackColor = false;
            this.closeApplication.Click += new System.EventHandler(this.CloseApplication_Click);
            // 
            // Reload
            // 
            this.Reload.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Reload.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Reload, "Reload");
            this.Reload.Name = "Reload";
            this.Reload.UseVisualStyleBackColor = false;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // SpinChambers
            // 
            this.SpinChambers.BackColor = System.Drawing.Color.DeepSkyBlue;
            resources.ApplyResources(this.SpinChambers, "SpinChambers");
            this.SpinChambers.FlatAppearance.BorderSize = 0;
            this.SpinChambers.Name = "SpinChambers";
            this.SpinChambers.UseVisualStyleBackColor = false;
            this.SpinChambers.Click += new System.EventHandler(this.SpinChambers_Click);
            // 
            // ShootAway
            // 
            this.ShootAway.BackColor = System.Drawing.Color.DeepSkyBlue;
            resources.ApplyResources(this.ShootAway, "ShootAway");
            this.ShootAway.FlatAppearance.BorderSize = 0;
            this.ShootAway.Name = "ShootAway";
            this.ShootAway.UseVisualStyleBackColor = false;
            this.ShootAway.Click += new System.EventHandler(this.ShootAway_Click);
            // 
            // Shoot
            // 
            this.Shoot.BackColor = System.Drawing.Color.DeepSkyBlue;
            resources.ApplyResources(this.Shoot, "Shoot");
            this.Shoot.FlatAppearance.BorderSize = 0;
            this.Shoot.Name = "Shoot";
            this.Shoot.UseVisualStyleBackColor = false;
            this.Shoot.Click += new System.EventHandler(this.Shoot_Click);
            // 
            // PlayAgain
            // 
            this.PlayAgain.BackColor = System.Drawing.Color.DeepSkyBlue;
            resources.ApplyResources(this.PlayAgain, "PlayAgain");
            this.PlayAgain.FlatAppearance.BorderSize = 0;
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.UseVisualStyleBackColor = false;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // PlayerState
            // 
            this.PlayerState.Image = global::ShooterGame.Properties.Resources.russian_roulette_by_reddii_d4x39wz;
            resources.ApplyResources(this.PlayerState, "PlayerState");
            this.PlayerState.Name = "PlayerState";
            this.PlayerState.TabStop = false;
            // 
            // victoryIndicator
            // 
            resources.ApplyResources(this.victoryIndicator, "victoryIndicator");
            this.victoryIndicator.BackColor = System.Drawing.Color.Transparent;
            this.victoryIndicator.ForeColor = System.Drawing.Color.White;
            this.victoryIndicator.Name = "victoryIndicator";
            // 
            // errorText
            // 
            resources.ApplyResources(this.errorText, "errorText");
            this.errorText.BackColor = System.Drawing.Color.Transparent;
            this.errorText.ForeColor = System.Drawing.Color.Red;
            this.errorText.Name = "errorText";
            // 
            // scoreLabel
            // 
            resources.ApplyResources(this.scoreLabel, "scoreLabel");
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.scoreLabel.Name = "scoreLabel";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.victoryIndicator);
            this.Controls.Add(this.PlayerState);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.Shoot);
            this.Controls.Add(this.ShootAway);
            this.Controls.Add(this.SpinChambers);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeApplication;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.Button SpinChambers;
        private System.Windows.Forms.Button ShootAway;
        private System.Windows.Forms.Button Shoot;
        private System.Windows.Forms.Button PlayAgain;
        private System.Windows.Forms.Label victoryIndicator;
        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.PictureBox PlayerState;
        private System.Windows.Forms.Label scoreLabel;
    }
}

