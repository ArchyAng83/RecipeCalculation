namespace MainDisplay
{
    partial class MainForm
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
            this.inputProductLabel = new System.Windows.Forms.Label();
            this.inputProductComboBox = new System.Windows.Forms.ComboBox();
            this.inputNumberLabel = new System.Windows.Forms.Label();
            this.inputNumberComboBox = new System.Windows.Forms.ComboBox();
            this.calculateRawMaterialButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputProductLabel
            // 
            this.inputProductLabel.AutoSize = true;
            this.inputProductLabel.Location = new System.Drawing.Point(13, 13);
            this.inputProductLabel.Name = "inputProductLabel";
            this.inputProductLabel.Size = new System.Drawing.Size(127, 13);
            this.inputProductLabel.TabIndex = 0;
            this.inputProductLabel.Text = "Выберите продукцию:";
            // 
            // inputProductComboBox
            // 
            this.inputProductComboBox.FormattingEnabled = true;
            this.inputProductComboBox.Location = new System.Drawing.Point(254, 13);
            this.inputProductComboBox.Name = "inputProductComboBox";
            this.inputProductComboBox.Size = new System.Drawing.Size(379, 21);
            this.inputProductComboBox.TabIndex = 1;
            // 
            // inputNumberLabel
            // 
            this.inputNumberLabel.AutoSize = true;
            this.inputNumberLabel.Location = new System.Drawing.Point(12, 67);
            this.inputNumberLabel.Name = "inputNumberLabel";
            this.inputNumberLabel.Size = new System.Drawing.Size(177, 13);
            this.inputNumberLabel.TabIndex = 2;
            this.inputNumberLabel.Text = "Количество единиц продукции:";
            // 
            // inputNumberComboBox
            // 
            this.inputNumberComboBox.FormattingEnabled = true;
            this.inputNumberComboBox.Location = new System.Drawing.Point(254, 64);
            this.inputNumberComboBox.Name = "inputNumberComboBox";
            this.inputNumberComboBox.Size = new System.Drawing.Size(121, 21);
            this.inputNumberComboBox.TabIndex = 3;
            // 
            // calculateRawMaterialButton
            // 
            this.calculateRawMaterialButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateRawMaterialButton.Location = new System.Drawing.Point(590, 438);
            this.calculateRawMaterialButton.Name = "calculateRawMaterialButton";
            this.calculateRawMaterialButton.Size = new System.Drawing.Size(75, 23);
            this.calculateRawMaterialButton.TabIndex = 4;
            this.calculateRawMaterialButton.Text = "Расчитать";
            this.calculateRawMaterialButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 473);
            this.Controls.Add(this.calculateRawMaterialButton);
            this.Controls.Add(this.inputNumberComboBox);
            this.Controls.Add(this.inputNumberLabel);
            this.Controls.Add(this.inputProductComboBox);
            this.Controls.Add(this.inputProductLabel);
            this.Name = "MainForm";
            this.Text = "Приложение для расчета рецептуры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputProductLabel;
        private System.Windows.Forms.ComboBox inputProductComboBox;
        private System.Windows.Forms.Label inputNumberLabel;
        private System.Windows.Forms.ComboBox inputNumberComboBox;
        private System.Windows.Forms.Button calculateRawMaterialButton;
    }
}

