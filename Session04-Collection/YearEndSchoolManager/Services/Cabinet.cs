using Repositories.Entities;

namespace Services
{
    public class Cabinet <T>
    {
        private T[] _list = new T[300];
        private int _count = 0;

        public void PrintList()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_list[i]);
            }
        }
        public void Add(T item) //Add new Type() outside
        {
            _list[_count] = item;
            _count++;
        }
    }
}
