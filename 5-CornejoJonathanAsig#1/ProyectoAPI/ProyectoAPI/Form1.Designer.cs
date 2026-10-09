namespace ProyectoAPI
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
            titulo = new Label();
            btnObtenerChiste = new Button();
            txtChiste = new TextBox();
            lblFormato = new Label();
            rdbJson = new RadioButton();
            rdbTxt = new RadioButton();
            rdbCsv = new RadioButton();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            txtResultadoEstado = new TextBox();
            estado = new Label();
            SuspendLayout();

            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.Location = new Point(329, 25);
            titulo.Name = "titulo";
            titulo.Size = new Size(295, 31);
            titulo.TabIndex = 0;
            titulo.Text = "Proyecto de API de chistes";

            // 
            // btnObtenerChiste
            // 
            btnObtenerChiste.BackColor = Color.FromArgb(128, 128, 255);
            btnObtenerChiste.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnObtenerChiste.Location = new Point(372, 341);
            btnObtenerChiste.Name = "btnObtenerChiste";
            btnObtenerChiste.Size = new Size(193, 47);
            btnObtenerChiste.TabIndex = 1;
            btnObtenerChiste.Text = "Obtener chiste";
            btnObtenerChiste.UseVisualStyleBackColor = false;

            // CONEXIÓN DEL BOTÓN
            btnObtenerChiste.Click += btnObtenerChiste_Click;

            // 
            // txtChiste
            // 
            txtChiste.Location = new Point(115, 75);
            txtChiste.MinimumSize = new Size(200, 260);
            txtChiste.Multiline = true;
            txtChiste.Name = "txtChiste";
            txtChiste.Size = new Size(718, 260);
            txtChiste.TabIndex = 2;

            // 
            // lblFormato
            // 
            lblFormato.AutoSize = true;
            lblFormato.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFormato.Location = new Point(148, 414);
            lblFormato.Name = "lblFormato";
            lblFormato.Size = new Size(205, 28);
            lblFormato.TabIndex = 3;
            lblFormato.Text = "Formato para guardar";

            // 
            // rdbJson
            // 
            rdbJson.AutoSize = true;
            rdbJson.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbJson.Location = new Point(235, 458);
            rdbJson.Name = "rdbJson";
            rdbJson.Size = new Size(76, 29);
            rdbJson.TabIndex = 4;
            rdbJson.TabStop = true;
            rdbJson.Text = "JSON";
            rdbJson.UseVisualStyleBackColor = true;

            // 
            // rdbTxt
            // 
            rdbTxt.AutoSize = true;
            rdbTxt.Font = new Font("Segoe UI", 11F);
            rdbTxt.Location = new Point(409, 458);
            rdbTxt.Name = "rdbTxt";
            rdbTxt.Size = new Size(64, 29);
            rdbTxt.TabIndex = 5;
            rdbTxt.TabStop = true;
            rdbTxt.Text = "TXT";
            rdbTxt.UseVisualStyleBackColor = true;

            // 
            // rdbCsv
            // 
            rdbCsv.AutoSize = true;
            rdbCsv.Font = new Font("Segoe UI", 11F);
            rdbCsv.Location = new Point(598, 458);
            rdbCsv.Name = "rdbCsv";
            rdbCsv.Size = new Size(67, 29);
            rdbCsv.TabIndex = 6;
            rdbCsv.TabStop = true;
            rdbCsv.Text = "CSV";
            rdbCsv.UseVisualStyleBackColor = true;

            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 192, 0);
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(307, 502);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(107, 39);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;

            // CONEXIÓN DEL BOTÓN
            btnGuardar.Click += btnGuardar_Click;

            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.IndianRed;
            btnLimpiar.Font = new Font("Segoe UI", 12F);
            btnLimpiar.Location = new Point(517, 502);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(107, 39);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;

            // CONEXIÓN DEL BOTÓN
            btnLimpiar.Click += btnLimpiar_Click;

            // 
            // txtResultadoEstado
            // 
            txtResultadoEstado.Location = new Point(341, 586);
            txtResultadoEstado.Multiline = true;
            txtResultadoEstado.Name = "txtResultadoEstado";
            txtResultadoEstado.ReadOnly = true;
            txtResultadoEstado.Size = new Size(492, 34);
            txtResultadoEstado.TabIndex = 10;

            // 
            // estado
            // 
            estado.AutoSize = true;
            estado.Location = new Point(176, 589);
            estado.Name = "estado";
            estado.Size = new Size(135, 20);
            estado.TabIndex = 11;
            estado.Text = "Estado de proceso:";

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 627);
            Controls.Add(estado);
            Controls.Add(txtResultadoEstado);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(rdbCsv);
            Controls.Add(rdbTxt);
            Controls.Add(rdbJson);
            Controls.Add(lblFormato);
            Controls.Add(txtChiste);
            Controls.Add(btnObtenerChiste);
            Controls.Add(titulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Button btnObtenerChiste;
        private TextBox txtChiste;
        private Label lblFormato;
        private RadioButton rdbJson;
        private RadioButton rdbTxt;
        private RadioButton rdbCsv;
        private Button btnGuardar;
        private Button btnLimpiar;
        private TextBox txtResultadoEstado;
        private Label estado;
    }
}
