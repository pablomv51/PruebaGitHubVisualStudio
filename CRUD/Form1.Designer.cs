namespace CRUD
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.GridViewPersonas = new System.Windows.Forms.DataGridView();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(88, 89);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(27, 15);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "DNI";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(88, 153);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(51, 15);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Nombre";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(88, 219);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(33, 15);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Edad";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(176, 86);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 23);
            this.txt1.TabIndex = 3;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(176, 145);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 23);
            this.txt2.TabIndex = 4;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(176, 211);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 23);
            this.txt3.TabIndex = 5;
            // 
            // GridViewPersonas
            // 
            this.GridViewPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewPersonas.Location = new System.Drawing.Point(88, 274);
            this.GridViewPersonas.Name = "GridViewPersonas";
            this.GridViewPersonas.RowTemplate.Height = 25;
            this.GridViewPersonas.Size = new System.Drawing.Size(615, 145);
            this.GridViewPersonas.TabIndex = 6;
            this.GridViewPersonas.SelectionChanged += new System.EventHandler(this.GridViewPersonas_SelectionChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(359, 113);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(110, 55);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "Añadir";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(505, 113);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(106, 54);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "Modificar";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(657, 113);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(97, 55);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "Borrar";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.GridViewPersonas);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private TextBox txt1;
        private TextBox txt2;
        private TextBox txt3;
        private DataGridView GridViewPersonas;
        private Button btn1;
        private Button btn2;
        private Button btn3;
    }
}