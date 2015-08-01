/*
 * Создано в SharpDevelop.
 * Пользователь: V.Seminchenko
 * Дата: 15.06.2015
 * Время: 14:44
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace AboHelper
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.panelSearsh.SuspendLayout();
			if (panelSearsh.Size.Height == 58) {
				panelSearsh.Size = new Size(panelSearsh.Size.Width, 600);
			}else{
				panelSearsh.Size = new Size(panelSearsh.Size.Width, 58);
			}
			this.panelSearsh.ResumeLayout();
		}
		void MainFormClick(object sender, EventArgs e)
		{
	
		}
		
			
		void TextBox1Click(object sender, EventArgs e)
		{
			this.textBox1.Text = "";
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			this.label1.Text = Convert.ToString((int)this.textBox1.Text.Length);
		}
		void TileView3line1Click(object sender, EventArgs e)
		{
			this.panelSearsh.SuspendLayout();
			if (panelSearsh.Size.Height == 58) {
				panelSearsh.Size = new Size(panelSearsh.Size.Width, 600);
			}else{
				panelSearsh.Size = new Size(panelSearsh.Size.Width, 58);
			}
			this.panelSearsh.ResumeLayout();
		}

	}
}
