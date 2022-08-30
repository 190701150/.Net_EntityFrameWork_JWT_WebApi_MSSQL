using System;
namespace Business.CCS
{
    public class FileLogger : ILogger
	{
		public FileLogger()
		{
		}

        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı");
        }
    }
}

