namespace examen2parcial_DorianLanuza
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
            this.miTabla1 = new System.Windows.Forms.DataGridView();
            this.columnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miTabla2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnER = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.miTablaER = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.miTabla1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miTabla2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miTablaER)).BeginInit();
            this.SuspendLayout();
            // 
            // miTabla1
            // 
            this.miTabla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.miTabla1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNombre,
            this.columnSaldo});
            this.miTabla1.Location = new System.Drawing.Point(62, 137);
            this.miTabla1.Name = "miTabla1";
            this.miTabla1.RowTemplate.Height = 25;
            this.miTabla1.Size = new System.Drawing.Size(343, 287);
            this.miTabla1.TabIndex = 0;
            // 
            // columnNombre
            // 
            this.columnNombre.Frozen = true;
            this.columnNombre.HeaderText = "Nombre de la cuenta";
            this.columnNombre.Name = "columnNombre";
            this.columnNombre.Width = 150;
            // 
            // columnSaldo
            // 
            this.columnSaldo.Frozen = true;
            this.columnSaldo.HeaderText = "Balance";
            this.columnSaldo.Name = "columnSaldo";
            this.columnSaldo.Width = 150;
            // 
            // miTabla2
            // 
            this.miTabla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.miTabla2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.miTabla2.Location = new System.Drawing.Point(421, 137);
            this.miTabla2.Name = "miTabla2";
            this.miTabla2.RowTemplate.Height = 25;
            this.miTabla2.Size = new System.Drawing.Size(343, 287);
            this.miTabla2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre de la cuenta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Balance";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(536, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(459, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Saldo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "<Seleccionar>",
            "Ventas",
            "Inventario inicial",
            "Devolución sobre ventas",
            "Gasto de Compras",
            "Renta de Oficina",
            "Sueldo Gerente Aditivo",
            "Publicidad",
            "Otros Productos",
            "Compras",
            "Inventario Final",
            "Devolución sobre compras",
            "Renta de tienda",
            "Comisión Vendedores",
            "Servicio telefónico ventas",
            "Empaque de productos",
            "Otros gastos"});
            this.comboBox1.Location = new System.Drawing.Point(189, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(315, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 26);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Actualizar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(421, 105);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(90, 26);
            this.btnClean.TabIndex = 6;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnER
            // 
            this.btnER.Location = new System.Drawing.Point(294, 430);
            this.btnER.Name = "btnER";
            this.btnER.Size = new System.Drawing.Size(247, 26);
            this.btnER.TabIndex = 7;
            this.btnER.Text = "Calcular Estado de Resultado";
            this.btnER.UseVisualStyleBackColor = true;
            this.btnER.Click += new System.EventHandler(this.btnER_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(62, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre de la cuenta:";
            // 
            // miTablaER
            // 
            this.miTablaER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.miTablaER.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnOperation});
            this.miTablaER.Location = new System.Drawing.Point(827, 12);
            this.miTablaER.Name = "miTablaER";
            this.miTablaER.RowTemplate.Height = 25;
            this.miTablaER.Size = new System.Drawing.Size(345, 412);
            this.miTablaER.TabIndex = 9;
            // 
            // columnName
            // 
            this.columnName.Frozen = true;
            this.columnName.HeaderText = "Nombre Cuenta";
            this.columnName.Name = "columnName";
            this.columnName.Width = 150;
            // 
            // columnOperation
            // 
            this.columnOperation.Frozen = true;
            this.columnOperation.HeaderText = "Calculo";
            this.columnOperation.Name = "columnOperation";
            this.columnOperation.Width = 150;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(948, 430);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Guardar en Excel";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1215, 464);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.miTablaER);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnER);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.miTabla2);
            this.Controls.Add(this.miTabla1);
            this.Name = "Form1";
            this.Text = "Estado de resultado";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.miTabla1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miTabla2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miTablaER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView miTabla1;
        private DataGridViewTextBoxColumn columnNombre;
        private DataGridViewTextBoxColumn columnSaldo;
        private DataGridView miTabla2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Button btnAdd;
        private Button btnClean;
        private Button btnER;
        private Label label2;
        private DataGridView miTablaER;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnOperation;
        private Button btnSave;
    }
}