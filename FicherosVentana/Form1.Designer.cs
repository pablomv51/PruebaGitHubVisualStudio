namespace FicherosVentana
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
            this.btncrear = new System.Windows.Forms.Button();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.btncarpeta = new System.Windows.Forms.Button();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.btnmover = new System.Windows.Forms.Button();
            this.btnBorrarCarpeta = new System.Windows.Forms.Button();
            this.btnBorrarFichero = new System.Windows.Forms.Button();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.txtBox4 = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.txtBox5 = new System.Windows.Forms.TextBox();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.txtBox6 = new System.Windows.Forms.TextBox();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.txtBox7 = new System.Windows.Forms.TextBox();
            this.grp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(388, 21);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(224, 70);
            this.btncrear.TabIndex = 0;
            this.btncrear.Text = "Crear fichero";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(142, 46);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(219, 23);
            this.txtbox1.TabIndex = 1;
            // 
            // btncarpeta
            // 
            this.btncarpeta.Location = new System.Drawing.Point(388, 127);
            this.btncarpeta.Name = "btncarpeta";
            this.btncarpeta.Size = new System.Drawing.Size(224, 70);
            this.btncarpeta.TabIndex = 2;
            this.btncarpeta.Text = "Crear carpeta";
            this.btncarpeta.UseVisualStyleBackColor = true;
            this.btncarpeta.Click += new System.EventHandler(this.btncarpeta_Click);
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(142, 152);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(219, 23);
            this.txtBox2.TabIndex = 3;
            // 
            // btnmover
            // 
            this.btnmover.Location = new System.Drawing.Point(608, 84);
            this.btnmover.Name = "btnmover";
            this.btnmover.Size = new System.Drawing.Size(180, 47);
            this.btnmover.TabIndex = 4;
            this.btnmover.Text = "Mover fichero";
            this.btnmover.UseVisualStyleBackColor = true;
            this.btnmover.Click += new System.EventHandler(this.btnmover_Click);
            // 
            // btnBorrarCarpeta
            // 
            this.btnBorrarCarpeta.Location = new System.Drawing.Point(388, 329);
            this.btnBorrarCarpeta.Name = "btnBorrarCarpeta";
            this.btnBorrarCarpeta.Size = new System.Drawing.Size(224, 70);
            this.btnBorrarCarpeta.TabIndex = 6;
            this.btnBorrarCarpeta.Text = "Borrar carpeta";
            this.btnBorrarCarpeta.UseVisualStyleBackColor = true;
            this.btnBorrarCarpeta.Click += new System.EventHandler(this.btnBorrarCarpeta_Click);
            // 
            // btnBorrarFichero
            // 
            this.btnBorrarFichero.Location = new System.Drawing.Point(388, 223);
            this.btnBorrarFichero.Name = "btnBorrarFichero";
            this.btnBorrarFichero.Size = new System.Drawing.Size(224, 70);
            this.btnBorrarFichero.TabIndex = 5;
            this.btnBorrarFichero.Text = "Borrar fichero";
            this.btnBorrarFichero.UseVisualStyleBackColor = true;
            this.btnBorrarFichero.Click += new System.EventHandler(this.btnBorrarFichero_Click);
            // 
            // txtBox3
            // 
            this.txtBox3.Location = new System.Drawing.Point(142, 248);
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(219, 23);
            this.txtBox3.TabIndex = 7;
            // 
            // txtBox4
            // 
            this.txtBox4.Location = new System.Drawing.Point(142, 354);
            this.txtBox4.Name = "txtBox4";
            this.txtBox4.Size = new System.Drawing.Size(219, 23);
            this.txtBox4.TabIndex = 8;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(388, 444);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(224, 56);
            this.btnLeer.TabIndex = 10;
            this.btnLeer.Text = "Leer fichero";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // txtBox5
            // 
            this.txtBox5.Location = new System.Drawing.Point(142, 462);
            this.txtBox5.Name = "txtBox5";
            this.txtBox5.Size = new System.Drawing.Size(219, 23);
            this.txtBox5.TabIndex = 11;
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.ItemHeight = 15;
            this.lst1.Location = new System.Drawing.Point(608, 405);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(259, 139);
            this.lst1.TabIndex = 12;
            // 
            // txtBox6
            // 
            this.txtBox6.Location = new System.Drawing.Point(26, 50);
            this.txtBox6.Name = "txtBox6";
            this.txtBox6.Size = new System.Drawing.Size(219, 23);
            this.txtBox6.TabIndex = 13;
            this.txtBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.label2);
            this.grp1.Controls.Add(this.label1);
            this.grp1.Controls.Add(this.btnAñadir);
            this.grp1.Controls.Add(this.txtBox7);
            this.grp1.Controls.Add(this.txtBox6);
            this.grp1.Location = new System.Drawing.Point(126, 588);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(629, 200);
            this.grp1.TabIndex = 15;
            this.grp1.TabStop = false;
            this.grp1.Text = "Grabar fichero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "aqui introduce la línea a introducir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "aqui introduce el fichero a modificar";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(288, 68);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(224, 56);
            this.btnAñadir.TabIndex = 16;
            this.btnAñadir.Text = "Insertar linea ";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // txtBox7
            // 
            this.txtBox7.Location = new System.Drawing.Point(26, 127);
            this.txtBox7.Name = "txtBox7";
            this.txtBox7.Size = new System.Drawing.Size(219, 23);
            this.txtBox7.TabIndex = 15;
            this.txtBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 858);
            this.Controls.Add(this.grp1);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.txtBox5);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtBox4);
            this.Controls.Add(this.txtBox3);
            this.Controls.Add(this.btnBorrarCarpeta);
            this.Controls.Add(this.btnBorrarFichero);
            this.Controls.Add(this.btnmover);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.btncarpeta);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.btncrear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btncrear;
        private TextBox txtbox1;
        private Button btncarpeta;
        private TextBox txtBox2;
        private Button btnmover;
        private Button btnBorrarCarpeta;
        private Button btnBorrarFichero;
        private TextBox txtBox3;
        private TextBox txtBox4;
        private Button btnLeer;
        private TextBox txtBox5;
        private ListBox lst1;
        private TextBox txtBox6;
        private GroupBox grp1;
        private Button btnAñadir;
        private TextBox txtBox7;
        private Label label1;
        private Label label2;
    }
}