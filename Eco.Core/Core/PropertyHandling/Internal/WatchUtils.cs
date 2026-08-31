// Decompiled with JetBrains decompiler
// Type: Eco.Core.PropertyHandling.Internal.WatchUtils
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable enable
namespace Eco.Core.PropertyHandling.Internal;

/// <summary>Utils for watching properties on properties.</summary>
public static class WatchUtils
{
  /// <summary>Adds global subscriptions for all types inherited from INotifyPropertyChanged and having properties with WatchSubMemberAttribute.
  /// Accepts list of types to register (or all, if empty).</summary>
  public static void RegisterWatching(params Type[] types);

  private interface IDelegateEventParam
  {
    Delegate InvokeDelegate { get; }
  }

  private class DelegateEventParam<T> : WatchUtils.IDelegateEventParam
  {
    public DelegateEventParam(
      MemberChangedBeforeAfterEventArgs args,
      PropertyChangedBeforeAfterEventHandler callback,
      bool passEventFirstParamToCallback,
      Type rootType);

    public Delegate InvokeDelegate { get; }
  }
}
