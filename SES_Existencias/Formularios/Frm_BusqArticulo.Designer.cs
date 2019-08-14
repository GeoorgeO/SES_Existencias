namespace SES_Existencias
{
    partial class Frm_BusqArticulo
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
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.Tabla = new DevExpress.XtraGrid.GridControl();
            this.gridview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ArticuloCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ArticuloDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FamiliaNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ArticuloCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.Tabla);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(10, 30);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Padding = new System.Windows.Forms.Padding(5);
            this.panelControl4.Size = new System.Drawing.Size(720, 395);
            this.panelControl4.TabIndex = 16;
            // 
            // Tabla
            // 
            this.Tabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabla.Location = new System.Drawing.Point(7, 7);
            this.Tabla.MainView = this.gridview;
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(706, 381);
            this.Tabla.TabIndex = 0;
            this.Tabla.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridview});
            this.Tabla.DoubleClick += new System.EventHandler(this.Tabla_DoubleClick);
            // 
            // gridview
            // 
            this.gridview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ArticuloCodigo,
            this.ArticuloDescripcion,
            this.FamiliaNombre,
            this.ArticuloCantidad});
            this.gridview.GridControl = this.Tabla;
            this.gridview.Name = "gridview";
            this.gridview.OptionsBehavior.Editable = false;
            this.gridview.OptionsFind.AlwaysVisible = true;
            this.gridview.OptionsView.ShowGroupPanel = false;
            // 
            // ArticuloCodigo
            // 
            this.ArticuloCodigo.Caption = "N°";
            this.ArticuloCodigo.FieldName = "ArticuloCodigo";
            this.ArticuloCodigo.Name = "ArticuloCodigo";
            this.ArticuloCodigo.Visible = true;
            this.ArticuloCodigo.VisibleIndex = 0;
            this.ArticuloCodigo.Width = 129;
            // 
            // ArticuloDescripcion
            // 
            this.ArticuloDescripcion.Caption = "Articulo";
            this.ArticuloDescripcion.FieldName = "ArticuloDescripcion";
            this.ArticuloDescripcion.Name = "ArticuloDescripcion";
            this.ArticuloDescripcion.Visible = true;
            this.ArticuloDescripcion.VisibleIndex = 1;
            this.ArticuloDescripcion.Width = 259;
            // 
            // FamiliaNombre
            // 
            this.FamiliaNombre.Caption = "Familia";
            this.FamiliaNombre.FieldName = "FamiliaNombre";
            this.FamiliaNombre.Name = "FamiliaNombre";
            this.FamiliaNombre.Visible = true;
            this.FamiliaNombre.VisibleIndex = 2;
            this.FamiliaNombre.Width = 241;
            // 
            // ArticuloCantidad
            // 
            this.ArticuloCantidad.Caption = "Existencia";
            this.ArticuloCantidad.FieldName = "ArticuloCantidad";
            this.ArticuloCantidad.Name = "ArticuloCantidad";
            this.ArticuloCantidad.Visible = true;
            this.ArticuloCantidad.VisibleIndex = 3;
            this.ArticuloCantidad.Width = 59;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(17, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(248, 13);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Nota: Solo se muestran los articulos activos.";
            // 
            // Frm_BusqArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 435);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_BusqArticulo";
            this.Padding = new System.Windows.Forms.Padding(10, 30, 10, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Frm_BusqArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraGrid.GridControl Tabla;
        private DevExpress.XtraGrid.Views.Grid.GridView gridview;
        private DevExpress.XtraGrid.Columns.GridColumn ArticuloCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn ArticuloDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn FamiliaNombre;
        private DevExpress.XtraGrid.Columns.GridColumn ArticuloCantidad;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}