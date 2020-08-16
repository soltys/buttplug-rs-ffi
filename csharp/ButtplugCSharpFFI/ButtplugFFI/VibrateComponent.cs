// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace ButtplugFFI
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct VibrateComponent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static VibrateComponent GetRootAsVibrateComponent(ByteBuffer _bb) { return GetRootAsVibrateComponent(_bb, new VibrateComponent()); }
  public static VibrateComponent GetRootAsVibrateComponent(ByteBuffer _bb, VibrateComponent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public VibrateComponent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Index { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public double Speed { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetDouble(o + __p.bb_pos) : (double)0.0; } }

  public static Offset<ButtplugFFI.VibrateComponent> CreateVibrateComponent(FlatBufferBuilder builder,
      uint index = 0,
      double speed = 0.0) {
    builder.StartTable(2);
    VibrateComponent.AddSpeed(builder, speed);
    VibrateComponent.AddIndex(builder, index);
    return VibrateComponent.EndVibrateComponent(builder);
  }

  public static void StartVibrateComponent(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddIndex(FlatBufferBuilder builder, uint index) { builder.AddUint(0, index, 0); }
  public static void AddSpeed(FlatBufferBuilder builder, double speed) { builder.AddDouble(1, speed, 0.0); }
  public static Offset<ButtplugFFI.VibrateComponent> EndVibrateComponent(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<ButtplugFFI.VibrateComponent>(o);
  }
};


}
