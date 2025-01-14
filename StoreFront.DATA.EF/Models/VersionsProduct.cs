﻿using System;
using System.Collections.Generic;

namespace StoreFront.DATA.EF.Models
{
    public partial class VersionsProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string? Properties { get; set; }
        public string? Image { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public bool IsActive { get; set; }
        public string? Version { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual OrderProduct OrderProduct { get; set; } = null!;
    }
}
