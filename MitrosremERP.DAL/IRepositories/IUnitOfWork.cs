using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Aplication.IRepositories
{
    public interface IUnitOfWork
    {
        IEmployeeRepository ZaposleniRepository { get; }
        IStepenStrucneSpremeRepository StepenStrucneSpremeRepository { get; }
        IPolRepository PolRepository { get; }
        Task SaveAsync();
    }
}
