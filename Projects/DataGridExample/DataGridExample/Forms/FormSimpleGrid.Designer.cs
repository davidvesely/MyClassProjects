﻿namespace DataGridExample.Forms
{
    partial class FormSimpleGrid
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.entityDataSource1 = new EFWinforms.EntityDataSource(this.components);
            this.radButtonSave = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSave)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGridView1.Location = new System.Drawing.Point(13, 13);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "FIRST_NAME";
            gridViewTextBoxColumn1.HeaderText = "FIRST_NAME";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "FIRST_NAME";
            gridViewTextBoxColumn1.Width = 108;
            gridViewTextBoxColumn2.FieldName = "LAST_NAME";
            gridViewTextBoxColumn2.HeaderText = "LAST_NAME";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "LAST_NAME";
            gridViewTextBoxColumn2.Width = 108;
            gridViewTextBoxColumn3.FieldName = "EMAIL";
            gridViewTextBoxColumn3.HeaderText = "EMAIL";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "EMAIL";
            gridViewTextBoxColumn3.Width = 108;
            gridViewTextBoxColumn4.FieldName = "PHONE_NUMBER";
            gridViewTextBoxColumn4.HeaderText = "PHONE_NUMBER";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "PHONE_NUMBER";
            gridViewTextBoxColumn4.Width = 108;
            gridViewDateTimeColumn1.FieldName = "HIRE_DATE";
            gridViewDateTimeColumn1.HeaderText = "HIRE_DATE";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "HIRE_DATE";
            gridViewDateTimeColumn1.Width = 108;
            gridViewDecimalColumn1.DataType = typeof(System.Nullable<decimal>);
            gridViewDecimalColumn1.FieldName = "SALARY";
            gridViewDecimalColumn1.HeaderText = "SALARY";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "SALARY";
            gridViewDecimalColumn1.Width = 108;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<decimal>);
            gridViewDecimalColumn2.FieldName = "COMMISSION_PCT";
            gridViewDecimalColumn2.HeaderText = "COMMISSION_PCT";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "COMMISSION_PCT";
            gridViewDecimalColumn2.Width = 108;
            gridViewComboBoxColumn1.DataSource = this.entityDataSource1;
            gridViewComboBoxColumn1.DisplayMember = "DEPARTMENTS.DEPARTMENT_NAME";
            gridViewComboBoxColumn1.FieldName = "EMPLOYEES.DEPARTMENT_ID";
            gridViewComboBoxColumn1.HeaderText = "Department";
            gridViewComboBoxColumn1.Name = "Department";
            gridViewComboBoxColumn1.ValueMember = "DEPARTMENTS.DEPARTMENT_ID";
            gridViewComboBoxColumn1.Width = 76;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDateTimeColumn1,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewComboBoxColumn1});
            this.radGridView1.MasterTemplate.DataMember = "EMPLOYEES";
            this.radGridView1.MasterTemplate.DataSource = this.entityDataSource1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(845, 734);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            // 
            // entityDataSource1
            // 
            this.entityDataSource1.DbContextType = typeof(DataGridExample.DatabaseModel.HREntities);
            // 
            // radButtonSave
            // 
            this.radButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radButtonSave.Location = new System.Drawing.Point(748, 753);
            this.radButtonSave.Name = "radButtonSave";
            this.radButtonSave.Size = new System.Drawing.Size(110, 24);
            this.radButtonSave.TabIndex = 1;
            this.radButtonSave.Text = "Save";
            this.radButtonSave.Click += new System.EventHandler(this.radButtonSave_Click);
            // 
            // FormSimpleGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 789);
            this.Controls.Add(this.radButtonSave);
            this.Controls.Add(this.radGridView1);
            this.Name = "FormSimpleGrid";
            this.Text = "FormSimpleGrid";
            this.Load += new System.EventHandler(this.FormSimpleGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton radButtonSave;
        private EFWinforms.EntityDataSource entityDataSource1;
    }
}