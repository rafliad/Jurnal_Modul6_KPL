namespace modul6_1302223153
{
    public class SayaTubeUser
    {
        Random random = new Random();
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        string Username;
        public SayaTubeUser(string Username)
        {
            if (string .IsNullOrEmpty(Username))
                throw new ArgumentNullException("Nama username tidak berupa null");
            if (Username.Length > 100)
                throw new ArgumentException("Nama username memiliki panjang maksimal 100 karakter");
            this.Username = Username;
            uploadedVideos = new List<SayaTubeVideo>();
            id = random.Next(10000,99999);
        }
        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                total = total + uploadedVideos[i].GetPlayCount();
            }
            return total;
        }
        public void AddVideo(SayaTubeVideo video)
        {
            if (video == null)
                throw new ArgumentException("Video yang ditambahkan tidak berupa null");
            if (video.GetPlayCount() > Int32.MaxValue)
                throw new ArgumentException("Video yang ditambahkan punya playCount yang kurang dari bilangan integer maksimum");

            uploadedVideos.Add(video);
        }
        public void PrintAllVideoPlayCount()
        {
            
            Console.WriteLine("User: " + Username);
            int counter = 1;
            for (int i = 0; i < uploadedVideos.Count;i++)
            {
                if (counter <= 8)
                {
                    Console.WriteLine("\nVideo " + counter + " judul: " + uploadedVideos[i].GetTitle());
                    counter++;
                }
            }
        }
    }
}
