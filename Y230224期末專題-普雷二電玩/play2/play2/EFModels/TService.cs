using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class TService
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Question { get; set; }
        public string? Answer { get; set; }
    }
}
