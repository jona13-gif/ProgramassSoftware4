namespace ModeloIATuristico
{
    partial class Form1
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
            txtDestino = new TextBox();
            txtTiempoDisponible = new TextBox();
            txtPreferencias = new TextBox();
            cmbRitmo = new ComboBox();
            btnCrearItinerario = new Button();
            rtbConversacion = new RichTextBox();
            txtConsulta = new TextBox();
            btnEnviar = new Button();
            btnNuevaSesion = new Button();
            lblTiempoUtilizado = new Label();
            lblTiempoRestante = new Label();
            lblResultadoViabilidad = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(29, 378);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(125, 27);
            txtDestino.TabIndex = 0;
            // 
            // txtTiempoDisponible
            // 
            txtTiempoDisponible.Location = new Point(195, 378);
            txtTiempoDisponible.Name = "txtTiempoDisponible";
            txtTiempoDisponible.Size = new Size(125, 27);
            txtTiempoDisponible.TabIndex = 1;
            // 
            // txtPreferencias
            // 
            txtPreferencias.Location = new Point(368, 384);
            txtPreferencias.Name = "txtPreferencias";
            txtPreferencias.Size = new Size(125, 27);
            txtPreferencias.TabIndex = 2;
            // 
            // cmbRitmo
            // 
            cmbRitmo.FormattingEnabled = true;
            cmbRitmo.Location = new Point(614, 129);
            cmbRitmo.Name = "cmbRitmo";
            cmbRitmo.Size = new Size(151, 28);
            cmbRitmo.TabIndex = 3;
            cmbRitmo.SelectedIndexChanged += cmbRitmo_SelectedIndexChanged;
            // 
            // btnCrearItinerario
            // 
            btnCrearItinerario.Location = new Point(571, 384);
            btnCrearItinerario.Name = "btnCrearItinerario";
            btnCrearItinerario.Size = new Size(125, 29);
            btnCrearItinerario.TabIndex = 4;
            btnCrearItinerario.Text = "Crear itenerario";
            btnCrearItinerario.UseVisualStyleBackColor = true;
            btnCrearItinerario.Click += btnCrearItinerario_Click;
            // 
            // rtbConversacion
            // 
            rtbConversacion.Location = new Point(29, 53);
            rtbConversacion.Name = "rtbConversacion";
            rtbConversacion.Size = new Size(385, 232);
            rtbConversacion.TabIndex = 5;
            rtbConversacion.Text = "";
            rtbConversacion.TextChanged += rtbConversacion_TextChanged;
            // 
            // txtConsulta
            // 
            txtConsulta.Location = new Point(29, 301);
            txtConsulta.Name = "txtConsulta";
            txtConsulta.Size = new Size(385, 27);
            txtConsulta.TabIndex = 6;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(433, 299);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(94, 29);
            btnEnviar.TabIndex = 7;
            btnEnviar.Text = "ENVIAR";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnNuevaSesion
            // 
            btnNuevaSesion.Location = new Point(433, 231);
            btnNuevaSesion.Name = "btnNuevaSesion";
            btnNuevaSesion.Size = new Size(116, 29);
            btnNuevaSesion.TabIndex = 8;
            btnNuevaSesion.Text = "Nueva sesion";
            btnNuevaSesion.UseVisualStyleBackColor = true;
            btnNuevaSesion.Click += btnNuevaSesion_Click_1;
            // 
            // lblTiempoUtilizado
            // 
            lblTiempoUtilizado.AutoSize = true;
            lblTiempoUtilizado.Location = new Point(473, 31);
            lblTiempoUtilizado.Name = "lblTiempoUtilizado";
            lblTiempoUtilizado.Size = new Size(14, 20);
            lblTiempoUtilizado.TabIndex = 9;
            lblTiempoUtilizado.Text = "t";
            // 
            // lblTiempoRestante
            // 
            lblTiempoRestante.AutoSize = true;
            lblTiempoRestante.Location = new Point(433, 71);
            lblTiempoRestante.Name = "lblTiempoRestante";
            lblTiempoRestante.Size = new Size(14, 20);
            lblTiempoRestante.TabIndex = 10;
            lblTiempoRestante.Text = "r";
            // 
            // lblResultadoViabilidad
            // 
            lblResultadoViabilidad.AutoSize = true;
            lblResultadoViabilidad.Location = new Point(420, 132);
            lblResultadoViabilidad.Name = "lblResultadoViabilidad";
            lblResultadoViabilidad.Size = new Size(16, 20);
            lblResultadoViabilidad.TabIndex = 11;
            lblResultadoViabilidad.Text = "v";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 9);
            label1.Name = "label1";
            label1.Size = new Size(198, 20);
            label1.TabIndex = 12;
            label1.Text = "Programa itenarios turisticos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblResultadoViabilidad);
            Controls.Add(lblTiempoRestante);
            Controls.Add(lblTiempoUtilizado);
            Controls.Add(btnNuevaSesion);
            Controls.Add(btnEnviar);
            Controls.Add(txtConsulta);
            Controls.Add(rtbConversacion);
            Controls.Add(btnCrearItinerario);
            Controls.Add(cmbRitmo);
            Controls.Add(txtPreferencias);
            Controls.Add(txtTiempoDisponible);
            Controls.Add(txtDestino);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDestino;
        private TextBox txtTiempoDisponible;
        private TextBox txtPreferencias;
        private ComboBox cmbRitmo;
        private Button btnCrearItinerario;
        private RichTextBox rtbConversacion;
        private TextBox txtConsulta;
        private Button btnEnviar;
        private Button btnNuevaSesion;
        private Label lblTiempoUtilizado;
        private Label lblTiempoRestante;
        private Label lblResultadoViabilidad;
        private Label label1;
    }
}
