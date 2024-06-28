namespace facturaWindowsForm
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
            dataGridView1 = new DataGridView();
            ITEM = new DataGridViewTextBoxColumn();
            CANTIDAD = new DataGridViewTextBoxColumn();
            DESCRIPCION = new DataGridViewTextBoxColumn();
            PU = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            btnguardar = new Button();
            btnguardar1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ITEM, CANTIDAD, DESCRIPCION, PU });
            dataGridView1.Location = new Point(55, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1103, 225);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ITEM
            // 
            ITEM.HeaderText = "ITEM";
            ITEM.MinimumWidth = 8;
            ITEM.Name = "ITEM";
            ITEM.Width = 150;
            // 
            // CANTIDAD
            // 
            CANTIDAD.HeaderText = "CANTIDAD";
            CANTIDAD.MinimumWidth = 8;
            CANTIDAD.Name = "CANTIDAD";
            CANTIDAD.Width = 150;
            // 
            // DESCRIPCION
            // 
            DESCRIPCION.HeaderText = "DESCRIPCION";
            DESCRIPCION.MinimumWidth = 8;
            DESCRIPCION.Name = "DESCRIPCION";
            DESCRIPCION.Width = 150;
            // 
            // PU
            // 
            PU.HeaderText = "PU";
            PU.MinimumWidth = 8;
            PU.Name = "PU";
            PU.Width = 150;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(55, 351);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(1103, 225);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(0, 0);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(75, 23);
            btnguardar.TabIndex = 0;
            // 
            // btnguardar1
            // 
            btnguardar1.Location = new Point(515, 620);
            btnguardar1.Name = "btnguardar1";
            btnguardar1.Size = new Size(112, 34);
            btnguardar1.TabIndex = 2;
            btnguardar1.Text = "GUARDAR";
            btnguardar1.UseVisualStyleBackColor = true;
            btnguardar1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1231, 806);
            Controls.Add(btnguardar1);
            Controls.Add(btnguardar);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn ITEM;
        private DataGridViewTextBoxColumn CANTIDAD;
        private DataGridViewTextBoxColumn DESCRIPCION;
        private DataGridViewTextBoxColumn PU;
        private Button btnguardar;
        private Button btnguardar1;
    }
}
