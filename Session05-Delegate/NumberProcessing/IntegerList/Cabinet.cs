using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerList
{
    internal class Cabinet
    {
        List<int> _arr = new List<int>();    
        public void AddNumber(int num) => _arr.Add(num);    
        public void PrintAll()
        {
            Console.WriteLine($"There is/are {_arr.Count} number(s) int the list");
            foreach (var x in _arr)
            {
                Console.WriteLine(x);
            }
        }

        //in các số chẵn, lẻ, tổng,... -> các hàm xử lkis danh sách, dãy số sẽ nằm ở đâu
        //VÔ SỐ HÀM TÙY THEO NHU CẦU!!


    }
}
