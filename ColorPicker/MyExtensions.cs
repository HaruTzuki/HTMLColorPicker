using System.Drawing;

namespace MyExtensions
{
    public static class extensions
    {
        public static string ToHTMLColor(this Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }
    }
}
