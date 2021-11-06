using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHS2Edit
{
    public class ItemBox
    {
        public byte[] _data;
        private List<Item> _items;
        private List<Item> _itemsHealing;
        private List<Item> _itemsSupport;
        private List<Item> _itemsMaterials;
        private List<Item> _itemsFacilities;
        private List<Item> _itemsGrowth;
        private List<Item> _itemsKey;
        public List<Item> ItemList { get => _items; set => _items = value; }
        public List<Item> ItemListHealing { get => _itemsHealing; set => _itemsHealing = value; }
        public List<Item> ItemListSupport { get => _itemsSupport; set => _itemsSupport = value; }
        public List<Item> ItemListMaterials { get => _itemsMaterials; set => _itemsMaterials = value; }
        public List<Item> ItemListFacilities { get => _itemsFacilities; set => _itemsFacilities = value; }
        public List<Item> ItemListGrowth { get => _itemsGrowth; set => _itemsGrowth = value; }
        public List<Item> ItemListKey { get => _itemsKey; set => _itemsKey = value; }

        public ItemBox(byte[] fileData)
        {
            this._data = fileData;

            _items = new List<Item>();
            _itemsHealing = new List<Item>();
            _itemsSupport = new List<Item>();
            _itemsMaterials = new List<Item>();
            _itemsFacilities = new List<Item>();
            _itemsGrowth = new List<Item>();
            _itemsKey = new List<Item>();

            for (uint i = 0; i < (0x3E70/8); i++)
            {
                var item = new Item(this, i, _data);
                _items.Add(item);
            }

            foreach (var item in _items)
            {
                if (item.Id == 0)
                    continue;

                switch (item.Id)
                {
                    case 129:
                        _itemsMaterials.Add(item);
                        continue;
                        break;
                    case 433:
                    case 435:
                    case 436:
                    case 437:
                    case 438:
                    case 439:  
                    case 440:
                    case 441:
                    case 442:
                    case 443:
                    case 466:
                    case 478:
                    case 497:
                    case 499:
                    case 711:
                        _itemsFacilities.Add(item);
                        continue;
                        break;
                    case 176:
                    case 1486:
                        _itemsHealing.Add(item);
                        continue;
                        break;
                    case 146:
                        _itemsSupport.Add(item);
                        continue;
                        break;
                    case 182:
                    case 183:
                    case 1652:
                        _itemsKey.Add(item);
                        continue;
                        break;
                    default:
                        break;
                }

                if(item.Id < 46)
                    _itemsHealing.Add(item);
                else if (item.Id < 159)
                    _itemsSupport.Add(item);
                else if (item.Id <= 286)
                    _itemsGrowth.Add(item);
                else if (item.Id < 1225)
                    _itemsMaterials.Add(item);
                else if(item.Id >= 1225 && item.Id < 1527)
                    _itemsKey.Add(item);
                else if (item.Id >= 1527 && item.Id < 1740)
                    _itemsMaterials.Add(item);
                else if (item.Id >= 1740)
                    _itemsKey.Add(item);
            }
        }
    }
}
