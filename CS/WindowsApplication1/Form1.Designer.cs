﻿namespace WindowsApplication1 {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.treeList1 = new DevExpress.XtraTreeList.TreeList();
			this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
			this.SuspendLayout();
			// 
			// treeList1
			// 
			this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
			this.treeList1.Location = new System.Drawing.Point(51, 29);
			this.treeList1.Name = "treeList1";
			this.treeList1.BeginUnboundLoad();
			this.treeList1.AppendNode(new object[] {
            "NodeOne"}, -1);
			this.treeList1.AppendNode(new object[] {
            "NodeTwo"}, -1);
			this.treeList1.AppendNode(new object[] {
            "NodeThree"}, -1);
			this.treeList1.EndUnboundLoad();
			this.treeList1.Size = new System.Drawing.Size(557, 280);
			this.treeList1.TabIndex = 0;
			this.treeList1.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.treeList1_CustomDrawNodeCell);
			// 
			// treeListColumn1
			// 
			this.treeListColumn1.Caption = "treeListColumn1";
			this.treeListColumn1.FieldName = "treeListColumn1";
			this.treeListColumn1.Name = "treeListColumn1";
			this.treeListColumn1.Visible = true;
			this.treeListColumn1.VisibleIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(763, 373);
			this.Controls.Add(this.treeList1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraTreeList.TreeList treeList1;
		private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
	}
}

