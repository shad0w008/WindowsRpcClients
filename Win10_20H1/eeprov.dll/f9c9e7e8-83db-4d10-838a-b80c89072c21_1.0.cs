//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\eeprov.dll
// Interface ID: f9c9e7e8-83db-4d10-838a-b80c89072c21
// Interface Version: 1.0



namespace rpc_f9c9e7e8_83db_4d10_838a_b80c89072c21_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(Struct_1 p0)
        {
            WriteStruct<Struct_1>(p0);
        }
        public void Write_2(Struct_2 p0)
        {
            WriteStruct<Struct_2>(p0);
        }
        public void Write_3(Struct_3 p0)
        {
            WriteStruct<Struct_3>(p0);
        }
        public void Write_4(Struct_4 p0)
        {
            WriteStruct<Struct_4>(p0);
        }
        public void Write_5(Struct_5 p0)
        {
            WriteStruct<Struct_5>(p0);
        }
        public void Write_6(Struct_6 p0)
        {
            WriteStruct<Struct_6>(p0);
        }
        public void Write_7(Struct_7 p0)
        {
            WriteStruct<Struct_7>(p0);
        }
        public void Write_8(Struct_8 p0)
        {
            WriteStruct<Struct_8>(p0);
        }
        public void Write_9(Struct_9 p0)
        {
            WriteStruct<Struct_9>(p0);
        }
        public void Write_10(Struct_10 p0)
        {
            WriteStruct<Struct_10>(p0);
        }
        public void Write_11(Struct_11 p0)
        {
            WriteStruct<Struct_11>(p0);
        }
        public void Write_12(Struct_1[] p0, long p1)
        {
            WriteConformantStructArray<Struct_1>(p0, p1);
        }
        public void Write_13(sbyte[] p0)
        {
            WriteFixedPrimitiveArray<sbyte>(p0, 68);
        }
        public void Write_14(long[] p0)
        {
            WriteFixedPrimitiveArray<long>(p0, 2);
        }
        public void Write_15(NtApiDotNet.Ndr.Marshal.NdrUnsupported p0)
        {
            WriteUnsupported(p0, "FC_SMFARRAY - long[2][4]");
        }
        public void Write_16(long[] p0)
        {
            WriteFixedPrimitiveArray<long>(p0, 14);
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
        public Struct_0 Read_0()
        {
            return ReadStruct<Struct_0>();
        }
        public Struct_1 Read_1()
        {
            return ReadStruct<Struct_1>();
        }
        public Struct_2 Read_2()
        {
            return ReadStruct<Struct_2>();
        }
        public Struct_3 Read_3()
        {
            return ReadStruct<Struct_3>();
        }
        public Struct_4 Read_4()
        {
            return ReadStruct<Struct_4>();
        }
        public Struct_5 Read_5()
        {
            return ReadStruct<Struct_5>();
        }
        public Struct_6 Read_6()
        {
            return ReadStruct<Struct_6>();
        }
        public Struct_7 Read_7()
        {
            return ReadStruct<Struct_7>();
        }
        public Struct_8 Read_8()
        {
            return ReadStruct<Struct_8>();
        }
        public Struct_9 Read_9()
        {
            return ReadStruct<Struct_9>();
        }
        public Struct_10 Read_10()
        {
            return ReadStruct<Struct_10>();
        }
        public Struct_11 Read_11()
        {
            return ReadStruct<Struct_11>();
        }
        public Struct_1[] Read_12()
        {
            return ReadConformantStructArray<Struct_1>();
        }
        public sbyte[] Read_13()
        {
            return ReadFixedPrimitiveArray<sbyte>(68);
        }
        public long[] Read_14()
        {
            return ReadFixedPrimitiveArray<long>(2);
        }
        public NtApiDotNet.Ndr.Marshal.NdrUnsupported Read_15()
        {
            return ReadUnsupported("FC_SMFARRAY - long[2][4]");
        }
        public long[] Read_16()
        {
            return ReadFixedPrimitiveArray<long>(14);
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_0 : NtApiDotNet.Ndr.Marshal.INdrConformantStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_9(Member0);
            m.Write_10(MemberC);
            m.Write_11(Member2C);
            m.Write_11(Member3C);
            m.WriteInt32(Member4C);
            m.Write_12(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member50, "Member50"), Member4C);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_9();
            MemberC = u.Read_10();
            Member2C = u.Read_11();
            Member3C = u.Read_11();
            Member4C = u.ReadInt32();
            Member50 = u.Read_12();
        }
        int NtApiDotNet.Ndr.Marshal.INdrConformantStructure.GetConformantDimensions()
        {
            return 1;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public Struct_9 Member0;
        public Struct_10 MemberC;
        public Struct_11 Member2C;
        public Struct_11 Member3C;
        public int Member4C;
        public Struct_1[] Member50;
        public static Struct_0 CreateDefault()
        {
            Struct_0 ret = new Struct_0();
            ret.Member50 = new Struct_1[0];
            return ret;
        }
        public Struct_0(Struct_9 Member0, Struct_10 MemberC, Struct_11 Member2C, Struct_11 Member3C, int Member4C, Struct_1[] Member50)
        {
            this.Member0 = Member0;
            this.MemberC = MemberC;
            this.Member2C = Member2C;
            this.Member3C = Member3C;
            this.Member4C = Member4C;
            this.Member50 = Member50;
        }
    }
    public struct Struct_1 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_2(Member0);
            m.Write_3(Member28);
            m.Write_4(Member70);
            m.Write_5(Member88);
            m.Write_6(MemberA0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_2();
            Member28 = u.Read_3();
            Member70 = u.Read_4();
            Member88 = u.Read_5();
            MemberA0 = u.Read_6();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public Struct_2 Member0;
        public Struct_3 Member28;
        public Struct_4 Member70;
        public Struct_5 Member88;
        public Struct_6 MemberA0;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(Struct_2 Member0, Struct_3 Member28, Struct_4 Member70, Struct_5 Member88, Struct_6 MemberA0)
        {
            this.Member0 = Member0;
            this.Member28 = Member28;
            this.Member70 = Member70;
            this.Member88 = Member88;
            this.MemberA0 = MemberA0;
        }
    }
    public struct Struct_2 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteEmbeddedPointer<string>(Member8, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<string>(Member10, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<string>(Member18, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<string>(Member20, new System.Action<string>(m.WriteTerminatedString));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member10 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member18 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member20 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member8;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member10;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member18;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member20;
        public static Struct_2 CreateDefault()
        {
            return new Struct_2();
        }
        public Struct_2(int Member0, int Member4, string Member8, string Member10, string Member18, string Member20)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member18 = Member18;
            this.Member20 = Member20;
        }
    }
    public struct Struct_3 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_13(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_13();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 1;
        }
        public sbyte[] Member0;
        public static Struct_3 CreateDefault()
        {
            Struct_3 ret = new Struct_3();
            ret.Member0 = new sbyte[68];
            return ret;
        }
        public Struct_3(sbyte[] Member0)
        {
            this.Member0 = Member0;
        }
    }
    public struct Struct_4 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt64(Member0);
            m.WriteInt32(Member8);
            m.WriteInt32(MemberC);
            m.WriteInt32(Member10);
            m.WriteInt32(Member14);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt64();
            Member8 = u.ReadInt32();
            MemberC = u.ReadInt32();
            Member10 = u.ReadInt32();
            Member14 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public long Member0;
        public int Member8;
        public int MemberC;
        public int Member10;
        public int Member14;
        public static Struct_4 CreateDefault()
        {
            return new Struct_4();
        }
        public Struct_4(long Member0, int Member8, int MemberC, int Member10, int Member14)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.MemberC = MemberC;
            this.Member10 = Member10;
            this.Member14 = Member14;
        }
    }
    public struct Struct_5 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteInt32(Member8);
            m.WriteInt32(MemberC);
            m.WriteInt32(Member10);
            m.WriteInt32(Member14);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadInt32();
            MemberC = u.ReadInt32();
            Member10 = u.ReadInt32();
            Member14 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public int Member8;
        public int MemberC;
        public int Member10;
        public int Member14;
        public static Struct_5 CreateDefault()
        {
            return new Struct_5();
        }
        public Struct_5(int Member0, int Member4, int Member8, int MemberC, int Member10, int Member14)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.MemberC = MemberC;
            this.Member10 = Member10;
            this.Member14 = Member14;
        }
    }
    public struct Struct_6 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_7(Member0);
            m.Write_8(Member110);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_7();
            Member110 = u.Read_8();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public Struct_7 Member0;
        public Struct_8 Member110;
        public static Struct_6 CreateDefault()
        {
            return new Struct_6();
        }
        public Struct_6(Struct_7 Member0, Struct_8 Member110)
        {
            this.Member0 = Member0;
            this.Member110 = Member110;
        }
    }
    public struct Struct_7 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_15(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
            m.WriteInt64(Member40);
            m.WriteInt64(Member48);
            m.WriteInt64(Member50);
            m.WriteInt64(Member58);
            m.WriteInt64(Member60);
            m.WriteInt64(Member68);
            m.WriteInt64(Member70);
            m.WriteInt64(Member78);
            m.WriteInt32(Member80);
            m.WriteInt32(Member84);
            m.WriteInt32(Member88);
            m.WriteInt32(Member8C);
            m.Write_15(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member90, "Member90"));
            m.Write_15(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(MemberD0, "MemberD0"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_15();
            Member40 = u.ReadInt64();
            Member48 = u.ReadInt64();
            Member50 = u.ReadInt64();
            Member58 = u.ReadInt64();
            Member60 = u.ReadInt64();
            Member68 = u.ReadInt64();
            Member70 = u.ReadInt64();
            Member78 = u.ReadInt64();
            Member80 = u.ReadInt32();
            Member84 = u.ReadInt32();
            Member88 = u.ReadInt32();
            Member8C = u.ReadInt32();
            Member90 = u.Read_15();
            MemberD0 = u.Read_15();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public NtApiDotNet.Ndr.Marshal.NdrUnsupported Member0;
        public long Member40;
        public long Member48;
        public long Member50;
        public long Member58;
        public long Member60;
        public long Member68;
        public long Member70;
        public long Member78;
        public int Member80;
        public int Member84;
        public int Member88;
        public int Member8C;
        public NtApiDotNet.Ndr.Marshal.NdrUnsupported Member90;
        public NtApiDotNet.Ndr.Marshal.NdrUnsupported MemberD0;
        public static Struct_7 CreateDefault()
        {
            return new Struct_7();
        }
        public Struct_7(NtApiDotNet.Ndr.Marshal.NdrUnsupported Member0, long Member40, long Member48, long Member50, long Member58, long Member60, long Member68, long Member70, long Member78, int Member80, int Member84, int Member88, int Member8C, NtApiDotNet.Ndr.Marshal.NdrUnsupported Member90, NtApiDotNet.Ndr.Marshal.NdrUnsupported MemberD0)
        {
            this.Member0 = Member0;
            this.Member40 = Member40;
            this.Member48 = Member48;
            this.Member50 = Member50;
            this.Member58 = Member58;
            this.Member60 = Member60;
            this.Member68 = Member68;
            this.Member70 = Member70;
            this.Member78 = Member78;
            this.Member80 = Member80;
            this.Member84 = Member84;
            this.Member88 = Member88;
            this.Member8C = Member8C;
            this.Member90 = Member90;
            this.MemberD0 = MemberD0;
        }
    }
    public struct Struct_8 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_16(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
            m.WriteInt64(Member70);
            m.WriteInt64(Member78);
            m.WriteInt64(Member80);
            m.WriteInt64(Member88);
            m.WriteInt64(Member90);
            m.WriteInt32(Member98);
            m.WriteInt32(Member9C);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_16();
            Member70 = u.ReadInt64();
            Member78 = u.ReadInt64();
            Member80 = u.ReadInt64();
            Member88 = u.ReadInt64();
            Member90 = u.ReadInt64();
            Member98 = u.ReadInt32();
            Member9C = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public long[] Member0;
        public long Member70;
        public long Member78;
        public long Member80;
        public long Member88;
        public long Member90;
        public int Member98;
        public int Member9C;
        public static Struct_8 CreateDefault()
        {
            Struct_8 ret = new Struct_8();
            ret.Member0 = new long[14];
            return ret;
        }
        public Struct_8(long[] Member0, long Member70, long Member78, long Member80, long Member88, long Member90, int Member98, int Member9C)
        {
            this.Member0 = Member0;
            this.Member70 = Member70;
            this.Member78 = Member78;
            this.Member80 = Member80;
            this.Member88 = Member88;
            this.Member90 = Member90;
            this.Member98 = Member98;
            this.Member9C = Member9C;
        }
    }
    public struct Struct_9 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteInt32(Member8);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public int Member8;
        public static Struct_9 CreateDefault()
        {
            return new Struct_9();
        }
        public Struct_9(int Member0, int Member4, int Member8)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
        }
    }
    public struct Struct_10 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteInt32(Member8);
            m.WriteInt32(MemberC);
            m.WriteInt32(Member10);
            m.WriteInt32(Member14);
            m.WriteInt32(Member18);
            m.WriteInt32(Member1C);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadInt32();
            MemberC = u.ReadInt32();
            Member10 = u.ReadInt32();
            Member14 = u.ReadInt32();
            Member18 = u.ReadInt32();
            Member1C = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public int Member8;
        public int MemberC;
        public int Member10;
        public int Member14;
        public int Member18;
        public int Member1C;
        public static Struct_10 CreateDefault()
        {
            return new Struct_10();
        }
        public Struct_10(int Member0, int Member4, int Member8, int MemberC, int Member10, int Member14, int Member18, int Member1C)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.MemberC = MemberC;
            this.Member10 = Member10;
            this.Member14 = Member14;
            this.Member18 = Member18;
            this.Member1C = Member1C;
        }
    }
    public struct Struct_11 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteInt32(Member8);
            m.WriteInt32(MemberC);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadInt32();
            MemberC = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public int Member8;
        public int MemberC;
        public static Struct_11 CreateDefault()
        {
            return new Struct_11();
        }
        public Struct_11(int Member0, int Member4, int Member8, int MemberC)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.MemberC = MemberC;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("f9c9e7e8-83db-4d10-838a-b80c89072c21", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        // async
        public int EepHvRpcSrv_ProvideEnergyData(int p0, Struct_0 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_0(p1);
            _Unmarshal_Helper u = SendReceive(0, m);
            return u.ReadInt32();
        }
        // async
        public int EepHvRpcSrv_WaitForEndOfEpoch(ref System.Nullable<int> p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<int>(m.WriteInt32));
            _Unmarshal_Helper u = SendReceive(1, m);
            p0 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            return u.ReadInt32();
        }
    }
    #endregion
}
