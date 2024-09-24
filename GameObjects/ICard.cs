using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InDeBanVanDeRing.GameObjects
{
    public interface ICard
    {
        string CardName { get; }
        string CardDescription { get; }
        void Play();
        void SetCardControl();
    }
}
