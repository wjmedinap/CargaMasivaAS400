namespace CargaMasivaAs400
{
    partial class frmCargaMasivaAs400
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
            this.tblypPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.btnProcesarDatos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgrvPrincipal = new System.Windows.Forms.DataGridView();
            this.tblypPrincipal.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            this.pnlInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // tblypPrincipal
            // 
            this.tblypPrincipal.ColumnCount = 1;
            this.tblypPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblypPrincipal.Controls.Add(this.pnlSuperior, 0, 0);
            this.tblypPrincipal.Controls.Add(this.pnlInferior, 0, 2);
            this.tblypPrincipal.Controls.Add(this.dgrvPrincipal, 0, 1);
            this.tblypPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblypPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tblypPrincipal.Name = "tblypPrincipal";
            this.tblypPrincipal.RowCount = 3;
            this.tblypPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblypPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblypPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblypPrincipal.Size = new System.Drawing.Size(1077, 673);
            this.tblypPrincipal.TabIndex = 0;
            this.tblypPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Controls.Add(this.button1);
            this.pnlSuperior.Controls.Add(this.textBox1);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSuperior.Location = new System.Drawing.Point(3, 3);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1071, 61);
            this.pnlSuperior.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cargar Base Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1071, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pnlInferior
            // 
            this.pnlInferior.Controls.Add(this.btnProcesarDatos);
            this.pnlInferior.Controls.Add(this.btnSalir);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInferior.Location = new System.Drawing.Point(3, 608);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(1071, 62);
            this.pnlInferior.TabIndex = 1;
            this.pnlInferior.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInferior_Paint);
            // 
            // btnProcesarDatos
            // 
            this.btnProcesarDatos.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnProcesarDatos.Location = new System.Drawing.Point(757, 0);
            this.btnProcesarDatos.Name = "btnProcesarDatos";
            this.btnProcesarDatos.Size = new System.Drawing.Size(157, 62);
            this.btnProcesarDatos.TabIndex = 1;
            this.btnProcesarDatos.Text = "Cargar Datos As400";
            this.btnProcesarDatos.UseVisualStyleBackColor = true;
            this.btnProcesarDatos.Click += new System.EventHandler(this.btnProcesarDatos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.Location = new System.Drawing.Point(914, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(157, 62);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgrvPrincipal
            // 
            this.dgrvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrvPrincipal.Location = new System.Drawing.Point(3, 70);
            this.dgrvPrincipal.Name = "dgrvPrincipal";
            this.dgrvPrincipal.RowHeadersWidth = 62;
            this.dgrvPrincipal.RowTemplate.Height = 33;
            this.dgrvPrincipal.Size = new System.Drawing.Size(1071, 532);
            this.dgrvPrincipal.TabIndex = 2;
            // 
            // frmCargaMasivaAs400
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1077, 673);
            this.Controls.Add(this.tblypPrincipal);
            this.Name = "frmCargaMasivaAs400";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga Masiva Archivos As400";
            this.Load += new System.EventHandler(this.frmCargaMasivaAs400_Load);
            this.tblypPrincipal.ResumeLayout(false);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.pnlInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblypPrincipal;
        private Panel pnlSuperior;
        private Panel pnlInferior;
        private DataGridView dgrvPrincipal;
        private Button btnProcesarDatos;
        private Button btnSalir;
        private Button button1;
        private TextBox textBox1;
    }
}