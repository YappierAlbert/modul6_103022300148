using modul6_103022300148;

class Program { 
    public static void Main(String[] args)
    {
        SayaTubeUser user = new SayaTubeUser("Bayu");
        string input;
        for (int i  = 0; i < 10; i++)
        {
            input = Console.ReadLine();
            SayaTubeVideo vd = new SayaTubeVideo(input);
            input = Console.ReadLine();
            vd.increasePlayCount(int.Parse(input));
            user.addVideo(vd);
        }
        Console.WriteLine("Total Play Count : "+user.getTotalVideoPlayCount());
        user.printAllVideoPlayCount();
    }
}