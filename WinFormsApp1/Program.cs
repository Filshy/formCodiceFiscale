namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            string codiceFiscaleCompleto = "";



        }
        static string calcoloCognome(string cognome)
        {
            cognome = cognome.ToUpper(); // tutto in maiuscolo

            int conteggioConsonanti = 0;
            int conteggioVocali = 0;
            string consonanti = "";
            string vocali = "";
            string codiceCognome = "";

            foreach (char carattere in cognome) // per ogni carattere
            {
                if (char.IsLetter(carattere))
                {
                    if (!"AEIOU".Contains(carattere))
                    {
                        consonanti = consonanti + carattere;
                        conteggioConsonanti++;
                    }
                    else
                    {
                        vocali = vocali + carattere;
                        conteggioVocali++;
                    }
                }
            }

            switch (conteggioConsonanti)
            {
                case 0: codiceCognome = vocali.Substring(0, 2) + "X"; break;
                case 1:
                    if (conteggioVocali == 1)
                    {
                        codiceCognome = consonanti[0] + vocali[0] + "X";
                    }
                    else
                    {
                        codiceCognome = consonanti[0] + vocali.Substring(0, 2);
                    }
                    break;
                case 2: codiceCognome = consonanti.Substring(0, 2) + vocali[0]; break;
                default: codiceCognome = consonanti.Substring(0, 3); break;
            }
            return codiceCognome;

        }
        static string calcoloNome(string nome)
        {
            nome = nome.ToUpper(); // tutto in maiuscolo

            int conteggioConsonanti = 0;
            int conteggioVocali = 0;
            string consonanti = "";
            string vocali = "";
            string codiceNome = "";

            foreach (char carattere in nome) // per ogni carattere
            {
                if (char.IsLetter(carattere))
                {
                    if (!"AEIOU".Contains(carattere))
                    {
                        consonanti = consonanti + carattere;
                        conteggioConsonanti++;
                    }
                    else
                    {
                        vocali = vocali + carattere;
                        conteggioVocali++;
                    }
                }
            }

            switch (conteggioConsonanti)
            {
                case 0: codiceNome = vocali.Substring(0, 2) + "X"; break;
                case 1:
                    if (conteggioVocali == 1)
                    {
                        codiceNome = consonanti[0] + vocali[0] + "X";
                    }
                    else
                    {
                        codiceNome = consonanti[0] + vocali.Substring(0, 2);
                    }
                    break;
                case 2: codiceNome = consonanti.Substring(0, 2) + vocali[0]; break;
                case 3: codiceNome = consonanti.Substring(0, 3); break;
                default: codiceNome = consonanti[0].ToString() + consonanti[2].ToString() + consonanti[3].ToString(); break;
            }
            return codiceNome;
        }
        static string calcoloData(string dataNascita, char sesso)
        {
            string[] mesi = { "A", "B", "C", "D", "E", "H", "L", "M", "P", "R", "S", "T" };
            string codiceData = "";
            string[] componentiData = dataNascita.Split('/'); // (3)

            switch (componentiData[1])
            {
                case "01": codiceData = $"{componentiData[2][2]}{componentiData[2][3]}" + mesi[0]; break;
                case "02": codiceData = $"{componentiData[2][2]}{componentiData[2][3]}" + mesi[1]; break;
                case "03": codiceData = $"{componentiData[2][2]}{componentiData[2][3]}" + mesi[2]; break;
                case "04": codiceData = $"{componentiData[2][2]}{componentiData[2][3]}" + mesi[3]; break;
                case "05": codiceData = $"{componentiData[2][2]}{componentiData[2][3]}" + mesi[4]; break;
                case "06": codiceData = $"{componentiData[2][2]}{componentiData[2][3]}" + mesi[5]; break;
                case "07": codiceData = $"{componentiData[2][2]}{componentiData[2][3]}" + mesi[6]; break;
                case "08": codiceData = $"{componentiData[2][2]}{componentiData[2][3]}" + mesi[7]; break;
                case "09": codiceData = $"{componentiData[2][2]}{componentiData[2][3]}" + mesi[8]; break;
                case "10": codiceData = $"{componentiData[2][2]}{componentiData[2][3]}" + mesi[9]; break;
                case "11": codiceData = $"{componentiData[2][2]}{componentiData[2][3]}" + mesi[10]; break;
                case "12": codiceData = $"{componentiData[2][2]}{componentiData[2][3]}" + mesi[11]; break;
                default: codiceData = "Data non valida"; break;
            }

            if (sesso.ToString().ToLower().Equals("m"))
                codiceData += componentiData[0];

            else if (sesso.ToString().ToLower().Equals("f"))
                codiceData += (int.Parse(componentiData[0]) + 40);
            else
            {
                codiceData = "Sesso inserito non valido";
            }

            return codiceData;
        }
        static string calcoloComune(string comune)
        {
            using (var reader = new StreamReader(@"codici_catastali.csv"))
            {
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    listA.Add(values[0]);
                    listB.Add(values[2]);
                }

                for (int i = 0; i < listB.Count; i++)
                {
                    if (comune == listB[i])
                        return listA[i];
                }
                return "None";
            }
        }
    }
}