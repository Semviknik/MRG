/*
 * Создано в SharpDevelop.
 * Пользователь: V.Seminchenko
 * Дата: 22.06.2015
 * Время: 11:24
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */

using Glade;
using Gtk;
using System;

namespace Glade
{
	/// <summary>
	/// Description of MainWindow.
	/// </summary>
	public class MainWindow
	{
		public MainWindow()
		{
			Glade.XML gxml = new Glade.XML(null, "glade.xml", "MainWindow", null);
			gxml.Autoconnect(this);
		}
		
		[STAThread]
		public static void Main(string[] args)
		{
			Application.Init();
			new MainWindow();
			Application.Run();
		}

		void MainWindowDeleteEvent(object o, DeleteEventArgs args) 
		{
			Application.Quit();
			args.RetVal = true;
		}
	}
}