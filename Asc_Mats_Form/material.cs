using System.Windows.Forms;

namespace Asc_Mats_Form
{
    internal class material
    {
        private string[] labels = new string[] { };

        public int Length
        {
            get
            {
                return labels.Length;
            }
        }

        public string this[int index]
        {
            get
            {
                return labels[index];
            }
            set
            {
                labels[index] = value;
            }
        }
    }

    internal class cloth : material
    {
        private static string[] words = new string[5] { "Bolt of ", " Scrap", "Wool", "Cotton", "Linen" };

        private string[] labels = new string[8] {
                                                words[0] + "Damask",
                                                "Spool of Silk",
                                                words[2] + words[1],
                                                words[0] + words[2],
                                                words[3] + words[1],
                                                words[0] + words[3],
                                                words[4] + words[1],
                                                words[0] + words[4]
                                            };

        public string setLabel(Label l, int i)
        {
            return l.Text = labels[i];
        }
    }

    internal class leather : material
    {
        private static string[] words = new string[6] { " Leather ", "Thin", "Coarse", "Rugged", "Section", "Square" };

        private string[] labels = new string[8] {
                                                "Elonian" + words[0] + words[5],
                                                "Spool of Cord",
                                                words[1] + words[0] + words[4],
                                                words[1] + words[0] + words[5],
                                                words[2] + words[0] + words[4],
                                                words[2] + words[0] + words[5],
                                                words[3] + words[0] + words[4],
                                                words[3] + words[0] + words[5]
                                            };

        public string setLabel(Label l, int i)
        {
            return l.Text = labels[i];
        }
    }

    internal class metal : material
    {
        private static string[] words = new string[5] { " Ingot", "Steel", " Ore", "Iron", "Lump of " };

        private string[] labels = new string[9]{
                                                "Deldrimor " + words[1] + words[0],
                                                words[4] + "Mithrillium",
                                                words[3] + words[2],
                                                words[3] + words[0],
                                                words[4] + "Coal",
                                                words[1] + words[0],
                                                "Platinum" + words[2],
                                                words[4] + "Primordium",
                                                "Dark" + words[1] + words[0]
                                            };

        public string setLabel(Label l, int i)
        {
            return l.Text = labels[i];
        }
    }

    internal class wood : material
    {
        private static string[] words = new string[7] { " Wood ", "Log", "Plank", "Soft", "Seasoned", "Hard", "Spirit" };

        private string[] labels = new string[8] {
                                                words[6] + words[0] + words[2],
                                                "Elder" + words[0] + words[6],
                                                words[3] + words[0] + words[1],
                                                words[3] + words[0] + words[2],
                                                words[4] + words[0] + words[1],
                                                words[4] + words[0] + words[2],
                                                words[5] + words[0] + words[1],
                                                words[5] + words[0] + words[2]
                                            };

        public string setLabel(Label l, int i)
        {
            return l.Text = labels[i];
        }
    }
}