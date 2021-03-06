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
	
	public partial class Response : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""Response"",""namespace"":""eu.driver.model.sim.support"",""fields"":[{""name"":""id"",""doc"":""Unique case-insensitive identifier of the response"",""type"":""string""},{""name"":""request"",""doc"":""Unique case-insensitive identifier of the request this response is responding to"",""type"":""string""},{""name"":""code"",""doc"":""Optional HTTP status code that best serves the response. Configuration guidelines might define new response codes that better fit the needs of that common simulation space"",""default"":null,""type"":[""null"",""int""]},{""name"":""message"",""doc"":""Optional information accompanying the response code"",""default"":null,""type"":[""null"",""string""]},{""name"":""timestamp"",""doc"":""Optional UNIX Epoch time in milliseconds marking the time the respond was given"",""default"":null,""type"":[""null"",""long""],""logicalType"":""timestamp-millis""}]}");
		/// <summary>
		/// Unique case-insensitive identifier of the response
		/// </summary>
		private string _id;
		/// <summary>
		/// Unique case-insensitive identifier of the request this response is responding to
		/// </summary>
		private string _request;
		/// <summary>
		/// Optional HTTP status code that best serves the response. Configuration guidelines might define new response codes that better fit the needs of that common simulation space
		/// </summary>
		private System.Nullable<int> _code;
		/// <summary>
		/// Optional information accompanying the response code
		/// </summary>
		private string _message;
		/// <summary>
		/// Optional UNIX Epoch time in milliseconds marking the time the respond was given
		/// </summary>
		private System.Nullable<long> _timestamp;
		public virtual Schema Schema
		{
			get
			{
				return Response._SCHEMA;
			}
		}
		/// <summary>
		/// Unique case-insensitive identifier of the response
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
		/// Unique case-insensitive identifier of the request this response is responding to
		/// </summary>
		public string request
		{
			get
			{
				return this._request;
			}
			set
			{
				this._request = value;
			}
		}
		/// <summary>
		/// Optional HTTP status code that best serves the response. Configuration guidelines might define new response codes that better fit the needs of that common simulation space
		/// </summary>
		public System.Nullable<int> code
		{
			get
			{
				return this._code;
			}
			set
			{
				this._code = value;
			}
		}
		/// <summary>
		/// Optional information accompanying the response code
		/// </summary>
		public string message
		{
			get
			{
				return this._message;
			}
			set
			{
				this._message = value;
			}
		}
		/// <summary>
		/// Optional UNIX Epoch time in milliseconds marking the time the respond was given
		/// </summary>
		public System.Nullable<long> timestamp
		{
			get
			{
				return this._timestamp;
			}
			set
			{
				this._timestamp = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.id;
			case 1: return this.request;
			case 2: return this.code;
			case 3: return this.message;
			case 4: return this.timestamp;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.id = (System.String)fieldValue; break;
			case 1: this.request = (System.String)fieldValue; break;
			case 2: this.code = (System.Nullable<int>)fieldValue; break;
			case 3: this.message = (System.String)fieldValue; break;
			case 4: this.timestamp = (System.Nullable<long>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
