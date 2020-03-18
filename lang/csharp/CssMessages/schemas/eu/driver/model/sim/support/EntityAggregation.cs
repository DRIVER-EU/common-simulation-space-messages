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
	
	public partial class EntityAggregation : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"EntityAggregation\",\"namespace\":\"eu.driver.model.sim.supp" +
				"ort\",\"fields\":[{\"name\":\"id\",\"doc\":\"Unique case-insensitive identifier of the agg" +
				"regation update\",\"type\":\"string\"},{\"name\":\"map\",\"doc\":\"Map containing key-value " +
				"pairs, all with unique keys: key – unique case-insensitive identifier of the ent" +
				"ity; value – entity message where all properties are optional\",\"type\":{\"type\":\"m" +
				"ap\",\"values\":[{\"type\":\"record\",\"name\":\"AggregatedItem\",\"namespace\":\"eu.driver.mo" +
				"del.sim.support\",\"fields\":[{\"name\":\"location\",\"doc\":\"Optional location of the it" +
				"em\",\"default\":null,\"type\":[\"null\",{\"type\":\"record\",\"name\":\"Location\",\"namespace\"" +
				":\"eu.driver.model.sim.support\",\"fields\":[{\"name\":\"latitude\",\"doc\":\"In decimal de" +
				"grees, ranging from [-90, 90] where 0 is the equator\",\"type\":\"double\"},{\"name\":\"" +
				"longitude\",\"doc\":\"In decimal degrees, ranging from (-180, 180] where 0 is the Pr" +
				"ime Meridian (line going through the geographic north, Greenwich, and the geogra" +
				"phic south)\",\"type\":\"double\"},{\"name\":\"altitude\",\"doc\":\"Optional in meters, wher" +
				"e 0 is the surface of the WGS84-based ellipsoid, or another agreed upon common g" +
				"round level (specified inside the configuration guidelines). A positive number i" +
				"ndicates a location outside the ellipsoid (or above the ground level), while a n" +
				"egative number indicates a location inside the ellipsoid (or below the ground le" +
				"vel). If an altitude is not provided, it is presumed that the location is at the" +
				" ground level of the provided latitude and longitude coordinates\",\"default\":null" +
				",\"type\":[\"null\",\"double\"]}]}]},{\"name\":\"orientation\",\"doc\":\"Optional orientation" +
				" of the item\",\"default\":null,\"type\":[\"null\",{\"type\":\"record\",\"name\":\"Orientation" +
				"\",\"namespace\":\"eu.driver.model.sim.support\",\"fields\":[{\"name\":\"yaw\",\"doc\":\"In de" +
				"cimal degrees, ranging from [0, 360) where 0 is pointing towards the geographic " +
				"north. The yaw value is applied in a clockwise rotation over the item’s heading/" +
				"yaw-axis. A yaw value of 90 makes the item face east, while a yaw of 270 makes i" +
				"t face west\",\"type\":\"double\"},{\"name\":\"pitch\",\"doc\":\"In decimal degrees, ranging" +
				" from [-90, 90] where 0 is perpendicular to the line crossing the item’s locatio" +
				"n and the centre of the WGS84-based ellipsoid. The pitch value is applied in a c" +
				"ounter-clockwise rotation over the item’s pitch-axis. A pitch value of 45 makes " +
				"the item face 45 degrees upwards, while a pitch of -20 makes it face 20 degrees " +
				"downwards\",\"type\":\"double\"},{\"name\":\"roll\",\"doc\":\"In decimal degrees, ranging fr" +
				"om (-180, 180] where 0 is perpendicular to the line crossing the item’s location" +
				" and the centre of the WGS84-based ellipsoid. The roll value is applied in a clo" +
				"ckwise rotation over the item’s roll/bank-axis. A roll value of 45 makes the ite" +
				"m roll 45 degrees to the right, while a roll of -50 makes it roll 50 degrees to " +
				"the left\",\"type\":\"double\"}]}]},{\"name\":\"velocity\",\"doc\":\"Optional velocity of th" +
				"e item\",\"default\":null,\"type\":[\"null\",{\"type\":\"record\",\"name\":\"Velocity\",\"namesp" +
				"ace\":\"eu.driver.model.sim.support\",\"fields\":[{\"name\":\"yaw\",\"doc\":\"In decimal deg" +
				"rees, ranging from [0, 360) where 0 is pointing towards the geographic north. Th" +
				"e yaw value is applied in a clockwise rotation over the item’s heading/yaw-axis." +
				" A yaw value of 90 makes the item face east, while a yaw of 270 makes it face we" +
				"st\",\"type\":\"double\"},{\"name\":\"pitch\",\"doc\":\"In decimal degrees, ranging from [-9" +
				"0, 90] where 0 is perpendicular to the line crossing the item’s location and the" +
				" centre of the WGS84-based ellipsoid. The pitch value is applied in a counter-cl" +
				"ockwise rotation over the item’s pitch-axis. A pitch value of 45 makes the item " +
				"face 45 degrees upwards, while a pitch of -20 makes it face 20 degrees downwards" +
				"\",\"type\":\"double\"},{\"name\":\"magnitude\",\"doc\":\"In meter per seconds, ranging from" +
				" [0, infinity) where 0 is standing still relative to the earth’s rotation\",\"type" +
				"\":\"double\"}]}]},{\"name\":\"name\",\"doc\":\"Optional name of the item\",\"default\":null," +
				"\"type\":[\"null\",\"string\"]},{\"name\":\"description\",\"doc\":\"Optional description of t" +
				"he item\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"type\",\"doc\":\"Optional" +
				" type of the item\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"owner\",\"doc" +
				"\":\"Optional unique case-insensitive identifier of the connected application owni" +
				"ng the item\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"timestamp\",\"doc\":" +
				"\"Optional UNIX Epoch time in milliseconds marking the time the update was perfor" +
				"med\",\"default\":null,\"type\":[\"null\",\"long\"],\"logicalType\":\"timestamp-millis\"},{\"n" +
				"ame\":\"tags\",\"doc\":\"Optional map containing item specific information: key – uniq" +
				"ue name of the specific property; value – value of that property\",\"default\":null" +
				",\"type\":[\"null\",{\"type\":\"map\",\"values\":\"string\"}]},{\"name\":\"children\",\"doc\":\"Opt" +
				"ional list of item identifiers that belong to this item\",\"default\":null,\"type\":[" +
				"\"null\",{\"type\":\"array\",\"items\":\"string\"}]}]},{\"type\":\"record\",\"name\":\"Aggregated" +
				"FeatureCollection\",\"namespace\":\"eu.driver.model.sim.support\",\"fields\":[{\"name\":\"" +
				"type\",\"default\":\"FeatureCollection\",\"type\":{\"type\":\"enum\",\"name\":\"FeatureCollect" +
				"ionType\",\"namespace\":\"eu.driver.model.sim.support.geojson\",\"symbols\":[\"FeatureCo" +
				"llection\"]}},{\"name\":\"features\",\"default\":null,\"type\":[\"null\",{\"type\":\"array\",\"i" +
				"tems\":{\"type\":\"record\",\"name\":\"AggregatedFeature\",\"namespace\":\"eu.driver.model.s" +
				"im.support.geojson\",\"fields\":[{\"name\":\"type\",\"default\":\"Feature\",\"type\":{\"type\":" +
				"\"enum\",\"name\":\"FeatureType\",\"namespace\":\"eu.driver.model.sim.support.geojson\",\"s" +
				"ymbols\":[\"Feature\"]}},{\"name\":\"geometry\",\"doc\":\"The geometry (as defined by the " +
				"GeoJSON standard): Point – a point; MultiPoint – a collection of points; LineStr" +
				"ing – a collection of points forming a line; MultiLineString – a collection of l" +
				"ines; Polygon – a collection of points forming an area; MultiPolygon – a collect" +
				"ion of areas; GeometryCollection – a collection of any of the types above\",\"defa" +
				"ult\":null,\"type\":[\"null\",{\"type\":\"record\",\"name\":\"Point\",\"namespace\":\"eu.driver." +
				"model.sim.support.geojson.geometry\",\"fields\":[{\"name\":\"type\",\"default\":\"Point\",\"" +
				"type\":{\"type\":\"enum\",\"name\":\"PointType\",\"namespace\":\"eu.driver.model.sim.support" +
				".geojson.geometry\",\"symbols\":[\"Point\"]}},{\"name\":\"coordinates\",\"type\":{\"type\":\"a" +
				"rray\",\"items\":\"double\"}}]},{\"type\":\"record\",\"name\":\"MultiPoint\",\"namespace\":\"eu." +
				"driver.model.sim.support.geojson.geometry\",\"fields\":[{\"name\":\"type\",\"default\":\"M" +
				"ultiPoint\",\"type\":{\"type\":\"enum\",\"name\":\"MultiPointType\",\"namespace\":\"eu.driver." +
				"model.sim.support.geojson.geometry\",\"symbols\":[\"MultiPoint\"]}},{\"name\":\"coordina" +
				"tes\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"array\",\"items\":\"double\"}}}]},{\"type" +
				"\":\"record\",\"name\":\"LineString\",\"namespace\":\"eu.driver.model.sim.support.geojson." +
				"geometry\",\"fields\":[{\"name\":\"type\",\"default\":\"LineString\",\"type\":{\"type\":\"enum\"," +
				"\"name\":\"LineStringType\",\"namespace\":\"eu.driver.model.sim.support.geojson.geometr" +
				"y\",\"symbols\":[\"LineString\"]}},{\"name\":\"coordinates\",\"type\":{\"type\":\"array\",\"item" +
				"s\":{\"type\":\"array\",\"items\":\"double\"}}}]},{\"type\":\"record\",\"name\":\"MultiLineStrin" +
				"g\",\"namespace\":\"eu.driver.model.sim.support.geojson.geometry\",\"fields\":[{\"name\":" +
				"\"type\",\"default\":\"MultiLineString\",\"type\":{\"type\":\"enum\",\"name\":\"MultiLineString" +
				"Type\",\"namespace\":\"eu.driver.model.sim.support.geojson.geometry\",\"symbols\":[\"Mul" +
				"tiLineString\"]}},{\"name\":\"coordinates\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"a" +
				"rray\",\"items\":{\"type\":\"array\",\"items\":\"double\"}}}}]},{\"type\":\"record\",\"name\":\"Po" +
				"lygon\",\"namespace\":\"eu.driver.model.sim.support.geojson.geometry\",\"fields\":[{\"na" +
				"me\":\"type\",\"default\":\"Polygon\",\"type\":{\"type\":\"enum\",\"name\":\"PolygonType\",\"names" +
				"pace\":\"eu.driver.model.sim.support.geojson.geometry\",\"symbols\":[\"Polygon\"]}},{\"n" +
				"ame\":\"coordinates\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"array\",\"items\":\"doubl" +
				"e\"}}}]},{\"type\":\"record\",\"name\":\"MultiPolygon\",\"namespace\":\"eu.driver.model.sim." +
				"support.geojson.geometry\",\"fields\":[{\"name\":\"type\",\"default\":\"MultiPolygon\",\"typ" +
				"e\":{\"type\":\"enum\",\"name\":\"MultiPolygonType\",\"namespace\":\"eu.driver.model.sim.sup" +
				"port.geojson.geometry\",\"symbols\":[\"MultiPolygon\"]}},{\"name\":\"coordinates\",\"type\"" +
				":{\"type\":\"array\",\"items\":{\"type\":\"array\",\"items\":{\"type\":\"array\",\"items\":\"double" +
				"\"}}}}]}]},{\"name\":\"properties\",\"doc\":\"Optional feature specific properties (as d" +
				"efined by the GeoJSON standard)\",\"default\":null,\"type\":[\"null\",{\"type\":\"record\"," +
				"\"name\":\"Properties\",\"namespace\":\"eu.driver.model.sim.support.geojson\",\"fields\":[" +
				"{\"name\":\"id\",\"doc\":\"Unique case-insensitive identifier of the feature\",\"type\":\"s" +
				"tring\"},{\"name\":\"name\",\"doc\":\"Optional name of the feature\",\"default\":null,\"type" +
				"\":[\"null\",\"string\"]},{\"name\":\"description\",\"doc\":\"Optional description of the fe" +
				"ature\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"type\",\"doc\":\"Optional t" +
				"ype of the feature\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"tags\",\"doc" +
				"\":\"Optional map containing feature specific information: key – unique name of th" +
				"e specific property; value – value of that property\",\"default\":null,\"type\":[\"nul" +
				"l\",{\"type\":\"map\",\"values\":\"string\"}]},{\"name\":\"orientation\",\"doc\":\"Optional orie" +
				"ntation of the feature\",\"default\":null,\"type\":[\"null\",\"eu.driver.model.sim.suppo" +
				"rt.Orientation\"]},{\"name\":\"entities\",\"doc\":\"Optional list of entity identifiers " +
				"that are at this feature\",\"default\":null,\"type\":[\"null\",{\"type\":\"array\",\"items\":" +
				"\"string\"}]},{\"name\":\"address\",\"doc\":\"Optional address information of the feature" +
				"\",\"default\":null,\"type\":[\"null\",{\"type\":\"record\",\"name\":\"Address\",\"namespace\":\"e" +
				"u.driver.model.sim.support\",\"fields\":[{\"name\":\"street\",\"doc\":\"Optional street na" +
				"me\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"houseNumber\",\"doc\":\"Option" +
				"al house number\",\"default\":null,\"type\":[\"null\",\"int\"]},{\"name\":\"houseLetter\",\"do" +
				"c\":\"Optional house letter\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"pos" +
				"talCode\",\"doc\":\"Optional postal code\",\"default\":null,\"type\":[\"null\",\"string\"]},{" +
				"\"name\":\"city\",\"doc\":\"Optional name of the city\",\"default\":null,\"type\":[\"null\",\"s" +
				"tring\"]},{\"name\":\"state\",\"doc\":\"Optional name of the state or province\",\"default" +
				"\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"country\",\"doc\":\"Optional name of the c" +
				"ountry\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"tags\",\"doc\":\"Optional " +
				"map containing address specific information: key – unique name of the specific p" +
				"roperty; value – value of that property\",\"default\":null,\"type\":[\"null\",{\"type\":\"" +
				"map\",\"values\":\"string\"}]}]}]},{\"name\":\"title\",\"doc\":\"Optional title of the featu" +
				"re (as defined by the simplestyle specification)\",\"default\":null,\"type\":[\"null\"," +
				"\"string\"]},{\"name\":\"markerSize\",\"doc\":\"Optional size of the style marker (as def" +
				"ined by the simplestyle specification)\",\"default\":null,\"type\":[\"null\",{\"type\":\"e" +
				"num\",\"name\":\"MarkerSize\",\"namespace\":\"eu.driver.model.sim.support\",\"symbols\":[\"s" +
				"mall\",\"medium\",\"large\"]}]},{\"name\":\"markerSymbol\",\"doc\":\"Optional symbol to disp" +
				"lay in the center of the style marker (as defined by the simplestyle specificati" +
				"on). Allowed values include an Icon ID, an integer 0 through 9, a lowercase char" +
				"acter a through z\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"markerColor" +
				"\",\"doc\":\"Optional color of the style marker (as defined by the simplestyle speci" +
				"fication). This value should be a string-encoded hexadecimal value for the red, " +
				"green and blue intensity of the desired color (in that order)\",\"default\":null,\"t" +
				"ype\":[\"null\",\"string\"]},{\"name\":\"stroke\",\"doc\":\"Optional color of a line as part" +
				" of a GeoJSON geometry (as defined by the simplestyle specification). This value" +
				" should be a string-encoded hexadecimal value for the red, green and blue intens" +
				"ity of the desired color (in that order)\",\"default\":null,\"type\":[\"null\",\"string\"" +
				"]},{\"name\":\"strokeOpacity\",\"doc\":\"Optional opacity of the line as part of a GeoJ" +
				"SON geometry (as defined by the simplestyle specification), ranging from [0, 1]\"" +
				",\"default\":null,\"type\":[\"null\",\"float\"]},{\"name\":\"strokeWidth\",\"doc\":\"The width " +
				"of the line as part of a GeoJSON geometry (as defined by the simplestyle specifi" +
				"cation), ranging from [0, infinity)\",\"default\":null,\"type\":[\"null\",\"float\"]},{\"n" +
				"ame\":\"fill\",\"doc\":\"Optional color of the GeoJSON geometry (as defined by the sim" +
				"plestyle specification). This value should be a string-encoded hexadecimal value" +
				" for the red, green and blue intensity of the desired color (in that order)\",\"de" +
				"fault\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"fillOpacity\",\"doc\":\"Optional opac" +
				"ity of the GeoJSON geometry (as defined by the simplestyle specification), rangi" +
				"ng from [0, 1]\",\"default\":null,\"type\":[\"null\",\"float\"]}]}]},{\"name\":\"bbox\",\"doc\"" +
				":\"Optional bounding box around the feature in the following order [west, south, " +
				"east, north]. Length(bbox)=2xn, where n is the number of dimensions represented " +
				"in the contained geometry, with all axes of the most south-westerly point follow" +
				"ed by all axes of the more north-easterly point. The axes order of a bbox follow" +
				"s the axes order of the geometry. The bbox values define shapes with edges that " +
				"follow lines of constant longitude, latitude, and elevation\",\"default\":null,\"typ" +
				"e\":[\"null\",{\"type\":\"array\",\"items\":\"double\"}]}]}}]},{\"name\":\"name\",\"doc\":\"Option" +
				"al name of the feature collection\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"na" +
				"me\":\"description\",\"doc\":\"Optional description of the feature collection\",\"defaul" +
				"t\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"owner\",\"doc\":\"Optional unique case-in" +
				"sensitive identifier of the connected application owning the feature collection\"" +
				",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"timestamp\",\"doc\":\"Optional UN" +
				"IX Epoch time in milliseconds marking the time the update was performed\",\"defaul" +
				"t\":null,\"type\":[\"null\",\"long\"],\"logicalType\":\"timestamp-millis\"},{\"name\":\"tags\"," +
				"\"doc\":\"Optional map containing feature collection specific information: key – un" +
				"ique name of the specific property; value – value of that property\",\"default\":nu" +
				"ll,\"type\":[\"null\",{\"type\":\"map\",\"values\":\"string\"}]},{\"name\":\"bbox\",\"doc\":\"Optio" +
				"nal bounding box around the feature collection in the following order [west, sou" +
				"th, east, north]. Length(bbox)=2xn, where n is the number of dimensions represen" +
				"ted in the contained geometries, with all axes of the most south-westerly point " +
				"followed by all axes of the more north-easterly point. The axes order of a bbox " +
				"follows the axes order of the geometries. The bbox values define shapes with edg" +
				"es that follow lines of constant longitude, latitude, and elevation\",\"default\":n" +
				"ull,\"type\":[\"null\",{\"type\":\"array\",\"items\":\"double\"}]}]},{\"type\":\"record\",\"name\"" +
				":\"AggregatedPost\",\"namespace\":\"eu.driver.model.sim.support\",\"fields\":[{\"name\":\"b" +
				"ody\",\"doc\":\"Body text of the post\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"na" +
				"me\":\"header\",\"doc\":\"Optional header information of the post\",\"default\":null,\"typ" +
				"e\":[\"null\",{\"type\":\"record\",\"name\":\"AggregatedHeader\",\"namespace\":\"eu.driver.mod" +
				"el.sim.support\",\"fields\":[{\"name\":\"from\",\"doc\":\"Sender of the post\",\"default\":nu" +
				"ll,\"type\":[\"null\",\"string\"]},{\"name\":\"date\",\"doc\":\"UNIX Epoch time in millisecon" +
				"ds marking the time the post was published/updated\",\"default\":null,\"type\":[\"null" +
				"\",\"long\"],\"logicalType\":\"timestamp-millis\"},{\"name\":\"to\",\"doc\":\"Optional list of" +
				" recipients of the post\",\"default\":null,\"type\":[\"null\",{\"type\":\"array\",\"items\":\"" +
				"string\"}]},{\"name\":\"cc\",\"doc\":\"Optional list of recipients in carbon copy of the" +
				" post\",\"default\":null,\"type\":[\"null\",{\"type\":\"array\",\"items\":\"string\"}]},{\"name\"" +
				":\"bcc\",\"doc\":\"Optional list of recipients in blind carbon copy of the post\",\"def" +
				"ault\":null,\"type\":[\"null\",{\"type\":\"array\",\"items\":\"string\"}]},{\"name\":\"subject\"," +
				"\"doc\":\"Optional subject of the post\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"" +
				"name\":\"intro\",\"doc\":\"Optional introductory text of the post\",\"default\":null,\"typ" +
				"e\":[\"null\",\"string\"]},{\"name\":\"attachments\",\"doc\":\"Optional map of (references t" +
				"o) attachments inside the post: key – unique reference to the attachment (e.g. U" +
				"RI) or complete string-encoded attachment; value – media type of the attachment " +
				"(e.g. .pdf, .png, .zip)\",\"default\":null,\"type\":[\"null\",{\"type\":\"map\",\"values\":\"s" +
				"tring\"}]},{\"name\":\"location\",\"doc\":\"Optional location of the sender of the post\"" +
				",\"default\":null,\"type\":[\"null\",\"Location\"]}]}]},{\"name\":\"name\",\"doc\":\"Optional n" +
				"ame of the post\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"type\",\"doc\":\"" +
				"Optional type of the post\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"own" +
				"er\",\"doc\":\"Optional unique case-insensitive identifier of the connected applicat" +
				"ion owning the post\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"timestamp" +
				"\",\"doc\":\"Optional UNIX Epoch time in milliseconds marking the time the update wa" +
				"s performed\",\"default\":null,\"type\":[\"null\",\"long\"],\"logicalType\":\"timestamp-mill" +
				"is\"},{\"name\":\"tags\",\"doc\":\"Optional map containing post specific information: ke" +
				"y – unique name of the specific property; value – value of that property\",\"defau" +
				"lt\":null,\"type\":[\"null\",{\"type\":\"map\",\"values\":\"string\"}]}]}]}},{\"name\":\"timesta" +
				"mp\",\"doc\":\"Optional UNIX Epoch time in milliseconds marking the time the aggrega" +
				"ted update was performed\",\"default\":null,\"type\":[\"null\",\"long\"],\"logicalType\":\"t" +
				"imestamp-millis\"}]}");
		/// <summary>
		/// Unique case-insensitive identifier of the aggregation update
		/// </summary>
		private string _id;
		/// <summary>
		/// Map containing key-value pairs, all with unique keys: key – unique case-insensitive identifier of the entity; value – entity message where all properties are optional
		/// </summary>
		private IDictionary<string,System.Object> _map;
		/// <summary>
		/// Optional UNIX Epoch time in milliseconds marking the time the aggregated update was performed
		/// </summary>
		private System.Nullable<long> _timestamp;
		public virtual Schema Schema
		{
			get
			{
				return EntityAggregation._SCHEMA;
			}
		}
		/// <summary>
		/// Unique case-insensitive identifier of the aggregation update
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
		/// Map containing key-value pairs, all with unique keys: key – unique case-insensitive identifier of the entity; value – entity message where all properties are optional
		/// </summary>
		public IDictionary<string,System.Object> map
		{
			get
			{
				return this._map;
			}
			set
			{
				this._map = value;
			}
		}
		/// <summary>
		/// Optional UNIX Epoch time in milliseconds marking the time the aggregated update was performed
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
			case 1: return this.map;
			case 2: return this.timestamp;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.id = (System.String)fieldValue; break;
			case 1: this.map = (IDictionary<string,System.Object>)fieldValue; break;
			case 2: this.timestamp = (System.Nullable<long>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
