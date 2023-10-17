namespace Presentacion
{
    partial class Rompe_Cabeza
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
            this.Lbl_Temporizador = new System.Windows.Forms.Label();
            this.Btn_Detener = new System.Windows.Forms.Button();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
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
            this.TSMI_Abrir.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Abrir.Text = "Abrir";
            this.TSMI_Abrir.Click += new System.EventHandler(this.OpenFileEvent);
            // 
            // Lbl_Lista
            // 
            this.Lbl_Lista.AutoSize = true;
            this.Lbl_Lista.BackColor = System.Drawing.Color.RoyalBlue;
            this.Lbl_Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Lista.Location = new System.Drawing.Point(15, 407);
            this.Lbl_Lista.Name = "Lbl_Lista";
            this.Lbl_Lista.Size = new System.Drawing.Size(58, 25);
            this.Lbl_Lista.TabIndex = 1;
            this.Lbl_Lista.Text = "Lista";
            this.Lbl_Lista.Visible = false;
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.BackColor = System.Drawing.Color.Plum;
            this.Lbl_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.Location = new System.Drawing.Point(699, 406);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(79, 25);
            this.Lbl_Estado.TabIndex = 2;
            this.Lbl_Estado.Text = "Estado";
            this.Lbl_Estado.Visible = false;
            // 
            // Lbl_Temporizador
            // 
            this.Lbl_Temporizador.AutoSize = true;
            this.Lbl_Temporizador.BackColor = System.Drawing.Color.RoyalBlue;
            this.Lbl_Temporizador.Location = new System.Drawing.Point(31, 203);
            this.Lbl_Temporizador.Name = "Lbl_Temporizador";
            this.Lbl_Temporizador.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Temporizador.TabIndex = 3;
            this.Lbl_Temporizador.Text = "label3";
            // 
            // Btn_Detener
            // 
            this.Btn_Detener.Enabled = false;
            this.Btn_Detener.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Detener.Location = new System.Drawing.Point(12, 365);
            this.Btn_Detener.Name = "Btn_Detener";
            this.Btn_Detener.Size = new System.Drawing.Size(83, 29);
            this.Btn_Detener.TabIndex = 4;
            this.Btn_Detener.Text = "Detener";
            this.Btn_Detener.UseVisualStyleBackColor = true;
            this.Btn_Detener.Click += new System.EventHandler(this.Btn_Detener_Click);
            // 
            // Temporizador
            // 
            this.Temporizador.Interval = 1000;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // Rompe_Cabeza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.Fondo_Rompecabezas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Detener);
            this.Controls.Add(this.Lbl_Temporizador);
            this.Controls.Add(this.Lbl_Estado);
            this.Controls.Add(this.Lbl_Lista);
            this.Controls.Add(this.MS_Barra);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.MS_Barra;
            this.Name = "Rompe_Cabeza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rompe_Cabeza";
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
        private System.Windows.Forms.Label Lbl_Temporizador;
        private System.Windows.Forms.Button Btn_Detener;
        private System.Windows.Forms.Timer Temporizador;
    }
}