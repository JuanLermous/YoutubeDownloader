namespace YoutubeDownloader
{
	partial class MainMenu
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
			tabControl1 = new TabControl();
			tabBuscar = new TabPage();
			groupBoxInformacionBusqueda = new GroupBox();
			panelRadioButtons = new Panel();
			label3 = new Label();
			radioButtonMP4 = new RadioButton();
			radioButtonMP3 = new RadioButton();
			textBoxTamaño = new TextBox();
			label2 = new Label();
			textBoxAutor = new TextBox();
			label1 = new Label();
			textBoxDuracion = new TextBox();
			textBoxTitulo = new TextBox();
			labelDuracion = new Label();
			labelTituloVideo = new Label();
			buttonDescargar = new Button();
			buttonBuscar = new Button();
			textUrl = new TextBox();
			labelBuscar = new Label();
			tabDescargas = new TabPage();
			tabControl1.SuspendLayout();
			tabBuscar.SuspendLayout();
			groupBoxInformacionBusqueda.SuspendLayout();
			panelRadioButtons.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabBuscar);
			tabControl1.Controls.Add(tabDescargas);
			tabControl1.Location = new Point(0, 0);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(801, 450);
			tabControl1.TabIndex = 0;
			// 
			// tabBuscar
			// 
			tabBuscar.BackColor = Color.Gray;
			tabBuscar.Controls.Add(groupBoxInformacionBusqueda);
			tabBuscar.Controls.Add(buttonBuscar);
			tabBuscar.Controls.Add(textUrl);
			tabBuscar.Controls.Add(labelBuscar);
			tabBuscar.ForeColor = SystemColors.ControlText;
			tabBuscar.Location = new Point(4, 29);
			tabBuscar.Name = "tabBuscar";
			tabBuscar.Padding = new Padding(3);
			tabBuscar.Size = new Size(793, 417);
			tabBuscar.TabIndex = 0;
			tabBuscar.Text = "Buscar";
			// 
			// groupBoxInformacionBusqueda
			// 
			groupBoxInformacionBusqueda.Controls.Add(panelRadioButtons);
			groupBoxInformacionBusqueda.Controls.Add(textBoxTamaño);
			groupBoxInformacionBusqueda.Controls.Add(label2);
			groupBoxInformacionBusqueda.Controls.Add(textBoxAutor);
			groupBoxInformacionBusqueda.Controls.Add(label1);
			groupBoxInformacionBusqueda.Controls.Add(textBoxDuracion);
			groupBoxInformacionBusqueda.Controls.Add(textBoxTitulo);
			groupBoxInformacionBusqueda.Controls.Add(labelDuracion);
			groupBoxInformacionBusqueda.Controls.Add(labelTituloVideo);
			groupBoxInformacionBusqueda.Controls.Add(buttonDescargar);
			groupBoxInformacionBusqueda.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBoxInformacionBusqueda.ForeColor = Color.White;
			groupBoxInformacionBusqueda.Location = new Point(0, 127);
			groupBoxInformacionBusqueda.Name = "groupBoxInformacionBusqueda";
			groupBoxInformacionBusqueda.Size = new Size(793, 266);
			groupBoxInformacionBusqueda.TabIndex = 3;
			groupBoxInformacionBusqueda.TabStop = false;
			groupBoxInformacionBusqueda.Text = "Informacion de la busqueda";
			groupBoxInformacionBusqueda.Visible = false;
			// 
			// panelRadioButtons
			// 
			panelRadioButtons.BackColor = SystemColors.ButtonFace;
			panelRadioButtons.Controls.Add(label3);
			panelRadioButtons.Controls.Add(radioButtonMP4);
			panelRadioButtons.Controls.Add(radioButtonMP3);
			panelRadioButtons.Location = new Point(534, 39);
			panelRadioButtons.Name = "panelRadioButtons";
			panelRadioButtons.Size = new Size(215, 126);
			panelRadioButtons.TabIndex = 12;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.ForeColor = Color.Black;
			label3.Location = new Point(32, 6);
			label3.Name = "label3";
			label3.Size = new Size(166, 22);
			label3.TabIndex = 2;
			label3.Text = "Tipo de descarga";
			// 
			// radioButtonMP4
			// 
			radioButtonMP4.AutoSize = true;
			radioButtonMP4.ForeColor = Color.Black;
			radioButtonMP4.Location = new Point(22, 68);
			radioButtonMP4.Name = "radioButtonMP4";
			radioButtonMP4.Size = new Size(70, 26);
			radioButtonMP4.TabIndex = 1;
			radioButtonMP4.TabStop = true;
			radioButtonMP4.Text = "MP4";
			radioButtonMP4.UseVisualStyleBackColor = true;
			// 
			// radioButtonMP3
			// 
			radioButtonMP3.AutoSize = true;
			radioButtonMP3.ForeColor = Color.Black;
			radioButtonMP3.Location = new Point(22, 36);
			radioButtonMP3.Name = "radioButtonMP3";
			radioButtonMP3.Size = new Size(70, 26);
			radioButtonMP3.TabIndex = 0;
			radioButtonMP3.TabStop = true;
			radioButtonMP3.Text = "MP3";
			radioButtonMP3.UseVisualStyleBackColor = true;
			// 
			// textBoxTamaño
			// 
			textBoxTamaño.BackColor = SystemColors.ButtonFace;
			textBoxTamaño.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBoxTamaño.Location = new Point(173, 181);
			textBoxTamaño.Name = "textBoxTamaño";
			textBoxTamaño.Size = new Size(297, 28);
			textBoxTamaño.TabIndex = 11;
			// 
			// label2
			// 
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.White;
			label2.Location = new Point(60, 181);
			label2.Name = "label2";
			label2.Size = new Size(79, 26);
			label2.TabIndex = 10;
			label2.Text = "Tamaño:";
			// 
			// textBoxAutor
			// 
			textBoxAutor.BackColor = SystemColors.ButtonFace;
			textBoxAutor.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBoxAutor.Location = new Point(173, 136);
			textBoxAutor.Name = "textBoxAutor";
			textBoxAutor.Size = new Size(297, 28);
			textBoxAutor.TabIndex = 9;
			// 
			// label1
			// 
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(60, 139);
			label1.Name = "label1";
			label1.Size = new Size(79, 26);
			label1.TabIndex = 8;
			label1.Text = "Autor:";
			// 
			// textBoxDuracion
			// 
			textBoxDuracion.BackColor = SystemColors.ButtonFace;
			textBoxDuracion.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBoxDuracion.Location = new Point(173, 91);
			textBoxDuracion.Name = "textBoxDuracion";
			textBoxDuracion.Size = new Size(297, 28);
			textBoxDuracion.TabIndex = 7;
			// 
			// textBoxTitulo
			// 
			textBoxTitulo.BackColor = SystemColors.ButtonFace;
			textBoxTitulo.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBoxTitulo.Location = new Point(173, 45);
			textBoxTitulo.Name = "textBoxTitulo";
			textBoxTitulo.Size = new Size(297, 28);
			textBoxTitulo.TabIndex = 6;
			// 
			// labelDuracion
			// 
			labelDuracion.BackColor = Color.Transparent;
			labelDuracion.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelDuracion.ForeColor = Color.White;
			labelDuracion.Location = new Point(60, 91);
			labelDuracion.Name = "labelDuracion";
			labelDuracion.Size = new Size(90, 28);
			labelDuracion.TabIndex = 5;
			labelDuracion.Text = "Duracion:";
			// 
			// labelTituloVideo
			// 
			labelTituloVideo.BackColor = Color.Transparent;
			labelTituloVideo.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelTituloVideo.ForeColor = Color.White;
			labelTituloVideo.Location = new Point(60, 48);
			labelTituloVideo.Name = "labelTituloVideo";
			labelTituloVideo.Size = new Size(79, 26);
			labelTituloVideo.TabIndex = 4;
			labelTituloVideo.Text = "Titulo:";
			// 
			// buttonDescargar
			// 
			buttonDescargar.BackColor = Color.LimeGreen;
			buttonDescargar.FlatAppearance.BorderSize = 0;
			buttonDescargar.FlatStyle = FlatStyle.Flat;
			buttonDescargar.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonDescargar.ForeColor = Color.White;
			buttonDescargar.Location = new Point(593, 201);
			buttonDescargar.Name = "buttonDescargar";
			buttonDescargar.Size = new Size(139, 44);
			buttonDescargar.TabIndex = 3;
			buttonDescargar.Text = "Descargar";
			buttonDescargar.UseVisualStyleBackColor = false;
			buttonDescargar.Click += buttonDescargar_Click;
			// 
			// buttonBuscar
			// 
			buttonBuscar.BackColor = Color.Red;
			buttonBuscar.FlatAppearance.BorderSize = 0;
			buttonBuscar.FlatStyle = FlatStyle.Flat;
			buttonBuscar.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonBuscar.ForeColor = Color.White;
			buttonBuscar.Location = new Point(321, 77);
			buttonBuscar.Name = "buttonBuscar";
			buttonBuscar.Size = new Size(139, 44);
			buttonBuscar.TabIndex = 2;
			buttonBuscar.Text = "Buscar";
			buttonBuscar.UseVisualStyleBackColor = false;
			buttonBuscar.Click += buttonBuscar_Click;
			// 
			// textUrl
			// 
			textUrl.BackColor = SystemColors.ButtonFace;
			textUrl.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textUrl.Location = new Point(60, 43);
			textUrl.Name = "textUrl";
			textUrl.Size = new Size(708, 28);
			textUrl.TabIndex = 1;
			// 
			// labelBuscar
			// 
			labelBuscar.BackColor = Color.Transparent;
			labelBuscar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			labelBuscar.ForeColor = Color.White;
			labelBuscar.Location = new Point(236, 3);
			labelBuscar.Name = "labelBuscar";
			labelBuscar.Size = new Size(346, 37);
			labelBuscar.TabIndex = 0;
			labelBuscar.Text = "Ingresa el link para buscar:";
			// 
			// tabDescargas
			// 
			tabDescargas.Location = new Point(4, 29);
			tabDescargas.Name = "tabDescargas";
			tabDescargas.Padding = new Padding(3);
			tabDescargas.Size = new Size(793, 417);
			tabDescargas.TabIndex = 1;
			tabDescargas.Text = "Descargas";
			tabDescargas.UseVisualStyleBackColor = true;
			// 
			// MainMenu
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(tabControl1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "MainMenu";
			Text = "Youtube Downloader";
			tabControl1.ResumeLayout(false);
			tabBuscar.ResumeLayout(false);
			tabBuscar.PerformLayout();
			groupBoxInformacionBusqueda.ResumeLayout(false);
			groupBoxInformacionBusqueda.PerformLayout();
			panelRadioButtons.ResumeLayout(false);
			panelRadioButtons.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabBuscar;
		private Button buttonBuscar;
		private Label labelBuscar;
		private TabPage tabDescargas;
		public TextBox textUrl;
		private Label labelDuracion;
		private Label labelTituloVideo;
		private Button buttonDescargar;
		public TextBox textBoxDuracion;
		public TextBox textBoxTitulo;
		public TextBox textBoxAutor;
		private Label label1;
		public TextBox textBoxTamaño;
		private Label label2;
		public GroupBox groupBoxInformacionBusqueda;
		private Panel panelRadioButtons;
		private RadioButton radioButtonMP4;
		private RadioButton radioButtonMP3;
		private Label label3;
	}
}
