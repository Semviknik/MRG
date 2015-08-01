/*
 * Создано в SharpDevelop.
 * Пользователь: V.Seminchenko
 * Дата: 15.06.2015
 * Время: 14:44
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System.Windows.Forms;
namespace AboHelper
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panelSearsh;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panelSearhTop;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Drawing.Color colorDarkFont;
		private System.Drawing.Color colorLightFont;
		private System.Drawing.Color colorDarkBg;
		private System.Drawing.Color colorLightBg;
		private System.Drawing.Color colorDarkNeutralBg;
		private System.Drawing.Color colorLightNeutralBg;
		private System.Drawing.Color colorDarkNegativeBg;
		private System.Drawing.Color colorLightNegativeBg;
		private System.Drawing.Color colorDarkPositiveBg;
		private System.Drawing.Color colorLightPositiveBg;
		private AboHelper.TileView3line tileView3line1;
		private AboHelper.TileInput tileInput1;
		private AboHelper.TileSwith tileSwith1;
		private AboHelper.TileSwith tileSwith2;

		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		public void InitColors(){
			colorDarkBg = System.Drawing.Color.FromArgb(255,64,64,64);
			colorLightBg = System.Drawing.Color.FromArgb(255,245,245,245);
			colorDarkFont = System.Drawing.Color.FromArgb(255,32,32,32);
			colorLightFont = System.Drawing.Color.FromArgb(255,235,235,235);
		}
		public void InitializeComponent(){
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panelSearsh = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panelSearhTop = new System.Windows.Forms.Panel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.tileView3line1 = new AboHelper.TileView3line();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.tileInput1 = new AboHelper.TileInput();
			this.panel3 = new System.Windows.Forms.Panel();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.tileSwith2 = new AboHelper.TileSwith();
			this.panel1.SuspendLayout();
			this.panelSearsh.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panelSearhTop.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Controls.Add(this.panelSearsh);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Name = "panel1";
			// 
			// panelSearsh
			// 
			resources.ApplyResources(this.panelSearsh, "panelSearsh");
			this.panelSearsh.Controls.Add(this.tableLayoutPanel1);
			this.panelSearsh.Name = "panelSearsh";
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.panelSearhTop, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// panelSearhTop
			// 
			this.panelSearhTop.BackColor = System.Drawing.Color.AntiqueWhite;
			this.panelSearhTop.Controls.Add(this.tableLayoutPanel2);
			resources.ApplyResources(this.panelSearhTop, "panelSearhTop");
			this.panelSearhTop.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panelSearhTop.Name = "panelSearhTop";
			// 
			// tableLayoutPanel2
			// 
			resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
			this.tableLayoutPanel2.Controls.Add(this.button1, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			// 
			// button1
			// 
			resources.ApplyResources(this.button1, "button1");
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
			this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.button1.Name = "button1";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// tableLayoutPanel3
			// 
			resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
			this.tableLayoutPanel3.Controls.Add(this.textBox1, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.label1, 1, 1);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			resources.ApplyResources(this.textBox1, "textBox1");
			this.textBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.textBox1.Name = "textBox1";
			this.textBox1.Click += new System.EventHandler(this.TextBox1Click);
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.label1.Name = "label1";
			// 
			// flowLayoutPanel1
			// 
			resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
			this.flowLayoutPanel1.Controls.Add(this.tileView3line1);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			// 
			// tileView3line1
			// 
			resources.ApplyResources(this.tileView3line1, "tileView3line1");
			this.tileView3line1.ColorBackgraund = System.Drawing.Color.MintCream;
			this.tileView3line1.ColorInfo = System.Drawing.Color.DarkSlateGray;
			this.tileView3line1.ColorTitle = System.Drawing.Color.SeaGreen;
			this.tileView3line1.FirstInfo = "Адрес: 396600, Воронежская обл., Калачеевский р-он, г. Калач, ул. Борцов Революци" +
	"и, д. 136, кв. 4";
			this.tileView3line1.Name = "tileView3line1";
			this.tileView3line1.SecondInfo = "Лицевой счёт: 0600013513";
			this.tileView3line1.Title = "Абонент: Иванов Иван Иванович";
			this.tileView3line1.Click += new System.EventHandler(this.TileView3line1Click);
			// 
			// flowLayoutPanel2
			// 
			resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
			this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
			this.flowLayoutPanel2.Controls.Add(this.tileInput1);
			this.flowLayoutPanel2.Controls.Add(this.tileSwith2);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			// 
			// tileInput1
			// 
			resources.ApplyResources(this.tileInput1, "tileInput1");
			this.tileInput1.ColorBackgraund = System.Drawing.Color.AntiqueWhite;
			this.tileInput1.ColorTitle = System.Drawing.Color.DarkSlateGray;
			this.tileInput1.Input = "";
			this.tileInput1.Name = "tileInput1";
			this.tileInput1.Title = "Фамилия";
			// 
			// panel3
			// 
			resources.ApplyResources(this.panel3, "panel3");
			this.panel3.Controls.Add(this.flowLayoutPanel3);
			this.panel3.Name = "panel3";
			// 
			// flowLayoutPanel3
			// 
			resources.ApplyResources(this.flowLayoutPanel3, "flowLayoutPanel3");
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			// 
			// tileSwith2
			// 
			resources.ApplyResources(this.tileSwith2, "tileSwith2");
			this.tileSwith2.ColorBackgraund = System.Drawing.Color.White;
			this.tileSwith2.ColorOff = System.Drawing.Color.LightPink;
			this.tileSwith2.ColorOn = System.Drawing.Color.LightGreen;
			this.tileSwith2.ColorTitle = System.Drawing.SystemColors.ControlText;
			this.tileSwith2.Name = "tileSwith2";
			this.tileSwith2.State = true;
			this.tileSwith2.TextOff = "Off";
			this.tileSwith2.TextOn = "On";
			this.tileSwith2.Title = "Title";
			// 
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.Name = "MainForm";
			this.Click += new System.EventHandler(this.MainFormClick);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panelSearsh.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panelSearhTop.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		}
		}
