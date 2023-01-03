using System.Diagnostics;

namespace _00_Repetition.Services
{
    public class FileService
    {
        public void SaveToFile(string filePath, string content)
        {
            try
            {
                using var sw = new StreamWriter(filePath);
                sw.WriteLine(content);
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
        }

        public string ReadFromFile(string filePath)
        {
            try
            {
                using var reader = new StreamReader(filePath);
                return reader.ReadToEnd();
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return null!;
        }
    }
}
