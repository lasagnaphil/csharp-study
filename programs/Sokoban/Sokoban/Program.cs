namespace Sokoban
{
    class Program
    {
        static void Main(string[] args)
        {
            MapLoader mapLoader = new MapLoader();
            mapLoader.Load();
            mapLoader.Run();
        }

    }
}
