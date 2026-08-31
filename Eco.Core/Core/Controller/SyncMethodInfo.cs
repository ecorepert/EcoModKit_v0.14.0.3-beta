// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.SyncMethodInfo
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Reflection;

#nullable enable
namespace Eco.Core.Controller;

/// <summary><see cref="T:Eco.Core.Controller.ISyncMemberInfo" /> for [SyncToView] methods.</summary>
public class SyncMethodInfo : SyncMemberInfoBase
{
  public override bool PerPlayerMember { get; }

  public override bool RequiresObserver { get; }

  public SyncMethodInfo(MethodInfo methodInfo, int id, string name);

  public override object? GetValue(IMvcNetClient? client, object obj);
}
