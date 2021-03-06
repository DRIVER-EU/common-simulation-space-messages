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
	
	public partial class Feature : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"Feature\",\"namespace\":\"eu.driver.model.sim.support.geojso" +
				"n\",\"fields\":[{\"name\":\"type\",\"default\":\"Feature\",\"type\":{\"type\":\"enum\",\"name\":\"Fe" +
				"atureType\",\"namespace\":\"eu.driver.model.sim.support.geojson\",\"symbols\":[\"Feature" +
				"\"]}},{\"name\":\"geometry\",\"doc\":\"The geometry (as defined by the GeoJSON standard)" +
				": Point – a point; MultiPoint – a collection of points; LineString – a collectio" +
				"n of points forming a line; MultiLineString – a collection of lines; Polygon – a" +
				" collection of points forming an area; MultiPolygon – a collection of areas; Geo" +
				"metryCollection – a collection of any of the types above\",\"type\":[{\"type\":\"recor" +
				"d\",\"name\":\"Point\",\"namespace\":\"eu.driver.model.sim.support.geojson.geometry\",\"fi" +
				"elds\":[{\"name\":\"type\",\"default\":\"Point\",\"type\":{\"type\":\"enum\",\"name\":\"PointType\"" +
				",\"namespace\":\"eu.driver.model.sim.support.geojson.geometry\",\"symbols\":[\"Point\"]}" +
				"},{\"name\":\"coordinates\",\"type\":{\"type\":\"array\",\"items\":\"double\"}}]},{\"type\":\"rec" +
				"ord\",\"name\":\"MultiPoint\",\"namespace\":\"eu.driver.model.sim.support.geojson.geomet" +
				"ry\",\"fields\":[{\"name\":\"type\",\"default\":\"MultiPoint\",\"type\":{\"type\":\"enum\",\"name\"" +
				":\"MultiPointType\",\"namespace\":\"eu.driver.model.sim.support.geojson.geometry\",\"sy" +
				"mbols\":[\"MultiPoint\"]}},{\"name\":\"coordinates\",\"type\":{\"type\":\"array\",\"items\":{\"t" +
				"ype\":\"array\",\"items\":\"double\"}}}]},{\"type\":\"record\",\"name\":\"LineString\",\"namespa" +
				"ce\":\"eu.driver.model.sim.support.geojson.geometry\",\"fields\":[{\"name\":\"type\",\"def" +
				"ault\":\"LineString\",\"type\":{\"type\":\"enum\",\"name\":\"LineStringType\",\"namespace\":\"eu" +
				".driver.model.sim.support.geojson.geometry\",\"symbols\":[\"LineString\"]}},{\"name\":\"" +
				"coordinates\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"array\",\"items\":\"double\"}}}]" +
				"},{\"type\":\"record\",\"name\":\"MultiLineString\",\"namespace\":\"eu.driver.model.sim.sup" +
				"port.geojson.geometry\",\"fields\":[{\"name\":\"type\",\"default\":\"MultiLineString\",\"typ" +
				"e\":{\"type\":\"enum\",\"name\":\"MultiLineStringType\",\"namespace\":\"eu.driver.model.sim." +
				"support.geojson.geometry\",\"symbols\":[\"MultiLineString\"]}},{\"name\":\"coordinates\"," +
				"\"type\":{\"type\":\"array\",\"items\":{\"type\":\"array\",\"items\":{\"type\":\"array\",\"items\":\"" +
				"double\"}}}}]},{\"type\":\"record\",\"name\":\"Polygon\",\"namespace\":\"eu.driver.model.sim" +
				".support.geojson.geometry\",\"fields\":[{\"name\":\"type\",\"default\":\"Polygon\",\"type\":{" +
				"\"type\":\"enum\",\"name\":\"PolygonType\",\"namespace\":\"eu.driver.model.sim.support.geoj" +
				"son.geometry\",\"symbols\":[\"Polygon\"]}},{\"name\":\"coordinates\",\"type\":{\"type\":\"arra" +
				"y\",\"items\":{\"type\":\"array\",\"items\":\"double\"}}}]},{\"type\":\"record\",\"name\":\"MultiP" +
				"olygon\",\"namespace\":\"eu.driver.model.sim.support.geojson.geometry\",\"fields\":[{\"n" +
				"ame\":\"type\",\"default\":\"MultiPolygon\",\"type\":{\"type\":\"enum\",\"name\":\"MultiPolygonT" +
				"ype\",\"namespace\":\"eu.driver.model.sim.support.geojson.geometry\",\"symbols\":[\"Mult" +
				"iPolygon\"]}},{\"name\":\"coordinates\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"array" +
				"\",\"items\":{\"type\":\"array\",\"items\":\"double\"}}}}]}]},{\"name\":\"properties\",\"doc\":\"O" +
				"ptional feature specific properties (as defined by the GeoJSON standard)\",\"defau" +
				"lt\":null,\"type\":[\"null\",{\"type\":\"record\",\"name\":\"Properties\",\"namespace\":\"eu.dri" +
				"ver.model.sim.support.geojson\",\"fields\":[{\"name\":\"id\",\"doc\":\"Unique case-insensi" +
				"tive identifier of the feature\",\"type\":\"string\"},{\"name\":\"name\",\"doc\":\"Optional " +
				"name of the feature\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"descripti" +
				"on\",\"doc\":\"Optional description of the feature\",\"default\":null,\"type\":[\"null\",\"s" +
				"tring\"]},{\"name\":\"type\",\"doc\":\"Optional type of the feature\",\"default\":null,\"typ" +
				"e\":[\"null\",\"string\"]},{\"name\":\"tags\",\"doc\":\"Optional map containing feature spec" +
				"ific information: key – unique name of the specific property; value – value of t" +
				"hat property\",\"default\":null,\"type\":[\"null\",{\"type\":\"map\",\"values\":\"string\"}]},{" +
				"\"name\":\"orientation\",\"doc\":\"Optional orientation of the feature\",\"default\":null," +
				"\"type\":[\"null\",{\"type\":\"record\",\"name\":\"Orientation\",\"namespace\":\"eu.driver.mode" +
				"l.sim.support\",\"fields\":[{\"name\":\"yaw\",\"doc\":\"In decimal degrees, ranging from [" +
				"0, 360) where 0 is pointing towards the geographic north. The yaw value is appli" +
				"ed in a clockwise rotation over the item’s heading/yaw-axis. A yaw value of 90 m" +
				"akes the item face east, while a yaw of 270 makes it face west\",\"type\":\"double\"}" +
				",{\"name\":\"pitch\",\"doc\":\"In decimal degrees, ranging from [-90, 90] where 0 is pe" +
				"rpendicular to the line crossing the item’s location and the centre of the WGS84" +
				"-based ellipsoid. The pitch value is applied in a counter-clockwise rotation ove" +
				"r the item’s pitch-axis. A pitch value of 45 makes the item face 45 degrees upwa" +
				"rds, while a pitch of -20 makes it face 20 degrees downwards\",\"type\":\"double\"},{" +
				"\"name\":\"roll\",\"doc\":\"In decimal degrees, ranging from (-180, 180] where 0 is per" +
				"pendicular to the line crossing the item’s location and the centre of the WGS84-" +
				"based ellipsoid. The roll value is applied in a clockwise rotation over the item" +
				"’s roll/bank-axis. A roll value of 45 makes the item roll 45 degrees to the righ" +
				"t, while a roll of -50 makes it roll 50 degrees to the left\",\"type\":\"double\"}]}]" +
				"},{\"name\":\"entities\",\"doc\":\"Optional list of entity identifiers that are at this" +
				" feature\",\"default\":null,\"type\":[\"null\",{\"type\":\"array\",\"items\":\"string\"}]},{\"na" +
				"me\":\"address\",\"doc\":\"Optional address information of the feature\",\"default\":null" +
				",\"type\":[\"null\",{\"type\":\"record\",\"name\":\"Address\",\"namespace\":\"eu.driver.model.s" +
				"im.support\",\"fields\":[{\"name\":\"street\",\"doc\":\"Optional street name\",\"default\":nu" +
				"ll,\"type\":[\"null\",\"string\"]},{\"name\":\"houseNumber\",\"doc\":\"Optional house number\"" +
				",\"default\":null,\"type\":[\"null\",\"int\"]},{\"name\":\"houseLetter\",\"doc\":\"Optional hou" +
				"se letter\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"postalCode\",\"doc\":\"" +
				"Optional postal code\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"city\",\"d" +
				"oc\":\"Optional name of the city\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\"" +
				":\"state\",\"doc\":\"Optional name of the state or province\",\"default\":null,\"type\":[\"" +
				"null\",\"string\"]},{\"name\":\"country\",\"doc\":\"Optional name of the country\",\"default" +
				"\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"tags\",\"doc\":\"Optional map containing a" +
				"ddress specific information: key – unique name of the specific property; value –" +
				" value of that property\",\"default\":null,\"type\":[\"null\",{\"type\":\"map\",\"values\":\"s" +
				"tring\"}]}]}]},{\"name\":\"title\",\"doc\":\"Optional title of the feature (as defined b" +
				"y the simplestyle specification)\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"nam" +
				"e\":\"markerSize\",\"doc\":\"Optional size of the style marker (as defined by the simp" +
				"lestyle specification)\",\"default\":null,\"type\":[\"null\",{\"type\":\"enum\",\"name\":\"Mar" +
				"kerSize\",\"namespace\":\"eu.driver.model.sim.support\",\"symbols\":[\"small\",\"medium\",\"" +
				"large\"]}]},{\"name\":\"markerSymbol\",\"doc\":\"Optional symbol to display in the cente" +
				"r of the style marker (as defined by the simplestyle specification). Allowed val" +
				"ues include an Icon ID, an integer 0 through 9, a lowercase character a through " +
				"z\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"markerColor\",\"doc\":\"Optiona" +
				"l color of the style marker (as defined by the simplestyle specification). This " +
				"value should be a string-encoded hexadecimal value for the red, green and blue i" +
				"ntensity of the desired color (in that order)\",\"default\":null,\"type\":[\"null\",\"st" +
				"ring\"]},{\"name\":\"stroke\",\"doc\":\"Optional color of a line as part of a GeoJSON ge" +
				"ometry (as defined by the simplestyle specification). This value should be a str" +
				"ing-encoded hexadecimal value for the red, green and blue intensity of the desir" +
				"ed color (in that order)\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"stro" +
				"keOpacity\",\"doc\":\"Optional opacity of the line as part of a GeoJSON geometry (as" +
				" defined by the simplestyle specification), ranging from [0, 1]\",\"default\":null," +
				"\"type\":[\"null\",\"float\"]},{\"name\":\"strokeWidth\",\"doc\":\"The width of the line as p" +
				"art of a GeoJSON geometry (as defined by the simplestyle specification), ranging" +
				" from [0, infinity)\",\"default\":null,\"type\":[\"null\",\"float\"]},{\"name\":\"fill\",\"doc" +
				"\":\"Optional color of the GeoJSON geometry (as defined by the simplestyle specifi" +
				"cation). This value should be a string-encoded hexadecimal value for the red, gr" +
				"een and blue intensity of the desired color (in that order)\",\"default\":null,\"typ" +
				"e\":[\"null\",\"string\"]},{\"name\":\"fillOpacity\",\"doc\":\"Optional opacity of the GeoJS" +
				"ON geometry (as defined by the simplestyle specification), ranging from [0, 1]\"," +
				"\"default\":null,\"type\":[\"null\",\"float\"]}]}]},{\"name\":\"bbox\",\"doc\":\"Optional bound" +
				"ing box around the feature in the following order [west, south, east, north]. Le" +
				"ngth(bbox)=2xn, where n is the number of dimensions represented in the contained" +
				" geometry, with all axes of the most south-westerly point followed by all axes o" +
				"f the more north-easterly point. The axes order of a bbox follows the axes order" +
				" of the geometry. The bbox values define shapes with edges that follow lines of " +
				"constant longitude, latitude, and elevation\",\"default\":null,\"type\":[\"null\",{\"typ" +
				"e\":\"array\",\"items\":\"double\"}]}]}");
		private eu.driver.model.sim.support.geojson.FeatureType _type;
		/// <summary>
		/// The geometry (as defined by the GeoJSON standard): Point – a point; MultiPoint – a collection of points; LineString – a collection of points forming a line; MultiLineString – a collection of lines; Polygon – a collection of points forming an area; MultiPolygon – a collection of areas; GeometryCollection – a collection of any of the types above
		/// </summary>
		private object _geometry;
		/// <summary>
		/// Optional feature specific properties (as defined by the GeoJSON standard)
		/// </summary>
		private eu.driver.model.sim.support.geojson.Properties _properties;
		/// <summary>
		/// Optional bounding box around the feature in the following order [west, south, east, north]. Length(bbox)=2xn, where n is the number of dimensions represented in the contained geometry, with all axes of the most south-westerly point followed by all axes of the more north-easterly point. The axes order of a bbox follows the axes order of the geometry. The bbox values define shapes with edges that follow lines of constant longitude, latitude, and elevation
		/// </summary>
		private IList<System.Double> _bbox;
		public virtual Schema Schema
		{
			get
			{
				return Feature._SCHEMA;
			}
		}
		public eu.driver.model.sim.support.geojson.FeatureType type
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
		/// The geometry (as defined by the GeoJSON standard): Point – a point; MultiPoint – a collection of points; LineString – a collection of points forming a line; MultiLineString – a collection of lines; Polygon – a collection of points forming an area; MultiPolygon – a collection of areas; GeometryCollection – a collection of any of the types above
		/// </summary>
		public object geometry
		{
			get
			{
				return this._geometry;
			}
			set
			{
				this._geometry = value;
			}
		}
		/// <summary>
		/// Optional feature specific properties (as defined by the GeoJSON standard)
		/// </summary>
		public eu.driver.model.sim.support.geojson.Properties properties
		{
			get
			{
				return this._properties;
			}
			set
			{
				this._properties = value;
			}
		}
		/// <summary>
		/// Optional bounding box around the feature in the following order [west, south, east, north]. Length(bbox)=2xn, where n is the number of dimensions represented in the contained geometry, with all axes of the most south-westerly point followed by all axes of the more north-easterly point. The axes order of a bbox follows the axes order of the geometry. The bbox values define shapes with edges that follow lines of constant longitude, latitude, and elevation
		/// </summary>
		public IList<System.Double> bbox
		{
			get
			{
				return this._bbox;
			}
			set
			{
				this._bbox = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.type;
			case 1: return this.geometry;
			case 2: return this.properties;
			case 3: return this.bbox;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.type = (eu.driver.model.sim.support.geojson.FeatureType)fieldValue; break;
			case 1: this.geometry = (System.Object)fieldValue; break;
			case 2: this.properties = (eu.driver.model.sim.support.geojson.Properties)fieldValue; break;
			case 3: this.bbox = (IList<System.Double>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
