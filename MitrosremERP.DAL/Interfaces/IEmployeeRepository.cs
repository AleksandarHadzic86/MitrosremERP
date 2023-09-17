﻿using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Aplication.Interfaces
{
    public interface IEmployeeRepository:IRepository<Zaposleni>
    {
        void Update(Zaposleni zaposleni);
    }
}
