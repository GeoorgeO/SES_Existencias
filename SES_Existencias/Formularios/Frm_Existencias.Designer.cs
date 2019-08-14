namespace SES_Existencias
{
    partial class Frm_Existencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Existencias));
            this.sbConexion = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodpro = new DevExpress.XtraEditors.TextEdit();
            this.lNomArticulo = new DevExpress.XtraEditors.LabelControl();
            this.sbConRemotas = new DevExpress.XtraEditors.SimpleButton();
            this.sbCodProducto = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.tabla = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SucursalesId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SucursalesNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ServerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DataBaseID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PassID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.existencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lexislocal = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodpro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sbConexion
            // 
            this.sbConexion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbConexion.ImageOptions.Image")));
            this.sbConexion.Location = new System.Drawing.Point(17, 7);
            this.sbConexion.Name = "sbConexion";
            this.sbConexion.Size = new System.Drawing.Size(41, 39);
            this.sbConexion.TabIndex = 0;
            this.sbConexion.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Codigo:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Descripción:";
            // 
            // txtCodpro
            // 
            this.txtCodpro.Location = new System.Drawing.Point(80, 52);
            this.txtCodpro.Name = "txtCodpro";
            this.txtCodpro.Size = new System.Drawing.Size(100, 20);
            this.txtCodpro.TabIndex = 3;
            this.txtCodpro.TextChanged += new System.EventHandler(this.txtCodpro_TextChanged);
            this.txtCodpro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodpro_KeyPress);
            // 
            // lNomArticulo
            // 
            this.lNomArticulo.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lNomArticulo.Appearance.Options.UseFont = true;
            this.lNomArticulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lNomArticulo.Location = new System.Drawing.Point(80, 78);
            this.lNomArticulo.Name = "lNomArticulo";
            this.lNomArticulo.Size = new System.Drawing.Size(261, 20);
            this.lNomArticulo.TabIndex = 4;
            // 
            // sbConRemotas
            // 
            this.sbConRemotas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbConRemotas.ImageOptions.Image")));
            this.sbConRemotas.Location = new System.Drawing.Point(61, 7);
            this.sbConRemotas.Name = "sbConRemotas";
            this.sbConRemotas.Size = new System.Drawing.Size(41, 39);
            this.sbConRemotas.TabIndex = 16;
            this.sbConRemotas.ToolTip = "Conexiones Remotas";
            this.sbConRemotas.Click += new System.EventHandler(this.sbConRemotas_Click);
            // 
            // sbCodProducto
            // 
            this.sbCodProducto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCodProducto.ImageOptions.Image")));
            this.sbCodProducto.Location = new System.Drawing.Point(183, 50);
            this.sbCodProducto.Name = "sbCodProducto";
            this.sbCodProducto.Size = new System.Drawing.Size(23, 23);
            this.sbCodProducto.TabIndex = 15;
            this.sbCodProducto.Click += new System.EventHandler(this.sbCodProducto_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(370, 51);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 39);
            this.simpleButton2.TabIndex = 14;
            this.simpleButton2.Text = "Consultar \r\nExistencia";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.lexislocal);
            this.panelControl4.Controls.Add(this.labelControl3);
            this.panelControl4.Controls.Add(this.sbConexion);
            this.panelControl4.Controls.Add(this.simpleButton2);
            this.panelControl4.Controls.Add(this.sbConRemotas);
            this.panelControl4.Controls.Add(this.labelControl2);
            this.panelControl4.Controls.Add(this.sbCodProducto);
            this.panelControl4.Controls.Add(this.labelControl1);
            this.panelControl4.Controls.Add(this.lNomArticulo);
            this.panelControl4.Controls.Add(this.txtCodpro);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(459, 109);
            this.panelControl4.TabIndex = 17;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.tabla);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 109);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Padding = new System.Windows.Forms.Padding(10);
            this.panelControl3.Size = new System.Drawing.Size(459, 448);
            this.panelControl3.TabIndex = 1;
            // 
            // tabla
            // 
            this.tabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabla.Location = new System.Drawing.Point(12, 12);
            this.tabla.MainView = this.gridView1;
            this.tabla.Name = "tabla";
            this.tabla.Size = new System.Drawing.Size(435, 424);
            this.tabla.TabIndex = 0;
            this.tabla.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SucursalesId,
            this.SucursalesNombre,
            this.ServerID,
            this.DataBaseID,
            this.UserID,
            this.PassID,
            this.existencia,
            this.Estatus});
            this.gridView1.GridControl = this.tabla;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // SucursalesId
            // 
            this.SucursalesId.Caption = "SucursalId";
            this.SucursalesId.FieldName = "SucursalesId";
            this.SucursalesId.Name = "SucursalesId";
            this.SucursalesId.Visible = true;
            this.SucursalesId.VisibleIndex = 0;
            this.SucursalesId.Width = 70;
            // 
            // SucursalesNombre
            // 
            this.SucursalesNombre.Caption = "Sucursal";
            this.SucursalesNombre.FieldName = "SucursalesNombre";
            this.SucursalesNombre.Name = "SucursalesNombre";
            this.SucursalesNombre.Visible = true;
            this.SucursalesNombre.VisibleIndex = 1;
            this.SucursalesNombre.Width = 191;
            // 
            // ServerID
            // 
            this.ServerID.Caption = "Servidor";
            this.ServerID.FieldName = "ServerID";
            this.ServerID.Name = "ServerID";
            // 
            // DataBaseID
            // 
            this.DataBaseID.Caption = "Basededatos";
            this.DataBaseID.FieldName = "DataBaseID";
            this.DataBaseID.Name = "DataBaseID";
            // 
            // UserID
            // 
            this.UserID.Caption = "Usuario";
            this.UserID.FieldName = "UserID";
            this.UserID.Name = "UserID";
            // 
            // PassID
            // 
            this.PassID.Caption = "Contraseña";
            this.PassID.FieldName = "PassID";
            this.PassID.Name = "PassID";
            // 
            // existencia
            // 
            this.existencia.Caption = "Existencia";
            this.existencia.FieldName = "existencia";
            this.existencia.Name = "existencia";
            this.existencia.Visible = true;
            this.existencia.VisibleIndex = 2;
            this.existencia.Width = 59;
            // 
            // Estatus
            // 
            this.Estatus.Caption = "Estatus";
            this.Estatus.FieldName = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.Visible = true;
            this.Estatus.VisibleIndex = 3;
            this.Estatus.Width = 93;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(216, 55);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 13);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Existencia Local:";
            // 
            // lexislocal
            // 
            this.lexislocal.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lexislocal.Appearance.Options.UseFont = true;
            this.lexislocal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lexislocal.Location = new System.Drawing.Point(297, 55);
            this.lexislocal.Name = "lexislocal";
            this.lexislocal.Size = new System.Drawing.Size(56, 13);
            this.lexislocal.TabIndex = 18;
            this.lexislocal.Text = "                        ";
            // 
            // Frm_Existencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 557);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Existencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Existencias Sucursales";
            this.Load += new System.EventHandler(this.Frm_Existencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodpro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbConexion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCodpro;
        private DevExpress.XtraEditors.LabelControl lNomArticulo;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton sbCodProducto;
        private DevExpress.XtraEditors.SimpleButton sbConRemotas;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl tabla;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn SucursalesId;
        private DevExpress.XtraGrid.Columns.GridColumn SucursalesNombre;
        private DevExpress.XtraGrid.Columns.GridColumn ServerID;
        private DevExpress.XtraGrid.Columns.GridColumn DataBaseID;
        private DevExpress.XtraGrid.Columns.GridColumn UserID;
        private DevExpress.XtraGrid.Columns.GridColumn PassID;
        private DevExpress.XtraGrid.Columns.GridColumn existencia;
        private DevExpress.XtraGrid.Columns.GridColumn Estatus;
        private DevExpress.XtraEditors.LabelControl lexislocal;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}