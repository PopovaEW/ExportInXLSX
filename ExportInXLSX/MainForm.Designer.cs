namespace ExportInXLSX
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblErrorMain = new System.Windows.Forms.Label();
            this.gridPatient = new System.Windows.Forms.DataGridView();
            this.DecisionSignatureId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePdfFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSignPrint = new System.Windows.Forms.DataGridViewImageColumn();
            this.DecDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMBCARDNUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNILS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhysicianName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimaryPersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnExport);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(782, 46);
            this.pnlTop.TabIndex = 15;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(3, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(146, 40);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Выгрузить";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblErrorMain
            // 
            this.lblErrorMain.AutoSize = true;
            this.lblErrorMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblErrorMain.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblErrorMain.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMain.Location = new System.Drawing.Point(0, 46);
            this.lblErrorMain.MaximumSize = new System.Drawing.Size(980, 0);
            this.lblErrorMain.Name = "lblErrorMain";
            this.lblErrorMain.Size = new System.Drawing.Size(54, 19);
            this.lblErrorMain.TabIndex = 16;
            this.lblErrorMain.Text = "label2";
            this.lblErrorMain.Visible = false;
            // 
            // gridPatient
            // 
            this.gridPatient.AllowUserToAddRows = false;
            this.gridPatient.AllowUserToDeleteRows = false;
            this.gridPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPatient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridPatient.BackgroundColor = System.Drawing.Color.White;
            this.gridPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPatient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DecisionSignatureId,
            this.NamePdfFile,
            this.btnSignPrint,
            this.DecDate,
            this.AMBCARDNUM,
            this.paFullName,
            this.SNILS,
            this.PhysicianName,
            this.IncomingNumber,
            this.IncomingDate,
            this.PrimaryPersonId});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPatient.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPatient.EnableHeadersVisualStyles = false;
            this.gridPatient.GridColor = System.Drawing.Color.Silver;
            this.gridPatient.Location = new System.Drawing.Point(0, 65);
            this.gridPatient.MultiSelect = false;
            this.gridPatient.Name = "gridPatient";
            this.gridPatient.ReadOnly = true;
            this.gridPatient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridPatient.RowHeadersWidth = 25;
            this.gridPatient.RowTemplate.Height = 24;
            this.gridPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPatient.Size = new System.Drawing.Size(782, 390);
            this.gridPatient.TabIndex = 17;
            // 
            // DecisionSignatureId
            // 
            this.DecisionSignatureId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DecisionSignatureId.FillWeight = 50F;
            this.DecisionSignatureId.HeaderText = "DecisionSignatureId";
            this.DecisionSignatureId.Name = "DecisionSignatureId";
            this.DecisionSignatureId.ReadOnly = true;
            this.DecisionSignatureId.Visible = false;
            this.DecisionSignatureId.Width = 20;
            // 
            // NamePdfFile
            // 
            this.NamePdfFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NamePdfFile.FillWeight = 50F;
            this.NamePdfFile.HeaderText = "NamePdfFile";
            this.NamePdfFile.Name = "NamePdfFile";
            this.NamePdfFile.ReadOnly = true;
            this.NamePdfFile.Visible = false;
            this.NamePdfFile.Width = 20;
            // 
            // btnSignPrint
            // 
            this.btnSignPrint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnSignPrint.HeaderText = "";
            this.btnSignPrint.Image = global::ExportInXLSX.Properties.Resources.FilePdf;
            this.btnSignPrint.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnSignPrint.Name = "btnSignPrint";
            this.btnSignPrint.ReadOnly = true;
            this.btnSignPrint.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnSignPrint.Width = 32;
            // 
            // DecDate
            // 
            this.DecDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DecDate.DataPropertyName = "DecDate";
            dataGridViewCellStyle2.Format = "dd.MM.yyyy";
            this.DecDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.DecDate.HeaderText = "Дата документа";
            this.DecDate.Name = "DecDate";
            this.DecDate.ReadOnly = true;
            this.DecDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DecDate.Width = 90;
            // 
            // AMBCARDNUM
            // 
            this.AMBCARDNUM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AMBCARDNUM.DataPropertyName = "AMBCARDNUM";
            this.AMBCARDNUM.FillWeight = 95F;
            this.AMBCARDNUM.HeaderText = "№ АК";
            this.AMBCARDNUM.Name = "AMBCARDNUM";
            this.AMBCARDNUM.ReadOnly = true;
            this.AMBCARDNUM.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AMBCARDNUM.Width = 75;
            // 
            // paFullName
            // 
            this.paFullName.DataPropertyName = "paFullName";
            this.paFullName.FillWeight = 200F;
            this.paFullName.HeaderText = "Пациент";
            this.paFullName.MinimumWidth = 50;
            this.paFullName.Name = "paFullName";
            this.paFullName.ReadOnly = true;
            this.paFullName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SNILS
            // 
            this.SNILS.DataPropertyName = "SNILS";
            this.SNILS.HeaderText = "СНИЛС";
            this.SNILS.Name = "SNILS";
            this.SNILS.ReadOnly = true;
            this.SNILS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PhysicianName
            // 
            this.PhysicianName.DataPropertyName = "PhysicianName";
            this.PhysicianName.FillWeight = 200F;
            this.PhysicianName.HeaderText = "Врач";
            this.PhysicianName.Name = "PhysicianName";
            this.PhysicianName.ReadOnly = true;
            this.PhysicianName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // IncomingNumber
            // 
            this.IncomingNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IncomingNumber.DataPropertyName = "SPECNUMBER";
            this.IncomingNumber.HeaderText = "Исходящий номер";
            this.IncomingNumber.Name = "IncomingNumber";
            this.IncomingNumber.ReadOnly = true;
            this.IncomingNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IncomingNumber.Width = 120;
            // 
            // IncomingDate
            // 
            this.IncomingDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IncomingDate.DataPropertyName = "SPECDATE";
            dataGridViewCellStyle3.Format = "dd.MM.yyyy";
            this.IncomingDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.IncomingDate.FillWeight = 91F;
            this.IncomingDate.HeaderText = "Дата ответа";
            this.IncomingDate.Name = "IncomingDate";
            this.IncomingDate.ReadOnly = true;
            this.IncomingDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IncomingDate.Width = 90;
            // 
            // PrimaryPersonId
            // 
            this.PrimaryPersonId.HeaderText = "PrimaryPersonId";
            this.PrimaryPersonId.Name = "PrimaryPersonId";
            this.PrimaryPersonId.ReadOnly = true;
            this.PrimaryPersonId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PrimaryPersonId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PrimaryPersonId.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 455);
            this.Controls.Add(this.gridPatient);
            this.Controls.Add(this.lblErrorMain);
            this.Controls.Add(this.pnlTop);
            this.Name = "MainForm";
            this.Text = "Выгрузка данных в Excel";
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblErrorMain;
        private System.Windows.Forms.DataGridView gridPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn DecisionSignatureId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePdfFile;
        private System.Windows.Forms.DataGridViewImageColumn btnSignPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn DecDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMBCARDNUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn paFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNILS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhysicianName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimaryPersonId;
    }
}

