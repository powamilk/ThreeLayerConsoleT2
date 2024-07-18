using System.Text;
using ThreeLayerConsoleT2.PL.UI;

namespace ThreeLayerConsoleT2.PL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            SanPhamUI sanPhamUI = new SanPhamUI();

            sanPhamUI.Menu();
        }
    }
}