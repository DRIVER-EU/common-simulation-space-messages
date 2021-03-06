// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace eu.driver.model.sim.support
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class Address : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""Address"",""namespace"":""eu.driver.model.sim.support"",""fields"":[{""name"":""street"",""doc"":""Optional street name"",""default"":null,""type"":[""null"",""string""]},{""name"":""houseNumber"",""doc"":""Optional house number"",""default"":null,""type"":[""null"",""int""]},{""name"":""houseLetter"",""doc"":""Optional house letter"",""default"":null,""type"":[""null"",""string""]},{""name"":""postalCode"",""doc"":""Optional postal code"",""default"":null,""type"":[""null"",""string""]},{""name"":""city"",""doc"":""Optional name of the city"",""default"":null,""type"":[""null"",""string""]},{""name"":""state"",""doc"":""Optional name of the state or province"",""default"":null,""type"":[""null"",""string""]},{""name"":""country"",""doc"":""Optional name of the country"",""default"":null,""type"":[""null"",""string""]},{""name"":""tags"",""doc"":""Optional map containing address specific information: key – unique name of the specific property; value – value of that property"",""default"":null,""type"":[""null"",{""type"":""map"",""values"":""string""}]}]}");
		/// <summary>
		/// Optional street name
		/// </summary>
		private string _street;
		/// <summary>
		/// Optional house number
		/// </summary>
		private System.Nullable<int> _houseNumber;
		/// <summary>
		/// Optional house letter
		/// </summary>
		private string _houseLetter;
		/// <summary>
		/// Optional postal code
		/// </summary>
		private string _postalCode;
		/// <summary>
		/// Optional name of the city
		/// </summary>
		private string _city;
		/// <summary>
		/// Optional name of the state or province
		/// </summary>
		private string _state;
		/// <summary>
		/// Optional name of the country
		/// </summary>
		private string _country;
		/// <summary>
		/// Optional map containing address specific information: key – unique name of the specific property; value – value of that property
		/// </summary>
		private IDictionary<string,System.String> _tags;
		public virtual Schema Schema
		{
			get
			{
				return Address._SCHEMA;
			}
		}
		/// <summary>
		/// Optional street name
		/// </summary>
		public string street
		{
			get
			{
				return this._street;
			}
			set
			{
				this._street = value;
			}
		}
		/// <summary>
		/// Optional house number
		/// </summary>
		public System.Nullable<int> houseNumber
		{
			get
			{
				return this._houseNumber;
			}
			set
			{
				this._houseNumber = value;
			}
		}
		/// <summary>
		/// Optional house letter
		/// </summary>
		public string houseLetter
		{
			get
			{
				return this._houseLetter;
			}
			set
			{
				this._houseLetter = value;
			}
		}
		/// <summary>
		/// Optional postal code
		/// </summary>
		public string postalCode
		{
			get
			{
				return this._postalCode;
			}
			set
			{
				this._postalCode = value;
			}
		}
		/// <summary>
		/// Optional name of the city
		/// </summary>
		public string city
		{
			get
			{
				return this._city;
			}
			set
			{
				this._city = value;
			}
		}
		/// <summary>
		/// Optional name of the state or province
		/// </summary>
		public string state
		{
			get
			{
				return this._state;
			}
			set
			{
				this._state = value;
			}
		}
		/// <summary>
		/// Optional name of the country
		/// </summary>
		public string country
		{
			get
			{
				return this._country;
			}
			set
			{
				this._country = value;
			}
		}
		/// <summary>
		/// Optional map containing address specific information: key – unique name of the specific property; value – value of that property
		/// </summary>
		public IDictionary<string,System.String> tags
		{
			get
			{
				return this._tags;
			}
			set
			{
				this._tags = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.street;
			case 1: return this.houseNumber;
			case 2: return this.houseLetter;
			case 3: return this.postalCode;
			case 4: return this.city;
			case 5: return this.state;
			case 6: return this.country;
			case 7: return this.tags;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.street = (System.String)fieldValue; break;
			case 1: this.houseNumber = (System.Nullable<int>)fieldValue; break;
			case 2: this.houseLetter = (System.String)fieldValue; break;
			case 3: this.postalCode = (System.String)fieldValue; break;
			case 4: this.city = (System.String)fieldValue; break;
			case 5: this.state = (System.String)fieldValue; break;
			case 6: this.country = (System.String)fieldValue; break;
			case 7: this.tags = (IDictionary<string,System.String>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
