// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Data;
using System.Linq;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.NoMetadata.Informix
{
	public partial class TestDataDB : DataConnection
	{
		public TestDataDB()
		{
		}

		public TestDataDB(string configuration)
			: base(configuration)
		{
		}

		public TestDataDB(DataOptions<TestDataDB> options)
			: base(options.Options)
		{
		}

		public ITable<Alltype>           Alltypes            => this.GetTable<Alltype>();
		public ITable<Child>             Children            => this.GetTable<Child>();
		public ITable<Collatedtable>     Collatedtables      => this.GetTable<Collatedtable>();
		public ITable<Doctor>            Doctors             => this.GetTable<Doctor>();
		public ITable<Grandchild>        Grandchildren       => this.GetTable<Grandchild>();
		public ITable<Inheritancechild>  Inheritancechildren => this.GetTable<Inheritancechild>();
		public ITable<Inheritanceparent> Inheritanceparents  => this.GetTable<Inheritanceparent>();
		public ITable<Linqdatatype>      Linqdatatypes       => this.GetTable<Linqdatatype>();
		public ITable<Parent>            Parents             => this.GetTable<Parent>();
		public ITable<Patient>           Patients            => this.GetTable<Patient>();
		public ITable<Person>            People              => this.GetTable<Person>();
		public ITable<Testfkunique>      Testfkuniques       => this.GetTable<Testfkunique>();
		public ITable<Testidentity>      Testidentities      => this.GetTable<Testidentity>();
		public ITable<Testmerge1>        Testmerge1          => this.GetTable<Testmerge1>();
		public ITable<Testmerge2>        Testmerge2          => this.GetTable<Testmerge2>();
		public ITable<Testunique>        Testuniques         => this.GetTable<Testunique>();
		public ITable<Personview>        Personviews         => this.GetTable<Personview>();
	}

	public static partial class ExtensionMethods
	{
		#region Associations
		#region Doctor Associations
		/// <summary>
		/// FK_doctor_person
		/// </summary>
		public static Person Person(this Doctor obj, IDataContext db)
		{
			return db.GetTable<Person>().First(t => obj.Personid == t.Personid);
		}
		#endregion

		#region Person Associations
		/// <summary>
		/// FK_doctor_person backreference
		/// </summary>
		public static Doctor? Doctor(this Person obj, IDataContext db)
		{
			return db.GetTable<Doctor>().FirstOrDefault(t => t.Personid == obj.Personid);
		}

		/// <summary>
		/// FK_patient_person backreference
		/// </summary>
		public static Patient? Patient(this Person obj, IDataContext db)
		{
			return db.GetTable<Patient>().FirstOrDefault(t => t.Personid == obj.Personid);
		}
		#endregion

		#region Patient Associations
		/// <summary>
		/// FK_patient_person
		/// </summary>
		public static Person Person(this Patient obj, IDataContext db)
		{
			return db.GetTable<Person>().First(t => obj.Personid == t.Personid);
		}
		#endregion

		#region Testfkunique Associations
		/// <summary>
		/// FK_testfkunique_testunique
		/// </summary>
		public static Testunique Testunique(this Testfkunique obj, IDataContext db)
		{
			return db.GetTable<Testunique>().First(t => obj.Id1 == t.Id1 && obj.Id2 == t.Id2);
		}

		/// <summary>
		/// FK_testfkunique_testunique_1
		/// </summary>
		public static Testunique Testunique1(this Testfkunique obj, IDataContext db)
		{
			return db.GetTable<Testunique>().First(t => obj.Id3 == t.Id3 && obj.Id4 == t.Id4);
		}
		#endregion

		#region Testunique Associations
		/// <summary>
		/// FK_testfkunique_testunique backreference
		/// </summary>
		public static IQueryable<Testfkunique> Testfkuniques(this Testunique obj, IDataContext db)
		{
			return db.GetTable<Testfkunique>().Where(t => t.Id1 == obj.Id1 && t.Id2 == obj.Id2);
		}

		/// <summary>
		/// FK_testfkunique_testunique_1 backreference
		/// </summary>
		public static IQueryable<Testfkunique> Testfkuniques1(this Testunique obj, IDataContext db)
		{
			return db.GetTable<Testfkunique>().Where(t => t.Id3 == obj.Id3 && t.Id4 == obj.Id4);
		}
		#endregion
		#endregion
	}
}