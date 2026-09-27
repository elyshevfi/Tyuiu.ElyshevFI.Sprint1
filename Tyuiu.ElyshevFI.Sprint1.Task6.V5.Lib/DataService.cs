using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ElyshevFI.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            string[] words = value.Split(' ');
            string result = "";
            int i = 0;

            while (i < words.Length)
            {
                string word = words[i];

                if (word.Length > 1)
                {
                    string lowerWord = word.ToLower();
                    bool isSymmetric = false;

                    if (lowerWord.Length == 3 && lowerWord[0] == lowerWord[2])
                    {
                        isSymmetric = true;
                    }
                    else if (lowerWord.Length == 5 && lowerWord[0] == lowerWord[4] && lowerWord[1] == lowerWord[3])
                    {
                        isSymmetric = true;
                    }

                    if (isSymmetric)
                    {
                        result += word + " ";
                    }
                }

                i = i + 1;
            }

            return result.Trim();
        }
    }
}
