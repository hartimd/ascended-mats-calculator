using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AscendedMaterialsForm
{
    public class Material
    {
        protected int v0, v1, v2, v3, v4, v5, v6;

        public Material(int a = 0, int b = 0, int c = 0, int d = 0, int e = 0, int f = 0, int g = 0)
        {
            v0 = a;
            v1 = b;
            v2 = c;
            v3 = d;
            v4 = e;
            v5 = f;
            v6 = g;
        }

        public int checkValue(int i)
        {
            if (i <= 0)
            {
                return i = 0;
            }
            else
            {
                return i;
            }
        }

        public virtual int to()
        {
            return checkValue((v0 * 2 * 20) - v1 - (v2 * 2));
        }

        public virtual int tw()
        {
            return checkValue((v0 * 2 * 10) - v3 - (v4 * 2));
        }

        public virtual int tt()
        {
            return checkValue((v0 * 2 * 20) - v5 - (v6 * 2));
        }
    }

    internal class Cloth : Material
    {
        public Cloth(int a = 0, int b = 0, int c = 0, int d = 0, int e = 0, int f = 0, int g = 0)
            : base(a, b, c, d, e, f, g)
        {
        }
    }

    internal class Leather : Material
    {
        public Leather(int a = 0, int b = 0, int c = 0, int d = 0, int e = 0, int f = 0, int g = 0)
            : base(a, b, c, d, e, f, g)
        {
        }
    }

    internal class Metal : Material
    {
        protected int v7;

        public Metal(int a = 0, int b = 0, int c = 0, int d = 0, int e = 0, int f = 0, int g = 0, int h = 0)
            : base(a, b, c, d, e, f, g)
        {
            v7 = h;
        }

        public virtual int ironingot()
        {
            return checkValue((v0 * 20) - v2);
        }

        public virtual int steelingot()
        {
            return checkValue((v0 * 10) - v3);
        }

        public override int to()
        {
            return checkValue((ironingot() * 3) + (steelingot() * 3) - v1);
        }

        public override int tw()
        {
            return to();
        }

        public override int tt()
        {
            return checkValue((v0 * 2 * 20) - v5 - (v6 * 2));
        }

        public virtual int coal()
        {
            return checkValue(10 * (((v0 * 10) - v6 - (v3) + 9) / 10));
        }

        public virtual int primordium()
        {
            return checkValue(10 * (((v0 * 20) - v7 - (v5) + 9) / 10));
        }
    }

    internal class Wood : Material
    {
        public Wood(int a = 0, int b = 0, int c = 0, int d = 0, int e = 0, int f = 0, int g = 0)
            : base(a, b, c, d, e, f, g)
        {
        }

        public override int to()
        {
            return checkValue((v0 * 4 * 20) - v1 - (v2 * 4));
        }

        public override int tw()
        {
            return checkValue((v0 * 3 * 10) - v3 - (v4 * 3));
        }

        public override int tt()
        {
            return checkValue((v0 * 3 * 20) - v5 - (v6 * 3));
        }
    }
}