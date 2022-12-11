// See https://aka.ms/new-console-template for more information
namespace MusicHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            var music = new Music();
            music.Name = "Ripple";
            music.Artist = "Grateful Dead";
            music.ReleaseDate = new DateTime(11, 1, 1970);
        }
    }
}
