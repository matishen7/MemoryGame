using static System.Net.Mime.MediaTypeNames;

namespace MemoryGame
{
    public interface IBoardBuilder
    {
        private void GetImages()
        {
        }

        public Board Build();

        public T PickRandomElement<T>(List<T> list, List<int> times);
    }
}
