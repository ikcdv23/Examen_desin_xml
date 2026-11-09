namespace Examen_desin_xml
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblDescripcion = new Label();
            grpDatos = new GroupBox();
            lblDni = new Label();
            txtDni = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblEdad = new Label();
            txtEdad = new TextBox();
            btnAñadir = new Button();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            grpPersonas = new GroupBox();
            btnMostrarTodos = new Button();
            lstPersonas = new ListBox();
            grpDatos.SuspendLayout();
            grpPersonas.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 53, 78);
            lblTitulo.Location = new Point(24, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(286, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestor de personas";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(28, 68);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(274, 20);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Datos personales · Archivo personas.xml";
            // 
            // grpDatos
            // 
            grpDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpDatos.Controls.Add(lblDni);
            grpDatos.Controls.Add(txtDni);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(lblApellido);
            grpDatos.Controls.Add(txtApellido);
            grpDatos.Controls.Add(lblEdad);
            grpDatos.Controls.Add(txtEdad);
            grpDatos.Controls.Add(btnAñadir);
            grpDatos.Controls.Add(btnBuscar);
            grpDatos.Controls.Add(btnModificar);
            grpDatos.Controls.Add(btnEliminar);
            grpDatos.Controls.Add(btnLimpiar);
            grpDatos.Location = new Point(28, 110);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(326, 434);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos de la persona";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(20, 34);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(35, 20);
            lblDni.TabIndex = 0;
            lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(20, 58);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(286, 27);
            txtDni.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(20, 99);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(20, 123);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(286, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(20, 164);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(20, 188);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(286, 27);
            txtApellido.TabIndex = 2;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(20, 229);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(88, 20);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad (años)";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(20, 253);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 27);
            txtEdad.TabIndex = 3;
            // 
            // btnAñadir
            // 
            btnAñadir.BackColor = Color.FromArgb(30, 83, 130);
            btnAñadir.FlatStyle = FlatStyle.Flat;
            btnAñadir.ForeColor = Color.White;
            btnAñadir.Location = new Point(20, 302);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(138, 34);
            btnAñadir.TabIndex = 4;
            btnAñadir.Text = "&Añadir";
            btnAñadir.UseVisualStyleBackColor = false;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(168, 302);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(138, 34);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "&Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(20, 344);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(138, 34);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "&Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = Color.FromArgb(158, 43, 43);
            btnEliminar.Location = new Point(168, 344);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(138, 34);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(20, 386);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(286, 34);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "&Limpiar campos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // grpPersonas
            // 
            grpPersonas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpPersonas.Controls.Add(btnMostrarTodos);
            grpPersonas.Controls.Add(lstPersonas);
            grpPersonas.Location = new Point(374, 110);
            grpPersonas.Name = "grpPersonas";
            grpPersonas.Size = new Size(498, 434);
            grpPersonas.TabIndex = 1;
            grpPersonas.TabStop = false;
            grpPersonas.Text = "Personas registradas";
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMostrarTodos.Location = new Point(314, 386);
            btnMostrarTodos.Name = "btnMostrarTodos";
            btnMostrarTodos.Size = new Size(164, 34);
            btnMostrarTodos.TabIndex = 1;
            btnMostrarTodos.Text = "Mostrar &todos";
            btnMostrarTodos.UseVisualStyleBackColor = true;
            btnMostrarTodos.Click += btnMostrarTodos_Click;
            // 
            // lstPersonas
            // 
            lstPersonas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstPersonas.HorizontalScrollbar = true;
            lstPersonas.IntegralHeight = false;
            lstPersonas.Location = new Point(20, 34);
            lstPersonas.Name = "lstPersonas";
            lstPersonas.Size = new Size(458, 344);
            lstPersonas.TabIndex = 0;
            lstPersonas.SelectedIndexChanged += lstPersonas_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(900, 581);
            Controls.Add(lblTitulo);
            Controls.Add(lblDescripcion);
            Controls.Add(grpDatos);
            Controls.Add(grpPersonas);
            Font = new Font("Segoe UI", 11F);
            MinimumSize = new Size(850, 620);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor de personas · XML";
            Load += Form1_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            grpPersonas.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private Label lblDescripcion;
        private GroupBox grpDatos;
        private GroupBox grpPersonas;
        private ListBox lstPersonas;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblEdad;
        private TextBox txtEdad;
        private Button btnAñadir;
        private Button btnBuscar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnMostrarTodos;
    }
}
