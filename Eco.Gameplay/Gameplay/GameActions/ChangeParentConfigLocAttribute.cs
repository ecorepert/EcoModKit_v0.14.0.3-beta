// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.ChangeParentConfigLocAttribute
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;

#nullable disable
namespace Eco.Gameplay.GameActions;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class ChangeParentConfigLocAttribute : Attribute
{
  public string PropName;
  public string NewName;
  public string RestrictToTag;
  public Type RestrictToType;
  public bool Hide;

  public ChangeParentConfigLocAttribute(
    string oldName,
    string newName = null,
    string tag = null,
    Type type = null,
    bool hide = false);
}
