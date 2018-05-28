using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVV_SAMPLE01
{
    public class ItemViewModel
    {
        private readonly ScoreCollection items;

        public ItemViewModel()
        {
            this.items = new ScoreCollection();
        }

        public ScoreCollection Items
        {
            get { return this.items; }
        }
    }
}
