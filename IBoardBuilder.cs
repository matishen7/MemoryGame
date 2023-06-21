using static System.Net.Mime.MediaTypeNames;

namespace MemoryGame
{
    public interface IBoardBuilder
    {
       public Board Build();
    }
}
