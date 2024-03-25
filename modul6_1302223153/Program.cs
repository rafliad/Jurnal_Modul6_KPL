namespace modul6_1302223153
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser user = new SayaTubeUser("Rafli");
            SayaTubeVideo video = new SayaTubeVideo("Review Film Interstellar oleh Rafli");
            user.AddVideo(video);
            video = new SayaTubeVideo("Review Film Breaking Bad oleh Rafli");
            user.AddVideo(video);
            video = new SayaTubeVideo("Review Film Better Call Saul oleh Rafli");
            user.AddVideo(video);
            video = new SayaTubeVideo("Review Film Inception oleh Rafli");
            user.AddVideo(video);
            video = new SayaTubeVideo("Review Film Oppenheimer oleh Rafli");
            user.AddVideo(video);
            video = new SayaTubeVideo("Review Film Tenet oleh Rafli");
            user.AddVideo(video);
            video = new SayaTubeVideo("Review Film True Sight oleh Rafli");
            user.AddVideo(video);
            video = new SayaTubeVideo("Review Film Your Name oleh Rafli");
            user.AddVideo(video);
            video = new SayaTubeVideo("Review Film El Camino oleh Rafli");
            user.AddVideo(video);
            video = new SayaTubeVideo("Review Film Dune oleh Rafli");
            user.AddVideo(video);
            user.PrintAllVideoPlayCount();
        }
    }
}
