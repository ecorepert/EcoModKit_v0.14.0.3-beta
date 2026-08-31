// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.EnvVars.EnvVarAttribute
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;

#nullable disable
namespace Eco.Gameplay.Systems.EnvVars;

/// <summary>Put this on a property or method taking a User, which returns any serializable value.
/// EnvVars (Environment Variables) are for high-voltaile, fast-update properties that are needed, like interaction tests.
/// They are queried on demand, cached on the client, and the server notifies the client when the cache is invalidated
/// (but unlike with Views, does not send an updated value, it waits till the next query).</summary>
public class EnvVarAttribute : NotifyAttribute
{
}
