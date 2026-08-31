// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.IEcopediaEntry
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary> Interface for <see cref="T:Eco.Core.Systems.IRegistrar" /> entries which may be shown in Ecopedia. </summary>
public interface IEcopediaEntry
{
  /// <summary> Returns if this entry should be displayed in Ecopedia. </summary>
  bool IsVisibleInEcopedia { get; }
}
