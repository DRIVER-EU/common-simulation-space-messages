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
	
	public partial class RequestCancelled : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""RequestCancelled"",""namespace"":""eu.driver.model.sim.support"",""fields"":[{""name"":""id"",""doc"":""Unique identifier of the request"",""type"":""string""},{""name"":""applicant"",""doc"":""Unique identifier of the connected appliaction sending the request"",""type"":""string""}]}");
		/// <summary>
		/// Unique identifier of the request
		/// </summary>
		private string _id;
		/// <summary>
		/// Unique identifier of the connected appliaction sending the request
		/// </summary>
		private string _applicant;
		public virtual Schema Schema
		{
			get
			{
				return RequestCancelled._SCHEMA;
			}
		}
		/// <summary>
		/// Unique identifier of the request
		/// </summary>
		public string id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		/// <summary>
		/// Unique identifier of the connected appliaction sending the request
		/// </summary>
		public string applicant
		{
			get
			{
				return this._applicant;
			}
			set
			{
				this._applicant = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.id;
			case 1: return this.applicant;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.id = (System.String)fieldValue; break;
			case 1: this.applicant = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
