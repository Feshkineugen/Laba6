internal class House
{
    public string Address { get; set; }
    public int Floor { get; set; }
    public int RoomCount { get; set; }
    public double Square { get; set; }

    public override string ToString()
    {
        return $"Адрес: {Address}, Этаж: {Floor}, Количество комнат: {RoomCount}, Площадь: {Square}";
    }
    class Public
    {
    
        public string Name;

        // Создаем параметрический конструктор
        public Public(string s)
        {
            Name = s;

        }

        public void reWrite()
        {
            Console.WriteLine("Имя жильца: {0}", Name);
        }
    }
    class Spisok
    {
        static void Main(string[] args)
        {
            Public ex = new("Александр");
           
            ex.reWrite();

            Console.ReadLine();
        }
    }
    ~House()
    {
        Console.WriteLine("Объект {0} уничтожен");
    }
}
