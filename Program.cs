using System.Text;

namespace Task1
{
    public static class Class1
    {
        // Record type:
        public record Song(
        string SongName,
        string? Performer = null,
        string? OriginalPerformer = null,
        string? Author = null,
        decimal? Duration = null,
        int? Year = null,
        string? Lable = null,
        string? Album = null,
        int? Number = null,
        string? Lyrics = null)
        {
            public override string ToString()
            {
                return
                    "The track " +
                    ((Number != null) ? $"{Number} - " : "") +
                    $"\"{SongName}\"" +
                    ((Duration != null) ? $" lasts {Duration}" : "") +
                    ((Performer != null) ? $" by \"{Performer}\"" : "") +
                    ((OriginalPerformer != null) ? $" (original by \"{OriginalPerformer})\"" : "") +
                    ((Author != null) ? $" written by {Author}" : "") +
                    ((Album != null) ? $" from the album \"{Album}\"" : "") +
                    ((Year != null) ? $" released in {Year}" : "") +
                    ((Lable != null) ? $" by label \"{Lable}\"" : "") +
                    ((Lyrics != null) ? $"\n\nLyrics:\n\n{Lyrics}" : "");
            }
        };

        public static Song diaka = new(
            "Дяка", "Haspyd",
            Year: 2019,
            Album: "Перехрестя двох вітрів",
            Lable: "Eternal Winter Records");

        // With expressions:
        public static Song otavaTrava = diaka with { SongName = "Отава-трава" };
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(diaka);
            Console.WriteLine(otavaTrava);
        }
    }
}

