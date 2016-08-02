namespace Sokoban
{
    public abstract class Entity
    {
        public int X { get; protected set; }
        public int Y { get; protected set; }
        public char Symbol { get; protected set; }

        public abstract bool TryMove(Game game, int dx, int dy);
        protected virtual void Move(Game game, int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public Entity(int x, int y, char symbol)
        {
            X = x;
            Y = y;
            Symbol = symbol;
        }
    }
}