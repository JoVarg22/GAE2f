namespace GAE2F
{
    partial class Sitios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sitios));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Regresar = new System.Windows.Forms.Button();
            this.gAE2FDataSet = new GAE2F.GAE2FDataSet();
            this.sitioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sitioTableAdapter = new GAE2F.GAE2FDataSetTableAdapters.SitioTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDSitioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sitioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sitioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gAE2FDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sitioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sitioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(47, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID de sitio:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(47, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de sitio:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(193, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(462, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(462, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Regresar
            // 
            this.Regresar.BackColor = System.Drawing.Color.DodgerBlue;
            this.Regresar.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regresar.Location = new System.Drawing.Point(464, 219);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(87, 37);
            this.Regresar.TabIndex = 6;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = false;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // gAE2FDataSet
            // 
            this.gAE2FDataSet.DataSetName = "GAE2FDataSet";
            this.gAE2FDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sitioBindingSource
            // 
            this.sitioBindingSource.DataMember = "Sitio";
            this.sitioBindingSource.DataSource = this.gAE2FDataSet;
            // 
            // sitioTableAdapter
            // 
            this.sitioTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSitioDataGridViewTextBoxColumn,
            this.sitioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sitioBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(155, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // iDSitioDataGridViewTextBoxColumn
            // 
            this.iDSitioDataGridViewTextBoxColumn.DataPropertyName = "ID_Sitio";
            this.iDSitioDataGridViewTextBoxColumn.HeaderText = "ID_Sitio";
            this.iDSitioDataGridViewTextBoxColumn.Name = "iDSitioDataGridViewTextBoxColumn";
            // 
            // sitioDataGridViewTextBoxColumn
            // 
            this.sitioDataGridViewTextBoxColumn.DataPropertyName = "Sitio";
            this.sitioDataGridViewTextBoxColumn.HeaderText = "Sitio";
            this.sitioDataGridViewTextBoxColumn.Name = "sitioDataGridViewTextBoxColumn";
            // 
            // sitioBindingSource1
            // 
            this.sitioBindingSource1.DataMember = "Sitio";
            this.sitioBindingSource1.DataSource = this.gAE2FDataSet;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(23, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 51);
            this.button3.TabIndex = 10;
            this.button3.Text = "Actualizar Tabla";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(464, 176);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 37);
            this.button4.TabIndex = 11;
            this.button4.Text = "Modificar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Sitios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(607, 384);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Sitios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sitios";
            this.Load += new System.EventHandler(this.Sitios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gAE2FDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sitioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sitioBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Regresar;
        private GAE2FDataSet gAE2FDataSet;
        private System.Windows.Forms.BindingSource sitioBindingSource;
        private GAE2FDataSetTableAdapters.SitioTableAdapter sitioTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSitioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sitioBindingSource1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}