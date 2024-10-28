namespace NumerosParesVentanas
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
            this.btn1 = new System.Windows.Forms.Button();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(306, 86);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(191, 106);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "añadir numeros pares";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.ItemHeight = 15;
            this.lst1.Location = new System.Drawing.Point(466, 254);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(169, 139);
            this.lst1.TabIndex = 1;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(228, 274);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(152, 85);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "Elegir archivo a visualizar";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn1;
        private ListBox lst1;
        private Button btn2;
    }
}