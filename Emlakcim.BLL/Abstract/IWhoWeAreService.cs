using Emlakcim.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emlakcim.BLL.Abstract
{
    public interface IWhoWeAreService
    {
        WhoWeAre GetOne();
        void Update(WhoWeAre entity);
    }
}
