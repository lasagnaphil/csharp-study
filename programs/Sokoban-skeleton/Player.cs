
namespace Sokoban
{
    public class Player : Entity
    {
        public Player(int x, int y) : base(x, y, '@')
        {
        }

        public override bool TryMove(Game game, int dx, int dy)
        {
            ...
        }
    }
}
