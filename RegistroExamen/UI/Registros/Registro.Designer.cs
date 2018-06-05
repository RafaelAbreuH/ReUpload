namespace RegistroExamen.UI.Registros
{
    partial class Registro
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
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label grupoIdLabel;
            System.Windows.Forms.Label grupoLabel;
            System.Windows.Forms.Label integrantesLabel;
            this.GrupoIdUpDown = new System.Windows.Forms.NumericUpDown();
            this.Descripcion_textBox = new System.Windows.Forms.TextBox();
            this.GrupoUpDown = new System.Windows.Forms.NumericUpDown();
            this.CantidadUpDown = new System.Windows.Forms.NumericUpDown();
            this.IntegranteUpDown = new System.Windows.Forms.NumericUpDown();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            cantidadLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            grupoIdLabel = new System.Windows.Forms.Label();
            grupoLabel = new System.Windows.Forms.Label();
            integrantesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoIdUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegranteUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(39, 188);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 1;
            cantidadLabel.Text = "Cantidad:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(40, 65);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 2;
            descripcionLabel.Text = "Descripcion:";
            // 
            // grupoIdLabel
            // 
            grupoIdLabel.AutoSize = true;
            grupoIdLabel.Location = new System.Drawing.Point(40, 31);
            grupoIdLabel.Name = "grupoIdLabel";
            grupoIdLabel.Size = new System.Drawing.Size(51, 13);
            grupoIdLabel.TabIndex = 6;
            grupoIdLabel.Text = "Grupo Id:";
            // 
            // grupoLabel
            // 
            grupoLabel.AutoSize = true;
            grupoLabel.Location = new System.Drawing.Point(40, 150);
            grupoLabel.Name = "grupoLabel";
            grupoLabel.Size = new System.Drawing.Size(39, 13);
            grupoLabel.TabIndex = 8;
            grupoLabel.Text = "Grupo:";
            // 
            // integrantesLabel
            // 
            integrantesLabel.AutoSize = true;
            integrantesLabel.Location = new System.Drawing.Point(28, 228);
            integrantesLabel.Name = "integrantesLabel";
            integrantesLabel.Size = new System.Drawing.Size(63, 13);
            integrantesLabel.TabIndex = 10;
            integrantesLabel.Text = "Integrantes:";
            // 
            // GrupoIdUpDown
            // 
            this.GrupoIdUpDown.Location = new System.Drawing.Point(97, 29);
            this.GrupoIdUpDown.Name = "GrupoIdUpDown";
            this.GrupoIdUpDown.Size = new System.Drawing.Size(67, 20);
            this.GrupoIdUpDown.TabIndex = 11;
            // 
            // Descripcion_textBox
            // 
            this.Descripcion_textBox.Location = new System.Drawing.Point(112, 62);
            this.Descripcion_textBox.Multiline = true;
            this.Descripcion_textBox.Name = "Descripcion_textBox";
            this.Descripcion_textBox.Size = new System.Drawing.Size(240, 67);
            this.Descripcion_textBox.TabIndex = 12;
            // 
            // GrupoUpDown
            // 
            this.GrupoUpDown.Location = new System.Drawing.Point(97, 150);
            this.GrupoUpDown.Name = "GrupoUpDown";
            this.GrupoUpDown.Size = new System.Drawing.Size(79, 20);
            this.GrupoUpDown.TabIndex = 13;
            // 
            // CantidadUpDown
            // 
            this.CantidadUpDown.Location = new System.Drawing.Point(97, 188);
            this.CantidadUpDown.Name = "CantidadUpDown";
            this.CantidadUpDown.Size = new System.Drawing.Size(79, 20);
            this.CantidadUpDown.TabIndex = 14;
            // 
            // IntegranteUpDown
            // 
            this.IntegranteUpDown.Location = new System.Drawing.Point(97, 226);
            this.IntegranteUpDown.Name = "IntegranteUpDown";
            this.IntegranteUpDown.Size = new System.Drawing.Size(79, 20);
            this.IntegranteUpDown.TabIndex = 15;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Image = global::RegistroExamen.Properties.Resources.icons8_New_Copy_32;
            this.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Nuevo.Location = new System.Drawing.Point(67, 344);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(118, 54);
            this.btn_Nuevo.TabIndex = 16;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Image = global::RegistroExamen.Properties.Resources.icons8_Save_Close_32;
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.Location = new System.Drawing.Point(217, 344);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(126, 54);
            this.btn_Guardar.TabIndex = 17;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Image = global::RegistroExamen.Properties.Resources.icons8_Delete_Document_32;
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar.Location = new System.Drawing.Point(379, 344);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(126, 54);
            this.btn_Eliminar.TabIndex = 18;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Image = global::RegistroExamen.Properties.Resources.icons8_Search_16;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.Location = new System.Drawing.Point(190, 23);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(77, 29);
            this.btn_Buscar.TabIndex = 19;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.IntegranteUpDown);
            this.Controls.Add(this.CantidadUpDown);
            this.Controls.Add(this.GrupoUpDown);
            this.Controls.Add(this.Descripcion_textBox);
            this.Controls.Add(this.GrupoIdUpDown);
            this.Controls.Add(integrantesLabel);
            this.Controls.Add(grupoLabel);
            this.Controls.Add(grupoIdLabel);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(cantidadLabel);
            this.Name = "Registro";
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.GrupoIdUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegranteUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown GrupoIdUpDown;
        private System.Windows.Forms.TextBox Descripcion_textBox;
        private System.Windows.Forms.NumericUpDown GrupoUpDown;
        private System.Windows.Forms.NumericUpDown CantidadUpDown;
        private System.Windows.Forms.NumericUpDown IntegranteUpDown;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Buscar;
    }
}