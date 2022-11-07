// See https://aka.ms/new-console-template for more information
Console.WriteLine("This program simulates various voting systems, including an audit system for checking the results");
Console.WriteLine("If it's your first time, write ''help'' in order to know the commands");

string initInput = Console.ReadLine() ?? "help";

if (initInput == "help")
{
    Console.WriteLine(@"Command Sheet (main):
    ________________________________________
    help      | opens menu
    majority  | opens majority voting system
    plurality | opens plurality voting system
    ________________________________________");

    Console.WriteLine(@"Command Sheet (suffixes):
    ____________________________________________
    -single | makes the voting for a single seat
    -many   | makes the voting for many seats
    ____________________________________________");

    Console.WriteLine(@"Example:
    
    majority -single
    
    (this will open the program for a majority election for a single seat)");
}

else

{

    Console.WriteLine("How many candidates will be up for the seat ?");
    int candidates = 2;
    candidates = Convert.ToInt16(Console.ReadLine());

    List<string> CandidatesName   = new List<string>{};
    List<int> CandidatesNumber    = new List<int>{};
    List<long> CandidatesVotes    = new List<long>{};
    CandidatesName.Add("Nulo");
    CandidatesNumber.Add(0);
    string Name = "";
    int Number  = 0;

    for (int i = 0; i < candidates; i++)
    {
        Console.WriteLine("Write the name of the candidate");
            Name = Console.ReadLine() ?? $"Generic {i}";
            CandidatesName.Add(Name);
        Console.WriteLine("Write the number of said candidate");
            Number = Convert.ToInt16(Console.ReadLine());
            CandidatesNumber.Add(Number);

            CandidatesVotes.Add(0);
    }

    Console.WriteLine("Insert the number of voters");
    int Eleitores = Convert.ToInt32(Console.ReadLine() ?? "1");

    for (int i = 0; i <= Eleitores; i++)
        {

        Console.WriteLine("Insert your candidate's Number");
        int candidato = -1;
         candidato =  Convert.ToInt16(Console.ReadLine());

        if (candidato == -1)
            {
                Console.WriteLine("Invalid Candidate");
                i = i--;
                break;
            }

        if (candidato != -1) 
            {
                for(int inc = 1; inc < CandidatesNumber.Count(); inc++)
                {
                    if (candidato == CandidatesNumber[inc])
                    {
                        CandidatesVotes[inc]++;
                    }
                }
            }

            Console.WriteLine(string.Join("/", CandidatesName));
            Console.WriteLine(string.Join("/", CandidatesNumber));
            Console.WriteLine(string.Join("/", CandidatesVotes));

        }
//Audit System in Progress

/*
        Console.WriteLine("Você quer auditar os resultados ? (S/N) ");

        string audit = Console.ReadLine() ?? "N";
        audit = audit.ToUpper();

            if (audit == "S")
            {
            Console.WriteLine("Your log will be saved into ElectronicUrn/log.txt");
            string filePath = Directory.GetCurrentDirectory();

            Console.WriteLine(filePath);

            File.Create(filePath + @"\" + "log.txt");
            var streamwriter = new StreamWriter(filePath + @"\log.txt");
            streamwriter.AutoFlush = true;
            Console.SetOut(streamwriter);
            Console.SetError(streamwriter);
            }
 */       
    
}