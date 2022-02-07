static void PigLatinTranslator(char[] buf, int off, int len)
{
    const string suffix = "ay";
    string entry ;
}

//Welcome message

Console.WriteLine("Welcome to the Pig Latin Translator!");

do

{
    Console.WriteLine("Enter a line to be translated: ");

    string word = Console.ReadLine();

    int Vowel = -1;
    foreach (char letter in word)
    {
        Vowel = Vowel + 1;
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        {
            break;
        }

    }

    string PigLatin = "";
    string before = "";
    string after = "";

    switch (Vowel)

    {
        case 0:
            PigLatin = word + "way";
            break;
        case 1:
            before = word.Substring(0, 1);
            after = word.Substring(1);
            PigLatin = after + before + "ay";
            break;
        case 2:
            before = word.Substring(0, 2);
            after = word.Substring(2);
            PigLatin = after + before + "ay";
            break;
        case 3:
            before = word.Substring(0, 3);
            after = word.Substring(3);
            PigLatin = after + before + "ay";
            break;
        case 4:
            before = word.Substring(0, 4);
            after = word.Substring(4);
            PigLatin = after + before + "ay";
            break;
        case 5:
            before = word.Substring(0, 5);
            after = word.Substring(5);
            PigLatin = after + before + "ay";
            break;
        default:
            PigLatin = "Invalid Input";
            break;

            string[] sentence = "".Split();

            string translation = "";
            foreach (string words in sentence)
            {
                translation = translation + word;
            }
            Console.WriteLine(translation.Substring(0, translation.Length - 1));
    }
    

    {
        //Result
        Console.WriteLine("Translation:" + PigLatin);

        //Loop
        Console.WriteLine("Would you like to enter another word? y/n");
        string choice = Console.ReadLine();
        if (choice == "y")
        {
            continue;
        }
        else if (choice == "n") ;
        {
            break;
        }
    }
}
while (true);