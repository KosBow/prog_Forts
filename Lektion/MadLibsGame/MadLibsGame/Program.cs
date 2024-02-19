namespace MadLibsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //                   ---MAD LIBS GAME---
            string adjective, typeOfBird, roomInHouse, verb, verbPastTense, relativesName, noun, liquid, verbIng, partOfBody, pluralNoun;

            adjective = inmating ("Enter an adjective, ex: old, good, big, small, hot, easy etc: ");
            
            typeOfBird = inmating ("Enter a type of bird, ex: owl, parrot, eagle, woodpecker etc ");
            roomInHouse = inmating ("Enter a room in a house, ex: bathroom, kitchen, dining room, living room etc ");
            verbPastTense = inmating ("Enter a verb (past tense) ex: walked, raned, jumped, talked etc ");
            verb = inmating ("Enter a verb ex: drive, with, cry, push, try etc ");
            relativesName = inmating ("Enter a relatives name ex: John, Lisa, Marcus, Zeus, Ali etc ");
            noun = inmating ("Enter a noun ex: flower, army, dog, book, desk, chair etc ");
            liquid = inmating ("Enter a liquid ex: water, soda, alcohol, urine etc ");
            verbIng = inmating ("Enter a verb ending in -ing ex: painting, waiting, staying, starting etc ");
            partOfBody = inmating ("Enter a part of the body (plural) ex: toes, arms, eyes, legs, fingers etc ");
            pluralNoun = inmating ("Enter a plural noun ex: cats, horses, rivers, cars, boats, boxes, spies etc ");

            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("It was a " + adjective + ", cold november day.");
            Console.WriteLine("I woke up to the " + adjective + " smell of " + typeOfBird);
            Console.WriteLine("roasting in the " + roomInHouse + " downstairs.");
            Console.WriteLine("I " + verbPastTense + " down the stairs to see if I could help " + verb + " the dinner.");
            Console.WriteLine("My mom said, \"See if " + relativesName + "\" " + " needs a fresh " + noun);
            Console.WriteLine("So I carried a tray of glasses full of " + liquid + " into the " + verbIng + " room.");
            Console.WriteLine("When I got there, I couldn't believe my " + partOfBody + "!");
            Console.WriteLine("There were " + pluralNoun + " " + verbIng + " on the " + noun + "!");

            Console.ReadLine();
        }
        static string inmating (string info)
        {
            Console.Write(info);
            return Console.ReadLine();
        }
    }
}
