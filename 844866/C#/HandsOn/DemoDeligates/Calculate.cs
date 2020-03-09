using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDeligates
{
    public partial class Calculate : Component
    {
        public Calculate()
        {
            InitializeComponent();
        }

        public Calculate(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
