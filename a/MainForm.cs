/*
 * Created by SharpDevelop.
 * User: LAB-04
 * Date: 27/9/2021
 * Time: 8:05 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace a
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string[] imagenes;
		string[] nombre;
		string[] descripcion;
		
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
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			PictureBox aux = (PictureBox)sender;
			pic_centro.Image=aux.Image;
			int i;
			i = Convert.ToInt32(aux.Tag);
			pic_centro.Image = Image.FromFile(imagenes[i]);
			lbl_nombre.Text = nombre[i];
			lbl_descripcion.Text = descripcion[i];
		}
		
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			imagenes = new string[8];
			string dir = "C:\\Users\\LAB_08\\Documents\\SharpDevelop Projects\\a\\imagenes\\";
			imagenes[0] = dir+ "mercurio.jpg";
			imagenes[1] = dir+ "venus.jpg";
			imagenes[2] = dir+ "tierra.jpg";
			imagenes[3] = dir+ "marte.jpg";
			imagenes[4] = dir+ "jupiter.jpg";
			imagenes[5] = dir+ "saturno.jpg";
			imagenes[6] = dir+ "urano.jpg";
			imagenes[7] = dir+ "neptuno.jpg";
			
			descripcion = new string[8];
			descripcion[0] = "Mercurio es el planeta del sistema solar más cercano al Sol y el más pequeño. Forma parte de los denominados planetas interiores y carece de satélites naturales al igual que Venus.";
			descripcion[1] = "Venus es el segundo planeta del sistema solar en orden de proximidad al Sol y el tercero en cuanto a tamaño en orden ascendente después de Mercurio y Marte. Al igual que Mercurio, carece de satélites naturales. ";
			descripcion[2] = "es un planeta del sistema solar que gira alrededor de su estrella el Sol en la tercera órbita más interna. Es el más denso y el quinto mayor de los ocho planetas del sistema solar. También es el mayor de los cuatro terrestres o rocosos.";
			descripcion[3] = "Marte es el cuarto planeta en orden de distancia al Sol y el segundo más pequeño del sistema solar, después de Mercurio. También es conocido como «el planeta rojo» debido a la apariencia rojiza​ que le confiere el óxido de hierro predominante en su superficie.";
			descripcion[4] = "Júpiter es el planeta más grande del sistema solar y el quinto en orden de lejanía al Sol.3 Es un gigante gaseoso que forma parte de los denominados planetas exteriores. Es uno de los objetos naturales más brillantes en un cielo nocturno despejado, superado solo por la Luna, Venus y algunas veces Marte.";
			descripcion[5] = "Saturno es el sexto planeta del sistema solar contando desde el Sol, el segundo en tamaño y masa después de Júpiter y el único con un sistema de anillos visible desde la Tierra.";
			descripcion[6] = "Urano es el séptimo planeta del sistema solar, el tercero de mayor tamaño, y el cuarto más masivo. Aunque es detectable a simple vista en el cielo nocturno, no fue catalogado como planeta por los astrónomos de la antigüedad debido a su escasa luminosidad y a la lentitud de su órbita.";
			descripcion[7] = "Neptuno es el octavo planeta en distancia respecto al Sol y el más lejano del sistema solar. Forma parte de los denominados planetas exteriores, y dentro de estos, es uno de los gigantes helados, y es el primero que fue descubierto gracias a predicciones matemáticas.";
			
			nombre = new string[8];
			nombre[0] = "Mercurio";
			nombre[1] = "Venus";
			nombre[2] = "Tierra";
			nombre[3] = "Marte";
			nombre[4] = "Jupiter";
			nombre[5] = "Saturno";
			nombre[6] = "Urano";
			nombre[7] = "Neptuno";
			
			pic_mercurio.Image = Image.FromFile(imagenes[0]);
			pic_venus.Image = Image.FromFile(imagenes[1]);
			pic_tierra.Image = Image.FromFile(imagenes[2]);
			pic_marte.Image = Image.FromFile(imagenes[3]);
			pic_jupiter.Image = Image.FromFile(imagenes[4]);
			pic_saturno.Image = Image.FromFile(imagenes[5]);
			pic_urano.Image = Image.FromFile(imagenes[6]);
			pic_neptuno.Image = Image.FromFile(imagenes[7]);
			
			pic_centro.Image = pic_mercurio.Image;
			
			lbl_nombre.Text=nombre[0];
			lbl_descripcion.Text=descripcion[0];
		}
	}
}
