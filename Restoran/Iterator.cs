using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran
{
    public interface Iterator
    {
        bool hasNext();
        MenuItem next();
    }
}
