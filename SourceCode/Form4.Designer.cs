using System.ComponentModel;

namespace parcialDos
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.tabF4 = new System.Windows.Forms.TabControl();
            this.tpPerfil = new System.Windows.Forms.TabPage();
            this.txtChangePass = new System.Windows.Forms.TextBox();
            this.lblChangePass = new System.Windows.Forms.Label();
            this.lblMyUsrnm = new System.Windows.Forms.Label();
            this.txtMyUsrnm = new System.Windows.Forms.TextBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.txtMyName = new System.Windows.Forms.TextBox();
            this.lblMyName = new System.Windows.Forms.Label();
            this.tpAddresses = new System.Windows.Forms.TabPage();
            this.lblDelAddress = new System.Windows.Forms.Label();
            this.cmbAddresses = new System.Windows.Forms.ComboBox();
            this.btnDelAddress = new System.Windows.Forms.Button();
            this.lblAddresses = new System.Windows.Forms.Label();
            this.cmbDelAddress = new System.Windows.Forms.ComboBox();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.lblAddAddress = new System.Windows.Forms.Label();
            this.txtAddAddress = new System.Windows.Forms.TextBox();
            this.tpOrders = new System.Windows.Forms.TabPage();
            this.cmbProOrder = new System.Windows.Forms.ComboBox();
            this.lblProOrder = new System.Windows.Forms.Label();
            this.cmbBusiOrder = new System.Windows.Forms.ComboBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.lblBusiOrder = new System.Windows.Forms.Label();
            this.cmbAddressOrder = new System.Windows.Forms.ComboBox();
            this.lblAddressOrder = new System.Windows.Forms.Label();
            this.dgvMisOrdenes = new System.Windows.Forms.DataGridView();
            this.tabF4.SuspendLayout();
            this.tpPerfil.SuspendLayout();
            this.tpAddresses.SuspendLayout();
            this.tpOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvMisOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabF4
            // 
            this.tabF4.Controls.Add(this.tpPerfil);
            this.tabF4.Controls.Add(this.tpAddresses);
            this.tabF4.Controls.Add(this.tpOrders);
            this.tabF4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabF4.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabF4.Location = new System.Drawing.Point(0, 0);
            this.tabF4.Name = "tabF4";
            this.tabF4.SelectedIndex = 0;
            this.tabF4.Size = new System.Drawing.Size(545, 450);
            this.tabF4.TabIndex = 1;
            // 
            // tpPerfil
            // 
            this.tpPerfil.Controls.Add(this.txtChangePass);
            this.tpPerfil.Controls.Add(this.lblChangePass);
            this.tpPerfil.Controls.Add(this.lblMyUsrnm);
            this.tpPerfil.Controls.Add(this.txtMyUsrnm);
            this.tpPerfil.Controls.Add(this.btnChangePass);
            this.tpPerfil.Controls.Add(this.txtMyName);
            this.tpPerfil.Controls.Add(this.lblMyName);
            this.tpPerfil.Location = new System.Drawing.Point(4, 32);
            this.tpPerfil.Name = "tpPerfil";
            this.tpPerfil.Padding = new System.Windows.Forms.Padding(3);
            this.tpPerfil.Size = new System.Drawing.Size(537, 414);
            this.tpPerfil.TabIndex = 1;
            this.tpPerfil.Text = "Mi Perfil";
            this.tpPerfil.UseVisualStyleBackColor = true;
            // 
            // txtChangePass
            // 
            this.txtChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtChangePass.Location = new System.Drawing.Point(173, 296);
            this.txtChangePass.Name = "txtChangePass";
            this.txtChangePass.Size = new System.Drawing.Size(204, 29);
            this.txtChangePass.TabIndex = 26;
            // 
            // lblChangePass
            // 
            this.lblChangePass.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblChangePass.Location = new System.Drawing.Point(173, 266);
            this.lblChangePass.Name = "lblChangePass";
            this.lblChangePass.Size = new System.Drawing.Size(201, 27);
            this.lblChangePass.TabIndex = 25;
            this.lblChangePass.Text = "Cambiar contraseña:";
            this.lblChangePass.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblMyUsrnm
            // 
            this.lblMyUsrnm.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblMyUsrnm.Location = new System.Drawing.Point(173, 146);
            this.lblMyUsrnm.Name = "lblMyUsrnm";
            this.lblMyUsrnm.Size = new System.Drawing.Size(200, 27);
            this.lblMyUsrnm.TabIndex = 24;
            this.lblMyUsrnm.Text = "Nombre de usuario:";
            this.lblMyUsrnm.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtMyUsrnm
            // 
            this.txtMyUsrnm.Location = new System.Drawing.Point(173, 176);
            this.txtMyUsrnm.Name = "txtMyUsrnm";
            this.txtMyUsrnm.ReadOnly = true;
            this.txtMyUsrnm.Size = new System.Drawing.Size(204, 31);
            this.txtMyUsrnm.TabIndex = 23;
            // 
            // btnChangePass
            // 
            this.btnChangePass.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnChangePass.Location = new System.Drawing.Point(221, 351);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(102, 32);
            this.btnChangePass.TabIndex = 22;
            this.btnChangePass.Text = "Cambiar";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // txtMyName
            // 
            this.txtMyName.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtMyName.Location = new System.Drawing.Point(173, 63);
            this.txtMyName.Name = "txtMyName";
            this.txtMyName.ReadOnly = true;
            this.txtMyName.Size = new System.Drawing.Size(204, 33);
            this.txtMyName.TabIndex = 18;
            // 
            // lblMyName
            // 
            this.lblMyName.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblMyName.Location = new System.Drawing.Point(173, 33);
            this.lblMyName.Name = "lblMyName";
            this.lblMyName.Size = new System.Drawing.Size(201, 27);
            this.lblMyName.TabIndex = 17;
            this.lblMyName.Text = "Nombre:";
            this.lblMyName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tpAddresses
            // 
            this.tpAddresses.Controls.Add(this.lblDelAddress);
            this.tpAddresses.Controls.Add(this.cmbAddresses);
            this.tpAddresses.Controls.Add(this.btnDelAddress);
            this.tpAddresses.Controls.Add(this.lblAddresses);
            this.tpAddresses.Controls.Add(this.cmbDelAddress);
            this.tpAddresses.Controls.Add(this.btnAddAddress);
            this.tpAddresses.Controls.Add(this.lblAddAddress);
            this.tpAddresses.Controls.Add(this.txtAddAddress);
            this.tpAddresses.Location = new System.Drawing.Point(4, 32);
            this.tpAddresses.Name = "tpAddresses";
            this.tpAddresses.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddresses.Size = new System.Drawing.Size(537, 414);
            this.tpAddresses.TabIndex = 2;
            this.tpAddresses.Text = "Mis Direcciones";
            this.tpAddresses.UseVisualStyleBackColor = true;
            // 
            // lblDelAddress
            // 
            this.lblDelAddress.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDelAddress.Location = new System.Drawing.Point(29, 276);
            this.lblDelAddress.Name = "lblDelAddress";
            this.lblDelAddress.Size = new System.Drawing.Size(203, 27);
            this.lblDelAddress.TabIndex = 24;
            this.lblDelAddress.Text = "Eliminar direccion;";
            this.lblDelAddress.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbAddresses
            // 
            this.cmbAddresses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddresses.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbAddresses.FormattingEnabled = true;
            this.cmbAddresses.Location = new System.Drawing.Point(29, 163);
            this.cmbAddresses.Name = "cmbAddresses";
            this.cmbAddresses.Size = new System.Drawing.Size(203, 33);
            this.cmbAddresses.TabIndex = 23;
            // 
            // btnDelAddress
            // 
            this.btnDelAddress.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDelAddress.Location = new System.Drawing.Point(403, 307);
            this.btnDelAddress.Name = "btnDelAddress";
            this.btnDelAddress.Size = new System.Drawing.Size(102, 32);
            this.btnDelAddress.TabIndex = 21;
            this.btnDelAddress.Text = "Eliminar";
            this.btnDelAddress.UseVisualStyleBackColor = true;
            this.btnDelAddress.Click += new System.EventHandler(this.btnDelAddress_Click);
            // 
            // lblAddresses
            // 
            this.lblAddresses.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAddresses.Location = new System.Drawing.Point(29, 138);
            this.lblAddresses.Name = "lblAddresses";
            this.lblAddresses.Size = new System.Drawing.Size(200, 22);
            this.lblAddresses.TabIndex = 19;
            this.lblAddresses.Text = "Mis direcciones:";
            // 
            // cmbDelAddress
            // 
            this.cmbDelAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDelAddress.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbDelAddress.FormattingEnabled = true;
            this.cmbDelAddress.Location = new System.Drawing.Point(29, 306);
            this.cmbDelAddress.Name = "cmbDelAddress";
            this.cmbDelAddress.Size = new System.Drawing.Size(203, 33);
            this.cmbDelAddress.TabIndex = 18;
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddAddress.Location = new System.Drawing.Point(403, 48);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(102, 32);
            this.btnAddAddress.TabIndex = 17;
            this.btnAddAddress.Text = "Agregar";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // lblAddAddress
            // 
            this.lblAddAddress.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAddAddress.Location = new System.Drawing.Point(29, 18);
            this.lblAddAddress.Name = "lblAddAddress";
            this.lblAddAddress.Size = new System.Drawing.Size(203, 27);
            this.lblAddAddress.TabIndex = 15;
            this.lblAddAddress.Text = "Añadir direccion;";
            this.lblAddAddress.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtAddAddress
            // 
            this.txtAddAddress.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtAddAddress.Location = new System.Drawing.Point(29, 48);
            this.txtAddAddress.Name = "txtAddAddress";
            this.txtAddAddress.Size = new System.Drawing.Size(203, 33);
            this.txtAddAddress.TabIndex = 14;
            // 
            // tpOrders
            // 
            this.tpOrders.Controls.Add(this.cmbProOrder);
            this.tpOrders.Controls.Add(this.lblProOrder);
            this.tpOrders.Controls.Add(this.cmbBusiOrder);
            this.tpOrders.Controls.Add(this.btnAddOrder);
            this.tpOrders.Controls.Add(this.lblBusiOrder);
            this.tpOrders.Controls.Add(this.cmbAddressOrder);
            this.tpOrders.Controls.Add(this.lblAddressOrder);
            this.tpOrders.Controls.Add(this.dgvMisOrdenes);
            this.tpOrders.Location = new System.Drawing.Point(4, 32);
            this.tpOrders.Name = "tpOrders";
            this.tpOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrders.Size = new System.Drawing.Size(537, 414);
            this.tpOrders.TabIndex = 3;
            this.tpOrders.Text = "Mis Ordenes";
            this.tpOrders.UseVisualStyleBackColor = true;
            // 
            // cmbProOrder
            // 
            this.cmbProOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProOrder.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbProOrder.FormattingEnabled = true;
            this.cmbProOrder.Location = new System.Drawing.Point(287, 170);
            this.cmbProOrder.Name = "cmbProOrder";
            this.cmbProOrder.Size = new System.Drawing.Size(194, 33);
            this.cmbProOrder.TabIndex = 31;
            // 
            // lblProOrder
            // 
            this.lblProOrder.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblProOrder.Location = new System.Drawing.Point(287, 140);
            this.lblProOrder.Name = "lblProOrder";
            this.lblProOrder.Size = new System.Drawing.Size(194, 27);
            this.lblProOrder.TabIndex = 30;
            this.lblProOrder.Text = "Producto:";
            this.lblProOrder.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbBusiOrder
            // 
            this.cmbBusiOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusiOrder.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbBusiOrder.FormattingEnabled = true;
            this.cmbBusiOrder.Location = new System.Drawing.Point(28, 170);
            this.cmbBusiOrder.Name = "cmbBusiOrder";
            this.cmbBusiOrder.Size = new System.Drawing.Size(194, 33);
            this.cmbBusiOrder.TabIndex = 29;
            this.cmbBusiOrder.SelectedIndexChanged += new System.EventHandler(this.cmbBusiOrder_SelectedIndexChanged);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddOrder.Location = new System.Drawing.Point(287, 51);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(194, 33);
            this.btnAddOrder.TabIndex = 28;
            this.btnAddOrder.Text = "Ordenar";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // lblBusiOrder
            // 
            this.lblBusiOrder.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblBusiOrder.Location = new System.Drawing.Point(28, 140);
            this.lblBusiOrder.Name = "lblBusiOrder";
            this.lblBusiOrder.Size = new System.Drawing.Size(194, 27);
            this.lblBusiOrder.TabIndex = 26;
            this.lblBusiOrder.Text = "Negocio:";
            this.lblBusiOrder.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbAddressOrder
            // 
            this.cmbAddressOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddressOrder.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbAddressOrder.FormattingEnabled = true;
            this.cmbAddressOrder.Location = new System.Drawing.Point(28, 51);
            this.cmbAddressOrder.Name = "cmbAddressOrder";
            this.cmbAddressOrder.Size = new System.Drawing.Size(194, 33);
            this.cmbAddressOrder.TabIndex = 25;
            // 
            // lblAddressOrder
            // 
            this.lblAddressOrder.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAddressOrder.Location = new System.Drawing.Point(28, 26);
            this.lblAddressOrder.Name = "lblAddressOrder";
            this.lblAddressOrder.Size = new System.Drawing.Size(194, 22);
            this.lblAddressOrder.TabIndex = 24;
            this.lblAddressOrder.Text = "Direccion:";
            // 
            // dgvMisOrdenes
            // 
            this.dgvMisOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisOrdenes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMisOrdenes.Location = new System.Drawing.Point(3, 241);
            this.dgvMisOrdenes.Name = "dgvMisOrdenes";
            this.dgvMisOrdenes.ReadOnly = true;
            this.dgvMisOrdenes.Size = new System.Drawing.Size(531, 170);
            this.dgvMisOrdenes.TabIndex = 0;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (65)))), ((int) (((byte) (43)))), ((int) (((byte) (110)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.tabF4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.tabF4.ResumeLayout(false);
            this.tpPerfil.ResumeLayout(false);
            this.tpPerfil.PerformLayout();
            this.tpAddresses.ResumeLayout(false);
            this.tpAddresses.PerformLayout();
            this.tpOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvMisOrdenes)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnDelAddress;
        private System.Windows.Forms.ComboBox cmbAddresses;
        private System.Windows.Forms.ComboBox cmbAddressOrder;
        private System.Windows.Forms.ComboBox cmbBusiOrder;
        private System.Windows.Forms.ComboBox cmbDelAddress;
        private System.Windows.Forms.ComboBox cmbProOrder;
        private System.Windows.Forms.DataGridView dgvMisOrdenes;
        private System.Windows.Forms.Label lblAddAddress;
        private System.Windows.Forms.Label lblAddresses;
        private System.Windows.Forms.Label lblAddressOrder;
        private System.Windows.Forms.Label lblBusiOrder;
        private System.Windows.Forms.Label lblChangePass;
        private System.Windows.Forms.Label lblDelAddress;
        private System.Windows.Forms.Label lblMyName;
        private System.Windows.Forms.Label lblMyUsrnm;
        private System.Windows.Forms.Label lblProOrder;
        private System.Windows.Forms.TabControl tabF4;
        private System.Windows.Forms.TabPage tpAddresses;
        private System.Windows.Forms.TabPage tpOrders;
        private System.Windows.Forms.TabPage tpPerfil;
        private System.Windows.Forms.TextBox txtAddAddress;
        private System.Windows.Forms.TextBox txtChangePass;
        private System.Windows.Forms.TextBox txtMyName;
        private System.Windows.Forms.TextBox txtMyUsrnm;

        #endregion
    }
}