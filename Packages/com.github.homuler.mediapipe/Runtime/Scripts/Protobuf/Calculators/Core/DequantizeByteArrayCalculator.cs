// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mediapipe/calculators/core/dequantize_byte_array_calculator.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mediapipe {

  /// <summary>Holder for reflection information generated from mediapipe/calculators/core/dequantize_byte_array_calculator.proto</summary>
  public static partial class DequantizeByteArrayCalculatorReflection {

    #region Descriptor
    /// <summary>File descriptor for mediapipe/calculators/core/dequantize_byte_array_calculator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DequantizeByteArrayCalculatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkFtZWRpYXBpcGUvY2FsY3VsYXRvcnMvY29yZS9kZXF1YW50aXplX2J5dGVf",
            "YXJyYXlfY2FsY3VsYXRvci5wcm90bxIJbWVkaWFwaXBlGiRtZWRpYXBpcGUv",
            "ZnJhbWV3b3JrL2NhbGN1bGF0b3IucHJvdG8iwAEKJERlcXVhbnRpemVCeXRl",
            "QXJyYXlDYWxjdWxhdG9yT3B0aW9ucxIbChNtYXhfcXVhbnRpemVkX3ZhbHVl",
            "GAEgASgCEhsKE21pbl9xdWFudGl6ZWRfdmFsdWUYAiABKAIyXgoDZXh0Ehwu",
            "bWVkaWFwaXBlLkNhbGN1bGF0b3JPcHRpb25zGLfv7IEBIAEoCzIvLm1lZGlh",
            "cGlwZS5EZXF1YW50aXplQnl0ZUFycmF5Q2FsY3VsYXRvck9wdGlvbnNCDKIC",
            "CU1lZGlhUGlwZQ=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Mediapipe.CalculatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mediapipe.DequantizeByteArrayCalculatorOptions), global::Mediapipe.DequantizeByteArrayCalculatorOptions.Parser, new[]{ "MaxQuantizedValue", "MinQuantizedValue" }, null, null, new pb::Extension[] { global::Mediapipe.DequantizeByteArrayCalculatorOptions.Extensions.Ext }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DequantizeByteArrayCalculatorOptions : pb::IMessage<DequantizeByteArrayCalculatorOptions>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DequantizeByteArrayCalculatorOptions> _parser = new pb::MessageParser<DequantizeByteArrayCalculatorOptions>(() => new DequantizeByteArrayCalculatorOptions());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DequantizeByteArrayCalculatorOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mediapipe.DequantizeByteArrayCalculatorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DequantizeByteArrayCalculatorOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DequantizeByteArrayCalculatorOptions(DequantizeByteArrayCalculatorOptions other) : this() {
      _hasBits0 = other._hasBits0;
      maxQuantizedValue_ = other.maxQuantizedValue_;
      minQuantizedValue_ = other.minQuantizedValue_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DequantizeByteArrayCalculatorOptions Clone() {
      return new DequantizeByteArrayCalculatorOptions(this);
    }

    /// <summary>Field number for the "max_quantized_value" field.</summary>
    public const int MaxQuantizedValueFieldNumber = 1;
    private readonly static float MaxQuantizedValueDefaultValue = 0F;

    private float maxQuantizedValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float MaxQuantizedValue {
      get { if ((_hasBits0 & 1) != 0) { return maxQuantizedValue_; } else { return MaxQuantizedValueDefaultValue; } }
      set {
        _hasBits0 |= 1;
        maxQuantizedValue_ = value;
      }
    }
    /// <summary>Gets whether the "max_quantized_value" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasMaxQuantizedValue {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "max_quantized_value" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearMaxQuantizedValue() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "min_quantized_value" field.</summary>
    public const int MinQuantizedValueFieldNumber = 2;
    private readonly static float MinQuantizedValueDefaultValue = 0F;

    private float minQuantizedValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float MinQuantizedValue {
      get { if ((_hasBits0 & 2) != 0) { return minQuantizedValue_; } else { return MinQuantizedValueDefaultValue; } }
      set {
        _hasBits0 |= 2;
        minQuantizedValue_ = value;
      }
    }
    /// <summary>Gets whether the "min_quantized_value" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasMinQuantizedValue {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "min_quantized_value" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearMinQuantizedValue() {
      _hasBits0 &= ~2;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DequantizeByteArrayCalculatorOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DequantizeByteArrayCalculatorOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MaxQuantizedValue, other.MaxQuantizedValue)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MinQuantizedValue, other.MinQuantizedValue)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasMaxQuantizedValue) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxQuantizedValue);
      if (HasMinQuantizedValue) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MinQuantizedValue);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (HasMaxQuantizedValue) {
        output.WriteRawTag(13);
        output.WriteFloat(MaxQuantizedValue);
      }
      if (HasMinQuantizedValue) {
        output.WriteRawTag(21);
        output.WriteFloat(MinQuantizedValue);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasMaxQuantizedValue) {
        output.WriteRawTag(13);
        output.WriteFloat(MaxQuantizedValue);
      }
      if (HasMinQuantizedValue) {
        output.WriteRawTag(21);
        output.WriteFloat(MinQuantizedValue);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasMaxQuantizedValue) {
        size += 1 + 4;
      }
      if (HasMinQuantizedValue) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DequantizeByteArrayCalculatorOptions other) {
      if (other == null) {
        return;
      }
      if (other.HasMaxQuantizedValue) {
        MaxQuantizedValue = other.MaxQuantizedValue;
      }
      if (other.HasMinQuantizedValue) {
        MinQuantizedValue = other.MinQuantizedValue;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
          case 13: {
            MaxQuantizedValue = input.ReadFloat();
            break;
          }
          case 21: {
            MinQuantizedValue = input.ReadFloat();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 13: {
            MaxQuantizedValue = input.ReadFloat();
            break;
          }
          case 21: {
            MinQuantizedValue = input.ReadFloat();
            break;
          }
        }
      }
    }
    #endif

    #region Extensions
    /// <summary>Container for extensions for other messages declared in the DequantizeByteArrayCalculatorOptions message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Extensions {
      public static readonly pb::Extension<global::Mediapipe.CalculatorOptions, global::Mediapipe.DequantizeByteArrayCalculatorOptions> Ext =
        new pb::Extension<global::Mediapipe.CalculatorOptions, global::Mediapipe.DequantizeByteArrayCalculatorOptions>(272316343, pb::FieldCodec.ForMessage(2178530746, global::Mediapipe.DequantizeByteArrayCalculatorOptions.Parser));
    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
