namespace Presentacion
{
    partial class Rompecabezas
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
            this.MS_Barra = new System.Windows.Forms.MenuStrip();
            this.TSMI_Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_Lista = new System.Windows.Forms.Label();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.Btn_Detener = new System.Windows.Forms.Button();
            this.MS_Barra.SuspendLayout();
            this.SuspendLayout();
            // 
            // MS_Barra
            // 
            this.MS_Barra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Archivo});
            this.MS_Barra.Location = new System.Drawing.Point(0, 0);
            this.MS_Barra.Name = "MS_Barra";
            this.MS_Barra.Size = new System.Drawing.Size(800, 24);
            this.MS_Barra.TabIndex = 0;
            this.MS_Barra.Text = "menuStrip1";
            // 
            // TSMI_Archivo
            // 
            this.TSMI_Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Abrir});
            this.TSMI_Archivo.Name = "TSMI_Archivo";
            this.TSMI_Archivo.Size = new System.Drawing.Size(60, 20);
            this.TSMI_Archivo.Text = "Archivo";
            // 
            // TSMI_Abrir
            // 
            this.TSMI_Abrir.Name = "TSMI_Abrir";
            this.TSMI_Abrir.Size = new System.Drawing.Size(100, 22);
            this.TSMI_Abrir.Text = "Abrir";
            this.TSMI_Abrir.Click += new System.EventHandler(this.TSMI_Abrir_Click);
            // 
            // Lbl_Lista
            // 
            this.Lbl_Lista.AutoSize = true;
            this.Lbl_Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Lista.Location = new System.Drawing.Point(28, 416);
            this.Lbl_Lista.Name = "Lbl_Lista";
            this.Lbl_Lista.Size = new System.Drawing.Size(58, 25);
            this.Lbl_Lista.TabIndex = 1;
            this.Lbl_Lista.Text = "Lista";
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.Location = new System.Drawing.Point(676, 416);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(79, 25);
            this.Lbl_Estado.TabIndex = 2;
            this.Lbl_Estado.Text = "Estado";
            // 
            // Temporizador
            // 
            this.Temporizador.Interval = 1000;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // Btn_Detener
            // 
            this.Btn_Detener.Location = new System.Drawing.Point(33, 390);
            this.Btn_Detener.Name = "Btn_Detener";
            this.Btn_Detener.Size = new System.Drawing.Size(75, 23);
            this.Btn_Detener.TabIndex = 4;
            this.Btn_Detener.Text = "Detener";
            this.Btn_Detener.UseVisualStyleBackColor = true;
            this.Btn_Detener.Click += new System.EventHandler(this.Btn_Detener_Click);
            // 
            // Rompecabezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Detener);
            this.Controls.Add(this.Lbl_Estado);
            this.Controls.Add(this.Lbl_Lista);
            this.Controls.Add(this.MS_Barra);
            this.MainMenuStrip = this.MS_Barra;
            this.Name = "Rompecabezas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rompecabezas";
            this.MS_Barra.ResumeLayout(false);
            this.MS_Barra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS_Barra;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Archivo;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Abrir;
        private System.Windows.Forms.Label Lbl_Lista;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.Button Btn_Detener;
    }
}