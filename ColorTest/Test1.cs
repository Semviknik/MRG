/*
 * Создано в SharpDevelop.
 * Пользователь: Total
 * Дата: 01.07.2015
 * Время: 21:49
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using NUnit.Framework;

namespace ColorTest
{
	[TestFixture]
	public class Test1
	{
		[Test]
		public void TestMethod()
		{
			// TODO: Add your test.
			System.Drawing.Color color = ColorUtils.LabToRgb(90,10
			                                         ,10);
			
		}
	}
}
