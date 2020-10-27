// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protos/GStoreServer.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from protos/GStoreServer.proto</summary>
public static partial class GStoreServerReflection {

  #region Descriptor
  /// <summary>File descriptor for protos/GStoreServer.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GStoreServerReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Chlwcm90b3MvR1N0b3JlU2VydmVyLnByb3RvIjgKG0dTdG9yZUNsaWVudFJl",
          "Z2lzdGVyUmVxdWVzdBIMCgRuaWNrGAEgASgJEgsKA3VybBgCIAEoCSIxChlH",
          "U3RvcmVDbGllbnRSZWdpc3RlclJlcGx5EhQKBXVzZXJzGAEgAygLMgUuVXNl",
          "ciIUCgRVc2VyEgwKBG5pY2sYASABKAkiLAoPQmNhc3RNc2dSZXF1ZXN0EgwK",
          "BG5pY2sYASABKAkSCwoDbXNnGAIgASgJIhsKDUJjYXN0TXNnUmVwbHkSCgoC",
          "b2sYASABKAgyiQEKE0dTdG9yZVNlcnZlclNlcnZpY2USRAoIUmVnaXN0ZXIS",
          "HC5HU3RvcmVDbGllbnRSZWdpc3RlclJlcXVlc3QaGi5HU3RvcmVDbGllbnRS",
          "ZWdpc3RlclJlcGx5EiwKCEJjYXN0TXNnEhAuQmNhc3RNc2dSZXF1ZXN0Gg4u",
          "QmNhc3RNc2dSZXBseWIGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GStoreClientRegisterRequest), global::GStoreClientRegisterRequest.Parser, new[]{ "Nick", "Url" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::GStoreClientRegisterReply), global::GStoreClientRegisterReply.Parser, new[]{ "Users" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::User), global::User.Parser, new[]{ "Nick" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::BcastMsgRequest), global::BcastMsgRequest.Parser, new[]{ "Nick", "Msg" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::BcastMsgReply), global::BcastMsgReply.Parser, new[]{ "Ok" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class GStoreClientRegisterRequest : pb::IMessage<GStoreClientRegisterRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GStoreClientRegisterRequest> _parser = new pb::MessageParser<GStoreClientRegisterRequest>(() => new GStoreClientRegisterRequest());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<GStoreClientRegisterRequest> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GStoreServerReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public GStoreClientRegisterRequest() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public GStoreClientRegisterRequest(GStoreClientRegisterRequest other) : this() {
    nick_ = other.nick_;
    url_ = other.url_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public GStoreClientRegisterRequest Clone() {
    return new GStoreClientRegisterRequest(this);
  }

  /// <summary>Field number for the "nick" field.</summary>
  public const int NickFieldNumber = 1;
  private string nick_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Nick {
    get { return nick_; }
    set {
      nick_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "url" field.</summary>
  public const int UrlFieldNumber = 2;
  private string url_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Url {
    get { return url_; }
    set {
      url_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as GStoreClientRegisterRequest);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(GStoreClientRegisterRequest other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Nick != other.Nick) return false;
    if (Url != other.Url) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Nick.Length != 0) hash ^= Nick.GetHashCode();
    if (Url.Length != 0) hash ^= Url.GetHashCode();
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
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (Nick.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Nick);
    }
    if (Url.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Url);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Nick.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Nick);
    }
    if (Url.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Url);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Nick.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Nick);
    }
    if (Url.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Url);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(GStoreClientRegisterRequest other) {
    if (other == null) {
      return;
    }
    if (other.Nick.Length != 0) {
      Nick = other.Nick;
    }
    if (other.Url.Length != 0) {
      Url = other.Url;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Nick = input.ReadString();
          break;
        }
        case 18: {
          Url = input.ReadString();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          Nick = input.ReadString();
          break;
        }
        case 18: {
          Url = input.ReadString();
          break;
        }
      }
    }
  }
  #endif

}

public sealed partial class GStoreClientRegisterReply : pb::IMessage<GStoreClientRegisterReply>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GStoreClientRegisterReply> _parser = new pb::MessageParser<GStoreClientRegisterReply>(() => new GStoreClientRegisterReply());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<GStoreClientRegisterReply> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GStoreServerReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public GStoreClientRegisterReply() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public GStoreClientRegisterReply(GStoreClientRegisterReply other) : this() {
    users_ = other.users_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public GStoreClientRegisterReply Clone() {
    return new GStoreClientRegisterReply(this);
  }

