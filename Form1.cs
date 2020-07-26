using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemFontsAndColors
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			this.InitializeComponent();

			foreach (var property in typeof(SystemFonts).GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
			{
				if (!(property.GetValue(null) is Font value)) continue;
				var label = new Label();
				label.Margin = new Padding(3);
				label.BackColor = Color.White;
				label.ForeColor = Color.Black;
				label.Padding = new Padding(3);
				label.AutoSize = true;
				label.Font = value;
				label.Text = $"{property.Name}: {value.ToString()}";
				this.flowLayoutPanelFonts.Controls.Add(label);
			}

			foreach (var property in typeof(SystemColors).GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
			{
				if (!(property.GetValue(null) is Color value)) continue;
				var label = new Label();
				label.Margin = new Padding(3);
				label.Padding = new Padding(3);
				label.AutoSize = false;
				label.BackColor = value;
				label.ForeColor = IsColorPrettyBright(value) ? Color.Black : Color.White;
				label.Width = 250;
				label.Height = 30;
				label.Text = $"{property.Name}: {value.R}/{value.G}/{value.B}";
				this.flowLayoutPanelColors.Controls.Add(label);
			}

			foreach (var property in typeof(SystemInformation).GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
			{
				object value = property.GetValue(null);
				var label = new Label();
				label.AutoSize = true;
				label.Margin = new Padding(3);
				label.Padding = new Padding(3);
				label.BackColor = SystemColors.Window;
				label.ForeColor = SystemColors.WindowText;
				label.Text = $"{property.Name}: {CoolToString(value)}";
				this.flowLayoutPanelSystemInformation.Controls.Add(label);
			}
		}

		private static string CoolToString(object obj)
		{
			if (obj is PowerStatus powerStatus)
			{
				return $"PowerStatus ->\r\nPowerLineStatus: {powerStatus.PowerLineStatus}\r\nBatteryChargeStatus: {powerStatus.BatteryChargeStatus}\r\nBatteryFullLifetime: {powerStatus.BatteryFullLifetime}\r\nBatteryLifetime: {powerStatus.BatteryFullLifetime}\r\nBatteryLifeRemaining: {powerStatus.BatteryLifeRemaining}";
			}
			else
			{
				return obj?.ToString() ?? "(null)";
			}
		}

		private static bool IsColorPrettyBright(Color c)
		{
			return c.R * 0.4 + c.G + c.B * 0.2 > 190;
		}
	}
}
