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
            uploadedVideos.Add(video);
        }
        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User: " + Username);
            int counter = 1;
            for (int i = 0; i < uploadedVideos.Count;i++)
            {
                Console.WriteLine("\nVideo " + counter + " judul: " + uploadedVideos[i].GetTitle());
                counter++;
            }
        }
    }
}
