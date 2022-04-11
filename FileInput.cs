namespace mod1AssingmntB
{
    public class FileInput
   	{
		private string fileName;

		public FileInput(string FileName) => fileName = FileName;

		public void fileRead()
		{
			
			try
			{
				using var sr = new StreamReader(fileName);
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					Console.WriteLine(line);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine($"Could not read file {fileName}: {e}");
			}
		}

		public string? fileReadLine()
		{
			try
        {
            using (var sr = new StreamReader(fileName))
            {
                return sr.ReadLine();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Could not read file {fileName}: {e}");
            return null;
        }	
		}
	}

}

