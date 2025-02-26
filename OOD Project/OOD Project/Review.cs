using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    public class Review
    {
        public string reviewText {  get; set; }
        int reviewScore { get; set; }
        public Review(string T, int S) 
        {
            reviewText = T;
            reviewScore = S;
        }

    }
}
