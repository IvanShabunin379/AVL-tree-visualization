
namespace Task1_generics
{
    partial class AVLTreeDemoForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.txtDisplayCount = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtDisplayIsEmpty = new System.Windows.Forms.TextBox();
            this.lblIsEmpty = new System.Windows.Forms.Label();
            this.lblProperties = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtInputValueContains = new System.Windows.Forms.TextBox();
            this.btnContains = new System.Windows.Forms.Button();
            this.txtInputRemovingValue = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtInputAddingValue = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblMethods = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.treeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkedTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrayTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unmutableTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forEachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftChildIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightChildIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NodeHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrayTreeView = new System.Windows.Forms.TreeView();
            this.linkedTreeView = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.txtDisplayCount);
            this.splitContainer.Panel1.Controls.Add(this.lblCount);
            this.splitContainer.Panel1.Controls.Add(this.txtDisplayIsEmpty);
            this.splitContainer.Panel1.Controls.Add(this.lblIsEmpty);
            this.splitContainer.Panel1.Controls.Add(this.lblProperties);
            this.splitContainer.Panel1.Controls.Add(this.btnClear);
            this.splitContainer.Panel1.Controls.Add(this.txtInputValueContains);
            this.splitContainer.Panel1.Controls.Add(this.btnContains);
            this.splitContainer.Panel1.Controls.Add(this.txtInputRemovingValue);
            this.splitContainer.Panel1.Controls.Add(this.btnRemove);
            this.splitContainer.Panel1.Controls.Add(this.txtInputAddingValue);
            this.splitContainer.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer.Panel1.Controls.Add(this.lblMethods);
            this.splitContainer.Panel1.Controls.Add(this.menuStrip);
            this.splitContainer.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer.Panel2.Controls.Add(this.arrayTreeView);
            this.splitContainer.Panel2.Controls.Add(this.linkedTreeView);
            this.splitContainer.Size = new System.Drawing.Size(653, 404);
            this.splitContainer.SplitterDistance = 217;
            this.splitContainer.TabIndex = 0;
            // 
            // txtDisplayCount
            // 
            this.txtDisplayCount.BackColor = System.Drawing.SystemColors.Window;
            this.txtDisplayCount.Location = new System.Drawing.Point(100, 346);
            this.txtDisplayCount.Name = "txtDisplayCount";
            this.txtDisplayCount.ReadOnly = true;
            this.txtDisplayCount.Size = new System.Drawing.Size(62, 27);
            this.txtDisplayCount.TabIndex = 13;
            this.txtDisplayCount.Visible = false;
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCount.Location = new System.Drawing.Point(19, 346);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(75, 27);
            this.lblCount.TabIndex = 12;
            this.lblCount.Text = "Count";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCount.Visible = false;
            // 
            // txtDisplayIsEmpty
            // 
            this.txtDisplayIsEmpty.BackColor = System.Drawing.SystemColors.Window;
            this.txtDisplayIsEmpty.Location = new System.Drawing.Point(100, 313);
            this.txtDisplayIsEmpty.Name = "txtDisplayIsEmpty";
            this.txtDisplayIsEmpty.ReadOnly = true;
            this.txtDisplayIsEmpty.Size = new System.Drawing.Size(62, 27);
            this.txtDisplayIsEmpty.TabIndex = 11;
            this.txtDisplayIsEmpty.Visible = false;
            // 
            // lblIsEmpty
            // 
            this.lblIsEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIsEmpty.Location = new System.Drawing.Point(19, 313);
            this.lblIsEmpty.Name = "lblIsEmpty";
            this.lblIsEmpty.Size = new System.Drawing.Size(75, 27);
            this.lblIsEmpty.TabIndex = 10;
            this.lblIsEmpty.Text = "IsEmpty";
            this.lblIsEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIsEmpty.Visible = false;
            // 
            // lblProperties
            // 
            this.lblProperties.Location = new System.Drawing.Point(44, 265);
            this.lblProperties.Name = "lblProperties";
            this.lblProperties.Size = new System.Drawing.Size(117, 48);
            this.lblProperties.TabIndex = 9;
            this.lblProperties.Text = "Properties:";
            this.lblProperties.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProperties.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(60, 204);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 27);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtInputValueContains
            // 
            this.txtInputValueContains.Location = new System.Drawing.Point(100, 170);
            this.txtInputValueContains.Name = "txtInputValueContains";
            this.txtInputValueContains.Size = new System.Drawing.Size(62, 27);
            this.txtInputValueContains.TabIndex = 7;
            this.txtInputValueContains.Visible = false;
            // 
            // btnContains
            // 
            this.btnContains.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnContains.Location = new System.Drawing.Point(19, 171);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(75, 27);
            this.btnContains.TabIndex = 6;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Visible = false;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // txtInputRemovingValue
            // 
            this.txtInputRemovingValue.Location = new System.Drawing.Point(100, 137);
            this.txtInputRemovingValue.Name = "txtInputRemovingValue";
            this.txtInputRemovingValue.Size = new System.Drawing.Size(62, 27);
            this.txtInputRemovingValue.TabIndex = 5;
            this.txtInputRemovingValue.Visible = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.Location = new System.Drawing.Point(19, 137);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 27);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Visible = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtInputAddingValue
            // 
            this.txtInputAddingValue.Location = new System.Drawing.Point(100, 104);
            this.txtInputAddingValue.Name = "txtInputAddingValue";
            this.txtInputAddingValue.Size = new System.Drawing.Size(62, 27);
            this.txtInputAddingValue.TabIndex = 3;
            this.txtInputAddingValue.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(19, 104);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 27);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblMethods
            // 
            this.lblMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMethods.Location = new System.Drawing.Point(45, 53);
            this.lblMethods.Name = "lblMethods";
            this.lblMethods.Size = new System.Drawing.Size(117, 48);
            this.lblMethods.TabIndex = 1;
            this.lblMethods.Text = "Methods:";
            this.lblMethods.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMethods.Visible = false;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.treeToolStripMenuItem,
            this.utilsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(213, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // treeToolStripMenuItem
            // 
            this.treeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linkedTreeToolStripMenuItem,
            this.arrayTreeToolStripMenuItem,
            this.unmutableTreeToolStripMenuItem});
            this.treeToolStripMenuItem.Name = "treeToolStripMenuItem";
            this.treeToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.treeToolStripMenuItem.Text = "Tree";
            // 
            // linkedTreeToolStripMenuItem
            // 
            this.linkedTreeToolStripMenuItem.Name = "linkedTreeToolStripMenuItem";
            this.linkedTreeToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.linkedTreeToolStripMenuItem.Text = "LinkedTree";
            this.linkedTreeToolStripMenuItem.Click += new System.EventHandler(this.linkedTreeToolStripMenuItem_Click);
            // 
            // arrayTreeToolStripMenuItem
            // 
            this.arrayTreeToolStripMenuItem.Name = "arrayTreeToolStripMenuItem";
            this.arrayTreeToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.arrayTreeToolStripMenuItem.Text = "ArrayTree";
            this.arrayTreeToolStripMenuItem.Click += new System.EventHandler(this.arrayTreeToolStripMenuItem_Click);
            // 
            // unmutableTreeToolStripMenuItem
            // 
            this.unmutableTreeToolStripMenuItem.Name = "unmutableTreeToolStripMenuItem";
            this.unmutableTreeToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.unmutableTreeToolStripMenuItem.Text = "UnmutableTree";
            this.unmutableTreeToolStripMenuItem.Click += new System.EventHandler(this.unmutableTreeToolStripMenuItem_Click);
            // 
            // utilsToolStripMenuItem
            // 
            this.utilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.existsToolStripMenuItem,
            this.findAllToolStripMenuItem,
            this.forEachToolStripMenuItem,
            this.checkForAllToolStripMenuItem});
            this.utilsToolStripMenuItem.Name = "utilsToolStripMenuItem";
            this.utilsToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.utilsToolStripMenuItem.Text = "Utils";
            // 
            // existsToolStripMenuItem
            // 
            this.existsToolStripMenuItem.Name = "existsToolStripMenuItem";
            this.existsToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.existsToolStripMenuItem.Text = "Exists";
            this.existsToolStripMenuItem.Click += new System.EventHandler(this.existsToolStripMenuItem_Click);
            // 
            // findAllToolStripMenuItem
            // 
            this.findAllToolStripMenuItem.Name = "findAllToolStripMenuItem";
            this.findAllToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.findAllToolStripMenuItem.Text = "FindAll";
            this.findAllToolStripMenuItem.Click += new System.EventHandler(this.findAllToolStripMenuItem_Click);
            // 
            // forEachToolStripMenuItem
            // 
            this.forEachToolStripMenuItem.Name = "forEachToolStripMenuItem";
            this.forEachToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.forEachToolStripMenuItem.Text = "ForEach";
            this.forEachToolStripMenuItem.Click += new System.EventHandler(this.forEachToolStripMenuItem_Click);
            // 
            // checkForAllToolStripMenuItem
            // 
            this.checkForAllToolStripMenuItem.Name = "checkForAllToolStripMenuItem";
            this.checkForAllToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.checkForAllToolStripMenuItem.Text = "CheckForAll";
            this.checkForAllToolStripMenuItem.Click += new System.EventHandler(this.checkForAllToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Value,
            this.LeftChildIndex,
            this.RightChildIndex,
            this.NodeHeight});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 50;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(207, 400);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.Visible = false;
            // 
            // Index
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Index.DefaultCellStyle = dataGridViewCellStyle6;
            this.Index.FillWeight = 16F;
            this.Index.HeaderText = "Ind";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.FillWeight = 34F;
            this.Value.HeaderText = "Value";
            this.Value.MinimumWidth = 6;
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // LeftChildIndex
            // 
            this.LeftChildIndex.FillWeight = 16F;
            this.LeftChildIndex.HeaderText = "L Ch Ind";
            this.LeftChildIndex.MinimumWidth = 6;
            this.LeftChildIndex.Name = "LeftChildIndex";
            this.LeftChildIndex.ReadOnly = true;
            // 
            // RightChildIndex
            // 
            this.RightChildIndex.FillWeight = 16F;
            this.RightChildIndex.HeaderText = "R Ch Ind";
            this.RightChildIndex.MinimumWidth = 6;
            this.RightChildIndex.Name = "RightChildIndex";
            this.RightChildIndex.ReadOnly = true;
            // 
            // NodeHeight
            // 
            this.NodeHeight.FillWeight = 16F;
            this.NodeHeight.HeaderText = "Ht";
            this.NodeHeight.MinimumWidth = 6;
            this.NodeHeight.Name = "NodeHeight";
            this.NodeHeight.ReadOnly = true;
            // 
            // arrayTreeView
            // 
            this.arrayTreeView.Dock = System.Windows.Forms.DockStyle.Right;
            this.arrayTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrayTreeView.Indent = 30;
            this.arrayTreeView.ItemHeight = 22;
            this.arrayTreeView.Location = new System.Drawing.Point(206, 0);
            this.arrayTreeView.Name = "arrayTreeView";
            this.arrayTreeView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.arrayTreeView.Size = new System.Drawing.Size(222, 400);
            this.arrayTreeView.TabIndex = 1;
            this.arrayTreeView.Visible = false;
            // 
            // linkedTreeView
            // 
            this.linkedTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkedTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkedTreeView.Indent = 50;
            this.linkedTreeView.ItemHeight = 26;
            this.linkedTreeView.Location = new System.Drawing.Point(0, 0);
            this.linkedTreeView.Name = "linkedTreeView";
            this.linkedTreeView.Size = new System.Drawing.Size(428, 400);
            this.linkedTreeView.TabIndex = 0;
            this.linkedTreeView.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 404);
            this.Controls.Add(this.splitContainer);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "AVL Tree Demo";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem treeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkedTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrayTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unmutableTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forEachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForAllToolStripMenuItem;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.TextBox txtInputRemovingValue;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtInputAddingValue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblMethods;
        private System.Windows.Forms.Label lblIsEmpty;
        private System.Windows.Forms.Label lblProperties;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtInputValueContains;
        private System.Windows.Forms.TextBox txtDisplayCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtDisplayIsEmpty;
        private System.Windows.Forms.TreeView linkedTreeView;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TreeView arrayTreeView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftChildIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightChildIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn NodeHeight;
    }
}

