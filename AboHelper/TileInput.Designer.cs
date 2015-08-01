/*
 * Создано в SharpDevelop.
 * Пользователь: V.Seminchenko
 * Дата: 03.07.2015
 * Время: 8:24
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace AboHelper
{
	partial class TileInput
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel table;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.TextBox textBox;
		
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
			this.table = new System.Windows.Forms.TableLayoutPanel();
			this.labelTitle = new System.Windows.Forms.Label();
			this.textBox = new System.Windows.Forms.TextBox();
			this.table.SuspendLayout();
			this.SuspendLayout();
			// 
			// table
			// 
			this.table.AutoSize = true;
			this.table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.table.ColumnCount = 1;
			this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.table.Controls.Add(this.labelTitle, 0, 0);
			this.table.Controls.Add(this.textBox, 0, 1);
			this.table.Dock = System.Windows.Forms.DockStyle.Fill;
			this.table.Location = new System.Drawing.Point(0, 0);
			this.table.Name = "table";
			this.table.RowCount = 2;
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.table.Size = new System.Drawing.Size(54, 32);
			this.table.TabIndex = 4;
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labelTitle.Location = new System.Drawing.Point(1, 1);
			this.labelTitle.Margin = new System.Windows.Forms.Padding(1);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(52, 13);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Title";
			// 
			// textBox
			// 
			this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox.Location = new System.Drawing.Point(2, 17);
			this.textBox.Margin = new System.Windows.Forms.Padding(2);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(50, 13);
			this.textBox.TabIndex = 1;
			// 
			// TileInput
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.table);
			this.Name = "TileInput";
			this.Size = new System.Drawing.Size(54, 32);
			this.table.ResumeLayout(false);
			this.table.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		}
		}