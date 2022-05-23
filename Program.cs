// Створити об'єкт класу Будинок, використовуючи класи Вікно, Двері.
// Методи: закрити на ключ, вивести на консоль кількість вікон, дверей.
var window = new Window(4);
var doors = new Door(2);
var house = new House(); 
house.String();
class House
{
    int windows, doors;
    public House()
    {
        this.windows = Window.window;
        this.doors = Door.door; 
    }
    public Window Window { get; set; }
    public Door Door { get; set; }
    public void String()
    {
        Console.WriteLine("Дверей: {doors} Вiкон: {windows}");
    }
}
class Window
{
    public int window;
    public Window(int windows)
    {
       window = windows;
    }
}
class Door
{
    public int door;
    public Door(int doors)
    {
        door = doors;
    }
}