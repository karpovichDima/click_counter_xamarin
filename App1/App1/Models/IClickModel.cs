using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    public interface IClickModel
    {
        void OnClick();

        void Reset();

        int Clicks { get;}
    }
}