  /// <summary>Field number for the "users" field.</summary>
  public const int UsersFieldNumber = 1;
  private static readonly pb::FieldCodec<global::User> _repeated_users_codec
      = pb::FieldCodec.ForMessage(10, global::User.Parser);
  private readonly pbc::RepeatedField<global::User> users_ = new pbc::RepeatedField<global::User>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::User> Users {
    get { return users_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as GStoreClientRegisterReply);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(GStoreClientRegisterReply other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!users_.Equals(other.users_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= users_.GetHashCode();
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
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    users_.WriteTo(output, _repeated_users_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    users_.WriteTo(ref output, _repeated_users_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    size += users_.CalculateSize(_repeated_users_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(GStoreClientRegisterReply other) {
    if (other == null) {
      return;
    }
    users_.Add(other.users_);
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          users_.AddEntriesFrom(input, _repeated_users_codec);
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          users_.AddEntriesFrom(ref input, _repeated_users_codec);
          break;
        }
      }
    }
  }
  #endif

}

public sealed partial class User : pb::IMessage<User>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<User> _parser = new pb::MessageParser<User>(() => new User());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<User> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GStoreServerReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public User() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public User(User other) : this() {
    nick_ = other.nick_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public User Clone() {
    return new User(this);
  }

  /// <summary>Field number for the "nick" field.</summary>
  public const int NickFieldNumber = 1;
  private string nick_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Nick {
    get { return nick_; }
    set {
      nick_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as User);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(User other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Nick != other.Nick) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Nick.Length != 0) hash ^= Nick.GetHashCode();
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
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (Nick.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Nick);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Nick.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Nick);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Nick.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Nick);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(User other) {
    if (other == null) {
      return;
    }
    if (other.Nick.Length != 0) {
      Nick = other.Nick;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Nick = input.ReadString();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          Nick = input.ReadString();
          break;
        }
      }
    }
  }
  #endif

}

public sealed partial class BcastMsgRequest : pb::IMessage<BcastMsgRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<BcastMsgRequest> _parser = new pb::MessageParser<BcastMsgRequest>(() => new BcastMsgRequest());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<BcastMsgRequest> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GStoreServerReflection.Descriptor.MessageTypes[3]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public BcastMsgRequest() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public BcastMsgRequest(BcastMsgRequest other) : this() {
    nick_ = other.nick_;
    msg_ = other.msg_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public BcastMsgRequest Clone() {
    return new BcastMsgRequest(this);
  }

  /// <summary>Field number for the "nick" field.</summary>
  public const int NickFieldNumber = 1;
  private string nick_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Nick {
    get { return nick_; }
    set {
      nick_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "msg" field.</summary>
  public const int MsgFieldNumber = 2;
  private string msg_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Msg {
    get { return msg_; }
    set {
      msg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as BcastMsgRequest);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(BcastMsgRequest other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Nick != other.Nick) return false;
    if (Msg != other.Msg) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Nick.Length != 0) hash ^= Nick.GetHashCode();
    if (Msg.Length != 0) hash ^= Msg.GetHashCode();
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
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (Nick.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Nick);
    }
    if (Msg.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Msg);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Nick.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Nick);
    }
    if (Msg.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Msg);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Nick.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Nick);
    }
    if (Msg.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Msg);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(BcastMsgRequest other) {
    if (other == null) {
      return;
    }
    if (other.Nick.Length != 0) {
      Nick = other.Nick;
    }
    if (other.Msg.Length != 0) {
      Msg = other.Msg;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Nick = input.ReadString();
          break;
        }
        case 18: {
          Msg = input.ReadString();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          Nick = input.ReadString();
          break;
        }
        case 18: {
          Msg = input.ReadString();
          break;
        }
      }
    }
  }
  #endif

}

public sealed partial class BcastMsgReply : pb::IMessage<BcastMsgReply>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<BcastMsgReply> _parser = new pb::MessageParser<BcastMsgReply>(() => new BcastMsgReply());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<BcastMsgReply> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GStoreServerReflection.Descriptor.MessageTypes[4]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public BcastMsgReply() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public BcastMsgReply(BcastMsgReply other) : this() {
    ok_ = other.ok_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public BcastMsgReply Clone() {
    return new BcastMsgReply(this);
  }

  /// <summary>Field number for the "ok" field.</summary>
  public const int OkFieldNumber = 1;
  private bool ok_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Ok {
    get { return ok_; }
    set {
      ok_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as BcastMsgReply);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(BcastMsgReply other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Ok != other.Ok) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Ok != false) hash ^= Ok.GetHashCode();
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
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (Ok != false) {
      output.WriteRawTag(8);
      output.WriteBool(Ok);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Ok != false) {
      output.WriteRawTag(8);
      output.WriteBool(Ok);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Ok != false) {
      size += 1 + 1;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(BcastMsgReply other) {
    if (other == null) {
      return;
    }
    if (other.Ok != false) {
      Ok = other.Ok;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          Ok = input.ReadBool();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 8: {
          Ok = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
