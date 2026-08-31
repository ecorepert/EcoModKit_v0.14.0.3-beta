// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Debugging.CollectionDebugView
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Collections;
using System.Diagnostics;

#nullable disable
namespace Eco.Core.Utils.Debugging;

/// <summary>Allows viewing custom lists better in debugger.  See https://www.codeproject.com/Articles/28405/Make-the-debugger-show-the-contents-of-your-custom</summary>
[DebuggerDisplay("Count = {Count}")]
public class CollectionDebugView
{
  public CollectionDebugView(ICollection collection);

  [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
  public object[] Items { get; }
}
