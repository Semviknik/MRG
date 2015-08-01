/*
 * Создано в SharpDevelop.
 * Пользователь: V.Seminchenko
 * Дата: 22.06.2015
 * Время: 12:48
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Windows.Forms.Design;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace AboHelper
{
	/// <summary>
	/// Description of TileView3line.
	/// </summary>
	

	public partial class TileView3line : UserControl{
		
		[Category("Appearance")]
		public String Title
		{
			get{return this.labelTitle.Text;}
			set{this.labelTitle.Text = value;}
		}
		
		[Category("Appearance")]
		public String FirstInfo
		{
			get{return this.labelFirstInfo.Text;}
			set{this.labelFirstInfo.Text = value;}
		}
		
		[Category("Appearance")]
		public String SecondInfo
		{
			get{return this.labelSecondInfo.Text;}
			set{this.labelSecondInfo.Text = value;}
		}
		
		
		[Category("Appearance")]
		public Color ColorInfo
		{
			get{return this.labelFirstInfo.ForeColor;}
			set{this.labelFirstInfo.ForeColor = value;
			this.labelSecondInfo.ForeColor = value;}
		}
		
		[Category("Appearance")]
		public Color ColorTitle
		{
			get{return this.labelTitle.ForeColor;}
			set{this.labelTitle.ForeColor = value;}
		}
		
		[Category("Appearance")]
		public Color ColorBackgraund
		{
			get{return this.tableLayoutPanel4.BackColor;}
			set{this.tableLayoutPanel4.BackColor = value;}
		}
		
	
		public TileView3line(){
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		

		void LabelTitleClick(object sender, EventArgs e)
		{
			this.OnClick(e);
		}
		void LabelFirstInfoMouseEnter(object sender, EventArgs e)
		{
			this.oldBgColor = this.ColorBackgraund;
			this.ColorBackgraund = System.Drawing.Color.FromArgb(oldBgColor.A,(int)((float)(oldBgColor.R*0.8)),(int)((float)(oldBgColor.G*0.8)),(int)((float)(oldBgColor.B*0.8)));
			this.OnMouseEnter(e);
		}
		void LabelFirstInfoMouseLeave(object sender, EventArgs e)
		{
			this.ColorBackgraund = oldBgColor;
			this.OnMouseLeave(e);
		}

	}
}
