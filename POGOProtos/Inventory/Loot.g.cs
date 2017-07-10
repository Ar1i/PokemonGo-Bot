// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Inventory/Loot.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Inventory {

  /// <summary>Holder for reflection information generated from POGOProtos/Inventory/Loot.proto</summary>
  public static partial class LootReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Inventory/Loot.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LootReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9QT0dPUHJvdG9zL0ludmVudG9yeS9Mb290LnByb3RvEhRQT0dPUHJvdG9z",
            "LkludmVudG9yeRojUE9HT1Byb3Rvcy9JbnZlbnRvcnkvTG9vdEl0ZW0ucHJv",
            "dG8iOQoETG9vdBIxCglsb290X2l0ZW0YASADKAsyHi5QT0dPUHJvdG9zLklu",
            "dmVudG9yeS5Mb290SXRlbWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Inventory.LootItemReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Inventory.Loot), global::POGOProtos.Inventory.Loot.Parser, new[]{ "LootItem" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Loot : pb::IMessage<Loot> {
    private static readonly pb::MessageParser<Loot> _parser = new pb::MessageParser<Loot>(() => new Loot());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Loot> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Inventory.LootReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Loot() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Loot(Loot other) : this() {
      lootItem_ = other.lootItem_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Loot Clone() {
      return new Loot(this);
    }

    /// <summary>Field number for the "loot_item" field.</summary>
    public const int LootItemFieldNumber = 1;
    private static readonly pb::FieldCodec<global::POGOProtos.Inventory.LootItem> _repeated_lootItem_codec
        = pb::FieldCodec.ForMessage(10, global::POGOProtos.Inventory.LootItem.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Inventory.LootItem> lootItem_ = new pbc::RepeatedField<global::POGOProtos.Inventory.LootItem>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Inventory.LootItem> LootItem {
      get { return lootItem_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Loot);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Loot other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!lootItem_.Equals(other.lootItem_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= lootItem_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      lootItem_.WriteTo(output, _repeated_lootItem_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += lootItem_.CalculateSize(_repeated_lootItem_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Loot other) {
      if (other == null) {
        return;
      }
      lootItem_.Add(other.lootItem_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            lootItem_.AddEntriesFrom(input, _repeated_lootItem_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code