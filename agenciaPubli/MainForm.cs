/*
 * Created by SharpDevelop.
 * User: joilma
 * Date: 10/12/2022
 * Time: 07:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace agenciaPubli
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
		void MainFormLoad(object sender, EventArgs e)
		{
			try{
				richTextBox1.LoadFile("candidatas.txt",RichTextBoxStreamType.PlainText);
				
			}
			catch{
				
			}
		}
		void BtnAptClick(object sender, EventArgs e)
		{
	
 		        
				foreach (string linhaAptas in richTextBox1.Lines)
				{

				string [] dados = linhaAptas.Split(';');
				string nomes = dados[0];
				int idade = int.Parse(dados[1]);
                
				if(idade >= 18 && idade<=20){
				richTextBox2.Text += dados[0] + ';' + dados[1] + '\n';
				}
				
					richTextBox2.SaveFile("aptas.txt", RichTextBoxStreamType.PlainText);
					
				
				} //FOREACH
				
		}
	}
}
