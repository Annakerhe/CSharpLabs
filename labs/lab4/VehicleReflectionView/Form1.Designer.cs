namespace VehicleReflectionView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxClass = new System.Windows.Forms.ComboBox();
            this.comboBoxAction = new System.Windows.Forms.ComboBox();
            this.createObjectClassButton = new System.Windows.Forms.Button();
            this.enterMethodButton = new System.Windows.Forms.Button();
            this.doMethodButton = new System.Windows.Forms.Button();
            this.listBoxFieldsClass = new System.Windows.Forms.ListBox();
            this.listBoxParamMethod = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбор типа общественного транспорта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выбор метода у выбранного класса";
            // 
            // ComboBoxClass
            // 
            this.ComboBoxClass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxClass.FormattingEnabled = true;
            this.ComboBoxClass.Location = new System.Drawing.Point(12, 67);
            this.ComboBoxClass.Name = "ComboBoxClass";
            this.ComboBoxClass.Size = new System.Drawing.Size(216, 25);
            this.ComboBoxClass.TabIndex = 2;
            this.ComboBoxClass.SelectedIndexChanged += new System.EventHandler(this.ComboBoxClass_SelectedIndexChanged);
            // 
            // comboBoxAction
            // 
            this.comboBoxAction.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxAction.FormattingEnabled = true;
            this.comboBoxAction.Location = new System.Drawing.Point(12, 151);
            this.comboBoxAction.Name = "comboBoxAction";
            this.comboBoxAction.Size = new System.Drawing.Size(216, 25);
            this.comboBoxAction.TabIndex = 3;
            this.comboBoxAction.SelectedIndexChanged += new System.EventHandler(this.comboBoxAction_SelectedIndexChanged);
            // 
            // createObjectClassButton
            // 
            this.createObjectClassButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createObjectClassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createObjectClassButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createObjectClassButton.Location = new System.Drawing.Point(467, 321);
            this.createObjectClassButton.Name = "createObjectClassButton";
            this.createObjectClassButton.Size = new System.Drawing.Size(242, 39);
            this.createObjectClassButton.TabIndex = 4;
            this.createObjectClassButton.Text = "Создать экземпляр класса";
            this.createObjectClassButton.UseVisualStyleBackColor = false;
            this.createObjectClassButton.Click += new System.EventHandler(this.createObjectClassButton_Click);
            // 
            // enterMethodButton
            // 
            this.enterMethodButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.enterMethodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterMethodButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterMethodButton.Location = new System.Drawing.Point(73, 365);
            this.enterMethodButton.Name = "enterMethodButton";
            this.enterMethodButton.Size = new System.Drawing.Size(242, 37);
            this.enterMethodButton.TabIndex = 5;
            this.enterMethodButton.Text = "Ввести данные метода";
            this.enterMethodButton.UseVisualStyleBackColor = false;
            this.enterMethodButton.Click += new System.EventHandler(this.enterMethodButton_Click);
            // 
            // doMethodButton
            // 
            this.doMethodButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.doMethodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doMethodButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.doMethodButton.Location = new System.Drawing.Point(467, 366);
            this.doMethodButton.Name = "doMethodButton";
            this.doMethodButton.Size = new System.Drawing.Size(242, 36);
            this.doMethodButton.TabIndex = 6;
            this.doMethodButton.Text = "Выполнить метод";
            this.doMethodButton.UseVisualStyleBackColor = false;
            this.doMethodButton.Click += new System.EventHandler(this.doMethodButton_Click);
            // 
            // listBoxFieldsClass
            // 
            this.listBoxFieldsClass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxFieldsClass.FormattingEnabled = true;
            this.listBoxFieldsClass.ItemHeight = 19;
            this.listBoxFieldsClass.Location = new System.Drawing.Point(423, 55);
            this.listBoxFieldsClass.Name = "listBoxFieldsClass";
            this.listBoxFieldsClass.Size = new System.Drawing.Size(334, 251);
            this.listBoxFieldsClass.TabIndex = 7;
            // 
            // listBoxParamMethod
            // 
            this.listBoxParamMethod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxParamMethod.FormattingEnabled = true;
            this.listBoxParamMethod.ItemHeight = 19;
            this.listBoxParamMethod.Location = new System.Drawing.Point(12, 229);
            this.listBoxParamMethod.Name = "listBoxParamMethod";
            this.listBoxParamMethod.Size = new System.Drawing.Size(348, 118);
            this.listBoxParamMethod.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(454, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Список полей экзмепляра класса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(73, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Список параметров метода";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxParamMethod);
            this.Controls.Add(this.listBoxFieldsClass);
            this.Controls.Add(this.doMethodButton);
            this.Controls.Add(this.enterMethodButton);
            this.Controls.Add(this.createObjectClassButton);
            this.Controls.Add(this.comboBoxAction);
            this.Controls.Add(this.ComboBoxClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Рефлексия";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox ComboBoxClass;
        private ComboBox comboBoxAction;
        private Button createObjectClassButton;
        private Button enterMethodButton;
        private Button doMethodButton;
        private ListBox listBoxFieldsClass;
        private ListBox listBoxParamMethod;
        private Label label3;
        private Label label4;
    }
}