namespace modul6_1302223153
{
    public class SayaTubeVideo
    {
        Random random = new Random();
        private int id;
        private string title;
        private int playCount;
        public SayaTubeVideo(string title)
        {
            this.title = title;
            id = random.Next(10000, 99999);
            playCount = 0;
        }
        private void IncreasePlayCount(int playCount)
        {
            this.playCount = playCount;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("Title: " + title + "\nId: " + id + "\nPlay Count: " + playCount);
        }
        public int GetPlayCount()
        {
            return playCount;
        }
        public string GetTitle()
        {
            return title;
        }
    }
}
