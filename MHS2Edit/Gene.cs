using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHS2Edit
{
    public class Gene
    {
        private uint _id;
        public uint Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private bool _isLocked;
        public bool IsLocked
        {
            get { return _id == 2 || _name.StartsWith("<LOCK"); }
            set { _isLocked = value; }
        }

        public Gene(uint id, string name)
        {
            this._id = id;
            this._name = name;
        }

        public Gene(uint id, string name, AttackType attType, ElementType eleType, SpecialType spcType)
        {
            this._id = id;
            this._name = name;
            this._typeAttack = attType;
            this._typeElement = eleType;
            this._typeSpecial = spcType;
        }

        public static Gene GetById(uint id)
        {
            if (ALL.ContainsKey(id))
            {
                return ALL[id];
            }
            else if(ALL.ContainsKey(id & 0xFFFF))
            {
                Gene g = new Gene(id, "<LvLock> " + id.ToString());
                ALL.Add(id, g);
                return g;
            }
            else
            {
                Gene g = new Gene(id, id.ToString());
                ALL.Add(id, g);
                return g;
            }
        }

        public override string ToString()
        {
            return this.Name;
        }

        public string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set { }
        }


        public enum AttackType
        {
            Undef,
            None,
            Power,
            Speed,
            Tech,
            Rainbow
        }
        AttackType _typeAttack;
        public AttackType TypeAttack
        {
            get { return _typeAttack; }
            set { this._typeAttack = value; }
        }

        public enum ElementType
        {
            None,
            Fire,
            Water,
            Ice,
            Lightning,
            Dragon,
            Rainbow
        }
        ElementType _typeElement;
        public ElementType TypeElement
        {
            get { return _typeElement; }
            set { this._typeElement = value; }
        }

        public enum SpecialType
        {
            None,
            Silver,
            Gold,
            Platinum
        }
        SpecialType _typeSpecial;
        public SpecialType TypeSpecial
        {
            get { return _typeSpecial; }
            set { this._typeSpecial = value; }
        }

        public Bitmap Image
        {
            get
            {
                Bitmap bmp = null;

                switch (this.TypeAttack)
                {
                    case AttackType.Undef:
                        bmp = new Bitmap(64, 64, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                        break;
                    case AttackType.None:
                        bmp = new Bitmap(MHS2Edit.Properties.Resources.None);
                        break;
                    case AttackType.Power:
                        bmp = new Bitmap(MHS2Edit.Properties.Resources.Power);
                        break;
                    case AttackType.Speed:
                        bmp = new Bitmap(MHS2Edit.Properties.Resources.Speed);
                        break;
                    case AttackType.Tech:
                        bmp = new Bitmap(MHS2Edit.Properties.Resources.Tech);
                        break;
                    default:
                        break;
                }

                if(this.TypeElement!=ElementType.None)
                {
                    switch (this.TypeElement)
                    {
                        case ElementType.None:
                            break;
                        case ElementType.Fire:
                            BitmapAddHue(bmp, 180, -70, -70);
                            break;
                        case ElementType.Water:
                            BitmapAddHue(bmp, 0, 0, 100);
                            break;
                        case ElementType.Ice:
                            BitmapAddHue(bmp, -70, -70, 100);
                            break;
                        case ElementType.Lightning:
                            BitmapAddHue(bmp, 80, 80, -70);
                            break;
                        case ElementType.Dragon:
                            BitmapAddHue(bmp, 80, -70, 80);
                            break;
                        case ElementType.Rainbow:
                            break;
                        default:
                            break;
                    }
                }

                if(this.TypeSpecial!=SpecialType.None)
                {

                }

                return bmp;
            }
        }


        public static Dictionary<uint, Gene> ALL = new Dictionary<uint, Gene>
        {
            { 0, new Gene(0, "<N/A>", AttackType.Undef, ElementType.None, SpecialType.None) }
            ,{ 1, new Gene(1, "<EMPTY>", AttackType.Undef, ElementType.None, SpecialType.None) }
            ,{ 2, new Gene(2, "<LOCKED>", AttackType.Undef, ElementType.None, SpecialType.None) }
            ,{ 6, new Gene(2, "<EMPTY>", AttackType.Undef, ElementType.None, SpecialType.None) }
            ,{ 7, new Gene(2, "<EMPTY>", AttackType.Undef, ElementType.None, SpecialType.None) }
            ,{ 8, new Gene(2, "<EMPTY>", AttackType.Undef, ElementType.None, SpecialType.None) }
            ,{ 9, new Gene(2, "<EMPTY>", AttackType.Undef, ElementType.None, SpecialType.None) }

            ,{ 28, new Gene(28, "Piercing Claws Gene (S)", AttackType.Tech, ElementType.None, SpecialType.None) }
            ,{ 32, new Gene(32, "Tackle Gene (S)", AttackType.Tech, ElementType.None, SpecialType.None) }
            ,{ 39, new Gene(39, "Smash Gene (XL)", AttackType.Power, ElementType.None, SpecialType.Platinum) }
            ,{ 44, new Gene(44, "Rock Gene (S)", AttackType.Power, ElementType.None, SpecialType.Platinum) }
            ,{ 45, new Gene(45, "Rock Gene (M)", AttackType.Tech, ElementType.Fire, SpecialType.Silver) }
            ,{ 61, new Gene(61, "Head Start Gene (S)", AttackType.None, ElementType.None, SpecialType.None) }
            ,{ 65, new Gene(65, "Onslaught Gene (S)", AttackType.Speed, ElementType.None, SpecialType.None) }
            ,{ 87, new Gene(87, "Fireball Gene (M)", AttackType.Tech, ElementType.Fire, SpecialType.Silver) }
            ,{ 119, new Gene(119, "Poison Gene (S)", AttackType.Tech, ElementType.None, SpecialType.None) }
            ,{ 180, new Gene(180, "Toss Gene (S)", AttackType.Tech, ElementType.None, SpecialType.None) }
            ,{ 213, new Gene(213, "Healing Gene (XL)", AttackType.None, ElementType.None, SpecialType.Platinum) }
            ,{ 226, new Gene(226, "Guard Gene (S)", AttackType.None, ElementType.None, SpecialType.None) }
            ,{ 251, new Gene(251, "Overpower Gene (S)", AttackType.None, ElementType.None, SpecialType.None) }
            ,{ 282, new Gene(282, "T Salt in the Wound Gene", AttackType.Tech, ElementType.None, SpecialType.Gold) }
            ,{ 380, new Gene(380, "Empowering Song (M)", AttackType.None, ElementType.None, SpecialType.Silver) }
            ,{ 384, new Gene(384, "Fortifying Song (M)", AttackType.None, ElementType.None, SpecialType.Silver) }
            ,{ 401, new Gene(401, "Critical Eye Gene (M)", AttackType.Speed, ElementType.Dragon, SpecialType.Silver) }
            ,{ 423, new Gene(423, "Fire+ Gene (S)", AttackType.Power, ElementType.Fire, SpecialType.None) }
            ,{ 444, new Gene(444, "Iron Wall Gene (S)", AttackType.Tech, ElementType.None, SpecialType.None) }
            ,{ 445, new Gene(445, "Iron Wall Gene (M)", AttackType.Tech, ElementType.None, SpecialType.Silver) }
            ,{ 477, new Gene(477, "Salt in Wound+ Gene (S)", AttackType.None, ElementType.None, SpecialType.None) }
            ,{ 487, new Gene(487, "Antivenom Gene (L)", AttackType.Tech, ElementType.None, SpecialType.Gold) }
            ,{ 493, new Gene(493, "Antishock Gene (S)", AttackType.Speed, ElementType.Lightning, SpecialType.None) }
            ,{ 527, new Gene(527, "Soul Kinship Gene (M)", AttackType.None, ElementType.None, SpecialType.Silver) }
            ,{ 531, new Gene(531, "Harmony Gene (M)", AttackType.Tech, ElementType.Water, SpecialType.Silver) }
            ,{ 543, new Gene(543, "Merciless Gene (M)", AttackType.Power, ElementType.Dragon, SpecialType.Silver) }
            ,{ 556, new Gene(556, "Vicious Gene (M)", AttackType.Power, ElementType.Dragon, SpecialType.Silver) }
            ,{ 572, new Gene(572, "Bombardier Gene (M)", AttackType.Power, ElementType.Fire, SpecialType.Silver) }




            
            
            
            

            
            
            







            ,{ 65542, new Gene(65542, "<LvLock12><EMPTY>", AttackType.Undef, ElementType.None, SpecialType.None) } // Lv.12
            ,{ 65544, new Gene(65544, "<LvLock18><EMPTY>", AttackType.Undef, ElementType.None, SpecialType.None) } // Lv.18
        };

        private Bitmap MergedBitmaps(Bitmap bmp1, Bitmap bmp2)
        {
            Bitmap result = new Bitmap(Math.Max(bmp1.Width, bmp2.Width), Math.Max(bmp1.Height, bmp2.Height), System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp2, Point.Empty);
                g.DrawImage(bmp1, Point.Empty);
            }
            return result;
        }


        private static void BitmapAddHue(Bitmap image, int red, int green, int blue)
        {
            // update the alpha for each pixel of image 2
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color c = image.GetPixel(x, y);
                    Color d = Color.FromArgb(c.A
                        , c.R + red > 255 ? 255 : (c.R + red < 0 ? 0 : c.R + red)
                        , c.G + green > 255 ? 255 : (c.G + green < 0 ? 0 : c.G + green)
                        , c.B + blue > 255 ? 255 : (c.B + blue < 0 ? 0 : c.B + blue));
                    image.SetPixel(x, y, d);
                }
            }
        }

        private static Bitmap SimpleBlend(Bitmap image1, Bitmap image2, byte alpha)
        {
            // update the alpha for each pixel of image 2
            for (int x = 0; x < image2.Width; x++)
            {
                for (int y = 0; y < image2.Height; y++)
                {
                    image2.SetPixel(x, y, Color.FromArgb(alpha, image2.GetPixel(x, y)));
                }
            }
            for (int x = 0; x < image1.Width; x++)
            {
                for (int y = 0; y < image1.Height; y++)
                {
                    image1.SetPixel(x, y, Color.FromArgb(alpha, image1.GetPixel(x, y)));
                }
            }

            Bitmap result = new Bitmap(Math.Max(image1.Width, image2.Width), Math.Max(image1.Height, image2.Height), System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.CompositingMode = CompositingMode.SourceOver;
                g.CompositingQuality = CompositingQuality.HighQuality;

                g.DrawImageUnscaled(image1, 0, 0);
                g.DrawImageUnscaled(image2, 0, 0);
            }

            return result;
        }
    }
}
