/*
 * Created by SharpDevelop.
 * User: william sy
 * Date: 2/6/2021
 * Time: 10:44 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NumberSystemsConverter
{
	partial class Binary
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbtn_hexadecimal = new System.Windows.Forms.RadioButton();
			this.rbtn_decimal = new System.Windows.Forms.RadioButton();
			this.rbtn_octal = new System.Windows.Forms.RadioButton();
			this.btn_back = new System.Windows.Forms.Button();
			this.btn_clear = new System.Windows.Forms.Button();
			this.txt_input = new System.Windows.Forms.TextBox();
			this.btn_convert = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lbl_numbersystem = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_converted = new System.Windows.Forms.Label();
			this.lbl_subscript = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbtn_hexadecimal);
			this.groupBox1.Controls.Add(this.rbtn_decimal);
			this.groupBox1.Controls.Add(this.rbtn_octal);
			this.groupBox1.Location = new System.Drawing.Point(13, 77);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(155, 148);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "From Binary to:";
			// 
			// rbtn_hexadecimal
			// 
			this.rbtn_hexadecimal.Location = new System.Drawing.Point(32, 110);
			this.rbtn_hexadecimal.Name = "rbtn_hexadecimal";
			this.rbtn_hexadecimal.Size = new System.Drawing.Size(104, 24);
			this.rbtn_hexadecimal.TabIndex = 2;
			this.rbtn_hexadecimal.TabStop = true;
			this.rbtn_hexadecimal.Text = "Hexadecimal";
			this.rbtn_hexadecimal.UseVisualStyleBackColor = true;
			this.rbtn_hexadecimal.CheckedChanged += new System.EventHandler(this.Rbtn_hexadecimalCheckedChanged);
			// 
			// rbtn_decimal
			// 
			this.rbtn_decimal.Location = new System.Drawing.Point(32, 70);
			this.rbtn_decimal.Name = "rbtn_decimal";
			this.rbtn_decimal.Size = new System.Drawing.Size(104, 24);
			this.rbtn_decimal.TabIndex = 1;
			this.rbtn_decimal.TabStop = true;
			this.rbtn_decimal.Text = "Decimal";
			this.rbtn_decimal.UseVisualStyleBackColor = true;
			this.rbtn_decimal.CheckedChanged += new System.EventHandler(this.Rbtn_decimalCheckedChanged);
			// 
			// rbtn_octal
			// 
			this.rbtn_octal.Location = new System.Drawing.Point(32, 31);
			this.rbtn_octal.Name = "rbtn_octal";
			this.rbtn_octal.Size = new System.Drawing.Size(104, 24);
			this.rbtn_octal.TabIndex = 0;
			this.rbtn_octal.TabStop = true;
			this.rbtn_octal.Text = "Octal";
			this.rbtn_octal.UseVisualStyleBackColor = true;
			this.rbtn_octal.CheckedChanged += new System.EventHandler(this.Rbtn_octalCheckedChanged);
			// 
			// btn_back
			// 
			this.btn_back.Location = new System.Drawing.Point(297, 202);
			this.btn_back.Name = "btn_back";
			this.btn_back.Size = new System.Drawing.Size(75, 23);
			this.btn_back.TabIndex = 1;
			this.btn_back.Text = "Back";
			this.btn_back.UseVisualStyleBackColor = true;
			this.btn_back.Click += new System.EventHandler(this.Btn_backClick);
			// 
			// btn_clear
			// 
			this.btn_clear.Location = new System.Drawing.Point(199, 202);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(75, 23);
			this.btn_clear.TabIndex = 2;
			this.btn_clear.Text = "Clear";
			this.btn_clear.UseVisualStyleBackColor = true;
			this.btn_clear.Click += new System.EventHandler(this.Btn_clearClick);
			// 
			// txt_input
			// 
			this.txt_input.Location = new System.Drawing.Point(12, 48);
			this.txt_input.Name = "txt_input";
			this.txt_input.Size = new System.Drawing.Size(156, 20);
			this.txt_input.TabIndex = 3;
			// 
			// btn_convert
			// 
			this.btn_convert.Location = new System.Drawing.Point(195, 48);
			this.btn_convert.Name = "btn_convert";
			this.btn_convert.Size = new System.Drawing.Size(177, 49);
			this.btn_convert.TabIndex = 4;
			this.btn_convert.Text = "Convert";
			this.btn_convert.UseVisualStyleBackColor = true;
			this.btn_convert.Click += new System.EventHandler(this.Btn_convertClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(305, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Input a binary number: You can only input digits 0 and 1.";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(220, 153);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 19);
			this.label4.TabIndex = 10;
			this.label4.Text = "_________________________________________";
			// 
			// lbl_numbersystem
			// 
			this.lbl_numbersystem.Location = new System.Drawing.Point(195, 114);
			this.lbl_numbersystem.Name = "lbl_numbersystem";
			this.lbl_numbersystem.Size = new System.Drawing.Size(177, 23);
			this.lbl_numbersystem.TabIndex = 4;
			this.lbl_numbersystem.Text = "Ouput:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(204, 153);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(10, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "(";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(336, 153);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = ")";
			// 
			// lbl_converted
			// 
			this.lbl_converted.Location = new System.Drawing.Point(212, 137);
			this.lbl_converted.Name = "lbl_converted";
			this.lbl_converted.Size = new System.Drawing.Size(126, 23);
			this.lbl_converted.TabIndex = 5;
			this.lbl_converted.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// lbl_subscript
			// 
			this.lbl_subscript.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_subscript.Location = new System.Drawing.Point(344, 154);
			this.lbl_subscript.Name = "lbl_subscript";
			this.lbl_subscript.Size = new System.Drawing.Size(24, 22);
			this.lbl_subscript.TabIndex = 9;
			this.lbl_subscript.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Binary
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(392, 246);
			this.Controls.Add(this.lbl_subscript);
			this.Controls.Add(this.lbl_converted);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_convert);
			this.Controls.Add(this.lbl_numbersystem);
			this.Controls.Add(this.txt_input);
			this.Controls.Add(this.btn_clear);
			this.Controls.Add(this.btn_back);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label4);
			this.Name = "Binary";
			this.Text = "Binary";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbl_subscript;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbl_converted;
		private System.Windows.Forms.Button btn_convert;
		private System.Windows.Forms.Label lbl_numbersystem;
		private System.Windows.Forms.TextBox txt_input;
		private System.Windows.Forms.Button btn_clear;
		private System.Windows.Forms.Button btn_back;
		private System.Windows.Forms.RadioButton rbtn_octal;
		private System.Windows.Forms.RadioButton rbtn_decimal;
		private System.Windows.Forms.RadioButton rbtn_hexadecimal;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
