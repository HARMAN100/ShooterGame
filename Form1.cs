using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ShooterGame
{
    public partial class Form1 : Form
    {

        private functions func = new functions();

        public Form1()
        {
            InitializeComponent();
            Assembly assembly = Assembly.GetExecutingAssembly();
            Bitmap bitmap = new Bitmap(ShooterGame.Properties.Resources.russian_roulette_by_reddii_d4x39wz);
            PlayerState.Image = bitmap;
        }

        private void CloseApplication_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sfx = new System.Media.SoundPlayer(ShooterGame.Properties.Resources.Gun_Reload);
            sfx.Play();
            Bitmap bitmap = new Bitmap(ShooterGame.Properties.Resources.reload);
            PlayerState.Image = bitmap;
            func.Reload();
            Reload.Enabled = false;
            SpinChambers.Enabled = true;
            ShootAway.Enabled = false;
            Shoot.Enabled = false;
        }

        private void SpinChambers_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sfx = new System.Media.SoundPlayer(ShooterGame.Properties.Resources.spinning);
            sfx.Play();
            Bitmap bitmap = new Bitmap(ShooterGame.Properties.Resources.spin);
            PlayerState.Image = bitmap;
            func.SpinChambers();
            Reload.Enabled = false;
            SpinChambers.Enabled = false;
            ShootAway.Enabled = true;
            Shoot.Enabled = true;
        }

        private void ShootAway_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sfx = new System.Media.SoundPlayer(ShooterGame.Properties.Resources.shoot1);
            sfx.Play();
            Bitmap bitmap = new Bitmap(ShooterGame.Properties.Resources.shoot_in_the_air);
            PlayerState.Image = bitmap;
            func.ShootAway();
            Reload.Enabled = false;
            SpinChambers.Enabled = false;
            errorText.Text = func.GetErrorMessage();

            scoreLabel.Text = "Score: " + func.GetScore().ToString();

            if (!func.GetGameOver())
            {
                if (func.GetShootAwayChances() > 0)
                {
                    ShootAway.Enabled = true;
                }
                else
                {
                    ShootAway.Enabled = false;
                }

                Shoot.Enabled = true;
            }
            else
            {
                ShootAway.Enabled = false;
                Shoot.Enabled = false;
                errorText.Text = func.GetErrorMessage();
                victoryIndicator.Text = func.GetErrorMessage();
                PlayAgain.Enabled = true;
            }
        }

        private void Shoot_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sfx = new System.Media.SoundPlayer(ShooterGame.Properties.Resources.shoot1);
            sfx.Play();
            Bitmap bitmap = new Bitmap(ShooterGame.Properties.Resources.shootself);
            PlayerState.Image = bitmap;
            func.Shoot();
            errorText.Text = func.GetErrorMessage();
            Reload.Enabled = false;
            SpinChambers.Enabled = false;

            scoreLabel.Text = "Score: " + func.GetScore().ToString();

            if (!func.GetGameOver())
            {
                if (func.GetAvailableBullets() > 0)
                {
                    Shoot.Enabled = true;
                }
                else
                {
                    Shoot.Enabled = false;
                }
            }
            else
            {
                ShootAway.Enabled = false;
                Shoot.Enabled = false;
                errorText.Text = func.GetErrorMessage();
                victoryIndicator.Text = func.GetErrorMessage();
                PlayAgain.Enabled = true;
            }
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            Reload.Enabled = true;
            SpinChambers.Enabled = false;
            ShootAway.Enabled = false;
            Shoot.Enabled = false;
            Bitmap bitmap = new Bitmap(ShooterGame.Properties.Resources.russian_roulette_by_reddii_d4x39wz);
            PlayerState.Image = bitmap;
            func.ResetStats();
            PlayAgain.Enabled = false;
            victoryIndicator.Text = "Victory Indicator";
            errorText.Text = "Error Message: ";
            scoreLabel.Text = "Score: 0";
        }
    }
}
