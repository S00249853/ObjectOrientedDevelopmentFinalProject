using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace OOD_Project
{
    public class Game
    {
        string gameName { get; set; }
        List<Review> reviews { get; set; }
        int rating { get; set; }
        BitmapImage gameImage { get; set; }

        public Game(string Name, BitmapImage image) 
        {
            gameName = Name;
            gameImage = image;
        }
       
    }
}
