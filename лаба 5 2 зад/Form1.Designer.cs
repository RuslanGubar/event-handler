namespace лаба_5_2_зад
{
    partial class mainForm
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
            this.labelSize = new System.Windows.Forms.Label();
            this.labelParams = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelSizeTile = new System.Windows.Forms.Label();
            this.labelCountTile = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.comboBoxTileSize = new System.Windows.Forms.ComboBox();
            this.comboBoxTileCount = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(13, 13);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(112, 13);
            this.labelSize.TabIndex = 0;
            this.labelSize.Text = "размер поверхности";
            // 
            // labelParams
            // 
            this.labelParams.AutoSize = true;
            this.labelParams.Location = new System.Drawing.Point(277, 12);
            this.labelParams.Name = "labelParams";
            this.labelParams.Size = new System.Drawing.Size(102, 13);
            this.labelParams.TabIndex = 1;
            this.labelParams.Text = "параметры плитки";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(13, 56);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(45, 13);
            this.labelWidth.TabIndex = 2;
            this.labelWidth.Text = "ширина";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(12, 85);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(44, 13);
            this.labelHeight.TabIndex = 3;
            this.labelHeight.Text = "высота";
            // 
            // labelSizeTile
            // 
            this.labelSizeTile.AutoSize = true;
            this.labelSizeTile.Location = new System.Drawing.Point(277, 56);
            this.labelSizeTile.Name = "labelSizeTile";
            this.labelSizeTile.Size = new System.Drawing.Size(45, 13);
            this.labelSizeTile.TabIndex = 4;
            this.labelSizeTile.Text = "размер";
            // 
            // labelCountTile
            // 
            this.labelCountTile.AutoSize = true;
            this.labelCountTile.Location = new System.Drawing.Point(277, 85);
            this.labelCountTile.Name = "labelCountTile";
            this.labelCountTile.Size = new System.Drawing.Size(90, 13);
            this.labelCountTile.TabIndex = 5;
            this.labelCountTile.Text = "штук в упаковке";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 164);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(115, 13);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "количество упаковок";
            // 
            // comboBoxTileSize
            // 
            this.comboBoxTileSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTileSize.FormattingEnabled = true;
            this.comboBoxTileSize.Location = new System.Drawing.Point(389, 48);
            this.comboBoxTileSize.Name = "comboBoxTileSize";
            this.comboBoxTileSize.Size = new System.Drawing.Size(55, 21);
            this.comboBoxTileSize.TabIndex = 7;
            // 
            // comboBoxTileCount
            // 
            this.comboBoxTileCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTileCount.FormattingEnabled = true;
            this.comboBoxTileCount.Location = new System.Drawing.Point(389, 86);
            this.comboBoxTileCount.Name = "comboBoxTileCount";
            this.comboBoxTileCount.Size = new System.Drawing.Size(55, 21);
            this.comboBoxTileCount.TabIndex = 8;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(296, 164);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "расчитать";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(256, 192);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 10;
            this.buttonHelp.Text = "справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(337, 192);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(99, 48);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(52, 20);
            this.textBoxWidth.TabIndex = 12;
            this.textBoxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWidth_KeyPress);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(99, 85);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(52, 20);
            this.textBoxHeight.TabIndex = 13;
            this.textBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHeight_KeyPress);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(154, 164);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 14;
            this.textBoxResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxResult_KeyPress);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 227);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.comboBoxTileCount);
            this.Controls.Add(this.comboBoxTileSize);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelCountTile);
            this.Controls.Add(this.labelSizeTile);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelParams);
            this.Controls.Add(this.labelSize);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelParams;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelSizeTile;
        private System.Windows.Forms.Label labelCountTile;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ComboBox comboBoxTileSize;
        private System.Windows.Forms.ComboBox comboBoxTileCount;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

