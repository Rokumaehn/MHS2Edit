using System;
using System.Collections.Generic;

namespace MHS2Edit
{
    public class Monsters
    {
        const int MONSTER_OFFSET = 0x2D72C8;

        public byte[] _data;
        private List<Monster> _monsters;
        private List<Monster> _party;
        public List<Monster> MonsterList { get => _monsters; set => _monsters = value; }
        public List<Monster> PartyList { get => _party; set => _party = value; }

        public Monsters(byte[] fileData)
        {
            this._data = fileData;

            _monsters = new List<Monster>();
            _party = new List<Monster>();

            int off = MONSTER_OFFSET;
            for (int i=0; i < 40; i++)
            {
                var mon = new Monster(this, i, _data, off);
                if (mon.Name != "")
                    _monsters.Add(mon);

                UInt64 uVal = 0;
                while (uVal!= 0x7fFF)
                {
                    off++;
                    uVal = BitConverter.ToUInt64(_data, off);
                }
                off += 8;
            }

            foreach (var mon in _monsters)
            {
                if (mon.Position != 0)
                    _party.Add(mon);
            }
        }
    }
}
