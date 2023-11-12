namespace FrmView
{
    partial class FrmPpal
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
            btnTurnos = new Button();
            btnCanchas = new Button();
            btnAdministradores = new Button();
            SuspendLayout();
            // 
            // btnTurnos
            // 
            btnTurnos.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTurnos.Location = new Point(110, 37);
            btnTurnos.Name = "btnTurnos";
            btnTurnos.Size = new Size(298, 65);
            btnTurnos.TabIndex = 0;
            btnTurnos.Text = "Turnos";
            btnTurnos.UseVisualStyleBackColor = true;
            btnTurnos.Click += btnTurnos_Click;
            // 
            // btnCanchas
            // 
            btnCanchas.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCanchas.Location = new Point(112, 124);
            btnCanchas.Name = "btnCanchas";
            btnCanchas.Size = new Size(298, 65);
            btnCanchas.TabIndex = 1;
            btnCanchas.Text = "Canchas";
            btnCanchas.UseVisualStyleBackColor = true;
            // 
            // btnAdministradores
            // 
            btnAdministradores.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdministradores.Location = new Point(112, 214);
            btnAdministradores.Name = "btnAdministradores";
            btnAdministradores.Size = new Size(298, 65);
            btnAdministradores.TabIndex = 2;
            btnAdministradores.Text = "Administradores";
            btnAdministradores.UseVisualStyleBackColor = true;
            // 
            // FrmPpal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 313);
            Controls.Add(btnAdministradores);
            Controls.Add(btnCanchas);
            Controls.Add(btnTurnos);
            Name = "FrmPpal";
            Text = "Administrador de Complejo";
            Load += FrmPpal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnTurnos;
        private Button btnCanchas;
        private Button btnAdministradores;
    }
}