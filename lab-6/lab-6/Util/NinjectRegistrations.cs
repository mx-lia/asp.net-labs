using Ninject.Modules;
using Ninject.Web.Common;
//using dll_json;
using dll_sql;

namespace lab_6.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IRecordRepository>().To<RecordRepository>();
            //Bind<IRecordRepository>().To<RecordRepository>().InThreadScope();
            //Bind<IRecordRepository>().To<RecordRepository>().InRequestScope();
        }
    }
}