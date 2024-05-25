using QLTiemVang.DAO;
using QLTiemVang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTiemVang.GUI
{
    public partial class fSupplier : Form
    {   

        public Supplier returnSupplier;
        private Supplier selectedSup = new Supplier();

        private int addButon = 0;

        public fSupplier()
        {
            InitializeComponent();
        }
        private void tb_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgv_Sup.DataSource = SupplierDAO.Instance.Search(tb_Search.Text);
            dgv_Sup.Refresh();
        }

        private void tb_Search_MouseClick(object sender, MouseEventArgs e)
        {
            tb_Search.Text = "";
            dgv_Sup.DataSource = SupplierDAO.Instance.Search(tb_Search.Text);
            if (addButon == 0)
            {
                DataGridViewButtonColumn bt_select = new DataGridViewButtonColumn();
                bt_select.HeaderText = "Chọn";
                bt_select.Name = "b_Select";
                bt_select.Text = "Chọn";
                bt_select.UseColumnTextForButtonValue = true;
                dgv_Sup.Columns.Add(bt_select);

                DataGridViewButtonColumn bt_edit = new DataGridViewButtonColumn();
                bt_edit.HeaderText = "Sửa";
                bt_edit.Name = "b_Edit";
                bt_edit.Text = "Sửa";
                bt_edit.UseColumnTextForButtonValue = true;
                dgv_Sup.Columns.Add(bt_edit);
                addButon = 1;
            }
            dgv_Sup.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Sup.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Sup.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Sup.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Sup.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Sup.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void dgv_Sup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) //Select
            {
                DataGridViewRow selectedRow = dgv_Sup.Rows[e.RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                string name = selectedRow.Cells[1].Value.ToString();
                string address = selectedRow.Cells[2].Value.ToString();
                string phone = selectedRow.Cells[3].Value.ToString();

                selectedSup = new Supplier(id, name, address, phone);
                tb_id.Text = id.ToString();
                tb_name.Text = name;
                tb_Address.Text = address;
                tb_Phone.Text = phone;
            }
            if (e.ColumnIndex == 5) //Edit
            {
                DataGridViewRow selectedRow = dgv_Sup.Rows[e.RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                string name = selectedRow.Cells[1].Value.ToString();
                string address = selectedRow.Cells[2].Value.ToString();
                string phone = selectedRow.Cells[3].Value.ToString();

                Supplier supplier = new Supplier(id, name, address, phone);
                fSup_edit fsup_edit = new fSup_edit(supplier);
                fsup_edit.ShowDialog();
                dgv_Sup.Refresh();
            }
        }

        private void b_ChoseSup_Click(object sender, EventArgs e)
        {
            returnSupplier = selectedSup;
            Close();
        }

        private void b_Add_Click(object sender, EventArgs e)
        {
            int id = SupplierDAO.Instance.CountSupplier() +1;
            Supplier supplier = new Supplier(id);
            fSup_edit fsup_edit = new fSup_edit(supplier);
            fsup_edit.ShowDialog();
        }
    }





}
