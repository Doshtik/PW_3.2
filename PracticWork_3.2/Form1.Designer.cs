namespace PracticWork_3._2
{
    partial class FormPW3
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTitle = new Panel();
            labelPartnersTable = new Label();
            panelDataGrids = new Panel();
            panelInfo = new Panel();
            dataGridInfo = new DataGridView();
            panelPartners = new Panel();
            dataGridPartners = new DataGridView();
            panelTitle.SuspendLayout();
            panelDataGrids.SuspendLayout();
            panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridInfo).BeginInit();
            panelPartners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPartners).BeginInit();
            SuspendLayout();
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(labelPartnersTable);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1470, 50);
            panelTitle.TabIndex = 0;
            // 
            // labelPartnersTable
            // 
            labelPartnersTable.Dock = DockStyle.Fill;
            labelPartnersTable.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPartnersTable.Location = new Point(0, 0);
            labelPartnersTable.Name = "labelPartnersTable";
            labelPartnersTable.Size = new Size(1470, 50);
            labelPartnersTable.TabIndex = 0;
            labelPartnersTable.Text = "Таблица Партнеры";
            labelPartnersTable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDataGrids
            // 
            panelDataGrids.Controls.Add(panelInfo);
            panelDataGrids.Controls.Add(panelPartners);
            panelDataGrids.Dock = DockStyle.Fill;
            panelDataGrids.Location = new Point(0, 50);
            panelDataGrids.Name = "panelDataGrids";
            panelDataGrids.Size = new Size(1470, 580);
            panelDataGrids.TabIndex = 1;
            // 
            // panelInfo
            // 
            panelInfo.Controls.Add(dataGridInfo);
            panelInfo.Dock = DockStyle.Fill;
            panelInfo.Location = new Point(932, 0);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(538, 580);
            panelInfo.TabIndex = 1;
            // 
            // dataGridInfo
            // 
            dataGridInfo.BackgroundColor = SystemColors.Control;
            dataGridInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridInfo.Dock = DockStyle.Fill;
            dataGridInfo.Location = new Point(0, 0);
            dataGridInfo.Name = "dataGridInfo";
            dataGridInfo.ReadOnly = true;
            dataGridInfo.Size = new Size(538, 580);
            dataGridInfo.TabIndex = 0;
            // 
            // panelPartners
            // 
            panelPartners.Controls.Add(dataGridPartners);
            panelPartners.Dock = DockStyle.Left;
            panelPartners.Location = new Point(0, 0);
            panelPartners.Name = "panelPartners";
            panelPartners.Size = new Size(932, 580);
            panelPartners.TabIndex = 0;
            // 
            // dataGridPartners
            // 
            dataGridPartners.BackgroundColor = SystemColors.Control;
            dataGridPartners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPartners.Dock = DockStyle.Fill;
            dataGridPartners.Location = new Point(0, 0);
            dataGridPartners.Name = "dataGridPartners";
            dataGridPartners.ReadOnly = true;
            dataGridPartners.Size = new Size(932, 580);
            dataGridPartners.TabIndex = 0;
            dataGridPartners.SelectionChanged += DataGridPartners_SelectionChanged;
            // 
            // FormPW3
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1470, 630);
            Controls.Add(panelDataGrids);
            Controls.Add(panelTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormPW3";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Таблица Партнеры";
            panelTitle.ResumeLayout(false);
            panelDataGrids.ResumeLayout(false);
            panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridInfo).EndInit();
            panelPartners.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridPartners).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitle;
        private Label labelPartnersTable;
        private Panel panelDataGrids;
        private Panel panelInfo;
        private Panel panelPartners;
        private DataGridView dataGridPartners;
        private DataGridView dataGridInfo;
    }
}
