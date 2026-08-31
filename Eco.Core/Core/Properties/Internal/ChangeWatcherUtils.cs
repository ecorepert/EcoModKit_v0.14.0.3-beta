// Decompiled with JetBrains decompiler
// Type: Eco.Core.Properties.Internal.ChangeWatcherUtils
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.ComponentModel;
using System.Reflection;

#nullable enable
namespace Eco.Core.Properties.Internal;

public static class ChangeWatcherUtils
{
  public static BindingFlags Binding;

  /// <summary>See if a given property name on this type will be getting updates from fody</summary>
  public static bool IsPropFodyNotifiable(this INotifyPropertyChanged propChanged, string name);
}
