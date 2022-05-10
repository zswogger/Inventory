using System;
using System.Drawing;
using System.Windows.Forms;

namespace Inventory
{
    public partial class form_ItemView : Form
    {
        Inventory editItem = new Inventory();
        Item edited = new Item();

        public form_ItemView(Item item, Inventory inventory)
        {
            InitializeComponent();
            lbl_partNumber.Text = item.ProductNumber;
            lbl_name.Text = item.Name;
            lbl_price.Text = item.Price.ToString();
            tb_description.Text = item.Description;
            lbl_quantity.Text = item.Quantity.ToString();
            editItem = inventory;
            edited = item;
        }

        private void form_ItemView_Load(object sender, EventArgs e)
        {

        }

        private void btn_editSubmit_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(tb_quantityUpdate.Text, out int quantity))
            {
                lbl_error.ResetText();
                if (rb_add.Checked == true)
                {
                    addQuantity(quantity);
                }

                if (rb_remove.Checked == true)
                {
                    removeQuantity(quantity);
                }
            }

            else if (tb_quantityUpdate.Text == "")
            {
                edited.Description = tb_description.Text;
                lbl_error.ForeColor = Color.White;
                lbl_error.Text = "Description Updated";
            }

            else
            {
                lbl_error.ForeColor = Color.Red;
                lbl_error.Text = "You must enter a number!";
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to delete this item?";
            string caption = "Confirm Delete";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(result == DialogResult.No)
            {
                
            }

            else
            {
                editItem.remove(lbl_partNumber.Text);
                this.Close();
            }
        }

        public void addQuantity(int quantity)
        {

            lbl_error.ResetText();
            lbl_quantity.Text = edited.Quantity + quantity + "";
            lbl_error.ForeColor = Color.White;
            edited.Quantity += quantity;

            if (quantity > 1)
            {
                lbl_error.Text = "Added " + quantity + " " + lbl_name.Text + "'s";
            }

            else
            {
                lbl_error.Text = "Added " + quantity + " " + lbl_name.Text;
            }

            edited.Description = tb_description.Text;
        }

        public void removeQuantity(int quantity)
        {
            if (edited.Quantity - quantity < 0)
            {
                lbl_error.Text = "Cannot go below 0 items in stock";
            }

            else
            {
                lbl_error.ResetText();
                lbl_quantity.Text = edited.Quantity- quantity + "";
                edited.Quantity -= quantity;
                lbl_error.ForeColor = Color.White;

                if (quantity > 1)
                {
                    lbl_error.Text = "Removed " + quantity + " " + lbl_name.Text + "'s";
                }

                else
                {
                    lbl_error.Text = "Removed " + quantity + " " + lbl_name.Text;
                }

                edited.Description = tb_description.Text;
            }
        }

        private void tb_description_DoubleClick(object sender, EventArgs e)
        {
            tb_description.ReadOnly = false;
        }

        private void tb_quantityUpdate_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_editSubmit.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
