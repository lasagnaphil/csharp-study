namespace Sokoban
{
    public class Block : Entity
    {
        public Block(int x, int y) : base(x, y, '■')
        { }

        public override bool TryMove(Game game, int dx, int dy)
        {
            ...
        }

        protected override void Move(Game game, int dx, int dy)
        {
            ...
        }
    }
