namespace Dtat.Windows.Forms;

public class Button : System.Windows.Forms.Button
{
	public Button() : base()
	{
	}

	protected System.Drawing.Color CurrentBackColor { get; set; }

	protected override void OnMouseEnter(System.EventArgs e)
	{
		//base.OnMouseEnter(e);

		CurrentBackColor = BackColor;
		BackColor = System.Drawing.Color.Khaki;
	}

	protected override void OnMouseLeave(System.EventArgs e)
	{
		//base.OnMouseLeave(e);

		BackColor = CurrentBackColor;
	}
}
