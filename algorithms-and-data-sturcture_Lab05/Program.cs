//Using Stacks and Queues where appropriate, create a simple command line playlist app
//that allows a user to add a song to a playlist.
//Provide commands to play the next song, skip the upcoming song,
//or add a new song to the playlist.
//Users should be able to rewind by one song many times to play a previous track.

Console.WriteLine();
Console.WriteLine("---------------create a simple command line playlist app-----------------");


Queue<string> playlist = new Queue<string>();
string[] playlistArray = playlist.ToArray();
bool playlistRunning = true;



while (playlistRunning)
{
    Console.WriteLine();
    Console.WriteLine("---------Please choose an Option-----------");
    Console.WriteLine("1. Add a song to your playlist");
    Console.WriteLine("2. Play the next song in your playlist");
    Console.WriteLine("3. Skip the next song");
    Console.WriteLine("4. Rewind one song");
    Console.WriteLine("5. Exit");
    Console.WriteLine();


    int option = int.Parse(Console.ReadLine());

    while (option < 1 || option > 5)
    {
        Console.WriteLine("Please enter a valid option");
        break;
    }

    while (option == 1)
    {
        Console.WriteLine("Add a song to your playlist");
        Console.WriteLine("Please Enter Song Name:");
        string songName = Console.ReadLine();
        playlist.Enqueue(songName);
        Console.WriteLine($"{songName} added to your playlist");
        Console.WriteLine("1. Add a song to your playlist");
        Console.WriteLine("2. Play the next song in your playlist");
        Console.WriteLine("3. Skip the next song");
        Console.WriteLine("4. Rewind one song");
        Console.WriteLine("5. Exit");
        option = int.Parse(Console.ReadLine());

    }

    int i = 0;
    while (option == 2)
    {
        Console.WriteLine(i);
        if (playlist.Count > 0)
        {
            playlistArray = playlist.ToArray();

            if (i < playlistArray.Length)
            {
                Console.WriteLine("Play the next song in your playlist");
                Console.WriteLine("Now playing the song:");
                Console.WriteLine(playlistArray[i]);
                Console.WriteLine($"next song: {playlistArray[i + 1]}");
                i++;
            }
            else if (i == playlistArray.Length)
            {
                Console.WriteLine("Please enter ");
            }

            Console.WriteLine("1. Add a song to your playlist");
            Console.WriteLine("2. Play the next song in your playlist");
            Console.WriteLine("3. Skip the next song");
            Console.WriteLine("4. Rewind one song");
            Console.WriteLine("5. Exit");
            option = int.Parse(Console.ReadLine());

        }
    }


    while (option == 3)
    {
        if (playlist.Count > 0)
        {
            playlistArray = playlist.ToArray();

            if (i < playlistArray.Length - 2)
            {
                Console.WriteLine("Play the next song in your playlist");
                Console.WriteLine("Now playing the song:");
                Console.WriteLine(playlistArray[i]);
                Console.WriteLine($"next song: {playlistArray[i + 2]}");
                i++;
            }
            else if (i == playlistArray.Length)
            {
                Console.WriteLine("Please enter ");
            }

            Console.WriteLine("1. Add a song to your playlist");
            Console.WriteLine("2. Play the next song in your playlist");
            Console.WriteLine("3. Skip the next song");
            Console.WriteLine("4. Rewind one song");
            Console.WriteLine("5. Exit");
            option = int.Parse(Console.ReadLine());

        }
    }



    while (option == 4)
    {
        Console.WriteLine(i);

        if (i > 1)
        {
            playlistArray = playlist.ToArray();
            Console.WriteLine("Play the next song in your playlist");
            Console.WriteLine("Now playing the song:");
            Console.WriteLine(playlistArray[i - 2]);
            Console.WriteLine($"next song: {playlistArray[i - 1]}");
            i--;


        }

        Console.WriteLine("1. Add a song to your playlist");
        Console.WriteLine("2. Play the next song in your playlist");
        Console.WriteLine("3. Skip the next song");
        Console.WriteLine("4. Rewind one song");
        Console.WriteLine("5. Exit");
        option = int.Parse(Console.ReadLine());

    }


    if (option == 5)
    {
        playlistRunning = false;
        Console.WriteLine("Playlist Stopeed, program Exit.");

    }


}

