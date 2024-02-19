using System.Data;
using System.Runtime.Intrinsics.X86;

class Program
{

    public class DiaryEntry
    {
       public DateTime datum;
        public string? rubrik;
        public string? innehåll;
    }
    static void Main(string[] args)
    {
        List<DiaryEntry> diaryEntries = new List<DiaryEntry>();

        // Huvudmenyloop
        while (true)
        {
            Console.WriteLine("1. Läs dagboksinlägg");
            Console.WriteLine("2. Skapa nytt dagboksinlägg");
            Console.WriteLine("3. Avsluta");

            Console.Write("Välj ett alternativ: ");
            int val = Convert.ToInt32(Console.ReadLine());

            switch (val)
            {
                case 1:
                    ReadEntry(diaryEntries);
                    break;
                case 2:
                    CreateEntry(diaryEntries);
                    break;
                case 3:
                    Console.WriteLine("Avslutar programmet...");
                    return;
                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
        }
    }
    static void ReadEntry(List<DiaryEntry> diaryEntries)
    {
        //En if statement när dagboken är tom
        if (!diaryEntries.Any())
        {
            Console.WriteLine("Dagboken är tom");
            return;
        }

        //For loop - checkar varje inlägg
        for (int i = 0; i < diaryEntries.Count; i++)
        {
            Console.WriteLine("Rubrik: {0}, Datum: {1} ", diaryEntries[i].rubrik, diaryEntries[i].datum);
        }
        //Val på inläggen genom att mata in rubrik 
        Console.Write("Mata in rubriken du vill läsa: ");
        string val = Console.ReadLine();

        for (int i = 0;i < diaryEntries.Count;i++)
        {
            if (diaryEntries[i].rubrik == val)
            {
                Console.WriteLine("Rubrik: {0}\nDatum:{1}\nInnehåll:\n{2}", diaryEntries[i].rubrik, diaryEntries[i].datum, diaryEntries[i].innehåll);
                break;
            }

        }
    }
    static void CreateEntry(List<DiaryEntry> diaryEntries)
    {
        DiaryEntry newList = new DiaryEntry();
        Console.Write("Ange rubrik: ");
        newList.rubrik = Console.ReadLine();
        Console.Write("Ange innehåll: ");
        newList.innehåll = Console.ReadLine();
        newList.datum = DateTime.Now;
        diaryEntries.Add(newList);
        Console.WriteLine("Dagboksinlägg skapat");
    }
}