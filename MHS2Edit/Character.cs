using System;
using System.Text;

namespace MHS2Edit
{
    public class Character
    {
        const int CHARACTER_NAME = 0x2D2A98;
        const int CHARACTER_EXP = 0x40;
        const int CHARACTER_ZENNY = 0x48;

        public byte[] _data;

        public Character(byte[] data)
        {
            _data = data;
        }

        public string Name
        {
            get
            {
                byte[] bt = new byte[48];
                Array.Copy(_data, CHARACTER_NAME, bt, 0, 48);
                return Encoding.UTF8.GetString(bt).Split((char)0)[0];
            }
            set
            {
                var bt = Encoding.UTF8.GetBytes(value);
                Array.Copy(bt, 0, _data, CHARACTER_NAME, bt.Length < 48 ? bt.Length : 48);
            }
        }

        public uint Exp
        {
            get
            {
                return BitConverter.ToUInt32(_data, CHARACTER_EXP);
            }
            set
            {
                var bt = BitConverter.GetBytes(value);
                Array.Copy(bt, 0, _data, CHARACTER_EXP, 4);
            }
        }

        public uint Zenny
        {
            get
            {
                return BitConverter.ToUInt32(_data, CHARACTER_ZENNY);
            }
            set
            {
                var bt = BitConverter.GetBytes(value);
                Array.Copy(bt, 0, _data, CHARACTER_ZENNY, 4);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
