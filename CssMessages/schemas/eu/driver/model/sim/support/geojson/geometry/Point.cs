// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace eu.driver.model.sim.support.geojson.geometry
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class Point : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""Point"",""namespace"":""eu.driver.model.sim.support.geojson.geometry"",""fields"":[{""name"":""type"",""default"":""Point"",""type"":{""type"":""enum"",""name"":""PointType"",""namespace"":""eu.driver.model.sim.support.geojson.geometry"",""symbols"":[""Point""]}},{""name"":""coordinates"",""type"":{""type"":""array"",""items"":""double""}}]}");
		private eu.driver.model.sim.support.geojson.geometry.PointType _type;
		private IList<System.Double> _coordinates;
		public virtual Schema Schema
		{
			get
			{
				return Point._SCHEMA;
			}
		}
		public eu.driver.model.sim.support.geojson.geometry.PointType type
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
		public IList<System.Double> coordinates
		{
			get
			{
				return this._coordinates;
			}
			set
			{
				this._coordinates = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.type;
			case 1: return this.coordinates;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.type = (eu.driver.model.sim.support.geojson.geometry.PointType)fieldValue; break;
			case 1: this.coordinates = (IList<System.Double>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
