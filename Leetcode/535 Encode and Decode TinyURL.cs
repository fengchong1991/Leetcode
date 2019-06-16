using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _535_Encode_and_Decode_TinyURL
    {
        public class Codec
        {

            string elements = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int counter = 0;
            Dictionary<int, string> db = new Dictionary<int, string>();

            // Encodes a URL to a shortened URL
            public string encode(string longUrl)
            {
                var sb = new StringBuilder();

                // Generate a auto increment unique ID
                counter++;

                string shortUrl = base10ToBase62(counter);
                db.Add(counter, longUrl);
                return shortUrl;
            }

            // Decodes a shortened URL to its original URL.
            public string decode(string shortUrl)
            {
                var id = base62ToBase10(shortUrl);
                return db[id];
            }


            public string base10ToBase62(int id)
            {
                var sb = new StringBuilder();

                while (id > 0)
                {
                    sb.Append(elements[id % 62]);
                    id /= 62;
                }

                return sb.ToString();
            }

            public int base62ToBase10(string s)
            {
                var result = 0;
                for (var i = 0; i < s.Length; i++)
                {
                    result += i * 62 + Convert(s[i]);
                }

                return result;
            }

            public int Convert(char c)
            {
                if (c >= '0' && c <= '9')
                {
                    return c - '0';
                }

                if (c >= 'a' && c <= 'z')
                {
                    return c - 'a' + 10;
                }

                if (c >= 'A' && c <= 'Z')
                {
                    return c - 'A' + 36;
                }

                return 0;
            }
        }

        // Your Codec object will be instantiated and called as such:
        // Codec codec = new Codec();
        // codec.decode(codec.encode(url));
    }
}
