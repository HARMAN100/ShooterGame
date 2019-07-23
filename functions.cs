using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShooterGame
{
    class functions
    {

        // Variables
        private int bulletsAvailable = 0;
        private int maximumBulletsInRevolver = 6;
        private int[] bulletChamber = new int[6];
        private int shootAwayChances = 2;
        private LinkedList<int> bulletSlots;
        private string[] message = { "You Won!", "You Lost!",  "You are out of Shoot Away Chances!", "The chamber was empty!", "You survived" };
        private int errorCode;
        private bool bDidWon = false;
        private int score = 0;
        private bool bGameOver = false;


        // Helper Functions
        private void SetGameOver(bool GameOver)
        {
            bGameOver = GameOver;
        }

        public bool GetGameOver()
        {
            return bGameOver;
        }

        public int GetScore()
        {
            return score;
        }

        private void AddScore(int value)
        {
            score += value;
        }

        private void SetErrorCode(int code)
        {
            errorCode = code;
        }

        private int GetErrorCode()
        {
            return errorCode;
        }

        public string GetErrorMessage()
        {
            return message[GetErrorCode()];
        }

        public int GetShootAwayChances()
        {
            return shootAwayChances;
        }

        public int GetAvailableBullets()
        {
            return bulletsAvailable;
        }

        public int GetMaxBullets()
        {
            return maximumBulletsInRevolver;
        }

        public int[] GetBulletChamber()
        {
            return bulletChamber;
        }

        public bool GetPlayerWon()
        {
            return bDidWon;
        }

        private void SetPlayerWon(bool bWon)
        {
            bDidWon = bWon;
        }


        // Reload Function
        public void Reload()
        {
            shootAwayChances = 2;
            SetPlayerWon(false);
            if (ChamberBulletsNeedsToBeCleared())
            {
                // This will empty all the bullets from the chambers
                Array.Clear(bulletChamber, 0, bulletChamber.Length);
                LoadBullets();
            }
            else
            {
                LoadBullets();
            }
        }

        // Checks if bullet needs to be removed from revolver
        private bool ChamberBulletsNeedsToBeCleared()
        {
            foreach (int bullet in GetBulletChamber())
            {
                if (bullet == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }


        // Spins the chamber
        public void SpinChambers()
        {
            // Moves the bullet to random slot
            ShuffleChamberBullets(bulletChamber);
            bulletSlots = new LinkedList<int>(bulletChamber);


            // The loop below is only used for testing purpose during development
            /**
            for (int i = 0; i < bulletChamber.Length; i++)
            {
                Console.WriteLine(bulletSlots.ElementAt(i));
            }
            Console.ReadLine();
            */
        }

        public void ResetStats()
        {
            SetPlayerWon(false);
            SetGameOver(false);
            score = 0;
        }

        // Fire's ammo
        private void FireBullet(bool bShootAway)
        {
            if (GetAvailableBullets() > 0)
            {
                bulletsAvailable--;
                if (bShootAway)
                {
                    if (bulletSlots.ElementAt(0) == 1)
                    {
                        SetErrorCode(0);
                        AddScore(150);
                        SetPlayerWon(true);
                        SetGameOver(true);
                    }
                    else
                    {
                        AddScore(10);
                        SetErrorCode(3);
                    }
                }
                else
                {
                    if (bulletSlots.ElementAt(0) == 1)
                    {
                        SetGameOver(true);
                        AddScore(0);
                        SetPlayerWon(false);
                        SetErrorCode(1);
                    }
                    else
                    {
                        AddScore(50);
                        SetErrorCode(3);
                    }
                }
                bulletSlots.AddLast(bulletSlots.ElementAt(0));
                bulletSlots.RemoveFirst();
            }
        }

        // Shoots away
        public void ShootAway()
        {
            shootAwayChances--;
            FireBullet(true);
        }

        // Shot's self
        public void Shoot()
        {
            FireBullet(false);
        }

        // Loads bullet in revolver
        private void LoadBullets()
        {
            for (int i = 0; i < GetMaxBullets(); i++)
            {
                if (i < 1 || i > 1)
                {
                    bulletChamber[i] = 0;
                }
                else
                {
                    bulletChamber[i] = i;
                }
                bulletsAvailable = bulletChamber.Length;
            }
        }

        // Shuffles the bullet chamber
        private void ShuffleChamberBullets(int[] arr)
        {
            int n = arr.Length;
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                swap(arr, i, i + random.Next(n - i));
            }
        }

        // Swaps bullets to make it totally random
        private static void swap(int[] arr, int a, int b)
        {
            // Swap all index's
            int randomInt = arr[a];
            arr[a] = arr[b];
            arr[b] = randomInt;
        }
    }
}
