/*
 * Created by SharpDevelop.
 * User: william sy
 * Date: 2/6/2021
 * Time: 10:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NumberSystemsConverter
{
	partial class MainForm
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
			this.main = new System.Windows.Forms.GroupBox();
			this.btn_hexadecimal = new System.Windows.Forms.Button();
			this.btn_decimal = new System.Windows.Forms.Button();
			this.btn_octal = new System.Windows.Forms.Button();
			this.btn_binary = new System.Windows.Forms.Button();
			this.btn_exit = new System.Windows.Forms.Button();
			this.lbl_instruct = new System.Windows.Forms.Label();
			this.main.SuspendLayout();
			this.SuspendLayout();
			// 
			// main
			// 
			this.main.Controls.Add(this.btn_hexadecimal);
			this.main.Controls.Add(this.btn_decimal);
			this.main.Controls.Add(this.btn_octal);
			this.main.Controls.Add(this.btn_binary);
			this.main.Location = new System.Drawing.Point(12, 62);
			this.main.Name = "main";
			this.main.Size = new System.Drawing.Size(368, 132);
			this.main.TabIndex = 0;
			this.main.TabStop = false;
			this.main.Text = "Convert from:";
			// 
			// btn_hexadecimal
			// 
			this.btn_hexadecimal.Location = new System.Drawing.Point(196, 80);
			this.btn_hexadecimal.Name = "btn_hexadecimal";
			this.btn_hexadecimal.Size = new System.Drawing.Size(145, 32);
			this.btn_hexadecimal.TabIndex = 4;
			this.btn_hexadecimal.Text = "Hexadecimal";
			this.btn_hexadecimal.UseVisualStyleBackColor = true;
			this.btn_hexadecimal.Click += new System.EventHandler(this.Btn_hexadecimalClick);
			// 
			// btn_decimal
			// 
			this.btn_decimal.Location = new System.Drawing.Point(196, 33);
			this.btn_decimal.Name = "btn_decimal";
			this.btn_decimal.Size = new System.Drawing.Size(145, 32);
			this.btn_decimal.TabIndex = 3;
			this.btn_decimal.Text = "Decimal";
			this.btn_decimal.UseVisualStyleBackColor = true;
			this.btn_decimal.Click += new System.EventHandler(this.Btn_decimalClick);
			// 
			// btn_octal
			// 
			this.btn_octal.Location = new System.Drawing.Point(16, 80);
			this.btn_octal.Name = "btn_octal";
			this.btn_octal.Size = new System.Drawing.Size(145, 32);
			this.btn_octal.TabIndex = 1;
			this.btn_octal.Text = "Octal";
			this.btn_octal.UseVisualStyleBackColor = true;
			this.btn_octal.Click += new System.EventHandler(this.Btn_octalClick);
			// 
			// btn_binary
			// 
			this.btn_binary.Location = new System.Drawing.Point(16, 33);
			this.btn_binary.Name = "btn_binary";
			this.btn_binary.Size = new System.Drawing.Size(145, 32);
			this.btn_binary.TabIndex = 0;
			this.btn_binary.Text = "Binary";
			this.btn_binary.UseVisualStyleBackColor = true;
			this.btn_binary.Click += new System.EventHandler(this.Btn_binaryClick);
			// 
			// btn_exit
			// 
			this.btn_exit.Location = new System.Drawing.Point(314, 211);
			this.btn_exit.Name = "btn_exit";
			this.btn_exit.Size = new System.Drawing.Size(66, 23);
			this.btn_exit.TabIndex = 5;
			this.btn_exit.Text = "Exit";
			this.btn_exit.UseVisualStyleBackColor = true;
			this.btn_exit.Click += new System.EventHandler(this.Btn_exitClick);
			// 
			// lbl_instruct
			// 
			this.lbl_instruct.Location = new System.Drawing.Point(12, 27);
			this.lbl_instruct.Name = "lbl_instruct";
			this.lbl_instruct.Size = new System.Drawing.Size(368, 23);
			this.lbl_instruct.TabIndex = 5;
			this.lbl_instruct.Text = "Instructions: Choose among the available number systems.";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(392, 246);
			this.Controls.Add(this.lbl_instruct);
			this.Controls.Add(this.btn_exit);
			this.Controls.Add(this.main);
			this.Name = "MainForm";
			this.Text = "Number Systems Converter";
			this.main.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lbl_instruct;
		private System.Windows.Forms.Button btn_exit;
		private System.Windows.Forms.Button btn_binary;
		private System.Windows.Forms.Button btn_octal;
		private System.Windows.Forms.Button btn_decimal;
		private System.Windows.Forms.Button btn_hexadecimal;
		private System.Windows.Forms.GroupBox main;
	}
}
