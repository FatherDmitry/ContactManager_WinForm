namespace ContactManager
{
    partial class Form1
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
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtPersonalPhone = new System.Windows.Forms.TextBox();
            this.txtInternalPhone = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewContacts = new System.Windows.Forms.DataGridView();
            this.btnSaveToJson = new System.Windows.Forms.Button();
            this.btnLoadFromJson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(12, 12);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(194, 31);
            this.txtLastName.TabIndex = 0;
            this.txtLastName.Text = "Имя";
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(12, 51);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(194, 33);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Text = "Фамилия";
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(12, 90);
            this.txtMiddleName.Multiline = true;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(194, 33);
            this.txtMiddleName.TabIndex = 2;
            this.txtMiddleName.Text = "Отчество";
            this.txtMiddleName.TextChanged += new System.EventHandler(this.txtMiddleName_TextChanged);
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(12, 129);
            this.txtCompany.Multiline = true;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(194, 33);
            this.txtCompany.TabIndex = 3;
            this.txtCompany.Text = "Компания";
            this.txtCompany.TextChanged += new System.EventHandler(this.txtCompany_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 168);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(194, 33);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "Email";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(12, 207);
            this.txtPosition.Multiline = true;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(194, 33);
            this.txtPosition.TabIndex = 5;
            this.txtPosition.Text = "Должность";
            this.txtPosition.TextChanged += new System.EventHandler(this.txtPosition_TextChanged);
            // 
            // txtPersonalPhone
            // 
            this.txtPersonalPhone.Location = new System.Drawing.Point(12, 246);
            this.txtPersonalPhone.Multiline = true;
            this.txtPersonalPhone.Name = "txtPersonalPhone";
            this.txtPersonalPhone.Size = new System.Drawing.Size(194, 33);
            this.txtPersonalPhone.TabIndex = 6;
            this.txtPersonalPhone.Text = "Личный телефон";
            this.txtPersonalPhone.TextChanged += new System.EventHandler(this.txtPersonalPhone_TextChanged);
            // 
            // txtInternalPhone
            // 
            this.txtInternalPhone.Location = new System.Drawing.Point(12, 285);
            this.txtInternalPhone.Multiline = true;
            this.txtInternalPhone.Name = "txtInternalPhone";
            this.txtInternalPhone.Size = new System.Drawing.Size(194, 33);
            this.txtInternalPhone.TabIndex = 7;
            this.txtInternalPhone.Text = "Внутренний телефон";
            this.txtInternalPhone.TextChanged += new System.EventHandler(this.txtInternalPhone_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 35);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(112, 324);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 35);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(61, 365);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 35);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(1001, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 35);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(461, 12);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(534, 31);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridViewContacts
            // 
            this.dataGridViewContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContacts.Location = new System.Drawing.Point(233, 53);
            this.dataGridViewContacts.Name = "dataGridViewContacts";
            this.dataGridViewContacts.RowHeadersWidth = 51;
            this.dataGridViewContacts.RowTemplate.Height = 24;
            this.dataGridViewContacts.Size = new System.Drawing.Size(860, 434);
            this.dataGridViewContacts.TabIndex = 13;
            this.dataGridViewContacts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContacts_CellContentClick);
            // 
            // btnSaveToJson
            // 
            this.btnSaveToJson.Location = new System.Drawing.Point(12, 454);
            this.btnSaveToJson.Name = "btnSaveToJson";
            this.btnSaveToJson.Size = new System.Drawing.Size(94, 33);
            this.btnSaveToJson.TabIndex = 14;
            this.btnSaveToJson.Text = "Экспорт";
            this.btnSaveToJson.UseVisualStyleBackColor = true;
            this.btnSaveToJson.Click += new System.EventHandler(this.btnSaveToJson_Click);
            // 
            // btnLoadFromJson
            // 
            this.btnLoadFromJson.Location = new System.Drawing.Point(112, 454);
            this.btnLoadFromJson.Name = "btnLoadFromJson";
            this.btnLoadFromJson.Size = new System.Drawing.Size(94, 33);
            this.btnLoadFromJson.TabIndex = 15;
            this.btnLoadFromJson.Text = "Импорт";
            this.btnLoadFromJson.UseVisualStyleBackColor = true;
            this.btnLoadFromJson.Click += new System.EventHandler(this.btnLoadFromJson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 499);
            this.Controls.Add(this.btnLoadFromJson);
            this.Controls.Add(this.btnSaveToJson);
            this.Controls.Add(this.dataGridViewContacts);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtInternalPhone);
            this.Controls.Add(this.txtPersonalPhone);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtPersonalPhone;
        private System.Windows.Forms.TextBox txtInternalPhone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridViewContacts;
        private System.Windows.Forms.Button btnSaveToJson;
        private System.Windows.Forms.Button btnLoadFromJson;
    }
}

