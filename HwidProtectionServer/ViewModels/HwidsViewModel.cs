﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HwidProtectionServer.Models;

namespace HwidProtectionServer.ViewModels
{
    public class HwidsViewModel : BaseViewModel
    {
        public IEnumerable<HwidInfo> Hwids { get; set; }
    }
}
