namespace Vynas
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fixedAcidityTextBox = new System.Windows.Forms.TextBox();
            this.fixedAcidityLabel = new System.Windows.Forms.Label();
            this.volatileAcidityLabel = new System.Windows.Forms.Label();
            this.volatileAcidityTextBox = new System.Windows.Forms.TextBox();
            this.residualSugarLabel = new System.Windows.Forms.Label();
            this.residualSugarTextBox = new System.Windows.Forms.TextBox();
            this.citricAcidLabel = new System.Windows.Forms.Label();
            this.citricAcidTextBox = new System.Windows.Forms.TextBox();
            this.chloridesLabel = new System.Windows.Forms.Label();
            this.chloridesTextBox = new System.Windows.Forms.TextBox();
            this.freeSulfurDioxide = new System.Windows.Forms.Label();
            this.freeSulfurDioxideTextBox = new System.Windows.Forms.TextBox();
            this.totalSulfurDioxide = new System.Windows.Forms.Label();
            this.totalSulfurDioxideTextBox = new System.Windows.Forms.TextBox();
            this.densityLabel = new System.Windows.Forms.Label();
            this.densityTextBox = new System.Windows.Forms.TextBox();
            this.pHLabel = new System.Windows.Forms.Label();
            this.pHTextBox = new System.Windows.Forms.TextBox();
            this.sulphatesLabel = new System.Windows.Forms.Label();
            this.sulphatesTextBox = new System.Windows.Forms.TextBox();
            this.alcoholLabel = new System.Windows.Forms.Label();
            this.alcoholTextBox = new System.Windows.Forms.TextBox();
            this.kLabel = new System.Windows.Forms.Label();
            this.kTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixedAcidityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volatileAcidityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citricAcidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residualSugarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chloridesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeSulfurDioxideDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSulfurDioxideDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.densityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sulphatesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alcoholDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.redwineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knnDataSet = new Vynas.knnDataSet();
            this.redwineTableAdapter = new Vynas.knnDataSetTableAdapters.redwineTableAdapter();
            this.firstFormulaRadioButton = new System.Windows.Forms.RadioButton();
            this.secondFormulaRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redwineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knnDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Vynas.Properties.Resources.external_content_duckduckgo_com;
            this.pictureBox1.Location = new System.Drawing.Point(12, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quality";
            // 
            // fixedAcidityTextBox
            // 
            this.fixedAcidityTextBox.Location = new System.Drawing.Point(426, 53);
            this.fixedAcidityTextBox.Name = "fixedAcidityTextBox";
            this.fixedAcidityTextBox.Size = new System.Drawing.Size(100, 20);
            this.fixedAcidityTextBox.TabIndex = 3;
            // 
            // fixedAcidityLabel
            // 
            this.fixedAcidityLabel.AutoSize = true;
            this.fixedAcidityLabel.Location = new System.Drawing.Point(423, 37);
            this.fixedAcidityLabel.Name = "fixedAcidityLabel";
            this.fixedAcidityLabel.Size = new System.Drawing.Size(65, 13);
            this.fixedAcidityLabel.TabIndex = 4;
            this.fixedAcidityLabel.Text = "Fixed acidity";
            // 
            // volatileAcidityLabel
            // 
            this.volatileAcidityLabel.AutoSize = true;
            this.volatileAcidityLabel.Location = new System.Drawing.Point(423, 76);
            this.volatileAcidityLabel.Name = "volatileAcidityLabel";
            this.volatileAcidityLabel.Size = new System.Drawing.Size(75, 13);
            this.volatileAcidityLabel.TabIndex = 6;
            this.volatileAcidityLabel.Text = "Volatile Acidity";
            // 
            // volatileAcidityTextBox
            // 
            this.volatileAcidityTextBox.Location = new System.Drawing.Point(426, 92);
            this.volatileAcidityTextBox.Name = "volatileAcidityTextBox";
            this.volatileAcidityTextBox.Size = new System.Drawing.Size(100, 20);
            this.volatileAcidityTextBox.TabIndex = 5;
            // 
            // residualSugarLabel
            // 
            this.residualSugarLabel.AutoSize = true;
            this.residualSugarLabel.Location = new System.Drawing.Point(423, 154);
            this.residualSugarLabel.Name = "residualSugarLabel";
            this.residualSugarLabel.Size = new System.Drawing.Size(79, 13);
            this.residualSugarLabel.TabIndex = 8;
            this.residualSugarLabel.Text = "Residual Sugar";
            // 
            // residualSugarTextBox
            // 
            this.residualSugarTextBox.Location = new System.Drawing.Point(426, 170);
            this.residualSugarTextBox.Name = "residualSugarTextBox";
            this.residualSugarTextBox.Size = new System.Drawing.Size(100, 20);
            this.residualSugarTextBox.TabIndex = 7;
            // 
            // citricAcidLabel
            // 
            this.citricAcidLabel.AutoSize = true;
            this.citricAcidLabel.Location = new System.Drawing.Point(423, 115);
            this.citricAcidLabel.Name = "citricAcidLabel";
            this.citricAcidLabel.Size = new System.Drawing.Size(54, 13);
            this.citricAcidLabel.TabIndex = 10;
            this.citricAcidLabel.Text = "Citric Acid";
            // 
            // citricAcidTextBox
            // 
            this.citricAcidTextBox.Location = new System.Drawing.Point(426, 131);
            this.citricAcidTextBox.Name = "citricAcidTextBox";
            this.citricAcidTextBox.Size = new System.Drawing.Size(100, 20);
            this.citricAcidTextBox.TabIndex = 9;
            // 
            // chloridesLabel
            // 
            this.chloridesLabel.AutoSize = true;
            this.chloridesLabel.Location = new System.Drawing.Point(423, 193);
            this.chloridesLabel.Name = "chloridesLabel";
            this.chloridesLabel.Size = new System.Drawing.Size(50, 13);
            this.chloridesLabel.TabIndex = 12;
            this.chloridesLabel.Text = "Chlorides";
            // 
            // chloridesTextBox
            // 
            this.chloridesTextBox.Location = new System.Drawing.Point(426, 209);
            this.chloridesTextBox.Name = "chloridesTextBox";
            this.chloridesTextBox.Size = new System.Drawing.Size(100, 20);
            this.chloridesTextBox.TabIndex = 11;
            // 
            // freeSulfurDioxide
            // 
            this.freeSulfurDioxide.AutoSize = true;
            this.freeSulfurDioxide.Location = new System.Drawing.Point(423, 232);
            this.freeSulfurDioxide.Name = "freeSulfurDioxide";
            this.freeSulfurDioxide.Size = new System.Drawing.Size(96, 13);
            this.freeSulfurDioxide.TabIndex = 14;
            this.freeSulfurDioxide.Text = "Free Sulfur Dioxide";
            // 
            // freeSulfurDioxideTextBox
            // 
            this.freeSulfurDioxideTextBox.Location = new System.Drawing.Point(426, 248);
            this.freeSulfurDioxideTextBox.Name = "freeSulfurDioxideTextBox";
            this.freeSulfurDioxideTextBox.Size = new System.Drawing.Size(100, 20);
            this.freeSulfurDioxideTextBox.TabIndex = 13;
            // 
            // totalSulfurDioxide
            // 
            this.totalSulfurDioxide.AutoSize = true;
            this.totalSulfurDioxide.Location = new System.Drawing.Point(556, 37);
            this.totalSulfurDioxide.Name = "totalSulfurDioxide";
            this.totalSulfurDioxide.Size = new System.Drawing.Size(99, 13);
            this.totalSulfurDioxide.TabIndex = 16;
            this.totalSulfurDioxide.Text = "Total Sulfur Dioxide";
            // 
            // totalSulfurDioxideTextBox
            // 
            this.totalSulfurDioxideTextBox.Location = new System.Drawing.Point(559, 53);
            this.totalSulfurDioxideTextBox.Name = "totalSulfurDioxideTextBox";
            this.totalSulfurDioxideTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalSulfurDioxideTextBox.TabIndex = 15;
            // 
            // densityLabel
            // 
            this.densityLabel.AutoSize = true;
            this.densityLabel.Location = new System.Drawing.Point(556, 76);
            this.densityLabel.Name = "densityLabel";
            this.densityLabel.Size = new System.Drawing.Size(42, 13);
            this.densityLabel.TabIndex = 18;
            this.densityLabel.Text = "Density";
            // 
            // densityTextBox
            // 
            this.densityTextBox.Location = new System.Drawing.Point(559, 92);
            this.densityTextBox.Name = "densityTextBox";
            this.densityTextBox.Size = new System.Drawing.Size(100, 20);
            this.densityTextBox.TabIndex = 17;
            // 
            // pHLabel
            // 
            this.pHLabel.AutoSize = true;
            this.pHLabel.Location = new System.Drawing.Point(556, 115);
            this.pHLabel.Name = "pHLabel";
            this.pHLabel.Size = new System.Drawing.Size(21, 13);
            this.pHLabel.TabIndex = 20;
            this.pHLabel.Text = "pH";
            // 
            // pHTextBox
            // 
            this.pHTextBox.Location = new System.Drawing.Point(559, 131);
            this.pHTextBox.Name = "pHTextBox";
            this.pHTextBox.Size = new System.Drawing.Size(100, 20);
            this.pHTextBox.TabIndex = 19;
            // 
            // sulphatesLabel
            // 
            this.sulphatesLabel.AutoSize = true;
            this.sulphatesLabel.Location = new System.Drawing.Point(556, 154);
            this.sulphatesLabel.Name = "sulphatesLabel";
            this.sulphatesLabel.Size = new System.Drawing.Size(54, 13);
            this.sulphatesLabel.TabIndex = 22;
            this.sulphatesLabel.Text = "Sulphates";
            // 
            // sulphatesTextBox
            // 
            this.sulphatesTextBox.Location = new System.Drawing.Point(559, 170);
            this.sulphatesTextBox.Name = "sulphatesTextBox";
            this.sulphatesTextBox.Size = new System.Drawing.Size(100, 20);
            this.sulphatesTextBox.TabIndex = 21;
            // 
            // alcoholLabel
            // 
            this.alcoholLabel.AutoSize = true;
            this.alcoholLabel.Location = new System.Drawing.Point(556, 193);
            this.alcoholLabel.Name = "alcoholLabel";
            this.alcoholLabel.Size = new System.Drawing.Size(42, 13);
            this.alcoholLabel.TabIndex = 24;
            this.alcoholLabel.Text = "Alcohol";
            // 
            // alcoholTextBox
            // 
            this.alcoholTextBox.Location = new System.Drawing.Point(559, 209);
            this.alcoholTextBox.Name = "alcoholTextBox";
            this.alcoholTextBox.Size = new System.Drawing.Size(100, 20);
            this.alcoholTextBox.TabIndex = 23;
            // 
            // kLabel
            // 
            this.kLabel.AutoSize = true;
            this.kLabel.Location = new System.Drawing.Point(556, 232);
            this.kLabel.Name = "kLabel";
            this.kLabel.Size = new System.Drawing.Size(13, 13);
            this.kLabel.TabIndex = 26;
            this.kLabel.Text = "k";
            // 
            // kTextBox
            // 
            this.kTextBox.Location = new System.Drawing.Point(559, 248);
            this.kTextBox.Name = "kTextBox";
            this.kTextBox.Size = new System.Drawing.Size(100, 20);
            this.kTextBox.TabIndex = 25;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(686, 50);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 27;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fixedAcidityDataGridViewTextBoxColumn,
            this.volatileAcidityDataGridViewTextBoxColumn,
            this.citricAcidDataGridViewTextBoxColumn,
            this.residualSugarDataGridViewTextBoxColumn,
            this.chloridesDataGridViewTextBoxColumn,
            this.freeSulfurDioxideDataGridViewTextBoxColumn,
            this.totalSulfurDioxideDataGridViewTextBoxColumn,
            this.densityDataGridViewTextBoxColumn,
            this.pHDataGridViewTextBoxColumn,
            this.sulphatesDataGridViewTextBoxColumn,
            this.alcoholDataGridViewTextBoxColumn,
            this.qualityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.redwineBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1030, 204);
            this.dataGridView1.TabIndex = 28;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fixedAcidityDataGridViewTextBoxColumn
            // 
            this.fixedAcidityDataGridViewTextBoxColumn.DataPropertyName = "fixedAcidity";
            this.fixedAcidityDataGridViewTextBoxColumn.HeaderText = "fixedAcidity";
            this.fixedAcidityDataGridViewTextBoxColumn.Name = "fixedAcidityDataGridViewTextBoxColumn";
            this.fixedAcidityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volatileAcidityDataGridViewTextBoxColumn
            // 
            this.volatileAcidityDataGridViewTextBoxColumn.DataPropertyName = "volatileAcidity";
            this.volatileAcidityDataGridViewTextBoxColumn.HeaderText = "volatileAcidity";
            this.volatileAcidityDataGridViewTextBoxColumn.Name = "volatileAcidityDataGridViewTextBoxColumn";
            this.volatileAcidityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // citricAcidDataGridViewTextBoxColumn
            // 
            this.citricAcidDataGridViewTextBoxColumn.DataPropertyName = "citricAcid";
            this.citricAcidDataGridViewTextBoxColumn.HeaderText = "citricAcid";
            this.citricAcidDataGridViewTextBoxColumn.Name = "citricAcidDataGridViewTextBoxColumn";
            this.citricAcidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // residualSugarDataGridViewTextBoxColumn
            // 
            this.residualSugarDataGridViewTextBoxColumn.DataPropertyName = "residualSugar";
            this.residualSugarDataGridViewTextBoxColumn.HeaderText = "residualSugar";
            this.residualSugarDataGridViewTextBoxColumn.Name = "residualSugarDataGridViewTextBoxColumn";
            this.residualSugarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chloridesDataGridViewTextBoxColumn
            // 
            this.chloridesDataGridViewTextBoxColumn.DataPropertyName = "chlorides";
            this.chloridesDataGridViewTextBoxColumn.HeaderText = "chlorides";
            this.chloridesDataGridViewTextBoxColumn.Name = "chloridesDataGridViewTextBoxColumn";
            this.chloridesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // freeSulfurDioxideDataGridViewTextBoxColumn
            // 
            this.freeSulfurDioxideDataGridViewTextBoxColumn.DataPropertyName = "freeSulfurDioxide";
            this.freeSulfurDioxideDataGridViewTextBoxColumn.HeaderText = "freeSulfurDioxide";
            this.freeSulfurDioxideDataGridViewTextBoxColumn.Name = "freeSulfurDioxideDataGridViewTextBoxColumn";
            this.freeSulfurDioxideDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalSulfurDioxideDataGridViewTextBoxColumn
            // 
            this.totalSulfurDioxideDataGridViewTextBoxColumn.DataPropertyName = "totalSulfurDioxide";
            this.totalSulfurDioxideDataGridViewTextBoxColumn.HeaderText = "totalSulfurDioxide";
            this.totalSulfurDioxideDataGridViewTextBoxColumn.Name = "totalSulfurDioxideDataGridViewTextBoxColumn";
            this.totalSulfurDioxideDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // densityDataGridViewTextBoxColumn
            // 
            this.densityDataGridViewTextBoxColumn.DataPropertyName = "density";
            this.densityDataGridViewTextBoxColumn.HeaderText = "density";
            this.densityDataGridViewTextBoxColumn.Name = "densityDataGridViewTextBoxColumn";
            this.densityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pHDataGridViewTextBoxColumn
            // 
            this.pHDataGridViewTextBoxColumn.DataPropertyName = "pH";
            this.pHDataGridViewTextBoxColumn.HeaderText = "pH";
            this.pHDataGridViewTextBoxColumn.Name = "pHDataGridViewTextBoxColumn";
            this.pHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sulphatesDataGridViewTextBoxColumn
            // 
            this.sulphatesDataGridViewTextBoxColumn.DataPropertyName = "sulphates";
            this.sulphatesDataGridViewTextBoxColumn.HeaderText = "sulphates";
            this.sulphatesDataGridViewTextBoxColumn.Name = "sulphatesDataGridViewTextBoxColumn";
            this.sulphatesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alcoholDataGridViewTextBoxColumn
            // 
            this.alcoholDataGridViewTextBoxColumn.DataPropertyName = "alcohol";
            this.alcoholDataGridViewTextBoxColumn.HeaderText = "alcohol";
            this.alcoholDataGridViewTextBoxColumn.Name = "alcoholDataGridViewTextBoxColumn";
            this.alcoholDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qualityDataGridViewTextBoxColumn
            // 
            this.qualityDataGridViewTextBoxColumn.DataPropertyName = "quality";
            this.qualityDataGridViewTextBoxColumn.HeaderText = "quality";
            this.qualityDataGridViewTextBoxColumn.Name = "qualityDataGridViewTextBoxColumn";
            this.qualityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // redwineBindingSource
            // 
            this.redwineBindingSource.DataMember = "redwine";
            this.redwineBindingSource.DataSource = this.knnDataSet;
            // 
            // knnDataSet
            // 
            this.knnDataSet.DataSetName = "knnDataSet";
            this.knnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // redwineTableAdapter
            // 
            this.redwineTableAdapter.ClearBeforeFill = true;
            // 
            // firstFormulaRadioButton
            // 
            this.firstFormulaRadioButton.AutoSize = true;
            this.firstFormulaRadioButton.Checked = true;
            this.firstFormulaRadioButton.Location = new System.Drawing.Point(686, 80);
            this.firstFormulaRadioButton.Name = "firstFormulaRadioButton";
            this.firstFormulaRadioButton.Size = new System.Drawing.Size(54, 17);
            this.firstFormulaRadioButton.TabIndex = 29;
            this.firstFormulaRadioButton.TabStop = true;
            this.firstFormulaRadioButton.Text = "| x - y |";
            this.firstFormulaRadioButton.UseVisualStyleBackColor = true;
            this.firstFormulaRadioButton.CheckedChanged += new System.EventHandler(this.firstFormulaRadioButton_CheckedChanged);
            // 
            // secondFormulaRadioButton
            // 
            this.secondFormulaRadioButton.AutoSize = true;
            this.secondFormulaRadioButton.Location = new System.Drawing.Point(686, 104);
            this.secondFormulaRadioButton.Name = "secondFormulaRadioButton";
            this.secondFormulaRadioButton.Size = new System.Drawing.Size(111, 17);
            this.secondFormulaRadioButton.TabIndex = 30;
            this.secondFormulaRadioButton.Text = "sqrt (pow( x-y , 2 ))";
            this.secondFormulaRadioButton.UseVisualStyleBackColor = true;
            this.secondFormulaRadioButton.CheckedChanged += new System.EventHandler(this.secondFormulaRadioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 508);
            this.Controls.Add(this.secondFormulaRadioButton);
            this.Controls.Add(this.firstFormulaRadioButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.kLabel);
            this.Controls.Add(this.kTextBox);
            this.Controls.Add(this.alcoholLabel);
            this.Controls.Add(this.alcoholTextBox);
            this.Controls.Add(this.sulphatesLabel);
            this.Controls.Add(this.sulphatesTextBox);
            this.Controls.Add(this.pHLabel);
            this.Controls.Add(this.pHTextBox);
            this.Controls.Add(this.densityLabel);
            this.Controls.Add(this.densityTextBox);
            this.Controls.Add(this.totalSulfurDioxide);
            this.Controls.Add(this.totalSulfurDioxideTextBox);
            this.Controls.Add(this.freeSulfurDioxide);
            this.Controls.Add(this.freeSulfurDioxideTextBox);
            this.Controls.Add(this.chloridesLabel);
            this.Controls.Add(this.chloridesTextBox);
            this.Controls.Add(this.citricAcidLabel);
            this.Controls.Add(this.citricAcidTextBox);
            this.Controls.Add(this.residualSugarLabel);
            this.Controls.Add(this.residualSugarTextBox);
            this.Controls.Add(this.volatileAcidityLabel);
            this.Controls.Add(this.volatileAcidityTextBox);
            this.Controls.Add(this.fixedAcidityLabel);
            this.Controls.Add(this.fixedAcidityTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redwineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knnDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fixedAcidityTextBox;
        private System.Windows.Forms.Label fixedAcidityLabel;
        private System.Windows.Forms.Label volatileAcidityLabel;
        private System.Windows.Forms.TextBox volatileAcidityTextBox;
        private System.Windows.Forms.Label residualSugarLabel;
        private System.Windows.Forms.TextBox residualSugarTextBox;
        private System.Windows.Forms.Label citricAcidLabel;
        private System.Windows.Forms.TextBox citricAcidTextBox;
        private System.Windows.Forms.Label chloridesLabel;
        private System.Windows.Forms.TextBox chloridesTextBox;
        private System.Windows.Forms.Label freeSulfurDioxide;
        private System.Windows.Forms.TextBox freeSulfurDioxideTextBox;
        private System.Windows.Forms.Label totalSulfurDioxide;
        private System.Windows.Forms.TextBox totalSulfurDioxideTextBox;
        private System.Windows.Forms.Label densityLabel;
        private System.Windows.Forms.TextBox densityTextBox;
        private System.Windows.Forms.Label pHLabel;
        private System.Windows.Forms.TextBox pHTextBox;
        private System.Windows.Forms.Label sulphatesLabel;
        private System.Windows.Forms.TextBox sulphatesTextBox;
        private System.Windows.Forms.Label alcoholLabel;
        private System.Windows.Forms.TextBox alcoholTextBox;
        private System.Windows.Forms.Label kLabel;
        private System.Windows.Forms.TextBox kTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private knnDataSet knnDataSet;
        private System.Windows.Forms.BindingSource redwineBindingSource;
        private knnDataSetTableAdapters.redwineTableAdapter redwineTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixedAcidityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volatileAcidityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn citricAcidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residualSugarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chloridesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeSulfurDioxideDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSulfurDioxideDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn densityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sulphatesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alcoholDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualityDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton firstFormulaRadioButton;
        private System.Windows.Forms.RadioButton secondFormulaRadioButton;
    }
}

