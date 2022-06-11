using GameObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitTheCoconut
{
    internal class FruitPictureBox : PictureBox
    {
        private readonly IFruit fruit;
        private readonly Random rdmPosition;
        public FruitPictureBox(IFruit fruit)
        {
            this.fruit = fruit;
            rdmPosition = new Random();
        }

        public IFruit Fruit => this.fruit;

        public virtual void SetBoxConfigurations(int width, int height)
        {
            this.Size = new Size(60, 60);
            int x = rdmPosition.Next(200, width - this.Width - 20);
            int y = rdmPosition.Next(20, height - this.Height - 100);
            this.Location = new Point(x, y);

            this.BackgroundImage = new Bitmap(fruit.ImgPath);
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
