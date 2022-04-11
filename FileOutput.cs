namespace mod1AssingmntB
{
    public class FileOutput
    {
        private string fileName;

        public FileOutput(string FileName) => fileName = FileName;

        public void WriteFile(string line)
        {
            try
            {
                using var sw = new StreamWriter(fileName);
                sw.WriteLine($"{line}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Could not write to file {fileName}: {e}");
            }
        }
    }
}