//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\mispace.dll
// Interface ID: 58b19028-b9a0-4c25-887f-aca58b584d1b
// Interface Version: 1.0



namespace rpc_58b19028_b9a0_4c25_887f_aca58b584d1b_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_1(byte[] p0, long p1, long p2)
        {
            WriteConformantVaryingArray<byte>(p0, p1, p2);
        }
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
        public byte[] Read_0()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_1()
        {
            return ReadConformantVaryingArray<byte>();
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("58b19028-b9a0-4c25-887f-aca58b584d1b", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int ClusterSpaceControl(byte[] p0, int p1, out byte[] p2, int p3, out int p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"), p1);
            m.WriteInt32(p1);
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(0, m);
            p2 = u.Read_1();
            p4 = u.ReadInt32();
            return u.ReadInt32();
        }
    }
    #endregion
}
