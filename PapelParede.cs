// Decompiled with JetBrains decompiler
// Type: Papelart.PapelParede
// Assembly: Papelart, Version=1.0.3467.33760, Culture=neutral, PublicKeyToken=null
// MVID: 8C1EFF8C-5818-42A0-93BB-D7C5094074EF
// Assembly location: D:\Gimenez & Gimenez\Projetos\Papel Arte\Papelart.exe

using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace Papelart
{
  public class PapelParede
  {
    private const int SPI_SETDESKWALLPAPER = 20;
    private const int SPIF_UPDATEINIFILE = 1;
    private const int SPIF_SENDWININICHANGE = 2;

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern int SystemParametersInfo(
      int uAction,
      int uParam,
      string lpvParam,
      int fuWinIni);

    public void SetWallpaper(string path, PapelParede.Style style)
    {
      RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
      switch (style)
      {
        case PapelParede.Style.Tiled:
          registryKey.SetValue("WallpaperStyle", (object) "1");
          registryKey.SetValue("TileWallpaper", (object) "1");
          break;
        case PapelParede.Style.Centered:
          registryKey.SetValue("WallpaperStyle", (object) "1");
          registryKey.SetValue("TileWallpaper", (object) "0");
          break;
        case PapelParede.Style.Stretched:
          registryKey.SetValue("WallpaperStyle", (object) "2");
          registryKey.SetValue("TileWallpaper", (object) "0");
          break;
      }
      PapelParede.SystemParametersInfo(20, 0, path, 3);
    }

    public enum Style
    {
      Tiled,
      Centered,
      Stretched,
    }
  }
}
