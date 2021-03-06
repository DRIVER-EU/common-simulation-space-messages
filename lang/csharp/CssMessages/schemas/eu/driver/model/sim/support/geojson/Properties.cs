// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace eu.driver.model.sim.support.geojson
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class Properties : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"Properties\",\"namespace\":\"eu.driver.model.sim.support.geo" +
				"json\",\"fields\":[{\"name\":\"id\",\"doc\":\"Unique case-insensitive identifier of the fe" +
				"ature\",\"type\":\"string\"},{\"name\":\"name\",\"doc\":\"Optional name of the feature\",\"def" +
				"ault\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"description\",\"doc\":\"Optional descr" +
				"iption of the feature\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"type\",\"" +
				"doc\":\"Optional type of the feature\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"n" +
				"ame\":\"tags\",\"doc\":\"Optional map containing feature specific information: key – u" +
				"nique name of the specific property; value – value of that property\",\"default\":n" +
				"ull,\"type\":[\"null\",{\"type\":\"map\",\"values\":\"string\"}]},{\"name\":\"orientation\",\"doc" +
				"\":\"Optional orientation of the feature\",\"default\":null,\"type\":[\"null\",{\"type\":\"r" +
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
				"kes it roll 50 degrees to the left\",\"type\":\"double\"}]}]},{\"name\":\"entities\",\"doc" +
				"\":\"Optional list of entity identifiers that are at this feature\",\"default\":null," +
				"\"type\":[\"null\",{\"type\":\"array\",\"items\":\"string\"}]},{\"name\":\"address\",\"doc\":\"Opti" +
				"onal address information of the feature\",\"default\":null,\"type\":[\"null\",{\"type\":\"" +
				"record\",\"name\":\"Address\",\"namespace\":\"eu.driver.model.sim.support\",\"fields\":[{\"n" +
				"ame\":\"street\",\"doc\":\"Optional street name\",\"default\":null,\"type\":[\"null\",\"string" +
				"\"]},{\"name\":\"houseNumber\",\"doc\":\"Optional house number\",\"default\":null,\"type\":[\"" +
				"null\",\"int\"]},{\"name\":\"houseLetter\",\"doc\":\"Optional house letter\",\"default\":null" +
				",\"type\":[\"null\",\"string\"]},{\"name\":\"postalCode\",\"doc\":\"Optional postal code\",\"de" +
				"fault\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"city\",\"doc\":\"Optional name of the" +
				" city\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"state\",\"doc\":\"Optional " +
				"name of the state or province\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":" +
				"\"country\",\"doc\":\"Optional name of the country\",\"default\":null,\"type\":[\"null\",\"st" +
				"ring\"]},{\"name\":\"tags\",\"doc\":\"Optional map containing address specific informati" +
				"on: key – unique name of the specific property; value – value of that property\"," +
				"\"default\":null,\"type\":[\"null\",{\"type\":\"map\",\"values\":\"string\"}]}]}]},{\"name\":\"ti" +
				"tle\",\"doc\":\"Optional title of the feature (as defined by the simplestyle specifi" +
				"cation)\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"markerSize\",\"doc\":\"Op" +
				"tional size of the style marker (as defined by the simplestyle specification)\",\"" +
				"default\":null,\"type\":[\"null\",{\"type\":\"enum\",\"name\":\"MarkerSize\",\"namespace\":\"eu." +
				"driver.model.sim.support\",\"symbols\":[\"small\",\"medium\",\"large\"]}]},{\"name\":\"marke" +
				"rSymbol\",\"doc\":\"Optional symbol to display in the center of the style marker (as" +
				" defined by the simplestyle specification). Allowed values include an Icon ID, a" +
				"n integer 0 through 9, a lowercase character a through z\",\"default\":null,\"type\":" +
				"[\"null\",\"string\"]},{\"name\":\"markerColor\",\"doc\":\"Optional color of the style mark" +
				"er (as defined by the simplestyle specification). This value should be a string-" +
				"encoded hexadecimal value for the red, green and blue intensity of the desired c" +
				"olor (in that order)\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"stroke\"," +
				"\"doc\":\"Optional color of a line as part of a GeoJSON geometry (as defined by the" +
				" simplestyle specification). This value should be a string-encoded hexadecimal v" +
				"alue for the red, green and blue intensity of the desired color (in that order)\"" +
				",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"strokeOpacity\",\"doc\":\"Optiona" +
				"l opacity of the line as part of a GeoJSON geometry (as defined by the simplesty" +
				"le specification), ranging from [0, 1]\",\"default\":null,\"type\":[\"null\",\"float\"]}," +
				"{\"name\":\"strokeWidth\",\"doc\":\"The width of the line as part of a GeoJSON geometry" +
				" (as defined by the simplestyle specification), ranging from [0, infinity)\",\"def" +
				"ault\":null,\"type\":[\"null\",\"float\"]},{\"name\":\"fill\",\"doc\":\"Optional color of the " +
				"GeoJSON geometry (as defined by the simplestyle specification). This value shoul" +
				"d be a string-encoded hexadecimal value for the red, green and blue intensity of" +
				" the desired color (in that order)\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"n" +
				"ame\":\"fillOpacity\",\"doc\":\"Optional opacity of the GeoJSON geometry (as defined b" +
				"y the simplestyle specification), ranging from [0, 1]\",\"default\":null,\"type\":[\"n" +
				"ull\",\"float\"]}]}");
		/// <summary>
		/// Unique case-insensitive identifier of the feature
		/// </summary>
		private string _id;
		/// <summary>
		/// Optional name of the feature
		/// </summary>
		private string _name;
		/// <summary>
		/// Optional description of the feature
		/// </summary>
		private string _description;
		/// <summary>
		/// Optional type of the feature
		/// </summary>
		private string _type;
		/// <summary>
		/// Optional map containing feature specific information: key – unique name of the specific property; value – value of that property
		/// </summary>
		private IDictionary<string,System.String> _tags;
		/// <summary>
		/// Optional orientation of the feature
		/// </summary>
		private eu.driver.model.sim.support.Orientation _orientation;
		/// <summary>
		/// Optional list of entity identifiers that are at this feature
		/// </summary>
		private IList<System.String> _entities;
		/// <summary>
		/// Optional address information of the feature
		/// </summary>
		private eu.driver.model.sim.support.Address _address;
		/// <summary>
		/// Optional title of the feature (as defined by the simplestyle specification)
		/// </summary>
		private string _title;
		/// <summary>
		/// Optional size of the style marker (as defined by the simplestyle specification)
		/// </summary>
		private System.Nullable<eu.driver.model.sim.support.MarkerSize> _markerSize;
		/// <summary>
		/// Optional symbol to display in the center of the style marker (as defined by the simplestyle specification). Allowed values include an Icon ID, an integer 0 through 9, a lowercase character a through z
		/// </summary>
		private string _markerSymbol;
		/// <summary>
		/// Optional color of the style marker (as defined by the simplestyle specification). This value should be a string-encoded hexadecimal value for the red, green and blue intensity of the desired color (in that order)
		/// </summary>
		private string _markerColor;
		/// <summary>
		/// Optional color of a line as part of a GeoJSON geometry (as defined by the simplestyle specification). This value should be a string-encoded hexadecimal value for the red, green and blue intensity of the desired color (in that order)
		/// </summary>
		private string _stroke;
		/// <summary>
		/// Optional opacity of the line as part of a GeoJSON geometry (as defined by the simplestyle specification), ranging from [0, 1]
		/// </summary>
		private System.Nullable<float> _strokeOpacity;
		/// <summary>
		/// The width of the line as part of a GeoJSON geometry (as defined by the simplestyle specification), ranging from [0, infinity)
		/// </summary>
		private System.Nullable<float> _strokeWidth;
		/// <summary>
		/// Optional color of the GeoJSON geometry (as defined by the simplestyle specification). This value should be a string-encoded hexadecimal value for the red, green and blue intensity of the desired color (in that order)
		/// </summary>
		private string _fill;
		/// <summary>
		/// Optional opacity of the GeoJSON geometry (as defined by the simplestyle specification), ranging from [0, 1]
		/// </summary>
		private System.Nullable<float> _fillOpacity;
		public virtual Schema Schema
		{
			get
			{
				return Properties._SCHEMA;
			}
		}
		/// <summary>
		/// Unique case-insensitive identifier of the feature
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
		/// Optional name of the feature
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
		/// Optional description of the feature
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
		/// Optional type of the feature
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
		/// Optional map containing feature specific information: key – unique name of the specific property; value – value of that property
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
		/// Optional orientation of the feature
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
		/// Optional list of entity identifiers that are at this feature
		/// </summary>
		public IList<System.String> entities
		{
			get
			{
				return this._entities;
			}
			set
			{
				this._entities = value;
			}
		}
		/// <summary>
		/// Optional address information of the feature
		/// </summary>
		public eu.driver.model.sim.support.Address address
		{
			get
			{
				return this._address;
			}
			set
			{
				this._address = value;
			}
		}
		/// <summary>
		/// Optional title of the feature (as defined by the simplestyle specification)
		/// </summary>
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				this._title = value;
			}
		}
		/// <summary>
		/// Optional size of the style marker (as defined by the simplestyle specification)
		/// </summary>
		public System.Nullable<eu.driver.model.sim.support.MarkerSize> markerSize
		{
			get
			{
				return this._markerSize;
			}
			set
			{
				this._markerSize = value;
			}
		}
		/// <summary>
		/// Optional symbol to display in the center of the style marker (as defined by the simplestyle specification). Allowed values include an Icon ID, an integer 0 through 9, a lowercase character a through z
		/// </summary>
		public string markerSymbol
		{
			get
			{
				return this._markerSymbol;
			}
			set
			{
				this._markerSymbol = value;
			}
		}
		/// <summary>
		/// Optional color of the style marker (as defined by the simplestyle specification). This value should be a string-encoded hexadecimal value for the red, green and blue intensity of the desired color (in that order)
		/// </summary>
		public string markerColor
		{
			get
			{
				return this._markerColor;
			}
			set
			{
				this._markerColor = value;
			}
		}
		/// <summary>
		/// Optional color of a line as part of a GeoJSON geometry (as defined by the simplestyle specification). This value should be a string-encoded hexadecimal value for the red, green and blue intensity of the desired color (in that order)
		/// </summary>
		public string stroke
		{
			get
			{
				return this._stroke;
			}
			set
			{
				this._stroke = value;
			}
		}
		/// <summary>
		/// Optional opacity of the line as part of a GeoJSON geometry (as defined by the simplestyle specification), ranging from [0, 1]
		/// </summary>
		public System.Nullable<float> strokeOpacity
		{
			get
			{
				return this._strokeOpacity;
			}
			set
			{
				this._strokeOpacity = value;
			}
		}
		/// <summary>
		/// The width of the line as part of a GeoJSON geometry (as defined by the simplestyle specification), ranging from [0, infinity)
		/// </summary>
		public System.Nullable<float> strokeWidth
		{
			get
			{
				return this._strokeWidth;
			}
			set
			{
				this._strokeWidth = value;
			}
		}
		/// <summary>
		/// Optional color of the GeoJSON geometry (as defined by the simplestyle specification). This value should be a string-encoded hexadecimal value for the red, green and blue intensity of the desired color (in that order)
		/// </summary>
		public string fill
		{
			get
			{
				return this._fill;
			}
			set
			{
				this._fill = value;
			}
		}
		/// <summary>
		/// Optional opacity of the GeoJSON geometry (as defined by the simplestyle specification), ranging from [0, 1]
		/// </summary>
		public System.Nullable<float> fillOpacity
		{
			get
			{
				return this._fillOpacity;
			}
			set
			{
				this._fillOpacity = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.id;
			case 1: return this.name;
			case 2: return this.description;
			case 3: return this.type;
			case 4: return this.tags;
			case 5: return this.orientation;
			case 6: return this.entities;
			case 7: return this.address;
			case 8: return this.title;
			case 9: return this.markerSize;
			case 10: return this.markerSymbol;
			case 11: return this.markerColor;
			case 12: return this.stroke;
			case 13: return this.strokeOpacity;
			case 14: return this.strokeWidth;
			case 15: return this.fill;
			case 16: return this.fillOpacity;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.id = (System.String)fieldValue; break;
			case 1: this.name = (System.String)fieldValue; break;
			case 2: this.description = (System.String)fieldValue; break;
			case 3: this.type = (System.String)fieldValue; break;
			case 4: this.tags = (IDictionary<string,System.String>)fieldValue; break;
			case 5: this.orientation = (eu.driver.model.sim.support.Orientation)fieldValue; break;
			case 6: this.entities = (IList<System.String>)fieldValue; break;
			case 7: this.address = (eu.driver.model.sim.support.Address)fieldValue; break;
			case 8: this.title = (System.String)fieldValue; break;
			case 9: this.markerSize = fieldValue == null ? (System.Nullable<eu.driver.model.sim.support.MarkerSize>)null : (eu.driver.model.sim.support.MarkerSize)fieldValue; break;
			case 10: this.markerSymbol = (System.String)fieldValue; break;
			case 11: this.markerColor = (System.String)fieldValue; break;
			case 12: this.stroke = (System.String)fieldValue; break;
			case 13: this.strokeOpacity = (System.Nullable<float>)fieldValue; break;
			case 14: this.strokeWidth = (System.Nullable<float>)fieldValue; break;
			case 15: this.fill = (System.String)fieldValue; break;
			case 16: this.fillOpacity = (System.Nullable<float>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
