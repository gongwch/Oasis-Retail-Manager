﻿using ORMWPFUI.Library.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ORMWPFUI.Library.API
{
    public interface ISaleEndPoint
    {
        Task PostSale(UISaleModel sale);
    }
}