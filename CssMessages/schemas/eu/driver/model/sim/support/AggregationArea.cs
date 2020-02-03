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
	
	public partial class AggregationArea : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"AggregationArea\",\"namespace\":\"eu.driver.model.sim.suppor" +
				"t\",\"fields\":[{\"name\":\"id\",\"doc\":\"Unique identifier of the aggregation update\",\"t" +
				"ype\":\"string\"},{\"name\":\"map\",\"doc\":\"Map containing key-value pairs, all with uni" +
				"que keys: key – unique identifier of the area; value – specific aggregated area " +
				"properties\",\"type\":{\"type\":\"map\",\"values\":{\"type\":\"record\",\"name\":\"AggrArea\",\"na" +
				"mespace\":\"eu.driver.model.sim.support.aggr\",\"fields\":[{\"name\":\"boundary\",\"doc\":\"" +
				"Optional list of locations, creating an edge between every consecutive location " +
				"in the list. An additional edge is created between the last location in the list" +
				" and the first location in the list, closing of the area. The smallest shape cre" +
				"ated by this boundary defines the area\",\"default\":null,\"type\":[\"null\",{\"type\":\"a" +
				"rray\",\"items\":{\"type\":\"record\",\"name\":\"Location\",\"namespace\":\"eu.driver.model.si" +
				"m.support\",\"fields\":[{\"name\":\"latitude\",\"doc\":\"In decimal degrees, ranging from " +
				"[-90, 90] where 0 is the equator\",\"type\":\"double\"},{\"name\":\"longitude\",\"doc\":\"In" +
				" decimal degrees, ranging from (-180, 180] where 0 is the Prime Meridian (line g" +
				"oing through the geographic north, Greenwich, and the geographic south)\",\"type\":" +
				"\"double\"},{\"name\":\"altitude\",\"doc\":\"Optional in meters, where 0 is the surface o" +
				"f the WGS84-based ellipsoid\",\"default\":null,\"type\":[\"null\",\"double\"]}]}}]},{\"nam" +
				"e\":\"name\",\"doc\":\"Optional name of the area\",\"default\":null,\"type\":[\"null\",\"strin" +
				"g\"]},{\"name\":\"tags\",\"doc\":\"Optional map containing area specific information: ke" +
				"y – unique name of the specific property; value – value of that property\",\"defau" +
				"lt\":null,\"type\":[\"null\",{\"type\":\"map\",\"values\":\"string\"}]}]}}},{\"name\":\"timestam" +
				"p\",\"doc\":\"Optional UNIX Epoch time in milliseconds marking the time the aggregat" +
				"ed update was performed\",\"default\":null,\"type\":[\"null\",\"long\"],\"logicalType\":\"ti" +
				"mestamp-millis\"}],\"_comment\":\"\"}");
		/// <summary>
		/// Unique identifier of the aggregation update
		/// </summary>
		private string _id;
		/// <summary>
		/// Map containing key-value pairs, all with unique keys: key – unique identifier of the area; value – specific aggregated area properties
		/// </summary>
		private IDictionary<string,eu.driver.model.sim.support.aggr.AggrArea> _map;
		/// <summary>
		/// Optional UNIX Epoch time in milliseconds marking the time the aggregated update was performed
		/// </summary>
		private System.Nullable<long> _timestamp;
		public virtual Schema Schema
		{
			get
			{
				return AggregationArea._SCHEMA;
			}
		}
		/// <summary>
		/// Unique identifier of the aggregation update
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
		/// Map containing key-value pairs, all with unique keys: key – unique identifier of the area; value – specific aggregated area properties
		/// </summary>
		public IDictionary<string,eu.driver.model.sim.support.aggr.AggrArea> map
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
			case 1: this.map = (IDictionary<string,eu.driver.model.sim.support.aggr.AggrArea>)fieldValue; break;
			case 2: this.timestamp = (System.Nullable<long>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
