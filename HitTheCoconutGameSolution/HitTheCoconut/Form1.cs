using GameObjects.Interfaces;
using GameObjects.Models;
using GameObjects.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace HitTheCoconut
{
    public partial class GameSkin : Form
    {
        private readonly List<FruitPictureBox> fruitBoxes;
        private readonly IScore score;
        private readonly IRepository<string> fruitsRepository;
        private readonly IFruitFactory<string> fruitFactory;
        public GameSkin()
        {
            fruitBoxes = new List<FruitPictureBox>();
            this.score = new Score();
            this.fruitsRepository = new FruitNamesRepository();
            this.fruitsRepository
                .Seed("apricot",
                    "blueberry",
                    "coconut",
                    "greenApple",
                    "mango",
                    "melon",
                    "peach",
                    "pomegranate",
                    "raspberry",
                    "redApple");

            fruitFactory = new FruitFactory();
            InitializeComponent();

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Thread.Sleep(300);
            Environment.Exit(0);
        }

        private void ExitBtn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Width += 30;
            btn.Height += 20;
        }

        private void ExitBtn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Width -= 30;
            btn.Height -= 20;
        }

        private void ReplayBtn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Width += 30;
            btn.Height += 20;
        }

        private void ReplayBtn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Width -= 30;
            btn.Height -= 20;
        }

        private void PauseBtn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Width += 30;
            btn.Height += 20;
        }

        private void PauseBtn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Width -= 30;
            btn.Height -= 20;
        }

        private void PlayBtn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            btn.Width += 30;
            btn.Height += 20;
        }

        private void PlayBtn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Width -= 30;
            btn.Height -= 20;
        }

        private void ReplayBtn_Click(object sender, EventArgs e)
        {

            score.ResetScore();
            foreach (var fruit in fruitBoxes)
            {
                this.Controls.Remove(fruit);
            }
            this.fruitBoxes.Clear();
            this.ChangeFruitsLabelContent();
            this.GameTimer.Start();
            this.PlayBtn.Enabled = true;
            this.ReplayBtn.Enabled = true;

        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            this.GameTimer.Stop();
            btn.Enabled = false;
            this.PlayBtn.Enabled = true;
            DisableAllFruitBoxes();
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            this.GameTimer.Start();
            btn.Enabled = false;
            this.PauseBtn.Enabled = true;
            EnableAllFruitBoxes();

        }

        private void CreateFruitBox()
        {
            var fruit = fruitFactory.CreateRandomFruit((IRandomItemGiver<string>) fruitsRepository);
            FruitPictureBox fruitPicBox = new FruitPictureBox(fruit);

            fruitPicBox.SetBoxConfigurations(this.ClientSize.Width, this.ClientSize.Height);

            fruitPicBox.Click += FruitPicBox_Click; ;

            fruitBoxes.Add(fruitPicBox);
            this.Controls.Add(fruitPicBox);
            
        }

        private void FruitPicBox_Click(object? sender, EventArgs e)
        {
            var fruitBox = (FruitPictureBox)sender;

            IFruit fruit = fruitBox.Fruit;

            int points = fruit.Points;
            
            this.score.AddPoints(points);

            if(this.score.TotalScore < -100)
            {
                GameOver("Sorry! Your score is under -100. Good luck next time!");
            }

            this.ScoreCounter.Text = this.score.ShowScore();

            this.Controls.Remove(fruitBox);
            this.fruitBoxes.Remove(fruitBox);
            this.ChangeFruitsLabelContent();
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            CreateFruitBox();
            this.ChangeFruitsLabelContent();

            if (fruitBoxes.Count >= 60)
            {
                GameOver("There are 60 or more fruits!!!");
            }

            this.ScoreCounter.Text = score.ShowScore();
        }

        private void GameSkin_Click(object sender, EventArgs e)
        {
            this.score.AddPoints(-5);

            if (this.score.TotalScore < -100)
            {
                GameOver("Sorry! Your score is under -100. Good luck next time!");
            }
        }

        private void GameOver(string msg)
        {
            this.GameTimer.Stop();
            var result = MessageBox.Show(msg, "Game over!", MessageBoxButtons.OK);

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                score.ResetScore();
                foreach (var fruit in fruitBoxes)
                {
                    this.Controls.Remove(fruit);
                }
                this.fruitBoxes.Clear();
                this.ChangeFruitsLabelContent();

            }
        }

        private void DisableAllFruitBoxes()
        {
            foreach (var fruit in fruitBoxes)
            {
                fruit.Enabled = false;
            }
        }

        private void EnableAllFruitBoxes()
        {
            foreach (var fruit in fruitBoxes)
            {
                fruit.Enabled = true;
            }
        }

        private void ChangeFruitsLabelContent()
        {
            this.FruitCounter.Text =  $"Fruits: {this.fruitBoxes.Count}";

            if(fruitBoxes.Count > 50)
            {
                this.FruitCounter.ForeColor = Color.Red;
            }
            else if(fruitBoxes.Count > 25)
            {
                this.FruitCounter.ForeColor = Color.Orange;
            }
            else
            {
                this.FruitCounter.ForeColor = Color.Green;
            }
        }
    }
}
