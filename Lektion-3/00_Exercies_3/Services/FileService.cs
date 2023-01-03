namespace _00_Exercies_3.Services
{
    internal class FileService
    {
        public void Save(string filePath, string content) 
        {
            using var sw = new StreamWriter(filePath);
            sw.WriteLine(content);
        }
        
        public string Read(string filePath) 
        {
            try
            {
                using var sr = new StreamReader(filePath);
                var content = sr.ReadToEnd();

                return content;
            }
            catch { return ""; }
        }
    }
}
