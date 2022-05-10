using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Inventory
{
    public partial class form_Home : Form
    {
        public static Inventory inventory = new Inventory();
        List<Item> recent = new List<Item>();

        public form_Home()
        {
            InitializeComponent();
            this.AcceptButton = btn_search;
            setTable();

            Load();
            foreach(Item item in inventory.Catalog)
            {
                var listItem = new ListViewItem(new[] { item.ProductNumber, item.Name, item.Manufacturer, item.Quantity.ToString(), item.Price.ToString(), item.Location, item.Description });
                lv_products.Items.Add(listItem);
            }

            colorTable();
            lv_products.GridLines = true;
            lv_products.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        //<----------------------------------------------Functional Button Click Methods------------------------------------------------------------->
        private void btn_search_Click(object sender, EventArgs e)
        {
            clearTable();

            foreach (Item item in inventory.Catalog)
            {
                if (item.ProductNumber.ToLower().Contains(tb_searchPartNumber.Text.ToLower()) && item.Name.ToLower().Contains(tb_searchName.Text.ToLower()) && item.Manufacturer.ToLower().Contains(tb_searchManufacturer.Text.ToLower()) && item.Location.ToLower().Contains(tb_searchLocation.Text.ToLower()))
                {
                    var listItem = new ListViewItem(new[] { item.ProductNumber, item.Name, item.Manufacturer, item.Quantity.ToString(), item.Price.ToString(), item.Location, item.Description });
                    lv_products.Items.Add(listItem);
                }
            }
            lv_products.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btn_refresh_Click(object sender, System.EventArgs e) // Clear and reformat table
        {
            clearTable();
            for (int i = 0; i < inventory.Catalog.Count; i++) // Show initial items on listview
            {
                var listItem = new ListViewItem(new[] { inventory.Catalog[i].ProductNumber, inventory.Catalog[i].Name, inventory.Catalog[i].Manufacturer, inventory.Catalog[i].Quantity.ToString(), inventory.Catalog[i].Price.ToString(), inventory.Catalog[i].Location, inventory.Catalog[i].Description });
                lv_products.Items.Add(listItem);
            }
            lv_products.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            colorTable();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Save();
        }

        //<--------------------------------------------Navigation Button Methods----------------------------------------------------------------->

        private void btn_add_Click(object sender, System.EventArgs e) // Opens add item user control
        {
            pnl_home.Visible = false;
            uc_addItem add = new uc_addItem(inventory, lv_products);
            this.Controls.Add(add);
            add.Location = new System.Drawing.Point(-1, 71);
            add.Show();
        }

        private void btn_home_Click(object sender, System.EventArgs e) // Opens home page
        {
            hideAll();
            pnl_home.Show();
            colorTable();
        }

        private void lv_products_DoubleClick(object sender, EventArgs e)
        {
            editItem();
        }

        //<--------------------------------------------Functional Methods------------------------------------------------------------------------>

        public void setTable() // Reformats headers
        {
            var headerPartNumber = lv_products.Columns.Add("Part Number", -2, HorizontalAlignment.Left);
            var headerPartName = lv_products.Columns.Add("Name", -1, HorizontalAlignment.Left);
            var headerManufacturer = lv_products.Columns.Add("Manufacturer", -1, HorizontalAlignment.Left);
            var headerQuantity = lv_products.Columns.Add("Quantity", -1, HorizontalAlignment.Left);
            var headerPrice = lv_products.Columns.Add("Price", -1, HorizontalAlignment.Left);
            var headerLocation = lv_products.Columns.Add("Location", -1, HorizontalAlignment.Left);
            var headerDescription = lv_products.Columns.Add("Description", -1, HorizontalAlignment.Left);
        }

        public void clearTable() // Clear contents of table and reformat header size
        {
            lv_products.Items.Clear();
            lbl_error.Text = "";
            lv_products.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void colorTable() // Colors every other row of table
        {
            for (int i = 0; i < lv_products.Items.Count; i++)
            {
                if (i % 2 == 0)
                {
                    lv_products.Items[i].BackColor = System.Drawing.Color.Gainsboro;
                }
            }
        }

        public void hideAll() // Hides all user controls
        {
            foreach (Control control in this.Controls)
            {
                if (control is UserControl)
                {
                    control.Dispose();
                }
            }
        }

        public void editItem() // Opens edit item window
        {
            string productNumber = lv_products.SelectedItems[0].SubItems[0].Text;
            form_ItemView itemView = new form_ItemView(inventory.searchID(productNumber), inventory);
            itemView.Show();
        }

        public void Save() // Save contents of inventory to .dat file
        {
            // Gain code access to the file that we are going
            // to write to
            try
            {
                // Create a FileStream that will write data to file.
                FileStream writerFileStream =
                    new FileStream("C:\\Temp\\Test.dat", FileMode.Create, FileAccess.Write);
                // Save our dictionary of friends to file
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(writerFileStream, inventory.Catalog);

                // Close the writerFileStream when we are done.
                writerFileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Load() // load saved contents into inventory
        {

            // Check if we had previously Save information of our friends
            // previously
            if (File.Exists("C:\\Temp\\Test.dat"))
            {

                try
                {
                    // Create a FileStream will gain read access to the
                    // data file.
                    FileStream readerFileStream = new FileStream("C:\\Temp\\Test.dat",
                        FileMode.Open, FileAccess.Read);
                    // Reconstruct information of our friends from file.
                    BinaryFormatter formatter = new BinaryFormatter();
                    inventory.Catalog = (List<Item>)
                        formatter.Deserialize(readerFileStream);
                    // Close the readerFileStream when we are done
                    readerFileStream.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void form_Home_FormClosed(object sender, FormClosedEventArgs e) // Save on close
        {
            btn_save.PerformClick();
        }

        //<--------------------------------------------Key Down and Style Methods-------------------------------------------------------------------------->

        private void btn_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btn_search.PerformClick();
            }
        }

        private void btn_search_MouseEnter(object sender, EventArgs e)
        {
            btn_search.BackColor = System.Drawing.Color.FromArgb(254, 101, 33);
            btn_search.ForeColor = System.Drawing.Color.Black;
        }

        private void btn_search_MouseLeave(object sender, EventArgs e)
        {
            btn_search.BackColor = System.Drawing.Color.Empty;
            btn_search.ForeColor = System.Drawing.Color.FromArgb(254, 101, 33);
        }

        private void btn_refresh_MouseEnter(object sender, EventArgs e)
        {
            btn_refresh.BackColor = System.Drawing.Color.FromArgb(254, 101, 33);
            btn_refresh.ForeColor = System.Drawing.Color.Black;
        }

        private void btn_refresh_MouseLeave(object sender, EventArgs e)
        {
            btn_refresh.BackColor = System.Drawing.Color.Empty;
            btn_refresh.ForeColor = System.Drawing.Color.FromArgb(254, 101, 33);
        }

        private void btn_home_MouseEnter(object sender, EventArgs e)
        {
            btn_home.BackColor = System.Drawing.Color.Black;
            btn_home.ForeColor = System.Drawing.Color.FromArgb(254, 101, 33);
        }

        private void btn_home_MouseLeave(object sender, EventArgs e)
        {
            btn_home.BackColor = System.Drawing.Color.Empty;
            btn_home.ForeColor = System.Drawing.Color.Black;
        }

        private void btn_add_MouseEnter(object sender, EventArgs e)
        {
            btn_add.BackColor = System.Drawing.Color.Black;
            btn_add.ForeColor = System.Drawing.Color.FromArgb(254, 101, 33);
        }

        private void Btn_add_MouseLeave(object sender, EventArgs e)
        {
            btn_add.BackColor = System.Drawing.Color.Empty;
            btn_add.ForeColor = System.Drawing.Color.Black;
        }
    }
}
