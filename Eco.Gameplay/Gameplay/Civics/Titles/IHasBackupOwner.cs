// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Titles.IHasBackupOwner
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Aliases;

#nullable disable
namespace Eco.Gameplay.Civics.Titles;

/// <summary> When an element with this interface is removed, all of its property goes to this deputy. </summary>
public interface IHasBackupOwner
{
  IAlias BackupOwner { get; set; }
}
