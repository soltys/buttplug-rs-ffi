// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace ButtplugFFI
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct RawReadCmd : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static RawReadCmd GetRootAsRawReadCmd(ByteBuffer _bb) { return GetRootAsRawReadCmd(_bb, new RawReadCmd()); }
  public static RawReadCmd GetRootAsRawReadCmd(ByteBuffer _bb, RawReadCmd obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RawReadCmd __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Endpoint Endpoint { get { int o = __p.__offset(4); return o != 0 ? (Endpoint)__p.bb.GetUshort(o + __p.bb_pos) : Endpoint.Tx; } }
  public sbyte Data(int j) { int o = __p.__offset(6); return o != 0 ? __p.bb.GetSbyte(__p.__vector(o) + j * 1) : (sbyte)0; }
  public int DataLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<sbyte> GetDataBytes() { return __p.__vector_as_span<sbyte>(6, 1); }
#else
  public ArraySegment<byte>? GetDataBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public sbyte[] GetDataArray() { return __p.__vector_as_array<sbyte>(6); }
  public uint ExpectedLength { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint Timeout { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }

  public static Offset<ButtplugFFI.RawReadCmd> CreateRawReadCmd(FlatBufferBuilder builder,
      Endpoint endpoint = Endpoint.Tx,
      VectorOffset dataOffset = default(VectorOffset),
      uint expected_length = 0,
      uint timeout = 0) {
    builder.StartTable(4);
    RawReadCmd.AddTimeout(builder, timeout);
    RawReadCmd.AddExpectedLength(builder, expected_length);
    RawReadCmd.AddData(builder, dataOffset);
    RawReadCmd.AddEndpoint(builder, endpoint);
    return RawReadCmd.EndRawReadCmd(builder);
  }

  public static void StartRawReadCmd(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddEndpoint(FlatBufferBuilder builder, Endpoint endpoint) { builder.AddUshort(0, (ushort)endpoint, 0); }
  public static void AddData(FlatBufferBuilder builder, VectorOffset dataOffset) { builder.AddOffset(1, dataOffset.Value, 0); }
  public static VectorOffset CreateDataVector(FlatBufferBuilder builder, sbyte[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddSbyte(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateDataVectorBlock(FlatBufferBuilder builder, sbyte[] data) { builder.StartVector(1, data.Length, 1); builder.Add(data); return builder.EndVector(); }
  public static void StartDataVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddExpectedLength(FlatBufferBuilder builder, uint expectedLength) { builder.AddUint(2, expectedLength, 0); }
  public static void AddTimeout(FlatBufferBuilder builder, uint timeout) { builder.AddUint(3, timeout, 0); }
  public static Offset<ButtplugFFI.RawReadCmd> EndRawReadCmd(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<ButtplugFFI.RawReadCmd>(o);
  }
};


}
