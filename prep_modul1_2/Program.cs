namespace prep_modul1_2
{
    internal class Program
    {
        public static double MatrixSum(double[,] matrix)
        {
            double sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i <= j && matrix[i, j] > 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
        public static IList<IShape> InputShapesFromFile(string fileName)
        {
            IList<IShape> lst = new List<IShape>();
            fileName = Path.Combine(@"C:\Users\HP-PC\C#programming\garbage\prep_modul1_2", fileName);
            using (StreamReader sr = new StreamReader(fileName))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    var arr = s.Split(",");
                    if (arr[0] == "0")
                    {
                        lst.Add(new ColoredTriangle(new ColoredSide(arr[1], double.Parse(arr[2])),
                            new ColoredSide(arr[3], double.Parse(arr[4])), new ColoredSide(arr[5], double.Parse(arr[6]))));
                    }
                    else if (arr[0] == "1")
                    {
                        lst.Add(new Rectangle(double.Parse(arr[1]), double.Parse(arr[2])));
                    }
                }
            }
            return lst;
        }
        public static void ShowShapes(IEnumerable<IShape> lst)
        {
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            double[,] matrix = new double[4, 4]
            {
                {1, 2, 1, 0 },
                {1, 5, 6, 2 },
                {3, 7, 4, 4 },
                {4, 5, 5, 6 }
            };
            Console.WriteLine(MatrixSum(matrix));
            Console.WriteLine();

            var shapes = InputShapesFromFile("shape.txt");
            ShowShapes(shapes.OrderBy(x => x.Perimeter()));
            Console.WriteLine();

            var triangles = shapes.OfType<ColoredTriangle>().Where(x => x.EqualsSide());
            var lookUp = triangles.ToLookup(x => x.Side1.Color, x => x.Side1.Color);
            var dict = lookUp.ToDictionary(x => x.Key, x => x.Count());
            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }

        }
    }
}