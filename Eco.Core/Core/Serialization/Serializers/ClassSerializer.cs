// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.ClassSerializer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Systems;
using System;
using System.Collections.Concurrent;
using System.IO;
using System.Reflection;

#nullable enable
namespace Eco.Core.Serialization.Serializers;

public abstract class ClassSerializer : ObjectSerializer
{
  public static 
  #nullable disable
  ConcurrentQueue<Action> PostLoadMethods;
  public static ConcurrentQueue<IHasUniversalID> LoadedObjectsWithIDS;
  protected const BindingFlags SerializationBindings = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
  protected MethodInfo[] onDeserializeMethods;
  protected MethodInfo[] onPostLoadMethods;

  protected MemberInfo[] Members { get; set; }

  public abstract object NewInstance { get; }

  protected ClassSerializer(SimpleSerializer parent, Type type, string schemaType);

  protected internal sealed override object DecodeInstance(BinaryReader reader);

  internal abstract void DecodeToInstance(ref object instance, BinaryReader reader);

  protected internal override void SkipInstance(BinaryReader reader);
}
