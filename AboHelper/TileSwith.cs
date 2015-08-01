/*
 * Создано в SharpDevelop.
 * Пользователь: V.Seminchenko
 * Дата: 03.07.2015
 * Время: 10:22
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AboHelper
{
	/// <summary>
	/// Description of TileSwith.
	/// </summary>
	public partial class TileSwith : UserControl
	{
		[Category("Appearance")]
		public String Title {
			get{ return this.lableTitle.Text; }
			set{ this.lableTitle.Text = value; }
		}
		
		
		[Category("Appearance")]
		public Color ColorTitle {
			get{ return this.lableTitle.ForeColor; }
			set{ this.lableTitle.ForeColor = value; }
		}
		
		[Category("Appearance")]
		public Color ColorBackgraund {
			get{ return this.tableLayoutPanel8.BackColor; }
			set{ this.tableLayoutPanel8.BackColor = value; }
		}
		
		[Category("Appearance")]
		public String TextOn {
			get{ return this.titleOn; }
			set {
				this.titleOn = value;
				InitSwith();
			}
		}
		
		[Category("Appearance")]
		public String TextOff {
			get{ return this.titleOff; }
			set {
				this.titleOff = value;
				InitSwith();
			}
		}
		
		[Category("Appearance")]
		public Color ColorOn {
			get{ return this.colorOn; }
			set {
				this.colorOn = value;
				InitSwith();
			}
		}
		
		[Category("Appearance")]
		public Color ColorOff {
			get{ return this.colorOff; }
			set {
				this.colorOff = value;
				InitSwith();
			}
		}
		
		[Category("Appearance")]
		public bool State {
			get{ return this.swithSatate; }
			set {
				this.swithSatate = value;
				InitSwith();
			}
		}
		
		public TileSwith()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			InitSwith();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		void Panel2Resize(object sender, EventArgs e)
		{
			this.buttonState.Size = new Size((int)(panelState.Size.Width/2), buttonState.Size.Height);
		}
		void Button2FontChanged(object sender, EventArgs e)
		{
			
		}
		void InitSwith(){
			if (swithSatate) {
				this.buttonState.Dock = DockStyle.Right;
				this.panelState.BackColor = colorOn;
				this.buttonState.Text = titleOn;
			}else{
				this.buttonState.Dock = DockStyle.Left;
				this.panelState.BackColor = colorOff;
				this.buttonState.Text = titleOff;
			}	
		}
		void ButtonStateFontChanged(object sender, EventArgs e)
		{
			
		}
		void TileSwithFontChanged(object sender, EventArgs e)
		{
			this.buttonState.Font = new Font(this.Font.FontFamily, (float)(this.Font.Size*0.5));
		}
		void ButtonStateClick(object sender, EventArgs e)
		{
			State = !(this.swithSatate);
		}
	}
}
