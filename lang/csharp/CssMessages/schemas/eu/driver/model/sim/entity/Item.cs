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
	
	public partial class Item : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"Item\",\"namespace\":\"eu.driver.model.sim.entity\",\"fields\":" +
				"[{\"name\":\"id\",\"doc\":\"Unique case-insensitive identifier of the item\",\"type\":\"str" +
				"ing\"},{\"name\":\"location\",\"doc\":\"Location of the item\",\"type\":{\"type\":\"record\",\"n" +
				"ame\":\"Location\",\"namespace\":\"eu.driver.model.sim.support\",\"fields\":[{\"name\":\"lat" +
				"itude\",\"doc\":\"In decimal degrees, ranging from [-90, 90] where 0 is the equator\"" +
				",\"type\":\"double\"},{\"name\":\"longitude\",\"doc\":\"In decimal degrees, ranging from (-" +
				"180, 180] where 0 is the Prime Meridian (line going through the geographic north" +
				", Greenwich, and the geographic south)\",\"type\":\"double\"},{\"name\":\"altitude\",\"doc" +
				"\":\"Optional in meters, where 0 is the surface of the WGS84-based ellipsoid, or a" +
				"nother agreed upon common ground level (specified inside the configuration guide" +
				"lines). A positive number indicates a location outside the ellipsoid (or above t" +
				"he ground level), while a negative number indicates a location inside the ellips" +
				"oid (or below the ground level). If an altitude is not provided, it is presumed " +
				"that the location is at the ground level of the provided latitude and longitude " +
				"coordinates\",\"default\":null,\"type\":[\"null\",\"double\"]}]}},{\"name\":\"orientation\",\"" +
				"doc\":\"Optional orientation of the item\",\"default\":null,\"type\":[\"null\",{\"type\":\"r" +
				"ecord\",\"name\":\"Orientation\",\"namespace\":\"eu.driver.model.sim.support\",\"fields\":[" +
				"{\"name\":\"yaw\",\"doc\":\"In decimal degrees, ranging from [0, 360) where 0 is pointi" +
				"ng towards the geographic north. The yaw value is applied in a clockwise rotatio" +
				"n over the item’s heading/yaw-axis. A yaw value of 90 makes the item face east, " +
				"while a yaw of 270 makes it face west\",\"type\":\"double\"},{\"name\":\"pitch\",\"doc\":\"I" +
				"n decimal degrees, ranging from [-90, 90] where 0 is perpendicular to the line c" +
				"rossing the item’s location and the centre of the WGS84-based ellipsoid. The pit" +
				"ch value is applied in a counter-clockwise rotation over the item’s pitch-axis. " +
				"A pitch value of 45 makes the item face 45 degrees upwards, while a pitch of -20" +
				" makes it face 20 degrees downwards\",\"type\":\"double\"},{\"name\":\"roll\",\"doc\":\"In d" +
				"ecimal degrees, ranging from (-180, 180] where 0 is perpendicular to the line cr" +
				"ossing the item’s location and the centre of the WGS84-based ellipsoid. The roll" +
				" value is applied in a clockwise rotation over the item’s roll/bank-axis. A roll" +
				" value of 45 makes the item roll 45 degrees to the right, while a roll of -50 ma" +
				"kes it roll 50 degrees to the left\",\"type\":\"double\"}]}]},{\"name\":\"velocity\",\"doc" +
				"\":\"Optional velocity of the item\",\"default\":null,\"type\":[\"null\",{\"type\":\"record\"" +
				",\"name\":\"Velocity\",\"namespace\":\"eu.driver.model.sim.support\",\"fields\":[{\"name\":\"" +
				"yaw\",\"doc\":\"In decimal degrees, ranging from [0, 360) where 0 is pointing toward" +
				"s the geographic north. The yaw value is applied in a clockwise rotation over th" +
				"e item’s heading/yaw-axis. A yaw value of 90 makes the item face east, while a y" +
				"aw of 270 makes it face west\",\"type\":\"double\"},{\"name\":\"pitch\",\"doc\":\"In decimal" +
				" degrees, ranging from [-90, 90] where 0 is perpendicular to the line crossing t" +
				"he item’s location and the centre of the WGS84-based ellipsoid. The pitch value " +
				"is applied in a counter-clockwise rotation over the item’s pitch-axis. A pitch v" +
				"alue of 45 makes the item face 45 degrees upwards, while a pitch of -20 makes it" +
				" face 20 degrees downwards\",\"type\":\"double\"},{\"name\":\"magnitude\",\"doc\":\"In meter" +
				" per seconds, ranging from [0, infinity) where 0 is standing still relative to t" +
				"he earth’s rotation\",\"type\":\"double\"}]}]},{\"name\":\"name\",\"doc\":\"Optional name of" +
				" the item\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"description\",\"doc\":" +
				"\"Optional description of the item\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"na" +
				"me\":\"type\",\"doc\":\"Optional type of the item\",\"default\":null,\"type\":[\"null\",\"stri" +
				"ng\"]},{\"name\":\"owner\",\"doc\":\"Optional unique case-insensitive identifier of the " +
				"connected application owning the item\",\"default\":null,\"type\":[\"null\",\"string\"]}," +
				"{\"name\":\"timestamp\",\"doc\":\"Optional UNIX Epoch time in milliseconds marking the " +
				"time the update was performed\",\"default\":null,\"type\":[\"null\",\"long\"],\"logicalTyp" +
				"e\":\"timestamp-millis\"},{\"name\":\"tags\",\"doc\":\"Optional map containing item specif" +
				"ic information: key – unique name of the specific property; value – value of tha" +
				"t property\",\"default\":null,\"type\":[\"null\",{\"type\":\"map\",\"values\":\"string\"}]},{\"n" +
				"ame\":\"children\",\"doc\":\"Optional list of item identifiers that belong to this ite" +
				"m\",\"default\":null,\"type\":[\"null\",{\"type\":\"array\",\"items\":\"string\"}]}]}");
		/// <summary>
		/// Unique case-insensitive identifier of the item
		/// </summary>
		private string _id;
		/// <summary>
		/// Location of the item
		/// </summary>
		private eu.driver.model.sim.support.Location _location;
		/// <summary>
		/// Optional orientation of the item
		/// </summary>
		private eu.driver.model.sim.support.Orientation _orientation;
		/// <summary>
		/// Optional velocity of the item
		/// </summary>
		private eu.driver.model.sim.support.Velocity _velocity;
		/// <summary>
		/// Optional name of the item
		/// </summary>
		private string _name;
		/// <summary>
		/// Optional description of the item
		/// </summary>
		private string _description;
		/// <summary>
		/// Optional type of the item
		/// </summary>
		private string _type;
		/// <summary>
		/// Optional unique case-insensitive identifier of the connected application owning the item
		/// </summary>
		private string _owner;
		/// <summary>
		/// Optional UNIX Epoch time in milliseconds marking the time the update was performed
		/// </summary>
		private System.Nullable<long> _timestamp;
		/// <summary>
		/// Optional map containing item specific information: key – unique name of the specific property; value – value of that property
		/// </summary>
		private IDictionary<string,System.String> _tags;
		/// <summary>
		/// Optional list of item identifiers that belong to this item
		/// </summary>
		private IList<System.String> _children;
		public virtual Schema Schema
		{
			get
			{
				return Item._SCHEMA;
			}
		}
		/// <summary>
		/// Unique case-insensitive identifier of the item
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
		/// Location of the item
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
		/// <summary>
		/// Optional orientation of the item
		/// </summary>
		public eu.driver.model.sim.support.Orientation orientation
		{
			get
			{
				return this._orientation;
			}
			set
			{
				this._orientation = value;
			}
		}
		/// <summary>
		/// Optional velocity of the item
		/// </summary>
		public eu.driver.model.sim.support.Velocity velocity
		{
			get
			{
				return this._velocity;
			}
			set
			{
				this._velocity = value;
			}
		}
		/// <summary>
		/// Optional name of the item
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
		/// Optional description of the item
		/// </summary>
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
		/// <summary>
		/// Optional type of the item
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
		/// Optional unique case-insensitive identifier of the connected application owning the item
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
		/// Optional map containing item specific information: key – unique name of the specific property; value – value of that property
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
		/// Optional list of item identifiers that belong to this item
		/// </summary>
		public IList<System.String> children
		{
			get
			{
				return this._children;
			}
			set
			{
				this._children = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.id;
			case 1: return this.location;
			case 2: return this.orientation;
			case 3: return this.velocity;
			case 4: return this.name;
			case 5: return this.description;
			case 6: return this.type;
			case 7: return this.owner;
			case 8: return this.timestamp;
			case 9: return this.tags;
			case 10: return this.children;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.id = (System.String)fieldValue; break;
			case 1: this.location = (eu.driver.model.sim.support.Location)fieldValue; break;
			case 2: this.orientation = (eu.driver.model.sim.support.Orientation)fieldValue; break;
			case 3: this.velocity = (eu.driver.model.sim.support.Velocity)fieldValue; break;
			case 4: this.name = (System.String)fieldValue; break;
			case 5: this.description = (System.String)fieldValue; break;
			case 6: this.type = (System.String)fieldValue; break;
			case 7: this.owner = (System.String)fieldValue; break;
			case 8: this.timestamp = (System.Nullable<long>)fieldValue; break;
			case 9: this.tags = (IDictionary<string,System.String>)fieldValue; break;
			case 10: this.children = (IList<System.String>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
