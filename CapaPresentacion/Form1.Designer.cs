namespace CapaPresentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picBox_Image = new System.Windows.Forms.PictureBox();
            this.btn_dxf = new System.Windows.Forms.Button();
            this.btn_image = new System.Windows.Forms.Button();
            this.txt_dxf = new System.Windows.Forms.TextBox();
            this.ts_contendor = new System.Windows.Forms.ToolStrip();
            this.tsbtn_undo = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_redo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtn_agregarTaladro = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_eliminarTaladro = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Image)).BeginInit();
            this.ts_contendor.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox_Image
            // 
            this.picBox_Image.Location = new System.Drawing.Point(12, 59);
            this.picBox_Image.Name = "picBox_Image";
            this.picBox_Image.Size = new System.Drawing.Size(300, 300);
            this.picBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Image.TabIndex = 0;
            this.picBox_Image.TabStop = false;
            // 
            // btn_dxf
            // 
            this.btn_dxf.Location = new System.Drawing.Point(418, 13);
            this.btn_dxf.Name = "btn_dxf";
            this.btn_dxf.Size = new System.Drawing.Size(165, 40);
            this.btn_dxf.TabIndex = 1;
            this.btn_dxf.Text = "Buscar DXF";
            this.btn_dxf.UseVisualStyleBackColor = true;
            this.btn_dxf.Click += new System.EventHandler(this.btn_dxf_Click);
            // 
            // btn_image
            // 
            this.btn_image.Location = new System.Drawing.Point(80, 13);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(165, 40);
            this.btn_image.TabIndex = 2;
            this.btn_image.Text = "Buscar Imagen";
            this.btn_image.UseVisualStyleBackColor = true;
            this.btn_image.Click += new System.EventHandler(this.btn_image_Click);
            // 
            // txt_dxf
            // 
            this.txt_dxf.Location = new System.Drawing.Point(350, 59);
            this.txt_dxf.Multiline = true;
            this.txt_dxf.Name = "txt_dxf";
            this.txt_dxf.Size = new System.Drawing.Size(300, 300);
            this.txt_dxf.TabIndex = 3;
            // 
            // ts_contendor
            // 
            this.ts_contendor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ts_contendor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts_contendor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_undo,
            this.tsbtn_redo,
            this.toolStripSeparator1,
            this.tsbtn_agregarTaladro,
            this.tsbtn_eliminarTaladro});
            this.ts_contendor.Location = new System.Drawing.Point(0, 394);
            this.ts_contendor.Name = "ts_contendor";
            this.ts_contendor.Size = new System.Drawing.Size(662, 27);
            this.ts_contendor.TabIndex = 4;
            this.ts_contendor.Text = "toolStrip1";
            // 
            // tsbtn_undo
            // 
            this.tsbtn_undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_undo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_undo.Image")));
            this.tsbtn_undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_undo.Name = "tsbtn_undo";
            this.tsbtn_undo.Size = new System.Drawing.Size(24, 24);
            this.tsbtn_undo.Text = "Undo (Ctrl + z)";
            this.tsbtn_undo.Click += new System.EventHandler(this.tsbtn_undo_Click);
            // 
            // tsbtn_redo
            // 
            this.tsbtn_redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_redo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_redo.Image")));
            this.tsbtn_redo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_redo.Name = "tsbtn_redo";
            this.tsbtn_redo.Size = new System.Drawing.Size(24, 24);
            this.tsbtn_redo.Text = "Redo (Ctrl + y)";
            this.tsbtn_redo.Click += new System.EventHandler(this.tsbtn_redo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbtn_agregarTaladro
            // 
            this.tsbtn_agregarTaladro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_agregarTaladro.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_agregarTaladro.Image")));
            this.tsbtn_agregarTaladro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_agregarTaladro.Name = "tsbtn_agregarTaladro";
            this.tsbtn_agregarTaladro.Size = new System.Drawing.Size(24, 24);
            this.tsbtn_agregarTaladro.Text = "Agregar Taladro";
            this.tsbtn_agregarTaladro.Click += new System.EventHandler(this.tsbtn_agregarTaladro_Click);
            // 
            // tsbtn_eliminarTaladro
            // 
            this.tsbtn_eliminarTaladro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_eliminarTaladro.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_eliminarTaladro.Image")));
            this.tsbtn_eliminarTaladro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_eliminarTaladro.Name = "tsbtn_eliminarTaladro";
            this.tsbtn_eliminarTaladro.Size = new System.Drawing.Size(24, 24);
            this.tsbtn_eliminarTaladro.Text = "Eliminar Taladro";
            this.tsbtn_eliminarTaladro.Click += new System.EventHandler(this.tsbtn_eliminarTaladro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 421);
            this.Controls.Add(this.ts_contendor);
            this.Controls.Add(this.txt_dxf);
            this.Controls.Add(this.btn_image);
            this.Controls.Add(this.btn_dxf);
            this.Controls.Add(this.picBox_Image);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Image)).EndInit();
            this.ts_contendor.ResumeLayout(false);
            this.ts_contendor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_Image;
        private System.Windows.Forms.Button btn_dxf;
        private System.Windows.Forms.Button btn_image;
        private System.Windows.Forms.TextBox txt_dxf;
        private System.Windows.Forms.ToolStrip ts_contendor;
        private System.Windows.Forms.ToolStripButton tsbtn_undo;
        private System.Windows.Forms.ToolStripButton tsbtn_redo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtn_agregarTaladro;
        private System.Windows.Forms.ToolStripButton tsbtn_eliminarTaladro;
    }
}

