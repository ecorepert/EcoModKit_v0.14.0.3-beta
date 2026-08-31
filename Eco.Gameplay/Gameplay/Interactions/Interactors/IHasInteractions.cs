// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Interactions.Interactors.IHasInteractions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Interactions.Interactors;

/// <summary> Identifier for types that can host methods with the <see cref="T:Eco.Gameplay.Interactions.Interactors.InteractionAttribute" />. </summary>
/// <remarks> We use heavy reflection in <see cref="M:Eco.Gameplay.Interactions.Interactors.ServerInteractionManager.Initialize" />, so we use this interface to reduce the scope of reflection to types that implement this.</remarks>
public interface IHasInteractions
{
}
