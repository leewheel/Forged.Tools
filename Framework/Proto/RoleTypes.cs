// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: bgs/low/pb/client/role_types.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Bgs.Protocol {

  /// <summary>Holder for reflection information generated from bgs/low/pb/client/role_types.proto</summary>
  public static partial class RoleTypesReflection {

    #region Descriptor
    /// <summary>File descriptor for bgs/low/pb/client/role_types.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RoleTypesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJiZ3MvbG93L3BiL2NsaWVudC9yb2xlX3R5cGVzLnByb3RvEgxiZ3MucHJv",
            "dG9jb2wiwgEKBFJvbGUSCgoCaWQYASACKA0SDAoEbmFtZRgCIAIoCRIRCglw",
            "cml2aWxlZ2UYAyADKAkSGwoPYXNzaWduYWJsZV9yb2xlGAQgAygNQgIQARIQ",
            "CghyZXF1aXJlZBgFIAEoCBIOCgZ1bmlxdWUYBiABKAgSFwoPcmVsZWdhdGlv",
            "bl9yb2xlGAcgASgNEhkKDWtpY2thYmxlX3JvbGUYCSADKA1CAhABEhoKDnJl",
            "bW92YWJsZV9yb2xlGAogAygNQgIQASLGAQoJUm9sZVN0YXRlEgwKBG5hbWUY",
            "AiABKAkSGwoPYXNzaWduYWJsZV9yb2xlGAQgAygNQgIQARIQCghyZXF1aXJl",
            "ZBgFIAEoCBIOCgZ1bmlxdWUYBiABKAgSFwoPcmVsZWdhdGlvbl9yb2xlGAcg",
            "ASgNEhkKDWtpY2thYmxlX3JvbGUYCSADKA1CAhABEhoKDnJlbW92YWJsZV9y",
            "b2xlGAogAygNQgIQARIcChBtZW50aW9uYWJsZV9yb2xlGAsgAygNQgIQAQ=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.Role), global::Bgs.Protocol.Role.Parser, new[]{ "Id", "Name", "Privilege", "AssignableRole", "Required", "Unique", "RelegationRole", "KickableRole", "RemovableRole" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.RoleState), global::Bgs.Protocol.RoleState.Parser, new[]{ "Name", "AssignableRole", "Required", "Unique", "RelegationRole", "KickableRole", "RemovableRole", "MentionableRole" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Role : pb::IMessage<Role> {
    private static readonly pb::MessageParser<Role> _parser = new pb::MessageParser<Role>(() => new Role());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Role> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.RoleTypesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Role() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Role(Role other) : this() {
      _hasBits0 = other._hasBits0;
      id_ = other.id_;
      name_ = other.name_;
      privilege_ = other.privilege_.Clone();
      assignableRole_ = other.assignableRole_.Clone();
      required_ = other.required_;
      unique_ = other.unique_;
      relegationRole_ = other.relegationRole_;
      kickableRole_ = other.kickableRole_.Clone();
      removableRole_ = other.removableRole_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Role Clone() {
      return new Role(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private readonly static uint IdDefaultValue = 0;

    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Id {
      get { if ((_hasBits0 & 1) != 0) { return id_; } else { return IdDefaultValue; } }
      set {
        _hasBits0 |= 1;
        id_ = value;
      }
    }
    /// <summary>Gets whether the "id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private readonly static string NameDefaultValue = "";

    private string name_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_ ?? NameDefaultValue; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "name" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasName {
      get { return name_ != null; }
    }
    /// <summary>Clears the value of the "name" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearName() {
      name_ = null;
    }

    /// <summary>Field number for the "privilege" field.</summary>
    public const int PrivilegeFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_privilege_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> privilege_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Privilege {
      get { return privilege_; }
    }

    /// <summary>Field number for the "assignable_role" field.</summary>
    public const int AssignableRoleFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_assignableRole_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> assignableRole_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<uint> AssignableRole {
      get { return assignableRole_; }
    }

    /// <summary>Field number for the "required" field.</summary>
    public const int RequiredFieldNumber = 5;
    private readonly static bool RequiredDefaultValue = false;

    private bool required_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Required {
      get { if ((_hasBits0 & 2) != 0) { return required_; } else { return RequiredDefaultValue; } }
      set {
        _hasBits0 |= 2;
        required_ = value;
      }
    }
    /// <summary>Gets whether the "required" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasRequired {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "required" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearRequired() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "unique" field.</summary>
    public const int UniqueFieldNumber = 6;
    private readonly static bool UniqueDefaultValue = false;

    private bool unique_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Unique {
      get { if ((_hasBits0 & 4) != 0) { return unique_; } else { return UniqueDefaultValue; } }
      set {
        _hasBits0 |= 4;
        unique_ = value;
      }
    }
    /// <summary>Gets whether the "unique" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasUnique {
      get { return (_hasBits0 & 4) != 0; }
    }
    /// <summary>Clears the value of the "unique" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearUnique() {
      _hasBits0 &= ~4;
    }

    /// <summary>Field number for the "relegation_role" field.</summary>
    public const int RelegationRoleFieldNumber = 7;
    private readonly static uint RelegationRoleDefaultValue = 0;

    private uint relegationRole_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint RelegationRole {
      get { if ((_hasBits0 & 8) != 0) { return relegationRole_; } else { return RelegationRoleDefaultValue; } }
      set {
        _hasBits0 |= 8;
        relegationRole_ = value;
      }
    }
    /// <summary>Gets whether the "relegation_role" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasRelegationRole {
      get { return (_hasBits0 & 8) != 0; }
    }
    /// <summary>Clears the value of the "relegation_role" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearRelegationRole() {
      _hasBits0 &= ~8;
    }

    /// <summary>Field number for the "kickable_role" field.</summary>
    public const int KickableRoleFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_kickableRole_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> kickableRole_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<uint> KickableRole {
      get { return kickableRole_; }
    }

    /// <summary>Field number for the "removable_role" field.</summary>
    public const int RemovableRoleFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_removableRole_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> removableRole_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<uint> RemovableRole {
      get { return removableRole_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Role);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Role other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if(!privilege_.Equals(other.privilege_)) return false;
      if(!assignableRole_.Equals(other.assignableRole_)) return false;
      if (Required != other.Required) return false;
      if (Unique != other.Unique) return false;
      if (RelegationRole != other.RelegationRole) return false;
      if(!kickableRole_.Equals(other.kickableRole_)) return false;
      if(!removableRole_.Equals(other.removableRole_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasId) hash ^= Id.GetHashCode();
      if (HasName) hash ^= Name.GetHashCode();
      hash ^= privilege_.GetHashCode();
      hash ^= assignableRole_.GetHashCode();
      if (HasRequired) hash ^= Required.GetHashCode();
      if (HasUnique) hash ^= Unique.GetHashCode();
      if (HasRelegationRole) hash ^= RelegationRole.GetHashCode();
      hash ^= kickableRole_.GetHashCode();
      hash ^= removableRole_.GetHashCode();
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
        output.WriteRawTag(8);
        output.WriteUInt32(Id);
      }
      if (HasName) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      privilege_.WriteTo(output, _repeated_privilege_codec);
      assignableRole_.WriteTo(output, _repeated_assignableRole_codec);
      if (HasRequired) {
        output.WriteRawTag(40);
        output.WriteBool(Required);
      }
      if (HasUnique) {
        output.WriteRawTag(48);
        output.WriteBool(Unique);
      }
      if (HasRelegationRole) {
        output.WriteRawTag(56);
        output.WriteUInt32(RelegationRole);
      }
      kickableRole_.WriteTo(output, _repeated_kickableRole_codec);
      removableRole_.WriteTo(output, _repeated_removableRole_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasId) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (HasName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += privilege_.CalculateSize(_repeated_privilege_codec);
      size += assignableRole_.CalculateSize(_repeated_assignableRole_codec);
      if (HasRequired) {
        size += 1 + 1;
      }
      if (HasUnique) {
        size += 1 + 1;
      }
      if (HasRelegationRole) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RelegationRole);
      }
      size += kickableRole_.CalculateSize(_repeated_kickableRole_codec);
      size += removableRole_.CalculateSize(_repeated_removableRole_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Role other) {
      if (other == null) {
        return;
      }
      if (other.HasId) {
        Id = other.Id;
      }
      if (other.HasName) {
        Name = other.Name;
      }
      privilege_.Add(other.privilege_);
      assignableRole_.Add(other.assignableRole_);
      if (other.HasRequired) {
        Required = other.Required;
      }
      if (other.HasUnique) {
        Unique = other.Unique;
      }
      if (other.HasRelegationRole) {
        RelegationRole = other.RelegationRole;
      }
      kickableRole_.Add(other.kickableRole_);
      removableRole_.Add(other.removableRole_);
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
          case 8: {
            Id = input.ReadUInt32();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            privilege_.AddEntriesFrom(input, _repeated_privilege_codec);
            break;
          }
          case 34:
          case 32: {
            assignableRole_.AddEntriesFrom(input, _repeated_assignableRole_codec);
            break;
          }
          case 40: {
            Required = input.ReadBool();
            break;
          }
          case 48: {
            Unique = input.ReadBool();
            break;
          }
          case 56: {
            RelegationRole = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            kickableRole_.AddEntriesFrom(input, _repeated_kickableRole_codec);
            break;
          }
          case 82:
          case 80: {
            removableRole_.AddEntriesFrom(input, _repeated_removableRole_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class RoleState : pb::IMessage<RoleState> {
    private static readonly pb::MessageParser<RoleState> _parser = new pb::MessageParser<RoleState>(() => new RoleState());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoleState> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.RoleTypesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoleState() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoleState(RoleState other) : this() {
      _hasBits0 = other._hasBits0;
      name_ = other.name_;
      assignableRole_ = other.assignableRole_.Clone();
      required_ = other.required_;
      unique_ = other.unique_;
      relegationRole_ = other.relegationRole_;
      kickableRole_ = other.kickableRole_.Clone();
      removableRole_ = other.removableRole_.Clone();
      mentionableRole_ = other.mentionableRole_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoleState Clone() {
      return new RoleState(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private readonly static string NameDefaultValue = "";

    private string name_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_ ?? NameDefaultValue; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "name" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasName {
      get { return name_ != null; }
    }
    /// <summary>Clears the value of the "name" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearName() {
      name_ = null;
    }

    /// <summary>Field number for the "assignable_role" field.</summary>
    public const int AssignableRoleFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_assignableRole_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> assignableRole_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<uint> AssignableRole {
      get { return assignableRole_; }
    }

    /// <summary>Field number for the "required" field.</summary>
    public const int RequiredFieldNumber = 5;
    private readonly static bool RequiredDefaultValue = false;

    private bool required_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Required {
      get { if ((_hasBits0 & 1) != 0) { return required_; } else { return RequiredDefaultValue; } }
      set {
        _hasBits0 |= 1;
        required_ = value;
      }
    }
    /// <summary>Gets whether the "required" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasRequired {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "required" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearRequired() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "unique" field.</summary>
    public const int UniqueFieldNumber = 6;
    private readonly static bool UniqueDefaultValue = false;

    private bool unique_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Unique {
      get { if ((_hasBits0 & 2) != 0) { return unique_; } else { return UniqueDefaultValue; } }
      set {
        _hasBits0 |= 2;
        unique_ = value;
      }
    }
    /// <summary>Gets whether the "unique" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasUnique {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "unique" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearUnique() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "relegation_role" field.</summary>
    public const int RelegationRoleFieldNumber = 7;
    private readonly static uint RelegationRoleDefaultValue = 0;

    private uint relegationRole_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint RelegationRole {
      get { if ((_hasBits0 & 4) != 0) { return relegationRole_; } else { return RelegationRoleDefaultValue; } }
      set {
        _hasBits0 |= 4;
        relegationRole_ = value;
      }
    }
    /// <summary>Gets whether the "relegation_role" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasRelegationRole {
      get { return (_hasBits0 & 4) != 0; }
    }
    /// <summary>Clears the value of the "relegation_role" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearRelegationRole() {
      _hasBits0 &= ~4;
    }

    /// <summary>Field number for the "kickable_role" field.</summary>
    public const int KickableRoleFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_kickableRole_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> kickableRole_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<uint> KickableRole {
      get { return kickableRole_; }
    }

    /// <summary>Field number for the "removable_role" field.</summary>
    public const int RemovableRoleFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_removableRole_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> removableRole_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<uint> RemovableRole {
      get { return removableRole_; }
    }

    /// <summary>Field number for the "mentionable_role" field.</summary>
    public const int MentionableRoleFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_mentionableRole_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> mentionableRole_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<uint> MentionableRole {
      get { return mentionableRole_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoleState);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoleState other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if(!assignableRole_.Equals(other.assignableRole_)) return false;
      if (Required != other.Required) return false;
      if (Unique != other.Unique) return false;
      if (RelegationRole != other.RelegationRole) return false;
      if(!kickableRole_.Equals(other.kickableRole_)) return false;
      if(!removableRole_.Equals(other.removableRole_)) return false;
      if(!mentionableRole_.Equals(other.mentionableRole_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasName) hash ^= Name.GetHashCode();
      hash ^= assignableRole_.GetHashCode();
      if (HasRequired) hash ^= Required.GetHashCode();
      if (HasUnique) hash ^= Unique.GetHashCode();
      if (HasRelegationRole) hash ^= RelegationRole.GetHashCode();
      hash ^= kickableRole_.GetHashCode();
      hash ^= removableRole_.GetHashCode();
      hash ^= mentionableRole_.GetHashCode();
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
      if (HasName) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      assignableRole_.WriteTo(output, _repeated_assignableRole_codec);
      if (HasRequired) {
        output.WriteRawTag(40);
        output.WriteBool(Required);
      }
      if (HasUnique) {
        output.WriteRawTag(48);
        output.WriteBool(Unique);
      }
      if (HasRelegationRole) {
        output.WriteRawTag(56);
        output.WriteUInt32(RelegationRole);
      }
      kickableRole_.WriteTo(output, _repeated_kickableRole_codec);
      removableRole_.WriteTo(output, _repeated_removableRole_codec);
      mentionableRole_.WriteTo(output, _repeated_mentionableRole_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += assignableRole_.CalculateSize(_repeated_assignableRole_codec);
      if (HasRequired) {
        size += 1 + 1;
      }
      if (HasUnique) {
        size += 1 + 1;
      }
      if (HasRelegationRole) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RelegationRole);
      }
      size += kickableRole_.CalculateSize(_repeated_kickableRole_codec);
      size += removableRole_.CalculateSize(_repeated_removableRole_codec);
      size += mentionableRole_.CalculateSize(_repeated_mentionableRole_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RoleState other) {
      if (other == null) {
        return;
      }
      if (other.HasName) {
        Name = other.Name;
      }
      assignableRole_.Add(other.assignableRole_);
      if (other.HasRequired) {
        Required = other.Required;
      }
      if (other.HasUnique) {
        Unique = other.Unique;
      }
      if (other.HasRelegationRole) {
        RelegationRole = other.RelegationRole;
      }
      kickableRole_.Add(other.kickableRole_);
      removableRole_.Add(other.removableRole_);
      mentionableRole_.Add(other.mentionableRole_);
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
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 34:
          case 32: {
            assignableRole_.AddEntriesFrom(input, _repeated_assignableRole_codec);
            break;
          }
          case 40: {
            Required = input.ReadBool();
            break;
          }
          case 48: {
            Unique = input.ReadBool();
            break;
          }
          case 56: {
            RelegationRole = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            kickableRole_.AddEntriesFrom(input, _repeated_kickableRole_codec);
            break;
          }
          case 82:
          case 80: {
            removableRole_.AddEntriesFrom(input, _repeated_removableRole_codec);
            break;
          }
          case 90:
          case 88: {
            mentionableRole_.AddEntriesFrom(input, _repeated_mentionableRole_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code