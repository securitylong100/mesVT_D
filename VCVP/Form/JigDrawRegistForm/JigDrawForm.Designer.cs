namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form
{
    partial class JigDrawForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JigDrawForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.model_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.model_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.process_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.process_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.supplier_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.supplier_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.timereceive_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.timereceive_dtp = new Com.Nidec.Mes.Framework.DateTimePickerCommon();
            this.jig_draw_dgv = new Com.Nidec.Mes.Framework.DataGridViewCommon();
            this.col_jig_repair_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_jig_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_model_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_process_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_drawing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_time_receive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.add_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.clear_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.search_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.drawing_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.drawing_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            ((System.ComponentModel.ISupportInitialize)(this.jig_draw_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // model_cmb
            // 
            resources.ApplyResources(this.model_cmb, "model_cmb");
            this.model_cmb.ControlId = null;
            this.model_cmb.FormattingEnabled = true;
            this.model_cmb.Name = "model_cmb";
            this.model_cmb.SelectedIndexChanged += new System.EventHandler(this.model_cmb_SelectedIndexChanged);
            // 
            // model_lbl
            // 
            resources.ApplyResources(this.model_lbl, "model_lbl");
            this.model_lbl.ControlId = null;
            this.model_lbl.Name = "model_lbl";
            // 
            // process_cmb
            // 
            resources.ApplyResources(this.process_cmb, "process_cmb");
            this.process_cmb.ControlId = null;
            this.process_cmb.FormattingEnabled = true;
            this.process_cmb.Name = "process_cmb";
            // 
            // process_lbl
            // 
            resources.ApplyResources(this.process_lbl, "process_lbl");
            this.process_lbl.ControlId = null;
            this.process_lbl.Name = "process_lbl";
            // 
            // supplier_cmb
            // 
            resources.ApplyResources(this.supplier_cmb, "supplier_cmb");
            this.supplier_cmb.ControlId = null;
            this.supplier_cmb.FormattingEnabled = true;
            this.supplier_cmb.Name = "supplier_cmb";
            // 
            // supplier_lbl
            // 
            resources.ApplyResources(this.supplier_lbl, "supplier_lbl");
            this.supplier_lbl.ControlId = null;
            this.supplier_lbl.Name = "supplier_lbl";
            // 
            // timereceive_lbl
            // 
            resources.ApplyResources(this.timereceive_lbl, "timereceive_lbl");
            this.timereceive_lbl.ControlId = null;
            this.timereceive_lbl.Name = "timereceive_lbl";
            // 
            // timereceive_dtp
            // 
            resources.ApplyResources(this.timereceive_dtp, "timereceive_dtp");
            this.timereceive_dtp.BackColor = System.Drawing.SystemColors.Control;
            this.timereceive_dtp.ControlId = null;
            this.timereceive_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timereceive_dtp.Name = "timereceive_dtp";
            this.timereceive_dtp.Value = new System.DateTime(2017, 7, 11, 0, 0, 0, 0);
            // 
            // jig_draw_dgv
            // 
            resources.ApplyResources(this.jig_draw_dgv, "jig_draw_dgv");
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jig_draw_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.jig_draw_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_jig_repair_id,
            this.col_jig_code,
            this.col_model_code,
            this.col_process_name,
            this.col_drawing,
            this.col_time_receive,
            this.col_place,
            this.col_supplier,
            this.col_status});
            this.jig_draw_dgv.ControlId = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.jig_draw_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.jig_draw_dgv.Name = "jig_draw_dgv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jig_draw_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            // 
            // col_jig_repair_id
            // 
            this.col_jig_repair_id.DataPropertyName = "JigId";
            resources.ApplyResources(this.col_jig_repair_id, "col_jig_repair_id");
            this.col_jig_repair_id.Name = "col_jig_repair_id";
            this.col_jig_repair_id.ReadOnly = true;
            // 
            // col_jig_code
            // 
            this.col_jig_code.DataPropertyName = "JigBCode";
            resources.ApplyResources(this.col_jig_code, "col_jig_code");
            this.col_jig_code.Name = "col_jig_code";
            this.col_jig_code.ReadOnly = true;
            // 
            // col_model_code
            // 
            this.col_model_code.DataPropertyName = "ModelCode";
            resources.ApplyResources(this.col_model_code, "col_model_code");
            this.col_model_code.Name = "col_model_code";
            this.col_model_code.ReadOnly = true;
            // 
            // col_process_name
            // 
            this.col_process_name.DataPropertyName = "ProcessName";
            resources.ApplyResources(this.col_process_name, "col_process_name");
            this.col_process_name.Name = "col_process_name";
            this.col_process_name.ReadOnly = true;
            // 
            // col_drawing
            // 
            this.col_drawing.DataPropertyName = "DrawCode";
            resources.ApplyResources(this.col_drawing, "col_drawing");
            this.col_drawing.Name = "col_drawing";
            // 
            // col_time_receive
            // 
            this.col_time_receive.DataPropertyName = "TimeReceive";
            resources.ApplyResources(this.col_time_receive, "col_time_receive");
            this.col_time_receive.Name = "col_time_receive";
            this.col_time_receive.ReadOnly = true;
            // 
            // col_place
            // 
            this.col_place.DataPropertyName = "JigPlace";
            resources.ApplyResources(this.col_place, "col_place");
            this.col_place.Name = "col_place";
            this.col_place.ReadOnly = true;
            // 
            // col_supplier
            // 
            this.col_supplier.DataPropertyName = "SupplierName";
            resources.ApplyResources(this.col_supplier, "col_supplier");
            this.col_supplier.Name = "col_supplier";
            // 
            // col_status
            // 
            this.col_status.DataPropertyName = "Status";
            resources.ApplyResources(this.col_status, "col_status");
            this.col_status.Name = "col_status";
            // 
            // update_btn
            // 
            resources.ApplyResources(this.update_btn, "update_btn");
            this.update_btn.BackColor = System.Drawing.SystemColors.Control;
            this.update_btn.ControlId = "";
            this.update_btn.Name = "update_btn";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // add_btn
            // 
            resources.ApplyResources(this.add_btn, "add_btn");
            this.add_btn.BackColor = System.Drawing.SystemColors.Control;
            this.add_btn.ControlId = "";
            this.add_btn.Name = "add_btn";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // clear_btn
            // 
            resources.ApplyResources(this.clear_btn, "clear_btn");
            this.clear_btn.BackColor = System.Drawing.SystemColors.Control;
            this.clear_btn.ControlId = null;
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // search_btn
            // 
            resources.ApplyResources(this.search_btn, "search_btn");
            this.search_btn.BackColor = System.Drawing.SystemColors.Control;
            this.search_btn.ControlId = null;
            this.search_btn.Name = "search_btn";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // drawing_lbl
            // 
            resources.ApplyResources(this.drawing_lbl, "drawing_lbl");
            this.drawing_lbl.ControlId = null;
            this.drawing_lbl.Name = "drawing_lbl";
            // 
            // drawing_cmb
            // 
            resources.ApplyResources(this.drawing_cmb, "drawing_cmb");
            this.drawing_cmb.ControlId = null;
            this.drawing_cmb.FormattingEnabled = true;
            this.drawing_cmb.Name = "drawing_cmb";
            // 
            // JigDrawForm
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.jig_draw_dgv);
            this.Controls.Add(this.timereceive_lbl);
            this.Controls.Add(this.timereceive_dtp);
            this.Controls.Add(this.supplier_cmb);
            this.Controls.Add(this.supplier_lbl);
            this.Controls.Add(this.drawing_cmb);
            this.Controls.Add(this.drawing_lbl);
            this.Controls.Add(this.process_cmb);
            this.Controls.Add(this.process_lbl);
            this.Controls.Add(this.model_cmb);
            this.Controls.Add(this.model_lbl);
            this.Name = "JigDrawForm";
            this.Load += new System.EventHandler(this.JigDrawForm_Load);
            this.Controls.SetChildIndex(this.model_lbl, 0);
            this.Controls.SetChildIndex(this.model_cmb, 0);
            this.Controls.SetChildIndex(this.process_lbl, 0);
            this.Controls.SetChildIndex(this.process_cmb, 0);
            this.Controls.SetChildIndex(this.drawing_lbl, 0);
            this.Controls.SetChildIndex(this.drawing_cmb, 0);
            this.Controls.SetChildIndex(this.supplier_lbl, 0);
            this.Controls.SetChildIndex(this.supplier_cmb, 0);
            this.Controls.SetChildIndex(this.timereceive_dtp, 0);
            this.Controls.SetChildIndex(this.timereceive_lbl, 0);
            this.Controls.SetChildIndex(this.jig_draw_dgv, 0);
            this.Controls.SetChildIndex(this.add_btn, 0);
            this.Controls.SetChildIndex(this.update_btn, 0);
            this.Controls.SetChildIndex(this.clear_btn, 0);
            this.Controls.SetChildIndex(this.search_btn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.jig_draw_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Framework.ComboBoxCommon model_cmb;
        private Framework.LabelCommon model_lbl;
        private Framework.ComboBoxCommon process_cmb;
        private Framework.LabelCommon process_lbl;
        private Framework.ComboBoxCommon supplier_cmb;
        private Framework.LabelCommon supplier_lbl;
        private Framework.LabelCommon timereceive_lbl;
        private Framework.DateTimePickerCommon timereceive_dtp;
        private Framework.DataGridViewCommon jig_draw_dgv;
        private Framework.ButtonCommon update_btn;
        private Framework.ButtonCommon add_btn;
        private Framework.ButtonCommon clear_btn;
        private Framework.ButtonCommon search_btn;
        private Framework.LabelCommon drawing_lbl;
        private Framework.ComboBoxCommon drawing_cmb;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_jig_repair_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_jig_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_model_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_process_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_drawing;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_time_receive;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_place;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
    }
}
