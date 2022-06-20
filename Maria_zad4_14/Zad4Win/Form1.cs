using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zad4Win.Business;
using Zad4Win.Data;

namespace Zad4Win
{
    public partial class Editor : Form
    {
        DishLogic dishController = new DishLogic();
        DishTypeLogic typeController = new DishTypeLogic();
        DishContext db = new DishContext();
        public Editor()
        {
            InitializeComponent();
        }

        public void LoadRecord(Dish dish)
        {
            txtId.Text = dish.Id.ToString();
            txtName2.Text = dish.Name;
            txtDiscr2.Text = dish.Discription;
            txtPrice2.Text = dish.Price.ToString();
            txtWeight2.Text = dish.Weight.ToString();
            cbType2.Text = typeController.GetTypeById(dish.TypeId);
        }

        public void ClearScreen()
        {
            txtName.BackColor = Color.White;
            txtName.Clear();
            txtDiscr.Clear();
            txtPrice.Clear();
            txtWeight.Clear();
            cbType.Text = "";
            listResult.Items.Clear();
            txtId.Clear();
            txtName2.BackColor = Color.White;
            txtName2.Clear();
            txtDiscr2.Clear();
            txtPrice2.Clear();
            txtWeight2.Clear();
            cbType2.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<DishType> allTypes = typeController.GetAllTypes();
            cbType.DataSource = allTypes;
            cbType.DisplayMember = "TypeName";
            cbType.ValueMember = "Id";

            cbType2.DataSource = allTypes;
            cbType2.DisplayMember = "TypeName";
            cbType2.ValueMember = "Id";

            btnShowAll_Click(sender, e);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            List<Dish> allDishes = dishController.GetAll();
            listResult.Items.Clear();
            foreach (var item in allDishes)
            {
                listResult.Items.Add($"{item.Id}. - {item.Name} - {item.Discription} - {item.Price} лв - {item.Weight} g - " +
                  $"тип: {item.TypeId} {typeController.GetTypeById(item.TypeId)}");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int findId = 0;
            while (txtId.Text == null || txtId.Text == "")
            {
                MessageBox.Show("Не сте въвели ID за търсене!");
                txtId.BackColor = Color.Red;
                txtId.Focus();
                return;
            }
            findId = int.Parse(txtId.Text);

            Dish findedDish = dishController.Get(findId);

            if (findedDish == null)
            {
                MessageBox.Show("НЯМА ТАКЪВ ЗАПИС! \n Въведете правилно ID за търсене!");
                txtId.BackColor = Color.Red;
                txtId.Focus();
                return;
            }
            else
            {
                LoadRecord(findedDish);
                //listResult.Items.Add($"{findedDish.Id}. - {findedDish.Name} - {findedDish.Discription}  - {findedDish.Price} лв - {findedDish.Weight} g - " +
                //$"тип: {findedDish.TypeId} {typeController.GetTypeById(findedDish.TypeId)}");

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            int findId = 0;
            while (txtId.Text == null || txtId.Text == "")
            {
                MessageBox.Show("Не сте въвели ID за изтриване, в полето за редактиране!");
                txtId.BackColor = Color.Red;
                txtId.Focus();
                return;
            }
            findId = int.Parse(txtId.Text);

            Dish findedDish = dishController.Get(findId);
            if (findedDish == null)
            {
                MessageBox.Show("НЯМА ТАКЪВ ЗАПИС! \n Въведете правилно ID за изтриване!");
                ClearScreen();
                txtId.BackColor = Color.Red;
                txtId.Focus();
                return;
            }

            LoadRecord(findedDish);
            DialogResult answer = MessageBox.Show("Сигурни ли сте, че искате да изтриете ястие № " + findId + "?", "Question",
             MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                dishController.Delete(findId);
            }

            //LoadRecord(findedDish);
            btnShowAll_Click(sender, e);
            txtId.Clear();
            txtName2.Text = "";
            txtDiscr2.Text = "";
            txtPrice2.Text = "";
            txtWeight2.Text = "";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName2.Clear();
            txtDiscr2.Clear();
            txtPrice2.Clear();
            txtWeight2.Clear();
            cbType2.Text = "";
            //checking if the first textbox is empty or not
            while (txtName.Text == null || txtName.Text == "")
            {
                txtName.Focus();
                cbType2.Text = "";
                cbType.SelectedIndex = -1;
                MessageBox.Show("Въведете данни за новото ястие!");
                cbType.SelectedIndex = -1;
                cbType2.Text = "";
                txtName.BackColor = Color.Red;
                txtName.Focus();
                return;
            }

            Dish newDish = new Dish();
            newDish.Name = txtName.Text.Trim();
            newDish.Discription = txtDiscr.Text.Trim();
            newDish.Price = decimal.Parse(txtPrice.Text.Trim());
            newDish.Weight = decimal.Parse(txtWeight.Text.Trim());
            newDish.TypeId = (int)cbType.SelectedValue;
            //newDish.Type.TypeName = cbType.SelectedValue.ToString();
            dishController.Add(newDish);
            MessageBox.Show("Успешно въведен продукт!");
            btnShowAll_Click(sender, e);
            txtName.Clear();
            txtDiscr.Clear();
            txtPrice.Clear();
            txtWeight.Clear();
            cbType.SelectedIndex = -1;
            cbType2.SelectedIndex = -1;
            txtName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            int findId = 0;
            //checking if ID's textbox is empty or not
            while (txtId.Text == null || txtId.Text == "")
            {
                MessageBox.Show("Не сте въвели ID за търсене! \n Потърсете с бутона НАМЕРИ ЯСТИЕ.");
                txtId.BackColor = Color.Red;
                txtId.Focus();
                return;
            }
            findId = int.Parse(txtId.Text);
            if (string.IsNullOrEmpty(txtName2.Text)/*!IsChanged*/)
            {
                Dish findedDish = dishController.Get(findId);
                if (findedDish == null)
                {
                    MessageBox.Show("НЯМА ТАКЪВ ЗАПИС! \n Въведете правилно ID за търсене!");
                    txtId.BackColor = Color.Red;
                    txtId.Focus();
                    return;
                }

                //btnFind_Click(sender, e);
                LoadRecord(findedDish);

                MessageBox.Show("Поправете полетата, които искате и натиснете РЕДАКТИРАЙ.");
                //IsChanged = true;
                return;
            }
            else
            {
                Dish updatedDish = new Dish();
                //updatedDish.Id = int.Parse(txtId.Text);
                updatedDish.Name = txtName2.Text;
                updatedDish.Discription = txtDiscr2.Text;
                updatedDish.Price = decimal.Parse(txtPrice2.Text);
                updatedDish.Weight = decimal.Parse(txtWeight2.Text);
                updatedDish.TypeId = (int)cbType2.SelectedValue;
                dishController.Update(findId, updatedDish);
            }
            //btnEdit.Click += new EventHandler(btnEdit_Click);
            MessageBox.Show("Успешно е регистриран продукт!");
            btnShowAll_Click(sender, e);
        }
    }
}
