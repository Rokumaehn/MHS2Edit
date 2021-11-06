using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHS2Edit
{
    public class Item
    {
        const int ITEMBOX_OFFSET = 0x54;
        const int ITEMBOX_SIZE = 0xD8E;

        public ItemBox _parent;
        public uint _index;
        public byte[] _data;

        public Item(ItemBox parent, uint index, byte[] data)
        {
            _parent = parent;
            _index = index;
            _data = data;
        }

        public string Name
        {
            get
            {
                return ItemDef.Names.ContainsKey(this.Id) ? ItemDef.Names[this.Id] : Id.ToString();
            }
            set
            {
                    
            }
        }

        public uint Index
        {
            get { return this._index; }
            set { }
        }

        public ushort Id
        {
            get { return BitConverter.ToUInt16(_data, (int)(ITEMBOX_OFFSET + 8 * _index)); }
            set
            {
                var bt = BitConverter.GetBytes(value);
                Array.Copy(bt, 0, _data, ITEMBOX_OFFSET + 8 * _index, 2);
            }
        }

        public ulong Amount
        {
            get { return BitConverter.ToUInt64(_data, (int)(ITEMBOX_OFFSET + 8 * _index + 2)) & 0x0000FFFFFFFFFFFF; }
            set
            {
                var bt = BitConverter.GetBytes(value);
                Array.Copy(bt, 0, _data, ITEMBOX_OFFSET + 8 * _index + 2, 6);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
