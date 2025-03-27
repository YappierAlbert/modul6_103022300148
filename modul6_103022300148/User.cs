using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300148
{
    class SayaTubeUser
    {
        private int id;
        public string username;
        private List<SayaTubeVideo> uploadedVideo;
        Random rd = new Random();
        public SayaTubeUser(string username)
        {
            Debug.Assert(username.Length <= 100, "username tidak boleh lebih dari 100 karakter");
            Debug.Assert(username != "", "username tidak boleh kosong");
            this.username = username;
            id = rd.Next(10000, 99999);
            uploadedVideo = new List<SayaTubeVideo>();
        }
        public int getTotalVideoPlayCount()
        {
            int total = 0;
            foreach(SayaTubeVideo vd in uploadedVideo)
            {
                total += vd.getPC();
            }
            return total;
        }
        public void addVideo(SayaTubeVideo v)
        {
            Debug.Assert(v != null);
            Debug.Assert(v.getPC() < int.MaxValue);
            uploadedVideo.Add(v);
        }
        public void printAllVideoPlayCount() {
            int i = 1;
            Console.WriteLine("User : " + this.username);
            foreach (SayaTubeVideo vd in uploadedVideo)
            {
                Debug.Assert(i < 9, "Hanya Dapat Menampilkan 8");
                Console.WriteLine("Video " + i + " judul: " + vd.getTitle());
                i++;
            }
            
        }
    }
}
