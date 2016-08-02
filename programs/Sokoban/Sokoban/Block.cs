namespace Sokoban
{
    public class Block : Entity
    {
        public Block(int x, int y) : base(x, y, '■')
        { }

        public override bool TryMove(Game game, int dx, int dy)
        {
            int moveX = X + dx;
            int moveY = Y + dy;
            if (game.Grid[moveX, moveY] is Wall)
            {
                return false;
            }
            else
            {
                Block block = game.FindBlock(moveX, moveY);
                if (block != null)
                {
                    return false;
                }
                else
                {
                    Move(game, dx, dy);
                    return true;
                }
            }
        }

        protected override void Move(Game game, int dx, int dy)
        {
            Slot slot = game.Grid[X, Y] as Slot;
            if (slot != null)
            {
                slot.IsFilled = false;
            }

            base.Move(game, dx, dy);

            slot = game.Grid[X, Y] as Slot;
            if (slot != null)
            {
                slot.IsFilled = true;
            }
        }
    }
}