namespace LigaVentanas
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.GridClasificacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridClasificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(513, 85);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(263, 15);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "¿De qué jornada deseas ver los resultados? (1-10)";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(513, 115);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(194, 23);
            this.txt1.TabIndex = 2;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(513, 167);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(178, 95);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Mostrar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.ItemHeight = 15;
            this.lst1.Location = new System.Drawing.Point(149, 63);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(273, 199);
            this.lst1.TabIndex = 4;
            // 
            // GridClasificacion
            // 
            this.GridClasificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridClasificacion.Location = new System.Drawing.Point(149, 307);
            this.GridClasificacion.Name = "GridClasificacion";
            this.GridClasificacion.RowTemplate.Height = 25;
            this.GridClasificacion.Size = new System.Drawing.Size(1082, 373);
            this.GridClasificacion.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 995);
            this.Controls.Add(this.GridClasificacion);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridClasificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl1;
        private TextBox txt1;
        private Button btn1;
        private ListBox lst1;
        private DataGridView GridClasificacion;
    }
}