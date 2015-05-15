using System.Collections.Generic;
using System.Windows.Forms;

namespace Asc_Mats_Form
{
    public abstract class material
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

        public List<int> wl = new List<int> { 0, 1, 2, 2, 3, 4, 4, 5, 6, 6, 7 };
    }

    internal class cloth : material
    {
        private static string[] words = new string[5] { "Bolt of ", " Scrap", "Wool", "Cotton", "Linen" };

        //private static int[] ids = new int[3] {19739, 19741, 19743 };
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
            int j = wl[i];
            return l.Text = labels[j];
        }
    }

    internal class leather : material
    {
        private static string[] words = new string[6] { " Leather ", "Thin", "Coarse", "Rugged", "Section", "Square" };

        //private static int[] ids = new int[3] {19728, 19730, 19731 };
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
            int j = wl[i];
            return l.Text = labels[j];
        }
    }

    internal class metal : material
    {
        private static string[] words = new string[5] { " Ingot", "Steel", " Ore", "Iron", "Lump of " };

        //private static int[] ids = new int[2] {19699, 19702 };
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

        private List<int> ml = new List<int> { 0, 1, 2, 2, 3, 4, 4, 5, 6, 6, 7, 7, 8 };

        public string setLabel(Label l, int i)
        {
            int j = ml[i];
            return l.Text = labels[j];
        }
    }

    internal class wood : material
    {
        private static string[] words = new string[7] { " Wood ", "Log", "Plank", "Soft", "Seasoned", "Hard", "Spirit" };
        private static int[] ids = new int[3] { 19726, 19727, 19724 };

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
            int j = wl[i];
            return l.Text = labels[j];
        }
    }
}