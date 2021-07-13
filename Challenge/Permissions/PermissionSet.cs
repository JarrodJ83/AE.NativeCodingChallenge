using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AE.Permissions
{
    [Serializable]
    public class PermissionSet 
    {
        public IReadOnlyList<string> Permissions { get; }
        public PermissionSet(List<string> permissions)
        {
            Permissions = new ReadOnlyCollection<string>(permissions);
        }

        public byte[] Serialize()
        {
            using (var memStream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(memStream, this);
                return memStream.ToArray();
            }
        }

        public static PermissionSet Deserialize(byte[] data)
        {
            using (var ms = new MemoryStream(data))
            {
                var formatter = new BinaryFormatter();
                return formatter.Deserialize(ms) as PermissionSet;
            }
        }       
    }
}