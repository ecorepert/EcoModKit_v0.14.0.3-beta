// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.MemberInfo
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable enable
namespace Eco.Core.Serialization.Serializers;

public class MemberInfo
{
  public Type? Type { get; init; }

  public string Name { get; init; }

  public ISerializer Serializer { get; set; }

  public MemberData Data { get; init; }

  public bool Skip { get; set; }

  public SerializeFlags Flags { get; init; }

  public override string ToString();
}
