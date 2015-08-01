/*
 * Создано в SharpDevelop.
 * Пользователь: V.Seminchenko
 * Дата: 22.06.2015
 * Время: 12:48
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace AboHelper
{
	partial class TileView3line
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label labelFirstInfo;
		private System.Windows.Forms.Label labelSecondInfo;
		private System.Drawing.Color oldBgColor;
		
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
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.labelTitle = new System.Windows.Forms.Label();
			this.labelFirstInfo = new System.Windows.Forms.Label();
			this.labelSecondInfo = new System.Windows.Forms.Label();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.AutoSize = true;
			this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel4.BackColor = System.Drawing.Color.MintCream;
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.Controls.Add(this.labelTitle, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.labelFirstInfo, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.labelSecondInfo, 0, 2);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 3;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(6, 55);
			this.tableLayoutPanel4.TabIndex = 3;
			this.tableLayoutPanel4.Click += new System.EventHandler(this.LabelTitleClick);
			this.tableLayoutPanel4.MouseEnter += new System.EventHandler(this.LabelFirstInfoMouseEnter);
			this.tableLayoutPanel4.MouseLeave += new System.EventHandler(this.LabelFirstInfoMouseLeave);
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTitle.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
			this.labelTitle.ForeColor = System.Drawing.Color.SeaGreen;
			this.labelTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelTitle.Location = new System.Drawing.Point(3, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(1, 25);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Click += new System.EventHandler(this.LabelTitleClick);
			this.labelTitle.MouseEnter += new System.EventHandler(this.LabelFirstInfoMouseEnter);
			this.labelTitle.MouseLeave += new System.EventHandler(this.LabelFirstInfoMouseLeave);
			// 
			// labelFirstInfo
			// 
			this.labelFirstInfo.AutoSize = true;
			this.labelFirstInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelFirstInfo.Font = new System.Drawing.Font("Segoe UI Light", 9F);
			this.labelFirstInfo.ForeColor = System.Drawing.Color.LightSlateGray;
			this.labelFirstInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelFirstInfo.Location = new System.Drawing.Point(3, 25);
			this.labelFirstInfo.Name = "labelFirstInfo";
			this.labelFirstInfo.Size = new System.Drawing.Size(1, 15);
			this.labelFirstInfo.TabIndex = 1;
			this.labelFirstInfo.Click += new System.EventHandler(this.LabelTitleClick);
			this.labelFirstInfo.MouseEnter += new System.EventHandler(this.LabelFirstInfoMouseEnter);
			this.labelFirstInfo.MouseLeave += new System.EventHandler(this.LabelFirstInfoMouseLeave);
			// 
			// labelSecondInfo
			// 
			this.labelSecondInfo.AutoSize = true;
			this.labelSecondInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSecondInfo.Font = new System.Drawing.Font("Segoe UI Light", 9F);
			this.labelSecondInfo.ForeColor = System.Drawing.Color.LightSlateGray;
			this.labelSecondInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelSecondInfo.Location = new System.Drawing.Point(3, 40);
			this.labelSecondInfo.Name = "labelSecondInfo";
			this.labelSecondInfo.Size = new System.Drawing.Size(1, 15);
			this.labelSecondInfo.TabIndex = 2;
			this.labelSecondInfo.Click += new System.EventHandler(this.LabelTitleClick);
			this.labelSecondInfo.MouseEnter += new System.EventHandler(this.LabelFirstInfoMouseEnter);
			this.labelSecondInfo.MouseLeave += new System.EventHandler(this.LabelFirstInfoMouseLeave);
			// 
			// TileView3line
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.tableLayoutPanel4);
			this.Name = "TileView3line";
			this.Size = new System.Drawing.Size(6, 55);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
