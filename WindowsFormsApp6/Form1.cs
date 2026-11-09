using LabLibrary6_Task2;
using System;
using System.Text.RegularExpressions; // Добавлено для проверки ввода
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        // Задание 2: List<Teacher>
        private TeacherCollectionManager listManager = new TeacherCollectionManager();
        // Задание 3: Hashtable
        private TeacherHashtableManager hashManager = new TeacherHashtableManager();

        public Form1()
        {
            InitializeComponent();
            UpdateUI();
        }

        // ─────────────── ДОБАВЛЕНИЕ ───────────────
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string dept = txtDepartment.Text.Trim();
            string subject = txtSubject.Text.Trim();

            // 1. Проверка на пустоту
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(dept) || string.IsNullOrEmpty(subject))
            {
                MessageBox.Show("Пожалуйста, заполните все поля: ФИО, Кафедра и Предмет.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Проверка ФИО (только буквы, пробелы и дефисы)
            if (!Regex.IsMatch(name, @"^[a-zA-Zа-яА-ЯёЁ\s\-]+$"))
            {
                MessageBox.Show("В поле 'ФИО' разрешены только буквы, пробелы и дефисы. Цифры и спецсимволы запрещены!",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            // 3. Проверка Кафедры (только буквы, пробелы и дефисы)
            if (!Regex.IsMatch(dept, @"^[a-zA-Zа-яА-ЯёЁ\s\-]+$"))
            {
                MessageBox.Show("В поле 'Кафедра' разрешены только буквы, пробелы и дефисы!",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDepartment.Focus();
                return;
            }

            // 4. Проверка Предмета (только буквы, пробелы и дефисы)
            if (!Regex.IsMatch(subject, @"^[a-zA-Zа-яА-ЯёЁ\s\-]+$"))
            {
                MessageBox.Show("В поле 'Предмет' разрешены только буквы, пробелы и дефисы!",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSubject.Focus();
                return;
            }

            // Если все проверки пройдены — создаем объект
            Teacher t = new Teacher(
                name,
                dept,
                subject,
                (int)numExperience.Value
            );

            // Добавляем в List (Задание 2)
            listManager.AddTeacher(t);

            // Добавляем в Hashtable (Задание 3)
            if (!hashManager.AddTeacher(t))
            {
                MessageBox.Show("Преподаватель с таким ФИО уже есть в Hashtable!",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            UpdateUI();
            ClearInputs();
        }

        // ─────────────── УДАЛЕНИЕ ИЗ LIST ───────────────
        private void btnRemoveFromList_Click(object sender, EventArgs e)
        {
            if (lstTeachers.SelectedItem is Teacher selected)
            {
                listManager.RemoveTeacher(selected.FullName);
                hashManager.RemoveTeacher(selected.FullName);
                UpdateUI();
            }
            else
            {
                MessageBox.Show("Выберите преподавателя для удаления.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ─────────────── УДАЛЕНИЕ ИЗ HASHTABLE ───────────────
        private void btnRemoveFromHash_Click(object sender, EventArgs e)
        {
            if (lstHash.SelectedItem != null)
            {
                string key = lstHash.SelectedItem.ToString();
                hashManager.RemoveTeacher(key);
                listManager.RemoveTeacher(key);
                UpdateUI();
            }
            else
            {
                MessageBox.Show("Выберите ключ для удаления из Hashtable.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ─────────────── ОБНОВЛЕНИЕ UI ───────────────
        private void UpdateUI()
        {
            lstTeachers.Items.Clear();
            foreach (var t in listManager.GetTeachers())
                lstTeachers.Items.Add(t);

            lstHash.Items.Clear();
            foreach (var key in hashManager.GetKeys())
                lstHash.Items.Add(key);
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtDepartment.Clear();
            txtSubject.Clear();
            numExperience.Value = 0;
            txtName.Focus();
        }
    }
}