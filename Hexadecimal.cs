using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
	
namespace NumberSystemsConverter
{
	/// <summary>
	/// Description of Hexadecimal.
	/// </summary>
	public partial class Hexadecimal : Form
	{
		public Hexadecimal()
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
		
		
		void Rbtn_decimalCheckedChanged(object sender, EventArgs e)
		{
			btn_convert.Text = "Convert to Decimal";
			lbl_numbersystem.Text = "Decimal: ";
			lbl_subscript.Text = "10";
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
				MessageBox.Show("Error. Please follow the instructions and input a proper hexadecimal number.");
			}

			else{
			
			/*checks if the input is a proper hexadecimal number or not. If a letter that's not A-F or a punctuation is 
			in the input, a messagebox would appear and the textbox would automatically clear.*/
			for (int b = 0; b<a.Length; b++){
				if (char.IsLetter(a[b])){
					if (a[b].ToString().Equals("A") || a[b].ToString().Equals("a") || a[b].ToString().Equals("B")
					 || a[b].ToString().Equals("b") || a[b].ToString().Equals("C") || a[b].ToString().Equals("c")
					 || a[b].ToString().Equals("D") || a[b].ToString().Equals("d") || a[b].ToString().Equals("E")
					 || a[b].ToString().Equals("e") || a[b].ToString().Equals("F") || a[b].ToString().Equals("f")){
						inputcheck=true;
					}
					else{
						inputcheck = false;
						break;
					}
				}
				else if (char.IsPunctuation(a[b])){
					inputcheck = false;
					break;
				}
			}
			
			if (inputcheck == false){
				txt_input.Text = "";
				lbl_converted.Text = "";
				MessageBox.Show("Error. Please follow the instructions and input a proper hexadecimal number.");
			}				
			else{ //once the input passes checking, the computation begins.
				string x = txt_input.Text;
				List <int> digit = new List<int>();
				List <double> output = new List<double>();
				int input=0;
				double midoutput=0, output_decimal=0;
	
				
				/*seperates each digit from one another by converting the string into char array and running through this
				array with the use of a for loop. An if condition is used in order to store the equivalent int value of the
				letters in the int array which will be used later in the computation. if the input contains numbers, it
				automatically gets converted into int and added into the int array.*/ 
				char [] charx = x.ToCharArray();
				for (int i=x.LastIndexOfAny(charx); i>=0; i--){
					if (x[i].ToString().Equals("A") || x[i].ToString().Equals("a")){
						digit.Add(10);
					}
					else if (x[i].ToString().Equals("B") || x[i].ToString().Equals("b")){
						digit.Add(11);
					}
					else if (x[i].ToString().Equals("C") || x[i].ToString().Equals("c")){
						digit.Add(12);
					}
					else if (x[i].ToString().Equals("D") || x[i].ToString().Equals("d")){
						digit.Add(13);
					}
					else if (x[i].ToString().Equals("E") || x[i].ToString().Equals("e")){
						digit.Add(14);
					}
					else if (x[i].ToString().Equals("F") || x[i].ToString().Equals("f")){
						digit.Add(15);
					}
					else{
						int chardigit = int.Parse(x[i].ToString());
						digit.Add(chardigit);
					}
				}
						
				/*multiply each digit with 16 raised to the power of their index number; store to another array -
				the output array.*/
				for (int z=0; z<digit.Count;z++){
					input = digit[z];
					midoutput = input*(Math.Pow(16,z));
					output.Add(midoutput);
				}
				
				//adds all the elements of the output array	to get the decimal output of the hexadecimal number.		
				foreach(double number in output){
					output_decimal = output_decimal + number;
				}
				
				/*converts the decimal output into int so it can be used in later computations for other 
				number systems*/
				int y = Convert.ToInt32(output_decimal);
				
				if (rbtn_binary.Checked){
					List <int> output_binary = new List<int>();
					int mod_binary;
					
					/*converts the decimal output into its binary form by storing the remainders of the decimal input
					as its divided into 2 continuously into an array and reversing its position*/
					while (y!=0){
						mod_binary = y%2;
						output_binary.Add(mod_binary);
						y=y/2;
					}
					output_binary.Reverse();
					lbl_converted.Text = string.Join("", output_binary);
				}
				else if (rbtn_octal.Checked){
					List <int> output_octal = new List<int>();
					int mod_octal;
					
					/*converts the input into its octal form by storing the remainders of the decimal input
					as its divided into 8 continuously into an array and reversing its position*/
					while (y!=0){
						mod_octal = y%8;
						output_octal.Add(mod_octal);
						y=y/8;
					}
					output_octal.Reverse();
					lbl_converted.Text = string.Join("", output_octal);
				}
				else if (rbtn_decimal.Checked){
					lbl_converted.Text = output_decimal.ToString();
					}
				}
			}
		}
	}
}
