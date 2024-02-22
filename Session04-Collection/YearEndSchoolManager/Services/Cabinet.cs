using Repositories.Entities;

namespace Services
{
    public class Cabinet <T>
    {
        private T[] _list = new T[300]; //max _list[299]
        private int _count = 0;         //mảng: fix cố định kích thước, số phần tử
                                        //số biến ko đc vuột quá số đã in từ đầu
                                        //dùng mảng  co giãn kích thước: List, ArrayList

        public void PrintList()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_list[i]);
            }
        }

        public void Add(T item)
        {
            _list[_count] = item; //item is a new Student() outside
            _count++;
        }                         //        a new Lecturer() outside
                                  //        

    }
}
