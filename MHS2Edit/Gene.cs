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

        public uint Level
        {
            get { return _id >> 24 & 0x00000003; }
            set
            {
                if(value < 3)
                    _id = (_id & 0xFCFFFFFF) | (value << 24);
            }
        }

        private bool _isLocked;
        public bool IsLocked
        {
            get { return _id == 2 || (_id & 0x00010000) > 0; }
            set
            { 
                _isLocked = value;
                if(value)
                {
                    // lock
                    if (_id == 1) _id = 2;
                    else
                    {
                        _id = _id | 0x00010000;
                    }
                }
                else
                {
                    // unlock
                    if (_id == 2) _id = 1;
                    else
                    {
                        _id = _id & 0xFFFEFFFF;
                    }
                }
            }
        }

        public Gene(uint id, string name)
        {
            this._id = id;
            this._name = name;
        }

        public Gene(Gene g)
        {
            this._id = g._id;
            this._name = g._name;
            this.TypeAttack = g.TypeAttack;
            this.TypeElement = g.TypeElement;
            this.TypeSpecial = g.TypeSpecial;
        }

        public Gene(uint id, string name, AttackType attType, ElementType eleType, SpecialType spcType)
        {
            this._id = id;
            this._name = name;
            this._typeAttack = attType;
            this._typeElement = eleType;
            this._typeSpecial = spcType;
        }

        public static Gene CreateFromValue(uint val)
        {
            uint id = val & 0x0000FFFF;

            if (ALL.ContainsKey(id))
            {
                Gene g = new Gene(val, ALL[id].ToString());
                g.TypeAttack = ALL[id].TypeAttack;
                g.TypeElement = ALL[id].TypeElement;
                g.TypeSpecial = ALL[id].TypeSpecial;
                return g;
            }
            else
            {
                Gene g = new Gene(val, val.ToString());
                return g;
            }
        }

        public static Gene GetTemplate(uint val)
        {
            uint id = val & 0x0000FFFF;

            if (ALL.ContainsKey(id))
            {
                return ALL[id];
            }
            else
            {
                Gene g = new Gene(val, val.ToString());
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
            ,{ 6, new Gene(6, "<EMPTY Lv12>", AttackType.Undef, ElementType.None, SpecialType.None) }
            ,{ 7, new Gene(7, "<EMPTY Lv15>", AttackType.Undef, ElementType.None, SpecialType.None) }
            ,{ 8, new Gene(8, "<EMPTY Lv18>", AttackType.Undef, ElementType.None, SpecialType.None) }
            ,{ 9, new Gene(9, "<EMPTY Lv21>", AttackType.Undef, ElementType.None, SpecialType.None) }
            ,{ 10, new Gene(10, "<EMPTY Lv24>", AttackType.Undef, ElementType.None, SpecialType.None) }
            ,{ 11, new Gene(11, "<EMPTY Lv27>", AttackType.Undef, ElementType.None, SpecialType.None) }

            ,{ 28, new Gene(28, "Piercing Claws Gene (S)", AttackType.Tech, ElementType.None, SpecialType.None) }
            ,{ 32, new Gene(32, "Tackle Gene (S)", AttackType.Tech, ElementType.None, SpecialType.None) }
            ,{ 39, new Gene(39, "Smash Gene (XL)", AttackType.Power, ElementType.None, SpecialType.Platinum) }
            ,{ 40, new Gene(40, "Chomp Gene (S)", AttackType.Tech, ElementType.Lightning, SpecialType.None) }
            ,{ 41, new Gene(41, "Chomp Gene (M)", AttackType.Power, ElementType.None, SpecialType.Silver) }
            ,{ 42, new Gene(42, "Chomp Gene (L)", AttackType.Power, ElementType.Fire, SpecialType.Gold) }
            ,{ 43, new Gene(43, "Chomp Gene (XL)", AttackType.None, ElementType.None, SpecialType.Platinum) }
            ,{ 44, new Gene(44, "Rock Gene (S)", AttackType.Power, ElementType.None, SpecialType.None) }
            ,{ 45, new Gene(45, "Rock Gene (M)", AttackType.Tech, ElementType.Fire, SpecialType.Silver) }
            ,{ 57, new Gene(57, "Breaking Gene (S)", AttackType.Tech, ElementType.None, SpecialType.None) }
            ,{ 61, new Gene(61, "Head Start Gene (S)", AttackType.None, ElementType.None, SpecialType.None) }
            ,{ 65, new Gene(65, "Onslaught Gene (S)", AttackType.Speed, ElementType.None, SpecialType.None) }
            ,{ 69, new Gene(69, "All-Out Gene (S)", AttackType.Speed, ElementType.None, SpecialType.None) }
            ,{ 70, new Gene(70, "All-Out Gene (M)", AttackType.Power, ElementType.None, SpecialType.Silver) }
            ,{ 87, new Gene(87, "Fireball Gene (M)", AttackType.Tech, ElementType.Fire, SpecialType.Silver) }
            ,{ 106, new Gene(106, "Freezing Gene (S)", AttackType.Tech, ElementType.Ice, SpecialType.None) }
            ,{ 107, new Gene(107, "Freezing Gene (M)", AttackType.Tech, ElementType.Ice, SpecialType.None) }
            ,{ 119, new Gene(119, "Poison Gene (S)", AttackType.Tech, ElementType.None, SpecialType.None) }
            ,{ 123, new Gene(123, "Poison Breath Gene (S)", AttackType.Tech, ElementType.None, SpecialType.None) }
            ,{ 176, new Gene(176, "Spikeshot Gene (S)", AttackType.None, ElementType.None, SpecialType.None) }
            ,{ 180, new Gene(180, "Toss Gene (S)", AttackType.Tech, ElementType.None, SpecialType.None) }
            ,{ 198, new Gene(198, "Iceland Gene (M)", AttackType.None, ElementType.Ice, SpecialType.None) }
            ,{ 206, new Gene(206, "Soothing Gene (S)", AttackType.None, ElementType.None, SpecialType.None) }
            ,{ 207, new Gene(207, "Soothing Gene (M)", AttackType.None, ElementType.None, SpecialType.Silver) }
            ,{ 208, new Gene(208, "Soothing Gene (L)", AttackType.None, ElementType.None, SpecialType.Gold) }
            ,{ 209, new Gene(209, "Soothing Gene (XL)", AttackType.None, ElementType.None, SpecialType.Platinum) }
            ,{ 210, new Gene(210, "Healing Gene (S)", AttackType.None, ElementType.None, SpecialType.None) }
            ,{ 211, new Gene(211, "Healing Gene (M)", AttackType.None, ElementType.None, SpecialType.Silver) }
            ,{ 212, new Gene(212, "Healing Gene (L)", AttackType.None, ElementType.None, SpecialType.Gold) }
            ,{ 213, new Gene(213, "Healing Gene (XL)", AttackType.None, ElementType.None, SpecialType.Platinum) }
            ,{ 214, new Gene(214, "Recovery Gene (S)", AttackType.None, ElementType.None, SpecialType.None) }
            ,{ 226, new Gene(226, "Guard Gene (S)", AttackType.None, ElementType.None, SpecialType.None) }
            ,{ 234, new Gene(234, "Critical Gene (S)", AttackType.None, ElementType.None, SpecialType.None) }
            ,{ 242, new Gene(242, "Bellow Gene (S)", AttackType.None, ElementType.None, SpecialType.None) }
            ,{ 251, new Gene(251, "Overpower Gene (S)", AttackType.None, ElementType.None, SpecialType.None) }
            ,{ 282, new Gene(282, "T Salt in the Wound Gene", AttackType.Tech, ElementType.None, SpecialType.Gold) }
            ,{ 299, new Gene(299, "Mud Splash Gene (S)", AttackType.None, ElementType.Water, SpecialType.None) }
            ,{ 300, new Gene(300, "Mud Splash Gene (M)", AttackType.Speed, ElementType.Water, SpecialType.Silver) }
            ,{ 344, new Gene(344, "Nargacuga Gene (M)", AttackType.Speed, ElementType.None, SpecialType.Silver) }
            ,{ 371, new Gene(371, "Anjanath Gene (S)", AttackType.None, ElementType.Fire, SpecialType.None) }
            ,{ 372, new Gene(372, "Anjanath Gene (M)", AttackType.Power, ElementType.Fire, SpecialType.Silver) }
            ,{ 380, new Gene(380, "Empowering Song (M)", AttackType.None, ElementType.None, SpecialType.Silver) }
            ,{ 384, new Gene(384, "Fortifying Song (M)", AttackType.None, ElementType.None, SpecialType.Silver) }
            ,{ 400, new Gene(400, "Critical Eye Gene (S)", AttackType.Speed, ElementType.Dragon, SpecialType.None) }
            ,{ 401, new Gene(401, "Critical Eye Gene (M)", AttackType.Speed, ElementType.Dragon, SpecialType.Silver) }
            ,{ 402, new Gene(402, "Critical Eye Gene (L)", AttackType.Speed, ElementType.Dragon, SpecialType.Gold) }
            ,{ 403, new Gene(403, "Critical Eye Gene (XL)", AttackType.Speed, ElementType.Dragon, SpecialType.Platinum) }
            ,{ 404, new Gene(404, "Evasion Up Gene (S)", AttackType.Speed, ElementType.Water, SpecialType.None) }
            ,{ 405, new Gene(405, "Evasion Up Gene (M)", AttackType.Speed, ElementType.Water, SpecialType.Silver) }
            ,{ 406, new Gene(406, "Evasion Up Gene (L)", AttackType.Speed, ElementType.Water, SpecialType.Gold) }
            ,{ 407, new Gene(407, "Evasion Up Gene (XL)", AttackType.Speed, ElementType.Water, SpecialType.Platinum) }
            ,{ 419, new Gene(419, "Might Gene (S)", AttackType.Power, ElementType.None, SpecialType.None) }
            ,{ 423, new Gene(423, "Fire+ Gene (S)", AttackType.Power, ElementType.Fire, SpecialType.None) }
            ,{ 435, new Gene(435, "Ice+ Gene (S)", AttackType.Power, ElementType.Ice, SpecialType.None) }
            ,{ 444, new Gene(444, "Iron Wall Gene (S)", AttackType.Tech, ElementType.None, SpecialType.None) }
            ,{ 445, new Gene(445, "Iron Wall Gene (M)", AttackType.Tech, ElementType.None, SpecialType.Silver) }
            ,{ 449, new Gene(449, "Fire Res Gene (M)", AttackType.Tech, ElementType.Fire, SpecialType.Silver) }
            ,{ 477, new Gene(477, "Salt in Wound+ Gene (S)", AttackType.None, ElementType.None, SpecialType.None) }
            ,{ 464, new Gene(464, "Dragon Res Gene (S)", AttackType.Tech, ElementType.Dragon, SpecialType.None) }
            ,{ 482, new Gene(482, "Warming Gene", AttackType.None, ElementType.Ice, SpecialType.None) }
            ,{ 487, new Gene(487, "Antivenom Gene (L)", AttackType.Tech, ElementType.None, SpecialType.Gold) }
            ,{ 489, new Gene(489, "Burnproof Gene (S)", AttackType.Power, ElementType.Fire, SpecialType.None) }
            ,{ 493, new Gene(493, "Antishock Gene (S)", AttackType.Speed, ElementType.Lightning, SpecialType.None) }
            ,{ 527, new Gene(527, "Soul Kinship Gene (M)", AttackType.None, ElementType.None, SpecialType.Silver) }
            ,{ 530, new Gene(530, "Harmony Gene (S)", AttackType.Tech, ElementType.Water, SpecialType.None) }
            ,{ 531, new Gene(531, "Harmony Gene (M)", AttackType.Tech, ElementType.Water, SpecialType.Silver) }
            ,{ 543, new Gene(543, "Merciless Gene (M)", AttackType.Power, ElementType.Dragon, SpecialType.Silver) }
            ,{ 555, new Gene(555, "Vicious Gene (S)", AttackType.Power, ElementType.Dragon, SpecialType.None) }
            ,{ 556, new Gene(556, "Vicious Gene (M)", AttackType.Power, ElementType.Dragon, SpecialType.Silver) }
            ,{ 567, new Gene(567, "Synchronize Gene (S)", AttackType.Tech, ElementType.Lightning, SpecialType.None) }
            ,{ 571, new Gene(571, "Bombardier Gene (S)", AttackType.Power, ElementType.Fire, SpecialType.None) }
            ,{ 572, new Gene(572, "Bombardier Gene (M)", AttackType.Power, ElementType.Fire, SpecialType.Silver) }
            ,{ 616, new Gene(616, "Critical Healing Gene (S)", AttackType.None, ElementType.Dragon, SpecialType.Silver) }





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
