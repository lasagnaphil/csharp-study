
namespace Sokoban
{
    public class Player : Entity
    {
        public Player(int x, int y) : base(x, y, '@')
        {
        }

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
                    if (block.TryMove(game, dx, dy))
                    {
                        Move(game, dx, dy);
                        return true;
                    }
                    return false;
                }
                else
                {
                    Move(game, dx, dy);
                    return true;
                }
            }
        }
    }
}