namespace assignment7
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.queryGroupBox = new System.Windows.Forms.GroupBox();
            this.queryLabel = new System.Windows.Forms.Label();
            this.controlGroupBox = new System.Windows.Forms.GroupBox();
            this.orderControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.deleteOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.sortGroupBox = new System.Windows.Forms.GroupBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.mainGroupBox.SuspendLayout();
            this.queryGroupBox.SuspendLayout();
            this.controlGroupBox.SuspendLayout();
            this.orderControlsGroupBox.SuspendLayout();
            this.deleteOrderGroupBox.SuspendLayout();
            this.sortGroupBox.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainGroupBox.Controls.Add(this.titleLabel);
            this.mainGroupBox.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mainGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainGroupBox.Location = new System.Drawing.Point(0, 0);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainGroupBox.Size = new System.Drawing.Size(451, 86);
            this.mainGroupBox.TabIndex = 0;
            this.mainGroupBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(96, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(308, 48);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "订单管理系统";
            // 
            // queryGroupBox
            // 
            this.queryGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryGroupBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.queryGroupBox.Controls.Add(this.queryLabel);
            this.queryGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.queryGroupBox.Location = new System.Drawing.Point(0, 182);
            this.queryGroupBox.Name = "queryGroupBox";
            this.queryGroupBox.Size = new System.Drawing.Size(519, 84);
            this.queryGroupBox.TabIndex = 2;
            this.queryGroupBox.TabStop = false;
            this.queryGroupBox.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Font = new System.Drawing.Font("楷体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queryLabel.Location = new System.Drawing.Point(6, 24);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(207, 33);
            this.queryLabel.TabIndex = 0;
            this.queryLabel.Text = "订单查询窗口";
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.controlGroupBox.Controls.Add(this.orderControlsGroupBox);
            this.controlGroupBox.Controls.Add(this.deleteOrderGroupBox);
            this.controlGroupBox.Controls.Add(this.sortGroupBox);
            this.controlGroupBox.Location = new System.Drawing.Point(864, 34);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Size = new System.Drawing.Size(208, 776);
            this.controlGroupBox.TabIndex = 6;
            this.controlGroupBox.TabStop = false;
            // 
            // orderControlsGroupBox
            // 
            this.orderControlsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.orderControlsGroupBox.Controls.Add(this.addOrderButton);
            this.orderControlsGroupBox.Location = new System.Drawing.Point(6, 80);
            this.orderControlsGroupBox.Name = "orderControlsGroupBox";
            this.orderControlsGroupBox.Size = new System.Drawing.Size(202, 90);
            this.orderControlsGroupBox.TabIndex = 8;
            this.orderControlsGroupBox.TabStop = false;
            // 
            // addOrderButton
            // 
            this.addOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addOrderButton.AutoSize = true;
            this.addOrderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addOrderButton.Font = new System.Drawing.Font("楷体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addOrderButton.Location = new System.Drawing.Point(6, 27);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(190, 38);
            this.addOrderButton.TabIndex = 0;
            this.addOrderButton.Text = "选择添加订单";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteOrderGroupBox
            // 
            this.deleteOrderGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteOrderGroupBox.Controls.Add(this.deleteOrderButton);
            this.deleteOrderGroupBox.Location = new System.Drawing.Point(8, 251);
            this.deleteOrderGroupBox.Name = "deleteOrderGroupBox";
            this.deleteOrderGroupBox.Size = new System.Drawing.Size(200, 100);
            this.deleteOrderGroupBox.TabIndex = 8;
            this.deleteOrderGroupBox.TabStop = false;
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteOrderButton.AutoSize = true;
            this.deleteOrderButton.Font = new System.Drawing.Font("楷体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deleteOrderButton.Location = new System.Drawing.Point(4, 27);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(190, 38);
            this.deleteOrderButton.TabIndex = 2;
            this.deleteOrderButton.Text = "点击删除订单";
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            this.deleteOrderButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // sortGroupBox
            // 
            this.sortGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sortGroupBox.Controls.Add(this.sortButton);
            this.sortGroupBox.Controls.Add(this.sortComboBox);
            this.sortGroupBox.Location = new System.Drawing.Point(4, 439);
            this.sortGroupBox.Name = "sortGroupBox";
            this.sortGroupBox.Size = new System.Drawing.Size(204, 130);
            this.sortGroupBox.TabIndex = 8;
            this.sortGroupBox.TabStop = false;
            // 
            // sortButton
            // 
            this.sortButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sortButton.Location = new System.Drawing.Point(123, 87);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 37);
            this.sortButton.TabIndex = 9;
            this.sortButton.Text = "确定";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // sortComboBox
            // 
            this.sortComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sortComboBox.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "默认排序",
            "id排序",
            "总价排序"});
            this.sortComboBox.Location = new System.Drawing.Point(4, 36);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(192, 32);
            this.sortComboBox.TabIndex = 7;
            this.sortComboBox.Text = "选择排序订单";
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.Controls.Add(this.dataGridView);
            this.panelContainer.Location = new System.Drawing.Point(0, 270);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(771, 540);
            this.panelContainer.TabIndex = 7;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.Size = new System.Drawing.Size(771, 540);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1071, 809);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.controlButton);
            this.Controls.Add(this.controlGroupBox);
            this.Controls.Add(this.queryGroupBox);
            this.Controls.Add(this.mainGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainGroupBox.ResumeLayout(false);
            this.mainGroupBox.PerformLayout();
            this.queryGroupBox.ResumeLayout(false);
            this.queryGroupBox.PerformLayout();
            this.controlGroupBox.ResumeLayout(false);
            this.orderControlsGroupBox.ResumeLayout(false);
            this.orderControlsGroupBox.PerformLayout();
            this.deleteOrderGroupBox.ResumeLayout(false);
            this.deleteOrderGroupBox.PerformLayout();
            this.sortGroupBox.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.GroupBox queryGroupBox;
        private System.Windows.Forms.GroupBox controlGroupBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox orderControlsGroupBox;
        private System.Windows.Forms.GroupBox deleteOrderGroupBox;
        private System.Windows.Forms.GroupBox sortGroupBox;
    }
}
