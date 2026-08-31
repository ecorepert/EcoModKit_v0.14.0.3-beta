// Decompiled with JetBrains decompiler
// Type: StrangeCloud.Service.Client.Contracts.FileParameter
// Assembly: StrangeCloud.Service.Client.CSharp, Version=1.0.25.0, Culture=neutral, PublicKeyToken=null
// MVID: AAA52893-526A-4E25-B2C8-518262E68155
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.xml

using System.CodeDom.Compiler;
using System.IO;

#nullable disable
namespace StrangeCloud.Service.Client.Contracts;

[GeneratedCode("NSwag", "14.0.8.0 (NJsonSchema v11.0.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class FileParameter
{
  public FileParameter(Stream data)
    : this(data, (string) null, (string) null)
  {
  }

  public FileParameter(Stream data, string fileName)
    : this(data, fileName, (string) null)
  {
  }

  public FileParameter(Stream data, string fileName, string contentType)
  {
    this.Data = data;
    this.FileName = fileName;
    this.ContentType = contentType;
  }

  public Stream Data { get; private set; }

  public string FileName { get; private set; }

  public string ContentType { get; private set; }
}
