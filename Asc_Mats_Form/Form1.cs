using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Resources;
using System.Windows.Forms;

namespace AscendedMaterialsForm
{
    public partial class Form1 : Form
    {
        private ResourceManager rm;
        private CultureInfo cul;

        private void switchLanguage(string lang)
        {
            cul = CultureInfo.CreateSpecificCulture(lang);
        }

        private void checkChanged()
        {
            if (rad_english.Checked)
            {
                switchLanguage("en-US");
            }
            else if (rad_german.Checked)
            {
                switchLanguage("de-DE");
            }
            else if (rad_french.Checked)
            {
                switchLanguage("fr-FR");
            }
            else if (rad_spanish.Checked)
            {
                switchLanguage("es-ES");
            }
            else
            {
                switchLanguage("");
            }
            setLabels();
        }

        private void rad_english_CheckedChanged(object sender, System.EventArgs e)
        {
            checkChanged();
        }

        private void rad_german_CheckedChanged(object sender, System.EventArgs e)
        {
            checkChanged();
        }

        private void rad_french_CheckedChanged(object sender, System.EventArgs e)
        {
            checkChanged();
        }

        private void rad_spanish_CheckedChanged(object sender, System.EventArgs e)
        {
            checkChanged();
        }

        private void labelText(Label[] labels, string[] texts)
        {
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Text = @rm.GetString(texts[i], cul);
            }
        }

        private void setLabels()
        {
            Label[] woodLabels = new Label[] { label_title_wood, label_i_wood_asc, label_i_wood_to, label_o_wood_to, label_i_wood_toc, label_i_wood_tw, label_o_wood_tw, label_i_wood_twc, label_i_wood_tt, label_o_wood_tt, label_i_wood_ttc };
            string[] woodTexts = new string[] { "wood_title", "wood_asc", "wood_to", "wood_to", "wood_toc", "wood_tw", "wood_tw", "wood_twc", "wood_tt", "wood_tt", "wood_ttc" };
            Label[] clothLabels = new Label[] { this.label_title_cloth, this.label_i_cloth_asc, this.label_i_cloth_to, this.label_o_cloth_to, this.label_i_cloth_toc, this.label_i_cloth_tw, this.label_o_cloth_tw, this.label_i_cloth_twc, this.label_i_cloth_tt, this.label_o_cloth_tt, this.label_i_cloth_ttc };
            string[] clothTexts = new string[] { "cloth_title", "cloth_asc", "cloth_to", "cloth_to", "cloth_toc", "cloth_tw", "cloth_tw", "cloth_twc", "cloth_tt", "cloth_tt", "cloth_ttc" };
            Label[] metalLabels = new Label[] { label_title_metal, this.label_i_metal_asc, this.label_i_metal_to, this.label_o_metal_to, this.label_i_metal_toc, this.label_craft_iron, this.label_i_metal_ao, this.label_o_metal_ao, this.label_i_metal_twc, this.label_craft_steel, this.label_i_metal_tt, this.label_o_metal_tt, this.label_i_metal_at, this.label_o_metal_at, this.label_i_metal_ttc };
            string[] metalTexts = new string[] { "metal_title", "metal_asc", "metal_to", "metal_to", "metal_toc", "metal_toc", "metal_ao", "metal_ao", "metal_twc", "metal_twc", "metal_tt", "metal_tt", "metal_at", "metal_at", "metal_ttc" };
            Label[] leatherLabels = new Label[] { this.label_title_leather, this.label_i_leather_asc, this.label_i_leather_to, this.label_o_leather_to, this.label_i_leather_toc, this.label_i_leather_tw, this.label_o_leather_tw, this.label_i_leather_twc, this.label_i_leather_tt, this.label_o_leather_tt, this.label_i_leather_ttc };
            string[] leatherTexts = new string[] { "leather_title", "leather_asc", "leather_to", "leather_to", "leather_toc", "leather_tw", "leather_tw", "leather_twc", "leather_tt", "leather_tt", "leather_ttc" };
            labelText(woodLabels, woodTexts);
            labelText(clothLabels, clothTexts);
            labelText(leatherLabels, leatherTexts);
            labelText(metalLabels, metalTexts);
            Label[] globalLabels = new Label[] { label_needed, label_storage, label_craft };
            string[] globalTexts = new string[] { "needed", "storage", "craft" };
            labelText(globalLabels, globalTexts);
            rad_english.Text = rm.GetString("en_menu", cul);
            rad_german.Text = rm.GetString("de_menu", cul);
            rad_french.Text = rm.GetString("fr_menu", cul);
            rad_spanish.Text = rm.GetString("es_menu", cul);
        }

        private static Size buttonstandard = new Size(20, 20);

