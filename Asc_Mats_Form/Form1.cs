using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace AscendedMaterialsForm
{
    public partial class Form1 : Form
    {
        private ResourceManager _rm;
        private CultureInfo _cul;

        private void SwitchLanguage(string lang)
        {
            _cul = CultureInfo.CreateSpecificCulture(lang);
        }

        private void CheckChanged()
        {
            if (rad_english.Checked)
            {
                SwitchLanguage("en-US");
            }
            else if (rad_german.Checked)
            {
                SwitchLanguage("de-DE");
            }
            else if (rad_french.Checked)
            {
                SwitchLanguage("fr-FR");
            }
            else if (rad_spanish.Checked)
            {
                SwitchLanguage("es-ES");
            }
            else
            {
                SwitchLanguage("");
            }
            SetLabels();
        }

        private void rad_english_CheckedChanged(object sender, EventArgs e)
        {
            CheckChanged();
        }

        private void rad_german_CheckedChanged(object sender, EventArgs e)
        {
            CheckChanged();
        }

        private void rad_french_CheckedChanged(object sender, EventArgs e)
        {
            CheckChanged();
        }

        private void rad_spanish_CheckedChanged(object sender, EventArgs e)
        {
            CheckChanged();
        }

        private void LabelText(Dictionary<Control, string> dict)
        {
            foreach (var item in dict)
            {
                item.Key.Text = _rm.GetString(item.Value, _cul);
            }
        }

        private Dictionary<Control, string> _woodDict;
        private Dictionary<Control, string> _clothDict;
        private Dictionary<Control, string> _metalDict;
        private Dictionary<Control, string> _leatherDict;
        private Dictionary<Control, string> _globalDict;

        private void SetLabels()
        {
            _woodDict = new Dictionary<Control, string>
            {
                {label_title_wood, "wood_title"},
                {label_i_wood_asc, "wood_asc"},
                {label_i_wood_to, "wood_to"},
                {label_o_wood_to, "wood_to"},
                {label_i_wood_toc, "wood_toc"},
                {label_i_wood_tw, "wood_tw"},
                {label_o_wood_tw, "wood_tw"},
                {label_i_wood_twc, "wood_twc"},
                {label_i_wood_tt, "wood_tt"},
                {label_o_wood_tt, "wood_tt"},
                {label_i_wood_ttc, "wood_ttc"}
            };
            _clothDict = new Dictionary<Control, string>
            {
                {label_title_cloth, "cloth_title"},
                {label_i_cloth_asc, "cloth_asc"},
                {label_i_cloth_to, "cloth_to"},
                {label_o_cloth_to, "cloth_to"},
                {label_i_cloth_toc, "cloth_toc"},
                {label_i_cloth_tw, "cloth_tw"},
                {label_o_cloth_tw, "cloth_tw"},
                {label_i_cloth_twc, "cloth_twc"},
                {label_i_cloth_tt, "cloth_tt"},
                {label_o_cloth_tt, "cloth_tt"},
                {label_i_cloth_ttc, "cloth_ttc"}
            };
            _metalDict = new Dictionary<Control, string>
            {
                {label_title_metal, "metal_title"},
                {label_i_metal_asc, "metal_asc"  },
                {label_i_metal_to,  "metal_to"   },
                {label_o_metal_to,  "metal_to"   },
                {label_i_metal_toc, "metal_toc"  },
                {label_craft_iron,  "metal_toc"  },
                {label_i_metal_ao,  "metal_ao"   },
                {label_o_metal_ao,  "metal_ao"   },
                {label_i_metal_twc, "metal_twc"  },
                {label_craft_steel, "metal_twc"  },
                {label_i_metal_tt,  "metal_tt"   },
                {label_o_metal_tt,  "metal_tt"   },
                {label_i_metal_at,  "metal_at"   },
                {label_o_metal_at,  "metal_at"   },
                {label_i_metal_ttc,  "metal_ttc"  }
            };
            _leatherDict = new Dictionary<Control, string>
            {
                {label_title_leather,"leather_title"},
                {label_i_leather_asc,"leather_asc"  },
                {label_i_leather_to, "leather_to"   },
                {label_o_leather_to, "leather_to"   },
                {label_i_leather_toc,"leather_toc"  },
                {label_i_leather_tw, "leather_tw"   },
                {label_o_leather_tw, "leather_tw"   },
                {label_i_leather_twc,"leather_twc"  },
                {label_i_leather_tt, "leather_tt"   },
                {label_o_leather_tt, "leather_tt"   },
                {label_i_leather_ttc,"leather_ttc"  }
            };
            _globalDict = new Dictionary<Control, string>
            {
                {label_needed, "needed"},
                {label_storage, "storage"},
                {label_craft, "craft"},
                {rad_english, "en_menu"},
                {rad_german, "de_menu"},
                {rad_french, "fr_menu"},
                {rad_spanish, "es_menu"},
                {button_calc, "calc"},
                {button_load, "load"},
                {button_reset, "reset"},
                {button_save, "save"}
            };
            var labels = new List<Dictionary<Control, string>>
            {
                _woodDict, _clothDict, _metalDict, _leatherDict, _globalDict
            };
            labels.ForEach(LabelText);
        }

        private static readonly Size Buttonstandard = new Size(20, 20);

        private static readonly Font Header = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Bold);
        private int _ti;

        public Form1()
        {
            InitializeComponent();
            _cul = CultureInfo.CurrentCulture;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string[] _contents = new string[29];
            var result = saveFileDialog1.ShowDialog();
            if ((result != DialogResult.OK) || (saveFileDialog1.FileName.Length <= 0))
                return;
            List<Control> TB = new List<Control>
            {
                i_wood_asc, i_wood_to, i_wood_toc, i_wood_tw, i_wood_twc, i_wood_ttc, i_wood_ttc,  i_cloth_asc, i_cloth_to, i_cloth_toc, i_cloth_tw, i_cloth_twc,  i_cloth_ttc,  i_cloth_ttc,  i_leather_asc, i_leather_to,  i_leather_toc, i_leather_tw, i_leather_twc,  i_leather_tt,   i_leather_ttc, i_metal_asc,    i_metal_to,  i_metal_toc, i_metal_ao,  i_metal_twc, i_metal_tt,i_metal_at, i_metal_ttc
            };
            for (int i = 0; i < TB.Count; i++)
            {
                _contents[i] = TB[i].Text;
            }
            var name = saveFileDialog1.FileName;
            File.WriteAllLines(name, _contents);
        }

        private int calcStruct(string s, int i, Label label, Label labelprice)
        {
            SetValue(i, label);
            var temp = GetPrice(s, i);
            labelprice.Text = FormatAsGold(temp);
            return temp;
        }

        private static int getTB(TextBox tb)
        {
            int temp;
            int.TryParse(tb.Text, out temp);
            return temp;
        }

        private void calc_cloth()
        {
            Cloth cloth = new Cloth(getTB(i_cloth_asc), getTB(i_cloth_to), getTB(i_cloth_toc), getTB(i_cloth_tw), getTB(i_cloth_twc), getTB(i_cloth_tt), getTB(i_cloth_ttc));
            var woolPrice = calcStruct("wool", cloth.to(), o_cloth_to, label_o_cloth_to_price);
            var cottonPrice = calcStruct("cotton", cloth.tw(), o_cloth_tw, label_o_cloth_tw_price);
            var linenPrice = calcStruct("linen", cloth.tt(), o_cloth_tt, label_o_cloth_tt_price);
            label_cloth_total.Text = FormatAsGold(woolPrice + cottonPrice + linenPrice);
        }

        private void calc_leather()
        {
            Leather leather = new Leather(getTB(i_leather_asc), getTB(i_leather_to), getTB(i_leather_toc), getTB(i_leather_tw), getTB(i_leather_twc), getTB(i_leather_tt), getTB(i_leather_ttc));
            var thinPrice = calcStruct("thin", leather.to(), o_leather_to, label_o_leather_to_price);
            var coarsePrice = calcStruct("coarse", leather.tw(), o_leather_tw, label_o_leather_tw_price);
            var ruggedPrice = calcStruct("rugged", leather.tt(), o_leather_tt, label_o_leather_tt_price);
            label_leather_total.Text = FormatAsGold(thinPrice + coarsePrice + ruggedPrice);
        }

        private void calc_metal()
        {
            Metal metal = new Metal(getTB(i_metal_asc), getTB(i_metal_to), getTB(i_metal_toc), getTB(i_metal_twc), getTB(i_metal_tt), getTB(i_metal_ttc), getTB(i_metal_ao), getTB(i_metal_at));
            o_craft_iron.Text = metal.ironingot().ToString();
            o_craft_steel.Text = metal.steelingot().ToString();
            var ironPrice = calcStruct("iron", metal.to(), o_metal_to, o_iron_price);
            var platinumPrice = calcStruct("platinum", metal.tt(), o_metal_tt, o_platinum_price);
            var coalPrice = calcStruct("coal", metal.coal(), o_metal_ao, label_o_metal_ao_price);
            var primordiumPrice = calcStruct("primordium", metal.primordium(), o_metal_at, label_o_metal_at_price);
            label_metal_total.Text = FormatAsGold(ironPrice + coalPrice + platinumPrice + primordiumPrice);
        }

        private void calc_wood()
        {
            Wood wood = new Wood(getTB(i_wood_asc), getTB(i_wood_to), getTB(i_wood_toc), getTB(i_wood_tw), getTB(i_wood_twc), getTB(i_wood_tt), getTB(i_wood_ttc));
            var softPrice = calcStruct("soft", wood.to(), o_wood_to, label_o_wood_to_price);
            var seasonedPrice = calcStruct("seasoned", wood.tw(), o_wood_tw, label_o_wood_tw_price);
            var hardPrice = calcStruct("hard", wood.tt(), o_wood_tt, label_o_wood_tt_price);
            label_wood_total.Text = FormatAsGold(softPrice + seasonedPrice + hardPrice);
        }

        private int GetPrice(string s, int i)
        {
            var p = _prices[s] * i;
            return p;
        }

        private string FormatAsGold(int p)
        {
            var gold = Rounding.RoundDown(p / 10000, 0);
            var silver = Rounding.RoundDown((p - (10000 * gold)) / 100, 0);
            var copper = (p - (10000 * gold) - (100 * silver));
            return gold + _rm.GetString("gold", _cul) + " " + silver + _rm.GetString("silver", _cul) + " " + copper + _rm.GetString("copper", _cul);
        }

        private void but_min_cloth_Click(object sender, EventArgs e)
        {
            Minus(i_cloth_asc);
            calc_cloth();
        }

        private void but_min_leather_Click(object sender, EventArgs e)
        {
            Minus(i_leather_asc);
            calc_leather();
        }

        private void but_min_metal_Click(object sender, EventArgs e)
        {
            Minus(i_metal_asc);
            calc_metal();
        }

        private void but_min_wood_Click(object sender, EventArgs e)
        {
            Minus(i_wood_asc);
            calc_wood();
        }

        private void but_pl_cloth_Click(object sender, EventArgs e)
        {
            Plus(i_cloth_asc);
            calc_cloth();
        }

        private void but_pl_leather_Click(object sender, EventArgs e)
        {
            Plus(i_leather_asc);
            calc_leather();
        }

        private void but_pl_metal_Click(object sender, EventArgs e)
        {
            Plus(i_metal_asc);
            calc_metal();
        }

        private void but_pl_wood_Click(object sender, EventArgs e)
        {
            Plus(i_wood_asc);
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
            var result = openFileDialog1.ShowDialog();
            if (result != DialogResult.OK)
                return;
            var name = openFileDialog1.FileName;
            string[] _contents = File.ReadAllLines(name);
            List<Control> TB = new List<Control>
            {
                i_wood_asc, i_wood_to, i_wood_toc, i_wood_tw, i_wood_twc, i_wood_ttc, i_wood_ttc,  i_cloth_asc, i_cloth_to, i_cloth_toc, i_cloth_tw, i_cloth_twc,  i_cloth_ttc,  i_cloth_ttc,  i_leather_asc, i_leather_to,  i_leather_toc, i_leather_tw, i_leather_twc,  i_leather_tt,   i_leather_ttc, i_metal_asc,    i_metal_to,  i_metal_toc, i_metal_ao,  i_metal_twc, i_metal_tt,i_metal_at, i_metal_ttc
            };
            for (int i = 0; i < TB.Count; i++)
            {
                TB[i].Text = _contents[i];
            }
            calc_cloth();
            calc_leather();
            calc_metal();
            calc_wood();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(Controls);
            calc_wood();
            calc_cloth();
            calc_metal();
            calc_leather();
        }

        private static void ClearTextBoxes(Control.ControlCollection cc)
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

        private void CreateControls()
        {
            label_storage.Font = new Font("Microsoft Sans Serif", 9.25F, FontStyle.Bold);
            label_storage.Location = new Point(pan_wood.Location.X, pan_wood.Location.Y + 25);
            label_needed.Font = new Font("Microsoft Sans Serif", 9.25F, FontStyle.Bold);
            label_needed.Location = new Point(pan_wood.Location.X, pan_wood.Location.Y + 275);
            CreateControlsWood();
            CreateControlsCloth();
            CreateControlsMetal();
            CreateControlsLeather();
            panel_languages.Location = new Point(pan_wood.Location.X + 250, pan_wood.Location.Y + 380);
            rad_german.Location = new Point(rad_english.Location.X, rad_english.Location.Y + rad_english.Height);
            rad_french.Location = new Point(rad_german.Location.X, rad_german.Location.Y + rad_german.Height);
            rad_spanish.Location = new Point(rad_french.Location.X, rad_french.Location.Y + rad_french.Height);
        }

        private void CreateControlsCloth()
        {
            CreateHeader(label_title_cloth);
            CreateLabelFirst(label_i_cloth_asc, label_title_cloth);
            label_i_cloth_asc.Location = new Point(label_title_cloth.Location.X, label_i_wood_asc.Location.Y);
            CreateTextbox(i_cloth_asc, label_i_cloth_asc);
            i_cloth_asc.Enabled = true;
            i_cloth_asc.TextChanged += i_cloth_asc_TextChanged;
            but_pl_cloth.Location = new Point(i_cloth_asc.Location.X + 50, i_cloth_asc.Location.Y);
            but_pl_cloth.Size = Buttonstandard;
            but_pl_cloth.Text = "+";
            but_pl_cloth.Click += but_pl_cloth_Click;
            but_min_cloth.Enabled = false;
            but_min_cloth.Location = new Point(but_pl_cloth.Location.X + but_pl_cloth.Width, but_pl_cloth.Location.Y);
            but_min_cloth.Size = Buttonstandard;
            but_min_cloth.Text = "-";
            but_min_cloth.Click += but_min_cloth_Click;
            CreateLabelFirst(label_i_cloth_to, label_i_cloth_asc);
            label_i_cloth_to.Location = new Point(label_i_cloth_asc.Location.X, label_i_wood_to.Location.Y);
            CreateTextbox(i_cloth_to, label_i_cloth_to);
            CreateLabelFirst(label_i_cloth_toc, label_i_cloth_to);
            CreateTextbox(i_cloth_toc, label_i_cloth_toc);
            CreateLabelFirst(label_i_cloth_tw, label_i_cloth_toc);
            CreateTextbox(i_cloth_tw, label_i_cloth_tw);
            CreateLabelFirst(label_i_cloth_twc, label_i_cloth_tw);
            CreateTextbox(i_cloth_twc, label_i_cloth_twc);
            CreateLabelFirst(label_i_cloth_tt, label_i_cloth_twc);
            CreateTextbox(i_cloth_tt, label_i_cloth_tt);
            CreateLabelFirst(label_i_cloth_ttc, label_i_cloth_tt);
            CreateTextbox(i_cloth_ttc, label_i_cloth_ttc);
            CreateLabelFirst(label_o_cloth_to, label_i_cloth_ttc);
            label_o_cloth_to.Location = new Point(label_i_cloth_ttc.Location.X, label_o_wood_to.Location.Y);
            CreateLabelSecond(o_cloth_to, label_o_cloth_to);
            CreateLabelThird(label_o_cloth_to_price, o_cloth_to);
            CreateLabelFirst(label_o_cloth_tw, label_o_cloth_to);
            CreateLabelSecond(o_cloth_tw, label_o_cloth_tw);
            CreateLabelThird(label_o_cloth_tw_price, o_cloth_tw);
            CreateLabelFirst(label_o_cloth_tt, label_o_cloth_tw);
            CreateLabelSecond(o_cloth_tt, label_o_cloth_tt);
            CreateLabelThird(label_o_cloth_tt_price, o_cloth_tt);
            CreateLabelTotal(label_cloth_total, label_o_cloth_to_price);
            label_cloth_total.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
        }

        private void CreateControlsLeather()
        {
            CreateHeader(label_title_leather);
            CreateLabelFirst(label_i_leather_asc, label_title_leather);
            label_i_leather_asc.Location = new Point(label_title_leather.Location.X, label_i_wood_asc.Location.Y);
            CreateTextbox(i_leather_asc, label_i_leather_asc);
            i_leather_asc.Enabled = true;
            i_leather_asc.TextChanged += i_leather_asc_TextChanged;
            but_pl_leather.Location = new Point(i_leather_asc.Location.X + 50, i_leather_asc.Location.Y);
            but_pl_leather.Size = Buttonstandard;
            but_pl_leather.Text = "+";
            but_pl_leather.Click += but_pl_leather_Click;
            but_min_leather.Enabled = false;
            but_min_leather.Location = new Point(but_pl_leather.Location.X + but_pl_leather.Width, but_pl_leather.Location.Y);
            but_min_leather.Size = Buttonstandard;
            but_min_leather.Text = "-";
            but_min_leather.Click += but_min_leather_Click;
            CreateLabelFirst(label_i_leather_to, label_i_leather_asc);
            label_i_leather_to.Location = new Point(label_i_leather_asc.Location.X, label_i_wood_to.Location.Y);
            CreateTextbox(i_leather_to, label_i_leather_to);
            CreateLabelFirst(label_i_leather_toc, label_i_leather_to);
            CreateTextbox(i_leather_toc, label_i_leather_toc);
            CreateLabelFirst(label_i_leather_tw, label_i_leather_toc);
            CreateTextbox(i_leather_tw, label_i_leather_tw);
            CreateLabelFirst(label_i_leather_twc, label_i_leather_tw);
            CreateTextbox(i_leather_twc, label_i_leather_twc);
            CreateLabelFirst(label_i_leather_tt, label_i_leather_twc);
            CreateTextbox(i_leather_tt, label_i_leather_tt);
            CreateLabelFirst(label_i_leather_ttc, label_i_leather_tt);
            CreateTextbox(i_leather_ttc, label_i_leather_ttc);
            CreateLabelFirst(label_o_leather_to, label_i_leather_ttc);
            label_o_leather_to.Location = new Point(label_i_leather_ttc.Location.X, label_o_wood_to.Location.Y);
            CreateLabelSecond(o_leather_to, label_o_leather_to);
            CreateLabelThird(label_o_leather_to_price, o_leather_to);
            CreateLabelFirst(label_o_leather_tw, label_o_leather_to);
            CreateLabelSecond(o_leather_tw, label_o_leather_tw);
            CreateLabelThird(label_o_leather_tw_price, o_leather_tw);
            CreateLabelFirst(label_o_leather_tt, label_o_leather_tw);
            CreateLabelSecond(o_leather_tt, label_o_leather_tt);
            CreateLabelThird(label_o_leather_tt_price, o_leather_tt);
            CreateLabelTotal(label_leather_total, label_o_leather_to_price);
            label_leather_total.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
        }

        private void CreateControlsMetal()
        {
            CreateHeader(label_title_metal);
            CreateLabelFirst(label_i_metal_asc, label_title_metal);
            label_i_metal_asc.Location = new Point(label_title_metal.Location.X, label_i_wood_asc.Location.Y);
            CreateTextbox(i_metal_asc, label_i_metal_asc);
            i_metal_asc.Enabled = true;
            i_metal_asc.TextChanged += i_metal_asc_TextChanged;
            but_pl_metal.Location = new Point(i_metal_asc.Location.X + 50, i_metal_asc.Location.Y);
            but_pl_metal.Size = Buttonstandard;
            but_pl_metal.Text = "+";
            but_pl_metal.Click += but_pl_metal_Click;
            but_min_metal.Enabled = false;
            but_min_metal.Location = new Point(but_pl_metal.Location.X + but_pl_metal.Width, but_pl_metal.Location.Y);
            but_min_metal.Size = Buttonstandard;
            but_min_metal.Text = "-";
            but_min_metal.Click += but_min_metal_Click;
            CreateLabelFirst(label_i_metal_to, label_i_metal_asc);
            label_i_metal_to.Location = new Point(label_i_metal_asc.Location.X, label_i_wood_to.Location.Y);
            CreateTextbox(i_metal_to, label_i_metal_to);
            CreateLabelFirst(label_i_metal_toc, label_i_metal_to);
            CreateTextbox(i_metal_toc, label_i_metal_toc);
            CreateLabelFirst(label_i_metal_ao, label_i_metal_toc);
            CreateTextbox(i_metal_ao, label_i_metal_ao);
            CreateLabelFirst(label_i_metal_twc, label_i_metal_ao);
            CreateTextbox(i_metal_twc, label_i_metal_twc);
            CreateLabelFirst(label_i_metal_tt, label_i_metal_twc);
            CreateTextbox(i_metal_tt, label_i_metal_tt);
            CreateLabelFirst(label_i_metal_at, label_i_metal_tt);
            CreateTextbox(i_metal_at, label_i_metal_at);
            CreateLabelFirst(label_i_metal_ttc, label_i_metal_at);
            CreateTextbox(i_metal_ttc, label_i_metal_ttc);
            CreateLabelFirst(label_o_metal_to, label_i_metal_ttc);
            label_o_metal_to.Location = new Point(label_i_metal_ttc.Location.X, label_o_wood_to.Location.Y);
            CreateLabelSecond(o_metal_to, label_o_metal_to);
            CreateLabelThird(o_iron_price, o_metal_to);
            CreateLabelFirst(label_o_metal_ao, label_o_metal_to);
            CreateLabelSecond(o_metal_ao, label_o_metal_ao);
            CreateLabelThird(label_o_metal_ao_price, o_metal_ao);
            CreateLabelFirst(label_o_metal_tt, label_o_metal_ao);
            CreateLabelSecond(o_metal_tt, label_o_metal_tt);
            CreateLabelThird(o_platinum_price, o_metal_tt);
            CreateLabelFirst(label_o_metal_at, label_o_metal_tt);
            CreateLabelSecond(o_metal_at, label_o_metal_at);
            CreateLabelThird(label_o_metal_at_price, o_metal_at);
            CreateLabelTotal(label_metal_total, o_iron_price);
            label_metal_total.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            CreateLabelFirst(label_craft, label_o_metal_at);
            label_craft.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            CreateLabelFirst(label_craft_iron, label_craft);
            CreateLabelSecond(o_craft_iron, label_craft_iron);
            CreateLabelFirst(label_craft_steel, label_craft_iron);
            CreateLabelSecond(o_craft_steel, label_craft_steel);
        }

        private void CreateControlsWood()
        {
            CreateHeader(label_title_wood);
            CreateLabelFirst(label_i_wood_asc, label_storage);
            label_i_wood_asc.Location = new Point(label_storage.Location.X, label_storage.Location.Y + label_storage.Height + 2);
            CreateTextbox(i_wood_asc, label_i_wood_asc);
            i_wood_asc.Enabled = true;
            i_wood_asc.TextChanged += i_wood_asc_TextChanged;
            but_pl_wood.Location = new Point(i_wood_asc.Location.X + 50, i_wood_asc.Location.Y);
            but_pl_wood.Size = Buttonstandard;
            but_pl_wood.Text = "+";
            but_pl_wood.Click += but_pl_wood_Click;
            but_min_wood.Enabled = false;
            but_min_wood.Location = new Point(but_pl_wood.Location.X + but_pl_wood.Width, but_pl_wood.Location.Y);
            but_min_wood.Size = Buttonstandard;
            but_min_wood.Text = "-";
            but_min_wood.Click += but_min_wood_Click;
            CreateLabelFirst(label_i_wood_to, label_i_wood_asc);
            label_i_wood_to.Location = new Point(label_i_wood_asc.Location.X, label_i_wood_asc.Location.Y + label_i_wood_asc.Height + 10);
            CreateTextbox(i_wood_to, label_i_wood_to);
            CreateLabelFirst(label_i_wood_toc, label_i_wood_to);
            CreateTextbox(i_wood_toc, label_i_wood_toc);
            CreateLabelFirst(label_i_wood_tw, label_i_wood_toc);
            CreateTextbox(i_wood_tw, label_i_wood_tw);
            CreateLabelFirst(label_i_wood_twc, label_i_wood_tw);
            CreateTextbox(i_wood_twc, label_i_wood_twc);
            CreateLabelFirst(label_i_wood_tt, label_i_wood_twc);
            CreateTextbox(i_wood_tt, label_i_wood_tt);
            CreateLabelFirst(label_i_wood_ttc, label_i_wood_tt);
            CreateTextbox(i_wood_ttc, label_i_wood_ttc);
            CreateLabelFirst(label_o_wood_to, label_needed);
            label_o_wood_to.Location = new Point(label_needed.Location.X, label_needed.Location.Y + label_needed.Height + 2);
            CreateLabelSecond(o_wood_to, label_o_wood_to);
            CreateLabelThird(label_o_wood_to_price, o_wood_to);
            CreateLabelFirst(label_o_wood_tw, label_o_wood_to);
            CreateLabelSecond(o_wood_tw, label_o_wood_tw);
            CreateLabelThird(label_o_wood_tw_price, o_wood_tw);
            CreateLabelFirst(label_o_wood_tt, label_o_wood_tw);
            CreateLabelSecond(o_wood_tt, label_o_wood_tt);
            CreateLabelThird(label_o_wood_tt_price, o_wood_tt);
            CreateLabelTotal(label_wood_total, label_o_wood_to_price);
            label_wood_total.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
        }

        private static void CreateHeader(Control active)
        {
            active.MaximumSize = new Size(250, 0);
            CreateLabel(active);
            active.Font = Header;
        }

        private static void CreateLabel(Control active)
        {
            active.AutoSize = true;
        }

        private static readonly Size LabelSecondStandard = new Size(50, _textboxStandard.Height);

        private static void CreateLabelFirst(Control active, Control parent)
        {
            active.MaximumSize = new Size(120, 0);
            CreateLabel(active);
            active.Location = new Point(parent.Location.X, parent.Location.Y + 27);
        }

        private static void CreateLabelSecond(Control active, Control parent)
        {
            CreateLabel(active);
            active.Location = new Point(parent.Location.X + 120, parent.Location.Y);
            active.Size = LabelSecondStandard;
        }

        private static void CreateLabelThird(Control active, Control parent)
        {
            CreateLabel(active);
            active.Location = new Point(parent.Location.X + 50, parent.Location.Y);
            active.Size = LabelSecondStandard;
        }

        private static void CreateLabelTotal(Control active, Control parent)
        {
            CreateLabel(active);
            active.Location = new Point(parent.Location.X - 10, parent.Location.Y - parent.Height - 10);
            active.Size = LabelSecondStandard;
        }

        private static Size _textboxStandard = new Size(45, 20);

        private void CreateTextbox(Control active, Control parent)
        {
            active.Enabled = false;
            active.Location = new Point(parent.Location.X + 125, parent.Location.Y - 3);
            active.Size = _textboxStandard;
            active.TabIndex = _ti++;
        }

        private Dictionary<string, int> _prices;

        private void Form1_Load(object sender, EventArgs e)
        {
            _rm = new ResourceManager("AscendedMaterialsForm.AdditionalResources.Res", typeof(Form1).Assembly);
            var langSwitch = new List<Control> { rad_english, rad_german, rad_french, rad_spanish };
            langSwitch.ForEach(s =>
            {
                panel_languages.Controls.Add(s);
            });
            switch (_cul.ToString())
            {
                case "de-DE":
                    rad_german.Checked = true;
                    break;

                case "en-US":
                    rad_english.Checked = true;
                    break;

                case "fr-FR":
                    rad_french.Checked = true;
                    break;

                case "es-SP":
                    rad_spanish.Checked = true;
                    break;
            }
            Api API = new Api();
            _prices = new Dictionary<string, int>
            {
                {"iron", API.GetSellPrice(19699)},
                {"coal", 16},
                {"platinum", API.GetSellPrice(19702)},
                {"primordium", 48},
                {"soft", API.GetSellPrice(19726)},
                {"seasoned", API.GetSellPrice(19727)},
                {"hard", API.GetSellPrice(19724)},
                {"wool", API.GetSellPrice(19739)},
                {"cotton", API.GetSellPrice(19741)},
                {"linen", API.GetSellPrice(19743)},
                {"thin", API.GetSellPrice(19728)},
                {"coarse", API.GetSellPrice(19730)},
                {"rugged", API.GetSellPrice(19731)}
            };
            AutoSize = true;
            CreateControls();

            pan_wood.AutoSize = true;
            pan_cloth.AutoSize = true;
            pan_cloth.Location = new Point(pan_wood.Location.X + pan_wood.Width + 40, pan_wood.Location.Y);
            pan_metal.AutoSize = true;
            pan_metal.Location = new Point(pan_cloth.Location.X + pan_cloth.Width + 40, pan_cloth.Location.Y);
            pan_leather.AutoSize = true;
            pan_leather.Location = new Point(pan_metal.Location.X + pan_metal.Width + 40, pan_metal.Location.Y);
            var woodLabels = new List<Label> { o_wood_to, o_wood_tw, o_wood_tt, label_o_wood_to_price, label_o_wood_tw_price, label_o_wood_tt_price, label_wood_total };
            var clothLabels = new List<Label> { o_cloth_to, label_o_cloth_to_price, o_cloth_tw, label_o_cloth_tw_price, o_cloth_tt, label_o_cloth_tt_price, label_cloth_total };
            var metalLabels = new List<Label> { o_metal_to, o_metal_tt, o_craft_iron, o_craft_steel, o_metal_ao, o_metal_at, o_iron_price, o_platinum_price, label_o_metal_ao_price, label_o_metal_at_price, label_metal_total };
            var leatherLabels = new List<Label> { o_leather_to, o_leather_tw, o_leather_tt, label_o_leather_to_price, label_o_leather_tw_price, label_o_leather_tt_price, label_leather_total };
            var woodBoxes = new List<TextBox> { i_wood_asc, i_wood_to, i_wood_toc, i_wood_tw, i_wood_twc, i_wood_tt, i_wood_ttc };
            var clothBoxes = new List<TextBox> { i_cloth_asc, i_cloth_to, i_cloth_toc, i_cloth_tw, i_cloth_twc, i_cloth_tt, i_cloth_ttc };
            var metalBoxes = new List<TextBox> { i_metal_asc, i_metal_to, i_metal_toc, i_metal_twc, i_metal_tt, i_metal_ttc, i_metal_ao, i_metal_at };
            var leatherBoxes = new List<TextBox> { i_leather_asc, i_leather_to, i_leather_toc, i_leather_tw, i_leather_twc, i_leather_tt, i_leather_ttc };
            SetLabels();
            _woodDict.Keys.ToList().ForEach(s =>
            {
                pan_wood.Controls.Add(s);
            });
            woodBoxes.ForEach(s =>
            {
                pan_wood.Controls.Add(s);
            });
            woodLabels.ForEach(s =>
            {
                pan_wood.Controls.Add(s);
            });
            _clothDict.Keys.ToList().ForEach(s =>
            {
                pan_cloth.Controls.Add(s);
            });
            clothBoxes.ForEach(s =>
            {
                pan_cloth.Controls.Add(s);
            });
            clothLabels.ForEach(s =>
            {
                pan_cloth.Controls.Add(s);
            });
            _metalDict.Keys.ToList().ForEach(s =>
            {
                pan_metal.Controls.Add(s);
            });
            metalBoxes.ForEach(s =>
            {
                pan_metal.Controls.Add(s);
            });
            metalLabels.ForEach(s =>
            {
                pan_metal.Controls.Add(s);
            });
            _leatherDict.Keys.ToList().ForEach(s =>
            {
                pan_leather.Controls.Add(s);
            });
            leatherBoxes.ForEach(s =>
            {
                pan_leather.Controls.Add(s);
            });
            leatherLabels.ForEach(s =>
            {
                pan_leather.Controls.Add(s);
            });
            pan_metal.Controls.Add(label_craft);

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

            button_save.Location = new Point(0, 10 + pan_wood.Height);
            button_load.Location = new Point(button_save.Location.X + button_save.Width, 10 + pan_wood.Height);
            button_reset.Location = new Point(button_load.Location.X + button_load.Width, 10 + pan_wood.Height);
            button_calc.Location = new Point(button_save.Location.X, 20 + button_save.Height + pan_wood.Height);
            button_calc.Width = button_load.Width + button_save.Width + button_reset.Width;
        }

        private void i_cloth_asc_TextChanged(object sender, EventArgs e)
        {
            OnChange(pan_cloth);
        }

        private void i_leather_asc_TextChanged(object sender, EventArgs e)
        {
            OnChange(pan_leather);
        }

        private void i_metal_asc_TextChanged(object sender, EventArgs e)
        {
            OnChange(pan_metal);
        }

        private void i_wood_asc_TextChanged(object sender, EventArgs e)
        {
            OnChange(pan_wood);
        }

        private static void Minus(Control textbox)
        {
            int calc;
            int.TryParse(textbox.Text, out calc);
            if (calc <= 0)
            {
                return;
            }
            calc -= 1;
            textbox.Text = calc.ToString();
        }

        private static void OnChange(Control p)
        {
            foreach (Control c in p.Controls)
            {
                c.Enabled = true;
            }
        }

        private static void Plus(Control textbox)
        {
            int calc;
            int.TryParse(textbox.Text, out calc);
            calc += 1;
            textbox.Text = calc.ToString();
        }

        private static void SetValue(int x, Control y)
        {
            if (x >= 250)
            {
                var s = Rounding.RoundDown(x / 250, 0);
                var rest = x - (s * 250);
                var text = s + " : " + rest;
                y.Text = text;
            }
            else
            {
                y.Text = x.ToString();
            }
        }
    }
}