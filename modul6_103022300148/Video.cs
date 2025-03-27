using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300148
{
    class SayaTubeVideo
    {
        private int id, playCount;
        private string title;
        Random rd = new Random();
        public SayaTubeVideo(string title)
        {
            Contract.Requires(title.Length <= 200,"judul tidak boleh lebih dari 200 karakter");
            Contract.Requires(title != "","judul tidak boleh kosong");
            id = rd.Next(10000, 99999);
            this.title = title;
            playCount = 0;
        }
        public void increasePlayCount(int x)
        {
            Contract.Requires(x <= 25000000,"penambahan view tidak boleh lebih dari 25juta sekaligus");
            Contract.Requires(x > 0,"penambahan view tidak boleh dibawah 0");
            try
            {
                checked
                {
                    playCount += x;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error Overflow");
            }
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Judul Video : " + title);
            Console.WriteLine("Jumlah View : " + playCount);
        }
        public int getPC() {
            return this.playCount;
        }
        public string getTitle() {
            return this.title;
        }
    }
}
