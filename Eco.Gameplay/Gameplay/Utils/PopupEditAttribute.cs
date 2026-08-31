// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.PopupEditAttribute
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;

#nullable disable
namespace Eco.Gameplay.Utils;

/// <summary>Tag properties with this to allow clients to call an 'EditProperty' RPC to open a popup that edits them.</summary>
[AttributeUsage(AttributeTargets.Property)]
public class PopupEditAttribute : Attribute
{
  public EditOptions Options;

  public PopupEditAttribute(EditOptions options = EditOptions.OwnerOnly);
}
