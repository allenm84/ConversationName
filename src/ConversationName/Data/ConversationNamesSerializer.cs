using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversationName
{
  public class ConversationNamesSerializer
  {
    public void Write(Stream stream, ConversationNames names)
    {
      var writer = new BinaryWriter(stream);
      writer.Write(names.Count);
      foreach (var kvp in names)
      {
        writer.Write(kvp.Key.Ticks);
        writer.Write(kvp.Value);
      }
    }

    public ConversationNames Read(Stream stream)
    {
      var names = new ConversationNames();
      var reader = new BinaryReader(stream);

      DateTime key;
      string value;
      
      int count = reader.ReadInt32();
      for (; count > 0; --count)
      {
        key = new DateTime(reader.ReadInt64());
        value = reader.ReadString();
        names.Add(key, value);
      }

      return names;
    }
  }
}
