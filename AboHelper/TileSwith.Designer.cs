/*
 * Создано в SharpDevelop.
 * Пользователь: V.Seminchenko
 * Дата: 03.07.2015
 * Время: 10:22
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace AboHelper
{
	partial class TileSwith
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
		private System.Windows.Forms.Label lableTitle;
		private System.Windows.Forms.Panel panelState;
		private System.Windows.Forms.Button buttonState;
		private bool swithSatate = true;
		private string titleOn = "On";
		private string titleOff = "Off";
		private System.Drawing.Color colorOn = System.Drawing.Color.LightGreen;
		private System.Drawing.Color colorOff = System.Drawing.Color.LightPink;
		
		/// <summary>
		/// Disposes resources used by the control.
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
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
			this.lableTitle = new System.Windows.Forms.Label();
			this.panelState = new System.Windows.Forms.Panel();
			this.buttonState = new System.Windows.Forms.Button();
			this.tableLayoutPanel8.SuspendLayout();
			this.panelState.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel8
			// 
			this.tableLayoutPanel8.AutoSize = true;
			this.tableLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel8.ColumnCount = 1;
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel8.Controls.Add(this.lableTitle, 0, 0);
			this.tableLayoutPanel8.Controls.Add(this.panelState, 0, 1);
			this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel8.Name = "tableLayoutPanel8";
			this.tableLayoutPanel8.RowCount = 2;
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel8.Size = new System.Drawing.Size(44, 33);
			this.tableLayoutPanel8.TabIndex = 7;
			// 
			// lableTitle
			// 
			this.lableTitle.AutoSize = true;
			this.lableTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lableTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lableTitle.Location = new System.Drawing.Point(3, 0);
			this.lableTitle.Name = "lableTitle";
			this.lableTitle.Size = new System.Drawing.Size(38, 13);
			this.lableTitle.TabIndex = 0;
			this.lableTitle.Text = "Title";
			// 
			// panelState
			// 
			this.panelState.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panelState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelState.Controls.Add(this.buttonState);
			this.panelState.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelState.Location = new System.Drawing.Point(2, 15);
			this.panelState.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelState.Name = "panelState";
			this.panelState.Size = new System.Drawing.Size(40, 16);
			this.panelState.TabIndex = 1;
			this.panelState.Resize += new System.EventHandler(this.Panel2Resize);
			// 
			// buttonState
			// 
			this.buttonState.BackColor = System.Drawing.Color.White;
			this.buttonState.Dock = System.Windows.Forms.DockStyle.Left;
			this.buttonState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonState.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.buttonState.Location = new System.Drawing.Point(0, 0);
			this.buttonState.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.buttonState.MinimumSize = new System.Drawing.Size(12, 12);
			this.buttonState.Name = "buttonState";
			this.buttonState.Size = new System.Drawing.Size(75, 14);
			this.buttonState.TabIndex = 0;
			this.buttonState.Text = "State";
			this.buttonState.UseVisualStyleBackColor = false;
			this.buttonState.FontChanged += new System.EventHandler(this.ButtonStateFontChanged);
			this.buttonState.Click += new System.EventHandler(this.ButtonStateClick);
			// 
			// TileSwith
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.tableLayoutPanel8);
			this.Name = "TileSwith";
			this.Size = new System.Drawing.Size(44, 33);
			this.FontChanged += new System.EventHandler(this.TileSwithFontChanged);
			this.tableLayoutPanel8.ResumeLayout(false);
			this.tableLayoutPanel8.PerformLayout();
			this.panelState.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
