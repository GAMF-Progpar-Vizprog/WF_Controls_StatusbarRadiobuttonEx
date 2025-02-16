using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatusbarRadiobuttonEx
{
  
  public enum PanelIndices
  {
    Second = 1,
    Third,
    Fourth,
  }
  
  public partial class frmMain : Form
  {
    PanelIndices PanelIndex;
    public frmMain()
    {
      InitializeComponent();
      PanelIndex = PanelIndices.Second;
      rbSecond.Checked = true;
      tmClock.Start();
    }
    private void btAssign_Click(object sender, EventArgs e)
    {
      ssStatusbar.Items[(int)PanelIndex].Text =
        tbText.Text;
    }

    private void frmMain_FormClosing(object sender,
      FormClosingEventArgs e)
    {
      tmClock.Stop();
      e.Cancel = false;
    }

    
    private void rb_CheckedChanged(object sender, EventArgs e)
    {
			if (sender == rbSecond)
				PanelIndex = PanelIndices.Second;
			else
				if (sender == rbThird)
				  PanelIndex = PanelIndices.Third;
			  else
					if (sender == rbFourth)
				    PanelIndex = PanelIndices.Fourth;
		}


    private void tmClock_Tick(object sender, EventArgs e)
    {
      DateTime Dt = DateTime.Now;
      string myText = Dt.Hour.ToString("00") + ":" +
        Dt.Minute.ToString("00") + ":" +
        Dt.Second.ToString("00");
      tssFirst.Text = myText;
    }
  }

}
