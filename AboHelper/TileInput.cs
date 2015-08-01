/*
 * Создано в SharpDevelop.
 * Пользователь: V.Seminchenko
 * Дата: 03.07.2015
 * Время: 8:24
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
	/// Description of TileInput.
	/// </summary>
	public partial class TileInput : UserControl
	{
		public TileInput()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		[Category("Appearance")]
		public String Title
		{
			get{return this.labelTitle.Text;}
			set{this.labelTitle.Text = value;}
		}
		
		[Category("Appearance")]
		public String Input
		{
			get{return this.textBox.Text;}
			set{this.textBox.Text = value;}
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
			get{return this.table.BackColor;}
			set{this.table.BackColor = value;}
		}
	}
}
