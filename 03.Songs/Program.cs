/*
 * 03.Songs
 */

namespace _03.Songs
{
    class Program
    {
        static void Main()
        {
            //= debug =//
            //3
            //favourite_DownTown_3:14
            //favourite_Kiss_4:16
            //favourite_Smooth Criminal_4:01
            //favourite
            //= debug =//

            byte songsCount = byte.Parse(Console.ReadLine() ?? "6");
            List<Song> songs = new();
            for (int i = 0; i < songsCount; i++)
            {
                string[] definition = (Console.ReadLine() ?? "Favorites_KilligInside_6:66").Split('_');
                Song currentPlay = new()
                {
                    Title = definition[1],
                    Duration = definition[2],
                    Playlist = definition[0]
                };

                songs.Add(currentPlay);
            }

            string playlistName = Console.ReadLine() ?? "Favorites";
            switch (playlistName)
            {
                case "all":
                    songs.ForEach(song => Console.WriteLine(song.Title));
                    break;
                default:
                    List<Song> filteredSongs = songs
                        .Where(song => song.Playlist == playlistName)
                        .ToList();
                    filteredSongs.ForEach(song => Console.WriteLine(song.Title));
                break;
            }
        }     
    }
}