﻿using DigisoftPortal.Model.Models;
using DigisoftPortal.Model.Models.Response;
using DigisoftPortal.Model.Models.Shared;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digisoft.Portal.Model.ViewModels
{
    public class GetListUserLeave
    {
        public GetListUserLeave()
        {
            Pagination = new Pagination();
            LeavesRequest = new LeavesResponse();

        }
        public Pagination? Pagination { get; set; }
        public LeavesResponse? LeavesRequest { get; set; }
    }
}
