using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class SaleReport
    {
        int mid;
        string movieTitle;
        int count;
        string genre;

        public SaleReport(int newMid, string newMovieTitle, int newCount)
        {
            mid = newMid;
            movieTitle = newMovieTitle;
            count = newCount;
        }

        public int Mid { get => mid; set => mid = value; }
        public string MovieTitle { get => movieTitle; set => movieTitle = value; }
        public int Count { get => count; set => count = value; }
        public string Genre { get => genre; set => genre = value; }
    }
}
