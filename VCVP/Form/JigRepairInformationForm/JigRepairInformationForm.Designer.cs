namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form
{
    partial class JigRepairInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JigRepairInformationForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.model_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.model_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.process_work_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.process_work_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.jigresponse_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.jigause_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.jigresponse_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.jigause_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.line_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.line_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.timefrom_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.timefrom_dtp = new Com.Nidec.Mes.Framework.DateTimePickerCommon();
            this.timeto_dtp = new Com.Nidec.Mes.Framework.DateTimePickerCommon();
            this.timeto_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.jig_repair_information_dgv = new Com.Nidec.Mes.Framework.DataGridViewCommon();
            this.setting_gbc = new Com.Nidec.Mes.Framework.GroupBoxCommon();
            this.update_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.add_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.clear_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.search_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.jig_code_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.jig_code_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.col_jig_repair_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_jig_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_model_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_line_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_process_work_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_jig_cause_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_response = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_time_from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_time_to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_before_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_after_repair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_repair_resuft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.jig_repair_information_dgv)).BeginInit();
            this.setting_gbc.SuspendLayout();
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
            // process_work_cmb
            // 
            resources.ApplyResources(this.process_work_cmb, "process_work_cmb");
            this.process_work_cmb.ControlId = null;
            this.process_work_cmb.FormattingEnabled = true;
            this.process_work_cmb.Name = "process_work_cmb";
            // 
            // process_work_lbl
            // 
            resources.ApplyResources(this.process_work_lbl, "process_work_lbl");
            this.process_work_lbl.ControlId = null;
            this.process_work_lbl.Name = "process_work_lbl";
            // 
            // jigresponse_lbl
            // 
            resources.ApplyResources(this.jigresponse_lbl, "jigresponse_lbl");
            this.jigresponse_lbl.ControlId = null;
            this.jigresponse_lbl.Name = "jigresponse_lbl";
            // 
            // jigause_cmb
            // 
            resources.ApplyResources(this.jigause_cmb, "jigause_cmb");
            this.jigause_cmb.ControlId = null;
            this.jigause_cmb.FormattingEnabled = true;
            this.jigause_cmb.Name = "jigause_cmb";
            // 
            // jigresponse_cmb
            // 
            resources.ApplyResources(this.jigresponse_cmb, "jigresponse_cmb");
            this.jigresponse_cmb.ControlId = null;
            this.jigresponse_cmb.FormattingEnabled = true;
            this.jigresponse_cmb.Name = "jigresponse_cmb";
            // 
            // jigause_lbl
            // 
            resources.ApplyResources(this.jigause_lbl, "jigause_lbl");
            this.jigause_lbl.ControlId = null;
            this.jigause_lbl.Name = "jigause_lbl";
            // 
            // line_lbl
            // 
            resources.ApplyResources(this.line_lbl, "line_lbl");
            this.line_lbl.ControlId = null;
            this.line_lbl.Name = "line_lbl";
            // 
            // line_cmb
            // 
            resources.ApplyResources(this.line_cmb, "line_cmb");
            this.line_cmb.ControlId = null;
            this.line_cmb.FormattingEnabled = true;
            this.line_cmb.Name = "line_cmb";
            // 
            // timefrom_lbl
            // 
            resources.ApplyResources(this.timefrom_lbl, "timefrom_lbl");
            this.timefrom_lbl.ControlId = null;
            this.timefrom_lbl.Name = "timefrom_lbl";
            // 
            // timefrom_dtp
            // 
            resources.ApplyResources(this.timefrom_dtp, "timefrom_dtp");
            this.timefrom_dtp.BackColor = System.Drawing.SystemColors.Control;
            this.timefrom_dtp.ControlId = null;
            this.timefrom_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timefrom_dtp.Name = "timefrom_dtp";
            this.timefrom_dtp.Value = new System.DateTime(2017, 6, 29, 0, 0, 0, 0);
            // 
            // timeto_dtp
            // 
            resources.ApplyResources(this.timeto_dtp, "timeto_dtp");
            this.timeto_dtp.BackColor = System.Drawing.SystemColors.Control;
            this.timeto_dtp.ControlId = null;
            this.timeto_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeto_dtp.Name = "timeto_dtp";
            // 
            // timeto_lbl
            // 
            resources.ApplyResources(this.timeto_lbl, "timeto_lbl");
            this.timeto_lbl.ControlId = null;
            this.timeto_lbl.Name = "timeto_lbl";
            // 
            // jig_repair_information_dgv
            // 
            resources.ApplyResources(this.jig_repair_information_dgv, "jig_repair_information_dgv");
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jig_repair_information_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.jig_repair_information_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_jig_repair_id,
            this.col_jig_code,
            this.col_model_name,
            this.col_line_name,
            this.col_process_work_name,
            this.col_jig_cause_name,
            this.col_response,
            this.col_time_from,
            this.col_time_to,
            this.col_before_status,
            this.col_after_repair,
            this.col_repair_resuft,
            this.col_place});
            this.jig_repair_information_dgv.ControlId = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.jig_repair_information_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.jig_repair_information_dgv.Name = "jig_repair_information_dgv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jig_repair_information_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            // 
            // setting_gbc
            // 
            resources.ApplyResources(this.setting_gbc, "setting_gbc");
            this.setting_gbc.ControlId = null;
            this.setting_gbc.Controls.Add(this.update_btn);
            this.setting_gbc.Controls.Add(this.add_btn);
            this.setting_gbc.Controls.Add(this.clear_btn);
            this.setting_gbc.Controls.Add(this.search_btn);
            this.setting_gbc.Name = "setting_gbc";
            this.setting_gbc.TabStop = false;
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
            // jig_code_txt
            // 
            resources.ApplyResources(this.jig_code_txt, "jig_code_txt");
            this.jig_code_txt.ControlId = null;
            this.jig_code_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.jig_code_txt.Name = "jig_code_txt";
            // 
            // jig_code_lbl
            // 
            resources.ApplyResources(this.jig_code_lbl, "jig_code_lbl");
            this.jig_code_lbl.ControlId = null;
            this.jig_code_lbl.Name = "jig_code_lbl";
            // 
            // col_jig_repair_id
            // 
            this.col_jig_repair_id.DataPropertyName = "JigRepairId";
            resources.ApplyResources(this.col_jig_repair_id, "col_jig_repair_id");
            this.col_jig_repair_id.Name = "col_jig_repair_id";
            this.col_jig_repair_id.ReadOnly = true;
            // 
            // col_jig_code
            // 
            this.col_jig_code.DataPropertyName = "JigRepairCode";
            resources.ApplyResources(this.col_jig_code, "col_jig_code");
            this.col_jig_code.Name = "col_jig_code";
            this.col_jig_code.ReadOnly = true;
            // 
            // col_model_name
            // 
            this.col_model_name.DataPropertyName = "ModelCode";
            resources.ApplyResources(this.col_model_name, "col_model_name");
            this.col_model_name.Name = "col_model_name";
            this.col_model_name.ReadOnly = true;
            // 
            // col_line_name
            // 
            this.col_line_name.DataPropertyName = "LineCode";
            resources.ApplyResources(this.col_line_name, "col_line_name");
            this.col_line_name.Name = "col_line_name";
            this.col_line_name.ReadOnly = true;
            // 
            // col_process_work_name
            // 
            this.col_process_work_name.DataPropertyName = "ProcessName";
            resources.ApplyResources(this.col_process_work_name, "col_process_work_name");
            this.col_process_work_name.Name = "col_process_work_name";
            this.col_process_work_name.ReadOnly = true;
            // 
            // col_jig_cause_name
            // 
            this.col_jig_cause_name.DataPropertyName = "JigCauseName";
            resources.ApplyResources(this.col_jig_cause_name, "col_jig_cause_name");
            this.col_jig_cause_name.Name = "col_jig_cause_name";
            this.col_jig_cause_name.ReadOnly = true;
            // 
            // col_response
            // 
            this.col_response.DataPropertyName = "JigResponseName";
            resources.ApplyResources(this.col_response, "col_response");
            this.col_response.Name = "col_response";
            this.col_response.ReadOnly = true;
            // 
            // col_time_from
            // 
            this.col_time_from.DataPropertyName = "TimeFrom";
            resources.ApplyResources(this.col_time_from, "col_time_from");
            this.col_time_from.Name = "col_time_from";
            this.col_time_from.ReadOnly = true;
            // 
            // col_time_to
            // 
            this.col_time_to.DataPropertyName = "TimeTo";
            resources.ApplyResources(this.col_time_to, "col_time_to");
            this.col_time_to.Name = "col_time_to";
            this.col_time_to.ReadOnly = true;
            // 
            // col_before_status
            // 
            this.col_before_status.DataPropertyName = "JigCurrentStatus";
            resources.ApplyResources(this.col_before_status, "col_before_status");
            this.col_before_status.Name = "col_before_status";
            this.col_before_status.ReadOnly = true;
            // 
            // col_after_repair
            // 
            this.col_after_repair.DataPropertyName = "JigAfterRepairStatus";
            resources.ApplyResources(this.col_after_repair, "col_after_repair");
            this.col_after_repair.Name = "col_after_repair";
            this.col_after_repair.ReadOnly = true;
            // 
            // col_repair_resuft
            // 
            this.col_repair_resuft.DataPropertyName = "JigRepairResult";
            resources.ApplyResources(this.col_repair_resuft, "col_repair_resuft");
            this.col_repair_resuft.Name = "col_repair_resuft";
            this.col_repair_resuft.ReadOnly = true;
            // 
            // col_place
            // 
            this.col_place.DataPropertyName = "JigPlace";
            resources.ApplyResources(this.col_place, "col_place");
            this.col_place.Name = "col_place";
            this.col_place.ReadOnly = true;
            // 
            // JigRepairInformationForm
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.jig_code_txt);
            this.Controls.Add(this.jig_code_lbl);
            this.Controls.Add(this.setting_gbc);
            this.Controls.Add(this.jig_repair_information_dgv);
            this.Controls.Add(this.timefrom_lbl);
            this.Controls.Add(this.timefrom_dtp);
            this.Controls.Add(this.timeto_dtp);
            this.Controls.Add(this.timeto_lbl);
            this.Controls.Add(this.jigresponse_lbl);
            this.Controls.Add(this.jigause_cmb);
            this.Controls.Add(this.jigresponse_cmb);
            this.Controls.Add(this.jigause_lbl);
            this.Controls.Add(this.process_work_cmb);
            this.Controls.Add(this.process_work_lbl);
            this.Controls.Add(this.line_cmb);
            this.Controls.Add(this.model_cmb);
            this.Controls.Add(this.line_lbl);
            this.Controls.Add(this.model_lbl);
            this.Name = "JigRepairInformationForm";
            this.Load += new System.EventHandler(this.JigRepairInformationForm_Load);
            this.Controls.SetChildIndex(this.model_lbl, 0);
            this.Controls.SetChildIndex(this.line_lbl, 0);
            this.Controls.SetChildIndex(this.model_cmb, 0);
            this.Controls.SetChildIndex(this.line_cmb, 0);
            this.Controls.SetChildIndex(this.process_work_lbl, 0);
            this.Controls.SetChildIndex(this.process_work_cmb, 0);
            this.Controls.SetChildIndex(this.jigause_lbl, 0);
            this.Controls.SetChildIndex(this.jigresponse_cmb, 0);
            this.Controls.SetChildIndex(this.jigause_cmb, 0);
            this.Controls.SetChildIndex(this.jigresponse_lbl, 0);
            this.Controls.SetChildIndex(this.timeto_lbl, 0);
            this.Controls.SetChildIndex(this.timeto_dtp, 0);
            this.Controls.SetChildIndex(this.timefrom_dtp, 0);
            this.Controls.SetChildIndex(this.timefrom_lbl, 0);
            this.Controls.SetChildIndex(this.jig_repair_information_dgv, 0);
            this.Controls.SetChildIndex(this.setting_gbc, 0);
            this.Controls.SetChildIndex(this.jig_code_lbl, 0);
            this.Controls.SetChildIndex(this.jig_code_txt, 0);
            ((System.ComponentModel.ISupportInitialize)(this.jig_repair_information_dgv)).EndInit();
            this.setting_gbc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Framework.ComboBoxCommon model_cmb;
        private Framework.LabelCommon model_lbl;
        private Framework.ComboBoxCommon process_work_cmb;
        private Framework.LabelCommon process_work_lbl;
        private Framework.LabelCommon jigresponse_lbl;
        private Framework.ComboBoxCommon jigause_cmb;
        private Framework.ComboBoxCommon jigresponse_cmb;
        private Framework.LabelCommon jigause_lbl;
        private Framework.LabelCommon line_lbl;
        private Framework.ComboBoxCommon line_cmb;
        private Framework.LabelCommon timefrom_lbl;
        private Framework.DateTimePickerCommon timefrom_dtp;
        private Framework.DateTimePickerCommon timeto_dtp;
        private Framework.LabelCommon timeto_lbl;
        private Framework.DataGridViewCommon jig_repair_information_dgv;
        private Framework.GroupBoxCommon setting_gbc;
        private Framework.ButtonCommon update_btn;
        private Framework.ButtonCommon add_btn;
        private Framework.ButtonCommon clear_btn;
        private Framework.ButtonCommon search_btn;
        private Framework.TextBoxCommon jig_code_txt;
        private Framework.LabelCommon jig_code_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_jig_repair_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_jig_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_model_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_line_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_process_work_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_jig_cause_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_response;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_time_from;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_time_to;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_before_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_after_repair;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_repair_resuft;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_place;
    }
}
