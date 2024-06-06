using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class cFiscale
    {   
        public string calcoloCognome(string cognome)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Il cognome inserito non è valido");
                Environment.Exit(Environment.ExitCode);
                return "0";
            }


        }
        public string calcoloNome(string nome)
        {

            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Il nome inserito non è valido");
                Environment.Exit(Environment.ExitCode);
                return "0";
            }

        }
        public string calcoloData(string dataNascita, string sesso)
        {
            if (sesso != "M" || sesso != "F")
            {
                MessageBox.Show("Impossibile calcolare la data");
                Environment.Exit(Environment.ExitCode);
                return "0";
            }

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
        public string calcoloComune(string comune)
        {
            try
            {
                comune.ToUpper();
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
            catch (Exception ex)
            {
                MessageBox.Show("Il comune inserito non è stato trovato");
                Environment.Exit(Environment.ExitCode);
                return "0";
            }

        }
        public char calcolaCarattereControllo(string codiceFiscale)
        {
            int[] valoriDispari = { 1, 0, 5, 7, 9, 13, 15, 17, 19, 21, 2, 4, 18, 20, 11, 3, 6, 8, 12, 14, 16, 10, 22, 25, 24, 23 };
            int[] valoriPari =  { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

            int somma = 0;
            for (int i = 0; i < 15; i++)
            {
                char c = codiceFiscale[i];
                int valore;
                if (char.IsDigit(c))
                {
                    valore = c - '0';
                }
                else
                {
                    valore = c - 'A';
                }

                if (i % 2 == 0)
                {
                    somma += valoriDispari[valore];
                }
                else
                {
                    somma += valoriPari[valore];
                }
            }

            int carattereControllo = somma % 26;
            return (char)('A' + carattereControllo);
        }
    }
}
