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
			buttonRutaDescarga = new Button();
			textBoxRutaDescarga = new TextBox();
			labelRuta = new Label();
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
			textBoxUrl = new TextBox();
			labelBuscar = new Label();
			tabDescargas = new TabPage();
			panelToolBar = new Panel();
			buttonClose = new Button();
			buttonMinimize = new Button();
			buttonLogo = new Button();
			labelTittle = new Label();
			panel1 = new Panel();
			button2 = new Button();
			label4 = new Label();
			button1 = new Button();
			labelDescargas = new Label();
			tabControl1.SuspendLayout();
			tabBuscar.SuspendLayout();
			groupBoxInformacionBusqueda.SuspendLayout();
			panelRadioButtons.SuspendLayout();
			panelToolBar.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabBuscar);
			tabControl1.Controls.Add(tabDescargas);
			tabControl1.Location = new Point(-7, 66);
			tabControl1.Margin = new Padding(3, 2, 3, 2);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(711, 347);
			tabControl1.TabIndex = 0;
			// 
			// tabBuscar
			// 
			tabBuscar.BackColor = Color.DarkGray;
			tabBuscar.Controls.Add(groupBoxInformacionBusqueda);
			tabBuscar.Controls.Add(buttonBuscar);
			tabBuscar.Controls.Add(textBoxUrl);
			tabBuscar.Controls.Add(labelBuscar);
			tabBuscar.ForeColor = SystemColors.ControlText;
			tabBuscar.Location = new Point(4, 24);
			tabBuscar.Margin = new Padding(3, 2, 3, 2);
			tabBuscar.Name = "tabBuscar";
			tabBuscar.Padding = new Padding(3, 2, 3, 2);
			tabBuscar.Size = new Size(703, 319);
			tabBuscar.TabIndex = 0;
			tabBuscar.Text = "Buscar";
			// 
			// groupBoxInformacionBusqueda
			// 
			groupBoxInformacionBusqueda.Controls.Add(buttonRutaDescarga);
			groupBoxInformacionBusqueda.Controls.Add(textBoxRutaDescarga);
			groupBoxInformacionBusqueda.Controls.Add(labelRuta);
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
			groupBoxInformacionBusqueda.Location = new Point(6, 106);
			groupBoxInformacionBusqueda.Margin = new Padding(3, 2, 3, 2);
			groupBoxInformacionBusqueda.Name = "groupBoxInformacionBusqueda";
			groupBoxInformacionBusqueda.Padding = new Padding(3, 2, 3, 2);
			groupBoxInformacionBusqueda.Size = new Size(688, 209);
			groupBoxInformacionBusqueda.TabIndex = 3;
			groupBoxInformacionBusqueda.TabStop = false;
			groupBoxInformacionBusqueda.Text = "Informacion de la busqueda";
			groupBoxInformacionBusqueda.Visible = false;
			// 
			// buttonRutaDescarga
			// 
			buttonRutaDescarga.BackColor = Color.SteelBlue;
			buttonRutaDescarga.BackgroundImage = Resources.carpeta;
			buttonRutaDescarga.BackgroundImageLayout = ImageLayout.Zoom;
			buttonRutaDescarga.Cursor = Cursors.Hand;
			buttonRutaDescarga.FlatAppearance.BorderSize = 0;
			buttonRutaDescarga.FlatStyle = FlatStyle.Flat;
			buttonRutaDescarga.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonRutaDescarga.ForeColor = Color.White;
			buttonRutaDescarga.Location = new Point(403, 169);
			buttonRutaDescarga.Margin = new Padding(3, 2, 3, 2);
			buttonRutaDescarga.Name = "buttonRutaDescarga";
			buttonRutaDescarga.Size = new Size(39, 31);
			buttonRutaDescarga.TabIndex = 15;
			buttonRutaDescarga.UseVisualStyleBackColor = false;
			buttonRutaDescarga.Click += buttonRutaDescarga_Click;
			// 
			// textBoxRutaDescarga
			// 
			textBoxRutaDescarga.BackColor = SystemColors.ButtonFace;
			textBoxRutaDescarga.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBoxRutaDescarga.Location = new Point(137, 173);
			textBoxRutaDescarga.Margin = new Padding(3, 2, 3, 2);
			textBoxRutaDescarga.Name = "textBoxRutaDescarga";
			textBoxRutaDescarga.Size = new Size(260, 24);
			textBoxRutaDescarga.TabIndex = 14;
			// 
			// labelRuta
			// 
			labelRuta.BackColor = Color.Transparent;
			labelRuta.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelRuta.ForeColor = Color.White;
			labelRuta.Location = new Point(52, 174);
			labelRuta.Name = "labelRuta";
			labelRuta.Size = new Size(79, 20);
			labelRuta.TabIndex = 13;
			labelRuta.Text = "Ruta:";
			labelRuta.TextAlign = ContentAlignment.MiddleRight;
			// 
			// panelRadioButtons
			// 
			panelRadioButtons.BackColor = SystemColors.ButtonFace;
			panelRadioButtons.Controls.Add(label3);
			panelRadioButtons.Controls.Add(radioButtonMP4);
			panelRadioButtons.Controls.Add(radioButtonMP3);
			panelRadioButtons.Location = new Point(496, 30);
			panelRadioButtons.Margin = new Padding(3, 2, 3, 2);
			panelRadioButtons.Name = "panelRadioButtons";
			panelRadioButtons.Size = new Size(183, 94);
			panelRadioButtons.TabIndex = 12;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.ForeColor = Color.Black;
			label3.Location = new Point(28, 4);
			label3.Name = "label3";
			label3.Size = new Size(138, 18);
			label3.TabIndex = 2;
			label3.Text = "Tipo de descarga";
			// 
			// radioButtonMP4
			// 
			radioButtonMP4.AutoSize = true;
			radioButtonMP4.ForeColor = Color.Black;
			radioButtonMP4.Location = new Point(19, 51);
			radioButtonMP4.Margin = new Padding(3, 2, 3, 2);
			radioButtonMP4.Name = "radioButtonMP4";
			radioButtonMP4.Size = new Size(60, 22);
			radioButtonMP4.TabIndex = 1;
			radioButtonMP4.TabStop = true;
			radioButtonMP4.Text = "MP4";
			radioButtonMP4.UseVisualStyleBackColor = true;
			// 
			// radioButtonMP3
			// 
			radioButtonMP3.AutoSize = true;
			radioButtonMP3.ForeColor = Color.Black;
			radioButtonMP3.Location = new Point(19, 27);
			radioButtonMP3.Margin = new Padding(3, 2, 3, 2);
			radioButtonMP3.Name = "radioButtonMP3";
			radioButtonMP3.Size = new Size(60, 22);
			radioButtonMP3.TabIndex = 0;
			radioButtonMP3.TabStop = true;
			radioButtonMP3.Text = "MP3";
			radioButtonMP3.UseVisualStyleBackColor = true;
			// 
			// textBoxTamaño
			// 
			textBoxTamaño.BackColor = SystemColors.ButtonFace;
			textBoxTamaño.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBoxTamaño.Location = new Point(137, 140);
			textBoxTamaño.Margin = new Padding(3, 2, 3, 2);
			textBoxTamaño.Name = "textBoxTamaño";
			textBoxTamaño.Size = new Size(260, 24);
			textBoxTamaño.TabIndex = 11;
			// 
			// label2
			// 
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.White;
			label2.Location = new Point(52, 142);
			label2.Name = "label2";
			label2.Size = new Size(79, 20);
			label2.TabIndex = 10;
			label2.Text = "Tamaño:";
			label2.TextAlign = ContentAlignment.MiddleRight;
			// 
			// textBoxAutor
			// 
			textBoxAutor.BackColor = SystemColors.ButtonFace;
			textBoxAutor.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBoxAutor.Location = new Point(137, 104);
			textBoxAutor.Margin = new Padding(3, 2, 3, 2);
			textBoxAutor.Name = "textBoxAutor";
			textBoxAutor.Size = new Size(260, 24);
			textBoxAutor.TabIndex = 9;
			// 
			// label1
			// 
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(52, 104);
			label1.Name = "label1";
			label1.Size = new Size(79, 20);
			label1.TabIndex = 8;
			label1.Text = "Autor:";
			label1.TextAlign = ContentAlignment.MiddleRight;
			// 
			// textBoxDuracion
			// 
			textBoxDuracion.BackColor = SystemColors.ButtonFace;
			textBoxDuracion.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBoxDuracion.Location = new Point(137, 70);
			textBoxDuracion.Margin = new Padding(3, 2, 3, 2);
			textBoxDuracion.Name = "textBoxDuracion";
			textBoxDuracion.Size = new Size(260, 24);
			textBoxDuracion.TabIndex = 7;
			// 
			// textBoxTitulo
			// 
			textBoxTitulo.BackColor = SystemColors.ButtonFace;
			textBoxTitulo.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBoxTitulo.Location = new Point(137, 36);
			textBoxTitulo.Margin = new Padding(3, 2, 3, 2);
			textBoxTitulo.Name = "textBoxTitulo";
			textBoxTitulo.Size = new Size(260, 24);
			textBoxTitulo.TabIndex = 6;
			// 
			// labelDuracion
			// 
			labelDuracion.BackColor = Color.Transparent;
			labelDuracion.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelDuracion.ForeColor = Color.White;
			labelDuracion.Location = new Point(52, 68);
			labelDuracion.Name = "labelDuracion";
			labelDuracion.Size = new Size(79, 21);
			labelDuracion.TabIndex = 5;
			labelDuracion.Text = "Duracion:";
			labelDuracion.TextAlign = ContentAlignment.MiddleRight;
			// 
			// labelTituloVideo
			// 
			labelTituloVideo.BackColor = Color.Transparent;
			labelTituloVideo.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelTituloVideo.ForeColor = Color.White;
			labelTituloVideo.Location = new Point(52, 36);
			labelTituloVideo.Name = "labelTituloVideo";
			labelTituloVideo.Size = new Size(79, 20);
			labelTituloVideo.TabIndex = 4;
			labelTituloVideo.Text = "Titulo:";
			labelTituloVideo.TextAlign = ContentAlignment.MiddleRight;
			// 
			// buttonDescargar
			// 
			buttonDescargar.BackColor = Color.LimeGreen;
			buttonDescargar.Cursor = Cursors.Hand;
			buttonDescargar.Enabled = false;
			buttonDescargar.FlatAppearance.BorderSize = 0;
			buttonDescargar.FlatStyle = FlatStyle.Flat;
			buttonDescargar.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonDescargar.ForeColor = Color.White;
			buttonDescargar.Location = new Point(515, 135);
			buttonDescargar.Margin = new Padding(3, 2, 3, 2);
			buttonDescargar.Name = "buttonDescargar";
			buttonDescargar.Size = new Size(162, 33);
			buttonDescargar.TabIndex = 3;
			buttonDescargar.Text = "Descargar";
			buttonDescargar.UseVisualStyleBackColor = false;
			buttonDescargar.Click += buttonDescargar_Click;
			// 
			// buttonBuscar
			// 
			buttonBuscar.BackColor = Color.Red;
			buttonBuscar.Cursor = Cursors.Hand;
			buttonBuscar.FlatAppearance.BorderSize = 0;
			buttonBuscar.FlatStyle = FlatStyle.Flat;
			buttonBuscar.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonBuscar.ForeColor = Color.White;
			buttonBuscar.Location = new Point(281, 69);
			buttonBuscar.Margin = new Padding(3, 2, 3, 2);
			buttonBuscar.Name = "buttonBuscar";
			buttonBuscar.Size = new Size(122, 33);
			buttonBuscar.TabIndex = 2;
			buttonBuscar.Text = "Buscar";
			buttonBuscar.UseVisualStyleBackColor = false;
			buttonBuscar.Click += buttonBuscar_Click;
			// 
			// textBoxUrl
			// 
			textBoxUrl.BackColor = SystemColors.ButtonFace;
			textBoxUrl.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBoxUrl.Location = new Point(52, 32);
			textBoxUrl.Margin = new Padding(3, 2, 3, 2);
			textBoxUrl.Name = "textBoxUrl";
			textBoxUrl.Size = new Size(620, 24);
			textBoxUrl.TabIndex = 1;
			// 
			// labelBuscar
			// 
			labelBuscar.BackColor = Color.Transparent;
			labelBuscar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			labelBuscar.ForeColor = Color.White;
			labelBuscar.Location = new Point(206, 2);
			labelBuscar.Name = "labelBuscar";
			labelBuscar.Size = new Size(303, 28);
			labelBuscar.TabIndex = 0;
			labelBuscar.Text = "Ingresa el link para buscar:";
			// 
			// tabDescargas
			// 
			tabDescargas.Location = new Point(4, 24);
			tabDescargas.Margin = new Padding(3, 2, 3, 2);
			tabDescargas.Name = "tabDescargas";
			tabDescargas.Padding = new Padding(3, 2, 3, 2);
			tabDescargas.Size = new Size(703, 319);
			tabDescargas.TabIndex = 1;
			tabDescargas.Text = "Descargas";
			tabDescargas.UseVisualStyleBackColor = true;
			// 
			// panelToolBar
			// 
			panelToolBar.BackColor = Color.FromArgb(209, 4, 13);
			panelToolBar.Controls.Add(buttonClose);
			panelToolBar.Controls.Add(buttonMinimize);
			panelToolBar.Controls.Add(buttonLogo);
			panelToolBar.Controls.Add(labelTittle);
			panelToolBar.Location = new Point(-3, -3);
			panelToolBar.Name = "panelToolBar";
			panelToolBar.Size = new Size(707, 40);
			panelToolBar.TabIndex = 1;
			// 
			// buttonClose
			// 
			buttonClose.BackColor = Color.Transparent;
			buttonClose.BackgroundImage = Resources.close;
			buttonClose.BackgroundImageLayout = ImageLayout.Zoom;
			buttonClose.Cursor = Cursors.Hand;
			buttonClose.FlatAppearance.BorderSize = 0;
			buttonClose.FlatStyle = FlatStyle.Flat;
			buttonClose.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonClose.ForeColor = Color.White;
			buttonClose.Location = new Point(656, 3);
			buttonClose.Margin = new Padding(3, 2, 3, 2);
			buttonClose.Name = "buttonClose";
			buttonClose.Size = new Size(38, 35);
			buttonClose.TabIndex = 4;
			buttonClose.UseVisualStyleBackColor = false;
			buttonClose.Click += buttonClose_Click;
			// 
			// buttonMinimize
			// 
			buttonMinimize.BackColor = Color.Transparent;
			buttonMinimize.BackgroundImage = Resources.minus;
			buttonMinimize.BackgroundImageLayout = ImageLayout.Zoom;
			buttonMinimize.Cursor = Cursors.Hand;
			buttonMinimize.FlatAppearance.BorderSize = 0;
			buttonMinimize.FlatStyle = FlatStyle.Flat;
			buttonMinimize.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonMinimize.ForeColor = Color.White;
			buttonMinimize.Location = new Point(619, 4);
			buttonMinimize.Margin = new Padding(3, 2, 3, 2);
			buttonMinimize.Name = "buttonMinimize";
			buttonMinimize.Size = new Size(33, 33);
			buttonMinimize.TabIndex = 5;
			buttonMinimize.UseVisualStyleBackColor = false;
			buttonMinimize.Click += buttonMinimize_Click;
			// 
			// buttonLogo
			// 
			buttonLogo.BackColor = Color.Transparent;
			buttonLogo.BackgroundImage = Resources.youtubeBlack;
			buttonLogo.BackgroundImageLayout = ImageLayout.Zoom;
			buttonLogo.FlatAppearance.BorderSize = 0;
			buttonLogo.FlatAppearance.MouseDownBackColor = Color.Transparent;
			buttonLogo.FlatAppearance.MouseOverBackColor = Color.Transparent;
			buttonLogo.FlatStyle = FlatStyle.Flat;
			buttonLogo.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonLogo.ForeColor = Color.Transparent;
			buttonLogo.Location = new Point(161, 4);
			buttonLogo.Margin = new Padding(3, 2, 3, 2);
			buttonLogo.Name = "buttonLogo";
			buttonLogo.Size = new Size(45, 32);
			buttonLogo.TabIndex = 6;
			buttonLogo.UseVisualStyleBackColor = false;
			// 
			// labelTittle
			// 
			labelTittle.BackColor = Color.Transparent;
			labelTittle.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			labelTittle.ForeColor = Color.White;
			labelTittle.Location = new Point(4, 3);
			labelTittle.Name = "labelTittle";
			labelTittle.Size = new Size(618, 37);
			labelTittle.TabIndex = 4;
			labelTittle.Text = "Youtube Downloader";
			labelTittle.TextAlign = ContentAlignment.MiddleCenter;
			labelTittle.MouseMove += labelTittle_MouseMove;
			// 
			// panel1
			// 
			panel1.BackColor = Color.DimGray;
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(button2);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(labelDescargas);
			panel1.Location = new Point(0, 34);
			panel1.Name = "panel1";
			panel1.Size = new Size(700, 34);
			panel1.TabIndex = 2;
			// 
			// button2
			// 
			button2.BackColor = Color.Transparent;
			button2.BackgroundImage = Resources.search;
			button2.BackgroundImageLayout = ImageLayout.Zoom;
			button2.Cursor = Cursors.Hand;
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
			button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.ForeColor = Color.White;
			button2.Location = new Point(3, 3);
			button2.Margin = new Padding(3, 2, 3, 2);
			button2.Name = "button2";
			button2.Size = new Size(41, 24);
			button2.TabIndex = 7;
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// label4
			// 
			label4.BackColor = Color.Transparent;
			label4.Cursor = Cursors.Hand;
			label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.White;
			label4.Location = new Point(3, 2);
			label4.Name = "label4";
			label4.Size = new Size(117, 28);
			label4.TabIndex = 6;
			label4.Text = "Buscar";
			label4.TextAlign = ContentAlignment.MiddleRight;
			label4.Click += label4_Click;
			// 
			// button1
			// 
			button1.BackColor = Color.Transparent;
			button1.BackgroundImage = Resources.download;
			button1.BackgroundImageLayout = ImageLayout.Zoom;
			button1.Cursor = Cursors.Hand;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
			button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.ForeColor = Color.White;
			button1.Location = new Point(157, 2);
			button1.Margin = new Padding(3, 2, 3, 2);
			button1.Name = "button1";
			button1.Size = new Size(37, 28);
			button1.TabIndex = 5;
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// labelDescargas
			// 
			labelDescargas.BackColor = Color.Transparent;
			labelDescargas.Cursor = Cursors.Hand;
			labelDescargas.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			labelDescargas.ForeColor = Color.White;
			labelDescargas.Location = new Point(157, 3);
			labelDescargas.Name = "labelDescargas";
			labelDescargas.Size = new Size(152, 28);
			labelDescargas.TabIndex = 4;
			labelDescargas.Text = "Descargas";
			labelDescargas.TextAlign = ContentAlignment.MiddleRight;
			labelDescargas.Click += labelDescargas_Click;
			// 
			// MainMenu
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Gray;
			ClientSize = new Size(700, 409);
			Controls.Add(panel1);
			Controls.Add(panelToolBar);
			Controls.Add(tabControl1);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(3, 2, 3, 2);
			Name = "MainMenu";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Youtube Downloader";
			tabControl1.ResumeLayout(false);
			tabBuscar.ResumeLayout(false);
			tabBuscar.PerformLayout();
			groupBoxInformacionBusqueda.ResumeLayout(false);
			groupBoxInformacionBusqueda.PerformLayout();
			panelRadioButtons.ResumeLayout(false);
			panelRadioButtons.PerformLayout();
			panelToolBar.ResumeLayout(false);
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private TabPage tabBuscar;
		private Button buttonBuscar;
		private Label labelBuscar;
		private TabPage tabDescargas;
		public TextBox textBoxUrl;
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
		public TextBox textBoxRutaDescarga;
		private Label labelRuta;
		private Button buttonRutaDescarga;
		private Panel panelToolBar;
		private Button buttonMinimize;
		private Button buttonClose;
		private Button buttonLogo;
		private Label labelTittle;
		private Panel panel1;
		private Button button1;
		private Label labelDescargas;
		public TabControl tabControl1;
		private Button button2;
		private Label label4;
	}
}
