using Laboratory5.Interfaces;
using System.Diagnostics;

namespace Laboratory5
{
    public class Client
    {
        public void Render(IRenderer renderer)
        {
            var result = renderer.Serialize();
            Debug.WriteLine(result);
        }
    }
}
