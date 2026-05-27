using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TreeFamily
{
    public partial class Form1 : Form
    {
        private FamilyTree tree = new FamilyTree();

        public Form1()
        {
            InitializeComponent();

            btnAddPerson.Click += BtnAddPerson_Click;
            btnLink.Click += BtnLink_Click;
            btnAncestors.Click += BtnAncestors_Click;
            btnDescendants.Click += BtnDescendants_Click;
        }

        private void BtnAddPerson_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtMiddleName.Text) ||
                string.IsNullOrWhiteSpace(txtPassport.Text))
            {
                MessageBox.Show("Помилка! Усі поля (Прізвище, Ім'я, По батькові та Паспорт) є обов'язковими для заповнення.",
                                "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fullName = $"{txtLastName.Text.Trim()} {txtFirstName.Text.Trim()} {txtMiddleName.Text.Trim()}";

            var person = new Person
            {
                Id = Guid.NewGuid().ToString(),
                FullName = fullName,
                PassportData = txtPassport.Text.Trim()
            };

            tree.AddPerson(person);

            cmbSearch.Items.Add(person);
            cmbParent.Items.Add(person);
            cmbChild.Items.Add(person);

            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            txtPassport.Clear();

            UpdateTreeView();
        }

        private void BtnLink_Click(object sender, EventArgs e)
        {
            if (cmbParent.SelectedItem == null || cmbChild.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, оберіть і батька, і дитину зі списків!");
                return;
            }

            Person parent = (Person)cmbParent.SelectedItem;
            Person child = (Person)cmbChild.SelectedItem;

            tree.AddChild(parent, child);

            UpdateTreeView();

            MessageBox.Show($"Зв'язок створено: {parent.FullName} є батьком/матір'ю для {child.FullName}");
        }

        private void BtnAncestors_Click(object sender, EventArgs e)
        {
            lstResults.DataSource = null;
            lstResults.Items.Clear();

            if (cmbSearch.SelectedItem is Person selectedPerson)
            {
                List<Person> ancestors = tree.GetAncestors(selectedPerson);

                if (ancestors.Count > 0)
                {
                    lstResults.DataSource = ancestors;
                }
                else
                {
                    MessageBox.Show($"У {selectedPerson.FullName} не знайдено предків у системі (це корінь дерева).", "Пошук завершено");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть особу у списку пошуку!", "Помилка");
            }
        }

        private void BtnDescendants_Click(object sender, EventArgs e)
        {
            lstResults.DataSource = null;
            lstResults.Items.Clear();

            if (cmbSearch.SelectedItem is Person selectedPerson)
            {
                List<Person> descendants = tree.GetDescendants(selectedPerson);

                if (descendants.Count > 0)
                {
                    lstResults.DataSource = descendants;
                }
                else
                {
                    MessageBox.Show($"У {selectedPerson.FullName} немає нащадків у системі (це кінцевий вузол дерева).", "Пошук завершено");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть особу у списку пошуку!", "Помилка");
            }
        }

        private void UpdateTreeView()
        {
            treeView1.Nodes.Clear();

            foreach (var person in tree.People)
            {
                if (person.Parent == null)
                {
                    TreeNode node = new TreeNode(person.ToString()) { Tag = person };
                    BuildTree(node, person);
                    treeView1.Nodes.Add(node);
                }
            }

            treeView1.ExpandAll();
        }
        private void BuildTree(TreeNode node, Person person)
        {
            foreach (var child in person.Children)
            {
                TreeNode childNode = new TreeNode(child.ToString()) { Tag = child };
                node.Nodes.Add(childNode);
                BuildTree(childNode, child);
            }
        }

        private void txtPassport_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Person grandparent = new Person { Id = Guid.NewGuid().ToString(), FullName = "Іван Іванов (Дідусь)", PassportData = "AA111111" };

            Person parent1 = new Person { Id = Guid.NewGuid().ToString(), FullName = "Петро Іванов (Батько)", PassportData = "BB222222" };
            Person parent2 = new Person { Id = Guid.NewGuid().ToString(), FullName = "Марія Іванова (Тітка)", PassportData = "CC333333" };

            Person child1 = new Person { Id = Guid.NewGuid().ToString(), FullName = "Олексій Іванов (Онук)", PassportData = "DD444444" };
            Person child2 = new Person { Id = Guid.NewGuid().ToString(), FullName = "Олена Іванова (Онучка)", PassportData = "EE555555" };

            tree.AddPerson(grandparent);
            tree.AddPerson(parent1);
            tree.AddPerson(parent2);
            tree.AddPerson(child1);
            tree.AddPerson(child2);

            tree.AddChild(grandparent, parent1);
            tree.AddChild(grandparent, parent2);

            tree.AddChild(parent1, child1);
            tree.AddChild(parent1, child2);

            Person[] allPeople = { grandparent, parent1, parent2, child1, child2 };
        }
    }
}