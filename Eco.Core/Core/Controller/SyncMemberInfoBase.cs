// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.SyncMemberInfoBase
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.View;
using System.Reflection;

#nullable enable
namespace Eco.Core.Controller;

/// <summary>Base class for <see cref="T:Eco.Core.Controller.ISyncMemberInfo" /> implementations with shared logic.</summary>
public abstract class SyncMemberInfoBase : ISyncMemberInfo
{
  public string Name { get; }

  public int ID { get; }

  public SyncFlags Flags { get; }

  public abstract bool PerPlayerMember { get; }

  public virtual bool RequiresObserver { get; }

  protected SyncMemberInfoBase(MemberInfo memberInfo, int id, string name);

  public abstract object? GetValue(IMvcNetClient? client, object obj);

  /// <summary>Returns <see cref="T:System.Reflection.MethodInfo" /> which may be used for getter generation. For generic type definitions it will try to use declaring type (base type or interface).</summary>
  /// <exception cref="T:System.ArgumentException">If this member may not be accessed via both reflected and declaring type.</exception>
  protected MethodInfo GetAccessMethodInfo(MethodInfo methodInfo);
}
