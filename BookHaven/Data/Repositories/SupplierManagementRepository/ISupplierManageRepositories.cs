using BookHaven.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Data.Repositories.SupplierManagementRepository
{
    public interface ISupplierManageRepositories
    {
        void AddSupplier(Supplier supplier);
        void UpdateSupplier(Supplier supplier);
        List<Supplier> GetAllSuppliers();
        Supplier GetSupplierByName(string supplierName);
        void DeactivateSupplier(int supplierId); // For deactivating a supplier
        List<Supplier> GetActiveSuppliers(); // For fetching active suppliers
    }
}
