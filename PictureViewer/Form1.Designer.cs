
namespace PictureViewer
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.butonMostar = new System.Windows.Forms.Button();
            this.butonBorrar = new System.Windows.Forms.Button();
            this.butonFondo = new System.Windows.Forms.Button();
            this.butonCerrar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 278);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 244);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 253);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Ajustar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.butonMostar);
            this.flowLayoutPanel1.Controls.Add(this.butonBorrar);
            this.flowLayoutPanel1.Controls.Add(this.butonFondo);
            this.flowLayoutPanel1.Controls.Add(this.butonCerrar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(95, 253);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(457, 22);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // butonMostar
            // 
            this.butonMostar.Location = new System.Drawing.Point(352, 3);
            this.butonMostar.Name = "butonMostar";
            this.butonMostar.Size = new System.Drawing.Size(102, 23);
            this.butonMostar.TabIndex = 0;
            this.butonMostar.Text = "Mostar una imajen";
            this.butonMostar.UseVisualStyleBackColor = true;
            this.butonMostar.Click += new System.EventHandler(this.butonMostar_Click);
            // 
            // butonBorrar
            // 
            this.butonBorrar.Location = new System.Drawing.Point(247, 3);
            this.butonBorrar.Name = "butonBorrar";
            this.butonBorrar.Size = new System.Drawing.Size(99, 23);
            this.butonBorrar.TabIndex = 1;
            this.butonBorrar.Text = "Borrar una imajen ";
            this.butonBorrar.UseVisualStyleBackColor = true;
            this.butonBorrar.Click += new System.EventHandler(this.butonBorrar_Click);
            // 
            // butonFondo
            // 
            this.butonFondo.Location = new System.Drawing.Point(85, 3);
            this.butonFondo.Name = "butonFondo";
            this.butonFondo.Size = new System.Drawing.Size(156, 23);
            this.butonFondo.TabIndex = 2;
            this.butonFondo.Text = "Estrabeser color al fondo";
            this.butonFondo.UseVisualStyleBackColor = true;
            this.butonFondo.Click += new System.EventHandler(this.butonFondo_Click);
            // 
            // butonCerrar
            // 
            this.butonCerrar.Location = new System.Drawing.Point(4, 3);
            this.butonCerrar.Name = "butonCerrar";
            this.butonCerrar.Size = new System.Drawing.Size(75, 23);
            this.butonCerrar.TabIndex = 3;
            this.butonCerrar.Text = "Cerrar";
            this.butonCerrar.UseVisualStyleBackColor = true;
            this.butonCerrar.Click += new System.EventHandler(this.butonCerrar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Selecsionar un archibo de una imagen ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 278);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Visor imagenes";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button butonMostar;
        private System.Windows.Forms.Button butonBorrar;
        private System.Windows.Forms.Button butonFondo;
        private System.Windows.Forms.Button butonCerrar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

