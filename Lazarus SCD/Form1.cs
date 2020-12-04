using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lazarus_SCD
{
    public partial class FRM_MAIN : Form
    {

         // globals
        public string rdt_file;
        public static LIB_RDT.RDT_HEADER_OBJ RDT_HEADER = new LIB_RDT.RDT_HEADER_OBJ();
        public static LIB_RDT.SCD_DATA_OBJ SCD_DATA = new LIB_RDT.SCD_DATA_OBJ();
        public FRM_DEBUG DEBUG_FORM = new FRM_DEBUG();


        public int[] scd_offs { get; set; }


        private void TOGGLE_VIEW()
        {
            if (LST_CODE.Visible)
            {
              //  MessageBox.Show("INTERPRETED VIEW NOW VISIBLE");

                LST_CODE.Visible = false;
                LST_CODE.Enabled = false;
                LST_BYTE.Visible = true;
                LST_BYTE.Enabled = true;
            }
            else
            {
               // MessageBox.Show("BYTE STRING MODE NOW VISIBLE!");
                LST_CODE.Visible = true;
                LST_CODE.Enabled = true;
                LST_BYTE.Visible = false;
                LST_BYTE.Enabled = false;
            }
        }


        public FRM_MAIN()
        {
            InitializeComponent();

            LIB_RDT.LB_OFF = this.LB_SCD;
            LIB_RDT.LV_CODE = this.LST_CODE;
            LIB_RDT.LV_BYTE = this.LST_BYTE;
            LIB_RDT.LBL_SIZE = this.LBL_SELECTED_SZ;

            this.WindowState = FormWindowState.Maximized;

            //LST_BYTE.Visible = false;
            //LST_BYTE.Enabled = false;

            //  LST_CODE.Width = (this.Width - 16) - 600;
            //  LST_CODE.Height = this.Height - 150;
            //  LST_BYTE.Width = (this.Width - 16) - 600;
            // LST_BYTE.Height = this.Height - 150;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LST_CODE.SelectedItems.Count > 0)
            {
                int sel_idx = LST_CODE.FocusedItem.Index;

                LST_BYTE.Items[sel_idx].Selected = true;
             //   LST_BYTE.Items[sel_idx].Focused = true;

                LST_BYTE.Items[sel_idx].EnsureVisible();


            }
        }

        private void openRDTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTN_OPEN_Click(sender, e);
        }

        private void BTN_OPEN_Click(object sender, EventArgs e)
        {
            FILE_DLG.ShowDialog();

            rdt_file = FILE_DLG.FileName;

            LBL_FILE.Text = rdt_file;
           
            LIB_RDT.PARSE_RDT_HEADER(rdt_file, RDT_HEADER, DEBUG_FORM, SCD_DATA);
          //  DEBUG_FORM.ShowDialog();



        }

        private void BTN_DEBUG_Click(object sender, EventArgs e)
        {
            DEBUG_FORM.ShowDialog();
        }

        private void BTN_H2B_Click(object sender, EventArgs e)
        {
            TOGGLE_VIEW();
        }

        private void LB_SCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LB_SCD.SelectedIndex;
            int idx = LB_SCD.SelectedIndices[0];

            LST_BYTE.Items.Clear();
            LST_BYTE.Items.Clear();


            if (index == 0)
            {
                LBL_STATUS.Text = "SELECTED OFFSET: " + RDT_HEADER.OBJ_OFFSETS[6].ToString();
                LIB_RDT.BIO_PARSE_SCD_INDEX(rdt_file, RDT_HEADER, index, SCD_DATA);
                // run main parse
            }
            else {
                LBL_STATUS.Text = "SELECTED OFFSET: " + SCD_DATA.sub_scd_offs_t[index - 1].ToString();
                // run sub parse
                LIB_RDT.BIO_PARSE_SCD_INDEX(rdt_file, RDT_HEADER, index - 1, SCD_DATA);

            }

            //if (index == 0)
            //{
            //   

            //}
            //else {
              
            //}

            

            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LAZARUS SCD VIEW \n Dchaps 4/16/2020, RESIDENT EVIL/BIOHAZARD 1 SCD VIEWER", "LAZARUS SCD VIEW", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LST_BYTE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LST_BYTE.SelectedItems.Count > 0)
            {
              


           }
        }

        private void hEX2CODEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTN_H2B_Click(sender, e);
        }

        private void FILE_DLG_FileOk(object sender, CancelEventArgs e)
        {
           // LB_SCD.SelectedIndex = 0;
        }

        private void BTN_EXE_Click(object sender, EventArgs e)
        {
            FILE_DLG.ShowDialog();

            LIB_EXE.EXE_PATH = FILE_DLG.FileName;

            LIB_EXE.COMBO_PTR_PARSE(LIB_EXE.EXE_PATH);

        }

        private void openEXEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTN_EXE_Click(sender, e);
        }
    }
}