        private static Font header = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Bold);
        private string[] contents = new string[29];
        private int ti = 0;
        public int v_cloth_asc, v_cloth_to, v_cloth_toc, v_cloth_tw, v_cloth_twc, v_cloth_tt, v_cloth_ttc;
        public int v_leather_asc, v_leather_to, v_leather_toc, v_leather_tw, v_leather_twc, v_leather_tt, v_leather_ttc;
        public int v_metal_ao, v_metal_at;
        public int v_metal_asc, v_metal_to, v_metal_toc, v_metal_tw, v_metal_twc, v_metal_tt, v_metal_ttc;
        public int v_wood_asc, v_wood_to, v_wood_toc, v_wood_tw, v_wood_twc, v_wood_tt, v_wood_ttc;

        private cloth cloth = new cloth();

        private int iiron, icoal, iplatinum, iprimordium, isoft, iseasoned, ihard, iwool, icotton, ilinen, ithin, icoarse, irugged;

        private leather leather = new leather();

        private metal metal = new metal();

        private wood wood = new wood();

        public Form1()
        {
            InitializeComponent();
            cul = CultureInfo.CurrentCulture;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            DialogResult Result = saveFileDialog1.ShowDialog();
            if ((Result == DialogResult.OK) && (saveFileDialog1.FileName.Length > 0))
            {
                contents[0] = this.i_wood_asc.Text;
                contents[1] = this.i_wood_to.Text;
                contents[2] = this.i_wood_toc.Text;
                contents[3] = this.i_wood_tw.Text;
                contents[4] = this.i_wood_twc.Text;
                contents[5] = this.i_wood_ttc.Text;
                contents[6] = this.i_wood_ttc.Text;
                contents[7] = this.i_cloth_asc.Text;
                contents[8] = this.i_cloth_to.Text;
                contents[9] = this.i_cloth_toc.Text;
                contents[10] = this.i_cloth_tw.Text;
                contents[11] = this.i_cloth_twc.Text;
                contents[12] = this.i_cloth_ttc.Text;
                contents[13] = this.i_cloth_ttc.Text;
                contents[14] = this.i_leather_asc.Text;
                contents[15] = this.i_leather_to.Text;
                contents[16] = this.i_leather_toc.Text;
                contents[17] = this.i_leather_tw.Text;
                contents[18] = this.i_leather_twc.Text;
                contents[19] = this.i_leather_tt.Text;
                contents[20] = this.i_leather_ttc.Text;
                contents[21] = this.i_metal_asc.Text;
                contents[22] = this.i_metal_to.Text;
                contents[23] = this.i_metal_toc.Text;
                contents[24] = this.i_metal_ao.Text;
                contents[25] = this.i_metal_twc.Text;
                contents[26] = this.i_metal_tt.Text;
                contents[27] = this.i_metal_at.Text;
                contents[28] = this.i_metal_ttc.Text;
                string name = saveFileDialog1.FileName;
                System.IO.File.WriteAllLines(name, contents);
            }
        }

        private void calc_cloth()
        {
            TextBox[] clothBoxes = new TextBox[] { this.i_cloth_asc, this.i_cloth_to, this.i_cloth_toc, this.i_cloth_tw, this.i_cloth_twc, this.i_cloth_tt, this.i_cloth_ttc };
            int[] clothBoxes_value = new int[] { v_cloth_asc, v_cloth_to, v_cloth_toc, v_cloth_tw, v_cloth_twc, v_cloth_tt, v_cloth_ttc };
            for (int i = 0; i < clothBoxes.Length; i++)
            {
                Int32.TryParse(clothBoxes[i].Text, out clothBoxes_value[i]);
            }
            int wool = (clothBoxes_value[0] * 2 * 20) - clothBoxes_value[1] - (clothBoxes_value[2] * 2);
            checkNull(wool, out wool);
            SetValue(wool, o_cloth_to);
            int woolPrice = iwool * wool;
            label_o_cloth_to_price.Text = formatAsGold(woolPrice);
            //
            int cotton = (clothBoxes_value[0] * 2 * 10) - clothBoxes_value[3] - (clothBoxes_value[4] * 2);
            checkNull(cotton, out cotton);
            SetValue(cotton, o_cloth_tw);
            int cottonPrice = icotton * cotton;
            label_o_cloth_tw_price.Text = formatAsGold(cottonPrice);
            //
            int linen = (clothBoxes_value[0] * 2 * 20) - clothBoxes_value[5] - (clothBoxes_value[6] * 2);
            checkNull(linen, out linen);
            SetValue(linen, o_cloth_tt);
            int linenPrice = ilinen * linen;
            label_o_cloth_tt_price.Text = formatAsGold(linenPrice);
            label_cloth_total.Text = formatAsGold(woolPrice + cottonPrice + linenPrice);
        }

        private void calc_leather()
        {
            TextBox[] leatherBoxes = new TextBox[] { this.i_leather_asc, this.i_leather_to, this.i_leather_toc, this.i_leather_tw, this.i_leather_twc, this.i_leather_tt, this.i_leather_ttc };
            int[] leatherBoxes_value = new int[] { v_leather_asc, v_leather_to, v_leather_toc, v_leather_tw, v_leather_twc, v_leather_tt, v_leather_ttc };
            for (int i = 0; i < leatherBoxes.Length; i++)
            {
                Int32.TryParse(leatherBoxes[i].Text, out leatherBoxes_value[i]);
            }
            int thin = (leatherBoxes_value[0] * 2 * 20) - leatherBoxes_value[1] - (leatherBoxes_value[2] * 2);
            checkNull(thin, out thin);
            SetValue(thin, o_leather_to);
            int thinPrice = ithin * thin;
            label_o_leather_to_price.Text = formatAsGold(thinPrice);
            //
            int coarse = (leatherBoxes_value[0] * 2 * 10) - leatherBoxes_value[3] - (leatherBoxes_value[4] * 2);
            checkNull(coarse, out coarse);
            SetValue(coarse, o_leather_tw);
            int coarsePrice = icoarse * coarse;
            label_o_leather_tw_price.Text = formatAsGold(coarsePrice);
            //
            int rugged = (leatherBoxes_value[0] * 2 * 20) - leatherBoxes_value[5] - (leatherBoxes_value[6] * 2);
            checkNull(rugged, out rugged);
            SetValue(rugged, o_leather_tt);
            int ruggedPrice = irugged * rugged;
            label_o_leather_tt_price.Text = formatAsGold(ruggedPrice);
            //
            label_leather_total.Text = formatAsGold(thinPrice + coarsePrice + ruggedPrice);
        }

        private void calc_metal()
        {
            int out_toc, out_twc;
            TextBox[] metalBoxes = new TextBox[] { this.i_metal_asc, this.i_metal_to, this.i_metal_toc, this.i_metal_twc, this.i_metal_tt, this.i_metal_ttc, this.i_metal_ao, this.i_metal_at };
            int[] metalBoxes_value = new int[] { v_metal_asc, v_metal_to, v_metal_toc, v_metal_tw, v_metal_twc, v_metal_tt, v_metal_ttc, v_metal_ao, v_metal_at };
            for (int i = 0; i < metalBoxes.Length; i++)
            {
                Int32.TryParse(metalBoxes[i].Text, out metalBoxes_value[i]);
            }

            out_toc = (metalBoxes_value[0] * 20) - metalBoxes_value[2];
            checkNull(out_toc, out out_toc);
            o_craft_iron.Text = out_toc.ToString();
            out_twc = (metalBoxes_value[0] * 10) - metalBoxes_value[3];
            checkNull(out_twc, out out_twc);
            o_craft_steel.Text = out_twc.ToString();
            int iron = (out_toc * 3) + (out_twc * 3) - metalBoxes_value[1];
            checkNull(iron, out iron);
            SetValue(iron, o_metal_to);
            int ironPrice = iiron * iron;
            o_iron_price.Text = formatAsGold(ironPrice);
            //
            int platinum = (metalBoxes_value[0] * 2 * 20) - metalBoxes_value[4] - (2 * metalBoxes_value[5]);
            checkNull(platinum, out platinum);
            SetValue(platinum, o_metal_tt);
            int platinumPrice = iplatinum * platinum;
            o_platinum_price.Text = formatAsGold(platinumPrice);
            //
            int coal = 10 * (((metalBoxes_value[0] * 10) - metalBoxes_value[6] - (metalBoxes_value[3]) + 9) / 10);
            checkNull(coal, out coal);
            SetValue(coal, o_metal_ao);
            int coalPrice = icoal * coal;
            label_o_metal_ao_price.Text = formatAsGold(coalPrice);
            //
            int primordium = 10 * (((metalBoxes_value[0] * 20) - metalBoxes_value[7] - (metalBoxes_value[5]) + 9) / 10);
            checkNull(primordium, out primordium);
            SetValue(primordium, o_metal_at);
            int primordiumPrice = iprimordium * primordium;
            label_o_metal_at_price.Text = formatAsGold(primordiumPrice);
            //
            label_metal_total.Text = formatAsGold(ironPrice + coalPrice + platinumPrice + primordiumPrice);
        }

        private void calc_wood()
        {
            TextBox[] woodBoxes = new TextBox[] { this.i_wood_asc, this.i_wood_to, this.i_wood_toc, this.i_wood_tw, this.i_wood_twc, this.i_wood_tt, this.i_wood_ttc };
            int[] woodBoxes_value = new int[] { v_wood_asc, v_wood_to, v_wood_toc, v_wood_tw, v_wood_twc, v_wood_tt, v_wood_ttc };
            for (int i = 0; i < woodBoxes.Length; i++)
            {
                Int32.TryParse(woodBoxes[i].Text, out woodBoxes_value[i]);
            }
            int soft = (woodBoxes_value[0] * 4 * 20) - woodBoxes_value[1] - (woodBoxes_value[2] * 4);
            checkNull(soft, out soft);
            SetValue(soft, o_wood_to);
            int softPrice = isoft * soft;
            label_o_wood_to_price.Text = formatAsGold(softPrice);
            //
            int seasoned = (woodBoxes_value[0] * 3 * 10) - woodBoxes_value[3] - (woodBoxes_value[4] * 3);
            checkNull(seasoned, out seasoned);
            SetValue(seasoned, o_wood_tw);
            int seasonedPrice = iseasoned * seasoned;
            label_o_wood_tw_price.Text = formatAsGold(seasonedPrice);
            //
            int hard = (woodBoxes_value[0] * 3 * 20) - woodBoxes_value[5] - (woodBoxes_value[6] * 3);
            checkNull(hard, out hard);
            SetValue(hard, o_wood_tt);
            int hardPrice = ihard * hard;
            label_o_wood_tt_price.Text = formatAsGold(hardPrice);
            //
            label_wood_total.Text = formatAsGold(softPrice + seasonedPrice + hardPrice);
        }

        private string formatAsGold(int p)
        {
            decimal gold;
            decimal silver;
            decimal copper;
            gold = Rounding.RoundDown(p / 10000, 0);
            silver = Rounding.RoundDown((p - (10000 * gold)) / 100, 0);
            copper = (p - (10000 * gold) - (100 * silver));
            return gold.ToString() + rm.GetString("gold", cul) + " " + silver.ToString() + rm.GetString("silver", cul) + " " + copper.ToString() + rm.GetString("copper", cul);
        }

        private int getSellPrice(int id)
        {
            var url = "https://api.guildwars2.com/v2/commerce/prices/" + id.ToString();
            var sellprice = _download_serialized_json_data<API>(url);
            int sell = sellprice.Sells["unit_price"];
            return sell;
        }

        private static T _download_serialized_json_data<T>(string url) where T : new()
        {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString(url);
                }
                catch (Exception)
                {
                }
                // if string with JSON data is not empty, deserialize it to class and return its instance
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }

        private void but_min_cloth_Click(object sender, EventArgs e)
        {
            minus(this.i_cloth_asc);
            calc_cloth();
        }

        private void but_min_leather_Click(object sender, EventArgs e)
        {
            minus(this.i_leather_asc);
            calc_leather();
        }

        private void but_min_metal_Click(object sender, EventArgs e)
        {
            minus(this.i_metal_asc);
            calc_metal();
        }

        private void but_min_wood_Click(object sender, EventArgs e)
        {
            minus(this.i_wood_asc);
            calc_wood();
        }

        private void but_pl_cloth_Click(object sender, EventArgs e)
        {
            plus(this.i_cloth_asc);
            calc_cloth();
        }

        private void but_pl_leather_Click(object sender, EventArgs e)
        {
            plus(this.i_leather_asc);
            calc_leather();
        }

        private void but_pl_metal_Click(object sender, EventArgs e)
        {
            plus(this.i_metal_asc);
            calc_metal();
        }

        private void but_pl_wood_Click(object sender, EventArgs e)
        {
            plus(this.i_wood_asc);
            calc_wood();
        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            calc_wood();
            calc_cloth();
            calc_metal();
            calc_leather();
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            DialogResult Result = openFileDialog1.ShowDialog();
            if (Result == DialogResult.OK)
            {
                string name = openFileDialog1.FileName;
                contents = System.IO.File.ReadAllLines(name);
                this.i_wood_asc.Text = contents[0];
                this.i_wood_to.Text = contents[1];
                this.i_wood_toc.Text = contents[2];
                this.i_wood_tw.Text = contents[3];
                this.i_wood_twc.Text = contents[4];
                this.i_wood_ttc.Text = contents[5];
                this.i_wood_ttc.Text = contents[6];
                this.i_cloth_asc.Text = contents[7];
                this.i_cloth_to.Text = contents[8];
                this.i_cloth_toc.Text = contents[9];
                this.i_cloth_tw.Text = contents[10];
                this.i_cloth_twc.Text = contents[11];
                this.i_cloth_ttc.Text = contents[12];
                this.i_cloth_ttc.Text = contents[13];
                this.i_leather_asc.Text = contents[14];
                this.i_leather_to.Text = contents[15];
                this.i_leather_toc.Text = contents[16];
                this.i_leather_tw.Text = contents[17];
                this.i_leather_twc.Text = contents[18];
                this.i_leather_tt.Text = contents[19];
                this.i_leather_ttc.Text = contents[20];
                this.i_metal_asc.Text = contents[21];
                this.i_metal_to.Text = contents[22];
                this.i_metal_toc.Text = contents[23];
                this.i_metal_ao.Text = contents[24];
                this.i_metal_twc.Text = contents[25];
                this.i_metal_tt.Text = contents[26];
                this.i_metal_at.Text = contents[27];
                this.i_metal_ttc.Text = contents[28];
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
            calc_wood();
            calc_cloth();
            calc_metal();
            calc_leather();
        }

        private int checkNull(int x, out int y)
        {
            if (x <= 0)
            {
                return y = 0;
            }
            else
                return y = x;
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

        private void createControls()
        {
            this.label_storage.Font = new Font("Microsoft Sans Serif", 9.25F, FontStyle.Bold);
            this.label_storage.Location = new Point(this.pan_wood.Location.X, this.pan_wood.Location.Y + 25);
            this.label_storage.Text = "Storage";
            this.label_needed.Font = new Font("Microsoft Sans Serif", 9.25F, FontStyle.Bold);
            this.label_needed.Location = new Point(this.pan_wood.Location.X, this.pan_wood.Location.Y + 275);
            this.label_needed.Text = "Needed";
            createControlsWood();
            createControlsCloth();
            createControlsMetal();
            createControlsLeather();
            this.panel_languages.Location = new Point(this.pan_wood.Location.X + 250, this.pan_wood.Location.Y + 380);
            this.rad_german.Location = new Point(rad_english.Location.X, rad_english.Location.Y + rad_english.Height);
            this.rad_french.Location = new Point(rad_german.Location.X, rad_german.Location.Y + rad_german.Height);
            this.rad_spanish.Location = new Point(rad_french.Location.X, rad_french.Location.Y + rad_french.Height);
        }

        private void createControlsCloth()
        {
            createHeader(label_title_cloth);
            createLabelFirst(label_i_cloth_asc, label_title_cloth);
            label_i_cloth_asc.Location = new Point(label_title_cloth.Location.X, label_i_wood_asc.Location.Y);
            createTextbox(i_cloth_asc, label_i_cloth_asc);
            i_cloth_asc.Enabled = true;
            i_cloth_asc.TextChanged += new EventHandler(i_cloth_asc_TextChanged);
            but_pl_cloth.Location = new Point(i_cloth_asc.Location.X + 50, i_cloth_asc.Location.Y);
            but_pl_cloth.Size = buttonstandard;
            but_pl_cloth.Text = "+";
            but_pl_cloth.Click += new EventHandler(but_pl_cloth_Click);
            but_min_cloth.Enabled = false;
            but_min_cloth.Location = new Point(but_pl_cloth.Location.X + but_pl_cloth.Width, but_pl_cloth.Location.Y);
            but_min_cloth.Size = buttonstandard;
            but_min_cloth.Text = "-";
            but_min_cloth.Click += new EventHandler(but_min_cloth_Click);
            createLabelFirst(label_i_cloth_to, label_i_cloth_asc);
            label_i_cloth_to.Location = new Point(label_i_cloth_asc.Location.X, label_i_wood_to.Location.Y);
            createTextbox(i_cloth_to, label_i_cloth_to);
            createLabelFirst(label_i_cloth_toc, label_i_cloth_to);
            createTextbox(i_cloth_toc, label_i_cloth_toc);
            createLabelFirst(label_i_cloth_tw, label_i_cloth_toc);
            createTextbox(i_cloth_tw, label_i_cloth_tw);
            createLabelFirst(label_i_cloth_twc, label_i_cloth_tw);
            createTextbox(i_cloth_twc, label_i_cloth_twc);
            createLabelFirst(label_i_cloth_tt, label_i_cloth_twc);
            createTextbox(i_cloth_tt, label_i_cloth_tt);
            createLabelFirst(label_i_cloth_ttc, label_i_cloth_tt);
            createTextbox(i_cloth_ttc, label_i_cloth_ttc);
            createLabelFirst(label_o_cloth_to, label_i_cloth_ttc);
            label_o_cloth_to.Location = new Point(label_i_cloth_ttc.Location.X, label_o_wood_to.Location.Y);
            createLabelSecond(o_cloth_to, label_o_cloth_to);
            createLabelThird(label_o_cloth_to_price, o_cloth_to);
            createLabelFirst(label_o_cloth_tw, label_o_cloth_to);
            createLabelSecond(o_cloth_tw, label_o_cloth_tw);
            createLabelThird(label_o_cloth_tw_price, o_cloth_tw);
            createLabelFirst(label_o_cloth_tt, label_o_cloth_tw);
            createLabelSecond(o_cloth_tt, label_o_cloth_tt);
            createLabelThird(label_o_cloth_tt_price, o_cloth_tt);
            createLabelTotal(label_cloth_total, label_o_cloth_to_price);
            label_cloth_total.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
        }

        private void createControlsLeather()
        {
            createHeader(label_title_leather);
            createLabelFirst(label_i_leather_asc, label_title_leather);
            label_i_leather_asc.Location = new Point(label_title_leather.Location.X, label_i_wood_asc.Location.Y);
            createTextbox(i_leather_asc, label_i_leather_asc);
            i_leather_asc.Enabled = true;
            i_leather_asc.TextChanged += new EventHandler(i_leather_asc_TextChanged);
            but_pl_leather.Location = new Point(i_leather_asc.Location.X + 50, i_leather_asc.Location.Y);
            but_pl_leather.Size = buttonstandard;
            but_pl_leather.Text = "+";
            but_pl_leather.Click += new EventHandler(but_pl_leather_Click);
            but_min_leather.Enabled = false;
            but_min_leather.Location = new Point(but_pl_leather.Location.X + but_pl_leather.Width, but_pl_leather.Location.Y);
            but_min_leather.Size = buttonstandard;
            but_min_leather.Text = "-";
            but_min_leather.Click += new EventHandler(but_min_leather_Click);
            createLabelFirst(label_i_leather_to, label_i_leather_asc);
            label_i_leather_to.Location = new Point(label_i_leather_asc.Location.X, label_i_wood_to.Location.Y);
            createTextbox(i_leather_to, label_i_leather_to);
            createLabelFirst(label_i_leather_toc, label_i_leather_to);
            createTextbox(i_leather_toc, label_i_leather_toc);
            createLabelFirst(label_i_leather_tw, label_i_leather_toc);
            createTextbox(i_leather_tw, label_i_leather_tw);
            createLabelFirst(label_i_leather_twc, label_i_leather_tw);
            createTextbox(i_leather_twc, label_i_leather_twc);
            createLabelFirst(label_i_leather_tt, label_i_leather_twc);
            createTextbox(i_leather_tt, label_i_leather_tt);
            createLabelFirst(label_i_leather_ttc, label_i_leather_tt);
            createTextbox(i_leather_ttc, label_i_leather_ttc);
            createLabelFirst(label_o_leather_to, label_i_leather_ttc);
            label_o_leather_to.Location = new Point(label_i_leather_ttc.Location.X, label_o_wood_to.Location.Y);
            createLabelSecond(o_leather_to, label_o_leather_to);
            createLabelThird(label_o_leather_to_price, o_leather_to);
            createLabelFirst(label_o_leather_tw, label_o_leather_to);
            createLabelSecond(o_leather_tw, label_o_leather_tw);
            createLabelThird(label_o_leather_tw_price, o_leather_tw);
            createLabelFirst(label_o_leather_tt, label_o_leather_tw);
            createLabelSecond(o_leather_tt, label_o_leather_tt);
            createLabelThird(label_o_leather_tt_price, o_leather_tt);
            createLabelTotal(label_leather_total, label_o_leather_to_price);
            label_leather_total.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
        }

        private void createControlsMetal()
        {
            createHeader(label_title_metal);
            createLabelFirst(label_i_metal_asc, label_title_metal);
            label_i_metal_asc.Location = new Point(label_title_metal.Location.X, label_i_wood_asc.Location.Y);
            createTextbox(i_metal_asc, label_i_metal_asc);
            i_metal_asc.Enabled = true;
            i_metal_asc.TextChanged += new EventHandler(i_metal_asc_TextChanged);
            but_pl_metal.Location = new Point(i_metal_asc.Location.X + 50, i_metal_asc.Location.Y);
            but_pl_metal.Size = buttonstandard;
            but_pl_metal.Text = "+";
            but_pl_metal.Click += new EventHandler(but_pl_metal_Click);
            but_min_metal.Enabled = false;
            but_min_metal.Location = new Point(but_pl_metal.Location.X + but_pl_metal.Width, but_pl_metal.Location.Y);
            but_min_metal.Size = buttonstandard;
            but_min_metal.Text = "-";
            but_min_metal.Click += new EventHandler(but_min_metal_Click);
            createLabelFirst(label_i_metal_to, label_i_metal_asc);
            label_i_metal_to.Location = new Point(label_i_metal_asc.Location.X, label_i_wood_to.Location.Y);
            createTextbox(i_metal_to, label_i_metal_to);
            createLabelFirst(label_i_metal_toc, label_i_metal_to);
            createTextbox(i_metal_toc, label_i_metal_toc);
            createLabelFirst(label_i_metal_ao, label_i_metal_toc);
            createTextbox(i_metal_ao, label_i_metal_ao);
            createLabelFirst(label_i_metal_twc, label_i_metal_ao);
            createTextbox(i_metal_twc, label_i_metal_twc);
            createLabelFirst(label_i_metal_tt, label_i_metal_twc);
            createTextbox(i_metal_tt, label_i_metal_tt);
            createLabelFirst(label_i_metal_at, label_i_metal_tt);
            createTextbox(i_metal_at, label_i_metal_at);
            createLabelFirst(label_i_metal_ttc, label_i_metal_at);
            createTextbox(i_metal_ttc, label_i_metal_ttc);
            createLabelFirst(label_o_metal_to, label_i_metal_ttc);
            label_o_metal_to.Location = new Point(label_i_metal_ttc.Location.X, label_o_wood_to.Location.Y);
            createLabelSecond(o_metal_to, label_o_metal_to);
            createLabelThird(o_iron_price, o_metal_to);
            createLabelFirst(label_o_metal_ao, label_o_metal_to);
            createLabelSecond(o_metal_ao, label_o_metal_ao);
            createLabelThird(label_o_metal_ao_price, o_metal_ao);
            createLabelFirst(label_o_metal_tt, label_o_metal_ao);
            createLabelSecond(o_metal_tt, label_o_metal_tt);
            createLabelThird(o_platinum_price, o_metal_tt);
            createLabelFirst(label_o_metal_at, label_o_metal_tt);
            createLabelSecond(o_metal_at, label_o_metal_at);
            createLabelThird(label_o_metal_at_price, o_metal_at);
            createLabelTotal(label_metal_total, o_iron_price);
            label_metal_total.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            createLabelFirst(label_craft, label_o_metal_at);
            label_craft.Text = "Craft";
            label_craft.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            createLabelFirst(label_craft_iron, label_craft);
            createLabelSecond(o_craft_iron, label_craft_iron);
            createLabelFirst(label_craft_steel, label_craft_iron);
            createLabelSecond(o_craft_steel, label_craft_steel);
        }

        private void createControlsWood()
        {
            createHeader(label_title_wood);
            createLabelFirst(label_i_wood_asc, label_storage);
            label_i_wood_asc.Location = new Point(label_storage.Location.X, label_storage.Location.Y + label_storage.Height + 2);
            createTextbox(i_wood_asc, label_i_wood_asc);
            i_wood_asc.Enabled = true;
            i_wood_asc.TextChanged += new EventHandler(i_wood_asc_TextChanged);
            but_pl_wood.Location = new Point(i_wood_asc.Location.X + 50, i_wood_asc.Location.Y);
            but_pl_wood.Size = buttonstandard;
            but_pl_wood.Text = "+";
            but_pl_wood.Click += new EventHandler(but_pl_wood_Click);
            but_min_wood.Enabled = false;
            but_min_wood.Location = new Point(but_pl_wood.Location.X + but_pl_wood.Width, but_pl_wood.Location.Y);
            but_min_wood.Size = buttonstandard;
            but_min_wood.Text = "-";
            but_min_wood.Click += new EventHandler(but_min_wood_Click);
            createLabelFirst(label_i_wood_to, label_i_wood_asc);
            label_i_wood_to.Location = new Point(label_i_wood_asc.Location.X, label_i_wood_asc.Location.Y + label_i_wood_asc.Height + 10);
            createTextbox(i_wood_to, label_i_wood_to);
            createLabelFirst(label_i_wood_toc, label_i_wood_to);
            createTextbox(i_wood_toc, label_i_wood_toc);
            createLabelFirst(label_i_wood_tw, label_i_wood_toc);
            createTextbox(i_wood_tw, label_i_wood_tw);
            createLabelFirst(label_i_wood_twc, label_i_wood_tw);
            createTextbox(i_wood_twc, label_i_wood_twc);
            createLabelFirst(label_i_wood_tt, label_i_wood_twc);
            createTextbox(i_wood_tt, label_i_wood_tt);
            createLabelFirst(label_i_wood_ttc, label_i_wood_tt);
            createTextbox(i_wood_ttc, label_i_wood_ttc);
            createLabelFirst(label_o_wood_to, label_needed);
            label_o_wood_to.Location = new Point(label_needed.Location.X, label_needed.Location.Y + label_needed.Height + 2);
            createLabelSecond(o_wood_to, label_o_wood_to);
            createLabelThird(label_o_wood_to_price, o_wood_to);
            createLabelFirst(label_o_wood_tw, label_o_wood_to);
            createLabelSecond(o_wood_tw, label_o_wood_tw);
            createLabelThird(label_o_wood_tw_price, o_wood_tw);
            createLabelFirst(label_o_wood_tt, label_o_wood_tw);
            createLabelSecond(o_wood_tt, label_o_wood_tt);
            createLabelThird(label_o_wood_tt_price, o_wood_tt);
            createLabelTotal(label_wood_total, label_o_wood_to_price);
            label_wood_total.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
        }

        private void createHeader(Label active)
        {
            active.MaximumSize = new Size(250, 0);
            createLabel(active);
            active.Font = header;
        }

        private void createLabel(Label active)
        {
            active.AutoSize = true;
        }

        private static Size labelSecondStandard = new Size(50, textboxStandard.Height);

        private void createLabelFirst(Label active, Label parent)
        {
            active.MaximumSize = new Size(120, 0);
            createLabel(active);
            active.Location = new Point(parent.Location.X, parent.Location.Y + 27);
        }

        private void createLabelSecond(Label active, Label parent)
        {
            createLabel(active);
            active.Location = new Point(parent.Location.X + 120, parent.Location.Y);
            active.Size = labelSecondStandard;
        }

        private void createLabelThird(Label active, Label parent)
        {
            createLabel(active);
            active.Location = new Point(parent.Location.X + 50, parent.Location.Y);
            active.Size = labelSecondStandard;
        }

        private void createLabelTotal(Label active, Label parent)
        {
            createLabel(active);
            active.Location = new Point(parent.Location.X - 10, parent.Location.Y - parent.Height - 10);
            active.Size = labelSecondStandard;
        }

        private static Size textboxStandard = new Size(45, 20);

        private void createTextbox(TextBox active, Label parent)
        {
            active.Enabled = false;
            active.Location = new Point(parent.Location.X + 125, parent.Location.Y - 3);
            active.Size = textboxStandard;
            active.TabIndex = ti++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rm = new ResourceManager("AscendedMaterialsForm.AdditionalResources.Res", typeof(Form1).Assembly);

            this.panel_languages.Controls.Add(rad_english);
            this.panel_languages.Controls.Add(rad_german);
            this.panel_languages.Controls.Add(rad_french);
            this.panel_languages.Controls.Add(rad_spanish);
            if (cul.ToString() == "de-DE")
            {
                rad_german.Checked = true;
            }
            else if (cul.ToString() == "en-US")
            {
                rad_english.Checked = true;
            }
            else if (cul.ToString() == "fr-FR")
            {
                rad_french.Checked = true;
            }
            else if (cul.ToString() == "es-SP")
            {
                rad_spanish.Checked = true;
            }

            iiron = getSellPrice(19699);
            icoal = 16;
            iplatinum = getSellPrice(19702);
            iprimordium = 48;
            isoft = getSellPrice(19726);
            iseasoned = getSellPrice(19727);
            ihard = getSellPrice(19724);
            iwool = getSellPrice(19739);
            icotton = getSellPrice(19741);
            ilinen = getSellPrice(19743);
            ithin = getSellPrice(19728);
            icoarse = getSellPrice(19730);
            irugged = getSellPrice(19731);
            this.AutoSize = true;
            createControls();

            this.pan_wood.AutoSize = true;
            this.pan_cloth.AutoSize = true;
            this.pan_cloth.Location = new Point(pan_wood.Location.X + pan_wood.Width + 40, pan_wood.Location.Y);
            this.pan_metal.AutoSize = true;
            this.pan_metal.Location = new Point(pan_cloth.Location.X + pan_cloth.Width + 40, pan_cloth.Location.Y);
            this.pan_leather.AutoSize = true;
            this.pan_leather.Location = new Point(pan_metal.Location.X + pan_metal.Width + 40, pan_metal.Location.Y);
            List<Label> woodLabels = new List<Label> { this.label_title_wood, this.label_i_wood_asc, this.label_i_wood_to, this.label_o_wood_to, this.label_i_wood_toc, this.label_i_wood_tw, this.label_o_wood_tw, this.label_i_wood_twc, this.label_i_wood_tt, this.label_o_wood_tt, this.label_i_wood_ttc, this.o_wood_to, this.o_wood_tw, this.o_wood_tt, this.label_o_wood_to_price, this.label_o_wood_tw_price, this.label_o_wood_tt_price, this.label_wood_total };
            List<Label> clothLabels = new List<Label> { this.label_title_cloth, this.label_i_cloth_asc, this.label_i_cloth_to, this.label_o_cloth_to, this.label_i_cloth_toc, this.label_i_cloth_tw, this.label_o_cloth_tw, this.label_i_cloth_twc, this.label_i_cloth_tt, this.label_o_cloth_tt, this.label_i_cloth_ttc, this.o_cloth_to, this.label_o_cloth_to_price, this.o_cloth_tw, this.label_o_cloth_tw_price, this.o_cloth_tt, this.label_o_cloth_tt_price, this.label_cloth_total };
            List<Label> metalLabels = new List<Label> { this.o_metal_to, this.o_metal_tt, this.o_craft_iron, this.o_craft_steel, this.o_metal_ao, this.o_metal_at, label_title_metal, this.label_i_metal_asc, this.label_i_metal_to, this.label_o_metal_to, this.label_i_metal_toc, this.label_i_metal_ao, this.label_o_metal_ao, this.label_i_metal_twc, this.label_i_metal_tt, this.label_o_metal_tt, this.label_i_metal_at, this.label_o_metal_at, this.label_i_metal_ttc, this.label_craft_steel, this.label_craft_iron, this.o_iron_price, this.o_platinum_price, this.label_o_metal_ao_price, this.label_o_metal_at_price, this.label_metal_total };
            List<Label> leatherLabels = new List<Label> { this.label_title_leather, this.label_i_leather_asc, this.label_i_leather_to, this.label_o_leather_to, this.label_i_leather_toc, this.label_i_leather_tw, this.label_o_leather_tw, this.label_i_leather_twc, this.label_i_leather_tt, this.label_o_leather_tt, this.label_i_leather_ttc, this.o_leather_to, this.o_leather_tw, this.o_leather_tt, this.label_o_leather_to_price, this.label_o_leather_tw_price, this.label_o_leather_tt_price, this.label_leather_total };
            List<TextBox> woodBoxes = new List<TextBox> { this.i_wood_asc, this.i_wood_to, this.i_wood_toc, this.i_wood_tw, this.i_wood_twc, this.i_wood_tt, this.i_wood_ttc };
            List<TextBox> clothBoxes = new List<TextBox> { this.i_cloth_asc, this.i_cloth_to, this.i_cloth_toc, this.i_cloth_tw, this.i_cloth_twc, this.i_cloth_tt, this.i_cloth_ttc };
            List<TextBox> metalBoxes = new List<TextBox> { this.i_metal_asc, this.i_metal_to, this.i_metal_toc, this.i_metal_twc, this.i_metal_tt, this.i_metal_ttc, this.i_metal_ao, i_metal_at };
            List<TextBox> leatherBoxes = new List<TextBox> { this.i_leather_asc, this.i_leather_to, this.i_leather_toc, this.i_leather_tw, this.i_leather_twc, this.i_leather_tt, this.i_leather_ttc };
            setLabels();
            woodLabels.ForEach(s =>
            {
                this.pan_wood.Controls.Add(s);
            });
            woodBoxes.ForEach(s =>
            {
                this.pan_wood.Controls.Add(s);
            });
            clothLabels.ForEach(s =>
            {
                this.pan_cloth.Controls.Add(s);
            });
            clothBoxes.ForEach(s =>
            {
                this.pan_cloth.Controls.Add(s);
            });
            metalLabels.ForEach(s =>
            {
                this.pan_metal.Controls.Add(s);
            });
            metalBoxes.ForEach(s =>
            {
                this.pan_metal.Controls.Add(s);
            });
            leatherLabels.ForEach(s =>
            {
                this.pan_leather.Controls.Add(s);
            });
            leatherBoxes.ForEach(s =>
            {
                this.pan_leather.Controls.Add(s);
            });
            this.pan_metal.Controls.Add(label_craft);

            this.pan_wood.Controls.Add(but_pl_wood);
            this.pan_wood.Controls.Add(but_min_wood);
            this.pan_cloth.Controls.Add(but_pl_cloth);
            this.pan_cloth.Controls.Add(but_min_cloth);
            this.pan_metal.Controls.Add(but_pl_metal);
            this.pan_metal.Controls.Add(but_min_metal);
            this.pan_leather.Controls.Add(but_pl_leather);
            this.pan_leather.Controls.Add(but_min_leather);
            this.Controls.Add(pan_wood);
            this.Controls.Add(pan_cloth);
            this.Controls.Add(pan_metal);
            this.Controls.Add(pan_leather);

            this.button_save.Location = new Point(0, 10 + pan_wood.Height);
            this.button_load.Location = new Point(button_save.Location.X + button_save.Width, 10 + pan_wood.Height);
            this.button_reset.Location = new Point(button_load.Location.X + button_load.Width, 10 + pan_wood.Height);
            this.button_calc.Location = new Point(button_save.Location.X, 20 + button_save.Height + pan_wood.Height);
            this.button_calc.Width = button_load.Width + button_save.Width + button_reset.Width;
        }

        private void i_cloth_asc_TextChanged(object sender, EventArgs e)
        {
            onChange(this.pan_cloth);
        }

        private void i_leather_asc_TextChanged(object sender, EventArgs e)
        {
            onChange(this.pan_leather);
        }

        private void i_metal_asc_TextChanged(object sender, EventArgs e)
        {
            onChange(this.pan_metal);
        }

        private void i_wood_asc_TextChanged(object sender, EventArgs e)
        {
            onChange(this.pan_wood);
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

        private void onChange(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                c.Enabled = true;
            }
        }

        private void plus(TextBox textbox)
        {
            int calc;
            Int32.TryParse(textbox.Text, out calc);
            calc += 1;
            textbox.Text = calc.ToString();
        }

        private void SetValue(int x, Label y)
        {
            if (x >= 250)
            {
                decimal s = Rounding.RoundDown(x / 250, 0);
                decimal rest = x - (s * 250);
                string text = s.ToString() + " : " + rest.ToString();
                y.Text = text;
            }
            else
            {
                y.Text = x.ToString();
            }
        }
    }
}