using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Inventory
{
    public partial class uc_addItem : UserControl
    {

        Inventory addinventory = new Inventory();
        ListView lv_add = new ListView();

        public uc_addItem(Inventory inventory, ListView lv)
        {
            InitializeComponent();
            addinventory = inventory;
            lv_add = lv;
            setTable();
            lv_recentlyAdded.GridLines = true;
        }

        //<-------------------------------------------------Button Click Methods---------------------------------------->

        private void btn_submit_Click(object sender, EventArgs e)
        {
            addItem();
            colorTable();
        }

        //<------------------------------------------------Functional Methods----------------------------------------->

        public void setTable() // Clears table and reformats headers and column size
        {
            lv_recentlyAdded.Clear();
            lbl_error.Text = "";
            var headerPartNumber = lv_recentlyAdded.Columns.Add("Part Number", -2, HorizontalAlignment.Left);
            var headerPartName = lv_recentlyAdded.Columns.Add("Name", -1, HorizontalAlignment.Left);
            var headerManufacturer = lv_recentlyAdded.Columns.Add("Manufacturer", -1, HorizontalAlignment.Left);
            var headerQuantity = lv_recentlyAdded.Columns.Add("Quantity", -1, HorizontalAlignment.Left);
            var headerPrice = lv_recentlyAdded.Columns.Add("Price", -1, HorizontalAlignment.Left);
            var headerLocation = lv_recentlyAdded.Columns.Add("Location", -1, HorizontalAlignment.Left);
            var headerDescription = lv_recentlyAdded.Columns.Add("Description", -1, HorizontalAlignment.Left);
            lv_recentlyAdded.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public void colorTable()
        {
            for (int i = 0; i < lv_recentlyAdded.Items.Count; i++)
            {
                if (i % 2 == 0)
                {
                    lv_recentlyAdded.Items[i].BackColor = System.Drawing.Color.Gainsboro;
                }
            }
        }

        public void addItem() // Adding new item to main inventory
        {
            if (duplicateCheck())
            {
                lbl_error.ResetText();
                if (tb_addPartNumber.Text != string.Empty)
                {
                    lbl_error.ResetText();
                    if (tb_addName.Text != string.Empty)
                    {
                        lbl_error.ResetText();
                        if (tb_addManufacturer.Text != string.Empty)
                        {
                            lbl_error.ResetText();
                            if (Int32.TryParse(tb_addQuantity.Text, out int quantity))
                            {
                                lbl_error.ResetText();
                                if (Double.TryParse(tb_addPrice.Text, out double price))
                                {
                                    lbl_error.ResetText();
                                    if (tb_addLocation.Text != string.Empty)
                                    {
                                        lbl_error.ResetText();
                                        if (tb_addDescription.Text != string.Empty)
                                        {
                                            lbl_error.ResetText();

                                            // Create new item and add it to inventory
                                            Item item = new Item(tb_addPartNumber.Text, tb_addName.Text, tb_addManufacturer.Text, quantity, price, tb_addLocation.Text, tb_addDescription.Text);
                                            addinventory.add(item);

                                            // Add item to main listview
                                            var listItem = new ListViewItem(new[] { item.ProductNumber, item.Name, item.Manufacturer, item.Quantity.ToString(), item.Price.ToString(), item.Location, item.Description });
                                            lv_add.Items.Add(listItem);

                                            // Add item to recently added listview
                                            Item newItem = item.copy(item);
                                            var recentItem = new ListViewItem(new[] { newItem.ProductNumber, newItem.Name, newItem.Manufacturer, newItem.Quantity.ToString(), newItem.Price.ToString(), newItem.Location, newItem.Description });
                                            lv_recentlyAdded.Items.Add(recentItem);
                                            

                                            // Clear text boxes
                                            clearTB();

                                        }
                                        else
                                        {
                                            lbl_error.Text = "Enter a description for part.";
                                        }
                                    }

                                    else
                                    {
                                        lbl_error.Text = "Enter a storage location.";
                                    }
                                }

                                else
                                {
                                    lbl_error.Text = "Please enter a valid price";
                                }
                            }

                            else
                            {
                                lbl_error.Text = "Enter an integer for quantity";
                            }
                        }

                        else
                        {
                            lbl_error.Text = "Enter a manufacturer";
                        }
                    }

                    else
                    {
                        lbl_error.Text = "Enter a name.";
                    }
                }

                else
                {
                    lbl_error.Text = "Enter a part number.";
                }
            }
        }

        public void clearTB()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.ResetText();
                }
            }
        }

        public bool duplicateCheck()
        {
            for (int i = 0; i < addinventory.Catalog.Count; i++)
            {
                if (addinventory.Catalog[i].ProductNumber == tb_addPartNumber.Text)
                {
                    lbl_error.Text = "Part number in use. \n Please see the edit \n screen \n to make changes.";
                    return false;
                }
            }

            return true;
        }
    }
}
