namespace RenameAWAudioFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Program Files (x86)\Steam\steamapps\common\Call of Duty Advanced Warfare\portuguese";
            string oldLang = "eng";
            string newLang = "por";

            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                if (file.Contains(oldLang))
                    File.Move(file, file.Replace(oldLang, newLang));
            }
        }
    }
}
