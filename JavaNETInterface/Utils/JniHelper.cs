using System.Text;

namespace JavaNETInterface.Utils
{
    internal static class JniHelper
    {
        public static byte[] GetUtf8Bytes(string value)
        {
            int bytesCount = Encoding.UTF8.GetByteCount(value);
            byte[] buffer = new byte[bytesCount + 1];
            Encoding.UTF8.GetBytes(value, 0, value.Length, buffer, 0);
            return buffer;
        }
    }
}
