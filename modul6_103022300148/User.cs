using System;
using System.Collections.Generic;
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
            uploadedVideo.Add(v);
        }
        public void printAllVideoPlayCount() {
            int i = 1;
            Console.WriteLine("User : " + this.username);
            foreach(SayaTubeVideo vd in uploadedVideo)
            {
                Console.WriteLine("Video " + i + " judul: " + vd.getTitle());
                i++;
            }
        }
    }
}
