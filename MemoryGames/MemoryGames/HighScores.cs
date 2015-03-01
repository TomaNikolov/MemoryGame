using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace MemoryGames
{
    public class HighScores
    {
        //Methods here are called in SaveScore upon exiting a Win state game and
        // upon entering the help menu (the HighScores.txt file is being readed).
        
        public static void Write(string playerAndScore)
        {
            //This method checks if a text file to store the highscores exists.
            //If not, it creates one and writes in it.

             string fileName = "../../../HighScores.txt";

             try
             {
                 if (File.Exists(fileName) == false)
                 {
                     StreamWriter streamWriter = new StreamWriter("../../../HighScores.txt");
                     using (streamWriter)
                     {
                         streamWriter.WriteLine(playerAndScore);
                     }
                 }
                 else
                 {
                     StreamWriter streamWriter = new StreamWriter("../../../HighScores.txt", true);
                     using (streamWriter)
                     {
                         streamWriter.WriteLine(playerAndScore);
                     }
                 }
             }
             catch (Exception)
             {
                 Console.SetCursorPosition(30, 16);
                 Console.WriteLine("Error occured while trying to write to {0}", fileName);
                 
             }                    
        }

        public static void Read()
        {
            // This method reads the file, gets its content into string. The string is
            // split into array. The elements are transffered into a unordered dictionary.
            // Key array is sorted. Via the keys (in the array) a new dictionary is created.
            //Then the first 5 elements of the dictionary are printed.

            string fileName = "../../../HighScores.txt";

            if (File.Exists(fileName) == false)
            {
                return;
            }

            StreamReader reader = new StreamReader(fileName);

            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                

                List<string> content = new List<string>();

                while (line != null)
                {
                    lineNumber++;
                    content.Add(line);
                    line = reader.ReadLine();
                }

                GradeScores(content);
            }                        
         }
    
        public static void GradeScores(List<string> content)
        {
           
            Dictionary<int, string> unOrdered = new Dictionary<int,string>();
            for (int i = 0; i < content.Count; i++)
            {
                char[] remove = {' ', '\n'};
                content[i] = content[i].TrimEnd(remove);
            }

            for (int i = 0; i < content.Count; i++)
            {
                int upToIndex = content.LastIndexOf(" ");
                string[] twoItems = content[i].Split(' ').ToArray();

                unOrdered.Add(int.Parse(twoItems[1]), twoItems[0]);
                             
            }

            SortedDictionary<int, string> sorted = new SortedDictionary<int, string>();
            var keys = unOrdered.Keys.ToArray();
            Array.Sort(keys);
            Array.Reverse(keys);
            

            for (int i = 0; i < unOrdered.Count; i++)
            {
                sorted.Add(keys[i], unOrdered[keys[i]]);                           
            }

            int currentRow = 29;         

            for (int i = 0; i < sorted.Count; i++)
            {
                if (i == 5)
                {
                    break;
                }
                else
                {
                    Console.SetCursorPosition(36, currentRow);
                    Console.WriteLine("{0} {1}", keys[i], sorted[keys[i]]);
                    currentRow++;
                }              
            }
            
        }


         
    }

}
