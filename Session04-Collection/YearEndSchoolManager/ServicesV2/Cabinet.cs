using Repositories.Entities;

namespace ServicesV2
{
    //tủ/thùng chứa bên trong rất nhiều hồ sơ
    //Đựng đa dạng các loại object, muốn loại object nào thì truyền tên của loại object đó vào data type đưa vào, túi/tủ sẽ đựng đúng loại đó
    //để túi/tủ/thùng chứa thoải mái đồ, ko dùng mảng truyền thông mà thay = List<?>
    //Bài này kết hợp List và Generic
    public class Cabinet<T>
    {
        //private Student[] _list = new Student[300];
        //private T[] _list = new T[300];
        private List<T> _list = new List<T>();
        //ko cần biến count để đếm, tự biến _list, con trỏ, tên túi nó tính số lượng cho mình
        //CRUD THOẢI MÁI, KO LO TRÀN RAM
        public void PrintAll()
        {
            Console.WriteLine($"There is/ There are {_list.Count} item(s) in the list");
            foreach ( T x in _list ) 
            {
                Console.WriteLine( x ); //gọi thầm ToString() của T, T có thể là Student, Lecturer
            }
        }
        public void Add(T item)
        {
            _list.Add( item ); //khỏi cần count++ như chơi mảng
        }
        
        //hàm UD
    }
}
