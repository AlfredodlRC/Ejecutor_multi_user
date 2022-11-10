namespace Ejecutor_multi_user
{
    partial class Formulario
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TBComando = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEjecucion = new System.Windows.Forms.Button();
            this.TBResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbUsuario = new System.Windows.Forms.TextBox();
            this.TBContrasenya = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TBResultado);
            this.tabPage1.Controls.Add(this.BtnEjecucion);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TBComando);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(822, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Comando";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TBContrasenya);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.TbUsuario);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(822, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Usuario";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(822, 418);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Parametros";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TBComando
            // 
            this.TBComando.Location = new System.Drawing.Point(113, 40);
            this.TBComando.Name = "TBComando";
            this.TBComando.Size = new System.Drawing.Size(683, 27);
            this.TBComando.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Comando :";
            // 
            // BtnEjecucion
            // 
            this.BtnEjecucion.Location = new System.Drawing.Point(364, 111);
            this.BtnEjecucion.Name = "BtnEjecucion";
            this.BtnEjecucion.Size = new System.Drawing.Size(94, 29);
            this.BtnEjecucion.TabIndex = 2;
            this.BtnEjecucion.Text = "Ejecutar";
            this.BtnEjecucion.UseVisualStyleBackColor = true;
            this.BtnEjecucion.Click += new System.EventHandler(this.BtnEjecucion_Click);
            // 
            // TBResultado
            // 
            this.TBResultado.Location = new System.Drawing.Point(10, 180);
            this.TBResultado.Multiline = true;
            this.TBResultado.Name = "TBResultado";
            this.TBResultado.Size = new System.Drawing.Size(800, 226);
            this.TBResultado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuario :";
            // 
            // TbUsuario
            // 
            this.TbUsuario.Location = new System.Drawing.Point(243, 172);
            this.TbUsuario.Name = "TbUsuario";
            this.TbUsuario.Size = new System.Drawing.Size(454, 27);
            this.TbUsuario.TabIndex = 4;
            // 
            // TBContrasenya
            // 
            this.TBContrasenya.Location = new System.Drawing.Point(243, 221);
            this.TBContrasenya.Name = "TBContrasenya";
            this.TBContrasenya.Size = new System.Drawing.Size(454, 27);
            this.TBContrasenya.TabIndex = 6;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 449);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Formulario";
            this.Text = "Ejecutor multiusuario";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox TBResultado;
        private Button BtnEjecucion;
        private Label label1;
        private TextBox TBComando;
        private TabPage tabPage2;
        private MaskedTextBox TBContrasenya;
        private Label label3;
        private TextBox TbUsuario;
        private Label label2;
        private TabPage tabPage3;
    }
}