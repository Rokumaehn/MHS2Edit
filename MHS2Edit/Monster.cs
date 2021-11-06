using System;
using System.Text;

namespace MHS2Edit
{
    public class Monster
    {
        const int MONSTER_OFFSET = 0x2D72C8;
        const int MONSTER_SIZE = 0x19C;

        const int OFFSET_ID = 0x30;
        const int OFFSET_EXP = 0xBC;
        const int OFFSET_GENES = 0x14C;
        const int OFFSET_PARTY = 0x309778;

        public Monsters _parent;
        public int _index;
        public byte[] _data;
        public int _startOffset;

        public Monster(Monsters parent, int index, byte[] data, int offset)
        {
            _parent = parent;
            _index = index;
            _data = data;
            _startOffset = offset;
        }

        public string Name
        {
            get
            {
                byte[] bt = new byte[48];
                Array.Copy(_data, _startOffset, bt, 0, 48);
                return Encoding.UTF8.GetString(bt).Split((char)0)[0];
            }
            set
            {
                var bt = Encoding.UTF8.GetBytes(value);
                Array.Copy(bt, 0, _data, _startOffset, bt.Length < 48 ? bt.Length : 48);
            }
        }

        public uint Id
        {
            get
            {
                return BitConverter.ToUInt32(_data, _startOffset + OFFSET_ID);
            }
            set
            {
                //var bt = BitConverter.GetBytes(value);
                //Array.Copy(bt, 0, _data, _startOffset + OFFSET_ID, 4);
            }
        }

        public int Position
        {
            get
            {
                var id = this.Id;
                for (int i = 0; i < 5; i++)
                {
                    var u = BitConverter.ToUInt32(_data, OFFSET_PARTY + i*4);
                    if (u == id)
                        return i+1;
                }
                return 0;
            }
            set
            {
                //var bt = BitConverter.GetBytes(value);
                //Array.Copy(bt, 0, _data, _startOffset + OFFSET_ID, 4);
            }
        }

        public uint Exp
        {
            get
            {
                return BitConverter.ToUInt32(_data, _startOffset + OFFSET_EXP);
            }
            set
            {
                var bt = BitConverter.GetBytes(value);
                Array.Copy(bt, 0, _data, _startOffset + OFFSET_EXP, 4);
            }
        }

        public Gene[] Genes
        {
            get
            {
                Gene[] g = new Gene[9];
                for (int i = 0; i < 9; i++)
                {
                    g[i] = Gene.GetById( BitConverter.ToUInt32(_data, _startOffset + OFFSET_GENES + i*4) );
                }
                return g;
            }
            set
            {
                for (int i = 0; i < 9; i++)
                {
                    var bt = BitConverter.GetBytes(value[i].Id);
                    Array.Copy(bt, 0, _data, _startOffset + OFFSET_GENES + i * 4, 4);
                }
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
