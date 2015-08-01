/*
 * Создано в SharpDevelop.
 * Пользователь: V.Seminchenko
 * Дата: 06.07.2015
 * Время: 9:03
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Text;
using Total.Net;
using Total.Data.Serializations;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace DataClientApp
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public delegate void MessageDelegate(String st);
		public MessageDelegate putMessage; 
		public String request;
		public EchoServer esrv;
		public DataClient client;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			putMessage = new MessageDelegate(PutMessage);
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			//ServerConnection();
			esrv = new EchoServer(49200);
			var lst = esrv.Echo();
			if (lst.Count > 0) {
				foreach (var el in lst) {
					PutMessage(el.Address.ToString());
					}
				client = new DataClient();
				client.ClientReceiveCallback = new ReceiveCallback(Process);
				if (client.Connect(new IPEndPoint(lst[0].Address, 49210))) {
					client.Send("TIME");
				}
			}else{PutMessage("Серверы не отвечают");}
			
			
		}
		
		public string Process(string msg)
		{
			messages.Invoke(putMessage, msg);
			client.Send("CLOSE");
			return "";
		}
		
		void PutMessage(String msg){
			String[] tmp = messages.Lines;
			Array.Resize(ref tmp, tmp.Length+1);
			tmp[tmp.Length-1] = msg;
			messages.Lines = tmp;
			messages.Refresh();
		}
		void Button2Click(object sender, EventArgs e)
		{
			
			Person ps = new Person();
			ps.Name = "Jhon";
			ps.LastName = "Smith";
			ps.HomeAdress = new Adress(397600, "Russia", "Voroneghskaya oblasty", "Klacheevskyi raion", "Kalach", "Lenynskaya", "24");
			
			xmlSerializePreparator.SerializeObjectToFile(ps, "person.xml");
			
			Object obj = xmlSerializePreparator.DeserializeObjectFromFile("person.xml");
			
			}
		}
		
		
	}
