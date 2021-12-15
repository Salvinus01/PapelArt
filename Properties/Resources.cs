// Decompiled with JetBrains decompiler
// Type: Papelart.Properties.Resources
// Assembly: Papelart, Version=1.0.3467.33760, Culture=neutral, PublicKeyToken=null
// MVID: 8C1EFF8C-5818-42A0-93BB-D7C5094074EF
// Assembly location: D:\Gimenez & Gimenez\Projetos\Papel Arte\Papelart.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Papelart.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
  [CompilerGenerated]
  [DebuggerNonUserCode]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) Papelart.Properties.Resources.resourceMan, (object) null))
          Papelart.Properties.Resources.resourceMan = new ResourceManager("Papelart.Properties.Resources", typeof (Papelart.Properties.Resources).Assembly);
        return Papelart.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => Papelart.Properties.Resources.resourceCulture;
      set => Papelart.Properties.Resources.resourceCulture = value;
    }
  }
}
