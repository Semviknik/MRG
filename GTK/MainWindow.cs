/*
 * Создано в SharpDevelop.
 * Пользователь: V.Seminchenko
 * Дата: 22.06.2015
 * Время: 11:25
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */

using Gtk;
using System;

namespace GTK
{
/// <summary>
/// Description of MainWindow.
/// </summary>
public class MainWindow : Window
{
	public MainWindow() : base("MainWindow")
	{
		DeleteEvent += new DeleteEventHandler(MainWindowDeleteEvent);
		ShowAll();
	}
	
	[STAThread]
	public static void Main(string[] arg)
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