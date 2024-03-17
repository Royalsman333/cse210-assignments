using System;
//Develop 3 Program
//Jeremy Untch
class Program
{
    //This class will help make values for each word in the scriptures
    class Word
    {
        public string Text { get; private set; }
        public bool IsHidden { get; set; }

        public Word(string text)
        {
            Text = text;
            IsHidden = false;
        }

        public override string ToString()
        {
            if (IsHidden)
            {
                //Having the value set to one dash per "text.Length" will mean that words with 4 characters will have 4 dashes, where as words with 2 will have 2. I thought it looked visually better
                return new string('_', Text.Length);
            }
            else
            {
                return Text;
            }

        }
    }

    //This class will define the scripture reference. These next few parts will help me make sure that my scriptures will only hide words in the scripture, instead of the "Reference"
    class ScriptureReference
    {
        public string Reference { get; private set; }

        public ScriptureReference(string reference)
        {
            Reference = reference;
        }

        public override string ToString()
        {
            return Reference;
        }
    }

    //This defines the scriptures. It will call upon the other class to separate the scripture and the reference.
    class Scripture
    {
        private Word[] words;
        private ScriptureReference reference;

        public Scripture(string reference, string text)
        {
            this.reference = new ScriptureReference(reference);
            string[] wordArray = text.Split(' ');
            words = new Word[wordArray.Length];
            for (int i = 0; i < wordArray.Length; i++)
            {
                words[i] = new Word(wordArray[i]);
            }
        }

    //This will make it so a random word will be hidden. This will make sure that words that are already hidden will not be targetted twice.
        public void HideRandomWord()
        {
            Random rand = new Random();
            bool found = false;
            while (!found)
            {
                int index = rand.Next(words.Length);
                if (!words[index].IsHidden)
                {
                    words[index].IsHidden = true;
                    found = true;
                }
            }
        }

    //Once all of the words are hidden, it will label them as hidden. This will help me get out of the loop even if the scripture is very long or very short.
        public bool AllWordsHidden()
        {
            foreach (Word word in words)
            {
                if (!word.IsHidden)
                {
                    return false;
                }
            }
            return true;
        }

    //I used this to help me later on. I came across a problem where the program ended with one word not hidden yet (because of the values that I set earlier)
    //To fix it, I made this which will set them all to invisible and I will call upon it later.
        public void HideAllWords()
        {
            foreach (Word word in words)
            {
                word.IsHidden = true;
            }
        }
        public override string ToString()
        {
            return $"{reference}\n{string.Join(" ", Array.ConvertAll(words, w => w.ToString()))}";
        }

    }

    static void Main(string[] args)
    {
        //These are the scriptures. I can add more if needed by adding a comma behind each scripture (except for the last one) and then following the same format as the others.
        Scripture[] scriptures = new Scripture[]
        {
            new Scripture("1 Nephi 21:16", "Behold, I have graven thee upon the palms of my hands."),
            new Scripture("2 Nephi 23:3", "Angels speak by the power of the Holy Ghost; wherefore, they speak the words of Christ. Wherefore, I said unto you, feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do."),
            new Scripture("Ether 12:4", "Wherefore, whoso believeth in God might with surety hope for a better world, yea, even a place at the right hand of God, which hope cometh of faith, maketh an anchor to the souls of men, which would make them sure and steadfast."),
            new Scripture("2 Corinthians 4:16-18", "So we do not lose heart. Though our outer self is wasting away, our inner self is being renewed day by day. For this light momentary affliction is preparing for us an eternal weight of glory beyond all comparison, as we look not to the things that are seen but to the things that are unseen. For the things that are seen are transient, but the things that are unseen are eternal.")
        };

        Random rand = new Random();
        bool shouldContinue = true;
        
        //This will set one of the random scriptures to the one that we will use during this program. Each time the program resets, this value is reset.
        Scripture currentScripture = scriptures[rand.Next(scriptures.Length)];

        //This loop is made to make sure that the program does not end until all of the words are hidden in the scripture.
        while (shouldContinue)
        {
        //I use Console.Clear at the beginning to clear off the console. Then I use Console.WriteLine to print of the scripture, but in its updated state.
            Console.Clear();
            Console.WriteLine(currentScripture);

            Console.WriteLine("\nPress enter to continue or type 'quit' to end program: ");
            string input = Console.ReadLine().Trim();
        //If the user types 'quit' then the program will end as the "shouldContinue" value will be set to false, ending the loop.
            if (input.ToLower() == "quit")
            {
                shouldContinue = false;
            }
        //If the user inputs anything besides quit (such as enter) then it will call upon hiding a random word.
            else
            {
                currentScripture.HideRandomWord();
                //This checks to see if all of the words have been hidden. If they are then this activates, if not then the program resets.
                if (currentScripture.AllWordsHidden())
                {
                //This is how I fixed my problem that I stated earlier. I first reset the Console, then I set all of the scriptures to be hidden.
                //I then reprint the scripture, which now has all of the words hidden. I added the message here because if the user 'quits' early, the message wouldnt make sense.
                //shouldContinue is then set to false, which ends the loop.
                    Console.Clear();
                    foreach (Scripture scripture in scriptures)
                        {
                            scripture.HideAllWords();
                        }
                    
                    Console.WriteLine(currentScripture); 
                    Console.WriteLine("\nNow that the scripture is completely covered,try and repeat the scripture from memory!");                   
                    shouldContinue = false;
                }
            }
        }
    //I then have this fairwell message to let the user know that the program has ended. This will always show.
     Console.WriteLine("\nThank you for using my program. Restart the program for a new scripture to learn!");
    }
}
