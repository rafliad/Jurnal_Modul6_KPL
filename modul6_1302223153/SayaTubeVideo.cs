using System.Diagnostics.Contracts;

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
            if (string .IsNullOrEmpty(title))
                throw new ArgumentNullException("Judul video tidak boleh kosong");
            if (title.Length > 200)
                throw new ArgumentException("Panjang judul video maksimal 200 karakter");

            this.title = title;
            id = random.Next(10000, 99999);
            playCount = 0;
        }
        private void IncreasePlayCount(int playCount)
        {
            if (playCount > 25000000)
                throw new ArgumentException("Input penambahan play count maksimal 25.000.000 per panggilan method-nya");
            if (playCount < 0)
                throw new ArgumentException("Input play count tidak berupa bilangan negatif");
            try
            {
                checked
                {
                    this.playCount += playCount;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
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
        public void setPlayCount(int playCount)
        {
            IncreasePlayCount(playCount);
        }
    }
}
