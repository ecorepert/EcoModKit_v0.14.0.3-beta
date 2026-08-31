// Decompiled with JetBrains decompiler
// Type: Eco.Core.Systems.UnserializedNamedEntry`1
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Core.Systems;

public abstract class UnserializedNamedEntry<T> : UnserializedNamedEntry where T : UnserializedNamedEntry<T>
{
  protected static Dictionary<string, T> nameToEntry;

  public override string Name { get; set; }

  public static T GetByName(string name);

  public static void Remove(string name);

  /// <summary> Clears all entries. It isn't thread-safe for same entity type, but thread safe with other <see cref="T:Eco.Core.Systems.UnserializedNamedEntry" />.</summary>
  public static void Clear();
}
