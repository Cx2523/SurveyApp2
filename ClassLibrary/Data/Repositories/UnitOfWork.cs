//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ClassLibrary.Data.Repositories
//{
//    public class UnitOfWork : IDisposable
//    {
//        private Context _context = new Context();
//        private ClientRepository clientRepository;
//        private UserRepository userRepository;

//        public ClientRepository ClientRepository
//        {
//            get
//            {
//                return this.clientRepository ?? new ClientRepository(_context);
//            }
//        }

//        public UserRepository UserRepository
//        {
//            get
//            {
//                var repo = this.userRepository ?? new UserRepository(_context);
//                return repo;    
//            }
//        }

//        public void Save()
//        {
//            _context.SaveChanges();
//        }

//        private bool disposed = false;

//        protected virtual void Dispose(bool disposing)
//        {
//            if (!this.disposed)
//            {
//                if (disposing)
//                {
//                    _context.Dispose();
//                }
//            }
//            this.disposed = true;
//        }

//        public void Dispose()
//        {
//            Dispose(true);
//            GC.SuppressFinalize(this);
//        }
//    }
//}
