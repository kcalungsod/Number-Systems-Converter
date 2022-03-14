using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace NumberSystemsConverter
{
	/// <summary>
	/// Description of Octal.
	/// </summary>
	public partial class Octal : Form
	{
		public Octal()
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
		
		void Rbtn_decimalCheckedChanged(object sender, EventArgs e)
		{
			btn_convert.Text = "Convert to Decimal";
			lbl_numbersystem.Text = "Decimal: ";
			lbl_subscript.Text = "10";
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
				MessageBox.Show("Error. Please follow the instructions and input a proper octal number.");
			}

			else{
			
			/*checks if the input is a proper octal number or not. If a letter, punctuation or digit 8 and 9 is 
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
				else if (a[b].ToString().Equals("8") || a[b].ToString().Equals("9")){
					inputcheck = false;
					break;
				}
		
			}
			
			if (inputcheck == false){
				txt_input.Text = "";
				lbl_converted.Text = "";
				MessageBox.Show("Error. Please follow the instructions and input a proper octal number.");
			}
			
			else{ //once the input passes checking, the computation begins.
				int x = int.Parse(txt_input.Text);
				List <int> digit = new List<int>();
				List <double> output = new List<double>();
				int count=0, input=0, check = x;
				double midoutput=0, output_decimal=0;
				
				//counts the number of digits in a number
				while (check!=0){
					check = check/10;
					count++;
				}
				
				//stores the digits in an array in reverse
				for (int z=0; z<count; z++){
					int mod = x%10;
					x/=10;
					digit.Add(mod);
				}
				
				/*multiply each digit with 8 raised to the power of their index number; store to another array -
				the output array.*/
				for (int z=0; z<digit.Count;z++){
					input = digit[z];
					midoutput = input*(Math.Pow(8,z));
					output.Add(midoutput);
				}
				
				//adds all the elements of the output array to get the decimal output of the octal number			
				foreach(double number in output){
					output_decimal = output_decimal + number;
				}
				
				/*converts the decimal output into int so it can be used in later computations for other 
				number systems*/
				int y = Convert.ToInt32(output_decimal);
				
				if (rbtn_binary.Checked){
					List <int> output_binary = new List<int>();
					int mod_binary;
					
					/*converts the decimal output into its binary form by storing the remainders of the decimal
					output as its divided into 2 continuously into an array and reversing its position*/
					while (y!=0){
						mod_binary = y%2;
						output_binary.Add(mod_binary);
						y=y/2;
					}
					output_binary.Reverse();
					lbl_converted.Text = string.Join("", output_binary);
				}
				else if (rbtn_decimal.Checked){
					lbl_converted.Text = output_decimal.ToString();
				}
				else if (rbtn_hexadecimal.Checked){
					List <string> output_hexadecimal = new List<string>();
					int mod_hexadecimal;
					
					/*converts the decimal output into its hexadecimal form by storing the remainders of the 
					decimal as its divided into 16 continuously into an array and reversing its position*/
					while (y!=0){
						mod_hexadecimal = y%16;
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
						y=y/16;
					}
					output_hexadecimal.Reverse();
					lbl_converted.Text = string.Join("", output_hexadecimal);
					}
				}
			}
		}
	}
}
