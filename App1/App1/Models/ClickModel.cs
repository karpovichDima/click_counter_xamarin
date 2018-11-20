using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
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
