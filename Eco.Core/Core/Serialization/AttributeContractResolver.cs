// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.AttributeContractResolver
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Reflection;

#nullable disable
namespace Eco.Core.Serialization;

internal class AttributeContractResolver : DefaultContractResolver
{
  public AttributeContractResolver(Type attributeType);

  protected override List<MemberInfo> GetSerializableMembers(Type objectType);

  protected override JsonProperty CreateProperty(
    MemberInfo member,
    MemberSerialization memberSerialization);
}
