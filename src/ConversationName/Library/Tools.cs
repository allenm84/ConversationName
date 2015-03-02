using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversationName
{
  public static class Tools
  {
    static Random random = new Random();
    const string pool = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";

    public static string GenerateRandomName()
    {
      char[] values = new char[24];
      for (int c = 0; c < 24; ++c)
      {
        values[c] = pool[random.Next(pool.Length)];
      }
      return new string(values);
    }
  }
}
