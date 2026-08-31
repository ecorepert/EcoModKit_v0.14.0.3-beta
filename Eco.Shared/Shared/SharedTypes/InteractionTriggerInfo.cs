// Decompiled with JetBrains decompiler
// Type: Eco.Shared.SharedTypes.InteractionTriggerInfo
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.SharedTypes;

/// <summary> Wrapper struct for a Trigger (LMB/RMB/Interact) + a Modifier (Ctrl/Alt/Shift). </summary>
/// <remarks> Used to define the input needed to trigger an interaction. </remarks>
public struct InteractionTriggerInfo
{
  public InteractionTrigger Trigger;
  public InteractionModifier Modifier;

  public InteractionTriggerInfo(InteractionTrigger trigger, InteractionModifier modifier);

  public InteractionTriggerInfo(InteractionTrigger trigger);

  /// <summary>Interactions with more resrictions are high priority. Count the modifiers and that's our priority.</summary>
  public int GetPriority();

  public static bool operator ==(InteractionTriggerInfo left, InteractionTriggerInfo right);

  public static bool operator !=(InteractionTriggerInfo left, InteractionTriggerInfo right);

  public static bool operator ==(InteractionTriggerInfo info, InteractionTrigger trigger);

  public static bool operator !=(InteractionTriggerInfo info, InteractionTrigger trigger);

  public override bool Equals(object obj);

  public override int GetHashCode();

  public override string ToString();

  public static implicit operator InteractionTriggerInfo(InteractionTrigger trigger);

  public static implicit operator InteractionTriggerInfo(
    (InteractionTrigger Trigger, InteractionModifier Modifier) tuple);

  public static implicit operator (InteractionTrigger Trigger, InteractionModifier Modifier)(
    InteractionTriggerInfo info);
}
