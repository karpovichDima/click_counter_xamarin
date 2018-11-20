using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using App1.Models;

namespace App1.UWP.Models
{
    class ClickModel : IClickModel
    {
        public void OnClick()
        {
            Clicks++;
        }

        public void Reset()
        {
            Clicks = 0;
        }

        public int Clicks { get; private set; }
    }
}