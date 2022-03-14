using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NumberSystemsConverter
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void Btn_binaryClick(object sender, EventArgs e)
		{
			//opens form for binary and hides the main form
			Binary frm = new Binary();
			frm.Show();
			this.Hide();
		}
		
		void Btn_decimalClick(object sender, EventArgs e)
		{
			//opens form for decimal and hides the main form
			Decimal frm = new Decimal();
			frm.Show();
			this.Hide();
		}
		
		void Btn_octalClick(object sender, EventArgs e)
		{
			//opens form for octal and hides the main form
			Octal frm = new Octal();
			frm.Show();
			this.Hide();
		}
		
		void Btn_hexadecimalClick(object sender, EventArgs e)
		{
			//opens form for hexadecimal and hides the main form
			Hexadecimal frm = new Hexadecimal();
			frm.Show();
			this.Hide();
		}
		
		void Btn_exitClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
