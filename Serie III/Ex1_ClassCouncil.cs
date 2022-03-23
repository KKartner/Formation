using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_III
{
    public static class ClassCouncil
    {
        public static void SchoolMeans(string input, string output)
        {
            List<string> nom = new List<string>();
            List<string> matieres = new List<string>();
            List<float> notes = new List<float>();
            List<string> sortieMatiere = new List<string>();

            using (StreamReader sr = new StreamReader(input))
            {
                string lines;
                while ((lines = sr.ReadLine()) != null)
                {
                    string[] line = lines.Split(';');
                    int i = -1;
                    //line[0]
                    foreach (var l in line)
                    {
                        i++;
                        if (i == 0)
                        {
                            nom.Add(l);
                        }
                        else if (i == 1)
                        {
                            matieres.Add(l);
                        }
                        else
                        {
                            float result = 0;
                            bool verification;
                            verification = float.TryParse(l, out result);
                            if (verification)
                            {
                                notes.Add(result);
                            }
                            i = -1;
                        }
                    }
                }
            }
            for (int i = 0; i < matieres.Count; i++)
            {
                int nbNote = 0;
                float moyenne = 0;
                for (int j = 0; j < notes.Count; j++)
                {
                    if (!sortieMatiere.Contains(matieres[i]) && matieres[i] == matieres[j])
                    {
                        nbNote++;
                        moyenne += notes[j];
                    }
                }
                if (!sortieMatiere.Contains(matieres[i]))
                {
                    sortieMatiere.Add(matieres[i]);
                    float total = moyenne / nbNote;
                    int index = sortieMatiere.Count - 1;
                    using (StreamWriter sw = new StreamWriter(output, true))
                    {
                        sw.WriteLine($"{sortieMatiere[index]};{total}");
                    }
                }
            }
        }
    }
}
