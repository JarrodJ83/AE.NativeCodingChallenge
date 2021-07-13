using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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
            throw new NotImplementedException();
        }

        public static PermissionSet Deserialize(byte[] data)
        {
            throw new NotImplementedException();
        }       
    }
}