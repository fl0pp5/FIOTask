namespace FIOTask
{
    partial class Fullname
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
            this.authGroupBox = new System.Windows.Forms.GroupBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.authButton = new System.Windows.Forms.Button();
            this.enterLabel = new System.Windows.Forms.Label();
            this.dbConnectGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.initCatalogTextBox = new System.Windows.Forms.TextBox();
            this.dataSourceTextBox = new System.Windows.Forms.TextBox();
            this.authGroupBox.SuspendLayout();
            this.dbConnectGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // authGroupBox
            // 
            this.authGroupBox.Controls.Add(this.nameLabel);
            this.authGroupBox.Controls.Add(this.surnameLabel);
            this.authGroupBox.Controls.Add(this.nameTextBox);
            this.authGroupBox.Controls.Add(this.surnameTextBox);
            this.authGroupBox.Controls.Add(this.authButton);
            this.authGroupBox.Controls.Add(this.enterLabel);
            this.authGroupBox.Location = new System.Drawing.Point(76, 12);
            this.authGroupBox.Name = "authGroupBox";
            this.authGroupBox.Size = new System.Drawing.Size(455, 229);
            this.authGroupBox.TabIndex = 6;
            this.authGroupBox.TabStop = false;
            this.authGroupBox.Text = "Авторизация";
            this.authGroupBox.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(53, 71);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 26);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Имя";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLabel.Location = new System.Drawing.Point(53, 100);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(94, 26);
            this.surnameLabel.TabIndex = 10;
            this.surnameLabel.Text = "Фамилия";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(170, 78);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(231, 23);
            this.nameTextBox.TabIndex = 9;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(170, 107);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(231, 23);
            this.surnameTextBox.TabIndex = 8;
            // 
            // authButton
            // 
            this.authButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.authButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authButton.Location = new System.Drawing.Point(170, 159);
            this.authButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(99, 40);
            this.authButton.TabIndex = 7;
            this.authButton.Text = "Вход";
            this.authButton.UseVisualStyleBackColor = true;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterLabel.Location = new System.Drawing.Point(207, 29);
            this.enterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(62, 29);
            this.enterLabel.TabIndex = 6;
            this.enterLabel.Text = "Вход";
            // 
            // dbConnectGroupBox
            // 
            this.dbConnectGroupBox.Controls.Add(this.label2);
            this.dbConnectGroupBox.Controls.Add(this.label1);
            this.dbConnectGroupBox.Controls.Add(this.connectButton);
            this.dbConnectGroupBox.Controls.Add(this.initCatalogTextBox);
            this.dbConnectGroupBox.Controls.Add(this.dataSourceTextBox);
            this.dbConnectGroupBox.Location = new System.Drawing.Point(186, 5);
            this.dbConnectGroupBox.Name = "dbConnectGroupBox";
            this.dbConnectGroupBox.Size = new System.Drawing.Size(247, 160);
            this.dbConnectGroupBox.TabIndex = 7;
            this.dbConnectGroupBox.TabStop = false;
            this.dbConnectGroupBox.Text = "Подключение к БД";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "БД";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Сервер";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(73, 108);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(100, 28);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Подключиться";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // initCatalogTextBox
            // 
            this.initCatalogTextBox.Location = new System.Drawing.Point(73, 78);
            this.initCatalogTextBox.Name = "initCatalogTextBox";
            this.initCatalogTextBox.Size = new System.Drawing.Size(100, 23);
            this.initCatalogTextBox.TabIndex = 1;
            // 
            // dataSourceTextBox
            // 
            this.dataSourceTextBox.Location = new System.Drawing.Point(73, 49);
            this.dataSourceTextBox.Name = "dataSourceTextBox";
            this.dataSourceTextBox.Size = new System.Drawing.Size(100, 23);
            this.dataSourceTextBox.TabIndex = 0;
            // 
            // Fullname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 283);
            this.Controls.Add(this.dbConnectGroupBox);
            this.Controls.Add(this.authGroupBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Fullname";
            this.Text = "Fullname";
            this.authGroupBox.ResumeLayout(false);
            this.authGroupBox.PerformLayout();
            this.dbConnectGroupBox.ResumeLayout(false);
            this.dbConnectGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox authGroupBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Button authButton;
        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.GroupBox dbConnectGroupBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox initCatalogTextBox;
        private System.Windows.Forms.TextBox dataSourceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

