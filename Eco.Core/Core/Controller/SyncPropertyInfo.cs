// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.SyncPropertyInfo
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Reflection;

#nullable enable
namespace Eco.Core.Controller;

/// <summary>Builds info about a given property that is marked SyncToView, and synced between the server an client.</summary>
internal class SyncPropertyInfo : SyncMemberInfoBase
{
  public SyncPropertyInfo(PropertyInfo propertyInfo, int id, string name);

  public override bool PerPlayerMember { get; }

  public override object? GetValue(IMvcNetClient? client, object obj);
}
