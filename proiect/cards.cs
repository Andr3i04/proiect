using System;
using System.Drawing;
using System.IO;

namespace proiect
{
    public class Card
    {
        public string Suit { get; set; }
        public string Rank { get; set; }
        public Image Image { get; set; }


        public Card(string rank, string suit)
        {
            Rank = rank;
            Suit = suit;
            LoadCardImage();
        }

        private void LoadCardImage()
        {
            string imageFolder = Path.Combine("D:\\", "proiect", "imagini");
            string imageName = $"{Rank}_of_{Suit}.png";
            string imagePath = Path.Combine(imageFolder, imageName);

            if (File.Exists(imagePath))
            {
                Image = Image.FromFile(imagePath);
            }
            else
            {
                throw new FileNotFoundException($"Card image not found: {imagePath}");
            }
        }
       
    }


}
