// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace eu.driver.model.sim.entity
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class Post : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"Post\",\"namespace\":\"eu.driver.model.sim.entity\",\"fields\":" +
				"[{\"name\":\"id\",\"doc\":\"Unique identifier of the post\",\"type\":\"string\"},{\"name\":\"bo" +
				"dy\",\"doc\":\"Body text of the post\",\"type\":\"string\"},{\"name\":\"header\",\"doc\":\"Optio" +
				"nal header information of the post\",\"default\":null,\"type\":[\"null\",{\"type\":\"recor" +
				"d\",\"name\":\"Header\",\"namespace\":\"eu.driver.model.sim.support\",\"fields\":[{\"name\":\"" +
				"from\",\"doc\":\"Sender of the post\",\"type\":\"string\"},{\"name\":\"date\",\"doc\":\"UNIX Epo" +
				"ch time in milliseconds marking the time the post was published/updated\",\"type\":" +
				"\"long\",\"logicalType\":\"timestamp-millis\"},{\"name\":\"to\",\"doc\":\"Optional list of re" +
				"cipients of the post\",\"default\":null,\"type\":[\"null\",{\"type\":\"array\",\"items\":\"str" +
				"ing\"}]},{\"name\":\"cc\",\"doc\":\"Optional list of recipients in carbon copy of the po" +
				"st\",\"default\":null,\"type\":[\"null\",{\"type\":\"array\",\"items\":\"string\"}]},{\"name\":\"b" +
				"cc\",\"doc\":\"Optional list of recipients in blind carbon copy of the post\",\"defaul" +
				"t\":null,\"type\":[\"null\",{\"type\":\"array\",\"items\":\"string\"}]},{\"name\":\"subject\",\"do" +
				"c\":\"Optional Subject of the post\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"nam" +
				"e\":\"intro\",\"doc\":\"Optional introductory text of the post\",\"default\":null,\"type\":" +
				"[\"null\",\"string\"]},{\"name\":\"attachments\",\"doc\":\"Optional list of (references to)" +
				" attachments inside the post\",\"default\":null,\"type\":[\"null\",{\"type\":\"array\",\"ite" +
				"ms\":\"string\"}]},{\"name\":\"location\",\"doc\":\"optional location the post is attached" +
				" to\",\"default\":null,\"type\":[\"null\",{\"type\":\"record\",\"name\":\"Location\",\"namespace" +
				"\":\"eu.driver.model.sim.support\",\"fields\":[{\"name\":\"latitude\",\"doc\":\"In decimal d" +
				"egrees, ranging from [-90, 90] where 0 is the equator\",\"type\":\"double\"},{\"name\":" +
				"\"longitude\",\"doc\":\"In decimal degrees, ranging from (-180, 180] where 0 is the P" +
				"rime Meridian (line going through the geographic north, Greenwich, and the geogr" +
				"aphic south)\",\"type\":\"double\"},{\"name\":\"altitude\",\"doc\":\"Optional in meters, whe" +
				"re 0 is the surface of the WGS84-based ellipsoid\",\"default\":null,\"type\":[\"null\"," +
				"\"double\"]}]}]}]}]},{\"name\":\"name\",\"doc\":\"Optional name of the post\",\"default\":nu" +
				"ll,\"type\":[\"null\",\"string\"]},{\"name\":\"type\",\"doc\":\"Optional type of the post\",\"d" +
				"efault\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"owner\",\"doc\":\"Optional unique id" +
				"entifier of the connected application owning the post\",\"default\":null,\"type\":[\"n" +
				"ull\",\"string\"]},{\"name\":\"timestamp\",\"doc\":\"Optional UNIX Epoch time in milliseco" +
				"nds marking the time the update was performed\",\"default\":null,\"type\":[\"null\",\"lo" +
				"ng\"],\"logicalType\":\"timestamp-millis\"},{\"name\":\"tags\",\"doc\":\"Optional map contai" +
				"ning post specific information: key – unique name of the specific property; valu" +
				"e – value of that property\",\"default\":null,\"type\":[\"null\",{\"type\":\"map\",\"values\"" +
				":\"string\"}]},{\"name\":\"mediumType\",\"doc\":\"Optional type of the medium the post is" +
				" published on\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"mediumName\",\"do" +
				"c\":\"Optional name of the medium the post is published on\",\"default\":null,\"type\":" +
				"[\"null\",\"string\"]}],\"_comment\":\"TODO: Include type property into tags? Can heade" +
				"r become null?\"}");
		/// <summary>
		/// Unique identifier of the post
		/// </summary>
		private string _id;
		/// <summary>
		/// Body text of the post
		/// </summary>
		private string _body;
		/// <summary>
		/// Optional header information of the post
		/// </summary>
		private eu.driver.model.sim.support.Header _header;
		/// <summary>
		/// Optional name of the post
		/// </summary>
		private string _name;
		/// <summary>
		/// Optional type of the post
		/// </summary>
		private string _type;
		/// <summary>
		/// Optional unique identifier of the connected application owning the post
		/// </summary>
		private string _owner;
		/// <summary>
		/// Optional UNIX Epoch time in milliseconds marking the time the update was performed
		/// </summary>
		private System.Nullable<long> _timestamp;
		/// <summary>
		/// Optional map containing post specific information: key – unique name of the specific property; value – value of that property
		/// </summary>
		private IDictionary<string,System.String> _tags;
		/// <summary>
		/// Optional type of the medium the post is published on
		/// </summary>
		private string _mediumType;
		/// <summary>
		/// Optional name of the medium the post is published on
		/// </summary>
		private string _mediumName;
		public virtual Schema Schema
		{
			get
			{
				return Post._SCHEMA;
			}
		}
		/// <summary>
		/// Unique identifier of the post
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
		/// Body text of the post
		/// </summary>
		public string body
		{
			get
			{
				return this._body;
			}
			set
			{
				this._body = value;
			}
		}
		/// <summary>
		/// Optional header information of the post
		/// </summary>
		public eu.driver.model.sim.support.Header header
		{
			get
			{
				return this._header;
			}
			set
			{
				this._header = value;
			}
		}
		/// <summary>
		/// Optional name of the post
		/// </summary>
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		/// <summary>
		/// Optional type of the post
		/// </summary>
		public string type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		/// <summary>
		/// Optional unique identifier of the connected application owning the post
		/// </summary>
		public string owner
		{
			get
			{
				return this._owner;
			}
			set
			{
				this._owner = value;
			}
		}
		/// <summary>
		/// Optional UNIX Epoch time in milliseconds marking the time the update was performed
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
		/// <summary>
		/// Optional map containing post specific information: key – unique name of the specific property; value – value of that property
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
		/// <summary>
		/// Optional type of the medium the post is published on
		/// </summary>
		public string mediumType
		{
			get
			{
				return this._mediumType;
			}
			set
			{
				this._mediumType = value;
			}
		}
		/// <summary>
		/// Optional name of the medium the post is published on
		/// </summary>
		public string mediumName
		{
			get
			{
				return this._mediumName;
			}
			set
			{
				this._mediumName = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.id;
			case 1: return this.body;
			case 2: return this.header;
			case 3: return this.name;
			case 4: return this.type;
			case 5: return this.owner;
			case 6: return this.timestamp;
			case 7: return this.tags;
			case 8: return this.mediumType;
			case 9: return this.mediumName;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.id = (System.String)fieldValue; break;
			case 1: this.body = (System.String)fieldValue; break;
			case 2: this.header = (eu.driver.model.sim.support.Header)fieldValue; break;
			case 3: this.name = (System.String)fieldValue; break;
			case 4: this.type = (System.String)fieldValue; break;
			case 5: this.owner = (System.String)fieldValue; break;
			case 6: this.timestamp = (System.Nullable<long>)fieldValue; break;
			case 7: this.tags = (IDictionary<string,System.String>)fieldValue; break;
			case 8: this.mediumType = (System.String)fieldValue; break;
			case 9: this.mediumName = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}