/*
 * Created by SharpDevelop.
 * User: joilma
 * Date: 10/12/2022
 * Time: 07:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace agenciaPubli
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.Button btnApt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		
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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.btnApt = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.Color.White;
			this.richTextBox1.Location = new System.Drawing.Point(57, 28);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(215, 263);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// richTextBox2
			// 
			this.richTextBox2.BackColor = System.Drawing.Color.White;
			this.richTextBox2.Location = new System.Drawing.Point(416, 28);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(222, 263);
			this.richTextBox2.TabIndex = 1;
			this.richTextBox2.Text = "";
			// 
			// btnApt
			// 
			this.btnApt.BackColor = System.Drawing.Color.Transparent;
			this.btnApt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnApt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnApt.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnApt.Location = new System.Drawing.Point(316, 121);
			this.btnApt.Name = "btnApt";
			this.btnApt.Size = new System.Drawing.Size(61, 42);
			this.btnApt.TabIndex = 2;
			this.btnApt.Text = ">>>";
			this.btnApt.UseVisualStyleBackColor = false;
			this.btnApt.Click += new System.EventHandler(this.BtnAptClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(278, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 49);
			this.label1.TabIndex = 3;
			this.label1.Text = "Listar aptas a vaga";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(57, 2);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Lista de Candidatas:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(416, 2);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(184, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Lista de Aptas a vaga:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.ClientSize = new System.Drawing.Size(693, 332);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnApt);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.richTextBox1);
			this.Name = "MainForm";
			this.Text = "agenciaPubli";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);

		}
	}
}
