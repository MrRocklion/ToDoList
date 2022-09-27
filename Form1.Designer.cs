namespace ToDoList
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.asuntoTxt = new System.Windows.Forms.TextBox();
            this.estadoBox = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.listaTareasDataSet = new ToDoList.ListaTareasDataSet();
            this.tareasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tareasTableAdapter = new ToDoList.ListaTareasDataSetTableAdapters.TareasTableAdapter();
            this.btnActualizar = new MaterialSkin.Controls.MaterialButton();
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.tareaTxt = new MaterialSkin.Controls.MaterialTextBox2();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnEliminar = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.listaTareasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareasBindingSource)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(11, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(56, 164);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectionChange);
            // 
            // asuntoTxt
            // 
            this.asuntoTxt.Location = new System.Drawing.Point(87, 96);
            this.asuntoTxt.Name = "asuntoTxt";
            this.asuntoTxt.Size = new System.Drawing.Size(227, 22);
            this.asuntoTxt.TabIndex = 7;
            // 
            // estadoBox
            // 
            this.estadoBox.FormattingEnabled = true;
            this.estadoBox.Items.AddRange(new object[] {
            "Solventado",
            "Pendiente"});
            this.estadoBox.Location = new System.Drawing.Point(87, 181);
            this.estadoBox.Name = "estadoBox";
            this.estadoBox.Size = new System.Drawing.Size(227, 24);
            this.estadoBox.TabIndex = 9;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(84, 61);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(55, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Asunto:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(28, 26);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(16, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "ID";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(93, 17);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(141, 19);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "Tarea Seleccionada";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(84, 143);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(54, 19);
            this.materialLabel4.TabIndex = 13;
            this.materialLabel4.Text = "Estado:";
            // 
            // listaTareasDataSet
            // 
            this.listaTareasDataSet.DataSetName = "ListaTareasDataSet";
            this.listaTareasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tareasBindingSource
            // 
            this.tareasBindingSource.DataMember = "Tareas";
            this.tareasBindingSource.DataSource = this.listaTareasDataSet;
            // 
            // tareasTableAdapter
            // 
            this.tareasTableAdapter.ClearBeforeFill = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.HighEmphasis = true;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(87, 236);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizar.Size = new System.Drawing.Size(109, 36);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizar.UseAccentColor = false;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Depth = 0;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImageList = this.imageList1;
            this.tabControl.Location = new System.Drawing.Point(3, 64);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(333, 327);
            this.tabControl.TabIndex = 16;
            this.tabControl.TabIndexChanged += new System.EventHandler(this.tabControl_Changed);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnEliminar);
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Controls.Add(this.materialLabel2);
            this.tabPage3.Controls.Add(this.materialLabel3);
            this.tabPage3.Controls.Add(this.btnActualizar);
            this.tabPage3.Controls.Add(this.materialLabel1);
            this.tabPage3.Controls.Add(this.asuntoTxt);
            this.tabPage3.Controls.Add(this.estadoBox);
            this.tabPage3.Controls.Add(this.materialLabel4);
            this.tabPage3.ImageKey = "tasks.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(325, 284);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Lista de Tareas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.materialLabel5);
            this.tabPage4.Controls.Add(this.btnAgregar);
            this.tabPage4.Controls.Add(this.tareaTxt);
            this.tabPage4.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPage4.ImageKey = "task.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(325, 284);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Agregar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(87, 38);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(139, 19);
            this.materialLabel5.TabIndex = 2;
            this.materialLabel5.Text = "Asunto de La Tarea";
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(115, 194);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(88, 36);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "agregar";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tareaTxt
            // 
            this.tareaTxt.AnimateReadOnly = false;
            this.tareaTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tareaTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tareaTxt.Depth = 0;
            this.tareaTxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tareaTxt.HideSelection = true;
            this.tareaTxt.LeadingIcon = null;
            this.tareaTxt.Location = new System.Drawing.Point(29, 96);
            this.tareaTxt.MaxLength = 32767;
            this.tareaTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.tareaTxt.Name = "tareaTxt";
            this.tareaTxt.PasswordChar = '\0';
            this.tareaTxt.PrefixSuffixText = null;
            this.tareaTxt.ReadOnly = false;
            this.tareaTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tareaTxt.SelectedText = "";
            this.tareaTxt.SelectionLength = 0;
            this.tareaTxt.SelectionStart = 0;
            this.tareaTxt.ShortcutsEnabled = true;
            this.tareaTxt.Size = new System.Drawing.Size(266, 48);
            this.tareaTxt.TabIndex = 0;
            this.tareaTxt.TabStop = false;
            this.tareaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tareaTxt.TrailingIcon = null;
            this.tareaTxt.UseSystemPasswordChar = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "dashboard.png");
            this.imageList1.Images.SetKeyName(1, "salir.png");
            this.imageList1.Images.SetKeyName(2, "settings.png");
            this.imageList1.Images.SetKeyName(3, "task.png");
            this.imageList1.Images.SetKeyName(4, "tasks.png");
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.HighEmphasis = true;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(226, 236);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminar.Size = new System.Drawing.Size(88, 36);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminar.UseAccentColor = false;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(339, 394);
            this.Controls.Add(this.tabControl);
            this.DrawerTabControl = this.tabControl;
            this.Name = "Form1";
            this.Text = "To Do List SQL server";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaTareasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareasBindingSource)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox asuntoTxt;
        private System.Windows.Forms.ComboBox estadoBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private ListaTareasDataSet listaTareasDataSet;
        private System.Windows.Forms.BindingSource tareasBindingSource;
        private ListaTareasDataSetTableAdapters.TareasTableAdapter tareasTableAdapter;
        private MaterialSkin.Controls.MaterialButton btnActualizar;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialTextBox2 tareaTxt;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
    }
}

