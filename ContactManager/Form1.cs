using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class Form1 : Form
    {
        private List<Contact> contacts = new List<Contact>();
        private int selectedIndex = -1;

        public Form1()
        {
            InitializeComponent();
            UpdateGrid();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCompany_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPersonalPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInternalPhone_TextChanged(object sender, EventArgs e)
        {

        }

        // Кнопка <Добавить>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Создание нового контакта
            Contact c = new Contact
            {
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                MiddleName = txtMiddleName.Text,
                Company = txtCompany.Text,
                Email = txtInternalPhone.Text,
                Position = txtPosition.Text,
                PersonalPhone = txtPersonalPhone.Text,
                InternalPhone = txtInternalPhone.Text
            };

            contacts.Add(c); // Добавление контакта в список
            ClearInputs(); // Очистка полей ввода
            UpdateGrid(); // Обновление таблицы

        }

        // Кнопка <Изменить>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedIndex >= 0 && selectedIndex < contacts.Count)
            {
                var c = contacts[selectedIndex]; // Получение выбранного контакта

                // Изменение выбранного контакта
                c.LastName = txtLastName.Text;
                c.FirstName = txtFirstName.Text;
                c.MiddleName = txtMiddleName.Text;
                c.Company = txtCompany.Text;
                c.Email = txtEmail.Text;
                c.Position = txtPosition.Text;
                c.PersonalPhone = txtPersonalPhone.Text;
                c.InternalPhone = txtInternalPhone.Text;

                ClearInputs(); // Очистка полей ввода
                UpdateGrid(); // Обновление таблицы
            }
        }

        // Кнопка <Удалить>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedIndex >= 0 && selectedIndex < contacts.Count)
            {
                contacts.RemoveAt(selectedIndex); // Удаление выбранного контакта
                ClearInputs(); // Очистка полей ввода
                UpdateGrid(); // Обновление таблицы
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        // Кнопка <Поиск>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string term = txtSearch.Text.ToLower(); // Получение текста для поиска

            // Фильтрация списка контактов
            var filtered = contacts.Where(c => c.FullName.ToLower().Contains(term) || c.Company.ToLower().Contains(term)).ToList();

            dataGridViewContacts.DataSource = filtered.Select(c => new
                {
                    c.FullName,
                    c.Company,
                    c.Email,
                    c.Position,
                    c.PersonalPhone,
                    c.InternalPhone
                }).ToList();
        }

        // Кнопка <Экспорт (сохранить список JSON)>
        private void btnSaveToJson_Click(object sender, EventArgs e)
        {
            JsonStorage.Save(contacts);
        }

        // Кнопка <Импорт (загрузить список JSON)>
        private void btnLoadFromJson_Click(object sender, EventArgs e)
        {
            contacts = JsonStorage.Load();
            UpdateGrid();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////

        private void dataGridViewContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < contacts.Count)
            {
                selectedIndex = e.RowIndex; // Запоминаем индекс выбранного контакта
                var c = contacts[selectedIndex]; // Получаем выбранный контакт
                // Заполняем поля ввода данными выбранного контакта
                txtLastName.Text = c.LastName;
                txtFirstName.Text = c.FirstName;
                txtMiddleName.Text = c.MiddleName;
                txtCompany.Text = c.Company;
                txtEmail.Text = c.Email;
                txtPosition.Text = c.Position;
                txtPersonalPhone.Text = c.PersonalPhone;
                txtInternalPhone.Text = c.InternalPhone;
            }

        }

        private void UpdateGrid()
        {
            // Обновление таблицы контактов
            dataGridViewContacts.DataSource = contacts.Select(c => new
            {
                c.FullName,
                c.Company,
                c.Email,
                c.Position,
                c.PersonalPhone,
                c.InternalPhone
            }).ToList();
        }

        private void ClearInputs()
        {
            // Очистка полей ввода
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtCompany.Clear();
            txtEmail.Clear();
            txtPosition.Clear();
            txtPersonalPhone.Clear();
            txtInternalPhone.Clear();
            selectedIndex = -1; // Сброс индекса выбранного контакта
        }

    }
}
