// Decompiled with JetBrains decompiler
// Type: Papelart.frmPapelarte
// Assembly: Papelart, Version=1.0.3467.33760, Culture=neutral, PublicKeyToken=null
// MVID: 8C1EFF8C-5818-42A0-93BB-D7C5094074EF
// Assembly location: D:\Gimenez & Gimenez\Projetos\Papel Arte\Papelart.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Papelart
{
  public class frmPapelarte : Form
  {
    private Label label1;
    private IContainer components;

    public frmPapelarte() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPapelarte));
      this.label1 = new Label();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.BackColor = Color.Transparent;
      this.label1.Font = new Font("Monotype Corsiva", 26.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.Snow;
      this.label1.Location = new Point(22, 27);
      this.label1.Name = "label1";
      this.label1.Size = new Size(510, 43);
      this.label1.TabIndex = 0;
      this.label1.Text = "Carregando Novo Papel de Parede !!!";
      this.AutoScaleBaseSize = new Size(5, 13);
      this.BackgroundImage = (Image) componentResourceManager.GetObject("$this.BackgroundImage");
      this.ClientSize = new Size(555, 182);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmPapelarte);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "   Papel Arte";
      this.TopMost = true;
      this.UseWaitCursor = true;
      this.Load += new EventHandler(this.frmPapelarte_Load);
      this.FormClosing += new FormClosingEventHandler(this.frmPapelarte_FormClosing);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    [STAThread]
    private static void Main() => Application.Run((Form) new frmPapelarte());

    private void AlterarWP()
    {
      try
      {
        string path1 = Application.StartupPath + "\\Imagens";
        string path2 = path1 + "\\Atual";
        List<string> stringList = new List<string>();
        stringList.AddRange((IEnumerable<string>) Directory.GetFiles(path1, "*.jpg", SearchOption.TopDirectoryOnly));
        stringList.AddRange((IEnumerable<string>) Directory.GetFiles(path1, "*.bmp", SearchOption.TopDirectoryOnly));
        stringList.AddRange((IEnumerable<string>) Directory.GetFiles(path1, "*.png", SearchOption.TopDirectoryOnly));
        stringList.AddRange((IEnumerable<string>) Directory.GetFiles(path1, "*.gif", SearchOption.TopDirectoryOnly));
        string[] array = stringList.ToArray();
        if (array == null || array.Length == 0)
          return;
        int index = new Random((int) DateTime.Now.Ticks).Next(0, array.Length);
        Bitmap bitmap = new Bitmap(array[index]);
        if (!Directory.Exists(path2))
          Directory.CreateDirectory(path2);
        bitmap.Save(path2 + "\\wp.bmp", ImageFormat.Bmp);
        new PapelParede().SetWallpaper(path2 + "\\wp.bmp", PapelParede.Style.Stretched);
      }
      catch
      {
      }
    }

    private void frmPapelarte_Load(object sender, EventArgs e)
    {
      this.AlterarWP();
      Application.Exit();
    }

    private void frmPapelarte_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.Show();
      this.Refresh();
      Thread.Sleep(2000);
    }
  }
}
