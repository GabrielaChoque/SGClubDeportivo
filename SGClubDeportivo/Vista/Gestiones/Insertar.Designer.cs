
namespace SGClubDeportivo.Vista.Gestiones
{
    partial class Insertar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insertar));
            System.Windows.Forms.Label ci_jugadorLabel;
            System.Windows.Forms.Label nom_jugadorLabel;
            System.Windows.Forms.Label fecha_nacLabel;
            System.Windows.Forms.Label fecha_registroLabel;
            System.Windows.Forms.Label ci_secretariaLabel;
            System.Windows.Forms.Label id_categoriaLabel;
            this.bdClubDeportivoDataSet = new SGClubDeportivo.Data.BdClubDeportivoDataSet();
            this.jugadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jugadorTableAdapter = new SGClubDeportivo.Data.BdClubDeportivoDataSetTableAdapters.JugadorTableAdapter();
            this.tableAdapterManager = new SGClubDeportivo.Data.BdClubDeportivoDataSetTableAdapters.TableAdapterManager();
            this.jugadorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.jugadorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ci_jugadorTextBox = new System.Windows.Forms.TextBox();
            this.nom_jugadorTextBox = new System.Windows.Forms.TextBox();
            this.fecha_nacDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fecha_registroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ci_secretariaTextBox = new System.Windows.Forms.TextBox();
            this.id_categoriaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ci_jugadorLabel = new System.Windows.Forms.Label();
            nom_jugadorLabel = new System.Windows.Forms.Label();
            fecha_nacLabel = new System.Windows.Forms.Label();
            fecha_registroLabel = new System.Windows.Forms.Label();
            ci_secretariaLabel = new System.Windows.Forms.Label();
            id_categoriaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdClubDeportivoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingNavigator)).BeginInit();
            this.jugadorBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdClubDeportivoDataSet
            // 
            this.bdClubDeportivoDataSet.DataSetName = "BdClubDeportivoDataSet";
            this.bdClubDeportivoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jugadorBindingSource
            // 
            this.jugadorBindingSource.DataMember = "Jugador";
            this.jugadorBindingSource.DataSource = this.bdClubDeportivoDataSet;
            // 
            // jugadorTableAdapter
            // 
            this.jugadorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministradorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.HorarioTableAdapter = null;
            this.tableAdapterManager.JugadorTableAdapter = this.jugadorTableAdapter;
            this.tableAdapterManager.SecretariaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SGClubDeportivo.Data.BdClubDeportivoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // jugadorBindingNavigator
            // 
            this.jugadorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.jugadorBindingNavigator.BindingSource = this.jugadorBindingSource;
            this.jugadorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.jugadorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.jugadorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.jugadorBindingNavigatorSaveItem});
            this.jugadorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.jugadorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.jugadorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.jugadorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.jugadorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.jugadorBindingNavigator.Name = "jugadorBindingNavigator";
            this.jugadorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.jugadorBindingNavigator.Size = new System.Drawing.Size(381, 25);
            this.jugadorBindingNavigator.TabIndex = 0;
            this.jugadorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // jugadorBindingNavigatorSaveItem
            // 
            this.jugadorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.jugadorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("jugadorBindingNavigatorSaveItem.Image")));
            this.jugadorBindingNavigatorSaveItem.Name = "jugadorBindingNavigatorSaveItem";
            this.jugadorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.jugadorBindingNavigatorSaveItem.Text = "Guardar datos";
            this.jugadorBindingNavigatorSaveItem.Click += new System.EventHandler(this.jugadorBindingNavigatorSaveItem_Click);
            // 
            // ci_jugadorLabel
            // 
            ci_jugadorLabel.AutoSize = true;
            ci_jugadorLabel.Location = new System.Drawing.Point(55, 44);
            ci_jugadorLabel.Name = "ci_jugadorLabel";
            ci_jugadorLabel.Size = new System.Drawing.Size(56, 13);
            ci_jugadorLabel.TabIndex = 1;
            ci_jugadorLabel.Text = "ci jugador:";
            // 
            // ci_jugadorTextBox
            // 
            this.ci_jugadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadorBindingSource, "ci_jugador", true));
            this.ci_jugadorTextBox.Location = new System.Drawing.Point(135, 41);
            this.ci_jugadorTextBox.Name = "ci_jugadorTextBox";
            this.ci_jugadorTextBox.Size = new System.Drawing.Size(200, 20);
            this.ci_jugadorTextBox.TabIndex = 2;
            // 
            // nom_jugadorLabel
            // 
            nom_jugadorLabel.AutoSize = true;
            nom_jugadorLabel.Location = new System.Drawing.Point(55, 70);
            nom_jugadorLabel.Name = "nom_jugadorLabel";
            nom_jugadorLabel.Size = new System.Drawing.Size(68, 13);
            nom_jugadorLabel.TabIndex = 3;
            nom_jugadorLabel.Text = "nom jugador:";
            // 
            // nom_jugadorTextBox
            // 
            this.nom_jugadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadorBindingSource, "nom_jugador", true));
            this.nom_jugadorTextBox.Location = new System.Drawing.Point(135, 67);
            this.nom_jugadorTextBox.Name = "nom_jugadorTextBox";
            this.nom_jugadorTextBox.Size = new System.Drawing.Size(200, 20);
            this.nom_jugadorTextBox.TabIndex = 4;
            // 
            // fecha_nacLabel
            // 
            fecha_nacLabel.AutoSize = true;
            fecha_nacLabel.Location = new System.Drawing.Point(55, 97);
            fecha_nacLabel.Name = "fecha_nacLabel";
            fecha_nacLabel.Size = new System.Drawing.Size(58, 13);
            fecha_nacLabel.TabIndex = 5;
            fecha_nacLabel.Text = "fecha nac:";
            // 
            // fecha_nacDateTimePicker
            // 
            this.fecha_nacDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jugadorBindingSource, "fecha_nac", true));
            this.fecha_nacDateTimePicker.Location = new System.Drawing.Point(135, 93);
            this.fecha_nacDateTimePicker.Name = "fecha_nacDateTimePicker";
            this.fecha_nacDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_nacDateTimePicker.TabIndex = 6;
            // 
            // fecha_registroLabel
            // 
            fecha_registroLabel.AutoSize = true;
            fecha_registroLabel.Location = new System.Drawing.Point(55, 123);
            fecha_registroLabel.Name = "fecha_registroLabel";
            fecha_registroLabel.Size = new System.Drawing.Size(74, 13);
            fecha_registroLabel.TabIndex = 7;
            fecha_registroLabel.Text = "fecha registro:";
            // 
            // fecha_registroDateTimePicker
            // 
            this.fecha_registroDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jugadorBindingSource, "fecha_registro", true));
            this.fecha_registroDateTimePicker.Location = new System.Drawing.Point(135, 119);
            this.fecha_registroDateTimePicker.Name = "fecha_registroDateTimePicker";
            this.fecha_registroDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_registroDateTimePicker.TabIndex = 8;
            // 
            // ci_secretariaLabel
            // 
            ci_secretariaLabel.AutoSize = true;
            ci_secretariaLabel.Location = new System.Drawing.Point(55, 148);
            ci_secretariaLabel.Name = "ci_secretariaLabel";
            ci_secretariaLabel.Size = new System.Drawing.Size(67, 13);
            ci_secretariaLabel.TabIndex = 9;
            ci_secretariaLabel.Text = "ci secretaria:";
            // 
            // ci_secretariaTextBox
            // 
            this.ci_secretariaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadorBindingSource, "ci_secretaria", true));
            this.ci_secretariaTextBox.Location = new System.Drawing.Point(135, 145);
            this.ci_secretariaTextBox.Name = "ci_secretariaTextBox";
            this.ci_secretariaTextBox.Size = new System.Drawing.Size(200, 20);
            this.ci_secretariaTextBox.TabIndex = 10;
            // 
            // id_categoriaLabel
            // 
            id_categoriaLabel.AutoSize = true;
            id_categoriaLabel.Location = new System.Drawing.Point(55, 174);
            id_categoriaLabel.Name = "id_categoriaLabel";
            id_categoriaLabel.Size = new System.Drawing.Size(65, 13);
            id_categoriaLabel.TabIndex = 11;
            id_categoriaLabel.Text = "id categoria:";
            // 
            // id_categoriaTextBox
            // 
            this.id_categoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadorBindingSource, "id_categoria", true));
            this.id_categoriaTextBox.Location = new System.Drawing.Point(135, 171);
            this.id_categoriaTextBox.Name = "id_categoriaTextBox";
            this.id_categoriaTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_categoriaTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Insertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 289);
            this.Controls.Add(this.button1);
            this.Controls.Add(ci_jugadorLabel);
            this.Controls.Add(this.ci_jugadorTextBox);
            this.Controls.Add(nom_jugadorLabel);
            this.Controls.Add(this.nom_jugadorTextBox);
            this.Controls.Add(fecha_nacLabel);
            this.Controls.Add(this.fecha_nacDateTimePicker);
            this.Controls.Add(fecha_registroLabel);
            this.Controls.Add(this.fecha_registroDateTimePicker);
            this.Controls.Add(ci_secretariaLabel);
            this.Controls.Add(this.ci_secretariaTextBox);
            this.Controls.Add(id_categoriaLabel);
            this.Controls.Add(this.id_categoriaTextBox);
            this.Controls.Add(this.jugadorBindingNavigator);
            this.Name = "Insertar";
            this.Text = "Insertar";
            this.Load += new System.EventHandler(this.Insertar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdClubDeportivoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingNavigator)).EndInit();
            this.jugadorBindingNavigator.ResumeLayout(false);
            this.jugadorBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.BdClubDeportivoDataSet bdClubDeportivoDataSet;
        private System.Windows.Forms.BindingSource jugadorBindingSource;
        private Data.BdClubDeportivoDataSetTableAdapters.JugadorTableAdapter jugadorTableAdapter;
        private Data.BdClubDeportivoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator jugadorBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton jugadorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox ci_jugadorTextBox;
        private System.Windows.Forms.TextBox nom_jugadorTextBox;
        private System.Windows.Forms.DateTimePicker fecha_nacDateTimePicker;
        private System.Windows.Forms.DateTimePicker fecha_registroDateTimePicker;
        private System.Windows.Forms.TextBox ci_secretariaTextBox;
        private System.Windows.Forms.TextBox id_categoriaTextBox;
        private System.Windows.Forms.Button button1;
    }
}