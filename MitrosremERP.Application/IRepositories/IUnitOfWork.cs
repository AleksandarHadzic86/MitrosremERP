using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Application.IRepositories
{
    public interface IUnitOfWork
    {
        IEmployeeRepository ZaposleniRepository { get; }
        IStepenStrucneSpremeRepository StepenStrucneSpremeRepository { get; }
        IUgovoriRepository UgovoriRepository { get; }
        IBolovanjeRepository BolovanjeRepository { get; }
        IGodisnjiRepository GodisnjiRepository { get; }
        IDokumentiRepository DokumentiRepository { get; }
        Task SaveAsync();
    }
}
