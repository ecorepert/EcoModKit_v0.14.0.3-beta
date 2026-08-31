// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Schema.ClassSerializerSchemaBuilder
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Core.Serialization.Schema;

/// <summary>Custom serializer schema builder. Doesn't require existing type. Used for migration tests.</summary>
public class ClassSerializerSchemaBuilder
{
  public ClassSerializerSchemaBuilder(string typeOrSchemaType);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public ClassSerializerSchemaBuilder AddField(string fieldName, Type type);

  public ClassSerializerSchemaBuilder AddField(string fieldName, string schemaType);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public ClassSerializerSchemaBuilder AddField<T>(string fieldName);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public ClassSerializerSchemaBuilder AddStringField(string fieldName);

  public SerializerSchema Build();
}
