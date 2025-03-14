using BookHaven.Business.Interfaces;
using BookHaven.Data.Models;
using BookHaven.Data.Repositories.SupplierManagementRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Business.Services
{
    public class SupplierManagementService : ISupplierManagementService
    {
        private readonly ISupplierManageRepositories _supplierRepository;

        public SupplierManagementService()
        {
            _supplierRepository = new SupplierManageRepository();
        }

      
        public void AddSupplier(Supplier supplier) => _supplierRepository.AddSupplier(supplier);
        public void UpdateSupplier(Supplier supplier) => _supplierRepository.UpdateSupplier(supplier);
        public List<Supplier> GetAllSuppliers() => _supplierRepository.GetAllSuppliers();
        public Supplier GetSupplierByName(string supplierName) => _supplierRepository.GetSupplierByName(supplierName);

        public void DeactivateSupplier(int supplierId)  
        {
            _supplierRepository.DeactivateSupplier(supplierId);
        }

        public List<Supplier> GetActiveSuppliers() 
        {
            return _supplierRepository.GetActiveSuppliers();
        }
    }
}
