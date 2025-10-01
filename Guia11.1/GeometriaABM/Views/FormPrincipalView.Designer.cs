namespace GeometriaABM
{
    partial class FormPrincipalView
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            rbRectangulo = new RadioButton();
            rbCirculo = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnLimpiar = new Button();
            btnActualizarListado = new Button();
            tbAncho = new TextBox();
            tbAlto = new TextBox();
            tbRadio = new TextBox();
            tbArea = new TextBox();
            groupBox3 = new GroupBox();
            btnConfirmarRegistro = new Button();
            btnEliminarRegistro = new Button();
            lsbResultado = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConfirmarRegistro);
            groupBox1.Controls.Add(tbArea);
            groupBox1.Controls.Add(tbRadio);
            groupBox1.Controls.Add(tbAlto);
            groupBox1.Controls.Add(tbAncho);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(529, 171);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la Figura";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbCirculo);
            groupBox2.Controls.Add(rbRectangulo);
            groupBox2.Location = new Point(17, 49);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(189, 100);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de Figura";
            // 
            // rbRectangulo
            // 
            rbRectangulo.AutoSize = true;
            rbRectangulo.Location = new Point(18, 31);
            rbRectangulo.Name = "rbRectangulo";
            rbRectangulo.Size = new Size(85, 19);
            rbRectangulo.TabIndex = 0;
            rbRectangulo.TabStop = true;
            rbRectangulo.Text = "Rectángulo";
            rbRectangulo.UseVisualStyleBackColor = true;
            // 
            // rbCirculo
            // 
            rbCirculo.AutoSize = true;
            rbCirculo.Location = new Point(18, 59);
            rbCirculo.Name = "rbCirculo";
            rbCirculo.Size = new Size(63, 19);
            rbCirculo.TabIndex = 1;
            rbCirculo.TabStop = true;
            rbCirculo.Text = "Círculo";
            rbCirculo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 19);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Ancho:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 55);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "Alto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(234, 94);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 3;
            label3.Text = "Radio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(234, 134);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 4;
            label4.Text = "Área:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(434, 22);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 54);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnActualizarListado
            // 
            btnActualizarListado.Location = new Point(434, 36);
            btnActualizarListado.Name = "btnActualizarListado";
            btnActualizarListado.Size = new Size(75, 54);
            btnActualizarListado.TabIndex = 6;
            btnActualizarListado.Text = "Actualizar Listado";
            btnActualizarListado.UseVisualStyleBackColor = true;
            // 
            // tbAncho
            // 
            tbAncho.Location = new Point(296, 19);
            tbAncho.Name = "tbAncho";
            tbAncho.Size = new Size(100, 23);
            tbAncho.TabIndex = 7;
            // 
            // tbAlto
            // 
            tbAlto.Location = new Point(296, 53);
            tbAlto.Name = "tbAlto";
            tbAlto.Size = new Size(100, 23);
            tbAlto.TabIndex = 8;
            // 
            // tbRadio
            // 
            tbRadio.Location = new Point(296, 90);
            tbRadio.Name = "tbRadio";
            tbRadio.Size = new Size(100, 23);
            tbRadio.TabIndex = 9;
            // 
            // tbArea
            // 
            tbArea.Location = new Point(296, 126);
            tbArea.Name = "tbArea";
            tbArea.Size = new Size(100, 23);
            tbArea.TabIndex = 10;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lsbResultado);
            groupBox3.Controls.Add(btnEliminarRegistro);
            groupBox3.Controls.Add(btnActualizarListado);
            groupBox3.Location = new Point(12, 189);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(529, 276);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Listado de Figuras";
            // 
            // btnConfirmarRegistro
            // 
            btnConfirmarRegistro.Location = new Point(434, 95);
            btnConfirmarRegistro.Name = "btnConfirmarRegistro";
            btnConfirmarRegistro.Size = new Size(75, 54);
            btnConfirmarRegistro.TabIndex = 11;
            btnConfirmarRegistro.Text = "Confirmar Registro";
            btnConfirmarRegistro.UseVisualStyleBackColor = true;
            // 
            // btnEliminarRegistro
            // 
            btnEliminarRegistro.Location = new Point(434, 196);
            btnEliminarRegistro.Name = "btnEliminarRegistro";
            btnEliminarRegistro.Size = new Size(75, 54);
            btnEliminarRegistro.TabIndex = 7;
            btnEliminarRegistro.Text = "Eliminar Registro";
            btnEliminarRegistro.UseVisualStyleBackColor = true;
            // 
            // lsbResultado
            // 
            lsbResultado.FormattingEnabled = true;
            lsbResultado.ItemHeight = 15;
            lsbResultado.Location = new Point(17, 36);
            lsbResultado.Name = "lsbResultado";
            lsbResultado.ScrollAlwaysVisible = true;
            lsbResultado.Size = new Size(379, 214);
            lsbResultado.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 477);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejemplo de ABM";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnConfirmarRegistro;
        private TextBox tbArea;
        private TextBox tbRadio;
        private TextBox tbAlto;
        private TextBox tbAncho;
        private Button btnLimpiar;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton rbCirculo;
        private RadioButton rbRectangulo;
        private Button btnActualizarListado;
        private GroupBox groupBox3;
        private ListBox lsbResultado;
        private Button btnEliminarRegistro;
    }
}
