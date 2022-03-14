using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace NumberSystemsConverter
{
	/// <summary>
	/// Description of Decimal.
	/// </summary>
	public partial class Decimal : Form
	{
		public Decimal()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
			void Btn_backClick(object sender, EventArgs e)
		{
			MainForm frm = new MainForm();
			frm.Show();
			this.Close();
		}
		
		void Rbtn_binaryCheckedChanged(object sender, EventArgs e)
		{
			btn_convert.Text = "Convert to Binary";
			lbl_numbersystem.Text = "Binary: ";
			lbl_subscript.Text = "2";
			lbl_converted.Text = "";
		}
		
		void Rbtn_octalCheckedChanged(object sender, EventArgs e)
		{
			btn_convert.Text = "Convert to Octal";
			lbl_numbersystem.Text = "Octal: ";
			lbl_subscript.Text = "8";
			lbl_converted.Text = "";
		}
		
		
		void Rbtn_hexadecimalCheckedChanged(object sender, EventArgs e)
		{
			btn_convert.Text = "Convert to Hexadecimal";
			lbl_numbersystem.Text = "Hexadecimal: ";
			lbl_subscript.Text = "16";
			lbl_converted.Text = "";
		}
		
		void Btn_clearClick(object sender, EventArgs e)
		{
			txt_input.Text = "";
			lbl_converted.Text = "";
		}
		
		void Btn_convertClick(object sender, EventArgs e)
		{
			bool inputcheck = true;
			string a = txt_input.Text;
			a.ToCharArray();
			
			//checks if the input is empty
			if (a == ""){
				MessageBox.Show("Error. Please follow the instructions and input a proper decimal number.");
			}

			else{ /*checks if the input is a proper decimal number or not. If a letter or punctuation is 
			in the input, a messagebox would appear and the textbox would automatically clear.*/
			
			for (int b = 0; b<a.Length; b++){
				if (char.IsLetter(a[b])){
					inputcheck = false;
					break;
				}
				else if (char.IsPunctuation(a[b])){
					inputcheck = false;
					break;
				}
			}
			
			if (inputcheck == false){
				txt_input.Text = "";
				lbl_converted.Text = "";
				MessageBox.Show("Error. Please follow the instructions and input a proper decimal number.");
			}	
			
			else{ //once the input passes checking, the computation begins.
				int x = int.Parse(txt_input.Text);
				
				if (rbtn_binary.Checked){
					List <int> output_binary = new List<int>();
					int mod_binary;
				
					/*converts the input into its binary form by storing the remainders of the decimal input
					as its divided into 2 continuously into an array and reversing its position*/	
					while (x!=0){
						mod_binary = x%2;
						output_binary.Add(mod_binary);
						x=x/2;
					}
					output_binary.Reverse();
					lbl_converted.Text = string.Join("", output_binary);
				}
				
				else if (rbtn_octal.Checked){
					List <int> output_octal = new List<int>();
					int mod_octal;
					
					/*converts the input into its octal form by storing the remainders of the decimal input
					as its divided into 8 continuously into an array and reversing its position*/
					while (x!=0){
						mod_octal = x%8;
						output_octal.Add(mod_octal);
						x=x/8;
					}
					output_octal.Reverse();
					lbl_converted.Text = string.Join("", output_octal);
				}
				
				else if (rbtn_hexadecimal.Checked){
					List <string> output_hexadecimal = new List<string>();
					int mod_hexadecimal;
					
					/*converts the input into its hexadecimal form by storing the remainders of the 
					decimal input as its divided into 16 continuously into an array and reversing its position*/
					while (x!=0){
						mod_hexadecimal = x%16;
						/* if the remainder is greater than 9, the element that would be stored will be the
						hexadecimal equivalent of the digit.*/
						if (mod_hexadecimal>9){
							switch (mod_hexadecimal){
							case 10:
								output_hexadecimal.Add("A");
								break;
							case 11:
								output_hexadecimal.Add("B");
								break;
							case 12:
								output_hexadecimal.Add("C");
								break;
							case 13:
								output_hexadecimal.Add("D");
								break;
							case 14:
								output_hexadecimal.Add("E");
								break;
							case 15:
								output_hexadecimal.Add("F");
								break;
							}
						}
						else{
							output_hexadecimal.Add(mod_hexadecimal.ToString());
						}
						x=x/16;
					}
					output_hexadecimal.Reverse();
					lbl_converted.Text = string.Join("", output_hexadecimal);
					}	
				}
			}
		}
	}
}
