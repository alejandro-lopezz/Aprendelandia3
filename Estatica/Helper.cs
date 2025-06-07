using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estatica
{
    public static class Helper
    {
        public static void cargarImagen(PictureBox pbx, string url)
        {
            try
            {
                pbx.Load(url);
            }
            catch (Exception)
            {
                pbx.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
            }
        }
    }
}
