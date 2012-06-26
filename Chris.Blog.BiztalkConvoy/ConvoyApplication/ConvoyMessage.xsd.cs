namespace ConvoyApplication {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://ConvoyApplication.ConvoyMessage",@"ConvoyMessage")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::ConvoyApplication.InstanceId), XPath = @"/*[local-name()='ConvoyMessage' and namespace-uri()='http://ConvoyApplication.ConvoyMessage']/*[local-name()='InstanceId' and namespace-uri()='']", XsdType = @"int")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "InstanceId", XPath = @"/*[local-name()='ConvoyMessage' and namespace-uri()='http://ConvoyApplication.ConvoyMessage']/*[local-name()='InstanceId' and namespace-uri()='']", XsdType = @"int")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "MessageText", XPath = @"/*[local-name()='ConvoyMessage' and namespace-uri()='http://ConvoyApplication.ConvoyMessage']/*[local-name()='MessageText' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ConvoyMessage"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ConvoyApplication.ConvoyMessageProperties", typeof(global::ConvoyApplication.ConvoyMessageProperties))]
    public sealed class ConvoyMessage : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://ConvoyApplication.ConvoyMessage"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://ConvoyApplication.ConvoyMessageProperties"" targetNamespace=""http://ConvoyApplication.ConvoyMessage"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://ConvoyApplication.ConvoyMessageProperties"" location=""ConvoyApplication.ConvoyMessageProperties"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""ConvoyMessage"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:InstanceId"" xpath=""/*[local-name()='ConvoyMessage' and namespace-uri()='http://ConvoyApplication.ConvoyMessage']/*[local-name()='InstanceId' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ConvoyMessage' and namespace-uri()='http://ConvoyApplication.ConvoyMessage']/*[local-name()='InstanceId' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ConvoyMessage' and namespace-uri()='http://ConvoyApplication.ConvoyMessage']/*[local-name()='MessageText' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""InstanceId"" type=""xs:int"" />
        <xs:element name=""MessageText"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ConvoyMessage() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ConvoyMessage";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
