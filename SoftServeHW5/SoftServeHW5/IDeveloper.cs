using System;
using System.Collections.Generic;
using System.Text;

namespace SoftServeHW5
{
    public interface IDeveloper
    {
        public string Tool { get; set; }
        public void Create(List<string> developers);
        public void Destroy(List<string> developers);

        public void OutPut(List<string> developers);
    }
}
