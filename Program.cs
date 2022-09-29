// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Insira o Numero de Eleitores");
int Eleitores = Convert.ToInt32(Console.ReadLine() ?? "1");


int votosBonoro = 0;
int votosLula = 0;
int votosCiro = 0;
int votosTebet = 0;
int votosNulo = 0;

for (int i = 0; i < Eleitores; i++)
    {
    Console.WriteLine("Insira seu candidato");
    string candidato =  Console.ReadLine() ?? "A";
    switch(candidato)
        {
            case "13" or "Lula":
            votosLula = votosLula++;
            break;

            case "22" or "Bonoro":
            votosBonoro = votosBonoro++;
            break;

            case "12" or "Ciro":
            votosCiro = votosCiro++;
            break;

            case "25" or "Tebet":
            votosTebet = votosTebet++;
            break;

            case "Nulo":
            votosNulo = votosNulo++;
            break;

            default:
            Console.WriteLine("Candidato Invalido");
            i = i--;
            break;
        }
    }

    Console.WriteLine(@$"Votos:
    Lula: {votosLula}
    Bolsonaro: {votosBonoro}
    Ciro: {votosCiro}
    Tebet: {votosTebet}
    ");

    Console.WriteLine("Você quer auditar os resultados ? (S/N) ");

    string audit = Console.ReadLine() ?? "N";
    audit = audit.ToUpper();

    if (audit == "S")
    {
    Console.WriteLine("Your log will be saved into CalcMachine/log.txt");
    string filePath = Directory.GetCurrentDirectory();

    FileStream filestream = new FileStream("log.txt", FileMode.Create);
    var streamwriter = new StreamWriter(filestream);
    streamwriter.AutoFlush = true;
    Console.SetOut(streamwriter);
    Console.SetError(streamwriter);
    }