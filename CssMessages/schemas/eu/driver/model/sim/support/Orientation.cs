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
	
	public partial class Orientation : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""Orientation"",""namespace"":""eu.driver.model.sim.support"",""fields"":[{""name"":""yaw"",""doc"":""In decimal degrees, ranging from [0, 360) where 0 is pointing towards the geographic north. The yaw value is applied in a clockwise rotation over the item’s heading/yaw-axis. A yaw value of 90 makes the item face east, while a yaw of 270 makes it face west"",""type"":""double""},{""name"":""pitch"",""doc"":""In decimal degrees, ranging from [-90, 90] where 0 is perpendicular to the line crossing the item’s location and the centre of the WGS84-based ellipsoid. The pitch value is applied in a counter-clockwise rotation over the item’s pitch-axis. A pitch value of 45 makes the item face 45 degrees upwards, while a pitch of -20 makes it face 20 degrees downwards"",""type"":""double""},{""name"":""roll"",""doc"":""In decimal degrees, ranging from (-180, 180] where 0 is perpendicular to the line crossing the item’s location and the centre of the WGS84-based ellipsoid. The roll value is applied in a clockwise rotation over the item’s roll/bank-axis. A roll value of 45 makes the item roll 45 degrees to the right, while a roll of -50 makes it roll 50 degrees to the left"",""type"":""double""}]}");
		/// <summary>
		/// In decimal degrees, ranging from [0, 360) where 0 is pointing towards the geographic north. The yaw value is applied in a clockwise rotation over the item’s heading/yaw-axis. A yaw value of 90 makes the item face east, while a yaw of 270 makes it face west
		/// </summary>
		private double _yaw;
		/// <summary>
		/// In decimal degrees, ranging from [-90, 90] where 0 is perpendicular to the line crossing the item’s location and the centre of the WGS84-based ellipsoid. The pitch value is applied in a counter-clockwise rotation over the item’s pitch-axis. A pitch value of 45 makes the item face 45 degrees upwards, while a pitch of -20 makes it face 20 degrees downwards
		/// </summary>
		private double _pitch;
		/// <summary>
		/// In decimal degrees, ranging from (-180, 180] where 0 is perpendicular to the line crossing the item’s location and the centre of the WGS84-based ellipsoid. The roll value is applied in a clockwise rotation over the item’s roll/bank-axis. A roll value of 45 makes the item roll 45 degrees to the right, while a roll of -50 makes it roll 50 degrees to the left
		/// </summary>
		private double _roll;
		public virtual Schema Schema
		{
			get
			{
				return Orientation._SCHEMA;
			}
		}
		/// <summary>
		/// In decimal degrees, ranging from [0, 360) where 0 is pointing towards the geographic north. The yaw value is applied in a clockwise rotation over the item’s heading/yaw-axis. A yaw value of 90 makes the item face east, while a yaw of 270 makes it face west
		/// </summary>
		public double yaw
		{
			get
			{
				return this._yaw;
			}
			set
			{
				this._yaw = value;
			}
		}
		/// <summary>
		/// In decimal degrees, ranging from [-90, 90] where 0 is perpendicular to the line crossing the item’s location and the centre of the WGS84-based ellipsoid. The pitch value is applied in a counter-clockwise rotation over the item’s pitch-axis. A pitch value of 45 makes the item face 45 degrees upwards, while a pitch of -20 makes it face 20 degrees downwards
		/// </summary>
		public double pitch
		{
			get
			{
				return this._pitch;
			}
			set
			{
				this._pitch = value;
			}
		}
		/// <summary>
		/// In decimal degrees, ranging from (-180, 180] where 0 is perpendicular to the line crossing the item’s location and the centre of the WGS84-based ellipsoid. The roll value is applied in a clockwise rotation over the item’s roll/bank-axis. A roll value of 45 makes the item roll 45 degrees to the right, while a roll of -50 makes it roll 50 degrees to the left
		/// </summary>
		public double roll
		{
			get
			{
				return this._roll;
			}
			set
			{
				this._roll = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.yaw;
			case 1: return this.pitch;
			case 2: return this.roll;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.yaw = (System.Double)fieldValue; break;
			case 1: this.pitch = (System.Double)fieldValue; break;
			case 2: this.roll = (System.Double)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
