using System;

namespace Sample.Models.Interfaces
{
    public interface IDTO<TDTO, TEntity>
    {
        TEntity MapTo(TDTO dto);
        TDTO MapFrom(TEntity entity);
    }
}