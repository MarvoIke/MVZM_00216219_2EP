using System.ComponentModel;

namespace parcialDos
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.tabF3 = new System.Windows.Forms.TabControl();
            this.tpUsuario = new System.Windows.Forms.TabPage();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullname = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.txtChangePass = new System.Windows.Forms.TextBox();
            this.lblChangePass = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDelUser = new System.Windows.Forms.TextBox();
            this.lblDelUser = new System.Windows.Forms.Label();
            this.chbAdmin = new System.Windows.Forms.CheckBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblAddPass = new System.Windows.Forms.Label();
            this.txtUsrnm = new System.Windows.Forms.TextBox();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.tpNegocios = new System.Windows.Forms.TabPage();
            this.lblDescBusi = new System.Windows.Forms.Label();
            this.txtDescBusi = new System.Windows.Forms.TextBox();
            this.btnDelBusi = new System.Windows.Forms.Button();
            this.txtDelBusi = new System.Windows.Forms.TextBox();
            this.lblDelBusi = new System.Windows.Forms.Label();
            this.btnAddBusi = new System.Windows.Forms.Button();
            this.txtAddBusi = new System.Windows.Forms.TextBox();
            this.lblAddBusi = new System.Windows.Forms.Label();
            this.tpProductos = new System.Windows.Forms.TabPage();
            this.cmbDelProd = new System.Windows.Forms.ComboBox();
            this.btnDelPro = new System.Windows.Forms.Button();
            this.lblDelPro = new System.Windows.Forms.Label();
            this.cmbAddProBusi = new System.Windows.Forms.ComboBox();
            this.btnAddPro = new System.Windows.Forms.Button();
            this.lblAddProBusi = new System.Windows.Forms.Label();
            this.txtAddProName = new System.Windows.Forms.TextBox();
            this.lblAddProName = new System.Windows.Forms.Label();
            this.tpOrdenes = new System.Windows.Forms.TabPage();
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.tabF3.SuspendLayout();
            this.tpUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvUser)).BeginInit();
            this.tpNegocios.SuspendLayout();
            this.tpProductos.SuspendLayout();
            this.tpOrdenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabF3
            // 
            this.tabF3.Controls.Add(this.tpUsuario);
            this.tabF3.Controls.Add(this.tpNegocios);
            this.tabF3.Controls.Add(this.tpProductos);
            this.tabF3.Controls.Add(this.tpOrdenes);
            this.tabF3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabF3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabF3.Location = new System.Drawing.Point(0, 0);
            this.tabF3.Name = "tabF3";
            this.tabF3.SelectedIndex = 0;
            this.tabF3.Size = new System.Drawing.Size(544, 474);
            this.tabF3.TabIndex = 0;
            // 
            // tpUsuario
            // 
            this.tpUsuario.Controls.Add(this.txtFullName);
            this.tpUsuario.Controls.Add(this.lblFullname);
            this.tpUsuario.Controls.Add(this.dgvUser);
            this.tpUsuario.Controls.Add(this.btnChangePass);
            this.tpUsuario.Controls.Add(this.txtChangePass);
            this.tpUsuario.Controls.Add(this.lblChangePass);
            this.tpUsuario.Controls.Add(this.btnDelete);
            this.tpUsuario.Controls.Add(this.txtDelUser);
            this.tpUsuario.Controls.Add(this.lblDelUser);
            this.tpUsuario.Controls.Add(this.chbAdmin);
            this.tpUsuario.Controls.Add(this.btnCrear);
            this.tpUsuario.Controls.Add(this.txtPass);
            this.tpUsuario.Controls.Add(this.lblAddPass);
            this.tpUsuario.Controls.Add(this.txtUsrnm);
            this.tpUsuario.Controls.Add(this.lblAddUser);
            this.tpUsuario.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tpUsuario.Location = new System.Drawing.Point(4, 24);
            this.tpUsuario.Name = "tpUsuario";
            this.tpUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsuario.Size = new System.Drawing.Size(536, 446);
            this.tpUsuario.TabIndex = 0;
            this.tpUsuario.Text = "Usuarios";
            this.tpUsuario.UseVisualStyleBackColor = true;
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtFullName.Location = new System.Drawing.Point(295, 30);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(203, 29);
            this.txtFullName.TabIndex = 21;
            // 
            // lblFullname
            // 
            this.lblFullname.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblFullname.Location = new System.Drawing.Point(295, 9);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(156, 18);
            this.lblFullname.TabIndex = 20;
            this.lblFullname.Text = "Su nombre:";
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUser.Location = new System.Drawing.Point(3, 317);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.Size = new System.Drawing.Size(530, 126);
            this.dgvUser.TabIndex = 19;
            // 
            // btnChangePass
            // 
            this.btnChangePass.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnChangePass.Location = new System.Drawing.Point(396, 265);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(102, 32);
            this.btnChangePass.TabIndex = 18;
            this.btnChangePass.Text = "Confirmar";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // txtChangePass
            // 
            this.txtChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtChangePass.Location = new System.Drawing.Point(22, 268);
            this.txtChangePass.Name = "txtChangePass";
            this.txtChangePass.Size = new System.Drawing.Size(269, 29);
            this.txtChangePass.TabIndex = 17;
            // 
            // lblChangePass
            // 
            this.lblChangePass.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblChangePass.Location = new System.Drawing.Point(22, 243);
            this.lblChangePass.Name = "lblChangePass";
            this.lblChangePass.Size = new System.Drawing.Size(269, 22);
            this.lblChangePass.TabIndex = 16;
            this.lblChangePass.Text = "Cambiar contraseña (usuario actual)";
            this.lblChangePass.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDelete.Location = new System.Drawing.Point(396, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 32);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDelUser
            // 
            this.txtDelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtDelUser.Location = new System.Drawing.Point(22, 190);
            this.txtDelUser.Name = "txtDelUser";
            this.txtDelUser.Size = new System.Drawing.Size(203, 29);
            this.txtDelUser.TabIndex = 14;
            // 
            // lblDelUser
            // 
            this.lblDelUser.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDelUser.Location = new System.Drawing.Point(22, 160);
            this.lblDelUser.Name = "lblDelUser";
            this.lblDelUser.Size = new System.Drawing.Size(200, 27);
            this.lblDelUser.TabIndex = 13;
            this.lblDelUser.Text = "Eliminar Usuario";
            this.lblDelUser.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // chbAdmin
            // 
            this.chbAdmin.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.chbAdmin.Location = new System.Drawing.Point(352, 65);
            this.chbAdmin.Name = "chbAdmin";
            this.chbAdmin.Size = new System.Drawing.Size(146, 30);
            this.chbAdmin.TabIndex = 12;
            this.chbAdmin.Text = "Administrador";
            this.chbAdmin.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCrear.Location = new System.Drawing.Point(396, 104);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(102, 32);
            this.btnCrear.TabIndex = 11;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtPass.Location = new System.Drawing.Point(22, 104);
            this.txtPass.Name = "txtPass";
            this.txtPass.ReadOnly = true;
            this.txtPass.Size = new System.Drawing.Size(203, 29);
            this.txtPass.TabIndex = 10;
            // 
            // lblAddPass
            // 
            this.lblAddPass.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAddPass.Location = new System.Drawing.Point(22, 75);
            this.lblAddPass.Name = "lblAddPass";
            this.lblAddPass.Size = new System.Drawing.Size(200, 26);
            this.lblAddPass.TabIndex = 9;
            this.lblAddPass.Text = "Nueva contraseña:";
            this.lblAddPass.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtUsrnm
            // 
            this.txtUsrnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtUsrnm.Location = new System.Drawing.Point(22, 30);
            this.txtUsrnm.Name = "txtUsrnm";
            this.txtUsrnm.Size = new System.Drawing.Size(203, 29);
            this.txtUsrnm.TabIndex = 8;
            this.txtUsrnm.TextChanged += new System.EventHandler(this.txtUsrnm_TextChanged);
            // 
            // lblAddUser
            // 
            this.lblAddUser.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAddUser.Location = new System.Drawing.Point(22, 5);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(156, 22);
            this.lblAddUser.TabIndex = 7;
            this.lblAddUser.Text = "Nuevo usuario:";
            // 
            // tpNegocios
            // 
            this.tpNegocios.Controls.Add(this.lblDescBusi);
            this.tpNegocios.Controls.Add(this.txtDescBusi);
            this.tpNegocios.Controls.Add(this.btnDelBusi);
            this.tpNegocios.Controls.Add(this.txtDelBusi);
            this.tpNegocios.Controls.Add(this.lblDelBusi);
            this.tpNegocios.Controls.Add(this.btnAddBusi);
            this.tpNegocios.Controls.Add(this.txtAddBusi);
            this.tpNegocios.Controls.Add(this.lblAddBusi);
            this.tpNegocios.Location = new System.Drawing.Point(4, 24);
            this.tpNegocios.Name = "tpNegocios";
            this.tpNegocios.Padding = new System.Windows.Forms.Padding(3);
            this.tpNegocios.Size = new System.Drawing.Size(536, 446);
            this.tpNegocios.TabIndex = 1;
            this.tpNegocios.Text = "Negocios";
            this.tpNegocios.UseVisualStyleBackColor = true;
            // 
            // lblDescBusi
            // 
            this.lblDescBusi.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDescBusi.Location = new System.Drawing.Point(23, 102);
            this.lblDescBusi.Name = "lblDescBusi";
            this.lblDescBusi.Size = new System.Drawing.Size(200, 27);
            this.lblDescBusi.TabIndex = 24;
            this.lblDescBusi.Text = "Descripcion:";
            this.lblDescBusi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtDescBusi
            // 
            this.txtDescBusi.Location = new System.Drawing.Point(23, 132);
            this.txtDescBusi.Multiline = true;
            this.txtDescBusi.Name = "txtDescBusi";
            this.txtDescBusi.Size = new System.Drawing.Size(477, 94);
            this.txtDescBusi.TabIndex = 23;
            // 
            // btnDelBusi
            // 
            this.btnDelBusi.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDelBusi.Location = new System.Drawing.Point(398, 340);
            this.btnDelBusi.Name = "btnDelBusi";
            this.btnDelBusi.Size = new System.Drawing.Size(102, 32);
            this.btnDelBusi.TabIndex = 22;
            this.btnDelBusi.Text = "Eliminar";
            this.btnDelBusi.UseVisualStyleBackColor = true;
            this.btnDelBusi.Click += new System.EventHandler(this.btnDelBusi_Click);
            // 
            // txtDelBusi
            // 
            this.txtDelBusi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtDelBusi.Location = new System.Drawing.Point(24, 343);
            this.txtDelBusi.Name = "txtDelBusi";
            this.txtDelBusi.Size = new System.Drawing.Size(203, 29);
            this.txtDelBusi.TabIndex = 21;
            // 
            // lblDelBusi
            // 
            this.lblDelBusi.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDelBusi.Location = new System.Drawing.Point(24, 313);
            this.lblDelBusi.Name = "lblDelBusi";
            this.lblDelBusi.Size = new System.Drawing.Size(200, 27);
            this.lblDelBusi.TabIndex = 20;
            this.lblDelBusi.Text = "Eliminar negocio:";
            this.lblDelBusi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnAddBusi
            // 
            this.btnAddBusi.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddBusi.Location = new System.Drawing.Point(398, 55);
            this.btnAddBusi.Name = "btnAddBusi";
            this.btnAddBusi.Size = new System.Drawing.Size(102, 32);
            this.btnAddBusi.TabIndex = 19;
            this.btnAddBusi.Text = "Agregar";
            this.btnAddBusi.UseVisualStyleBackColor = true;
            this.btnAddBusi.Click += new System.EventHandler(this.btnAddBusi_Click);
            // 
            // txtAddBusi
            // 
            this.txtAddBusi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtAddBusi.Location = new System.Drawing.Point(24, 58);
            this.txtAddBusi.Name = "txtAddBusi";
            this.txtAddBusi.Size = new System.Drawing.Size(203, 29);
            this.txtAddBusi.TabIndex = 18;
            // 
            // lblAddBusi
            // 
            this.lblAddBusi.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAddBusi.Location = new System.Drawing.Point(24, 28);
            this.lblAddBusi.Name = "lblAddBusi";
            this.lblAddBusi.Size = new System.Drawing.Size(200, 27);
            this.lblAddBusi.TabIndex = 17;
            this.lblAddBusi.Text = "Nuevo negocio:";
            this.lblAddBusi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tpProductos
            // 
            this.tpProductos.Controls.Add(this.cmbDelProd);
            this.tpProductos.Controls.Add(this.btnDelPro);
            this.tpProductos.Controls.Add(this.lblDelPro);
            this.tpProductos.Controls.Add(this.cmbAddProBusi);
            this.tpProductos.Controls.Add(this.btnAddPro);
            this.tpProductos.Controls.Add(this.lblAddProBusi);
            this.tpProductos.Controls.Add(this.txtAddProName);
            this.tpProductos.Controls.Add(this.lblAddProName);
            this.tpProductos.Location = new System.Drawing.Point(4, 24);
            this.tpProductos.Name = "tpProductos";
            this.tpProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tpProductos.Size = new System.Drawing.Size(536, 446);
            this.tpProductos.TabIndex = 2;
            this.tpProductos.Text = "Productos";
            this.tpProductos.UseVisualStyleBackColor = true;
            // 
            // cmbDelProd
            // 
            this.cmbDelProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDelProd.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbDelProd.FormattingEnabled = true;
            this.cmbDelProd.Location = new System.Drawing.Point(29, 255);
            this.cmbDelProd.Name = "cmbDelProd";
            this.cmbDelProd.Size = new System.Drawing.Size(197, 33);
            this.cmbDelProd.TabIndex = 23;
            // 
            // btnDelPro
            // 
            this.btnDelPro.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDelPro.Location = new System.Drawing.Point(403, 256);
            this.btnDelPro.Name = "btnDelPro";
            this.btnDelPro.Size = new System.Drawing.Size(102, 32);
            this.btnDelPro.TabIndex = 21;
            this.btnDelPro.Text = "Eliminar";
            this.btnDelPro.UseVisualStyleBackColor = true;
            this.btnDelPro.Click += new System.EventHandler(this.btnDelPro_Click);
            // 
            // lblDelPro
            // 
            this.lblDelPro.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDelPro.Location = new System.Drawing.Point(29, 230);
            this.lblDelPro.Name = "lblDelPro";
            this.lblDelPro.Size = new System.Drawing.Size(194, 22);
            this.lblDelPro.TabIndex = 19;
            this.lblDelPro.Text = "Eliminar producto:";
            // 
            // cmbAddProBusi
            // 
            this.cmbAddProBusi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddProBusi.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbAddProBusi.FormattingEnabled = true;
            this.cmbAddProBusi.Location = new System.Drawing.Point(29, 48);
            this.cmbAddProBusi.Name = "cmbAddProBusi";
            this.cmbAddProBusi.Size = new System.Drawing.Size(203, 33);
            this.cmbAddProBusi.TabIndex = 18;
            this.cmbAddProBusi.SelectedIndexChanged += new System.EventHandler(this.cmbAddProBusi_SelectedIndexChanged);
            // 
            // btnAddPro
            // 
            this.btnAddPro.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddPro.Location = new System.Drawing.Point(403, 148);
            this.btnAddPro.Name = "btnAddPro";
            this.btnAddPro.Size = new System.Drawing.Size(102, 32);
            this.btnAddPro.TabIndex = 17;
            this.btnAddPro.Text = "Agregar";
            this.btnAddPro.UseVisualStyleBackColor = true;
            this.btnAddPro.Click += new System.EventHandler(this.btnAddPro_Click);
            // 
            // lblAddProBusi
            // 
            this.lblAddProBusi.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAddProBusi.Location = new System.Drawing.Point(29, 18);
            this.lblAddProBusi.Name = "lblAddProBusi";
            this.lblAddProBusi.Size = new System.Drawing.Size(203, 27);
            this.lblAddProBusi.TabIndex = 15;
            this.lblAddProBusi.Text = "Negocio:";
            this.lblAddProBusi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtAddProName
            // 
            this.txtAddProName.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtAddProName.Location = new System.Drawing.Point(29, 147);
            this.txtAddProName.Name = "txtAddProName";
            this.txtAddProName.Size = new System.Drawing.Size(203, 33);
            this.txtAddProName.TabIndex = 14;
            // 
            // lblAddProName
            // 
            this.lblAddProName.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAddProName.Location = new System.Drawing.Point(29, 122);
            this.lblAddProName.Name = "lblAddProName";
            this.lblAddProName.Size = new System.Drawing.Size(174, 22);
            this.lblAddProName.TabIndex = 13;
            this.lblAddProName.Text = "Nuevo producto:";
            // 
            // tpOrdenes
            // 
            this.tpOrdenes.Controls.Add(this.dgvOrdenes);
            this.tpOrdenes.Location = new System.Drawing.Point(4, 24);
            this.tpOrdenes.Name = "tpOrdenes";
            this.tpOrdenes.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrdenes.Size = new System.Drawing.Size(536, 446);
            this.tpOrdenes.TabIndex = 3;
            this.tpOrdenes.Text = "Ordenes";
            this.tpOrdenes.UseVisualStyleBackColor = true;
            // 
            // dgvOrdenes
            // 
            this.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenes.Location = new System.Drawing.Point(14, 14);
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.ReadOnly = true;
            this.dgvOrdenes.Size = new System.Drawing.Size(507, 418);
            this.dgvOrdenes.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (65)))), ((int) (((byte) (43)))), ((int) (((byte) (110)))));
            this.ClientSize = new System.Drawing.Size(544, 474);
            this.Controls.Add(this.tabF3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabF3.ResumeLayout(false);
            this.tpUsuario.ResumeLayout(false);
            this.tpUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvUser)).EndInit();
            this.tpNegocios.ResumeLayout(false);
            this.tpNegocios.PerformLayout();
            this.tpProductos.ResumeLayout(false);
            this.tpProductos.PerformLayout();
            this.tpOrdenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvOrdenes)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAddBusi;
        private System.Windows.Forms.Button btnAddPro;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnDelBusi;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDelPro;
        private System.Windows.Forms.CheckBox chbAdmin;
        private System.Windows.Forms.ComboBox cmbAddProBusi;
        private System.Windows.Forms.ComboBox cmbDelProd;
        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Label lblAddBusi;
        private System.Windows.Forms.Label lblAddPass;
        private System.Windows.Forms.Label lblAddProBusi;
        private System.Windows.Forms.Label lblAddProName;
        private System.Windows.Forms.Label lblAddUser;
        private System.Windows.Forms.Label lblChangePass;
        private System.Windows.Forms.Label lblDelBusi;
        private System.Windows.Forms.Label lblDelPro;
        private System.Windows.Forms.Label lblDelUser;
        private System.Windows.Forms.Label lblDescBusi;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.TabControl tabF3;
        private System.Windows.Forms.TabPage tpNegocios;
        private System.Windows.Forms.TabPage tpOrdenes;
        private System.Windows.Forms.TabPage tpProductos;
        private System.Windows.Forms.TabPage tpUsuario;
        private System.Windows.Forms.TextBox txtAddBusi;
        private System.Windows.Forms.TextBox txtAddProName;
        private System.Windows.Forms.TextBox txtChangePass;
        private System.Windows.Forms.TextBox txtDelBusi;
        private System.Windows.Forms.TextBox txtDelUser;
        private System.Windows.Forms.TextBox txtDescBusi;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsrnm;

        #endregion
    }
}