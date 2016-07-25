namespace Sokoban
{
    public class Tile
    {
        public char Symbol { get; protected set; }

        public Tile(char symbol)
        {
            Symbol = symbol;
        }
    }
    public class Wall : Tile
    {
        public Wall() : base('□') { }
    }

    public class Floor : Tile
    {
        public Floor() : base(' ') { }
    }

    public class Slot : Tile
    {
        public char SymbolWhenEmpty { get; private set; } = '○';
        public char SymbolWhenFilled { get; private set; } = '●';

        private bool isFilled = false;
        public bool IsFilled
        {
            get { ... }
            set
            {
                ...
            }
        }

        public Slot() : base('○')
        {
            Symbol = SymbolWhenEmpty;
        }
    }
}
