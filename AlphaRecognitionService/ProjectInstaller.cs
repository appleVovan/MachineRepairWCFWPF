﻿using System.ComponentModel;
using System.Configuration.Install;

namespace MachineRepair
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }
    }
}
