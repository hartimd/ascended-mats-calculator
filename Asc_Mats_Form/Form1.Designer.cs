using System.Windows.Forms;
using System.Drawing;

namespace Asc_Mats_Form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pan_wood = new Panel();
            this.pan_cloth = new Panel();
            this.pan_metal = new Panel();
            this.pan_leather = new Panel();
            this.label_title_leather = new Label();
            this.label_title_metal = new Label();
            this.label_title_cloth = new Label();
            this.label_title_wood = new Label();
            this.label_storage = new Label();
            this.label_i_wood_asc = new Label();
            this.label_i_wood_to = new Label();
            this.label_i_wood_toc = new Label();
            this.label_i_wood_tw = new Label();
            this.label_i_wood_tt = new Label();
            this.label_i_wood_twc = new Label();
            this.label_i_wood_ttc = new Label();
            this.i_wood_asc = new TextBox();
            this.i_wood_to = new TextBox();
            this.i_wood_toc = new TextBox();
            this.i_wood_tw = new TextBox();
            this.i_wood_tt = new TextBox();
            this.i_wood_twc = new TextBox();
            this.i_wood_ttc = new TextBox();
            this.o_platinum_price = new Label();
            this.o_metal_tt = new Label();
            this.i_cloth_ttc = new TextBox();
            this.label_i_cloth_ttc = new Label();
            this.i_cloth_twc = new TextBox();
            this.label_i_cloth_twc = new Label();
            this.i_cloth_tt = new TextBox();
            this.label_i_cloth_tt = new Label();
            this.i_cloth_tw = new TextBox();
            this.label_i_cloth_tw = new Label();
            this.i_cloth_toc = new TextBox();
            this.label_i_cloth_toc = new Label();
            this.i_cloth_to = new TextBox();
            this.label_i_cloth_to = new Label();
            this.label_i_cloth_asc = new Label();
            this.i_metal_at = new TextBox();
            this.label_i_metal_at = new Label();
            this.i_metal_twc = new TextBox();
            this.label_i_metal_twc = new Label();
            this.i_metal_tt = new TextBox();
            this.label_i_metal_tt = new Label();
            this.i_metal_ao = new TextBox();
            this.label_i_metal_ao = new Label();
            this.i_metal_toc = new TextBox();
            this.label_i_metal_toc = new Label();
            this.i_metal_to = new TextBox();
            this.label_i_metal_to = new Label();
            this.i_metal_asc = new TextBox();
            this.label_i_metal_asc = new Label();
            this.i_leather_ttc = new TextBox();
            this.label_i_leather_ttc = new Label();
            this.i_leather_twc = new TextBox();
            this.label_i_leather_twc = new Label();
            this.i_leather_tt = new TextBox();
            this.label_i_leather_tt = new Label();
            this.i_leather_tw = new TextBox();
            this.label_i_leather_tw = new Label();
            this.i_leather_toc = new TextBox();
            this.label_i_leather_toc = new Label();
            this.i_leather_to = new TextBox();
            this.label_i_leather_to = new Label();
            this.i_leather_asc = new TextBox();
            this.label_i_leather_asc = new Label();
            this.label_o_wood_to = new Label();
            this.o_wood_to = new Label();
            this.o_wood_tt = new Label();
            this.label_o_wood_tt = new Label();
            this.o_wood_tw = new Label();
            this.label_o_wood_tw = new Label();
            this.o_cloth_tw = new Label();
            this.label_o_cloth_tw = new Label();
            this.o_cloth_tt = new Label();
            this.label_o_cloth_tt = new Label();
            this.o_cloth_to = new Label();
            this.label_o_cloth_to = new Label();
            this.o_leather_tw = new Label();
            this.label_o_leather_tw = new Label();
            this.o_leather_tt = new Label();
            this.label_o_leather_tt = new Label();
            this.o_leather_to = new Label();
            this.label_o_leather_to = new Label();
            this.o_metal_ao = new Label();
            this.label_o_metal_ao = new Label();
            this.label_o_metal_tt = new Label();
            this.o_metal_to = new Label();
            this.label_o_metal_to = new Label();
            this.o_metal_at = new Label();
            this.label_o_metal_at = new Label();
            this.o_craft_iron = new Label();
            this.label_craft_iron = new Label();
            this.o_craft_steel = new Label();
            this.label_craft_steel = new Label();
            this.label_craft = new Label();
            this.label_needed = new Label();
            this.button_calc = new Button();
            this.button_reset = new Button();
            this.button_save = new Button();
            this.button_load = new Button();
            this.i_metal_ttc = new TextBox();
            this.label_i_metal_ttc = new Label();
            this.saveFileDialog1 = new SaveFileDialog();
            this.openFileDialog1 = new OpenFileDialog();
            this.but_pl_wood = new Button();
            this.but_min_wood = new Button();
            this.but_min_cloth = new Button();
            this.but_pl_cloth = new Button();
            this.but_min_metal = new Button();
            this.but_pl_metal = new Button();
            this.but_min_leather = new Button();
            this.but_pl_leather = new Button();
            this.i_cloth_asc = new TextBox();
            this.o_iron_price = new Label();
            this.label_o_wood_to_price = new Label();
            this.label_o_wood_tw_price = new Label();
            this.label_o_wood_tt_price = new Label();
            this.label_wood_total = new Label();
            this.label_o_cloth_to_price = new Label();
            this.label_o_cloth_tw_price = new Label();
            this.label_o_cloth_tt_price = new Label();
            this.label_cloth_total = new Label();
            this.label_o_leather_to_price = new Label();
            this.label_o_leather_tw_price = new Label();
            this.label_o_leather_tt_price = new Label();
            this.label_leather_total = new Label();
            this.label_o_metal_ao_price = new Label();
            this.label_o_metal_at_price = new Label();
            this.label_metal_total = new Label();

            this.SuspendLayout();
            // 
            // button_calc
            // 
            this.button_calc.Height = 48;
            this.button_calc.Text = "Calc";
            this.button_calc.Click += new System.EventHandler(this.button_calc_Click);
            // 
            // button_reset
            // 
            this.button_reset.Text = "Reset";
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_save
            // 
            this.button_save.Text = "Save";
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_load
            // 
            this.button_load.Text = "Load";
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "asc_mats";
            this.saveFileDialog1.Filter = "Text file (*.txt)|*.txt";
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "asc_mats";
            this.openFileDialog1.Filter = "Text file (*.txt)|*.txt";
            // 
            // Form1
            // 
            //this.ClientSize = new Size(851, 375);
            this.Controls.Add(this.o_platinum_price);
            this.Controls.Add(this.o_iron_price);
            this.Controls.Add(this.but_min_leather);
            this.Controls.Add(this.but_pl_leather);
            this.Controls.Add(this.but_min_metal);
            this.Controls.Add(this.but_pl_metal);
            this.Controls.Add(this.but_min_cloth);
            this.Controls.Add(this.but_pl_cloth);
            this.Controls.Add(this.but_min_wood);
            this.Controls.Add(this.but_pl_wood);
            this.Controls.Add(this.i_metal_ttc);
            this.Controls.Add(this.label_i_metal_ttc);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_calc);
            this.Controls.Add(this.label_needed);
            this.Controls.Add(this.label_craft);
            this.Controls.Add(this.o_craft_steel);
            this.Controls.Add(this.label_craft_steel);
            this.Controls.Add(this.o_craft_iron);
            this.Controls.Add(this.label_craft_iron);
            this.Controls.Add(this.o_metal_at);
            this.Controls.Add(this.label_o_metal_at);
            this.Controls.Add(this.o_metal_ao);
            this.Controls.Add(this.label_o_metal_ao);
            this.Controls.Add(this.o_metal_tt);
            this.Controls.Add(this.label_o_metal_tt);
            this.Controls.Add(this.o_metal_to);
            this.Controls.Add(this.label_o_metal_to);
            this.Controls.Add(this.o_leather_tw);
            this.Controls.Add(this.label_o_leather_tw);
            this.Controls.Add(this.o_leather_tt);
            this.Controls.Add(this.label_o_leather_tt);
            this.Controls.Add(this.o_leather_to);
            this.Controls.Add(this.label_o_leather_to);
            this.Controls.Add(this.o_cloth_tw);
            this.Controls.Add(this.label_o_cloth_tw);
            this.Controls.Add(this.o_cloth_tt);
            this.Controls.Add(this.label_o_cloth_tt);
            this.Controls.Add(this.o_cloth_to);
            this.Controls.Add(this.label_o_cloth_to);
            this.Controls.Add(this.o_wood_tw);
            this.Controls.Add(this.label_o_wood_tw);
            this.Controls.Add(this.o_wood_tt);
            this.Controls.Add(this.label_o_wood_tt);
            this.Controls.Add(this.o_wood_to);
            this.Controls.Add(this.label_o_wood_to);
            this.Controls.Add(this.i_leather_ttc);
            this.Controls.Add(this.label_i_leather_ttc);
            this.Controls.Add(this.i_leather_twc);
            this.Controls.Add(this.label_i_leather_twc);
            this.Controls.Add(this.i_leather_tt);
            this.Controls.Add(this.label_i_leather_tt);
            this.Controls.Add(this.i_leather_tw);
            this.Controls.Add(this.label_i_leather_tw);
            this.Controls.Add(this.i_leather_toc);
            this.Controls.Add(this.label_i_leather_toc);
            this.Controls.Add(this.i_leather_to);
            this.Controls.Add(this.label_i_leather_to);
            this.Controls.Add(this.i_leather_asc);
            this.Controls.Add(this.label_i_leather_asc);
            this.Controls.Add(this.i_metal_at);
            this.Controls.Add(this.label_i_metal_at);
            this.Controls.Add(this.i_metal_twc);
            this.Controls.Add(this.label_i_metal_twc);
            this.Controls.Add(this.i_metal_tt);
            this.Controls.Add(this.label_i_metal_tt);
            this.Controls.Add(this.i_metal_ao);
            this.Controls.Add(this.label_i_metal_ao);
            this.Controls.Add(this.i_metal_toc);
            this.Controls.Add(this.label_i_metal_toc);
            this.Controls.Add(this.i_metal_to);
            this.Controls.Add(this.label_i_metal_to);
            this.Controls.Add(this.i_metal_asc);
            this.Controls.Add(this.label_i_metal_asc);
            this.Controls.Add(this.i_cloth_ttc);
            this.Controls.Add(this.label_i_cloth_ttc);
            this.Controls.Add(this.i_cloth_twc);
            this.Controls.Add(this.label_i_cloth_twc);
            this.Controls.Add(this.i_cloth_tt);
            this.Controls.Add(this.label_i_cloth_tt);
            this.Controls.Add(this.i_cloth_tw);
            this.Controls.Add(this.label_i_cloth_tw);
            this.Controls.Add(this.i_cloth_toc);
            this.Controls.Add(this.label_i_cloth_toc);
            this.Controls.Add(this.i_cloth_to);
            this.Controls.Add(this.label_i_cloth_to);
            this.Controls.Add(this.i_cloth_asc);
            this.Controls.Add(this.label_i_cloth_asc);
            this.Controls.Add(this.label_title_wood);
            this.Controls.Add(this.label_title_cloth);
            this.Controls.Add(this.label_title_metal);
            this.Controls.Add(this.label_title_leather);
            this.Controls.Add(this.label_storage);
            this.Controls.Add(this.i_wood_ttc);
            this.Controls.Add(this.label_i_wood_ttc);
            this.Controls.Add(this.i_wood_twc);
            this.Controls.Add(this.label_i_wood_twc);
            this.Controls.Add(this.i_wood_tt);
            this.Controls.Add(this.label_i_wood_tt);
            this.Controls.Add(this.i_wood_tw);
            this.Controls.Add(this.label_i_wood_tw);
            this.Controls.Add(this.i_wood_toc);
            this.Controls.Add(this.label_i_wood_toc);
            this.Controls.Add(this.i_wood_to);
            this.Controls.Add(this.label_i_wood_to);
            this.Controls.Add(this.i_wood_asc);
            this.Controls.Add(this.label_i_wood_asc);
            this.Controls.Add(this.label_o_wood_to_price);
            this.Controls.Add(this.label_o_wood_tw_price);
            this.Controls.Add(this.label_o_wood_tt_price);
            this.Controls.Add(this.label_wood_total);
            this.Controls.Add(this.label_o_cloth_to_price);
            this.Controls.Add(this.label_o_cloth_tw_price);
            this.Controls.Add(this.label_o_cloth_tt_price);
            this.Controls.Add(this.label_cloth_total);
            this.Controls.Add(this.label_o_leather_to_price);
            this.Controls.Add(this.label_o_leather_tw_price);
            this.Controls.Add(this.label_o_leather_tt_price);
            this.Controls.Add(this.label_leather_total);
            this.Controls.Add(this.label_o_metal_ao_price);
            this.Controls.Add(this.label_o_metal_at_price);
            this.Controls.Add(this.label_metal_total);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Smoke\'s Ascended Mats Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }
        private Panel pan_wood;
        private Panel pan_cloth;
        private Panel pan_metal;
        private Panel pan_leather;
        private Label label_title_leather;
        private Label label_title_metal;
        private Label label_title_cloth;
        private Label label_title_wood;
        private Label label_storage;
        private Label label_i_wood_asc;
        private Label label_i_wood_to;
        private Label label_i_wood_toc;
        private Label label_i_wood_tw;
        private Label label_i_wood_tt;
        private Label label_i_wood_twc;
        private Label label_i_wood_ttc;
        private TextBox i_wood_asc;
        private TextBox i_wood_to;
        private TextBox i_wood_toc;
        private TextBox i_wood_tw;
        private TextBox i_wood_tt;
        private TextBox i_wood_twc;
        private TextBox i_wood_ttc;
        private TextBox i_cloth_ttc;
        private Label label_i_cloth_ttc;
        private TextBox i_cloth_twc;
        private Label label_i_cloth_twc;
        private TextBox i_cloth_tt;
        private Label label_i_cloth_tt;
        private TextBox i_cloth_tw;
        private Label label_i_cloth_tw;
        private TextBox i_cloth_toc;
        private Label label_i_cloth_toc;
        private TextBox i_cloth_to;
        private Label label_i_cloth_to;
        private Label label_i_cloth_asc;
        private TextBox i_metal_at;
        private Label label_i_metal_at;
        private TextBox i_metal_twc;
        private Label label_i_metal_twc;
        private TextBox i_metal_tt;
        private Label label_i_metal_tt;
        private TextBox i_metal_ao;
        private Label label_i_metal_ao;
        private TextBox i_metal_toc;
        private Label label_i_metal_toc;
        private TextBox i_metal_to;
        private Label label_i_metal_to;
        private TextBox i_metal_asc;
        private Label label_i_metal_asc;
        private TextBox i_leather_ttc;
        private Label label_i_leather_ttc;
        private TextBox i_leather_twc;
        private Label label_i_leather_twc;
        private TextBox i_leather_tt;
        private Label label_i_leather_tt;
        private TextBox i_leather_tw;
        private Label label_i_leather_tw;
        private TextBox i_leather_toc;
        private Label label_i_leather_toc;
        private TextBox i_leather_to;
        private Label label_i_leather_to;
        private TextBox i_leather_asc;
        private Label label_i_leather_asc;
        private Label label_o_wood_to;
        private Label o_wood_to;
        private Label o_wood_tt;
        private Label label_o_wood_tt;
        private Label o_wood_tw;
        private Label label_o_wood_tw;
        private Label o_cloth_tw;
        private Label label_o_cloth_tw;
        private Label o_cloth_tt;
        private Label label_o_cloth_tt;
        private Label o_cloth_to;
        private Label label_o_cloth_to;
        private Label o_leather_tw;
        private Label label_o_leather_tw;
        private Label o_leather_tt;
        private Label label_o_leather_tt;
        private Label o_leather_to;
        private Label label_o_leather_to;
        private Label o_metal_ao;
        private Label label_o_metal_ao;
        private Label o_metal_tt;
        private Label label_o_metal_tt;
        private Label o_metal_to;
        private Label label_o_metal_to;
        private Label o_metal_at;
        private Label label_o_metal_at;
        private Label o_craft_iron;
        private Label label_craft_iron;
        private Label o_craft_steel;
        private Label label_craft_steel;
        private Label label_craft;
        private Label label_needed;
        private Button button_calc;
        private Button button_reset;
        private Button button_save;
        private Button button_load;
        private TextBox i_metal_ttc;
        private Label label_i_metal_ttc;
        private Button but_pl_wood;
        private Button but_min_wood;
        private Button but_min_cloth;
        private Button but_pl_cloth;
        private Button but_min_metal;
        private Button but_pl_metal;
        private Button but_min_leather;
        private Button but_pl_leather;
        private TextBox i_cloth_asc;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Label o_iron_price;
        private Label label_o_metal_ao_price;
        private Label o_platinum_price;
        private Label label_o_metal_at_price;
        private Label label_metal_total;
        private Label label_o_wood_to_price;
        private Label label_o_wood_tw_price;
        private Label label_o_wood_tt_price;
        private Label label_wood_total;
        private Label label_o_cloth_to_price;
        private Label label_o_cloth_tw_price;
        private Label label_o_cloth_tt_price;
        private Label label_cloth_total;
        private Label label_o_leather_to_price;
        private Label label_o_leather_tw_price;
        private Label label_o_leather_tt_price;
        private Label label_leather_total;
    }
}

