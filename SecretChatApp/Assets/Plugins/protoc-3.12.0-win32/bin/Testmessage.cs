// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: testmessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from testmessage.proto</summary>
public static partial class TestmessageReflection {

  #region Descriptor
  /// <summary>File descriptor for testmessage.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static TestmessageReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChF0ZXN0bWVzc2FnZS5wcm90byIfCgtUZXN0TWVzc2FnZRIQCghzb21lVGV4",
          "dBgBIAEoCWIGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::TestMessage), global::TestMessage.Parser, new[]{ "SomeText" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class TestMessage : pb::IMessage<TestMessage> {
  private static readonly pb::MessageParser<TestMessage> _parser = new pb::MessageParser<TestMessage>(() => new TestMessage());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<TestMessage> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::TestmessageReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TestMessage() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TestMessage(TestMessage other) : this() {
    someText_ = other.someText_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TestMessage Clone() {
    return new TestMessage(this);
  }

  /// <summary>Field number for the "someText" field.</summary>
  public const int SomeTextFieldNumber = 1;
  private string someText_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string SomeText {
    get { return someText_; }
    set {
      someText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as TestMessage);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(TestMessage other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (SomeText != other.SomeText) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (SomeText.Length != 0) hash ^= SomeText.GetHashCode();
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
    if (SomeText.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(SomeText);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (SomeText.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(SomeText);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(TestMessage other) {
    if (other == null) {
      return;
    }
    if (other.SomeText.Length != 0) {
      SomeText = other.SomeText;
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
          SomeText = input.ReadString();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
