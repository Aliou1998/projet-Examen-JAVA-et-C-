using GestionCommercial.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercial.dao
{
    public interface IDao<T>
    {
        int Insert(T obj  );

    }
}

