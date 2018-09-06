/*
 * Created By 42476232
 * On 04/09/2018
 * Time: 10:11 a.m.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Program.Forms
{
  /// <summary>
  /// Description of FormGuests.
  /// </summary>
  public partial class FormGuests : Form
  {
    public FormGuests()
    {
      InitializeComponent();
    }
    
    void MaterialFlatButton1Click(object sender, EventArgs e)
    {
      materialFlatButton1.Text = "Clicked";
    }
    
    void MaterialLabel3Click(object sender, EventArgs e)
    {
      MaterialFlatButton1Click(sender, e);
    }
    
    void MaterialLabel3MouseEnter(object sender, EventArgs e)
    {
      materialFlatButton1.MouseEnter();
    }
  }
}
