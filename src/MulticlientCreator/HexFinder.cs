using MulticlientCreator.Helpers;
using System.IO;

namespace MulticlientCreator
{
    public class HexFinder
    {
        private readonly string _nostalePath;
        private readonly string _newIp;

        public HexFinder(string nostalePath, string newIp)
        {
            _nostalePath = nostalePath;
            _newIp = newIp;
        }

        public bool ReplaceIpPattern(string ipPattern)
        {
            byte[] byteData;
            using (var fileStream = new FileStream(_nostalePath, FileMode.Open, FileAccess.Read))
                byteData = DeserializationHelper.ReadFully(fileStream);

            string oldHex = HexHelper.ToHexString(byteData);
            string newHex = oldHex.Replace(ipPattern, _newIp);

            if (oldHex == newHex)
                return false;

            byte[] newByteData = HexHelper.ToByteArray(newHex);
            using (var writer = new FileStream(_nostalePath, FileMode.Create, FileAccess.Write))
                writer.Write(newByteData, 0, newByteData.Length);

            return true;
        }
    }
}