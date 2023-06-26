using System;
using System.IO;

namespace MulticlientCreator.Helpers
{
    public static class DeserializationHelper
    {
        /// <summary>
        /// Reads data from a stream until the end is reached and returns the data as a byte array. 
        /// An IOException is thrown if any of the underlying IO calls fail.
        /// </summary>
        /// <param name="stream">The stream to read data from</param>
        /// <param name="initialLength">The initial buffer length</param>
        public static byte[] ReadFully(Stream stream, int initialLength = 0)
        {
            const int DefaultLength = 32768;
            initialLength = initialLength > 0 ? initialLength : DefaultLength;

            byte[] buffer = new byte[initialLength];
            int totalRead = 0;

            while (true)
            {
                int remainingBufferSpace = buffer.Length - totalRead;
                int chunkRead = stream.Read(buffer, totalRead, remainingBufferSpace);

                if (chunkRead == 0)
                    break;

                totalRead += chunkRead;

                if (totalRead == buffer.Length)
                {
                    int nextByte = stream.ReadByte();
                    if (nextByte == -1)
                        break;

                    byte[] newBuffer = new byte[buffer.Length * 2];
                    Array.Copy(buffer, newBuffer, buffer.Length);
                    newBuffer[totalRead] = (byte)nextByte;
                    buffer = newBuffer;
                    totalRead++;
                }
            }

            byte[] result = new byte[totalRead];
            Array.Copy(buffer, result, totalRead);
            return result;
        }
    }
}
