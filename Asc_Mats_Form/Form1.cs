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
        public Form1()
        {
            InitializeComponent();
            initializePanels();
        }

        private Panel pan_wood = new Panel();
        private Panel pan_cloth = new Panel();
        private Panel pan_metal = new Panel();
        private Panel pan_leather = new Panel();

        public void initializePanels()
        {
            // Create and initialize a GroupBox and a Button control.
            //Button button1 = new Button();
            //button1.Location = new Point(20, 10);

            // Set the FlatStyle of the GroupBox.
            //gb_wood.FlatStyle = FlatStyle.Flat;

            // Add the Button to the GroupBox.
            List<int> wl = new List<int> { 0, 1, 2, 2, 3, 4, 4, 5, 6, 6, 7 };
            List<int> ml = wl;
            ml.Add(7);
            ml.Add(8);
            pan_wood.AutoSize = true;
            pan_cloth.AutoSize = true;
            pan_metal.AutoSize = true;
            pan_leather.AutoSize = true;
            List<Label> woodLabels = new List<Label> { this.label63, this.label1, this.label2, this.label29, this.label3, this.label4, this.label34, this.label7, this.label6, this.label32, this.label5, this.o_wood_to, this.o_wood_tw, this.o_wood_tt };
            List<Label> clothLabels = new List<Label> { this.label62, this.label14, this.label13, this.label40, this.label12, this.label11, this.label36, this.label9, this.label10, this.label38, this.label8, this.o_cloth_to, this.o_cloth_tw, this.o_cloth_tt };
            List<Label> metalLabels = new List<Label> { this.o_metal_to, this.o_metal_tt, this.o_craft_iron, this.o_craft_steel, this.o_metal_ao, this.o_metal_at, this.label61, this.label21, this.label20, this.label52, this.label19, this.label18, this.label48, this.label16, this.label17, this.label50, this.label15, this.label54, this.label30, this.label58, this.label56 };
            List<Label> leatherLabels = new List<Label> { this.label60, this.label28, this.label27, this.label46, this.label26, this.label25, this.label42, this.label23, this.label24, this.label44, this.label22, this.o_leather_to, this.o_leather_tw, this.o_leather_tt };
            List<TextBox> woodBoxes = new List<TextBox> { this.i_wood_asc, this.i_wood_to, this.i_wood_toc, this.i_wood_tw, this.i_wood_twc, this.i_wood_tt, this.i_wood_ttc };
            List<TextBox> clothBoxes = new List<TextBox> { this.i_cloth_asc, this.i_cloth_to, this.i_cloth_toc, this.i_cloth_tw, this.i_cloth_twc, this.i_cloth_tt, this.i_cloth_ttc };
            List<TextBox> metalBoxes = new List<TextBox> { this.i_metal_asc, this.i_metal_to, this.i_metal_toc, this.i_metal_twc, this.i_metal_tt, this.i_metal_ttc, this.i_metal_ao, i_metal_at };
            List<TextBox> leatherBoxes = new List<TextBox> { this.i_leather_asc, this.i_leather_to, this.i_leather_toc, this.i_leather_tw, this.i_leather_twc, this.i_leather_tt, this.i_leather_ttc };
            wood wood = new wood();
            cloth cloth = new cloth();
            metal metal = new metal();
            leather leather = new leather();
            for (int i = 0; i < 11; i++)
            {
                wood.setLabel(woodLabels[i], wl[i]);
                cloth.setLabel(clothLabels[i], wl[i]);
                leather.setLabel(leatherLabels[i], wl[i]);
            }

            foreach (var item in woodLabels)
            {
                pan_wood.Controls.Add(item);
            }
            foreach (var item in woodBoxes)
            {
                pan_wood.Controls.Add(item);
            }

            foreach (var item in clothLabels)
            {
                pan_cloth.Controls.Add(item);
            }
            foreach (var item in clothBoxes)
            {
                pan_cloth.Controls.Add(item);
            }

            foreach (var item in metalBoxes)
            {
                pan_metal.Controls.Add(item);
            }
            int c = 0;
            for (int j = 6; j < 18; j++, c++)
            {
                metal.setLabel(metalLabels[j], ml[c]);
            }
            label56.Text = label19.Text + "s";
            label58.Text = label16.Text + "s";
            foreach (var item in metalLabels)
            {
                pan_metal.Controls.Add(item);
            }

            foreach (var item in leatherLabels)
            {
                pan_leather.Controls.Add(item);
            }

            foreach (var item in leatherBoxes)
            {
                pan_leather.Controls.Add(item);
            }

            pan_wood.Controls.Add(but_pl_wood);
            pan_wood.Controls.Add(but_min_wood);
            pan_cloth.Controls.Add(but_pl_cloth);
            pan_cloth.Controls.Add(but_min_cloth);
            pan_metal.Controls.Add(but_pl_metal);
            pan_metal.Controls.Add(but_min_metal);
            pan_leather.Controls.Add(but_pl_leather);
            pan_leather.Controls.Add(but_min_leather);

            Controls.Add(pan_wood);
            Controls.Add(pan_cloth);
            Controls.Add(pan_metal);
            Controls.Add(pan_leather);
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

        //   <summary>
        //   Saves a .txt file.
        //   </summary>
        //   <param name="sender">The source of the event.</param>
        //   <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        //   private void button_save_Click(object sender, EventArgs e)
        //   {
        //       DialogResult Result = saveFileDialog1.ShowDialog();
        //       if ((Result == DialogResult.OK) && (saveFileDialog1.FileName.Length > 0))
        //       {
        //           string[] contents = new string[23];
        //           TextBox[] boxes = { textBox_token, textBox_recipe_item, textBox_recipe_item1, textBox_recipe_item2, textBox_mats_item, textBox_mats_item1, textBox_mats_item2, textBox_mats_item3, textBox_runestones, textBox_skillpoint, textBox_honor, textBox_obsi, textBox_totem, textBox_dust, textBox_venom, textBox_blood, textBox_bone, textBox_scale, textBox_claws, textBox_fangs, textBox_ecto, textBox_clover };
        //           contents[0] = input;
        //           for (int i = 1; i < 23; i++)
        //           {
        //               contents[i] = boxes[i - 1].Text;
        //           }
        //           string name = saveFileDialog1.FileName;
        //           System.IO.File.WriteAllLines(name, contents);
        //       }
        //   }

        public string[] contents = new string[29];

        //private void callTextBox(Control.ControlCollection cc)
        //{
        //    foreach (Control ctrl in cc)
        //    {
        //        TextBox tb = ctrl as TextBox;
        //    }
        //}

        public void button_save_Click(object sender, EventArgs e)
        {
            DialogResult Result = saveFileDialog1.ShowDialog();
            if ((Result == DialogResult.OK) && (saveFileDialog1.FileName.Length > 0))
            {
                //{
                //    callTextBox(this.Controls);
                //}
                contents[0] = i_wood_asc.Text;
                contents[1] = i_wood_to.Text;
                contents[2] = i_wood_toc.Text;
                contents[3] = i_wood_tw.Text;
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
                System.IO.File.WriteAllLines(name, contents);
            }
        }

        /// <summary>
        /// Loads a .txt file.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        //private void button_load_Click(object sender, EventArgs e)
        //{
        //    DialogResult Result = openFileDialog1.ShowDialog();
        //    if (Result == DialogResult.OK)
        //    {
        //        string name = openFileDialog1.FileName;
        //        string[] contents = new string[23];
        //        TextBox[] boxes = { textBox_token, textBox_recipe_item, textBox_recipe_item1, textBox_recipe_item2, textBox_mats_item, textBox_mats_item1, textBox_mats_item2, textBox_mats_item3, textBox_runestones, textBox_skillpoint, textBox_honor, textBox_obsi, textBox_totem, textBox_dust, textBox_venom, textBox_blood, textBox_bone, textBox_scale, textBox_claws, textBox_fangs, textBox_ecto, textBox_clover };
        //        contents = System.IO.File.ReadAllLines(name);
        //        input = contents[0];
        //        for (int i = 1; i < 23; i++)
        //        {
        //            boxes[i - 1].Text = contents[i];
        //        }
        //        comboBox_legy.SelectedItem = input;
        //    }
        //}

        private void button_load_Click(object sender, EventArgs e)
        {
            DialogResult Result = openFileDialog1.ShowDialog();
            if (Result == DialogResult.OK)
            {
                string name = openFileDialog1.FileName;
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
            foreach (Control c in pan_wood.Controls)
            {
                c.Enabled = true;
            }
        }

        private void i_cloth_asc_TextChanged(object sender, EventArgs e)
        {
            foreach (Control c in pan_cloth.Controls)
            {
                c.Enabled = true;
            }
        }

        private void i_metal_asc_TextChanged(object sender, EventArgs e)
        {
            foreach (Control c in pan_metal.Controls)
            {
                c.Enabled = true;
            }
        }

        private void i_leather_asc_TextChanged(object sender, EventArgs e)
        {
            foreach (Control c in pan_leather.Controls)
            {
                c.Enabled = true;
            }
        }

        private void minus(TextBox textbox)
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

        private void plus(TextBox textbox)
        {
            int calc;
            Int32.TryParse(textbox.Text, out calc);
            calc += 1;
            textbox.Text = calc.ToString();
        }

        private void checkNull(int x, Label y)
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

        public int v_wood_asc, v_wood_to, v_wood_toc, v_wood_tw, v_wood_twc, v_wood_tt, v_wood_ttc;

        public void calc_wood()
        {
            TextBox[] woodBoxes = new TextBox[] { this.i_wood_asc, this.i_wood_to, this.i_wood_toc, this.i_wood_tw, this.i_wood_twc, this.i_wood_tt, this.i_wood_ttc };

            int[] woodBoxes_value = new int[] { v_wood_asc, v_wood_to, v_wood_toc, v_wood_tw, v_wood_twc, v_wood_tt, v_wood_ttc };
            for (int i = 0; i < woodBoxes.Length; i++)
            {
                Int32.TryParse(woodBoxes[i].Text, out woodBoxes_value[i]);
            }

            checkNull((woodBoxes_value[0] * 4 * 20) - woodBoxes_value[1] - (woodBoxes_value[2] * 4), o_wood_to);
            checkNull((woodBoxes_value[0] * 3 * 10) - woodBoxes_value[3] - (woodBoxes_value[4] * 3), o_wood_tw);
            checkNull((woodBoxes_value[0] * 3 * 20) - woodBoxes_value[5] - (woodBoxes_value[6] * 3), o_wood_tt);
        }

        public int v_cloth_asc, v_cloth_to, v_cloth_toc, v_cloth_tw, v_cloth_twc, v_cloth_tt, v_cloth_ttc;

        public void calc_cloth()
        {
            TextBox[] clothBoxes = new TextBox[] { this.i_cloth_asc, this.i_cloth_to, this.i_cloth_toc, this.i_cloth_tw, this.i_cloth_twc, this.i_cloth_tt, this.i_cloth_ttc };
            int[] clothBoxes_value = new int[] { v_cloth_asc, v_cloth_to, v_cloth_toc, v_cloth_tw, v_cloth_twc, v_cloth_tt, v_cloth_ttc };
            for (int i = 0; i < clothBoxes.Length; i++)
            {
                Int32.TryParse(clothBoxes[i].Text, out clothBoxes_value[i]);
            }

            checkNull((clothBoxes_value[0] * 2 * 20) - clothBoxes_value[1] - (clothBoxes_value[2] * 2), o_cloth_to);
            checkNull((clothBoxes_value[0] * 2 * 10) - clothBoxes_value[3] - (clothBoxes_value[4] * 2), o_cloth_tw);
            checkNull((clothBoxes_value[0] * 2 * 20) - clothBoxes_value[5] - (clothBoxes_value[6] * 2), o_cloth_tt);
        }

        public int v_leather_asc, v_leather_to, v_leather_toc, v_leather_tw, v_leather_twc, v_leather_tt, v_leather_ttc;

        public void calc_leather()
        {
            TextBox[] leatherBoxes = new TextBox[] { this.i_leather_asc, this.i_leather_to, this.i_leather_toc, this.i_leather_tw, this.i_leather_twc, this.i_leather_tt, this.i_leather_ttc };
            int[] leatherBoxes_value = new int[] { v_leather_asc, v_leather_to, v_leather_toc, v_leather_tw, v_leather_twc, v_leather_tt, v_leather_ttc };
            for (int i = 0; i < leatherBoxes.Length; i++)
            {
                Int32.TryParse(leatherBoxes[i].Text, out leatherBoxes_value[i]);
            }

            checkNull((leatherBoxes_value[0] * 2 * 20) - leatherBoxes_value[1] - (leatherBoxes_value[2] * 2), o_leather_to);
            checkNull((leatherBoxes_value[0] * 2 * 10) - leatherBoxes_value[3] - (leatherBoxes_value[4] * 2), o_leather_tw);
            checkNull((leatherBoxes_value[0] * 2 * 20) - leatherBoxes_value[5] - (leatherBoxes_value[6] * 2), o_leather_tt);
        }

        public int v_metal_asc, v_metal_to, v_metal_toc, v_metal_tw, v_metal_twc, v_metal_tt, v_metal_ttc;
        public int v_metal_ao, v_metal_at;

        public void calc_metal()
        {
            int out_toc, out_twc;
            TextBox[] metalBoxes = new TextBox[] { this.i_metal_asc, this.i_metal_to, this.i_metal_toc, this.i_metal_twc, this.i_metal_tt, this.i_metal_ttc, this.i_metal_ao, this.i_metal_at };
            int[] metalBoxes_value = new int[] { v_metal_asc, v_metal_to, v_metal_toc, v_metal_tw, v_metal_twc, v_metal_tt, v_metal_ttc, v_metal_ao, v_metal_at };
            for (int i = 0; i < metalBoxes.Length; i++)
            {
                Int32.TryParse(metalBoxes[i].Text, out metalBoxes_value[i]);
            }

            out_toc = (metalBoxes_value[0] * 20) - metalBoxes_value[2];
            if (out_toc < 0)
            {
                out_toc = 0;
            }
            out_twc = (metalBoxes_value[0] * 10) - metalBoxes_value[3];
            if (out_twc < 0)
            {
                out_twc = 0;
            }
            checkNull(out_toc, o_craft_iron);
            checkNull(out_twc, o_craft_steel);
            checkNull((out_toc * 3) + (out_twc * 3) - metalBoxes_value[1], o_metal_to);
            checkNull((metalBoxes_value[0] * 2 * 20) - metalBoxes_value[4] - (2 * metalBoxes_value[5]), o_metal_tt);
            checkNull((metalBoxes_value[0] * 10) - metalBoxes_value[6] - (metalBoxes_value[3]), o_metal_ao);
            checkNull((metalBoxes_value[0] * 20) - metalBoxes_value[7] - (metalBoxes_value[5]), o_metal_at);
        }
    }
}