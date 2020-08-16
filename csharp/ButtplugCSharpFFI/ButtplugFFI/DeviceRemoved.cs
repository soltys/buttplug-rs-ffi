// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace ButtplugFFI
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct DeviceRemoved : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static DeviceRemoved GetRootAsDeviceRemoved(ByteBuffer _bb) { return GetRootAsDeviceRemoved(_bb, new DeviceRemoved()); }
  public static DeviceRemoved GetRootAsDeviceRemoved(ByteBuffer _bb, DeviceRemoved obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public DeviceRemoved __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Index { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }

  public static Offset<ButtplugFFI.DeviceRemoved> CreateDeviceRemoved(FlatBufferBuilder builder,
      uint index = 0) {
    builder.StartTable(1);
    DeviceRemoved.AddIndex(builder, index);
    return DeviceRemoved.EndDeviceRemoved(builder);
  }

  public static void StartDeviceRemoved(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddIndex(FlatBufferBuilder builder, uint index) { builder.AddUint(0, index, 0); }
  public static Offset<ButtplugFFI.DeviceRemoved> EndDeviceRemoved(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<ButtplugFFI.DeviceRemoved>(o);
  }
};


}
