/*
 * Создано в SharpDevelop.
 * Пользователь: V.Seminchenko
 * Дата: 01.07.2015
 * Время: 11:34
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ColorTest
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	public partial class MainForm : Form
	{
		
		public ColorUtils.ColorSpaces chk;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			chk = ColorUtils.ColorSpaces.HSV;
			checkedListBox1.Items.Add(ColorUtils.ColorSpaces.HSV);
			checkedListBox1.Items.Add(ColorUtils.ColorSpaces.HSL);
			checkedListBox1.Items.Add(ColorUtils.ColorSpaces.Lab);
			checkedListBox1.Items.Add(ColorUtils.ColorSpaces.XYZ);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			colorDialog1.Color = (sender as Button).BackColor;
			if ((colorDialog1.ShowDialog()) == DialogResult.OK) {
				(sender as Button).BackColor = colorDialog1.Color;
				
				int cgdcount = colorGrid.Controls.Count;
				
				for (int i = 0; i < cgdcount; i++) {
					var ctrl = colorGrid.Controls[i];
						if (ctrl.Name == (sender as Button).Text) {
							ctrl.BackColor = (sender as Button).BackColor;
						}
				
				}
			}
		
		}
		void Button18Click(object sender, EventArgs e)
		{
			colorDialog1.Color = (sender as Button).BackColor;
			if ((colorDialog1.ShowDialog()) == DialogResult.OK) {
				(sender as Button).BackColor = colorDialog1.Color;
				
				int cgdcount = colorGrid.Controls.Count;
				int lbcount;
				
				for (int i = 0; i < cgdcount; i++) {
					var ctrl = colorGrid.Controls[i];
					lbcount = ctrl.Controls.Count;
					for (int j = 0; j < lbcount; j++) {
						var ctr = ctrl.Controls[j];
						if (ctr.Text == (sender as Button).Text) {
							ctr.ForeColor = (sender as Button).BackColor;
						}
					}
				}
			}
		}
		
		void TrackBar1ValueChanged(object sender, EventArgs e)
		{
			
		}
		
		void NegativeHueScroll(object sender, EventArgs e)
		{
				int cgdcount = colorGrid.Controls.Count;
				int lbcount;
				
				for (int i = 0; i < cgdcount; i++) {
					var ctrl = colorGrid.Controls[i];
					if (ctrl.Name == "LightNegative") {
						ctrl.BackColor = ColorUtils.ToColor((float)negativeHue.Value, (float)((negativeSat.Value)/100.0), (float)((lightValue.Value)/100.0), chk);
						blneg.BackColor = ctrl.BackColor;
					}
					if (ctrl.Name == "LightNeutral") {
						ctrl.BackColor = ColorUtils.ToColor((float)neutralHue.Value, (float)((neutralSat.Value)/100.0), (float)((lightValue.Value)/100.0), chk);
						blnet.BackColor = ctrl.BackColor;
					}
					if (ctrl.Name == "LightPositive") {
						ctrl.BackColor = ColorUtils.ToColor((float)positiveHue.Value, (float)((positiveSat.Value)/100.0), (float)((lightValue.Value)/100.0), chk);
						blpos.BackColor = ctrl.BackColor;
					}
					if (ctrl.Name == "MediumNegative") {
						ctrl.BackColor = ColorUtils.ToColor((float)negativeHue.Value, (float)((negativeSat.Value)/100.0), (float)((mediumValue.Value)/100.0), chk);
						bmneg.BackColor = ctrl.BackColor;
					}
					if (ctrl.Name == "MediumNeutral") {
						ctrl.BackColor = ColorUtils.ToColor((float)neutralHue.Value, (float)((neutralSat.Value)/100.0), (float)((mediumValue.Value)/100.0), chk);
						 bmnet.BackColor = ctrl.BackColor;
					}
					if (ctrl.Name == "MediumPositive") {
						ctrl.BackColor = ColorUtils.ToColor((float)positiveHue.Value, (float)((positiveSat.Value)/100.0), (float)((mediumValue.Value)/100.0), chk);
						bmpos.BackColor = ctrl.BackColor;
					}
					if (ctrl.Name == "DarkNegative") {
						ctrl.BackColor = ColorUtils.ToColor((float)negativeHue.Value, (float)((negativeSat.Value)/100.0), (float)((darkValue.Value)/100.0), chk);
						bdneg.BackColor = ctrl.BackColor;
					}
					if (ctrl.Name == "DarkNeutral") {
						ctrl.BackColor = ColorUtils.ToColor((float)neutralHue.Value, (float)((neutralSat.Value)/100.0), (float)((darkValue.Value)/100.0), chk);
						bdnet.BackColor = ctrl.BackColor;
					}
					if (ctrl.Name == "DarkPositive") {
						ctrl.BackColor = ColorUtils.ToColor((float)positiveHue.Value, (float)((positiveSat.Value)/100.0), (float)((darkValue.Value)/100.0), chk);
						bdpos.BackColor = ctrl.BackColor;
					}
					lbcount = ctrl.Controls.Count;
					for (int j = 0; j < lbcount; j++) {
						var ctr = ctrl.Controls[j];
						if (ctr.Text == "LightNegative") {
							ctr.ForeColor = ColorUtils.ToColor((float)negativeHue.Value, (float)((negativeSat.Value)/100.0), (float)((lightValueT.Value)/100.0), chk);
							blnegt.BackColor = ctr.ForeColor;
						}
						if (ctr.Text == "LightNeutral") {
							ctr.ForeColor = ColorUtils.ToColor((float)neutralHue.Value, (float)((neutralSat.Value)/100.0), (float)((lightValueT.Value)/100.0), chk);
							blnett.BackColor = ctr.ForeColor;
						}
						if (ctr.Text == "LightPositive") {
							ctr.ForeColor = ColorUtils.ToColor((float)positiveHue.Value, (float)((positiveSat.Value)/100.0), (float)((lightValueT.Value)/100.0), chk);
							blpost.BackColor = ctr.ForeColor;
						}
						if (ctr.Text == "MediumNegative") {
							ctr.ForeColor = ColorUtils.ToColor((float)negativeHue.Value, (float)((negativeSat.Value)/100.0), (float)((mediumValueT.Value)/100.0), chk);
							bmnegt.BackColor = ctr.ForeColor;
						}
						if (ctr.Text == "MediumNeutral") {
							ctr.ForeColor = ColorUtils.ToColor((float)neutralHue.Value, (float)((neutralSat.Value)/100.0), (float)((mediumValueT.Value)/100.0), chk);
							bmnett.BackColor = ctr.ForeColor;
						}
						if (ctr.Text == "MediumPositive") {
							ctr.ForeColor = ColorUtils.ToColor((float)positiveHue.Value, (float)((positiveSat.Value)/100.0), (float)((mediumValueT.Value)/100.0), chk);
							bmpost.BackColor = ctr.ForeColor;
						}
						if (ctr.Text == "DarkNegative") {
							ctr.ForeColor = ColorUtils.ToColor((float)negativeHue.Value, (float)((negativeSat.Value)/100.0), (float)((darkValueT.Value)/100.0), chk);
							bdnegt.BackColor = ctr.ForeColor;
						}
						if (ctr.Text == "DarkNeutral") {
							ctr.ForeColor = ColorUtils.ToColor((float)neutralHue.Value, (float)((neutralSat.Value)/100.0), (float)((darkValueT.Value)/100.0), chk);
							bdnett.BackColor = ctr.ForeColor;
						}
						if (ctr.Text == "DarkPositive") {
							ctr.ForeColor = ColorUtils.ToColor((float)positiveHue.Value, (float)((positiveSat.Value)/100.0), (float)((darkValueT.Value)/100.0), chk);
							bdpost.BackColor = ctr.ForeColor;
						}
					}
				}
			}
		void CheckedListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			var ci = checkedListBox1.CheckedItems;
			if (ci.Count > 0) {
				if (ci[0].Equals(ColorUtils.ColorSpaces.HSV)) {
					chk = ColorUtils.ColorSpaces.HSV;
					NegativeHueScroll(sender, e);
				}
				if (ci[0].Equals(ColorUtils.ColorSpaces.HSL)) {
					chk = ColorUtils.ColorSpaces.HSL;
					NegativeHueScroll(sender, e);
				}
				if (ci[0].Equals(ColorUtils.ColorSpaces.XYZ)) {
					chk = ColorUtils.ColorSpaces.XYZ;
					NegativeHueScroll(sender, e);
				}
				if (ci[0].Equals(ColorUtils.ColorSpaces.Lab)) {
					chk = ColorUtils.ColorSpaces.Lab;
					NegativeHueScroll(sender, e);
				}
			}
		}
	}
		
	/// <summary>
	/// Structure to define CIE XYZ.
	/// </summary>
	public struct CIEXYZ
	{
		/// <summary>
		/// Gets an empty CIEXYZ structure.
		/// </summary>
		public static readonly CIEXYZ Empty = new CIEXYZ();
		/// <summary>
		/// Gets the CIE D65 (white) structure.
		/// </summary>
		public static readonly CIEXYZ D65 = new CIEXYZ(0.9505, 1.0, 1.0890);


		private double x;
		private double y;
		private double z;

		public static bool operator ==(CIEXYZ item1, CIEXYZ item2)
		{
			return (
				item1.X == item2.X
				&& item1.Y == item2.Y
				&& item1.Z == item2.Z
			);
		}

		public static bool operator !=(CIEXYZ item1, CIEXYZ item2)
		{
			return (
				item1.X != item2.X
				|| item1.Y != item2.Y
				|| item1.Z != item2.Z
			);
		}

		/// <summary>
		/// Gets or sets X component.
		/// </summary>
		public double X
		{
			get
			{
				return this.x;
			}
			set
			{
				this.x = (value>0.9505)? 0.9505 : ((value<0)? 0 : value);
			}
		}

		/// <summary>
		/// Gets or sets Y component.
		/// </summary>
		public double Y
		{
			get
			{
				return this.y;
			}
			set
			{
				this.y = (value>1.0)? 1.0 : ((value<0)?0 : value);
			}
		}

		/// <summary>
		/// Gets or sets Z component.
		/// </summary>
		public double Z
		{
			get
			{
				return this.z;
			}
			set
			{
				this.z = (value>1.089)? 1.089 : ((value<0)? 0 : value);
			}
		}

		public CIEXYZ(double x, double y, double z)
		{
			this.x = (x>0.9505)? 0.9505 : ((x<0)? 0 : x);
			this.y = (y>1.0)? 1.0 : ((y<0)? 0 : y);
			this.z = (z>1.089)? 1.089 : ((z<0)? 0 : z);
		}

		public override bool Equals(Object obj)
		{
			if(obj==null || GetType()!=obj.GetType()) return false;

			return (this == (CIEXYZ)obj);
		}

		public override int GetHashCode()
		{
			return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
		}

	}
	public static class ColorUtils
    {
		public enum ColorSpaces
		{
			HSV, HSL, XYZ, Lab
		}
		
		public static Color ToColor(double x, double y, double z, ColorSpaces colorSpace)
		{
			switch (colorSpace) {
				case ColorSpaces.HSV:
					return HsvToRgb(x,y,z);

				case ColorSpaces.HSL:
					return HslToRgb(x,y,z);
					
				case ColorSpaces.XYZ:
					return XyzToRgb(x,y,z);
					
				case ColorSpaces.Lab:
					return LabToRgb(z,x/360.0,y);
					
				default:
					return System.Drawing.Color.White;
			}
			
		}
		
        public static Color HsvToRgb(double h, double s, double v)
        {
            int hi = (int)Math.Floor(h / 60.0) % 6;
            double f = (h / 60.0) - Math.Floor(h / 60.0);

            double p = v * (1.0 - s);
            double q = v * (1.0 - (f * s));
            double t = v * (1.0 - ((1.0 - f) * s));

            Color ret;


            switch (hi)
            {
                case 0:
                    ret = ColorUtils.GetRgb(v, t, p);
                    break;
                case 1:
                    ret = ColorUtils.GetRgb(q, v, p);
                    break;
                case 2:
                    ret = ColorUtils.GetRgb(p, v, t);
                    break;
                case 3:
                    ret = ColorUtils.GetRgb(p, q, v);
                    break;
                case 4:
                    ret = ColorUtils.GetRgb(t, p, v);
                    break;
                case 5:
                    ret = ColorUtils.GetRgb(v, p, q);
                    break;
                default:
                    ret = Color.FromArgb(0xFF, 0x00, 0x00, 0x00);
                    break;
            }
            return ret;
        }
        
        /// <summary>
        /// Converts HSL to RGB.
        /// </summary>
        /// <param name="h">Hue, must be in [0, 360].</param>
        /// <param name="s">Saturation, must be in [0, 1].</param>
        /// <param name="l">Luminance, must be in [0, 1].</param>
        public static Color HslToRgb(double h, double s, double l)
        {
        	if(s == 0.0)
        	{
        		// achromatic color (gray scale)
        		return GetRgb(l, l, l);
        	}
        	else
        	{
        		double q = (l<0.5)?(l * (1.0+s)):(l+s - (l*s));
        		double p = (2.0 * l) - q;

        		double Hk = h/360.0;
        		double[] T = new double[3];
        		T[0] = Hk + (1.0/3.0);    // Tr
        		T[1] = Hk;                // Tb
        		T[2] = Hk - (1.0/3.0);    // Tg

        		for(int i=0; i<3; i++)
        		{
        			if(T[i] < 0) T[i] += 1.0;
        			if(T[i] > 1) T[i] -= 1.0;

        			if((T[i]*6) < 1)
        			{
        				T[i] = p + ((q-p)*6.0*T[i]);
        			}
        			else if((T[i]*2.0) < 1) //(1.0/6.0)<=T[i] && T[i]<0.5
        			{
        				T[i] = q;
        			}
        			else if((T[i]*3.0) < 2) // 0.5<=T[i] && T[i]<(2.0/3.0)
        			{
        				T[i] = p + (q-p) * ((2.0/3.0) - T[i]) * 6.0;
        			}
        			else T[i] = p;
        		}

        		return GetRgb(T[0], T[1], T[2]);
        	}
        }

        /// <summary>
        /// Converts CIEXYZ to RGB structure.
        /// </summary>
        public static Color XyzToRgb(double x, double y, double z)
        {
        	double[] Clinear = new double[3];
        	Clinear[0] = x*3.2410 - y*1.5374 - z*0.4986; // red
        	Clinear[1] = -x*0.9692 + y*1.8760 - z*0.0416; // green
        	Clinear[2] = x*0.0556 - y*0.2040 + z*1.0570; // blue

        	for(int i=0; i<3; i++)
        	{
        		Clinear[i] = (Clinear[i]<=0.0031308)? 12.92*Clinear[i] : (
        			1+0.055)* Math.Pow(Clinear[i], (1.0/2.4)) - 0.055;
        	}

        	return GetRgb(Clinear[0], Clinear[1], Clinear[2]);
        }
        
        /// <summary>
        /// Converts CIELab to CIEXYZ.
        /// </summary>
        public static Color LabToRgb(double l, double a, double b)
        {
        	double delta = 6.0/29.0;

        	double fy = (l+16)/116.0;
        	double fx = fy + (a/500.0);
        	double fz = fy - (b/200.0);

        	return XyzToRgb(
        		(fx > delta)? CIEXYZ.D65.X * (fx*fx*fx) : (fx - 16.0/116.0)*3*(
        			delta*delta)*CIEXYZ.D65.X,
        		(fy > delta)? CIEXYZ.D65.Y * (fy*fy*fy) : (fy - 16.0/116.0)*3*(
        			delta*delta)*CIEXYZ.D65.Y,
        		(fz > delta)? CIEXYZ.D65.Z * (fz*fz*fz) : (fz - 16.0/116.0)*3*(
        			delta*delta)*CIEXYZ.D65.Z
        	);
        }
        
        public static Color GetRgb(double r, double g, double b)
        {
            return Color.FromArgb(255, (byte)(r * 255.0), (byte)(g * 255.0), (byte)(b * 255.0));
        }
    }
}

