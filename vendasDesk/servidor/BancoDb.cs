using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;

namespace vendasDesk.servidor
{
    internal class BancoDb
    {
        private static ISessionFactory _sessionFactory = null;
        private const String HOST = "localhost";
        private const String USER = "root";
        private const String PASSWORD = "123456";
        private const String DB = "vendasDesk";
        private const int PORT = 3306;

        private static ISessionFactory SessionFactory()
        {
            try
            {
                if (_sessionFactory == null)
                {
                    //database configs
                    return Fluently.Configure()
                        .Database(MySQLConfiguration.Standard
                        .ConnectionString(x => x
                            .Server(HOST)
                            .Port(PORT)
                            .Username(USER)
                            .Password(PASSWORD)
                            .Database(DB))
                         .ShowSql()
                          .FormatSql()
                          .FormatSql()
                        )

                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Usuario>())
                         .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true))
                        .BuildSessionFactory();
                }
                return _sessionFactory;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }

        public static ISession OpenSession()
        {
            return SessionFactory().OpenSession();
        }
    }
}
