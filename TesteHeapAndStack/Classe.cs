namespace TesteHeapAndStack;

public class Classe {
    static void Main(string[] args) {
        int score = 95;
        int score2 = score;
        Console.WriteLine("Score = {0}, Score2 = {1}", score, score2);
        score2 = 97;
        Console.WriteLine("Score = {0}, Score2 = {1}", score, score2);

        Report report = new Report() {
            Titulo = "First Report",
            Descricao = "Descrição do primeiro Report",
            Paginas = 11
        };
        Report report2 = report;
        Console.WriteLine(report.Display());
        Console.WriteLine(report2.Display());

        report2.Paginas = 999;
        report.Descricao = "Descrição alterada";

        Console.WriteLine(report.Display());
        Console.WriteLine(report2.Display());
        Console.WriteLine("Score = {0}", score);
        Console.WriteLine("Object Pages = {0}", report.Paginas);

        ProcessIt(score, report);

        Console.WriteLine("Score = {0}", score);
        Console.WriteLine("Object Pages = {0}", report.Paginas);

        Console.ReadLine();
    }

    static void ProcessIt(int s, Report r) {
        s = 1111;
        r.Paginas = 11111;

    }
    struct Report {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Paginas { get; set; }

        public string Display() {
            return string.Format("{0}: {1},pp.{2}", Titulo, Descricao, Paginas);
        }
    }


}