//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ReceiveChatMsg.proto
// Note: requires additional types generated from: ChatData.proto
namespace protocol
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReceiveChatSync")]
  public partial class ReceiveChatSync : global::ProtoBuf.IExtensible
  {
    public ReceiveChatSync() {}
    
    private readonly global::System.Collections.Generic.List<protocol.ChatItem> _chatData = new global::System.Collections.Generic.List<protocol.ChatItem>();
    [global::ProtoBuf.ProtoMember(1, Name=@"chatData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<protocol.ChatItem> chatData
    {
      get { return _chatData; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}