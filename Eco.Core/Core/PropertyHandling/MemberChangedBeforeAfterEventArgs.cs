// Decompiled with JetBrains decompiler
// Type: Eco.Core.PropertyHandling.MemberChangedBeforeAfterEventArgs
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.ComponentModel;

#nullable enable
namespace Eco.Core.PropertyHandling;

/// <summary><see cref="T:System.ComponentModel.PropertyChangedEventArgs" /> extended with <see cref="F:Eco.Core.PropertyHandling.MemberChangedBeforeAfterEventArgs.Before" /> and <see cref="F:Eco.Core.PropertyHandling.MemberChangedBeforeAfterEventArgs.After" /> values. Both <see cref="F:Eco.Core.PropertyHandling.MemberChangedBeforeAfterEventArgs.Before" /> and <see cref="F:Eco.Core.PropertyHandling.MemberChangedBeforeAfterEventArgs.After" />
/// will be null if not available.  We rename from the root 'property' to 'member' because this is used for methods as well.</summary>
public class MemberChangedBeforeAfterEventArgs : PropertyChangedEventArgs
{
  public object? Before;
  public object? After;
  public bool PropagatedChange;

  /// <summary>Checks if <see cref="F:Eco.Core.PropertyHandling.MemberChangedBeforeAfterEventArgs.Before" /> and <see cref="F:Eco.Core.PropertyHandling.MemberChangedBeforeAfterEventArgs.After" /> values available.</summary>
  public bool HasBeforeAfter { get; }

  public MemberChangedBeforeAfterEventArgs(string? propertyName, object? before, object? after);
}
