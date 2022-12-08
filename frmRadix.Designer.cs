namespace Conjunto_Programas_Estructura_Datos
{
    partial class frmRadix
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtTiempo = new System.Windows.Forms.TextBox();
            this.LblTiempo = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.LtbArregloOrdenadoMN = new System.Windows.Forms.ListBox();
            this.LtbArregloOrdenado = new System.Windows.Forms.ListBox();
            this.LtbArregloAleatorio = new System.Windows.Forms.ListBox();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.TxtTamaño = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtTiempo
            // 
            this.TxtTiempo.Location = new System.Drawing.Point(233, 16);
            this.TxtTiempo.Name = "TxtTiempo";
            this.TxtTiempo.Size = new System.Drawing.Size(100, 20);
            this.TxtTiempo.TabIndex = 21;
            // 
            // LblTiempo
            // 
            this.LblTiempo.AutoSize = true;
            this.LblTiempo.Location = new System.Drawing.Point(182, 19);
            this.LblTiempo.Name = "LblTiempo";
            this.LblTiempo.Size = new System.Drawing.Size(45, 13);
            this.LblTiempo.TabIndex = 20;
            this.LblTiempo.Text = "Tiempo:";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(177, 222);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 19;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(233, 42);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(100, 23);
            this.BtnBorrar.TabIndex = 18;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // LtbArregloOrdenadoMN
            // 
            this.LtbArregloOrdenadoMN.FormattingEnabled = true;
            this.LtbArregloOrdenadoMN.Location = new System.Drawing.Point(233, 77);
            this.LtbArregloOrdenadoMN.Name = "LtbArregloOrdenadoMN";
            this.LtbArregloOrdenadoMN.Size = new System.Drawing.Size(100, 134);
            this.LtbArregloOrdenadoMN.TabIndex = 17;
            // 
            // LtbArregloOrdenado
            // 
            this.LtbArregloOrdenado.FormattingEnabled = true;
            this.LtbArregloOrdenado.Location = new System.Drawing.Point(127, 77);
            this.LtbArregloOrdenado.Name = "LtbArregloOrdenado";
            this.LtbArregloOrdenado.Size = new System.Drawing.Size(100, 134);
            this.LtbArregloOrdenado.TabIndex = 16;
            // 
            // LtbArregloAleatorio
            // 
            this.LtbArregloAleatorio.FormattingEnabled = true;
            this.LtbArregloAleatorio.Location = new System.Drawing.Point(21, 77);
            this.LtbArregloAleatorio.Name = "LtbArregloAleatorio";
            this.LtbArregloAleatorio.Size = new System.Drawing.Size(100, 134);
            this.LtbArregloAleatorio.TabIndex = 15;
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Location = new System.Drawing.Point(127, 42);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(100, 23);
            this.BtnIniciar.TabIndex = 14;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // TxtTamaño
            // 
            this.TxtTamaño.Location = new System.Drawing.Point(21, 42);
            this.TxtTamaño.Name = "TxtTamaño";
            this.TxtTamaño.Size = new System.Drawing.Size(100, 20);
            this.TxtTamaño.TabIndex = 13;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(258, 222);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 22;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmRadix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 257);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.TxtTiempo);
            this.Controls.Add(this.LblTiempo);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.LtbArregloOrdenadoMN);
            this.Controls.Add(this.LtbArregloOrdenado);
            this.Controls.Add(this.LtbArregloAleatorio);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.TxtTamaño);
            this.Name = "frmRadix";
            this.Text = "frmRadix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTiempo;
        private System.Windows.Forms.Label LblTiempo;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.ListBox LtbArregloOrdenadoMN;
        private System.Windows.Forms.ListBox LtbArregloOrdenado;
        private System.Windows.Forms.ListBox LtbArregloAleatorio;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.TextBox TxtTamaño;
        private System.Windows.Forms.Button btnRegresar;
    }
}