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
	
	public partial class Header : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"Header\",\"namespace\":\"eu.driver.model.sim.support\",\"field" +
				"s\":[{\"name\":\"from\",\"doc\":\"Sender of the post\",\"type\":\"string\"},{\"name\":\"date\",\"d" +
				"oc\":\"UNIX Epoch time in milliseconds marking the time the post was published/upd" +
				"ated\",\"type\":\"long\",\"logicalType\":\"timestamp-millis\"},{\"name\":\"to\",\"doc\":\"Option" +
				"al list of recipients of the post\",\"default\":null,\"type\":[\"null\",{\"type\":\"array\"" +
				",\"items\":\"string\"}]},{\"name\":\"cc\",\"doc\":\"Optional list of recipients in carbon c" +
				"opy of the post\",\"default\":null,\"type\":[\"null\",{\"type\":\"array\",\"items\":\"string\"}" +
				"]},{\"name\":\"bcc\",\"doc\":\"Optional list of recipients in blind carbon copy of the " +
				"post\",\"default\":null,\"type\":[\"null\",{\"type\":\"array\",\"items\":\"string\"}]},{\"name\":" +
				"\"subject\",\"doc\":\"Optional Subject of the post\",\"default\":null,\"type\":[\"null\",\"st" +
				"ring\"]},{\"name\":\"intro\",\"doc\":\"Optional introductory text of the post\",\"default\"" +
				":null,\"type\":[\"null\",\"string\"]},{\"name\":\"attachments\",\"doc\":\"Optional list of (r" +
				"eferences to) attachments inside the post\",\"default\":null,\"type\":[\"null\",{\"type\"" +
				":\"array\",\"items\":\"string\"}]},{\"name\":\"location\",\"doc\":\"optional location the pos" +
				"t is attached to\",\"default\":null,\"type\":[\"null\",{\"type\":\"record\",\"name\":\"Locatio" +
				"n\",\"namespace\":\"eu.driver.model.sim.support\",\"fields\":[{\"name\":\"latitude\",\"doc\":" +
				"\"In decimal degrees, ranging from [-90, 90] where 0 is the equator\",\"type\":\"doub" +
				"le\"},{\"name\":\"longitude\",\"doc\":\"In decimal degrees, ranging from (-180, 180] whe" +
				"re 0 is the Prime Meridian (line going through the geographic north, Greenwich, " +
				"and the geographic south)\",\"type\":\"double\"},{\"name\":\"altitude\",\"doc\":\"Optional i" +
				"n meters, where 0 is the surface of the WGS84-based ellipsoid\",\"default\":null,\"t" +
				"ype\":[\"null\",\"double\"]}]}]}]}");
		/// <summary>
		/// Sender of the post
		/// </summary>
		private string _from;
		/// <summary>
		/// UNIX Epoch time in milliseconds marking the time the post was published/updated
		/// </summary>
		private long _date;
		/// <summary>
		/// Optional list of recipients of the post
		/// </summary>
		private IList<System.String> _to;
		/// <summary>
		/// Optional list of recipients in carbon copy of the post
		/// </summary>
		private IList<System.String> _cc;
		/// <summary>
		/// Optional list of recipients in blind carbon copy of the post
		/// </summary>
		private IList<System.String> _bcc;
		/// <summary>
		/// Optional Subject of the post
		/// </summary>
		private string _subject;
		/// <summary>
		/// Optional introductory text of the post
		/// </summary>
		private string _intro;
		/// <summary>
		/// Optional list of (references to) attachments inside the post
		/// </summary>
		private IList<System.String> _attachments;
		/// <summary>
		/// optional location the post is attached to
		/// </summary>
		private eu.driver.model.sim.support.Location _location;
		public virtual Schema Schema
		{
			get
			{
				return Header._SCHEMA;
			}
		}
		/// <summary>
		/// Sender of the post
		/// </summary>
		public string from
		{
			get
			{
				return this._from;
			}
			set
			{
				this._from = value;
			}
		}
		/// <summary>
		/// UNIX Epoch time in milliseconds marking the time the post was published/updated
		/// </summary>
		public long date
		{
			get
			{
				return this._date;
			}
			set
			{
				this._date = value;
			}
		}
		/// <summary>
		/// Optional list of recipients of the post
		/// </summary>
		public IList<System.String> to
		{
			get
			{
				return this._to;
			}
			set
			{
				this._to = value;
			}
		}
		/// <summary>
		/// Optional list of recipients in carbon copy of the post
		/// </summary>
		public IList<System.String> cc
		{
			get
			{
				return this._cc;
			}
			set
			{
				this._cc = value;
			}
		}
		/// <summary>
		/// Optional list of recipients in blind carbon copy of the post
		/// </summary>
		public IList<System.String> bcc
		{
			get
			{
				return this._bcc;
			}
			set
			{
				this._bcc = value;
			}
		}
		/// <summary>
		/// Optional Subject of the post
		/// </summary>
		public string subject
		{
			get
			{
				return this._subject;
			}
			set
			{
				this._subject = value;
			}
		}
		/// <summary>
		/// Optional introductory text of the post
		/// </summary>
		public string intro
		{
			get
			{
				return this._intro;
			}
			set
			{
				this._intro = value;
			}
		}
		/// <summary>
		/// Optional list of (references to) attachments inside the post
		/// </summary>
		public IList<System.String> attachments
		{
			get
			{
				return this._attachments;
			}
			set
			{
				this._attachments = value;
			}
		}
		/// <summary>
		/// optional location the post is attached to
		/// </summary>
		public eu.driver.model.sim.support.Location location
		{
			get
			{
				return this._location;
			}
			set
			{
				this._location = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.from;
			case 1: return this.date;
			case 2: return this.to;
			case 3: return this.cc;
			case 4: return this.bcc;
			case 5: return this.subject;
			case 6: return this.intro;
			case 7: return this.attachments;
			case 8: return this.location;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.from = (System.String)fieldValue; break;
			case 1: this.date = (System.Int64)fieldValue; break;
			case 2: this.to = (IList<System.String>)fieldValue; break;
			case 3: this.cc = (IList<System.String>)fieldValue; break;
			case 4: this.bcc = (IList<System.String>)fieldValue; break;
			case 5: this.subject = (System.String)fieldValue; break;
			case 6: this.intro = (System.String)fieldValue; break;
			case 7: this.attachments = (IList<System.String>)fieldValue; break;
			case 8: this.location = (eu.driver.model.sim.support.Location)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}