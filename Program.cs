using System.Text;

namespace Console_educational_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.OutputEncoding = Encoding.UTF8;
            }
            MusicService spotify = new MusicService();
            spotify.Register("Brutal", "Gdragon");
            

            spotify.RemoveSong("Brutal", "Gdragon");
            spotify.Play("Brutal");
        }
    }
}
