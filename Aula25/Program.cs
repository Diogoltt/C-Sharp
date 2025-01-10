/* namespace Aula25
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        // Construtor no struct é obrigatório inicializar todos
        // os campos e ter parametros nele

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double Distance(Point p)
        {
            X = 10;
            return Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2));
        }
    }

    public class Player
    {
        public Player(string name, Point position)
        {
            Name = name;
            Position = position;
        }

        public string Name { get; set; }
        public Point Position { get; set; }

        public void Move(Point newPosition)
        {
            Position = newPosition;
            newPosition.X = 10;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(10, 20);
            var p2 = new Point(20, 30);

            System.Console.WriteLine($"A distância entre p1 e p2: {p1.Distance(p2)}");

            var player = new Player("Jogador 1", p1);
            System.Console.WriteLine($"Posição do jogador 1: {player.Position.X}, {player.Position.Y}"); 
        
            player.Move(p2);

        }
    }
}
 */