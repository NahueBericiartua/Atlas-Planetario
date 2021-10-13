/*
 * Created by SharpDevelop.
 * User: LAB-04
 * Date: 27/9/2021
 * Time: 8:05 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace a
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
			this.pic_mercurio = new System.Windows.Forms.PictureBox();
			this.pic_venus = new System.Windows.Forms.PictureBox();
			this.pic_tierra = new System.Windows.Forms.PictureBox();
			this.pic_marte = new System.Windows.Forms.PictureBox();
			this.pic_centro = new System.Windows.Forms.PictureBox();
			this.pic_jupiter = new System.Windows.Forms.PictureBox();
			this.pic_saturno = new System.Windows.Forms.PictureBox();
			this.pic_urano = new System.Windows.Forms.PictureBox();
			this.pic_neptuno = new System.Windows.Forms.PictureBox();
			this.lbl_nombre = new System.Windows.Forms.Label();
			this.lbl_descripcion = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pic_mercurio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_venus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_tierra)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_marte)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_centro)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_jupiter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_saturno)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_urano)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_neptuno)).BeginInit();
			this.SuspendLayout();
			// 
			// pic_mercurio
			// 
			this.pic_mercurio.Location = new System.Drawing.Point(7, 12);
			this.pic_mercurio.Name = "pic_mercurio";
			this.pic_mercurio.Size = new System.Drawing.Size(73, 73);
			this.pic_mercurio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_mercurio.TabIndex = 0;
			this.pic_mercurio.TabStop = false;
			this.pic_mercurio.Tag = "0";
			this.pic_mercurio.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// pic_venus
			// 
			this.pic_venus.Location = new System.Drawing.Point(7, 91);
			this.pic_venus.Name = "pic_venus";
			this.pic_venus.Size = new System.Drawing.Size(73, 74);
			this.pic_venus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_venus.TabIndex = 1;
			this.pic_venus.TabStop = false;
			this.pic_venus.Tag = "1";
			this.pic_venus.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// pic_tierra
			// 
			this.pic_tierra.Location = new System.Drawing.Point(7, 171);
			this.pic_tierra.Name = "pic_tierra";
			this.pic_tierra.Size = new System.Drawing.Size(73, 79);
			this.pic_tierra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_tierra.TabIndex = 2;
			this.pic_tierra.TabStop = false;
			this.pic_tierra.Tag = "2";
			this.pic_tierra.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// pic_marte
			// 
			this.pic_marte.Location = new System.Drawing.Point(7, 256);
			this.pic_marte.Name = "pic_marte";
			this.pic_marte.Size = new System.Drawing.Size(73, 75);
			this.pic_marte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_marte.TabIndex = 3;
			this.pic_marte.TabStop = false;
			this.pic_marte.Tag = "3";
			this.pic_marte.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// pic_centro
			// 
			this.pic_centro.Location = new System.Drawing.Point(237, 124);
			this.pic_centro.Name = "pic_centro";
			this.pic_centro.Size = new System.Drawing.Size(391, 311);
			this.pic_centro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_centro.TabIndex = 4;
			this.pic_centro.TabStop = false;
			// 
			// pic_jupiter
			// 
			this.pic_jupiter.Location = new System.Drawing.Point(7, 337);
			this.pic_jupiter.Name = "pic_jupiter";
			this.pic_jupiter.Size = new System.Drawing.Size(73, 73);
			this.pic_jupiter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_jupiter.TabIndex = 5;
			this.pic_jupiter.TabStop = false;
			this.pic_jupiter.Tag = "4";
			this.pic_jupiter.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// pic_saturno
			// 
			this.pic_saturno.Location = new System.Drawing.Point(7, 416);
			this.pic_saturno.Name = "pic_saturno";
			this.pic_saturno.Size = new System.Drawing.Size(73, 74);
			this.pic_saturno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_saturno.TabIndex = 6;
			this.pic_saturno.TabStop = false;
			this.pic_saturno.Tag = "5";
			this.pic_saturno.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// pic_urano
			// 
			this.pic_urano.Location = new System.Drawing.Point(7, 496);
			this.pic_urano.Name = "pic_urano";
			this.pic_urano.Size = new System.Drawing.Size(73, 74);
			this.pic_urano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_urano.TabIndex = 7;
			this.pic_urano.TabStop = false;
			this.pic_urano.Tag = "6";
			this.pic_urano.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// pic_neptuno
			// 
			this.pic_neptuno.Location = new System.Drawing.Point(7, 576);
			this.pic_neptuno.Name = "pic_neptuno";
			this.pic_neptuno.Size = new System.Drawing.Size(73, 74);
			this.pic_neptuno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_neptuno.TabIndex = 8;
			this.pic_neptuno.TabStop = false;
			this.pic_neptuno.Tag = "7";
			this.pic_neptuno.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// lbl_nombre
			// 
			this.lbl_nombre.Location = new System.Drawing.Point(274, 59);
			this.lbl_nombre.Name = "lbl_nombre";
			this.lbl_nombre.Size = new System.Drawing.Size(296, 44);
			this.lbl_nombre.TabIndex = 10;
			this.lbl_nombre.Text = "label1";
			this.lbl_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_descripcion
			// 
			this.lbl_descripcion.Location = new System.Drawing.Point(237, 458);
			this.lbl_descripcion.Name = "lbl_descripcion";
			this.lbl_descripcion.Size = new System.Drawing.Size(391, 192);
			this.lbl_descripcion.TabIndex = 11;
			this.lbl_descripcion.Text = "label1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 659);
			this.Controls.Add(this.lbl_descripcion);
			this.Controls.Add(this.lbl_nombre);
			this.Controls.Add(this.pic_neptuno);
			this.Controls.Add(this.pic_urano);
			this.Controls.Add(this.pic_saturno);
			this.Controls.Add(this.pic_jupiter);
			this.Controls.Add(this.pic_centro);
			this.Controls.Add(this.pic_marte);
			this.Controls.Add(this.pic_tierra);
			this.Controls.Add(this.pic_venus);
			this.Controls.Add(this.pic_mercurio);
			this.Name = "MainForm";
			this.Text = "a";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pic_mercurio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_venus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_tierra)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_marte)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_centro)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_jupiter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_saturno)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_urano)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_neptuno)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lbl_descripcion;
		private System.Windows.Forms.Label lbl_nombre;
		private System.Windows.Forms.PictureBox pic_neptuno;
		private System.Windows.Forms.PictureBox pic_urano;
		private System.Windows.Forms.PictureBox pic_saturno;
		private System.Windows.Forms.PictureBox pic_jupiter;
		private System.Windows.Forms.PictureBox pic_centro;
		private System.Windows.Forms.PictureBox pic_marte;
		private System.Windows.Forms.PictureBox pic_tierra;
		private System.Windows.Forms.PictureBox pic_venus;
		private System.Windows.Forms.PictureBox pic_mercurio;
	}
}
