// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace ButtplugFFI
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct ConnectLocal : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static ConnectLocal GetRootAsConnectLocal(ByteBuffer _bb) { return GetRootAsConnectLocal(_bb, new ConnectLocal()); }
  public static ConnectLocal GetRootAsConnectLocal(ByteBuffer _bb, ConnectLocal obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConnectLocal __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string ServerName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetServerNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetServerNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetServerNameArray() { return __p.__vector_as_array<byte>(4); }
  public uint MaxPingTime { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public ushort CommManagerTypes { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUshort(o + __p.bb_pos) : (ushort)0; } }

  public static Offset<ButtplugFFI.ConnectLocal> CreateConnectLocal(FlatBufferBuilder builder,
      StringOffset server_nameOffset = default(StringOffset),
      uint max_ping_time = 0,
      ushort comm_manager_types = 0) {
    builder.StartTable(3);
    ConnectLocal.AddMaxPingTime(builder, max_ping_time);
    ConnectLocal.AddServerName(builder, server_nameOffset);
    ConnectLocal.AddCommManagerTypes(builder, comm_manager_types);
    return ConnectLocal.EndConnectLocal(builder);
  }

  public static void StartConnectLocal(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddServerName(FlatBufferBuilder builder, StringOffset serverNameOffset) { builder.AddOffset(0, serverNameOffset.Value, 0); }
  public static void AddMaxPingTime(FlatBufferBuilder builder, uint maxPingTime) { builder.AddUint(1, maxPingTime, 0); }
  public static void AddCommManagerTypes(FlatBufferBuilder builder, ushort commManagerTypes) { builder.AddUshort(2, commManagerTypes, 0); }
  public static Offset<ButtplugFFI.ConnectLocal> EndConnectLocal(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<ButtplugFFI.ConnectLocal>(o);
  }
};


}
