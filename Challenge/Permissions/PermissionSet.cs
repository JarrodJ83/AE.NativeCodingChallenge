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

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (ReferenceEquals(this, obj)) return true;

            var other = obj as PermissionSet;
            if (other == null) return false;

            return new Comparer().Equals(this, other);
        }

        class Comparer : IEqualityComparer<PermissionSet>
        {
            public bool Equals(PermissionSet x, PermissionSet y)
            {
                if (x == y) return true;
                if (x == null || y == null) return false;

                if (x.Permissions.Count != y.Permissions.Count) return false;

                for (int i = 0; i < x.Permissions.Count; i++)
                {
                    if (!x.Permissions[i].Equals(y.Permissions[i])) return false;
                }

                return true;
            }

            public int GetHashCode(PermissionSet obj)
            {
                return obj.Permissions.GetHashCode();
            }
        }
    }
}