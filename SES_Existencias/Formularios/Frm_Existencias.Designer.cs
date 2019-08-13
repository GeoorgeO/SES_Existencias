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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodpro = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.Observaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodpro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(4, 1);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(41, 39);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Codigo:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Descripción:";
            // 
            // txtCodpro
            // 
            this.txtCodpro.Location = new System.Drawing.Point(48, 48);
            this.txtCodpro.Name = "txtCodpro";
            this.txtCodpro.Size = new System.Drawing.Size(100, 20);
            this.txtCodpro.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(67, 74);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(196, 13);
            this.labelControl3.TabIndex = 4;
            // 
            // panelControl2
            // 
            this.panelControl2.AutoSize = true;
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(10);
            this.panelControl2.Size = new System.Drawing.Size(823, 557);
            this.panelControl2.TabIndex = 12;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.tabla);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(12, 106);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(799, 439);
            this.panelControl3.TabIndex = 1;
            // 
            // tabla
            // 
            this.tabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabla.Location = new System.Drawing.Point(2, 2);
            this.tabla.MainView = this.gridView1;
            this.tabla.Name = "tabla";
            this.tabla.Size = new System.Drawing.Size(795, 435);
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
            this.Estatus,
            this.Observaciones});
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
            // 
            // SucursalesNombre
            // 
            this.SucursalesNombre.Caption = "Sucursal";
            this.SucursalesNombre.FieldName = "SucursalesNombre";
            this.SucursalesNombre.Name = "SucursalesNombre";
            this.SucursalesNombre.Visible = true;
            this.SucursalesNombre.VisibleIndex = 1;
            // 
            // ServerID
            // 
            this.ServerID.Caption = "Servidor";
            this.ServerID.FieldName = "ServerID";
            this.ServerID.Name = "ServerID";
            this.ServerID.Visible = true;
            this.ServerID.VisibleIndex = 4;
            // 
            // DataBaseID
            // 
            this.DataBaseID.Caption = "Basededatos";
            this.DataBaseID.FieldName = "DataBaseID";
            this.DataBaseID.Name = "DataBaseID";
            this.DataBaseID.Visible = true;
            this.DataBaseID.VisibleIndex = 5;
            // 
            // UserID
            // 
            this.UserID.Caption = "Usuario";
            this.UserID.FieldName = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.Visible = true;
            this.UserID.VisibleIndex = 6;
            // 
            // PassID
            // 
            this.PassID.Caption = "Contraseña";
            this.PassID.FieldName = "PassID";
            this.PassID.Name = "PassID";
            this.PassID.Visible = true;
            this.PassID.VisibleIndex = 7;
            // 
            // existencia
            // 
            this.existencia.Caption = "Existencia";
            this.existencia.FieldName = "existencia";
            this.existencia.Name = "existencia";
            this.existencia.Visible = true;
            this.existencia.VisibleIndex = 2;
            // 
            // Estatus
            // 
            this.Estatus.Caption = "Estatus";
            this.Estatus.FieldName = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.Visible = true;
            this.Estatus.VisibleIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.txtCodpro);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(823, 100);
            this.panelControl1.TabIndex = 13;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(367, 69);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 14;
            this.simpleButton2.Text = "Consultar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Observaciones
            // 
            this.Observaciones.Caption = "Observaciones";
            this.Observaciones.FieldName = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Visible = true;
            this.Observaciones.VisibleIndex = 8;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(153, 47);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(28, 23);
            this.simpleButton3.TabIndex = 15;
            this.simpleButton3.Text = "...";
            // 
            // Frm_Existencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 557);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "Frm_Existencias";
            this.Text = "Frm_Existencias";
            this.Load += new System.EventHandler(this.Frm_Existencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodpro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCodpro;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl tabla;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn SucursalesId;
        private DevExpress.XtraGrid.Columns.GridColumn SucursalesNombre;
        private DevExpress.XtraGrid.Columns.GridColumn existencia;
        private DevExpress.XtraGrid.Columns.GridColumn Estatus;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn ServerID;
        private DevExpress.XtraGrid.Columns.GridColumn DataBaseID;
        private DevExpress.XtraGrid.Columns.GridColumn UserID;
        private DevExpress.XtraGrid.Columns.GridColumn PassID;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.Columns.GridColumn Observaciones;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}