using System;

namespace Modulos
{
    public interface IModulo
    {
        int ProvideModulo(int left, int right);
    }

    public class Modulo : IModulo
    {
        public int ProvideModulo(int left, int right)
        {
            return left % right;
        }
    }
}
