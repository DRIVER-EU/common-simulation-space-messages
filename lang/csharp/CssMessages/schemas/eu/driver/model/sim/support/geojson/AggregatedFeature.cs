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
	
	public partial class AggregatedFeature : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"AggregatedFeature\",\"namespace\":\"eu.driver.model.sim.supp" +
				"ort.geojson\",\"fields\":[{\"name\":\"type\",\"default\":\"Feature\",\"type\":{\"type\":\"enum\"," +
				"\"name\":\"FeatureType\",\"namespace\":\"eu.driver.model.sim.support.geojson\",\"symbols\"" +
				":[\"Feature\"]}},{\"name\":\"geometry\",\"doc\":\"The geometry (as defined by the GeoJSON" +
				" standard): Point – a point; MultiPoint – a collection of points; LineString – a" +
				" collection of points forming a line; MultiLineString – a collection of lines; P" +
				"olygon – a collection of points forming an area; MultiPolygon – a collection of " +
				"areas; GeometryCollection – a collection of any of the types above\",\"default\":nu" +
				"ll,\"type\":[\"null\",{\"type\":\"record\",\"name\":\"Point\",\"namespace\":\"eu.driver.model.s" +
				"im.support.geojson.geometry\",\"fields\":[{\"name\":\"type\",\"default\":\"Point\",\"type\":{" +
				"\"type\":\"enum\",\"name\":\"PointType\",\"namespace\":\"eu.driver.model.sim.support.geojso" +
				"n.geometry\",\"symbols\":[\"Point\"]}},{\"name\":\"coordinates\",\"type\":{\"type\":\"array\",\"" +
				"items\":\"double\"}}]},{\"type\":\"record\",\"name\":\"MultiPoint\",\"namespace\":\"eu.driver." +
				"model.sim.support.geojson.geometry\",\"fields\":[{\"name\":\"type\",\"default\":\"MultiPoi" +
				"nt\",\"type\":{\"type\":\"enum\",\"name\":\"MultiPointType\",\"namespace\":\"eu.driver.model.s" +
				"im.support.geojson.geometry\",\"symbols\":[\"MultiPoint\"]}},{\"name\":\"coordinates\",\"t" +
				"ype\":{\"type\":\"array\",\"items\":{\"type\":\"array\",\"items\":\"double\"}}}]},{\"type\":\"reco" +
				"rd\",\"name\":\"LineString\",\"namespace\":\"eu.driver.model.sim.support.geojson.geometr" +
				"y\",\"fields\":[{\"name\":\"type\",\"default\":\"LineString\",\"type\":{\"type\":\"enum\",\"name\":" +
				"\"LineStringType\",\"namespace\":\"eu.driver.model.sim.support.geojson.geometry\",\"sym" +
				"bols\":[\"LineString\"]}},{\"name\":\"coordinates\",\"type\":{\"type\":\"array\",\"items\":{\"ty" +
				"pe\":\"array\",\"items\":\"double\"}}}]},{\"type\":\"record\",\"name\":\"MultiLineString\",\"nam" +
				"espace\":\"eu.driver.model.sim.support.geojson.geometry\",\"fields\":[{\"name\":\"type\"," +
				"\"default\":\"MultiLineString\",\"type\":{\"type\":\"enum\",\"name\":\"MultiLineStringType\",\"" +
				"namespace\":\"eu.driver.model.sim.support.geojson.geometry\",\"symbols\":[\"MultiLineS" +
				"tring\"]}},{\"name\":\"coordinates\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"array\",\"" +
				"items\":{\"type\":\"array\",\"items\":\"double\"}}}}]},{\"type\":\"record\",\"name\":\"Polygon\"," +
				"\"namespace\":\"eu.driver.model.sim.support.geojson.geometry\",\"fields\":[{\"name\":\"ty" +
				"pe\",\"default\":\"Polygon\",\"type\":{\"type\":\"enum\",\"name\":\"PolygonType\",\"namespace\":\"" +
				"eu.driver.model.sim.support.geojson.geometry\",\"symbols\":[\"Polygon\"]}},{\"name\":\"c" +
				"oordinates\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"array\",\"items\":\"double\"}}}]}" +
				",{\"type\":\"record\",\"name\":\"MultiPolygon\",\"namespace\":\"eu.driver.model.sim.support" +
				".geojson.geometry\",\"fields\":[{\"name\":\"type\",\"default\":\"MultiPolygon\",\"type\":{\"ty" +
				"pe\":\"enum\",\"name\":\"MultiPolygonType\",\"namespace\":\"eu.driver.model.sim.support.ge" +
				"ojson.geometry\",\"symbols\":[\"MultiPolygon\"]}},{\"name\":\"coordinates\",\"type\":{\"type" +
				"\":\"array\",\"items\":{\"type\":\"array\",\"items\":{\"type\":\"array\",\"items\":\"double\"}}}}]}" +
				"]},{\"name\":\"properties\",\"doc\":\"Optional feature specific properties (as defined " +
				"by the GeoJSON standard)\",\"default\":null,\"type\":[\"null\",{\"type\":\"record\",\"name\":" +
				"\"Properties\",\"namespace\":\"eu.driver.model.sim.support.geojson\",\"fields\":[{\"name\"" +
				":\"id\",\"doc\":\"Unique case-insensitive identifier of the feature\",\"type\":\"string\"}" +
				",{\"name\":\"name\",\"doc\":\"Optional name of the feature\",\"default\":null,\"type\":[\"nul" +
				"l\",\"string\"]},{\"name\":\"description\",\"doc\":\"Optional description of the feature\"," +
				"\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"type\",\"doc\":\"Optional type of " +
				"the feature\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"tags\",\"doc\":\"Opti" +
				"onal map containing feature specific information: key – unique name of the speci" +
				"fic property; value – value of that property\",\"default\":null,\"type\":[\"null\",{\"ty" +
				"pe\":\"map\",\"values\":\"string\"}]},{\"name\":\"orientation\",\"doc\":\"Optional orientation" +
				" of the feature\",\"default\":null,\"type\":[\"null\",{\"type\":\"record\",\"name\":\"Orientat" +
				"ion\",\"namespace\":\"eu.driver.model.sim.support\",\"fields\":[{\"name\":\"yaw\",\"doc\":\"In" +
				" decimal degrees, ranging from [0, 360) where 0 is pointing towards the geograph" +
				"ic north. The yaw value is applied in a clockwise rotation over the item’s headi" +
				"ng/yaw-axis. A yaw value of 90 makes the item face east, while a yaw of 270 make" +
				"s it face west\",\"type\":\"double\"},{\"name\":\"pitch\",\"doc\":\"In decimal degrees, rang" +
				"ing from [-90, 90] where 0 is perpendicular to the line crossing the item’s loca" +
				"tion and the centre of the WGS84-based ellipsoid. The pitch value is applied in " +
				"a counter-clockwise rotation over the item’s pitch-axis. A pitch value of 45 mak" +
				"es the item face 45 degrees upwards, while a pitch of -20 makes it face 20 degre" +
				"es downwards\",\"type\":\"double\"},{\"name\":\"roll\",\"doc\":\"In decimal degrees, ranging" +
				" from (-180, 180] where 0 is perpendicular to the line crossing the item’s locat" +
				"ion and the centre of the WGS84-based ellipsoid. The roll value is applied in a " +
				"clockwise rotation over the item’s roll/bank-axis. A roll value of 45 makes the " +
				"item roll 45 degrees to the right, while a roll of -50 makes it roll 50 degrees " +
				"to the left\",\"type\":\"double\"}]}]},{\"name\":\"entities\",\"doc\":\"Optional list of ent" +
				"ity identifiers that are at this feature\",\"default\":null,\"type\":[\"null\",{\"type\":" +
				"\"array\",\"items\":\"string\"}]},{\"name\":\"address\",\"doc\":\"Optional address informatio" +
				"n of the feature\",\"default\":null,\"type\":[\"null\",{\"type\":\"record\",\"name\":\"Address" +
				"\",\"namespace\":\"eu.driver.model.sim.support\",\"fields\":[{\"name\":\"street\",\"doc\":\"Op" +
				"tional street name\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"houseNumbe" +
				"r\",\"doc\":\"Optional house number\",\"default\":null,\"type\":[\"null\",\"int\"]},{\"name\":\"" +
				"houseLetter\",\"doc\":\"Optional house letter\",\"default\":null,\"type\":[\"null\",\"string" +
				"\"]},{\"name\":\"postalCode\",\"doc\":\"Optional postal code\",\"default\":null,\"type\":[\"nu" +
				"ll\",\"string\"]},{\"name\":\"city\",\"doc\":\"Optional name of the city\",\"default\":null,\"" +
				"type\":[\"null\",\"string\"]},{\"name\":\"state\",\"doc\":\"Optional name of the state or pr" +
				"ovince\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"country\",\"doc\":\"Option" +
				"al name of the country\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"tags\"," +
				"\"doc\":\"Optional map containing address specific information: key – unique name o" +
				"f the specific property; value – value of that property\",\"default\":null,\"type\":[" +
				"\"null\",{\"type\":\"map\",\"values\":\"string\"}]}]}]},{\"name\":\"title\",\"doc\":\"Optional ti" +
				"tle of the feature (as defined by the simplestyle specification)\",\"default\":null" +
				",\"type\":[\"null\",\"string\"]},{\"name\":\"markerSize\",\"doc\":\"Optional size of the styl" +
				"e marker (as defined by the simplestyle specification)\",\"default\":null,\"type\":[\"" +
				"null\",{\"type\":\"enum\",\"name\":\"MarkerSize\",\"namespace\":\"eu.driver.model.sim.suppor" +
				"t\",\"symbols\":[\"small\",\"medium\",\"large\"]}]},{\"name\":\"markerSymbol\",\"doc\":\"Optiona" +
				"l symbol to display in the center of the style marker (as defined by the simples" +
				"tyle specification). Allowed values include an Icon ID, an integer 0 through 9, " +
				"a lowercase character a through z\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"na" +
				"me\":\"markerColor\",\"doc\":\"Optional color of the style marker (as defined by the s" +
				"implestyle specification). This value should be a string-encoded hexadecimal val" +
				"ue for the red, green and blue intensity of the desired color (in that order)\",\"" +
				"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"stroke\",\"doc\":\"Optional color o" +
				"f a line as part of a GeoJSON geometry (as defined by the simplestyle specificat" +
				"ion). This value should be a string-encoded hexadecimal value for the red, green" +
				" and blue intensity of the desired color (in that order)\",\"default\":null,\"type\":" +
				"[\"null\",\"string\"]},{\"name\":\"strokeOpacity\",\"doc\":\"Optional opacity of the line a" +
				"s part of a GeoJSON geometry (as defined by the simplestyle specification), rang" +
				"ing from [0, 1]\",\"default\":null,\"type\":[\"null\",\"float\"]},{\"name\":\"strokeWidth\",\"" +
				"doc\":\"The width of the line as part of a GeoJSON geometry (as defined by the sim" +
				"plestyle specification), ranging from [0, infinity)\",\"default\":null,\"type\":[\"nul" +
				"l\",\"float\"]},{\"name\":\"fill\",\"doc\":\"Optional color of the GeoJSON geometry (as de" +
				"fined by the simplestyle specification). This value should be a string-encoded h" +
				"exadecimal value for the red, green and blue intensity of the desired color (in " +
				"that order)\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"fillOpacity\",\"doc" +
				"\":\"Optional opacity of the GeoJSON geometry (as defined by the simplestyle speci" +
				"fication), ranging from [0, 1]\",\"default\":null,\"type\":[\"null\",\"float\"]}]}]},{\"na" +
				"me\":\"bbox\",\"doc\":\"Optional bounding box around the feature in the following orde" +
				"r [west, south, east, north]. Length(bbox)=2xn, where n is the number of dimensi" +
				"ons represented in the contained geometry, with all axes of the most south-weste" +
				"rly point followed by all axes of the more north-easterly point. The axes order " +
				"of a bbox follows the axes order of the geometry. The bbox values define shapes " +
				"with edges that follow lines of constant longitude, latitude, and elevation\",\"de" +
				"fault\":null,\"type\":[\"null\",{\"type\":\"array\",\"items\":\"double\"}]}]}");
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
				return AggregatedFeature._SCHEMA;
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
