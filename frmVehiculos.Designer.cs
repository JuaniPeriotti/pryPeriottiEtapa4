namespace pryPeriottiEtapa4
{
    partial class frmVehiculos
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
            cbVehiculos = new ComboBox();
            groupBox1 = new GroupBox();
            btnCrearVehiculo = new Button();
            Listar = new GroupBox();
            btnListar = new Button();
            lbVehiculos = new ListBox();
            groupBox1.SuspendLayout();
            Listar.SuspendLayout();
            SuspendLayout();
            // 
            // cbVehiculos
            // 
            cbVehiculos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVehiculos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbVehiculos.FormattingEnabled = true;
            cbVehiculos.Items.AddRange(new object[] { "Auto", "Moto", "Avión" });
            cbVehiculos.Location = new Point(6, 22);
            cbVehiculos.Name = "cbVehiculos";
            cbVehiculos.Size = new Size(297, 29);
            cbVehiculos.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCrearVehiculo);
            groupBox1.Controls.Add(cbVehiculos);
            groupBox1.Location = new Point(12, 380);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(552, 123);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de Vehículo";
            // 
            // btnCrearVehiculo
            // 
            btnCrearVehiculo.Location = new Point(309, 22);
            btnCrearVehiculo.Name = "btnCrearVehiculo";
            btnCrearVehiculo.Size = new Size(237, 95);
            btnCrearVehiculo.TabIndex = 1;
            btnCrearVehiculo.Text = "Crear Vehículo";
            btnCrearVehiculo.UseVisualStyleBackColor = true;
            btnCrearVehiculo.Click += btnCrearVehiculo_Click;
            // 
            // Listar
            // 
            Listar.Controls.Add(btnListar);
            Listar.Controls.Add(lbVehiculos);
            Listar.Location = new Point(352, 12);
            Listar.Name = "Listar";
            Listar.Size = new Size(212, 362);
            Listar.TabIndex = 2;
            Listar.TabStop = false;
            Listar.Text = "Listar Vehículos";
            // 
            // btnListar
            // 
            btnListar.Location = new Point(6, 257);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(199, 95);
            btnListar.TabIndex = 2;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // lbVehiculos
            // 
            lbVehiculos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbVehiculos.FormattingEnabled = true;
            lbVehiculos.ItemHeight = 28;
            lbVehiculos.Location = new Point(6, 22);
            lbVehiculos.Name = "lbVehiculos";
            lbVehiculos.Size = new Size(199, 228);
            lbVehiculos.TabIndex = 3;
            // 
            // frmVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 515);
            Controls.Add(Listar);
            Controls.Add(groupBox1);
            MaximumSize = new Size(592, 554);
            MinimumSize = new Size(592, 554);
            Name = "frmVehiculos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vehiculos";
            groupBox1.ResumeLayout(false);
            Listar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbVehiculos;
        private GroupBox groupBox1;
        private Button btnCrearVehiculo;
        private GroupBox Listar;
        private Button btnListar;
        private ListBox lbVehiculos;
    }
}
