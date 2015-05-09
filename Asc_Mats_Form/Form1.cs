using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asc_Mats_Form
{
    public partial class Form1 : Form
    {
        int calc_asc, calc_to, calc_toc, calc_twadd, calc_tw, calc_twc, calc_tt, calc_ttc, calc_ttadd;
        int out_to, out_toc, out_tw, out_twc, out_tt, out_ttc, oao, oat;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            calc_wood();
            calc_cloth();
            calc_metal();
            calc_leather();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
        }

        private void ClearTextBoxes(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                TextBox tb = ctrl as TextBox;
                if (tb != null)
                    tb.Text = "";
                else
                    ClearTextBoxes(ctrl.Controls);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            DialogResult Result = saveFileDialog1.ShowDialog();
            if ((Result == DialogResult.OK) && (saveFileDialog1.FileName.Length > 0))
            {
                string[] contents = new string[29];
                contents[0] = i_wood_asc.Text;
                contents[1] = i_wood_to.Text ;
                contents[2] = i_wood_toc.Text;
                contents[3] = i_wood_tw.Text ;
                contents[4] = i_wood_twc.Text;
                contents[5] = i_wood_ttc.Text;
                contents[6] = i_wood_ttc.Text;
                contents[7] = i_cloth_asc.Text;
                contents[8] = i_cloth_to.Text;
                contents[9] = i_cloth_toc.Text;
                contents[10] = i_cloth_tw.Text;
                contents[11] = i_cloth_twc.Text;
                contents[12] = i_cloth_ttc.Text;
                contents[13] = i_cloth_ttc.Text;
                contents[14] = i_leather_asc.Text;
                contents[15] = i_leather_to.Text;
                contents[16] = i_leather_toc.Text;
                contents[17] = i_leather_tw.Text;
                contents[18] = i_leather_twc.Text;
                contents[19] = i_leather_tt.Text;
                contents[20] = i_leather_ttc.Text;
                contents[21] = i_metal_asc.Text;
                contents[22] = i_metal_to.Text;
                contents[23] = i_metal_toc.Text;
                contents[24] = i_metal_ao.Text;
                contents[25] = i_metal_twc.Text;
                contents[26] = i_metal_tt.Text;
                contents[27] = i_metal_at.Text;
                contents[28] = i_metal_ttc.Text;
                string name = saveFileDialog1.FileName;
                System.IO.File.WriteAllLines(name,contents);
            } 
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            DialogResult Result = openFileDialog1.ShowDialog();
            if (Result == DialogResult.OK)
            {
                string name = openFileDialog1.FileName;
                string[] contents = new string[29];
                contents = System.IO.File.ReadAllLines(name);
                i_wood_asc.Text = contents[0];
                i_wood_to.Text = contents[1];
                i_wood_toc.Text = contents[2];
                i_wood_tw.Text = contents[3];
                i_wood_twc.Text = contents[4];
                i_wood_ttc.Text = contents[5];
                i_wood_ttc.Text = contents[6];
                i_cloth_asc.Text = contents[7];
                i_cloth_to.Text = contents[8];
                i_cloth_toc.Text = contents[9];
                i_cloth_tw.Text = contents[10];
                i_cloth_twc.Text = contents[11];
                i_cloth_ttc.Text = contents[12];
                i_cloth_ttc.Text = contents[13];
                i_leather_asc.Text = contents[14];
                i_leather_to.Text = contents[15];
                i_leather_toc.Text = contents[16];
                i_leather_tw.Text = contents[17];
                i_leather_twc.Text = contents[18];
                i_leather_tt.Text = contents[19];
                i_leather_ttc.Text = contents[20];
                i_metal_asc.Text = contents[21];
                i_metal_to.Text = contents[22];
                i_metal_toc.Text = contents[23];
                i_metal_ao.Text = contents[24];
                i_metal_twc.Text = contents[25];
                i_metal_tt.Text = contents[26];
                i_metal_at.Text = contents[27];
                i_metal_ttc.Text = contents[28];
            } 
        }

        private void but_pl_wood_asc_Click(object sender, EventArgs e)
        {
            plus(i_wood_asc);
            calc_wood();
        }

        private void but_min_wood_asc_Click(object sender, EventArgs e)
        {
           minus(i_wood_asc);
           calc_wood();
        }

        private void but_pl_cloth_Click(object sender, EventArgs e)
        {
            plus(i_cloth_asc);
            calc_cloth();
        }

        private void but_min_cloth_Click(object sender, EventArgs e)
        {
            minus(i_cloth_asc);
            calc_cloth();
        }

        private void but_pl_metal_Click(object sender, EventArgs e)
        {
            plus(i_metal_asc);
            calc_metal();
        }

        private void but_min_metal_Click(object sender, EventArgs e)
        {
            minus(i_metal_asc);
            calc_metal();
        }

        private void but_pl_leather_Click(object sender, EventArgs e)
        {
            plus(i_leather_asc);
            calc_leather();
        }

        private void but_min_leather_Click(object sender, EventArgs e)
        {
            minus(i_leather_asc);
            calc_leather();
        }

        private void i_wood_asc_TextChanged(object sender, EventArgs e)
        {
            but_min_wood.Enabled = true;
            i_wood_to.Enabled = true;
            i_wood_toc.Enabled = true;
            i_wood_tt.Enabled = true;
            i_wood_ttc.Enabled = true;
            i_wood_tw.Enabled = true;
            i_wood_twc.Enabled = true;
        }

        private void i_cloth_asc_TextChanged(object sender, EventArgs e)
        {
            but_min_cloth.Enabled = true;
            i_cloth_to.Enabled = true;
            i_cloth_toc.Enabled = true;
            i_cloth_tt.Enabled = true;
            i_cloth_ttc.Enabled = true;
            i_cloth_tw.Enabled = true;
            i_cloth_twc.Enabled = true;
        }

        private void i_metal_asc_TextChanged(object sender, EventArgs e)
        {
            but_min_metal.Enabled = true;
            i_metal_to.Enabled = true;
            i_metal_toc.Enabled = true;
            i_metal_tt.Enabled = true;
            i_metal_ttc.Enabled = true;
            i_metal_twc.Enabled = true;
            i_metal_ao.Enabled = true;
            i_metal_at.Enabled = true;
        }

        private void i_leather_asc_TextChanged(object sender, EventArgs e)
        {
            but_min_leather.Enabled = true;
            i_leather_to.Enabled = true;
            i_leather_toc.Enabled = true;
            i_leather_tt.Enabled = true;
            i_leather_ttc.Enabled = true;
            i_leather_tw.Enabled = true;
            i_leather_twc.Enabled = true;
        }

        public void minus(TextBox textbox)
        {
            int calc;
            Int32.TryParse(textbox.Text, out calc);
            if (calc <= 0)
            {
                return;
            }
           calc -= 1;
            textbox.Text = calc.ToString();
        }

        public void plus(TextBox textbox)
        {
            int calc;
            Int32.TryParse(textbox.Text, out calc);
            calc += 1;
            textbox.Text = calc.ToString();
        }

        public void checkNull(int x,Label y)
        {
            if (x <= 0)
            {
                x = 0;
            }
            y.Text = x.ToString();
        }
/*
        public int calc(int asc,int o,int f_asc,int f_uncraftet,int c_uncraftet,int c_craftet,int f_craftet)
        {
            o = (asc * f_asc * f_uncraftet) - c_uncraftet - (c_craftet * f_craftet);
            return o;
        }
        */
        public void calc_wood()
        {
            Int32.TryParse(i_wood_asc.Text, out calc_asc);
            Int32.TryParse(i_wood_to.Text, out calc_to);
            Int32.TryParse(i_wood_toc.Text, out calc_toc);
            Int32.TryParse(i_wood_tw.Text, out calc_tw);
            Int32.TryParse(i_wood_twc.Text, out calc_twc);
            Int32.TryParse(i_wood_tt.Text, out calc_tt);
            Int32.TryParse(i_wood_ttc.Text, out calc_ttc);
            out_to = (calc_asc * 4 * 20) - calc_to - (calc_toc * 4);
            //calc(calc_asc,out_to,20,4,calc_to,calc_toc,4);
            out_tw = (calc_asc * 3 * 10) - calc_tw - (calc_twc * 3);
            out_tt = (calc_asc * 3 * 20) - calc_tt - (calc_ttc * 3);
            checkNull(out_to, o_wood_to);
            checkNull(out_tw, o_wood_tw);
            checkNull(out_tt, o_wood_tt);
        }

        public void calc_cloth()
        {
            Int32.TryParse(i_cloth_asc.Text, out calc_asc);
            Int32.TryParse(i_cloth_to.Text, out calc_to);
            Int32.TryParse(i_cloth_toc.Text, out calc_toc);
            Int32.TryParse(i_cloth_tw.Text, out calc_tw);
            Int32.TryParse(i_cloth_twc.Text, out calc_twc);
            Int32.TryParse(i_cloth_tt.Text, out calc_tt);
            Int32.TryParse(i_cloth_ttc.Text, out calc_ttc);

            out_to = (calc_asc * 2 * 20) - calc_to - (calc_toc * 2);
            out_tw = (calc_asc * 2 * 10) - calc_tw - (calc_twc * 2);
            out_tt = (calc_asc * 2 * 20) - calc_tt - (calc_ttc * 2);
            checkNull(out_to,o_cloth_to);
            checkNull(out_tw,o_cloth_tw);
            checkNull(out_tt,o_cloth_tt);
        }

        public void calc_leather()
        {
            Int32.TryParse(i_leather_asc.Text, out calc_asc);
            Int32.TryParse(i_leather_to.Text, out calc_to);
            Int32.TryParse(i_leather_toc.Text, out calc_toc);
            Int32.TryParse(i_leather_tw.Text, out calc_tw);
            Int32.TryParse(i_leather_twc.Text, out calc_twc);
            Int32.TryParse(i_leather_tt.Text, out calc_tt);
            Int32.TryParse(i_leather_ttc.Text, out calc_ttc);

            out_to = (calc_asc * 2 * 20) - calc_to - (calc_toc * 2);
            out_tw = (calc_asc * 2 * 10) - calc_tw - (calc_twc * 2);
            out_tt = (calc_asc * 2 * 20) - calc_tt - (calc_ttc * 2);
            checkNull(out_to,o_leather_to);
            checkNull(out_tw,o_leather_tw);
            checkNull(out_tt,o_leather_tt);
        }
        
        public void calc_metal()
        {
            Int32.TryParse(i_metal_asc.Text, out calc_asc);
            Int32.TryParse(i_metal_to.Text, out calc_to);
            Int32.TryParse(i_metal_toc.Text, out calc_toc);
            Int32.TryParse(i_metal_ao.Text, out calc_twadd);
            Int32.TryParse(i_metal_twc.Text, out calc_twc);
            Int32.TryParse(i_metal_tt.Text, out calc_tt);
            Int32.TryParse(i_metal_at.Text, out calc_ttadd);
            Int32.TryParse(i_metal_ttc.Text, out calc_ttc);

            out_toc = (calc_asc * 20) - calc_toc;
            out_twc = (calc_asc * 10) - calc_twc;
            out_to = (out_toc * 3) + (out_twc * 3) - calc_to;
            out_ttc = (calc_asc * 2 * 20) - calc_tt - (2 * calc_ttc);
            oao = (calc_asc * 10) - calc_twadd - (calc_twc);
            oat = (calc_asc * 20) - calc_ttadd - (calc_ttc);
            checkNull(out_toc,o_craft_iron);
            checkNull(out_twc,o_craft_steel);
            checkNull(out_to,o_metal_to);
            checkNull(out_ttc,o_metal_tt);
            checkNull(oao,o_metal_ao);
            checkNull(oat,o_metal_at);
        }
    }
}
