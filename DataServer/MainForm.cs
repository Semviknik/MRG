/*
 * Создано в SharpDevelop.
 * Пользователь: V.Seminchenko
 * Дата: 06.07.2015
 * Время: 9:00
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

namespace DataServerApp
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	///
public partial class MainForm : Form
	{
		public delegate void MessageDelegate(String st);
		public MessageDelegate putMessage;
		public DataServer dsrv;
		public Thread tr;
		public UdpClient udp;
		public EchoServer esrv;
		public bool stopServer = false;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//StartServer(49210);
			dsrv = new DataServer(49210);
			ReceiveCallback st = new ReceiveCallback(process);
			dsrv.ClientReceiveCallback = st;
			dsrv.Start();
			putMessage = new MessageDelegate(PutMessage);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (esrv == null){
			esrv = new EchoServer(49200);
			}
			if (esrv.isServerRun) {
				esrv.ServerState = "SHOUTDOWN";
				esrv.StopServer();
			} else {
				esrv.ServerState = "OK";
				esrv.StartServer();
			}
		}
		

		public string process(string st)
		{
			messages.Invoke(putMessage, st);
			if (st == "TIME") {
				return "00:00:00";
			}
			return "";
		}
		
		
		void PutMessage(String msg){
			String[] tmp = messages.Lines;
			Array.Resize(ref tmp, tmp.Length+1);
			tmp[tmp.Length-1] = msg;
			messages.Lines = tmp;
			messages.Refresh();
		}


		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			if (esrv != null) {
				if (esrv.isServerRun) {
					esrv.ServerState = "SHOUTDOWN";
					esrv.StopServer();
				}
			}
			if (dsrv != null) {
				dsrv.Stop();
			}
		}
	}
	
}
