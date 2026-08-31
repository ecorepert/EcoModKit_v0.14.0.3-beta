// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Time.SkyOp
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Time;

/// <summary>A purely visual change to how the sky is drawn. Shared by /time (every player) and /mytime (one player).</summary>
public enum SkyOp
{
  SetHour,
  Freeze,
  Resume,
  Reset,
}
