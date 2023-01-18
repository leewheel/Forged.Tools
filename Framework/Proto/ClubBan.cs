// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: bgs/low/pb/client/club_ban.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Bgs.Protocol.Club.V1 {

  /// <summary>Holder for reflection information generated from bgs/low/pb/client/club_ban.proto</summary>
  public static partial class ClubBanReflection {

    #region Descriptor
    /// <summary>File descriptor for bgs/low/pb/client/club_ban.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClubBanReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBiZ3MvbG93L3BiL2NsaWVudC9jbHViX2Jhbi5wcm90bxIUYmdzLnByb3Rv",
            "Y29sLmNsdWIudjEaN2Jncy9sb3cvcGIvY2xpZW50L2dsb2JhbF9leHRlbnNp",
            "b25zL2ZpZWxkX29wdGlvbnMucHJvdG8aI2Jncy9sb3cvcGIvY2xpZW50L2Ns",
            "dWJfbWVtYmVyLnByb3RvGjViZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50",
            "L3YyL2F0dHJpYnV0ZV90eXBlcy5wcm90byKBAQoNQWRkQmFuT3B0aW9ucxIx",
            "Cgl0YXJnZXRfaWQYASABKAsyHi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5NZW1i",
            "ZXJJZBItCglhdHRyaWJ1dGUYAiADKAsyGi5iZ3MucHJvdG9jb2wudjIuQXR0",
            "cmlidXRlEg4KBnJlYXNvbhgDIAEoCSLhAQoHQ2x1YkJhbhIqCgJpZBgBIAEo",
            "CzIeLmJncy5wcm90b2NvbC5jbHViLnYxLk1lbWJlcklkEhoKCmJhdHRsZV90",
            "YWcYAiABKAlCBoL5KwIIARI4CgdjcmVhdG9yGAMgASgLMicuYmdzLnByb3Rv",
            "Y29sLmNsdWIudjEuTWVtYmVyRGVzY3JpcHRpb24SLQoJYXR0cmlidXRlGAQg",
            "AygLMhouYmdzLnByb3RvY29sLnYyLkF0dHJpYnV0ZRIOCgZyZWFzb24YBSAB",
            "KAkSFQoNY3JlYXRpb25fdGltZRgGIAEoBA=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Bgs.Protocol.FieldOptionsReflection.Descriptor, global::Bgs.Protocol.Club.V1.ClubMemberReflection.Descriptor, global::Bgs.Protocol.V2.AttributeTypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.Club.V1.AddBanOptions), global::Bgs.Protocol.Club.V1.AddBanOptions.Parser, new[]{ "TargetId", "Attribute", "Reason" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.Club.V1.ClubBan), global::Bgs.Protocol.Club.V1.ClubBan.Parser, new[]{ "Id", "BattleTag", "Creator", "Attribute", "Reason", "CreationTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AddBanOptions : pb::IMessage<AddBanOptions> {
    private static readonly pb::MessageParser<AddBanOptions> _parser = new pb::MessageParser<AddBanOptions>(() => new AddBanOptions());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddBanOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.Club.V1.ClubBanReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddBanOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddBanOptions(AddBanOptions other) : this() {
      targetId_ = other.HasTargetId ? other.targetId_.Clone() : null;
      attribute_ = other.attribute_.Clone();
      reason_ = other.reason_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddBanOptions Clone() {
      return new AddBanOptions(this);
    }

    /// <summary>Field number for the "target_id" field.</summary>
    public const int TargetIdFieldNumber = 1;
    private global::Bgs.Protocol.Club.V1.MemberId targetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Bgs.Protocol.Club.V1.MemberId TargetId {
      get { return targetId_; }
      set {
        targetId_ = value;
      }
    }
    /// <summary>Gets whether the target_id field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasTargetId {
      get { return targetId_ != null; }
    }
    /// <summary>Clears the value of the target_id field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearTargetId() {
      targetId_ = null;
    }

    /// <summary>Field number for the "attribute" field.</summary>
    public const int AttributeFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Bgs.Protocol.V2.Attribute> _repeated_attribute_codec
        = pb::FieldCodec.ForMessage(18, global::Bgs.Protocol.V2.Attribute.Parser);
    private readonly pbc::RepeatedField<global::Bgs.Protocol.V2.Attribute> attribute_ = new pbc::RepeatedField<global::Bgs.Protocol.V2.Attribute>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Bgs.Protocol.V2.Attribute> Attribute {
      get { return attribute_; }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 3;
    private readonly static string ReasonDefaultValue = "";

    private string reason_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Reason {
      get { return reason_ ?? ReasonDefaultValue; }
      set {
        reason_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "reason" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasReason {
      get { return reason_ != null; }
    }
    /// <summary>Clears the value of the "reason" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearReason() {
      reason_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddBanOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddBanOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(TargetId, other.TargetId)) return false;
      if(!attribute_.Equals(other.attribute_)) return false;
      if (Reason != other.Reason) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasTargetId) hash ^= TargetId.GetHashCode();
      hash ^= attribute_.GetHashCode();
      if (HasReason) hash ^= Reason.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (HasTargetId) {
        output.WriteRawTag(10);
        output.WriteMessage(TargetId);
      }
      attribute_.WriteTo(output, _repeated_attribute_codec);
      if (HasReason) {
        output.WriteRawTag(26);
        output.WriteString(Reason);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasTargetId) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetId);
      }
      size += attribute_.CalculateSize(_repeated_attribute_codec);
      if (HasReason) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Reason);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddBanOptions other) {
      if (other == null) {
        return;
      }
      if (other.HasTargetId) {
        if (!HasTargetId) {
          TargetId = new global::Bgs.Protocol.Club.V1.MemberId();
        }
        TargetId.MergeFrom(other.TargetId);
      }
      attribute_.Add(other.attribute_);
      if (other.HasReason) {
        Reason = other.Reason;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (!HasTargetId) {
              TargetId = new global::Bgs.Protocol.Club.V1.MemberId();
            }
            input.ReadMessage(TargetId);
            break;
          }
          case 18: {
            attribute_.AddEntriesFrom(input, _repeated_attribute_codec);
            break;
          }
          case 26: {
            Reason = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ClubBan : pb::IMessage<ClubBan> {
    private static readonly pb::MessageParser<ClubBan> _parser = new pb::MessageParser<ClubBan>(() => new ClubBan());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClubBan> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.Club.V1.ClubBanReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClubBan() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClubBan(ClubBan other) : this() {
      _hasBits0 = other._hasBits0;
      id_ = other.HasId ? other.id_.Clone() : null;
      battleTag_ = other.battleTag_;
      creator_ = other.HasCreator ? other.creator_.Clone() : null;
      attribute_ = other.attribute_.Clone();
      reason_ = other.reason_;
      creationTime_ = other.creationTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClubBan Clone() {
      return new ClubBan(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private global::Bgs.Protocol.Club.V1.MemberId id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Bgs.Protocol.Club.V1.MemberId Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }
    /// <summary>Gets whether the id field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasId {
      get { return id_ != null; }
    }
    /// <summary>Clears the value of the id field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearId() {
      id_ = null;
    }

    /// <summary>Field number for the "battle_tag" field.</summary>
    public const int BattleTagFieldNumber = 2;
    private readonly static string BattleTagDefaultValue = "";

    private string battleTag_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BattleTag {
      get { return battleTag_ ?? BattleTagDefaultValue; }
      set {
        battleTag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "battle_tag" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasBattleTag {
      get { return battleTag_ != null; }
    }
    /// <summary>Clears the value of the "battle_tag" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearBattleTag() {
      battleTag_ = null;
    }

    /// <summary>Field number for the "creator" field.</summary>
    public const int CreatorFieldNumber = 3;
    private global::Bgs.Protocol.Club.V1.MemberDescription creator_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Bgs.Protocol.Club.V1.MemberDescription Creator {
      get { return creator_; }
      set {
        creator_ = value;
      }
    }
    /// <summary>Gets whether the creator field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasCreator {
      get { return creator_ != null; }
    }
    /// <summary>Clears the value of the creator field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearCreator() {
      creator_ = null;
    }

    /// <summary>Field number for the "attribute" field.</summary>
    public const int AttributeFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Bgs.Protocol.V2.Attribute> _repeated_attribute_codec
        = pb::FieldCodec.ForMessage(34, global::Bgs.Protocol.V2.Attribute.Parser);
    private readonly pbc::RepeatedField<global::Bgs.Protocol.V2.Attribute> attribute_ = new pbc::RepeatedField<global::Bgs.Protocol.V2.Attribute>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Bgs.Protocol.V2.Attribute> Attribute {
      get { return attribute_; }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 5;
    private readonly static string ReasonDefaultValue = "";

    private string reason_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Reason {
      get { return reason_ ?? ReasonDefaultValue; }
      set {
        reason_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "reason" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasReason {
      get { return reason_ != null; }
    }
    /// <summary>Clears the value of the "reason" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearReason() {
      reason_ = null;
    }

    /// <summary>Field number for the "creation_time" field.</summary>
    public const int CreationTimeFieldNumber = 6;
    private readonly static ulong CreationTimeDefaultValue = 0UL;

    private ulong creationTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong CreationTime {
      get { if ((_hasBits0 & 1) != 0) { return creationTime_; } else { return CreationTimeDefaultValue; } }
      set {
        _hasBits0 |= 1;
        creationTime_ = value;
      }
    }
    /// <summary>Gets whether the "creation_time" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasCreationTime {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "creation_time" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearCreationTime() {
      _hasBits0 &= ~1;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClubBan);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClubBan other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Id, other.Id)) return false;
      if (BattleTag != other.BattleTag) return false;
      if (!object.Equals(Creator, other.Creator)) return false;
      if(!attribute_.Equals(other.attribute_)) return false;
      if (Reason != other.Reason) return false;
      if (CreationTime != other.CreationTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasId) hash ^= Id.GetHashCode();
      if (HasBattleTag) hash ^= BattleTag.GetHashCode();
      if (HasCreator) hash ^= Creator.GetHashCode();
      hash ^= attribute_.GetHashCode();
      if (HasReason) hash ^= Reason.GetHashCode();
      if (HasCreationTime) hash ^= CreationTime.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (HasId) {
        output.WriteRawTag(10);
        output.WriteMessage(Id);
      }
      if (HasBattleTag) {
        output.WriteRawTag(18);
        output.WriteString(BattleTag);
      }
      if (HasCreator) {
        output.WriteRawTag(26);
        output.WriteMessage(Creator);
      }
      attribute_.WriteTo(output, _repeated_attribute_codec);
      if (HasReason) {
        output.WriteRawTag(42);
        output.WriteString(Reason);
      }
      if (HasCreationTime) {
        output.WriteRawTag(48);
        output.WriteUInt64(CreationTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasId) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Id);
      }
      if (HasBattleTag) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BattleTag);
      }
      if (HasCreator) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Creator);
      }
      size += attribute_.CalculateSize(_repeated_attribute_codec);
      if (HasReason) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Reason);
      }
      if (HasCreationTime) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(CreationTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClubBan other) {
      if (other == null) {
        return;
      }
      if (other.HasId) {
        if (!HasId) {
          Id = new global::Bgs.Protocol.Club.V1.MemberId();
        }
        Id.MergeFrom(other.Id);
      }
      if (other.HasBattleTag) {
        BattleTag = other.BattleTag;
      }
      if (other.HasCreator) {
        if (!HasCreator) {
          Creator = new global::Bgs.Protocol.Club.V1.MemberDescription();
        }
        Creator.MergeFrom(other.Creator);
      }
      attribute_.Add(other.attribute_);
      if (other.HasReason) {
        Reason = other.Reason;
      }
      if (other.HasCreationTime) {
        CreationTime = other.CreationTime;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (!HasId) {
              Id = new global::Bgs.Protocol.Club.V1.MemberId();
            }
            input.ReadMessage(Id);
            break;
          }
          case 18: {
            BattleTag = input.ReadString();
            break;
          }
          case 26: {
            if (!HasCreator) {
              Creator = new global::Bgs.Protocol.Club.V1.MemberDescription();
            }
            input.ReadMessage(Creator);
            break;
          }
          case 34: {
            attribute_.AddEntriesFrom(input, _repeated_attribute_codec);
            break;
          }
          case 42: {
            Reason = input.ReadString();
            break;
          }
          case 48: {
            CreationTime = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code