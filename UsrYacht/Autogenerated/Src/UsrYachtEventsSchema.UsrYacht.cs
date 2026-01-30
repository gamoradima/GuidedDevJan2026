namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrYachtEventsSchema

	/// <exclude/>
	public class UsrYachtEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrYachtEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrYachtEventsSchema(UsrYachtEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("47efde3a-feb7-4dfc-b03b-2c7748019f7c");
			Name = "UsrYachtEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("01001eb0-cc0a-4129-8747-301f342075da");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,111,107,219,48,16,198,223,27,250,29,14,191,178,33,136,245,237,178,21,154,44,27,133,210,141,217,25,140,178,23,138,124,113,52,100,201,232,228,116,217,200,119,159,254,164,89,156,116,108,7,6,251,244,232,119,247,156,79,243,14,169,231,2,161,70,107,57,153,181,99,115,163,215,178,29,44,119,210,232,236,87,6,62,6,146,186,133,106,71,14,187,233,73,230,244,86,215,25,253,183,51,139,108,161,157,116,18,233,63,36,108,177,69,237,14,202,199,152,221,197,212,189,244,13,104,180,69,37,54,216,241,7,223,61,188,133,124,73,246,43,23,27,151,151,223,226,149,126,88,41,41,64,40,78,4,241,228,5,6,188,134,25,39,124,225,36,50,146,239,19,154,217,250,102,101,131,176,53,178,129,143,186,226,91,111,161,48,171,239,40,28,16,234,6,237,4,18,110,134,107,239,39,66,111,109,75,128,229,145,246,135,27,98,229,59,96,71,214,51,4,203,233,72,149,160,176,11,78,188,223,34,125,151,73,62,150,54,40,100,199,21,244,86,138,48,155,120,135,125,64,87,239,122,108,230,70,13,157,254,194,213,128,111,14,202,155,34,140,239,83,144,231,103,101,229,26,138,196,185,129,235,87,49,202,145,96,236,37,4,178,59,154,115,45,80,97,227,171,59,59,224,52,187,80,145,179,225,239,251,213,35,222,98,141,93,175,184,11,221,106,124,130,123,35,184,146,63,249,74,97,21,117,69,242,176,36,180,126,53,181,159,182,223,75,246,25,201,12,86,120,141,177,30,50,185,186,168,18,226,184,26,105,163,242,9,228,23,124,98,113,32,119,84,27,51,147,109,250,202,75,86,155,67,253,242,159,22,124,235,41,193,222,27,219,113,87,156,89,243,101,175,193,143,47,62,203,234,221,249,164,67,184,141,53,79,113,2,139,31,2,251,96,242,25,115,166,222,103,227,183,125,182,207,126,3,127,15,43,202,201,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ed08ccc7-743a-ccf8-aa17-0bab1d835f48"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("01001eb0-cc0a-4129-8747-301f342075da"),
				CreatedInSchemaUId = new Guid("47efde3a-feb7-4dfc-b03b-2c7748019f7c"),
				ModifiedInSchemaUId = new Guid("47efde3a-feb7-4dfc-b03b-2c7748019f7c")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("47efde3a-feb7-4dfc-b03b-2c7748019f7c"));
		}

		#endregion

	}

	#endregion

}

