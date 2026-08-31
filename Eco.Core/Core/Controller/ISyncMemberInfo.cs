// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.ISyncMemberInfo
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.View;

#nullable enable
namespace Eco.Core.Controller;

/// <summary>Interface for <see cref="T:Eco.Core.Controller.SyncToViewAttribute" /> members info. Used by <see cref="T:Eco.Core.Controller.ControllerManager" /> for serialization.</summary>
public interface ISyncMemberInfo
{
  string Name { get; }

  int ID { get; }

  SyncFlags Flags { get; }

  object? GetValue(IMvcNetClient? client, object obj);

  /// <summary> Set to true if its a method that accepts the player, meaning a different result for each player </summary>
  bool PerPlayerMember { get; }

  /// <summary>True if <see cref="M:Eco.Core.Controller.ISyncMemberInfo.GetValue(Eco.Core.Controller.IMvcNetClient,System.Object)" /> needs a client with an observer (i.e. a method taking the player), so it may not be invoked without one.</summary>
  bool RequiresObserver { get; }
}
