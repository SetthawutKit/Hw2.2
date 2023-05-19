class Program
{
    static bool IsValidSequence(string halfDNASequence)
    {
        foreach (char nucleotide in halfDNASequence)
        {
            if (!"ATCG".Contains(nucleotide))
                return false;
        }
        return true;
    }

    static string ReplicateSequence(string halfDNASequence)
    {
        char[] nucleotides = halfDNASequence.ToCharArray();
        for (int i = 0; i < nucleotides.Length; i++)
        {
            int index = "ATCG".IndexOf(nucleotides[i]);
            nucleotides[i] = "TAGC"[index];
        }
        return new string(nucleotides);
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Enter a half DNA sequence: ");
            string halfDNASequence = Console.ReadLine();

            if (IsValidSequence(halfDNASequence))
            {
                Console.WriteLine("Current half DNA sequence: " + halfDNASequence);

                while (true)
                {
                    Console.Write("Do you want to replicate it? (Y/N): ");
                    string replicateOption = Console.ReadLine().ToUpper();

                    if (replicateOption == "Y")
                    {
                        string replicatedSequence = ReplicateSequence(halfDNASequence);
                        Console.WriteLine("Replicated half DNA sequence: " + replicatedSequence);
                        break;
                    }
                    else if (replicateOption == "N")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please input Y or N.");
                    }
                }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }

            while (true)
            {
                Console.Write("Do you want to process another sequence? (Y/N): ");
                string continueOption = Console.ReadLine().ToUpper();

                if (continueOption == "Y")
                {
                    break;
                }
                else if (continueOption == "N")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Please input Y or N.");
                }
            }
        }
    }
}