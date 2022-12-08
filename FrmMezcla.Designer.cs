namespace Conjunto_Programas_Estructura_Datos
{
    partial class FrmMezcla
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
            this.lvwMostar = new System.Windows.Forms.ListView();
            this.lvwOrdenado = new System.Windows.Forms.ListView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnRecAsc = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtElementos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRDescendenteDirecta = new System.Windows.Forms.Button();
            this.btnRAscendenteDirecta = new System.Windows.Forms.Button();
            this.lblEstadisticaNombre = new System.Windows.Forms.Label();
            this.lblStadistica = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvwMostar
            // 
            this.lvwMostar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvwMostar.HideSelection = false;
            this.lvwMostar.Location = new System.Drawing.Point(0, 0);
            this.lvwMostar.Name = "lvwMostar";
            this.lvwMostar.Size = new System.Drawing.Size(615, 58);
            this.lvwMostar.TabIndex = 0;
            this.lvwMostar.UseCompatibleStateImageBehavior = false;
            // 
            // lvwOrdenado
            // 
            this.lvwOrdenado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvwOrdenado.HideSelection = false;
            this.lvwOrdenado.Location = new System.Drawing.Point(0, 58);
            this.lvwOrdenado.Name = "lvwOrdenado";
            this.lvwOrdenado.Size = new System.Drawing.Size(615, 57);
            this.lvwOrdenado.TabIndex = 1;
            this.lvwOrdenado.UseCompatibleStateImageBehavior = false;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(356, 134);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(104, 23);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(246, 134);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(104, 23);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Recorrido Descendente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRecAsc
            // 
            this.btnRecAsc.Location = new System.Drawing.Point(12, 203);
            this.btnRecAsc.Name = "btnRecAsc";
            this.btnRecAsc.Size = new System.Drawing.Size(180, 23);
            this.btnRecAsc.TabIndex = 5;
            this.btnRecAsc.Text = "Recorrido Ascendente";
            this.btnRecAsc.UseVisualStyleBackColor = true;
            this.btnRecAsc.Click += new System.EventHandler(this.btnRecAsc_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(530, 246);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // txtElementos
            // 
            this.txtElementos.Location = new System.Drawing.Point(150, 134);
            this.txtElementos.Name = "txtElementos";
            this.txtElementos.Size = new System.Drawing.Size(68, 20);
            this.txtElementos.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "N Elementos:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(466, 134);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(85, 23);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mezcla Directa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mezcla Natural:";
            // 
            // btnRDescendenteDirecta
            // 
            this.btnRDescendenteDirecta.Location = new System.Drawing.Point(221, 232);
            this.btnRDescendenteDirecta.Name = "btnRDescendenteDirecta";
            this.btnRDescendenteDirecta.Size = new System.Drawing.Size(161, 23);
            this.btnRDescendenteDirecta.TabIndex = 18;
            this.btnRDescendenteDirecta.Text = "Recorrido Descendente";
            this.btnRDescendenteDirecta.UseVisualStyleBackColor = true;
            this.btnRDescendenteDirecta.Click += new System.EventHandler(this.btnRDescendenteDirecta_Click);
            // 
            // btnRAscendenteDirecta
            // 
            this.btnRAscendenteDirecta.Location = new System.Drawing.Point(221, 203);
            this.btnRAscendenteDirecta.Name = "btnRAscendenteDirecta";
            this.btnRAscendenteDirecta.Size = new System.Drawing.Size(161, 23);
            this.btnRAscendenteDirecta.TabIndex = 17;
            this.btnRAscendenteDirecta.Text = "Recorrido Ascendente";
            this.btnRAscendenteDirecta.UseVisualStyleBackColor = true;
            this.btnRAscendenteDirecta.Click += new System.EventHandler(this.btnRAscendenteDirecta_Click);
            // 
            // lblEstadisticaNombre
            // 
            this.lblEstadisticaNombre.AutoSize = true;
            this.lblEstadisticaNombre.Location = new System.Drawing.Point(431, 213);
            this.lblEstadisticaNombre.Name = "lblEstadisticaNombre";
            this.lblEstadisticaNombre.Size = new System.Drawing.Size(13, 13);
            this.lblEstadisticaNombre.TabIndex = 16;
            this.lblEstadisticaNombre.Text = "--";
            // 
            // lblStadistica
            // 
            this.lblStadistica.AutoSize = true;
            this.lblStadistica.Font = new System.Drawing.Font("Playbill", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStadistica.Location = new System.Drawing.Point(412, 173);
            this.lblStadistica.Name = "lblStadistica";
            this.lblStadistica.Size = new System.Drawing.Size(32, 40);
            this.lblStadistica.TabIndex = 15;
            this.lblStadistica.Text = "---";
            // 
            // FrmMezcla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 281);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRDescendenteDirecta);
            this.Controls.Add(this.btnRAscendenteDirecta);
            this.Controls.Add(this.lblEstadisticaNombre);
            this.Controls.Add(this.lblStadistica);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtElementos);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnRecAsc);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lvwOrdenado);
            this.Controls.Add(this.lvwMostar);
            this.Name = "FrmMezcla";
            this.Text = "FrmMezcla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwMostar;
        private System.Windows.Forms.ListView lvwOrdenado;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnRecAsc;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtElementos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRDescendenteDirecta;
        private System.Windows.Forms.Button btnRAscendenteDirecta;
        private System.Windows.Forms.Label lblEstadisticaNombre;
        private System.Windows.Forms.Label lblStadistica;
    }
}