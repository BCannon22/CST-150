class program
{
    static void Main(string[] args)
    {
        StreamWriter outputFile = File.CreateText("TextFile.txt");          //Creates text file.
        outputFile.WriteLine("Don't be late, teatime will not wait, the Mad Hatter will be taking part!");
        outputFile.Close();
        
        StreamReader textFile = File.OpenText("TextFile.txt");        //Reads from newly created text file, turns it into a string, and shows in console.
        string text = textFile.ReadToEnd();
        Console.WriteLine(text);
        Console.ReadLine();

        char[] delim = { ';', '.', '!', ',', '?', ' '};  //Takes out special characters.
        string[] splitText = text.Split(delim, StringSplitOptions.RemoveEmptyEntries);    //Splits the string into an array.
        
        int matches = 0;
        int index;
        
        for(index = 0; index < splitText.Length; index++)    //Searches for characters that end with either t or e.
        {     
            if (splitText[index].EndsWith("t") || splitText[index].EndsWith("e"))
            {
                matches++;
            }
        }

        Console.WriteLine("There were: " + (splitText.Length - 1) + " words");     //Outputs results
        Console.WriteLine("There was " + matches + " words that end in t or e.");
    }
}