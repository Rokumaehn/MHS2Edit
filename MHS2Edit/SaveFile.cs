using System.Linq;
using System.Threading.Tasks;

namespace MHS2Edit
{
    public class SaveFile
    {
        public byte[] _data;

        public SaveFile(byte[] fileData)
        {
            this._data = fileData;
        }
    }
}
