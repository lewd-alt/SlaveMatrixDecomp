using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2DGAMELIB;

public class Lab
{
	private ParT parT;

	private Med Med;

	private Are Are;

	private double Width;

	private bool Input;

	private double Min;

	private TextBox tb;

	public ParT ParT => parT;

	public string Text
	{
		get
		{
			return parT.Text;
		}
		set
		{
			if (!Med.BaseControl.Contains(tb))
			{
				SetText(value);
			}
		}
	}

	private void SetText(string Text)
	{
		parT.Text = Text;
		SetRect();
	}

	public Lab(Med Med, Are Are, string Name, ref Vector2D Position, double Size, double Width, Font Font, double TextSize, string Text, ref Color TextColor, ref Color ShadColor, ref Color BackColor, ref Color FramColor, bool Input)
	{
		Setting(Med, Are, Name, ref Position, Size, Width, Font, TextSize, Text, ref TextColor, ref ShadColor, ref BackColor, ref FramColor, Input);
	}

	public Lab(Med Med, Are Are, string Name, Vector2D Position, double Size, double Width, Font Font, double TextSize, string Text, Color TextColor, Color ShadColor, Color BackColor, Color FramColor, bool Input)
	{
		Setting(Med, Are, Name, ref Position, Size, Width, Font, TextSize, Text, ref TextColor, ref ShadColor, ref BackColor, ref FramColor, Input);
	}

	private void Setting(Med Med, Are Are, string Name, ref Vector2D Position, double Size, double Width, Font Font, double TextSize, string Text, ref Color TextColor, ref Color ShadColor, ref Color BackColor, ref Color FramColor, bool Input)
	{
		this.Med = Med;
		this.Are = Are;
		this.Width = Width;
		this.Input = Input;
		if (Input)
		{
			tb = new TextBox();
			tb.WordWrap = true;
			tb.Multiline = true;
			tb.Text = Text;
			tb.ForeColor = TextColor;
			tb.BackColor = Color.FromArgb(255, BackColor);
			tb.KeyUp += delegate
			{
				lock (Med.obj)
				{
					SetText(tb.Text);
					parT.Text = "";
					SetRectT();
				}
			};
			tb.KeyDown += delegate(object s, KeyEventArgs e)
			{
				lock (Med.obj)
				{
					if (e.KeyCode == Keys.Return)
					{
						this.Med.BaseControl.Controls.Remove(tb);
						SetText(tb.Text);
						e.SuppressKeyPress = true;
					}
				}
			};
			tb.PreviewKeyDown += delegate(object s, PreviewKeyDownEventArgs e)
			{
				e.IsInputKey = true;
			};
			Med.BaseControl.Controls.Add(tb);
			Med.BaseControl.Controls.Remove(tb);
			((Control)Med.BaseControl).Resize += Lab_Resize;
		}
		Out[] array = new Out[1] { Shas.Get正方形() };
		if (FramColor == Color.Empty || FramColor == Color.Transparent)
		{
			array.OutlineFalse();
		}
		parT = new ParT
		{
			Tag = Name,
			InitializeOP = array,
			BasePointBase = array[0].ps[0],
			PositionBase = Position,
			SizeBase = Size,
			Closed = true,
			BrushColor = BackColor,
			PenColor = FramColor,
			Font = Font,
			FontSize = TextSize,
			TextColor = TextColor,
			Text = "A"
		};
		if (ShadColor != Color.Empty)
		{
			parT.ShadBrush = new SolidBrush(ShadColor);
		}
		SetRect();
		Min = parT.RectSize.Y;
		SetText(Text);
	}

	private void Lab_Resize(object sender, EventArgs e)
	{
		Med.BaseControl.Controls.Remove(tb);
		SetText(tb.Text);
	}

	public void SetHitColor(Med Med)
	{
		if (parT.HitColor != Color.Transparent)
		{
			Med.RemUniqueColor(parT.HitColor);
		}
		parT.HitColor = Med.GetUniqueColor();
	}

	private void SetRect()
	{
		if (!string.IsNullOrEmpty(parT.Text))
		{
			parT.RectSize = new Vector2D(Width, 10.0);
			Vector2D_2 stringRect = parT.GetStringRect(Are.DisUnit, Are.GD);
			double x = ((stringRect.v2.X > Min) ? stringRect.v2.X : Min) + 0.07;
			parT.RectSize = new Vector2D(x, stringRect.v2.Y);
		}
		else
		{
			double x2 = Min + 0.07;
			parT.RectSize = new Vector2D(x2, Min);
		}
		parT.OP[0].ps[0] = new Vector2D(0.0, 0.0);
		parT.OP[0].ps[1] = new Vector2D(parT.RectSize.X, 0.0);
		parT.OP[0].ps[2] = new Vector2D(parT.RectSize.X, parT.RectSize.Y);
		parT.OP[0].ps[3] = new Vector2D(0.0, parT.RectSize.Y);
	}

	private void SetRectT()
	{
		double resMag = Med.ResMag;
		Vector2D vector2D = (parT.Position + Are.GetPosition()) * Med.Unit / resMag + Med.ResVector;
		tb.Location = new Point((int)vector2D.X - 1, (int)vector2D.Y - 1);
		double num = parT.Size * Med.Unit;
		if (tb.Font != null)
		{
			tb.Font.Dispose();
		}
		tb.Font = new Font(parT.Font.FontFamily, (float)(parT.FontSize * num / resMag));
		Vector2D vector2D2 = parT.RectSize * num / resMag;
		tb.Size = new Size((int)(vector2D2.X + 2.0), (int)(vector2D2.Y + 10.0));
	}

	public bool Double(ref Color HitColor)
	{
		if (Input && parT.HitColor == HitColor && !Med.BaseControl.Controls.Contains(tb))
		{
			tb.Text = parT.Text;
			parT.Text = "";
			SetRectT();
			Med.BaseControl.Controls.Add(tb);
			tb.SelectAll();
			tb.Focus();
			tb.BringToFront();
			return true;
		}
		return false;
	}

	public void Click(ref Color HitColor)
	{
		if (Input && parT.HitColor != HitColor && Med.BaseControl.Controls.Contains(tb))
		{
			Med.BaseControl.Controls.Remove(tb);
			SetText(tb.Text);
		}
	}

	public void Dispose()
	{
		parT.Dispose();
		if (Input)
		{
			((Control)Med.BaseControl).Resize -= Lab_Resize;
		}
		if (tb != null)
		{
			tb.Dispose();
		}
	}
}
