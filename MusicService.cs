using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project
{
    public class MusicService
    {
        List<Track> music_library = new List<Track>();
        public void Register(string song_title, string artist_name)
        {
            Track track = new Track(song_title, artist_name);
            music_library.Add(track);
            Console.WriteLine($"Песня {track.Title} артиста {track.Artist} успешно зарегистрирована!");

        }

        public void RemoveSong(string song_title, string artist_name)
        {
            Track songToRemove = null; 

            foreach (var track in music_library)
            {
                if ((track.Title == song_title) && (track.Artist == artist_name))
                {
                    songToRemove = track;
                    break; 
                }
            }

            if (songToRemove != null)
            {
                music_library.Remove(songToRemove);
                Console.WriteLine($"Песня {songToRemove.Title} артиста {songToRemove.Artist} удалена!");
            }
            else
            {
                Console.WriteLine($"Песня {song_title} артиста {artist_name} не существует");
            }

        }

        public void Play(string song_title)
        {
         
        }
    }
}