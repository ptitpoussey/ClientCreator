using MulticlientCreator.Helpers;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace MulticlientCreator
{
    public class Program
    {
        private const string OfficialName = "NostaleClientX.exe";
        private const string Pattern = "0C00000037392E3131302E38342E373500000000";

        public static void Main(string[] args)
        {
            Console.Title = "MulticlientCreator by Fizo";

            var nostalePath = PromptForNostalePath();
            var finalPath = Path.Combine(nostalePath, OfficialName);

            byte[] fileBytes = ReadBytesFromFile(finalPath);
            string fileString = HexHelper.ToHexString(fileBytes);

            var newIpPattern = string.Empty;
            if (fileString.Contains(Pattern))
            {
                WriteMessage(ConsoleColor.DarkGreen, "Pattern found !");
                var ip = PromptForIpAddress();
                newIpPattern = GenerateIpPattern(ip);
            }

            var finder = new HexFinder(finalPath, newIpPattern);
            if (finder.ReplaceIpPattern(Pattern))
            {
                WriteMessage(ConsoleColor.DarkGreen, "Your multiclient has been successfully generated !");
            }

            Console.ReadLine();
        }

        private static string PromptForNostalePath()
        {
            WriteMessage(ConsoleColor.Magenta, "Enter your nostale path:");
            string nostalePath;
            do
            {
                nostalePath = Console.ReadLine()!;
            } while (string.IsNullOrEmpty(nostalePath) || !File.Exists(Path.Combine(nostalePath, "NostaleClientX.exe")));

            return nostalePath;
        }

        private static string PromptForIpAddress()
        {
            WriteMessage(ConsoleColor.Magenta, "Enter your VPS IP: ");
            return Console.ReadLine()!;
        }

        private static byte[] ReadBytesFromFile(string path)
        {
            using var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            return DeserializationHelper.ReadFully(fileStream);
        }

        private static string GenerateIpPattern(string ip)
        {
            var split = ip.Split(".");
            var builder = new StringBuilder();
            builder.Append("0" + Convert.ToString(ip.Length, 16).ToUpper() + "000000");

            for (var i = 0; i < 4; i++)
            {
                builder.Append(HexHelper.ToHexString(split[i]));

                if (i == 3) break;

                builder.Append("2E"); // this is the dot "."
            }

            for (var j = builder.Length; j < 40; j++)
            {
                builder.Append("0");
            }

            return builder.ToString();
        }

        public static void WriteMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
