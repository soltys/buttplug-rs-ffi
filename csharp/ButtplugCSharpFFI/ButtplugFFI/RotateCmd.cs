// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace ButtplugFFI
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct RotateCmd : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static RotateCmd GetRootAsRotateCmd(ByteBuffer _bb) { return GetRootAsRotateCmd(_bb, new RotateCmd()); }
  public static RotateCmd GetRootAsRotateCmd(ByteBuffer _bb, RotateCmd obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RotateCmd __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public ButtplugFFI.RotateComponent? Rotations(int j) { int o = __p.__offset(4); return o != 0 ? (ButtplugFFI.RotateComponent?)(new ButtplugFFI.RotateComponent()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int RotationsLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<ButtplugFFI.RotateCmd> CreateRotateCmd(FlatBufferBuilder builder,
      VectorOffset rotationsOffset = default(VectorOffset)) {
    builder.StartTable(1);
    RotateCmd.AddRotations(builder, rotationsOffset);
    return RotateCmd.EndRotateCmd(builder);
  }

  public static void StartRotateCmd(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddRotations(FlatBufferBuilder builder, VectorOffset rotationsOffset) { builder.AddOffset(0, rotationsOffset.Value, 0); }
  public static VectorOffset CreateRotationsVector(FlatBufferBuilder builder, Offset<ButtplugFFI.RotateComponent>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateRotationsVectorBlock(FlatBufferBuilder builder, Offset<ButtplugFFI.RotateComponent>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartRotationsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<ButtplugFFI.RotateCmd> EndRotateCmd(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<ButtplugFFI.RotateCmd>(o);
  }
};


}
