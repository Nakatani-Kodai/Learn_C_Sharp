using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_C_Sharp.Classes
{
    public class Song
    {
        private string Title { get; set; }

        private string ArtistName { get; set; }

        private int Length { get; set; }


        public Song(string title, string artistName, int length)
        {
            this.Title = title;

            this.ArtistName = artistName;

            this.Length = length;

        }

        public void ConsoleResult()
        {
            System.Console.WriteLine(this.Title);
            System.Console.WriteLine(this.ArtistName);
            System.Console.WriteLine(this.calculateMinites(this.Length));
        }

        public string calculateMinites(int length)
        {
            int rest;
            int division = Math.DivRem(length, 60, out rest);
            return String.Format("{0}:{1}", division, rest);
        }

    }
}
