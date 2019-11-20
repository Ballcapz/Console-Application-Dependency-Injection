using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public interface IUser
    {
        string Name { get; set; }

        void TruncateName(string name);
    }
}
